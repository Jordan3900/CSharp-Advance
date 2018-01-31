using System;
using System.IO;
namespace _04.CopyBinaryFile
{
    class Program
    {
        static void Main(string[] args)
        {
            var filePath = "copyMe.png";
            var copyFilePath = "copyMeCopy.png";

            using (var sourceFile = new FileStream(filePath, FileMode.Open))
            {
                using (var copyFile = new FileStream(copyFilePath, FileMode.Create))
                {
                    byte[] buffer = new byte[4096];

                    while (true)
                    {
                        int readBytes = sourceFile.Read(buffer, 0, buffer.Length);

                        if (readBytes == 0)
                            break;

                        copyFile.Write(buffer, 0, readBytes);
                    }

                }
            }
        }
    }
}
