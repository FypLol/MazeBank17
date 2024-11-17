namespace Proyecto_Mibanco
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn_ContinuarLogin_Click(object sender, EventArgs e)
        {
           String User = txtBox_Usuario.Text;
           String Contra = txtBox_Clave5Digitos.Text;
            String codiVeri = txtBox_CodigoVerificacion.Text;

            if (User =="Pedro Quispe" && Contra =="212223"  && codiVeri=="73kp3")
            {
                InicioPantalla frm = new InicioPantalla();
                frm.Show();
                this.Hide();
                

            }
            else
            {
                
                MessageBox.Show("Usuario o Clave estan mal escritas");
            }

        }

        
        private void lbl_ClaveDigitios_Click(object sender, EventArgs e)
        {

        }
    }
}
