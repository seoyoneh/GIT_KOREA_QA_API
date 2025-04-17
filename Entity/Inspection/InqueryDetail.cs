using GIT_KOREA_QA_API.Helper.Database;
using Oracle.ManagedDataAccess.Client;
using System.Data;
using System.Reflection.Metadata;

namespace GIT_KOREA_QA_API.Entity.Inspection
{
    /// <summary>
    /// 서연이화 검사기준서 화면
    /// </summary>
    public class Inquery_SeoyonehResult
    {
        public required string Serial { get; set; }
        /// <summary>
        /// 이름
        /// </summary>
        public required string Vincd { get; set; }

        /// <summary>
        /// 권한
        /// </summary>
        public required string Linecd { get; set; }

        /// <summary>
        /// 권한
        /// </summary>
        public required string Linenm { get; set; }

        /// <summary>
        /// 권한
        /// </summary>
        public required string JO_CHO { get; set; }

        /// <summary>
        /// 권한
        /// </summary>
        public required string JO_JUNG { get; set; }

        /// <summary>
        /// 권한
        /// </summary>
        public required string YA_CHO { get; set; }

        /// <summary>
        /// 권한
        /// </summary>
        public required string YA_JUNG { get; set; }

        public Inquery_SeoyonehResult()
        {
            Serial = string.Empty;
            Vincd = string.Empty;
            Linecd = string.Empty;
            Linenm = string.Empty;
            JO_CHO = string.Empty;
            JO_JUNG = string.Empty;
            YA_CHO = string.Empty;
            YA_JUNG = string.Empty;
        }
    }

