using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using MarketProj.Services.Services.Abstract;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MarketProj.Infrastructures
{
    public class CloudinaryImageUploader : IImageUploader<ImageUploadResult>
    {
        private const string CloudName = "dnvzblymb";
        private const string ApiKey = "247968345686149";
        private const string ApiSecret = "juLhuud83o42qh79GD1XJK5KIY8";
        private readonly Cloudinary _cloudinary;
        private readonly Account _account;
        public CloudinaryImageUploader()
        {
            _account = new Account() { ApiKey = ApiKey, ApiSecret = ApiSecret, Cloud = CloudName };
            _cloudinary = new Cloudinary(_account);
        }
        public async Task<ImageUploadResult> Upload(string uniqueName, byte[] image, int? width, int? height)
        {
            var collection = FileReaderLeo.GetUrlsAsync().GetAsyncEnumerator();

            ImageUploadResult mainUploadImage=null;

            while (await collection.MoveNextAsync())
            {
                using var stream = new MemoryStream();

                stream.Write(collection.Current, 0, collection.Current.Length); ;

                ImageUploadParams @params=new ImageUploadParams();

                if (width != null || height != null)
                    @params = new ImageUploadParams()
                    {
                        File = new FileDescription(uniqueName,stream),
                        PublicId = uniqueName
                    };

                 @params.Transformation = new Transformation();


                if (width != null)
                    @params.Transformation.Crop("scale").Width(width);
                if (height != null)
                    @params.Transformation.Crop("scale").Height(height);



                mainUploadImage = await _cloudinary.UploadAsync(@params);
                
            }
            return mainUploadImage;
        }
    }
}
