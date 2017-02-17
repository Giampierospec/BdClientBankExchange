using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrestamoBancarioPosiblementeConBd
{
    public class Cliente
    {
        public Cliente(string nmc, string cdc)
        {
            NomCliente = nmc;
            CedCliente = cdc;
        }
        public Cliente(string nmc, string cdc, List<PrestamosMensuales> pa)
        {
            NomCliente = nmc;
            CedCliente = cdc;
            PrestamoAsignado = pa;

        }
        public string NomCliente { get; set; }
        public string CedCliente { get; set; }
        public List<PrestamosMensuales> PrestamoAsignado { get; set; }
    }

}
