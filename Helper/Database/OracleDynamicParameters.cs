using Dapper;
using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace GIT_KOREA_QA_API.Helper.Database
{
    public class OracleDynamicParameters : SqlMapper.IDynamicParameters
    {
        private readonly Dictionary<string, OracleParameter> _parameters = new Dictionary<string, OracleParameter>();

        /// <summary>
        /// 파라미터 추가
        /// </summary>
        /// <param name="name"></param>
        /// <param name="value"></param>
        /// <param name="dbType"></param>
        /// <param name="direction"></param>
        /// <param name="size"></param>
        public void Add(string name, object? value = null, OracleDbType? dbType = null, ParameterDirection? direction = null, int? size = null)
        {
            var parameter = new OracleParameter
            {
                ParameterName = name,
                Value = value ?? DBNull.Value,
                Direction = direction ?? ParameterDirection.Input
            };

            if (dbType.HasValue)
                parameter.OracleDbType = dbType.Value;

            if (size.HasValue)
                parameter.Size = size.Value;

            _parameters[name] = parameter;
        }

        /// <summary>
        /// 파라미터 가져오기
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="name"></param>
        /// <returns></returns>
        public T? Get<T>(string name)
        {
            var value = _parameters[name].Value;
            if (value == DBNull.Value)
                return default;

            return (T)Convert.ChangeType(value, typeof(T));
        }

        public void AddParameters(IDbCommand command, SqlMapper.Identity identity)
        {
            var oracleCommand = (OracleCommand)command;
            foreach (var parameter in _parameters.Values)
            {
                oracleCommand.Parameters.Add(parameter);
            }
        }
    }
}
