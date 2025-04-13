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
        /// 파일 삭제
        /// </summary>
        void DeleteFile(string path);
    }
}
