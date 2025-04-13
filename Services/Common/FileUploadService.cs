
using GIT_KOREA_QA_API.Utils;

namespace GIT_KOREA_QA_API.Services.Common
{
    public class FileUploadService : IFileUploadService
    {
        //-----------------------------------------------------------------------------
        //
        //  CONSTANTS
        //
        //-----------------------------------------------------------------------------
        private readonly IConfiguration _configuration;
        private readonly string basePath; // 업로드 기본 경로

        //-----------------------------------------------------------------------------
        //
        //  CONSTRUCTOR
        //
        //-----------------------------------------------------------------------------
        public FileUploadService(IConfiguration configuration)
        {
            _configuration = configuration;
            basePath = _configuration["UploadSettings:FolderPath"] ?? "Uploads";
        }

        //-----------------------------------------------------------------------------
        //
        //  IMPLEMENTATION
        //
        //-----------------------------------------------------------------------------
        /// <summary>
        /// 파일 삭제
        /// </summary>
        /// <param name="path"></param>
        public void DeleteFile(string path)
        {
            FileUtil.DeleteFile(path);
        }

        /// <summary>
        /// 파일 업로드 처리
        /// </summary>
        /// <param name="files"></param>
        public async Task<List<FileUploadResult>> UploadFiles(List<IFormFile> files)
        {
            DirectoryInfo info = FileUtil.CreateTodayDirectory(basePath);
            List<FileUploadResult> result = new List<FileUploadResult>();

            foreach (var file in files)
            {
                try
                {
                    var fileName = FileUtil.GetRandomFileName(file);
                    var filePath = await FileUtil.CopyFile(info, fileName, file); // 지정디렉토리에 파일을 저장한다.

                    result.Add(new FileUploadResult
                    {
                        OriginalFileName = file.FileName,
                        SavedFileName = fileName,
                        FileSize = file.Length,
                        FilePath = filePath,
                        //bytes = FileUtil.ToByteArray(file),
                        md5 = FileUtil.GetChecksum(filePath),
                        ContentType = file.ContentType,
                        UploadedAt = DateTime.Now,
                        IsSuccess = true
                    });
                } catch (Exception ex) {
                    result.Add(new FileUploadResult
                    {
                        OriginalFileName = file.FileName,
                        FileSize = file.Length,
                        ContentType = file.ContentType,
                        UploadedAt = DateTime.Now,
                        Error = ex.Message,
                        IsSuccess = false
                    });
                }
            }

            return result;
        }
    }

    /// <summary>
    /// 파일 업로드 결과 모델
    /// </summary>
    public class FileUploadResult
    {
        /// <summary>
        /// 파일원본명
        /// </summary>
        public required string OriginalFileName { get; set; }

        /// <summary>
        /// 저장된 파일명
        /// </summary>
        public string? SavedFileName { get; set; }

        /// <summary>
        /// File의 ByteArray
        /// </summary>
        public byte[]? bytes { get; set; }

        /// <summary>
        /// MD5 Checksum
        /// </summary>
        public string? md5 { get; set; }

        /// <summary>
        /// 파일크기(byte)
        /// </summary>
        public long FileSize { get; set; }

        /// <summary>
        /// 저장된 파일 경로
        /// </summary>
        public string? FilePath { get; set; }

        /// <summary>
        /// 컨텐츠 타입
        /// </summary>
        public required string ContentType { get; set; }

        /// <summary>
        /// 업로드 시간
        /// </summary>
        public DateTime? UploadedAt { get; set; }

        /// <summary>
        /// 업로드 실패 사유
        /// </summary>
        public string? Error { get; set; }

        /// <summary>
        /// 업로드 성공여부
        /// </summary>
        public bool IsSuccess { get; set; } = true;
    }
}
