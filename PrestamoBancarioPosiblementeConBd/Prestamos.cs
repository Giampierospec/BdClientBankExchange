using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrestamoBancarioPosiblementeConBd
{
    public class Prestamos
    {
        
            public double Capital
            {
                get
                {
                    return this.cap;
                }
                set
                {
                    this.cap = value;
                }
            }

            public double Tasa
            {
                get
                {
                    return this.tasa;
                }
                set
                {
                    this.tasa = value;
                }
            }
            public double Plazo
            {
                get
                {
                    return this.plazo;
                }
                set
                {
                    this.plazo = value;
                }
            }
            public double Cuota
            {
                get
                {
                    return PagoPer();
                }
            }


            double cap, tasa, plazo;

            public double PagoPer()
            {
                tasa = (tasa / 12) / 100;
                double result = cap * (tasa / (1 - Math.Pow((1 + this.tasa), -plazo)));
                return result;
            }



            public List<PrestamosMensuales> TablaAmortizacion(double tasa)
            {
                List<PrestamosMensuales> svData = new List<PrestamosMensuales>();
                Plazo *= 12;
                double pago = Cuota;
                double interesMens, amorti;
                tasa /= 1200;
                for (int i = 0; i <= Plazo; i++)
                {

                    if (i == 0)
                    {
                        svData.Add(new PrestamosMensuales(i, 0, 0, 0, cap));


                    }
                    else
                    {
                        interesMens = cap * tasa;
                        amorti = pago - interesMens;
                        cap -= amorti;
                        svData.Add(new PrestamosMensuales(i, pago, interesMens, amorti, cap));
                    }





                }
                return svData;
            }
        }
}
