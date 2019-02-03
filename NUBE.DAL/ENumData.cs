using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NUBE.DAL
{
    public class ENumData
    {
        public int Id { get; set; }
        public int ENumTypeId { get; set; }
        public ENumType ENumType { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
    }
}
