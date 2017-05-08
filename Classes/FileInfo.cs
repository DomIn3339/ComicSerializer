using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComicSerializer_Test
{
    public class FileInfo
    {
        public int id { get; set; }
        public string language { get; set; }
        public string md5hash { get; set; }
        public string translator { get; set; }
        public string url_download { get; set; }
    }
}
