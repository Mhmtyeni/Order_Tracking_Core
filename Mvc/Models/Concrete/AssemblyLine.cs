using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mvc.Models.Concrete
{
    public class AssemblyLine
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int FactoryId { get; set; }
        public Factory Factory { get; set; }
        public ICollection<SubLine> SubLines { get; set; }
    }
}
