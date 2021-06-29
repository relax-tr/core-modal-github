using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace modal.Models
{
    public class Soru
    {

        public int no { get; set; }
        public String name { get; set; }
        public String category { get; set; }

        public List<Soru> soruList{ get; set; }

    }
}
