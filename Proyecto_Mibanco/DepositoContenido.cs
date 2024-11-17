using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Mibanco
{
    public partial class DepositoContenido : Form
    {
        public DepositoContenido()
        {
            InitializeComponent();
        }
        #region
        private void btn10Retirar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Transacción realizada");
        }

        private void btn20Retirar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Transacción realizada");
        }

        private void btn50Retirar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Transacción realizada");
        }

        private void btn100Retirar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Transacción realizada");
        }

        private void btn1000Retirar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Transacción realizada");
        }
        #endregion

        private void btnNumero1_Click(object sender, EventArgs e)
        {
            rtboxCantidadDepositar.Text = rtboxCantidadDepositar.Text + "1";
        }

        private void btnNumero2_Click(object sender, EventArgs e)
        {
            rtboxCantidadDepositar.Text = rtboxCantidadDepositar.Text + "2";
        }

        private void btnNumero3_Click(object sender, EventArgs e)
        {
            rtboxCantidadDepositar.Text = rtboxCantidadDepositar.Text + "3";
        }

        private void btnNumero4_Click(object sender, EventArgs e)
        {
            rtboxCantidadDepositar.Text = rtboxCantidadDepositar.Text + "4";
        }

        private void btnNumero5_Click(object sender, EventArgs e)
        {
            rtboxCantidadDepositar.Text = rtboxCantidadDepositar.Text + "5";
        }

        private void btnNumero6_Click(object sender, EventArgs e)
        {
            rtboxCantidadDepositar.Text = rtboxCantidadDepositar.Text + "6";
        }

        private void btnNumero7_Click(object sender, EventArgs e)
        {
            rtboxCantidadDepositar.Text = rtboxCantidadDepositar.Text + "7";
        }

        private void btnNumero8_Click(object sender, EventArgs e)
        {
            rtboxCantidadDepositar.Text = rtboxCantidadDepositar.Text + "8";
        }

        private void btnNumero9_Click(object sender, EventArgs e)
        {
            rtboxCantidadDepositar.Text = rtboxCantidadDepositar.Text + "9";
        }

        private void btnNumero0_Click(object sender, EventArgs e)
        {
            rtboxCantidadDepositar.Text = rtboxCantidadDepositar.Text + "0";
        }

        private void btnBorrarNumero_Click(object sender, EventArgs e)
        {
            string cadena = rtboxCantidadDepositar.Text;
            cadena = cadena.Substring(0, cadena.Length - 1);
            rtboxCantidadDepositar.Text = cadena;
        
        }

        private void btnEnterDepositar_Click(object sender, EventArgs e)
        {
            decimal cantidad;
            if (decimal.TryParse(rtboxCantidadDepositar.Text, out cantidad))
            {
                if (cantidad > 0)
                {
                    Banco.Saldo += cantidad;
                    MessageBox.Show($"Has depositado S/{cantidad}. Saldo actual: S/{Banco.Saldo}.");
                }
                else
                {
                    MessageBox.Show("Introduce una cantidad válida.");
                }
            }
            else
            {
                MessageBox.Show("Introduce una cantidad válida.");
            }
            rtboxCantidadDepositar.Clear();
        }
    }
}
