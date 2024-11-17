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
    public partial class FormPConvertidor : Form
    {
        public FormPConvertidor()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void USD_Click(object sender, EventArgs e)
        {

        }

        private void cboxTipoCammbio_SelectedIndexChanged(object sender, EventArgs e)
        {
            Double soles, dolar, euro, libra, cambio;

            soles = Convert.ToDouble(textBoxIngresarCant.Text);


            //COMBOBOX
            if (cboxTipoCammbio.SelectedIndex == 0)
            {
                dolar = soles / 3.74;
                lblInfoCambio.Visible = true;
                lblInfoCambio.Text = "Dolares";
                textBoxConvert.Text = Convert.ToString(Math.Round(dolar, 2));

            }
            else
            {
                if (cboxTipoCammbio.SelectedIndex == 1)
                {
                    euro = soles / 4.11;
                    lblInfoCambio.Visible = true;
                    lblInfoCambio.Text = "Euros";
                    textBoxConvert.Text = Convert.ToString(Math.Round(euro, 2));

                }

                else
                {
                    libra = soles / 4.90;
                    lblInfoCambio.Visible = true;
                    lblInfoCambio.Text = "Libras Esterlinas";
                    textBoxConvert.Text += Convert.ToString(Math.Round(libra, 2));


                }

            }

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            textBoxIngresarCant.Clear();
            textBoxConvert.Clear();
        }

        private void cboxTipoCammbio_Click(object sender, EventArgs e)
        {
            if (textBoxIngresarCant.Text.Length == 0)
            {
                MessageBox.Show("Debe de Ingresar Cantidad que quiere convertir");
                textBoxConvert.Text = "";
                cboxTipoCammbio.Text = "";
            }
        }

        private void textBoxConvert_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
