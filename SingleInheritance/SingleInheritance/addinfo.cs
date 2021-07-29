using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleInheritance
{
   public class addinfo : basicinfo
    {
        string course;
        int year, sem;
        public addinfo(string fnm, string mnm, string lnm, string cr, int yr, int s)
        {
            fn = fnm;
            mn = mnm;
            ln = lnm;
            course = cr;
            year = yr;
            sem = s;
        }
        public string processadd()
        { return "\n" + course + " Course " + year + " Year " + sem + " Sem "; }
    }
}
