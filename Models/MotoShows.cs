using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace Moto_ShowsCore.Models
{
    public class MotoShows
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int DirectorsID { get; set; }

        public Directors Directors { get; set; }
        public ICollection<Subdivisions> Subdivisions { get; set; }
        public ICollection<Cars> Cars { get; set; }
    } 
}
