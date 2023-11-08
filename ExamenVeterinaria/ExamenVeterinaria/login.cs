using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenVeterinaria
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Close();
            
            
        }
        // Conexión a la base de datos
        SqlConnection conexion = new SqlConnection("server=LAPTOP-CRITSAB3\\SQLEXPRESS; database=Veterinaria ; integrated security = true");

        private void btnlogin_Click(object sender, EventArgs e)
        {
            Ingresar(this.txtUser.Text, this.txtPass.Text); // llamada al método

            Close(); 
        }

        public void Ingresar(string usuario, string contra)
        {
            try
            {
                conexion.Open(); //abre conexión
                //Implementa el select para visualizar nuevos pacientes
                SqlCommand cmd = new SqlCommand("SELECT Nombre, Tip_user FROM Usuario WHERE Usuario =@usuario AND Contraseña =@pas", conexion);
                cmd.Parameters.AddWithValue("usuario", usuario);
                cmd.Parameters.AddWithValue("pas", contra);

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                //Llenar data table datos de la tabla
                sda.Fill(dt);

                if (dt.Rows.Count == 1)
                {
                    this.Hide();
                    if (dt.Rows[0][1].ToString() == "Admin")

                    {
                        new Form2().ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("Usuario y/o Contraseña incorrecta");
                }


            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);

            }
            finally
            {
                conexion.Close();
            }


        }
        // Eventos
        private void txtUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
                txtPass.Focus();
        }

        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
                btnlogin.Focus();
        }
    }
}
