using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mvc.Models.Concrete
{
    public class SubLine
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int AssemblyLineId { get; set; }
        public AssemblyLine AssemblyLine { get; set; }
        public ICollection<WorkArea> WorkAreas { get; set; }
        public ICollection<Station> Stations { get; set; }
    }
}
