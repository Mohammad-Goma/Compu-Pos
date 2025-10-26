using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compu_Pos.Data.Models
{
    public class Logo
    {
        public int Id { get; set; }
        public string? FileName { get; set; }         // e.g., "logo.png"
        //public string? FilePath { get; set; }         // e.g., "/images/logos/"
        public string? MimeType { get; set; }         // e.g., "image/png"
        public byte[]? ImageData { get; set; }        // Optional: store image as binary data

        public override string ToString()
        {
            return $"Logo: {FileName} ({MimeType})";
        }
    }
}
