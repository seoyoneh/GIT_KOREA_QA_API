using System.Security.Cryptography;

namespace GIT_KOREA_QA_API.Utils
{
    public class FileUtil
    {
        /// <summary>
        /// 디렉토리 생성 메서드. 파라미터로 전달된 경로에 디렉토리가 없으면 생성하고 DirectoryInfo를 반환.
        /// 있으면 그냥 DirectoryInfo를 반환한다. 생성을 시도했지만 디렉토리 정보가 정상적으로 전달되지 못하면 null 반환.
        /// </summary>
        /// <param name="path">생성할 파일 경로</param>
        /// <returns>생성요청한 디렉토리의 정보</returns>
        public static DirectoryInfo CreateDirectory(string path) {
            if (Directory.Exists(path))
            {
                return new DirectoryInfo(path);
            }

            DirectoryInfo info = Directory.CreateDirectory(path);
            return info;
        }

        /// <summary>
        /// 오늘 날짜 기준(ex: Upload\20250414) 디렉토리를 생성하는 메서드
        /// </summary>
        /// <param name="basePath"></param>
        /// <returns></returns>
        public static DirectoryInfo CreateTodayDirectory(string basePath)
        {
            var dateStr = DateTime.Now.ToString("yyyyMMdd");

            return CreateDirectory(basePath + "\\" + dateStr);
        }

        /// <summary>
        /// 랜덤 파일명 생성
        /// </summary>
        /// <param name="file"></param>
        /// <returns></returns>
        public static string GetRandomFileName(IFormFile file)
        {
            var extenstion = Path.GetExtension(file.Name);
            
            return Guid.NewGuid().ToString() + extenstion;
        }

        /// <summary>
        /// 전달한 DirectoryInfo의 대상 경로에 파일을 복사해 저장하는 메서드. 업로드 한 파일 경로를 반환한다.
        /// </summary>
        /// <param name="info"></param>
        /// <param name="fileName"></param>
        /// <param name="file"></param>
        /// <returns></returns>
        public static async Task<string> CopyFile(DirectoryInfo info, string fileName, IFormFile file)
        {
            var path = Path.Combine(info.FullName, fileName);

            using(var stream = new FileStream(path, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }

            return path;
        }

        /// <summary>
        /// 파일 삭제하기
        /// </summary>
        /// <param name="filePath"></param>
        public static void DeleteFile(string filePath)
        {
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }
        }

        /// <summary>
        /// MD5체크섬 만들기
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        public static string GetChecksum(string filePath)
        {
            string checksum;

            using (var md5 = MD5.Create())
            {
                var stream = File.OpenRead(filePath);
                byte[] hash = md5.ComputeHash(stream);
                checksum = BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant(); // MD5 체크섬 생성
            }

            return checksum;
        }

        /// <summary>
        /// IFormFile 객체를 ByteArray로 변환하는 메서드
        /// </summary>
        /// <param name="file"></param>
        /// <returns></returns>
        public static byte[] ToByteArray(IFormFile file)
        {
            byte[] bytes;

            using (var ms = new MemoryStream())
            {
                file.CopyTo(ms); // 파일을 메모리 스트림으로 변환
                bytes = ms.ToArray();
            }

            return bytes;
        }
    }
}
