using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using softchape.dstablasTableAdapters;

namespace softchape{
    class material{
        TAmaterial tam = new TAmaterial();
        public int codmat;
        public int cantidad;
        public double costo;
        public material(int x) {
            cantidad = Convert.ToInt32(tam.f_cantidad(x));
            costo = Convert.ToInt32(tam.f_costo(x));
        }
        public int get_cantidad() {
            return cantidad;
        }
        public double get_costo() {
            return costo;
        }
    }   
}
