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
    public partial class InicioPantalla : Form
    {
        public InicioPantalla()
        {
            InitializeComponent();
            lblSaldo.Text = $"Saldo disponible: S/{Banco.Saldo}";
        }

        private void panelRetirar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel_Inicio_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void AbrirRetirar(object formureti)
        {
            if (this.panelContenido.Controls.Count > 0)
                this.panelContenido.Controls.RemoveAt(0);
            Form fh = formureti as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenido.Controls.Add(fh);
            this.panelContenido.Tag = fh;
            fh.Show();



        }

        private void btnRetirar_Click(object sender, EventArgs e)
        {
            AbrirRetirar(new RetirarContenido());
        }

        private void InicioPantalla_Load(object sender, EventArgs e)
        {

        }

        private void btnDeposito_Click(object sender, EventArgs e)
        {
            AbrirRetirar(new DepositoContenido());
        }

        private void panelContenido_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBoxLogo_Click(object sender, EventArgs e)
        {
            AbrirRetirar(new InicioContenido());
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            AbrirRetirar(new FormPConvertidor());
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
