using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea1_Lenguaje3
{
    public partial class Ejercicio1 : Form
    {
        public Ejercicio1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void Btn_aceptar_Click(object sender, EventArgs e)
        {
            decimal numero = Convert.ToDecimal(txt_numero1.Text);
            numeropar(numero);

        }
        
        
        private decimal numeropar (decimal numero)
        {
            decimal resultado;
            resultado = Convert.ToDecimal(txt_numero1.Text);
            if (numero % 2 == 0)
            {

                MessageBox.Show("El numero es par");
            }
            else
            {
                MessageBox.Show("El numero es Impar");
            }
            return resultado;

        }
    }
    
}
