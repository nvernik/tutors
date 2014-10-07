using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tutors.Models
{
    public class UploadFilesResult
    {
        public string name { get; set; }

        public int size { get; set; }

        public string type { get; set; }

        public string url { get; set; }
    }
}