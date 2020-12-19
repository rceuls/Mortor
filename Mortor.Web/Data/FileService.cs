using System;
using System.IO;
using System.Net;
using System.Threading.Tasks;

namespace Mortor.Web.Data
{
    public class FileService
    {
        public async Task<string> UploadFile(byte[] imageContent, string reportId)
        {
            var pngName = $"{Guid.NewGuid()}.png";
            var path = Path.Combine("upload", reportId);
            var uploadPathOnFs = Path.Combine("wwwroot", path);
            Directory.CreateDirectory(uploadPathOnFs);
            uploadPathOnFs = Path.Combine(uploadPathOnFs, pngName);
            await File.WriteAllBytesAsync(uploadPathOnFs, imageContent);
            return Path.Combine(path, pngName);
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