    public class Inquery_SeoyonehIn
    {
        /// <summary>
        /// 측정일자
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Input, 100)]
        public string IN_MEAS_DATE { get; set; }

        /// <summary>
        /// Lang Set
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Input, 100)]
        public string IN_LANG_SET { get; set; }

        /// <summary>
        /// 차종코드
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Input, 100)]
        public string IN_VINCD { get; set; }

        /// <summary>
        /// 법인코드
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Input, 100)]
        public string IN_CORCD { get; set; }

        /// <summary>
        /// 사업장코드
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Input, 100)]
        public string IN_BIZCD { get; set; }

        /// <summary>
        /// 사용자아이디
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Input, 100)]
        public string IN_USERID { get; set; }

        ///// <summary>
        ///// 검사기준서 사진
        ///// </summary>
        //[OracleParameter(OracleDbType.Blob, ParameterDirection.Output)]
        //public byte[]? PPT_FILE { get; set; }

        public Inquery_SeoyonehIn()
        {
            // 기본값 초기화
            IN_CORCD = string.Empty;
            IN_BIZCD = string.Empty;
            IN_VINCD = string.Empty;
            IN_LANG_SET = string.Empty;
            IN_MEAS_DATE = string.Empty;
            IN_USERID = string.Empty;

            //PPT_FILE = Array.Empty<byte>();
        }
    }

    public class Inquery_SeoyonehOut
    {
        /// <summary>
        /// 시리얼
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output, 10)]
        public string SERIAL { get; set; }

        /// <summary>
        /// 차종코드
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output, 20)]
        public string VINCD { get; set; }

        /// <summary>
        /// 라인코드
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output, 10)]
        public string LINECD { get; set; }

        /// <summary>
        /// 라인명
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output, 20)]
        public string LINENM { get; set; }

        /// <summary>
        /// 사용자 이름
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output, 2)]
        public string JO_CHO { get; set; }

        /// <summary>
        /// 사용자 구분(T11 : 고객, T12 : 한일이화, T15 : 협력업체, T16:2차협력업체)
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output, 2)]
        public string JO_JUNG { get; set; }

        /// <summary>
        /// 인증경로(T4A : AD, T4D : DB)
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output, 2)]
        public string YA_CHO { get; set; }

        /// <summary>
        /// 관리자권한(사업장선택)
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output, 2)]
        public string? YA_JUNG { get; set; }


        /// <summary>
        /// 부서 코드
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output, 20)]
        public string DN_DIV { get; set; }

        /// <summary>
        /// 부서명
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output, 20)]
        public string DN_DIVNM { get; set; }

        /// <summary>
        /// 고객코드
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output, 20)]
        public string FML_DIV { get; set; }

        /// <summary>
        /// 업체코드
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output, 20)]
        public string FML_DIVNM { get; set; }

        /// <summary>
        /// 패스워드 오류횟수(DB인증만)
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output)]
        public string? PROD_LOTNO { get; set; }

        /// <summary>
        /// 사용자 비밀번호
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output, 2)]
        public string PROBLEM_YN { get; set; }

        /// <summary>
        /// 고객명
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output, 200)]
        public string MGRT_RESULT { get; set; }

        /// <summary>
        /// 업체명
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output, 20)]
        public string INSERT_NM { get; set; }

        /// <summary>
        /// 업체명
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output, 20)]
        public string INSERT_DATE { get; set; }

        /// <summary>
        /// 업체명
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output, 20)]
        public string UPDATE_NM { get; set; }

        /// <summary>
        /// 업체명
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output, 20)]
        public string UPDATE_DATE { get; set; }

        /// <summary>
        /// 업체명
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output, 100)]
        public string PROD_IMAGE_ID1 { get; set; }

        /// <summary>
        /// 업체명
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output, 100)]
        public string PROD_IMAGE_ID2 { get; set; }

        /// <summary>
        /// 업체명
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output, 100)]
        public string PROD_IMAGE_ID3 { get; set; }

        /// <summary>
        /// 업체명
        /// </summary>
        [OracleParameter(OracleDbType.Blob, ParameterDirection.Output)]
        public byte[]? STD_PHOTO { get; set; }

        /// <summary>
        /// 업체명
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output, 100)]
        public string PPT_FILE_NAME { get; set; }

        /// <summary>
        /// 업체명
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output, 100)]
        public string PPT_FILE_SIZE { get; set; }

        /// <summary>
        /// 업체명
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output, 100)]
        public string IMG_FILE { get; set; }

        /// <summary>
        /// 업체명
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output, 100)]
        public string IMG_FILE_NAME { get; set; }

        /// <summary>
        /// 업체명
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output, 100)]
        public string IMG_FILE_SIZE { get; set; }

        /// <summary>
        /// 업체명
        /// </summary>
        [OracleParameter(OracleDbType.Int32, ParameterDirection.Output, 100)]
        public int SEQ { get; set; }

        /// <summary>
        /// 업체명
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output, 100)]
        public string PROD_IMAGE { get; set; }

        /// <summary>
        /// 업체명
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output, 100)]
        public string PROD_IMAGE2 { get; set; }

        /// <summary>
        /// 업체명
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output, 100)]
        public string PROD_IMAGE3 { get; set; }

        /// <summary>
        /// 업체명
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output, 100)]
        public string STD_PHOTO_FILEID { get; set; }

        public Inquery_SeoyonehOut()
        {
            // 기본값 초기화
            SERIAL = string.Empty;
            VINCD = string.Empty;
            LINECD = string.Empty;
            LINENM = string.Empty;
            JO_CHO = string.Empty;
            JO_JUNG = string.Empty;
            YA_CHO = string.Empty;
            YA_JUNG = string.Empty;

            DN_DIV = string.Empty;
            DN_DIVNM = string.Empty;
            FML_DIV = string.Empty;
            FML_DIVNM = string.Empty;
            PROD_LOTNO = string.Empty;
            PROBLEM_YN = string.Empty;
            MGRT_RESULT = string.Empty;
            INSERT_NM = string.Empty;
            INSERT_DATE = string.Empty;
            UPDATE_NM = string.Empty;
            UPDATE_DATE = string.Empty;
            PROD_IMAGE_ID1 = string.Empty;
            PROD_IMAGE_ID2 = string.Empty;
            PROD_IMAGE_ID3 = string.Empty;
            STD_PHOTO = Array.Empty<byte>();
            PPT_FILE_NAME = string.Empty;
            PPT_FILE_SIZE = string.Empty;
            IMG_FILE = string.Empty;
            IMG_FILE_NAME = string.Empty;
            IMG_FILE_SIZE = string.Empty;
            SEQ = 0;
            PROD_IMAGE = string.Empty;
            PROD_IMAGE2 = string.Empty;
            PROD_IMAGE3 = string.Empty;
            STD_PHOTO_FILEID = string.Empty;
        }
    }

    public class Inquery_VendorResult
    {
        public required string Serial { get; set; }
        /// <summary>
        /// 이름
        /// </summary>
        public required string Vincd { get; set; }

        /// <summary>
        /// 권한
        /// </summary>
        public required string MeasItem { get; set; }

        /// <summary>
        /// 권한
        /// </summary>
        public required string JO_CHO { get; set; }

        /// <summary>
        /// 권한
        /// </summary>
        public required string JO_JUNG { get; set; }

        /// <summary>
        /// 권한
        /// </summary>
        public required string YA_CHO { get; set; }

        /// <summary>
        /// 권한
        /// </summary>
        public required string YA_JUNG { get; set; }


        public Inquery_VendorResult()
        {
            Serial = string.Empty;
            Vincd = string.Empty;
            MeasItem = string.Empty;

            JO_CHO = string.Empty;
            JO_JUNG = string.Empty;
            YA_CHO = string.Empty;
            YA_JUNG = string.Empty;
        }
    }
    public class Inquery_VendorIn
    {
        /// <summary>
        /// 법인코드
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Input, 100)]
        public string IN_CORCD { get; set; }

        /// <summary>
        /// 사업장코드
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Input, 100)]
        public string IN_BIZCD { get; set; }

        /// <summary>
        /// 측정일자
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Input, 100)]
        public string IN_MEAS_DATE { get; set; }

        /// <summary>
        /// 사용자아이디
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Input, 100)]
        public string IN_USERID { get; set; }

        public Inquery_VendorIn()
        {
            // 기본값 초기화
            //IN_SERIAL = 0;
            IN_CORCD = string.Empty;
            IN_BIZCD = string.Empty;
            IN_MEAS_DATE = string.Empty;
            IN_USERID = string.Empty;

            //PPT_FILE = Array.Empty<byte>();
        }
    }
    public class Inquery_VendorOut
    {
        /// <summary>
        /// 시리얼
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output, 10)]
        public string SERIAL { get; set; }

        /// <summary>
        /// 차종코드
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output, 20)]
        public string VINCD { get; set; }

        /// <summary>
        /// 사용자 이름
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output, 2)]
        public string JO_CHO { get; set; }

        /// <summary>
        /// 사용자 구분(T11 : 고객, T12 : 한일이화, T15 : 협력업체, T16:2차협력업체)
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output, 2)]
        public string JO_JUNG { get; set; }

        /// <summary>
        /// 인증경로(T4A : AD, T4D : DB)
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output, 2)]
        public string YA_CHO { get; set; }

        /// <summary>
        /// 관리자권한(사업장선택)
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output, 2)]
        public string? YA_JUNG { get; set; }

        /// <summary>
        /// 사원 번호
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output, 20)]
        public string MEAS_ITEMNM { get; set; }

        public Inquery_VendorOut()
        {
            SERIAL = string.Empty;
            VINCD = string.Empty;
            MEAS_ITEMNM = string.Empty;
            JO_CHO = string.Empty;
            JO_JUNG = string.Empty;
            YA_CHO = string.Empty;
            YA_JUNG = string.Empty;
        }
    }

    public class Inquery_Seoyoneh_DetailResult
    {
        /// <summary>
        /// 시리얼 번호
        /// </summary>
        public required string Serial { get; set; }

        /// <summary>
        /// 측정 일자
        /// </summary>
        public required string MeasDate { get; set; }

        /// <summary>
        /// 조치 구분 코드
        /// </summary>
        public required string DnDiv { get; set; }

        /// <summary>
        /// 조치 구분명
        /// </summary>
        public required string DnDivnm { get; set; }

        /// <summary>
        /// FML 구분 코드
        /// </summary>
        public required string FmlDiv { get; set; }

        /// <summary>
        /// FML 구분명
        /// </summary>
        public required string FmlDivnm { get; set; }

        /// <summary>
        /// 제조 LOT 번호
        /// </summary>
        public required string ProdLotno { get; set; }

        /// <summary>
        /// 이상유무
        /// </summary>
        public required string ProblemYn { get; set; }

        /// <summary>
        /// MGRT 조치 결과
        /// </summary>
        public required string MgrtResult { get; set; }

        /// <summary>
        /// 최초 등록자
        /// </summary>
        public required string Insertnm { get; set; }

        /// <summary>
        /// 최초 등록일
        /// </summary>
        public required string Insertdate { get; set; }

        /// <summary>
        /// 최종 수정자
        /// </summary>
        public required string Updatenm { get; set; }

        /// <summary>
        /// 최종 수정일
        /// </summary>
        public required string Updatedate { get; set; }

        /// <summary>
        /// 제품 이미지 ID 1
        /// </summary>
        public required string ProdImageId1 { get; set; }

        /// <summary>
        /// 제품 이미지 ID 2
        /// </summary>
        public required string ProdImageId2 { get; set; }

        /// <summary>
        /// 제품 이미지 ID 3
        /// </summary>
        public required string ProdImageId3 { get; set; }

        /// <summary>
        /// 기준 사진 경로
        /// </summary>
        public required string StdPhoto { get; set; }

        /// <summary>
        /// PPT 파일명
        /// </summary>
        public required string PptFileName { get; set; }

        /// <summary>
        /// PPT 파일 크기
        /// </summary>
        public required string PptFileSize { get; set; }

        /// <summary>
        /// 이미지 파일 경로
        /// </summary>
        public required string ImgFile { get; set; }

        /// <summary>
        /// 이미지 파일명
        /// </summary>
        public required string ImgFileName { get; set; }

        /// <summary>
        /// 이미지 파일 크기
        /// </summary>
        public required string ImgFileSize { get; set; }

        /// <summary>
        /// 일련번호
        /// </summary>
        public required int Seq { get; set; }

        public Inquery_Seoyoneh_DetailResult()
        {
            Serial = string.Empty;
            MeasDate = string.Empty;
            DnDiv = string.Empty;
            DnDivnm = string.Empty;
            FmlDiv = string.Empty;
            FmlDivnm = string.Empty;
            ProdLotno = string.Empty;
            ProblemYn = string.Empty;
            MgrtResult = string.Empty;
            Insertnm = string.Empty;
            Insertdate = string.Empty;
            Updatenm = string.Empty;
            Updatedate = string.Empty;
            ProdImageId1 = string.Empty;
            ProdImageId2 = string.Empty;
            ProdImageId3 = string.Empty;
            StdPhoto = string.Empty;
            PptFileName = string.Empty;
            PptFileSize = string.Empty;
            ImgFile = string.Empty;
            ImgFileName = string.Empty;
            ImgFileSize = string.Empty;
            Seq = 0;
        }
    }

    public class Inquery_Seoyoneh_DetailIn
    {
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Input, 10)]
        public string IN_SERIAL { get; set; }

        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Input, 20)]
        public string IN_MEAS_DATE { get; set; }

        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Input, 20)]
        public string IN_LANG_SET { get; set; }

        public Inquery_Seoyoneh_DetailIn()
        {
            // 기본값 초기화
            IN_SERIAL = string.Empty;
            IN_MEAS_DATE = string.Empty;
            IN_LANG_SET = string.Empty;
        }
    }

    public class Inquery_Seoyoneh_DetailOut
    {
        /// <summary>
        /// 시리얼 번호
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output)]
        public string serial { get; set; }

        /// <summary>
        /// 측정 일자
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output)]
        public string measDate { get; set; }

        /// <summary>
        /// 조치 구분 코드
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output)]
        public string dnDiv { get; set; }

        /// <summary>
        /// 조치 구분명
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output)]
        public string dnDivNm { get; set; }

        /// <summary>
        /// FML 구분 코드
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output)]
        public string fmlDiv { get; set; }

        /// <summary>
        /// FML 구분명
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output)]
        public string fmlDivNm { get; set; }

        /// <summary>
        /// 제조 LOT 번호
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output)]
        public string prodLotNo { get; set; }

        /// <summary>
        /// 이상유무
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output)]
        public string problemYn { get; set; }

        /// <summary>
        /// MGRT 조치 결과
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output)]
        public string mgrtResult { get; set; }

        /// <summary>
        /// 최초 등록자
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output)]
        public string insertNm { get; set; }

        /// <summary>
        /// 최초 등록일자
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output)]
        public string insertDate { get; set; }

        /// <summary>
        /// 최종 수정자
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output)]
        public string updateNm { get; set; }

        /// <summary>
        /// 최종 수정일자
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output)]
        public string updateDate { get; set; }

        /// <summary>
        /// 제품 이미지 ID 1
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output)]
        public string prodImageId1 { get; set; }

        /// <summary>
        /// 제품 이미지 ID 2
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output)]
        public string prodImageId2 { get; set; }

        /// <summary>
        /// 제품 이미지 ID 3
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output)]
        public string prodImageId3 { get; set; }

        /// <summary>
        /// 기준 사진 경로
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output)]
        public string stdPhoto { get; set; }

        /// <summary>
        /// PPT 파일 이름
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output)]
        public string pptFileName { get; set; }

        /// <summary>
        /// PPT 파일 크기
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output)]
        public string pptFileSize { get; set; }

        /// <summary>
        /// 이미지 파일 경로
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output)]
        public string imgFile { get; set; }

        /// <summary>
        /// 이미지 파일 이름
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output)]
        public string imgFileName { get; set; }

        /// <summary>
        /// 이미지 파일 크기
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output)]
        public string imgFileSize { get; set; }

        /// <summary>
        /// 일련번호 (숫자형)
        /// </summary>
        [OracleParameter(OracleDbType.Int32, ParameterDirection.Output)]
        public int seq { get; set; }

        public Inquery_Seoyoneh_DetailOut()
        {
            // 기본값 초기화
            serial = string.Empty;
            measDate = string.Empty;
            dnDiv = string.Empty;
            dnDivNm = string.Empty;
            fmlDiv = string.Empty;
            fmlDivNm = string.Empty;
            prodLotNo = string.Empty;
            problemYn = string.Empty;
            mgrtResult = string.Empty;
            insertNm = string.Empty;
            insertDate = string.Empty;
            updateNm = string.Empty;
            updateDate = string.Empty;
            prodImageId1 = string.Empty;
            prodImageId2 = string.Empty;
            prodImageId3 = string.Empty;
            stdPhoto = string.Empty;
            pptFileName = string.Empty;
            pptFileSize = string.Empty;
            imgFile = string.Empty;
            imgFileName = string.Empty;
            imgFileSize = string.Empty;
            seq = 0;
        }
    }


    public class Inquery_Vendor_DetailResult
    {
        /// <summary>
        /// 시리얼 번호
        /// </summary>
        public required string Serial { get; set; }

        /// <summary>
        /// 측정 일자
        /// </summary>
        public required string MeasDate { get; set; }
        /// <summary>
        /// VIN 코드
        /// </summary>
        public required string Vincd { get; set; }

        /// <summary>
        /// 조치 구분 코드
        /// </summary>
        public required string DnDiv { get; set; }

        /// <summary>
        /// 조치 구분명
        /// </summary>
        public required string DnDivNm { get; set; }

        /// <summary>
        /// FML 구분 코드
        /// </summary>
        public required string FmlDiv { get; set; }

        /// <summary>
        /// FML 구분명
        /// </summary>
        public required string FmlDivNm { get; set; }

        /// <summary>
        /// 제조 LOT 번호
        /// </summary>
        public required string ProdLotNo { get; set; }

        /// <summary>
        /// 이상 발생 여부 (Y/N)
        /// </summary>
        public required string ProblemYn { get; set; }

        /// <summary>
        /// MGRT 결과
        /// </summary>
        public required string MgrtResult { get; set; }

        /// <summary>
        /// 최초 등록자
        /// </summary>
        public required string InsertNm { get; set; }

        /// <summary>
        /// 최초 등록일자
        /// </summary>
        public required string InsertDate { get; set; }

        /// <summary>
        /// 최종 수정자
        /// </summary>
        public required string UpdateNm { get; set; }

        /// <summary>
        /// 최종 수정일자
        /// </summary>
        public required string UpdateDate { get; set; }

        /// <summary>
        /// 제품 이미지 1 (BLOB)
        /// </summary>
        public required byte[] ProdImage1 { get; set; }

        /// <summary>
        /// 제품 이미지 2 (BLOB)
        /// </summary>
        public required byte[] ProdImage2 { get; set; }

        /// <summary>
        /// 제품 이미지 3 (BLOB)
        /// </summary>
        public required byte[] ProdImage3 { get; set; }

        /// <summary>
        /// 기준 사진 이미지 (BLOB)
        /// </summary>
        public required byte[] StdPhoto { get; set; }

        /// <summary>
        /// 기준 사진 파일 ID
        /// </summary>
        public required string StdPhotoFileId { get; set; }


        public Inquery_Vendor_DetailResult()
        {
            // 기본값 초기화
            Serial = string.Empty;
            MeasDate = string.Empty;
            Vincd = string.Empty;
            DnDiv = string.Empty;
            DnDivNm = string.Empty;
            FmlDiv = string.Empty;
            FmlDivNm = string.Empty;
            ProdLotNo = string.Empty;
            ProblemYn = string.Empty;
            MgrtResult = string.Empty;
            InsertNm = string.Empty;
            InsertDate = string.Empty;
            UpdateNm = string.Empty;
            UpdateDate = string.Empty;
            ProdImage1 = Array.Empty<byte>();
            ProdImage2 = Array.Empty<byte>();
            ProdImage3 = Array.Empty<byte>();
            StdPhoto = Array.Empty<byte>();
            StdPhotoFileId = string.Empty;
        }
    }

    public class Inquery_Vendor_DetailIn
    {
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Input, 10)]
        public string IN_SERIAL { get; set; }

        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Input, 20)]
        public string IN_MEAS_DATE { get; set; }

        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Input, 20)]
        public string IN_LANG_SET { get; set; }

        public Inquery_Vendor_DetailIn()
        {
            // 기본값 초기화
            IN_SERIAL = string.Empty;
            IN_MEAS_DATE = string.Empty;
            IN_LANG_SET = string.Empty;
        }
    }


    public class Inquery_Vendor_DetailOut
    {
        /// <summary>
        /// 시리얼 번호
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output)]
        public string Serial { get; set; }

        /// <summary>
        /// 측정일자
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output)]
        public string MeasDate { get; set; }

        /// <summary>
        /// VIN 코드
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output)]
        public string Vincd { get; set; }

        /// <summary>
        /// 조치 구분 코드
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output)]
        public string DnDiv { get; set; }

        /// <summary>
        /// 조치 구분명
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output)]
        public string DnDivNm { get; set; }

        /// <summary>
        /// FML 구분 코드
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output)]
        public string FmlDiv { get; set; }

        /// <summary>
        /// FML 구분명
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output)]
        public string FmlDivNm { get; set; }

        /// <summary>
        /// 제조 LOT 번호
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output)]
        public string ProdLotNo { get; set; }

        /// <summary>
        /// 이상 발생 여부 (Y/N)
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output)]
        public string ProblemYn { get; set; }

        /// <summary>
        /// MGRT 결과
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output)]
        public string MgrtResult { get; set; }

        /// <summary>
        /// 최초 등록자
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output)]
        public string InsertNm { get; set; }

        /// <summary>
        /// 최초 등록일자
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output)]
        public string InsertDate { get; set; }

        /// <summary>
        /// 최종 수정자
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output)]
        public string UpdateNm { get; set; }

        /// <summary>
        /// 최종 수정일자
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output)]
        public string UpdateDate { get; set; }

        /// <summary>
        /// 제품 이미지 1 (BLOB)
        /// </summary>
        [OracleParameter(OracleDbType.Blob, ParameterDirection.Output)]
        public byte[] ProdImage1 { get; set; }

        /// <summary>
        /// 제품 이미지 2 (BLOB)
        /// </summary>
        [OracleParameter(OracleDbType.Blob, ParameterDirection.Output)]
        public byte[] ProdImage2 { get; set; }

        /// <summary>
        /// 제품 이미지 3 (BLOB)
        /// </summary>
        [OracleParameter(OracleDbType.Blob, ParameterDirection.Output)]
        public byte[] ProdImage3 { get; set; }

        /// <summary>
        /// 기준 사진 이미지 (BLOB)
        /// </summary>
        [OracleParameter(OracleDbType.Blob, ParameterDirection.Output)]
        public byte[] StdPhoto { get; set; }

        /// <summary>
        /// 기준 사진 파일 ID
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output)]
        public string StdPhotoFileId { get; set; }

        public Inquery_Vendor_DetailOut()
        {
            // 기본값 초기화
            Serial = string.Empty;
            MeasDate = string.Empty;
            Vincd = string.Empty;
            DnDiv = string.Empty;
            DnDivNm = string.Empty;
            FmlDiv = string.Empty;
            FmlDivNm = string.Empty;
            ProdLotNo = string.Empty;
            ProblemYn = string.Empty;
            MgrtResult = string.Empty;
            InsertNm = string.Empty;
            InsertDate = string.Empty;
            UpdateNm = string.Empty;
            UpdateDate = string.Empty;
            ProdImage1 = Array.Empty<byte>();
            ProdImage2 = Array.Empty<byte>();
            ProdImage3 = Array.Empty<byte>();
            StdPhoto = Array.Empty<byte>();
            StdPhotoFileId = string.Empty;
        }
    }


    /// <summary>
    /// 협력사 검사기준서 화면
    /// </summary>
    public class VendorInqueryDetail
    {
        /// <summary>
        /// 시리얼
        /// </summary>
        [OracleParameter(OracleDbType.Int32, ParameterDirection.Input)]
        public int IN_SERIAL { get; set; }

        /// <summary>
        /// TODO : 주석필요
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Input, 100)]
        public string IN_YYYYMM { get; set; }

        /// <summary>
        /// TODO : 주석필요
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Input, 100)]
        public string IN_LANG_SET { get; set; }

        /// <summary>
        /// 검사기준서 사진
        /// </summary>
        [OracleParameter(OracleDbType.Blob, ParameterDirection.Output)]
        public byte[]? INSPECT_STD_PHOTO { get; set; }

        public VendorInqueryDetail()
        {
            // 기본값 초기화
            IN_SERIAL = 0;
            IN_YYYYMM = string.Empty;
            IN_LANG_SET = string.Empty;
            INSPECT_STD_PHOTO = Array.Empty<byte>();
        }
    }
}
