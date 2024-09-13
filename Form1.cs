using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Este es un comentario solo de prueba.
namespace ejercicioRentaEmpleado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            double sueldo = double.Parse(txtSueldo.Text);
            double renta;
            if (sueldo <= 365)
            {
                renta = 0;
            }
            else if (sueldo <= 750)
            {
                renta = sueldo * 0.15;
            }
            else if (sueldo <= 1300)
            {
                renta = sueldo * 0.17;
            }
            else if (sueldo <= 2000)
            {
                renta = sueldo * 0.21;
            }
            else if (sueldo <= 2900)
            {
                renta = sueldo * 0.25;
            }
            else
            {
                renta = sueldo * 0.29;
            }

            //fsfdfgsdfefewef

            //dsafsasfafafsfsaafsasffsa
            //intento otravez
            txtImpuesto.Text = renta.ToString();
            MessageBox.Show("Total a pagar renta: " + renta, "Salida", MessageBoxButtons.OK, MessageBoxIcon.Information);


            //asafkbaskfsabfafkbkafafasafs
        }

        private void Form1_Load(object sender, EventArgs e) //lennyn
        {

        }

        //Este boton Sale del formulario.
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Este boton limpia el formulario.
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtImpuesto.Text = "";
            txtNombre.Text = "";
            txtSueldo.Text = "";
            txtNombre.Focus();
            //lennyn Ayala
        }
    }
}
