using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace serie_fibonacci_y_factorial
{
    public partial class Form1 : Form
    {
        fibonacci fibonacci = new fibonacci();
        Factorial factorial = new Factorial();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnfibonacci_Click(object sender, EventArgs e)
        {
           

            fibonacci.setNumero (int.Parse(txtnumero.Text));

            foreach (int valores in fibonacci.calcularfibonacci()) {
                ltb1.Items.Add(valores);
            
            
            }

            }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            ltb1.Items.Clear();
            lblfactorial.Visible = false;
            
        }

        private void btnfactorial_Click(object sender, EventArgs e)
        {
            factorial.setNumero(int.Parse(txtnumero.Text));
            lblfactorial.Visible = true;
            lblfactorial.Text = Convert.ToString(factorial.calcularFactorial());
        }

      

        }
    }

