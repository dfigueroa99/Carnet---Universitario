using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wf_proyect
{
    public class estudiante : IComparable
    {
        public string nombre { get; set; }
        public string Estado { get; set; }
        public string blnombre { get; set; }
        public string blApellidoP { get; set; }
        public string blApellidoM { get; set; }
        public string blDNI { get; set; }
        public string pkfoto{ get; set; }


        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }
    }
}
