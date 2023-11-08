using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenVeterinaria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
          
            new login().ShowDialog(); // abre la forma login
            
        }

        private void whats_Click(object sender, EventArgs e)
        {
            label7.Text = "661-130-4418";  // despliega numero de telefono
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label8.Text = "naggini.pet@gmail.com"; // despliega correo electronico
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Close(); // cierra programa
        }
    }
}
