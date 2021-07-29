using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleInheritance {
    public class basicinfo {
        public string fn, mn, ln;
        public basicinfo() { }
        public basicinfo(string f,string m,string l) {
            fn = f;
            mn = m;
            ln = l;
        }

        public string processbasic() { 
            return "Welcome " + fn + " " + mn + " " + ln; 
        }
    }
}
