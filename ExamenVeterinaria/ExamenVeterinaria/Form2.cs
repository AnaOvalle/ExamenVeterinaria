using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ExamenVeterinaria
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        } 

        // conexion a la base de datos
        SqlConnection conexion = new SqlConnection("server=LAPTOP-CRITSAB3\\SQLEXPRESS; database=Veterinaria ; integrated security = true");

        private void lblcerrar_Click(object sender, EventArgs e)
        {
            Close(); // cierra el formulario
            
        }

        private void subir_Click(object sender, EventArgs e)
        {
            // método para agregar una imagen desde archivos
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.gif;*.bmp";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                pbImagen.Image = new System.Drawing.Bitmap(dialog.FileName);
            }
        }

        private void CargarPacientes()
        {
            string consulta = "select * from Pacientes";
            SqlDataAdapter adatador = new SqlDataAdapter(consulta, conexion);
            DataTable dt = new DataTable();
            adatador.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        public void limpiar_campos() // Metodo para limpiar los campos
        {
            txtID.Clear();
            txtNombre.Clear();
            txtRaza.Clear();
            txtEdad.Clear();
            txtColor.Clear();
            txtPropietario.Clear();
            cbEspecie.SelectedIndex =  -1;
            pbImagen.Image = null;
            dtpFecha.Text = DateTime.Now.ToString();
        }

        private int ObtenerIDSeleccionado()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                return Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["IDPaciente"].Value);
            }
            return -1;
        }


        private void btnRegis_Click(object sender, EventArgs e)
        {
            // Validar los datos ingresados y manejar errores
            try
            {
                
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO Pacientes (IDPaciente, Nombre, Especie, Raza, Edad, FechaNacimiento, Color, Propietario, Imagen) VALUES (@IDPaciente, @Nombre, @Especie, @Raza, @Edad, @FechaNacimiento, @Color, @Propietario, @Imagen)", conexion);
                    
                    cmd.Parameters.AddWithValue("@IDPaciente", txtID.Text);
                    cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                    cmd.Parameters.AddWithValue("@Especie", cbEspecie.Text);
                    cmd.Parameters.AddWithValue("@Raza", txtRaza.Text);
                    cmd.Parameters.AddWithValue("@Edad", txtEdad.Text);
                    cmd.Parameters.AddWithValue("@FechaNacimiento", dtpFecha.Value);
                    cmd.Parameters.AddWithValue("@Color", txtColor.Text);
                    cmd.Parameters.AddWithValue("@Propietario", txtPropietario.Text);

                // Guardar la imagen como arreglo de bytes
                if (pbImagen.Image != null)
                {
                    MemoryStream ms = new MemoryStream();
                    pbImagen.Image.Save(ms, pbImagen.Image.RawFormat);
                    byte[] imgData = ms.ToArray();
                    cmd.Parameters.Add("@Imagen", SqlDbType.VarBinary).Value = imgData;
                }
                else
                {
                    cmd.Parameters.Add("@Imagen", SqlDbType.VarBinary).Value = DBNull.Value;
                }

                cmd.ExecuteNonQuery();
                MessageBox.Show("Paciente Registrado.");
                limpiar_campos();
                CargarPacientes();
                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear el paciente: " + ex.Message);
                conexion.Close();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'veterinariaDataSet1.Pacientes' Puede moverla o quitarla según sea necesario.
            this.pacientesTableAdapter.Fill(this.veterinariaDataSet1.Pacientes);
            CargarPacientes();

            // TODO: esta línea de código carga datos en la tabla 'veterinariaDataSet.Especie' Puede moverla o quitarla según sea necesario.
            this.especieTableAdapter.Fill(this.veterinariaDataSet.Especie);

        }

        private void btnActua_Click(object sender, EventArgs e)
        {
            // Validar los datos ingresados y manejar errores
            try
            {
                int IDPaciente = ObtenerIDSeleccionado();
                if (IDPaciente == -1)
                    return;

                    conexion.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE Pacientes SET IDPaciente = @IDPaciente, Nombre = @Nombre, Especie = @Especie, Raza = @Raza, Edad = @Edad, FechaNacimiento = @FechaNacimiento, Color = @Color, Propietario = @Propietario, Imagen = @Imagen WHERE IDPaciente = @IDPaciente", conexion);
                    cmd.Parameters.AddWithValue("@IDPaciente", txtID.Text);
                    cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                    cmd.Parameters.AddWithValue("@Especie", cbEspecie.Text);                   
                    cmd.Parameters.AddWithValue("@Raza", txtRaza.Text);
                    cmd.Parameters.AddWithValue("@Edad", txtEdad.Text);
                    cmd.Parameters.AddWithValue("@FechaNacimiento", dtpFecha.Value);
                    cmd.Parameters.AddWithValue("@Color", txtColor.Text);
                    cmd.Parameters.AddWithValue("@Propietario", txtPropietario.Text);

                // Guardar la imagen como arreglo de bytes
                if (pbImagen.Image != null)
                {
                    MemoryStream ms = new MemoryStream();
                    pbImagen.Image.Save(ms, pbImagen.Image.RawFormat);
                    byte[] imgData = ms.ToArray();
                    cmd.Parameters.Add("@Imagen", SqlDbType.VarBinary).Value = imgData;
                }
                else
                {
                    cmd.Parameters.Add("@Imagen", SqlDbType.VarBinary).Value = DBNull.Value;
                }

                cmd.ExecuteNonQuery();
                MessageBox.Show("Paciente modificado.");
                limpiar_campos();
                CargarPacientes();
                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el paciente: " + ex.Message);
                conexion.Close();
            }
        }

        private void btnElimi_Click(object sender, EventArgs e)
        {
            try
            {
                int IDPaciente = ObtenerIDSeleccionado();
                if (IDPaciente == -1)
                    return;

                conexion.Open();
                string baja = "DELETE FROM Pacientes WHERE IDPaciente = @IDPaciente";
                SqlCommand cmd = new SqlCommand(baja, conexion);

                cmd.Parameters.AddWithValue("@IDPaciente", IDPaciente);
                cmd.ExecuteNonQuery();

                cmd.ExecuteNonQuery();
                MessageBox.Show("Paciente Eliminado.");
                limpiar_campos();
                CargarPacientes();
                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el paciente: " + ex.Message);
                conexion.Close();
            }
        }

        private void txtID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
                txtNombre.Focus();
        }

        private void txtNombre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
                cbEspecie.Focus();
        }

        private void cbEspecie_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
                txtRaza.Focus();
        }

        private void txtRaza_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
                txtEdad.Focus();
        }

        private void txtEdad_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
                dtpFecha.Focus();
        }

        private void dtpFecha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
                txtColor.Focus();
        }

        private void txtColor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
                txtPropietario.Focus();
        }

        private void txtPropietario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
                btnRegis.Focus();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar si se hizo clic en una fila válida
            if (e.RowIndex >= 0)
            {
                // Obtener la fila seleccionada
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Acceder a los valores de las celdas de la fila y asignarlos a los TextBox
                txtID.Text = row.Cells["IDPaciente"].Value.ToString(); 
                txtNombre.Text = row.Cells["Nombre"].Value.ToString();
                cbEspecie.Text = row.Cells["Especie"].Value.ToString();
                txtRaza.Text = row.Cells["Raza"].Value.ToString();
                txtEdad.Text = row.Cells["Edad"].Value.ToString();
                dtpFecha.Text = row.Cells["FechaNacimiento"].Value.ToString();
                txtColor.Text = row.Cells["Color"].Value.ToString();
                txtPropietario.Text = row.Cells["Propietario"].Value.ToString();

                // Obtener los datos de la imagen como un array de bytes desde una celda 
                byte[] imagenData = (byte[])row.Cells["Imagen"].Value;

                // Convertir los datos de la imagen en un objeto Image y mostrarlo en el PictureBox
                if (imagenData != null && imagenData.Length > 0)
                {
                    using (MemoryStream ms = new MemoryStream(imagenData))
                    {
                        pbImagen.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    pbImagen.Image = null; // Limpiar el PictureBox si no hay datos de imagen
                }


            }
        }
    }
}
