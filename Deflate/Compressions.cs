using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Compression;
using OOTP.Attributes;

    [Extension(".dflt")]
    public class Compressions
    {
        public static void Compress(string sourceFile)
        {
            using (FileStream sourceStream = new FileStream(sourceFile, FileMode.OpenOrCreate))
            {
                using (FileStream targetStream = File.Create(sourceFile + ".dflt"))
                {
                    using (DeflateStream compressionStream = new DeflateStream(targetStream, CompressionMode.Compress))
                    {
                        sourceStream.CopyTo(compressionStream);
                    }
                }
            }
        }
        public static void Decompress(string compressedFile)
        {
            using (FileStream sourceStream = new FileStream(compressedFile, FileMode.OpenOrCreate))
            {
                using (FileStream targetStream = File.Create(compressedFile.Substring(0, compressedFile.Length - 5)))
                {
                    using (DeflateStream decompressionStream = new DeflateStream(sourceStream, CompressionMode.Decompress))
                    {
                        decompressionStream.CopyTo(targetStream);
                    }
                }
            }
        }
    }
