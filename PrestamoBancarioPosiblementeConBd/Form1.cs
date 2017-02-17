using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrestamoBancarioPosiblementeConBd
{
    public partial class PrestamoBanc : Form
    {
        PrestamosMensuales pm = new PrestamosMensuales();
        Prestamos pr = new Prestamos();
        List<Cliente> cl = new List<Cliente>();
        public PrestamoBanc()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            infoPrestamoClientePanel.Hide();
            bsClientePanel.Hide();

        }

        private void agregarPrestamo_Click(object sender, EventArgs e)
        {


            if (nomCliente.Text != "" && cedCliente.Text != "" && capitalPrestamo.Text != "" && plazoPrestamo.Text != "" && tasaPrestamo.Text != "")
            {
                
                string nomCl = nomCliente.Text.ToLower();
                string cedCl = cedCliente.Text.ToLower();

                pr.Capital = double.Parse(capitalPrestamo.Text);
                pr.Plazo = (double)plazoPrestamo.Value;
                pr.Tasa = double.Parse(tasaPrestamo.Text);
                


                /*foreach (PrestamosMensuales cli in svData)
                {
                    tablaAmortizacion.Rows.Add(cli.Mes, Math.Round(cli.Cuota, 2), Math.Round(cli.Intereses, 2), Math.Round(cli.Amortizacion, 2), Math.Round(cli.Capital, 2));
                }
                tablaAmortizacion.Show();*/

                
                string selClienteQuery = "SELECT * FROM CLIENTE WHERE nombreCliente = '" + nomCl+"'";

                int countCliente = BdPosible.QuerySelector(selClienteQuery);




                if (countCliente > 0)
                {
                    MessageBox.Show("Cliente ya existe, Intente denuevo");
                    Limpiar();
                }
                else
                {
                    nomCliente.ReadOnly = true;
                    cedCliente.ReadOnly = true;
                    capitalPrestamo.ReadOnly = true;
                    plazoPrestamo.ReadOnly = true;
                    tasaPrestamo.ReadOnly = true;
                    agregarPrestamo.Enabled = false;
                    bsClientePanel.Show();
                    //cl.Add(new Cliente(nomCl, cedCl, svData));
                    string insertQuery = "INSERT INTO CLIENTE(nombreCliente, cedulaCliente) OUTPUT inserted.id VALUES('" + nomCl + "','" + cedCl + "')";
                    int idCliente = BdPosible.QuerySelector(insertQuery);
                    string insertQueryPrestamos = String.Format("INSERT INTO PRESTAMOS(capital,plazo,tasa,idCliente) VALUES({0}, {1}, {2}, {3})", pr.Capital, pr.Plazo, pr.Tasa, idCliente);
                    BdPosible.InsertData(insertQueryPrestamos);
                }







            }
            else
            {
                MessageBox.Show("Campos vacios llene denuevo");
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (bsCliente.Text != "")
            {

                string nombreCliente = bsCliente.Text.ToLower();
                
                string selClienteQuery = "SELECT * FROM CLIENTE WHERE nombreCliente  = '" + nombreCliente+"'";

                int countCliente = BdPosible.QuerySelector(selClienteQuery);
                


                if (countCliente > 0)
                {
                    bsClienteBtn.Enabled = false;
                    bsCliente.ReadOnly = true;
                    nomCliente.ReadOnly = true;
                    cedCliente.ReadOnly = true;
                    capitalPrestamo.ReadOnly = true;
                    plazoPrestamo.ReadOnly = true;
                    agregarPrestamo.Enabled = false;
                    infoClientePrestamo.Text += " de " + nombreCliente;

                    string joinQueryClientePrestamos = "SELECT * FROM PRESTAMOS WHERE idCliente = "+countCliente;
                    Prestamos pm = BdPosible.RetrieveData(joinQueryClientePrestamos);
                    List<PrestamosMensuales> svData = pm.TablaAmortizacion(pm.Tasa);

                    foreach (PrestamosMensuales ps in svData)
                    {
                        tablaAmortizacion.Rows.Add(ps.Mes, Math.Round(ps.Cuota, 2), Math.Round(ps.Intereses, 2), Math.Round(ps.Amortizacion, 2), Math.Round(ps.Capital, 2));
                    }
                    infoPrestamoClientePanel.Show();

                    /*for (int i = 0; i < cl.Count; i++)
                    {
                        if (nombreCliente == cl[i].NomCliente)
                        {
                            bsClienteBtn.Enabled = false;
                            bsCliente.ReadOnly = true;
                            nomCliente.ReadOnly = true;
                            cedCliente.ReadOnly = true;
                            capitalPrestamo.ReadOnly = true;
                            plazoPrestamo.ReadOnly = true;
                            agregarPrestamo.Enabled = false;
                            infoClientePrestamo.Text += " de " + nombreCliente;
                            List<PrestamosMensuales> svData = cl[i].PrestamoAsignado;
                            foreach (PrestamosMensuales ps in svData)
                            {
                                tablaAmortizacion.Rows.Add(ps.Mes, Math.Round(ps.Cuota, 2), Math.Round(ps.Intereses, 2), Math.Round(ps.Amortizacion, 2), Math.Round(ps.Capital, 2));
                            }

                            infoPrestamoClientePanel.Show();
                            break;
                        }*/



                }


                
                else
                {
                    MessageBox.Show("Cliente no existe");
                    bsClienteBtn.Enabled = true;
                    bsCliente.ReadOnly = false;
                    nomCliente.ReadOnly = false;
                    cedCliente.ReadOnly = false;
                    capitalPrestamo.ReadOnly = false;
                    plazoPrestamo.ReadOnly = false;
                    tasaPrestamo.ReadOnly = false;
                    agregarPrestamo.Enabled = true;
                    infoPrestamoClientePanel.Hide();
                }

            }
            else
            {
                MessageBox.Show("No ha introducido nada");
            }

        }

        private void desaparecer_Click(object sender, EventArgs e)
        {
            bsClienteBtn.Enabled = true;
            bsCliente.ReadOnly = false;
            nomCliente.ReadOnly = false;
            cedCliente.ReadOnly = false;
            capitalPrestamo.ReadOnly = false;
            plazoPrestamo.ReadOnly = false;
            tasaPrestamo.ReadOnly = false;
            agregarPrestamo.Enabled = true;
            infoPrestamoClientePanel.Hide();

            Limpiar();


        }

        private void infoPrestamoPanel_Paint(object sender, PaintEventArgs e)
        {

        }
        public void Limpiar()
        {
            tablaAmortizacion.DataSource = null;
            tablaAmortizacion.Rows.Clear();
            infoClientePrestamo.Text = "Informacion del prestamo";
            bsCliente.Clear();
            nomCliente.Clear();
            cedCliente.Clear();
            capitalPrestamo.Clear();
            tasaPrestamo.Clear();
            plazoPrestamo.Value = 0;
        }
    }
    
}
