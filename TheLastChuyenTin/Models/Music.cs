using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheLastChuyenTin.Models
{
    public class Music
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Singer { get; set; }
        public string Link { get; set; }
        public bool IsShown { get; set; } = false;
    }
}
