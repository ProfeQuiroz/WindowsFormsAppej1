using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppej1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double numero1, numero2;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void numero1textBox_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void salirbutton_Click(object sender, EventArgs e)
        {
            
        DialogResult dr = MessageBox.Show("¿Desea salir del Formulario?", "Confirmar Selección", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
         if (dr == DialogResult.No)
         {
            return;
         }
             Application.Exit();
            
        }

        

        private void confirmarbutton_Click(object sender, EventArgs e)
        {
            if (validardatos())
            {
                numero1 = double.Parse(numero1textBox.Text);
                numero2 = double.Parse(numero2textBox.Text);
                if (sumaradioButton.Checked)
                {
                    var sumar = numero1 + numero2;
                    MessageBox.Show(sumar.ToString());
                }
                if (restaradioButton.Checked)
                {
                    var restar = numero1 - numero2;
                    MessageBox.Show(restar.ToString());
                }
                if (productoradioButton.Checked)
                {
                    var producto = numero1 * numero2;
                    MessageBox.Show(producto.ToString());

                }
                if (divisionradioButton.Checked)
                {
                    var division = numero1 / numero2;
                    MessageBox.Show(division.ToString());
                }
                limpiarcampos(); 
            }
        }

        private bool validardatos()
        {
            errorProvider1.Clear();
            bool valido=true;
            if (!double.TryParse(numero1textBox.Text, out numero1))
            {
                valido = false;
                errorProvider1.SetError(numero1textBox, "El número debe ser un entero");
            }
            if (!double.TryParse(numero2textBox.Text, out numero2))
            {
                valido = false;
                errorProvider1.SetError(numero2textBox, "El número debe ser un entero");
            }
            else
            {
                if (divisionradioButton.Checked&&numero2==0)
                {
                    valido = false;
                    errorProvider1.SetError(numero2textBox, "No puede dividir por cero");
                }
            }
            return valido;
        }

        private void restabutton_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void limpiarcampos()
        {
            numero1textBox.Clear();
            numero2textBox.Clear();
            numero1textBox.Focus();
        }
    }
}
