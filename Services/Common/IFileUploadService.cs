using Microsoft.AspNetCore.Mvc;

namespace GIT_KOREA_QA_API.Services.Common
{
    public interface IFileUploadService
    {
        /// <summary>
        /// 파일 업로드 처리
        /// </summary>
        /// <param name="files"></param>
        /// <returns></returns>
        Task<List<FileUploadResult>> UploadFiles(List<IFormFile> files);

        /// <summary>
        /// 파일 업로드 처리(ByteArray정보 유무 처리)
        /// </summary>
        /// <param name="files"></param>
        /// <param name="includeBytes"></param>
        /// <returns></returns>
        Task<List<FileUploadResult>> UploadFiles(List<IFormFile> files, bool includeBytes);

        /// <summary>
        /// 파일 삭제
        /// </summary>
        void DeleteFile(string path);
    }
}
