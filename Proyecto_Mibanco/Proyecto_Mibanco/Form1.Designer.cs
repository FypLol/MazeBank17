namespace Proyecto_Mibanco
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lbl_BancaPorInternet = new Label();
            groupBoxLogin1 = new GroupBox();
            pictureBoxCodigo = new PictureBox();
            lbl_Codigo = new Label();
            lbl_ClaveDigitios = new Label();
            lbl_NumeroTarjeta = new Label();
            txtBox_CodigoVerificacion = new TextBox();
            txtBox_Clave5Digitos = new TextBox();
            txtBox_Usuario = new TextBox();
            btn_ContinuarLogin = new Button();
            pictureBoxPantalalAzul = new PictureBox();
            groupBoxLogin1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCodigo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPantalalAzul).BeginInit();
            SuspendLayout();
            // 
            // lbl_BancaPorInternet
            // 
            lbl_BancaPorInternet.AutoSize = true;
            lbl_BancaPorInternet.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_BancaPorInternet.Location = new Point(264, 88);
            lbl_BancaPorInternet.Margin = new Padding(5, 0, 5, 0);
            lbl_BancaPorInternet.Name = "lbl_BancaPorInternet";
            lbl_BancaPorInternet.Size = new Size(266, 40);
            lbl_BancaPorInternet.TabIndex = 0;
            lbl_BancaPorInternet.Text = "Banca por Internet";
            // 
            // groupBoxLogin1
            // 
            groupBoxLogin1.Controls.Add(pictureBoxCodigo);
            groupBoxLogin1.Controls.Add(lbl_Codigo);
            groupBoxLogin1.Controls.Add(lbl_ClaveDigitios);
            groupBoxLogin1.Controls.Add(lbl_NumeroTarjeta);
            groupBoxLogin1.Controls.Add(txtBox_CodigoVerificacion);
            groupBoxLogin1.Controls.Add(txtBox_Clave5Digitos);
            groupBoxLogin1.Controls.Add(txtBox_Usuario);
            groupBoxLogin1.Controls.Add(btn_ContinuarLogin);
            groupBoxLogin1.Controls.Add(lbl_BancaPorInternet);
            groupBoxLogin1.Location = new Point(701, -12);
            groupBoxLogin1.Margin = new Padding(5, 6, 5, 6);
            groupBoxLogin1.Name = "groupBoxLogin1";
            groupBoxLogin1.Padding = new Padding(5, 6, 5, 6);
            groupBoxLogin1.Size = new Size(909, 1146);
            groupBoxLogin1.TabIndex = 1;
            groupBoxLogin1.TabStop = false;
            // 
            // pictureBoxCodigo
            // 
            pictureBoxCodigo.BackColor = Color.Transparent;
            pictureBoxCodigo.Image = (Image)resources.GetObject("pictureBoxCodigo.Image");
            pictureBoxCodigo.Location = new Point(514, 616);
            pictureBoxCodigo.Margin = new Padding(5, 6, 5, 6);
            pictureBoxCodigo.Name = "pictureBoxCodigo";
            pictureBoxCodigo.Size = new Size(223, 88);
            pictureBoxCodigo.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxCodigo.TabIndex = 3;
            pictureBoxCodigo.TabStop = false;
            // 
            // lbl_Codigo
            // 
            lbl_Codigo.AutoSize = true;
            lbl_Codigo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            lbl_Codigo.Location = new Point(158, 768);
            lbl_Codigo.Margin = new Padding(5, 0, 5, 0);
            lbl_Codigo.Name = "lbl_Codigo";
            lbl_Codigo.Size = new Size(107, 38);
            lbl_Codigo.TabIndex = 8;
            lbl_Codigo.Text = "Codigo";
            // 
            // lbl_ClaveDigitios
            // 
            lbl_ClaveDigitios.AutoSize = true;
            lbl_ClaveDigitios.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            lbl_ClaveDigitios.Location = new Point(26, 480);
            lbl_ClaveDigitios.Margin = new Padding(5, 0, 5, 0);
            lbl_ClaveDigitios.Name = "lbl_ClaveDigitios";
            lbl_ClaveDigitios.Size = new Size(387, 38);
            lbl_ClaveDigitios.TabIndex = 7;
            lbl_ClaveDigitios.Text = "Clave de Internet de 6 digitos";
            lbl_ClaveDigitios.Click += lbl_ClaveDigitios_Click;
            // 
            // lbl_NumeroTarjeta
            // 
            lbl_NumeroTarjeta.AutoSize = true;
            lbl_NumeroTarjeta.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl_NumeroTarjeta.Location = new Point(264, 220);
            lbl_NumeroTarjeta.Margin = new Padding(5, 0, 5, 0);
            lbl_NumeroTarjeta.Name = "lbl_NumeroTarjeta";
            lbl_NumeroTarjeta.Size = new Size(116, 38);
            lbl_NumeroTarjeta.TabIndex = 6;
            lbl_NumeroTarjeta.Text = "Usuario";
            // 
            // txtBox_CodigoVerificacion
            // 
            txtBox_CodigoVerificacion.Location = new Point(430, 768);
            txtBox_CodigoVerificacion.Margin = new Padding(5, 6, 5, 6);
            txtBox_CodigoVerificacion.Name = "txtBox_CodigoVerificacion";
            txtBox_CodigoVerificacion.Size = new Size(424, 35);
            txtBox_CodigoVerificacion.TabIndex = 5;
            // 
            // txtBox_Clave5Digitos
            // 
            txtBox_Clave5Digitos.Location = new Point(430, 480);
            txtBox_Clave5Digitos.Margin = new Padding(5, 6, 5, 6);
            txtBox_Clave5Digitos.Name = "txtBox_Clave5Digitos";
            txtBox_Clave5Digitos.Size = new Size(424, 35);
            txtBox_Clave5Digitos.TabIndex = 4;
            // 
            // txtBox_Usuario
            // 
            txtBox_Usuario.Location = new Point(430, 216);
            txtBox_Usuario.Margin = new Padding(5, 6, 5, 6);
            txtBox_Usuario.Name = "txtBox_Usuario";
            txtBox_Usuario.Size = new Size(424, 35);
            txtBox_Usuario.TabIndex = 3;
            // 
            // btn_ContinuarLogin
            // 
            btn_ContinuarLogin.BackColor = Color.FromArgb(229, 34, 41);
            btn_ContinuarLogin.FlatAppearance.BorderSize = 0;
            btn_ContinuarLogin.FlatAppearance.MouseDownBackColor = SystemColors.MenuBar;
            btn_ContinuarLogin.FlatAppearance.MouseOverBackColor = SystemColors.MenuHighlight;
            btn_ContinuarLogin.FlatStyle = FlatStyle.Flat;
            btn_ContinuarLogin.ForeColor = Color.White;
            btn_ContinuarLogin.Location = new Point(129, 982);
            btn_ContinuarLogin.Margin = new Padding(5, 6, 5, 6);
            btn_ContinuarLogin.Name = "btn_ContinuarLogin";
            btn_ContinuarLogin.Size = new Size(674, 82);
            btn_ContinuarLogin.TabIndex = 2;
            btn_ContinuarLogin.Text = "Continuar";
            btn_ContinuarLogin.UseVisualStyleBackColor = false;
            btn_ContinuarLogin.Click += btn_ContinuarLogin_Click;
            // 
            // pictureBoxPantalalAzul
            // 
            pictureBoxPantalalAzul.Image = (Image)resources.GetObject("pictureBoxPantalalAzul.Image");
            pictureBoxPantalalAzul.Location = new Point(-3, 0);
            pictureBoxPantalalAzul.Margin = new Padding(5, 6, 5, 6);
            pictureBoxPantalalAzul.Name = "pictureBoxPantalalAzul";
            pictureBoxPantalalAzul.Size = new Size(703, 1134);
            pictureBoxPantalalAzul.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxPantalalAzul.TabIndex = 2;
            pictureBoxPantalalAzul.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1601, 1122);
            Controls.Add(pictureBoxPantalalAzul);
            Controls.Add(groupBoxLogin1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 6, 5, 6);
            MinimumSize = new Size(1611, 1136);
            Name = "Form1";
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MAZE BANK";
            groupBoxLogin1.ResumeLayout(false);
            groupBoxLogin1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCodigo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPantalalAzul).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lbl_BancaPorInternet;
        private GroupBox groupBoxLogin1;
        private TextBox txtBox_CodigoVerificacion;
        private TextBox txtBox_Clave5Digitos;
        private TextBox txtBox_Usuario;
        private Button btn_ContinuarLogin;
        private Label lbl_ClaveDigitios;
        private Label lbl_NumeroTarjeta;
        private Label lbl_Codigo;
        private PictureBox pictureBoxPantalalAzul;
        private PictureBox pictureBoxCodigo;
    }
}
