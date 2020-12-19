using System;
using System.IO;
using System.Net;
using System.Threading.Tasks;

namespace Mortor.Web.Data
{
    public class FileService
    {
        public async Task<string> UploadFile(byte[] imageContent, string imageName, string reportId)
        {
            var path = Path.Combine("upload", reportId);
            var uploadPathOnFs = Path.Combine("wwwroot", path);
            Directory.CreateDirectory(uploadPathOnFs);
            uploadPathOnFs = Path.Combine(uploadPathOnFs, imageName + ".png");
            await File.WriteAllBytesAsync(uploadPathOnFs, imageContent);
            return Path.Combine(path, imageName + ".png");
        }

        public void RemoveAllImagesFromReport(string reportId)
        {
            var targetPathOnFs = Path.Combine("wwwroot", "upload", reportId);
            if (Directory.Exists(targetPathOnFs))
            {
                Directory.Delete(targetPathOnFs, true);
            }
        }

        public void DeleteImage(string imagePath)
        {
            var targetPathOnFs = Path.Combine("wwwroot", imagePath);
            if (File.Exists(targetPathOnFs))
            {
                File.Delete(targetPathOnFs);
            }
        }
    }
}