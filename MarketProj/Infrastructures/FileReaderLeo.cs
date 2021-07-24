using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;


namespace MarketProj.Infrastructures
{
    public class FileReaderLeo
    {

        public static async IAsyncEnumerable<byte[]> GetUrlsAsync()
        {
            string[] filePaths = Directory.GetFiles(@"C:\Users\Admin\Desktop\testPhtoos");
            foreach (var item in filePaths)
            {
                yield return await File.ReadAllBytesAsync(item);
            }
        }


    }
}
