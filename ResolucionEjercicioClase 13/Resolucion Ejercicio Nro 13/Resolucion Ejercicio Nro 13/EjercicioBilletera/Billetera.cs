using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resolucion_Ejercicio_Nro_13.EjercicioBilletera
{
    internal class Billetera
    {
        public int BilletesDe10 { get; set; }
        public int BilletesDe20 { get; set; }
        public int BilletesDe50 { get; set; }
        public int BilletesDe100 { get; set; }
        public int BilletesDe200 { get; set; }
        public int BilletesDe500 { get; set; }
        public int BilletesDe1000 { get; set; }

        public Billetera(int billetesDe10, int billetesDe20, int billetesDe50, int billetesDe100, int billetesDe200, int billetesDe500, int billetesDe1000) {
            BilletesDe10 = billetesDe10;
            BilletesDe20 = billetesDe20;
            BilletesDe50 = billetesDe50;
            BilletesDe100 = billetesDe100;
            BilletesDe200 = billetesDe200;
            BilletesDe500 = billetesDe500;
            BilletesDe1000 = billetesDe1000;

        }
        public int Total()
        {
            int total = BilletesDe10 * 10 + BilletesDe20 * 20 + BilletesDe50 * 50 + BilletesDe100 * 100 + BilletesDe200 * 200 + BilletesDe500 * 500 + BilletesDe1000 + 1000;
            return total;
        }

    }
}