using Oracle.ManagedDataAccess.Client;
using System.Data;
using System.Reflection;

namespace GIT_KOREA_QA_API.Helper.Database
{
    public class OracleParameterAttribute : Attribute
    {
        public OracleDbType DbType { get; set; }
        public ParameterDirection Direction { get; set; }
        public int Size { get; set; }

        public OracleParameterAttribute(OracleDbType dbType = OracleDbType.Varchar2,
                                        ParameterDirection direction = ParameterDirection.Input,
                                        int size = 0)
        {
            DbType = dbType;
            Direction = direction;
            Size = size;
        }
    }

    // 모델 객체를 OracleDynamicParameters로 변환해주는 확장 메서드
    public static class OracleParameterExtensions
    {
        public static OracleDynamicParameters ToOracleParameters<T>(this T model) where T : class
        {
            var parameters = new OracleDynamicParameters();

            foreach (var prop in typeof(T).GetProperties())
            {
                // 프로퍼티 이름과 값 가져오기
                string paramName = ToSnakeCase(prop.Name);
                object value = prop.GetValue(model) == null ? "" : prop.GetValue(model)!;

                // 애트리뷰트 확인
                var attr = prop.GetCustomAttribute<OracleParameterAttribute>();
                if (attr != null)
                {
                    parameters.Add(
                        paramName,
                        value,
                        attr.DbType,
                        attr.Direction,
                        attr.Size > 0 ? attr.Size : null
                    );
                }
                else
                {
                    // 애트리뷰트가 없으면 기본값으로 추가
                    parameters.Add(paramName, value);
                }
            }

            return parameters;
        }

        // 카멜케이스나 파스칼케이스를 스네이크 케이스로 변환 (예: EmployeeName -> employee_name)
        private static string ToSnakeCase(string input)
        {
            if (string.IsNullOrEmpty(input)) return input;

            var result = new System.Text.StringBuilder();
            result.Append(char.ToLower(input[0]));

            for (int i = 1; i < input.Length; i++)
            {
                if (char.IsUpper(input[i]))
                {
                    result.Append('_');
                    result.Append(char.ToLower(input[i]));
                }
                else
                {
                    result.Append(input[i]);
                }
            }

            return result.ToString();
        }
    }

    // 결과값 매핑을 위한 확장 메서드
    public static class OracleResultExtensions
    {
        public static void MapOracleOutputs(this OracleDynamicParameters parameters, object model)
        {
            var properties = model.GetType().GetProperties();

            foreach (var prop in properties)
            {
                var attr = prop.GetCustomAttribute<OracleParameterAttribute>();
                if (attr != null && attr.Direction != ParameterDirection.Input)
                {
                    string paramName = ToSnakeCase(prop.Name);
                    var value = parameters.Get<object>(paramName);

                    if (value != null && value != DBNull.Value)
                    {
                        // 속성의 타입에 맞게 변환하여 설정
                        try
                        {
                            var convertedValue = Convert.ChangeType(value, prop.PropertyType);
                            prop.SetValue(model, convertedValue);
                        }
                        catch (Exception)
                        {
                            // 변환 실패 시 기본값 유지
                        }
                    }
                }
            }
        }

        private static string ToSnakeCase(string input)
        {
            if (string.IsNullOrEmpty(input)) return input;

            var result = new System.Text.StringBuilder();
            result.Append(char.ToLower(input[0]));

            for (int i = 1; i < input.Length; i++)
            {
                if (char.IsUpper(input[i]))
                {
                    result.Append('_');
                    result.Append(char.ToLower(input[i]));
                }
                else
                {
                    result.Append(input[i]);
                }
            }

            return result.ToString();
        }
    }
}
