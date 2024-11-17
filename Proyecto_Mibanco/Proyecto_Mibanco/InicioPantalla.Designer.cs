namespace Proyecto_Mibanco
{
    partial class InicioPantalla
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InicioPantalla));
            panelMenu = new Panel();
            btnConvertir = new Button();
            btnDeposito = new Button();
            btnRetirar = new Button();
            pictureBoxLogo = new PictureBox();
            panelContenido = new Panel();
            groupBox1 = new GroupBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            panelContenido.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.AutoScroll = true;
            panelMenu.BackColor = Color.FromArgb(229, 34, 41);
            panelMenu.Controls.Add(button1);
            panelMenu.Controls.Add(btnConvertir);
            panelMenu.Controls.Add(btnDeposito);
            panelMenu.Controls.Add(btnRetirar);
            panelMenu.Controls.Add(pictureBoxLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Margin = new Padding(5, 6, 5, 6);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(413, 1122);
            panelMenu.TabIndex = 0;
            // 
            // btnConvertir
            // 
            btnConvertir.FlatAppearance.BorderSize = 0;
            btnConvertir.FlatAppearance.MouseOverBackColor = SystemColors.AppWorkspace;
            btnConvertir.FlatStyle = FlatStyle.Flat;
            btnConvertir.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConvertir.ForeColor = Color.White;
            btnConvertir.Location = new Point(5, 552);
            btnConvertir.Margin = new Padding(5, 6, 5, 6);
            btnConvertir.Name = "btnConvertir";
            btnConvertir.Size = new Size(401, 130);
            btnConvertir.TabIndex = 3;
            btnConvertir.Text = "Convertidor";
            btnConvertir.UseVisualStyleBackColor = true;
            btnConvertir.Click += btnConvertir_Click;
            // 
            // btnDeposito
            // 
            btnDeposito.FlatAppearance.BorderSize = 0;
            btnDeposito.FlatAppearance.MouseOverBackColor = SystemColors.AppWorkspace;
            btnDeposito.FlatStyle = FlatStyle.Flat;
            btnDeposito.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeposito.ForeColor = Color.White;
            btnDeposito.Location = new Point(0, 410);
            btnDeposito.Margin = new Padding(5, 6, 5, 6);
            btnDeposito.Name = "btnDeposito";
            btnDeposito.Size = new Size(406, 130);
            btnDeposito.TabIndex = 2;
            btnDeposito.Text = "Deposito";
            btnDeposito.UseVisualStyleBackColor = true;
            btnDeposito.Click += btnDeposito_Click;
            // 
            // btnRetirar
            // 
            btnRetirar.FlatAppearance.BorderSize = 0;
            btnRetirar.FlatAppearance.MouseOverBackColor = SystemColors.AppWorkspace;
            btnRetirar.FlatStyle = FlatStyle.Flat;
            btnRetirar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRetirar.ForeColor = Color.White;
            btnRetirar.Location = new Point(0, 268);
            btnRetirar.Margin = new Padding(5, 6, 5, 6);
            btnRetirar.Name = "btnRetirar";
            btnRetirar.Size = new Size(413, 130);
            btnRetirar.TabIndex = 1;
            btnRetirar.Text = "Retirar";
            btnRetirar.UseVisualStyleBackColor = true;
            btnRetirar.Click += btnRetirar_Click;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Image = (Image)resources.GetObject("pictureBoxLogo.Image");
            pictureBoxLogo.Location = new Point(0, 6);
            pictureBoxLogo.Margin = new Padding(5, 6, 5, 6);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(413, 250);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLogo.TabIndex = 0;
            pictureBoxLogo.TabStop = false;
            pictureBoxLogo.Click += pictureBoxLogo_Click;
            // 
            // panelContenido
            // 
            panelContenido.Controls.Add(groupBox1);
            panelContenido.Location = new Point(417, 0);
            panelContenido.Margin = new Padding(5, 6, 5, 6);
            panelContenido.Name = "panelContenido";
            panelContenido.Size = new Size(1186, 1122);
            panelContenido.TabIndex = 1;
            panelContenido.Paint += panelContenido_Paint;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(pictureBox3);
            groupBox1.Controls.Add(pictureBox2);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Margin = new Padding(5, 6, 5, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(5, 6, 5, 6);
            groupBox1.Size = new Size(1178, 1108);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(562, 644);
            pictureBox3.Margin = new Padding(5, 6, 5, 6);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(627, 438);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(-9, 590);
            pictureBox2.Margin = new Padding(5, 6, 5, 6);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(605, 538);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(204, 10);
            pictureBox1.Margin = new Padding(5, 6, 5, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(823, 548);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.FlatAppearance.BorderColor = Color.Black;
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(79, 1004);
            button1.Name = "button1";
            button1.Size = new Size(214, 40);
            button1.TabIndex = 4;
            button1.Text = "CERRAR SESIÓN";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // InicioPantalla
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1601, 1122);
            Controls.Add(panelContenido);
            Controls.Add(panelMenu);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 6, 5, 6);
            MinimumSize = new Size(1611, 1136);
            Name = "InicioPantalla";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "InicioPantalla";
            Load += InicioPantalla_Load;
            panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            panelContenido.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Button btnRetirar;
        private PictureBox pictureBoxLogo;
        private Button btnConvertir;
        private Button btnDeposito;
        private Panel panelContenido;
        private GroupBox groupBox1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Button button1;
    }
}