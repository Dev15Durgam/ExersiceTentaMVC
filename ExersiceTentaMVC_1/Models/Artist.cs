using ExersiceTentaMVC_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExersiceTentaMVC_1.Models
{
    class Artist
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Band { get; set; }
        public List<Song> Songs { get; set; }
    }
}
