using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrestamoBancarioPosiblementeConBd
{
    public class PrestamosMensuales
    {
        public PrestamosMensuales()
        {

        }
        public PrestamosMensuales(int mes, double cuota, double intereses, double amortizacion, double capital)
        {
            Mes = mes;
            Cuota = cuota;
            Intereses = intereses;
            Amortizacion = amortizacion;
            Capital = capital;

        }
        public int Mes { get; set; }
        public double Cuota { get; set; }
        public double Intereses { get; set; }
        public double Amortizacion { get; set; }
        public double Capital { get; set; }

        public void MostrarDatos(List<PrestamosMensuales> svData)
        {
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("Mes\t| Pago\t\t| Intereses\t\t| Amortizacion\t\t| Saldo");


            foreach (PrestamosMensuales pr in svData)
            {

                Console.Write(pr.Mes + "\t| ");
                Console.Write("{0:C} \t\t|", Math.Round(pr.Cuota, 2));
                Console.Write("{0:C} \t\t|", Math.Round(pr.Intereses, 2));
                Console.Write("{0:C} \t\t|", Math.Round(pr.Amortizacion, 2));
                Console.WriteLine("{0:C}", Math.Round(pr.Capital, 2));
            }
            Console.WriteLine("--------------------------------------------------------");
        }
    }
}

