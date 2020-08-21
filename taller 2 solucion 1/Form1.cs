using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace taller_2_solucion_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            int edad;
            edad = int.Parse(txtEdad.Text);
            if (edad > 18)
            {

                MessageBox.Show("es mayor de edad", " mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            else
            {
                MessageBox.Show("es menor de edad ", " mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtEdad.Text = String.Empty;
            txtEdad.Focus();
        }

        
    }
}
