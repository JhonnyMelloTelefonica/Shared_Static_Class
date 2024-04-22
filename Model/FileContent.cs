using System;
using System.Collections.Generic;
using System.Text;

namespace Shared_Static_Class.Models
{
    public class FileContent
    {
        public FileContent(bool enableRangeProcessing, string fileDownloadName, string contentType, byte[] fileContents)
        {
            EnableRangeProcessing = enableRangeProcessing;
            FileDownloadName = fileDownloadName;
            ContentType = contentType;
            FileContents = fileContents;
        }

        public bool EnableRangeProcessing { get; set; }
        public string FileDownloadName { get; set; } = string.Empty;
        public string ContentType { get; set; } = string.Empty;
        public byte[] FileContents { get; set; } = new byte[0];
    }
}
