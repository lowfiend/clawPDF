using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clawSoft.clawPDF.Core.Settings
{
    public class Pfile
    {
        public List<PfileResult> result { get; set; }
    }

    public class PfileResult
    {
        public string UUID { get; set; }
        public String PFILE { get; set; }
    }
}
