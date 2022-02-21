using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using NetStateSpeed.Query;
namespace NetStateSpeed
{
    class FormattingAddress
    {

        private static List<Task<bool>> tasks = new List<Task<bool>>();

        private static List<string> ImageUrls(string urlServer)
        {
            
            var imageSizes = new List<string> { "350", "500", "750", "1000", "1500" };

            var imageUrls = new List<string>();

            foreach (var imageSize in imageSizes)
            {
                var imageUrl = urlServer.Replace("upload.php", $"random{imageSize}x{imageSize}.jpg");
                imageUrls.AddRange(Enumerable.Repeat(imageUrl, 4));
            }
            return imageUrls;

        }

        private static string UploadPayload()
        {
            const string chars = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            var payload = "content1=";
            var numIterations = 524288 / chars.Length;
            for (var iter = 0; iter < numIterations; iter++)
            {
                payload += chars;
            }
            return payload;
        }



        public static List<Task<bool>> GetSpeedBytesUp(string server)
        {
            var payload = UploadPayload();

            var numUploadThreads = 50;

            //var tasks = new List<Task<bool>>();

            for (var task = 0; task < numUploadThreads; task++)

                tasks.Add(new SpeedTestUploadQuery().GetUploadRes(server, payload));

            return tasks;

        }

        public static List<Task<bool>> GetSpeedBytesDown(string urlServer)
        {
           
            var imagesUrls = ImageUrls(urlServer).ToList();
            
            var task = imagesUrls.Select(url => new SpeedTestDownloadQuery().GetDownloadSpeed(url)).ToList();

            return task;
         
        }

    }   
}
