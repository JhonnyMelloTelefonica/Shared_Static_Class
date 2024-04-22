using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Text;

namespace Shared_Static_Class.Converters
{
    public static class SharedConverter
    {
        public static byte[] ConvertFile(byte[] Unconvertedfiles)
        {
            try
            {
                byte[] decompressedBytes;
                using (MemoryStream memoryStream = new MemoryStream(Unconvertedfiles))
                {
                    using (GZipStream gzipStream = new GZipStream(memoryStream, CompressionMode.Decompress))
                    {
                        using (MemoryStream decompressedStream = new MemoryStream())
                        {
                            gzipStream.CopyTo(decompressedStream);
                            decompressedBytes = decompressedStream.ToArray();
                        }
                    }
                }

                return decompressedBytes;
            }
            catch
            {
                return null;
            }
        }
        public static string ConvertFileToString(byte[] Unconvertedfiles)
        {
            try
            {
                byte[] decompressedBytes;
                using (MemoryStream memoryStream = new MemoryStream(Unconvertedfiles))
                {
                    using (GZipStream gzipStream = new GZipStream(memoryStream, CompressionMode.Decompress))
                    {
                        using (MemoryStream decompressedStream = new MemoryStream())
                        {
                            gzipStream.CopyTo(decompressedStream);
                            decompressedBytes = decompressedStream.ToArray();
                        }
                    }
                }

                return Convert.ToBase64String(decompressedBytes);
            }
            catch
            {
                return string.Empty;
            }
        }
    }

}
