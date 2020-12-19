using System.IO;
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
    }
}