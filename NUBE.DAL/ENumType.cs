using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NUBE.DAL
{
    public class ENumType
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public List<ENumData> ENumDatas { get; set; }
    }
}
