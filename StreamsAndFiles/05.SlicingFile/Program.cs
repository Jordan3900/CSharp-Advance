using System;
using System.Collections.Generic;
using System.IO;
namespace _05.SlicingFile
{
    class Program
    {
        private static List<string> fileParts = new List<string>();

        static void Main(string[] args)
        {
            int partsCount = int.Parse(Console.ReadLine());

            SliceFileParts(partsCount);

            AssembleFileFromParts();
        }

        private static void AssembleFileFromParts()
        {
            var buffer = new byte[4096];

            using (var assembledVideo = new FileStream("sliceMe.mp4",FileMode.Create))
            {
                for (int i = 0; i < fileParts.Count; i++)
                {
                    using (var reader = new FileStream(fileParts[i], FileMode.Open))
                    {
                        while (true)
                        {
                            int readBytes = reader.Read(buffer, 0, buffer.Length);

                            if (readBytes == 0)
                            {
                                break;
                            }
                            assembledVideo.Write(buffer, 0, readBytes);
                        }
                    }
                }
            }
        }

        private static void SliceFileParts(int partsCount)
        {
            Console.WriteLine($"Slicing file 'sliceMe.mp4' into {partsCount}");

            var buffer = new byte[4096];

            using (var sourceFile = new FileStream("sliceMe.mp4", FileMode.Open))
            {
                var partSize = Math.Ceiling((double)sourceFile.Length / partsCount);

                for (int i = 1; i <= partsCount; i++)
                {
                    var filePartName = $"Part-{i}.mp4";

                    fileParts.Add(filePartName);

                    using (var destinationFile = new FileStream(filePartName, FileMode.Create))
                    {
                        int totalBytes = 0;

                        while (totalBytes < partSize)
                        {
                            int readBytes = sourceFile.Read(buffer, 0, buffer.Length);
                            if (readBytes == 0)
                            {
                                break;
                            }
                            destinationFile.Write(buffer, 0, readBytes);
                            totalBytes += readBytes;
                        }
                    }
                }
            }
        }
    }
}
