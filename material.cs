using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using softchape.bdchapacoDataSetTableAdapters;

namespace softchape{
    class material{
        materialTableAdapter tam = new materialTableAdapter();
        public int cantidad;
        public double costo;
        public material(int x){
            cantidad = Convert.ToInt32(tam.f_cantidad(x));
            costo = Convert.ToInt32(tam.f_costo(x));
        }
        public int get_cantidad(){
            return cantidad;
        }
        public double get_costo(){
            return costo;
        }
    }
}
