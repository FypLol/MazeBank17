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
    public partial class RetirarContenido : Form
    {
        public RetirarContenido()
        {
            InitializeComponent();
        }

        private void lbl_Monto_Click(object sender, EventArgs e)
        {

        }

        private void lblSaldoUsuario_Click(object sender, EventArgs e)
        {


        }

        private void btnNumero1_Click(object sender, EventArgs e)
        {
            rtboxCantidadRetirar.Text = rtboxCantidadRetirar.Text + "1";
        }

        private void btnNumero2_Click(object sender, EventArgs e)
        {
            rtboxCantidadRetirar.Text = rtboxCantidadRetirar.Text + "2";
        }

        private void btnNumero3_Click(object sender, EventArgs e)
        {
            rtboxCantidadRetirar.Text = rtboxCantidadRetirar.Text + "3";
        }

        private void btnNumero4_Click(object sender, EventArgs e)
        {
            rtboxCantidadRetirar.Text = rtboxCantidadRetirar.Text + "4";
        }

        private void btnNumero5_Click(object sender, EventArgs e)
        {
            rtboxCantidadRetirar.Text = rtboxCantidadRetirar.Text + "5";
        }

        private void btnNumero6_Click(object sender, EventArgs e)
        {
            rtboxCantidadRetirar.Text = rtboxCantidadRetirar.Text + "6";
        }

        private void btnNumero7_Click(object sender, EventArgs e)
        {
            rtboxCantidadRetirar.Text = rtboxCantidadRetirar.Text + "7";
        }

        private void btnNumero8_Click(object sender, EventArgs e)
        {
            rtboxCantidadRetirar.Text = rtboxCantidadRetirar.Text + "8";
        }

        private void btnNumero9_Click(object sender, EventArgs e)
        {
            rtboxCantidadRetirar.Text = rtboxCantidadRetirar.Text + "9";
        }

        private void btnNumero0_Click(object sender, EventArgs e)
        {
            rtboxCantidadRetirar.Text = rtboxCantidadRetirar.Text + "0";
        }

        private void btnEnterRetirar_Click(object sender, EventArgs e)
        {
            decimal cantidad;
            if (decimal.TryParse(rtboxCantidadRetirar.Text, out cantidad))
            {
                if (cantidad > 0 && cantidad <= Banco.Saldo)
                {
                    Banco.Saldo -= cantidad;
                    MessageBox.Show($"Has retirado S/{cantidad}. Saldo actual: S/{Banco.Saldo}.");
                }
                else
                {
                    MessageBox.Show("Cantidad inválida o saldo insuficiente.");
                }
            }
            else
            {
                MessageBox.Show("Introduce una cantidad válida.");
            }
            rtboxCantidadRetirar.Clear();
        }

        private void btnBorrarNumero_Click(object sender, EventArgs e)
        {
            string cadena = rtboxCantidadRetirar.Text;
            cadena = cadena.Substring(0, cadena.Length - 1);
            rtboxCantidadRetirar.Text = cadena;
        }
    }
}
