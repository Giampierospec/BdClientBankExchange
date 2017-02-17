using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PrestamoBancarioPosiblementeConBd
{
    public class BdPosible
    {
        static int id;
        static SqlConnection con = new SqlConnection("Data Source=GIAMSPEC;Initial Catalog=prestamo_bancario;Integrated Security=True");
        public static int QuerySelector(string query)
        {
            DataSet ds = new DataSet("ds");
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                id = (int)cmd.ExecuteScalar();


                //MessageBox.Show("Query ejecutado satisfactoriamente");


            }
            catch (Exception ex)
            {
                MessageBox.Show("HUBO UN ERROR" + ex.Message.ToString());

            }
            finally
            {
                con.Close();
            }
            return id;

        }
        public static void InsertData(string query)
        {
            DataSet ds = new DataSet("ds");
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();


                MessageBox.Show("DATA GUARDADA");


            }
            catch (Exception ex)
            {
                MessageBox.Show("HUBO UN ERROR" + ex.Message.ToString());

            }
            finally
            {
                con.Close();
            }
            

        }

        public static void SelectData(string query)
        {

        }
        public static int SelectIdCliente(string query)
        {
            int id = 0;
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                id = (int)cmd.ExecuteScalar();

            }
            catch (Exception ex)
            {
                //MessageBox.Show(" " + ex.Message.ToString());
                id = 0;

            }
            finally
            {
                con.Close();
            }
            return id;
        }
        public static Prestamos RetrieveData(string query)
        {
            Prestamos pr = new Prestamos();
            try
            {
                con.Open();

                SqlCommand cmd = new SqlCommand(query, con);

                SqlDataReader reader = cmd.ExecuteReader();
                
                    if (reader.HasRows)
                    {
                    while (reader.Read())
                    {
                        pr.Capital = double.Parse(reader["capital"].ToString());
                        pr.Plazo = double.Parse(reader["plazo"].ToString());
                        pr.Tasa = double.Parse(reader["tasa"].ToString());
                    }
                    }
                
               
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error "+ex.Message.ToString());
            }
            finally
            {
                con.Close();
            }
            return pr;
            
        }
    }
}
