namespace Proyecto_Mibanco
{
    partial class RetirarContenido
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
            lbl_Seleccionelacantidad = new Label();
            groupBoxRetirar = new GroupBox();
            rtboxCantidadRetirar = new RichTextBox();
            gboxBtonesCajero = new GroupBox();
            btnEnterRetirar = new Button();
            btnBorrarNumero = new Button();
            btnNumero0 = new Button();
            btnNumero9 = new Button();
            btnNumero8 = new Button();
            btnNumero6 = new Button();
            btnNumero5 = new Button();
            btnNumero3 = new Button();
            btnNumero2 = new Button();
            btnNumero4 = new Button();
            btnNumero7 = new Button();
            btnNumero1 = new Button();
            groupBoxRetirar.SuspendLayout();
            gboxBtonesCajero.SuspendLayout();
            SuspendLayout();
            // 
            // lbl_Seleccionelacantidad
            // 
            lbl_Seleccionelacantidad.AutoSize = true;
            lbl_Seleccionelacantidad.Font = new Font("SF Pro Display", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Seleccionelacantidad.Location = new Point(176, 49);
            lbl_Seleccionelacantidad.Name = "lbl_Seleccionelacantidad";
            lbl_Seleccionelacantidad.Size = new Size(358, 25);
            lbl_Seleccionelacantidad.TabIndex = 0;
            lbl_Seleccionelacantidad.Text = "Ingrese la cantidad que desea retirar";
            // 
            // groupBoxRetirar
            // 
            groupBoxRetirar.BackColor = Color.White;
            groupBoxRetirar.Controls.Add(rtboxCantidadRetirar);
            groupBoxRetirar.Controls.Add(gboxBtonesCajero);
            groupBoxRetirar.Controls.Add(lbl_Seleccionelacantidad);
            groupBoxRetirar.FlatStyle = FlatStyle.Flat;
            groupBoxRetirar.Location = new Point(3, -2);
            groupBoxRetirar.Name = "groupBoxRetirar";
            groupBoxRetirar.Size = new Size(686, 551);
            groupBoxRetirar.TabIndex = 1;
            groupBoxRetirar.TabStop = false;
            // 
            // rtboxCantidadRetirar
            // 
            rtboxCantidadRetirar.BackColor = SystemColors.ScrollBar;
            rtboxCantidadRetirar.BorderStyle = BorderStyle.None;
            rtboxCantidadRetirar.Font = new Font("Segoe UI", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rtboxCantidadRetirar.Location = new Point(192, 90);
            rtboxCantidadRetirar.Name = "rtboxCantidadRetirar";
            rtboxCantidadRetirar.ScrollBars = RichTextBoxScrollBars.None;
            rtboxCantidadRetirar.Size = new Size(317, 111);
            rtboxCantidadRetirar.TabIndex = 24;
            rtboxCantidadRetirar.Text = "";
            // 
            // gboxBtonesCajero
            // 
            gboxBtonesCajero.Controls.Add(btnEnterRetirar);
            gboxBtonesCajero.Controls.Add(btnBorrarNumero);
            gboxBtonesCajero.Controls.Add(btnNumero0);
            gboxBtonesCajero.Controls.Add(btnNumero9);
            gboxBtonesCajero.Controls.Add(btnNumero8);
            gboxBtonesCajero.Controls.Add(btnNumero6);
            gboxBtonesCajero.Controls.Add(btnNumero5);
            gboxBtonesCajero.Controls.Add(btnNumero3);
            gboxBtonesCajero.Controls.Add(btnNumero2);
            gboxBtonesCajero.Controls.Add(btnNumero4);
            gboxBtonesCajero.Controls.Add(btnNumero7);
            gboxBtonesCajero.Controls.Add(btnNumero1);
            gboxBtonesCajero.Location = new Point(222, 204);
            gboxBtonesCajero.Margin = new Padding(0);
            gboxBtonesCajero.Name = "gboxBtonesCajero";
            gboxBtonesCajero.Size = new Size(255, 306);
            gboxBtonesCajero.TabIndex = 23;
            gboxBtonesCajero.TabStop = false;
            // 
            // btnEnterRetirar
            // 
            btnEnterRetirar.BackColor = Color.Green;
            btnEnterRetirar.FlatAppearance.BorderSize = 0;
            btnEnterRetirar.FlatStyle = FlatStyle.Flat;
            btnEnterRetirar.Location = new Point(13, 219);
            btnEnterRetirar.Name = "btnEnterRetirar";
            btnEnterRetirar.Size = new Size(70, 61);
            btnEnterRetirar.TabIndex = 24;
            btnEnterRetirar.Text = "ENTER";
            btnEnterRetirar.UseVisualStyleBackColor = false;
            btnEnterRetirar.Click += btnEnterRetirar_Click;
            // 
            // btnBorrarNumero
            // 
            btnBorrarNumero.BackColor = Color.Red;
            btnBorrarNumero.FlatAppearance.BorderSize = 0;
            btnBorrarNumero.FlatStyle = FlatStyle.Flat;
            btnBorrarNumero.Location = new Point(165, 219);
            btnBorrarNumero.Name = "btnBorrarNumero";
            btnBorrarNumero.Size = new Size(70, 61);
            btnBorrarNumero.TabIndex = 23;
            btnBorrarNumero.Text = "BORRAR";
            btnBorrarNumero.UseVisualStyleBackColor = false;
            btnBorrarNumero.Click += btnBorrarNumero_Click;
            // 
            // btnNumero0
            // 
            btnNumero0.Location = new Point(89, 219);
            btnNumero0.Name = "btnNumero0";
            btnNumero0.Size = new Size(70, 61);
            btnNumero0.TabIndex = 22;
            btnNumero0.Text = "0";
            btnNumero0.UseVisualStyleBackColor = true;
            btnNumero0.Click += btnNumero0_Click;
            // 
            // btnNumero9
            // 
            btnNumero9.Location = new Point(165, 152);
            btnNumero9.Name = "btnNumero9";
            btnNumero9.Size = new Size(70, 61);
            btnNumero9.TabIndex = 21;
            btnNumero9.Text = "9";
            btnNumero9.UseVisualStyleBackColor = true;
            btnNumero9.Click += btnNumero9_Click;
            // 
            // btnNumero8
            // 
            btnNumero8.Location = new Point(89, 152);
            btnNumero8.Name = "btnNumero8";
            btnNumero8.Size = new Size(70, 61);
            btnNumero8.TabIndex = 20;
            btnNumero8.Text = "8";
            btnNumero8.UseVisualStyleBackColor = true;
            btnNumero8.Click += btnNumero8_Click;
            // 
            // btnNumero6
            // 
            btnNumero6.Location = new Point(165, 85);
            btnNumero6.Name = "btnNumero6";
            btnNumero6.Size = new Size(70, 61);
            btnNumero6.TabIndex = 19;
            btnNumero6.Text = "6";
            btnNumero6.UseVisualStyleBackColor = true;
            btnNumero6.Click += btnNumero6_Click;
            // 
            // btnNumero5
            // 
            btnNumero5.Location = new Point(89, 85);
            btnNumero5.Name = "btnNumero5";
            btnNumero5.Size = new Size(70, 61);
            btnNumero5.TabIndex = 18;
            btnNumero5.Text = "5";
            btnNumero5.UseVisualStyleBackColor = true;
            btnNumero5.Click += btnNumero5_Click;
            // 
            // btnNumero3
            // 
            btnNumero3.Location = new Point(165, 18);
            btnNumero3.Name = "btnNumero3";
            btnNumero3.Size = new Size(70, 61);
            btnNumero3.TabIndex = 17;
            btnNumero3.Text = "3";
            btnNumero3.UseVisualStyleBackColor = true;
            btnNumero3.Click += btnNumero3_Click;
            // 
            // btnNumero2
            // 
            btnNumero2.Location = new Point(89, 18);
            btnNumero2.Name = "btnNumero2";
            btnNumero2.Size = new Size(70, 61);
            btnNumero2.TabIndex = 16;
            btnNumero2.Text = "2";
            btnNumero2.UseVisualStyleBackColor = true;
            btnNumero2.Click += btnNumero2_Click;
            // 
            // btnNumero4
            // 
            btnNumero4.Location = new Point(13, 85);
            btnNumero4.Name = "btnNumero4";
            btnNumero4.Size = new Size(70, 61);
            btnNumero4.TabIndex = 15;
            btnNumero4.Text = "4";
            btnNumero4.UseVisualStyleBackColor = true;
            btnNumero4.Click += btnNumero4_Click;
            // 
            // btnNumero7
            // 
            btnNumero7.Location = new Point(13, 152);
            btnNumero7.Name = "btnNumero7";
            btnNumero7.Size = new Size(70, 61);
            btnNumero7.TabIndex = 14;
            btnNumero7.Text = "7";
            btnNumero7.UseVisualStyleBackColor = true;
            btnNumero7.Click += btnNumero7_Click;
            // 
            // btnNumero1
            // 
            btnNumero1.Location = new Point(13, 18);
            btnNumero1.Name = "btnNumero1";
            btnNumero1.Size = new Size(70, 61);
            btnNumero1.TabIndex = 13;
            btnNumero1.Text = "1";
            btnNumero1.UseVisualStyleBackColor = true;
            btnNumero1.Click += btnNumero1_Click;
            // 
            // RetirarContenido
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(692, 561);
            Controls.Add(groupBoxRetirar);
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(692, 561);
            Name = "RetirarContenido";
            Text = "RetirarContenido";
            groupBoxRetirar.ResumeLayout(false);
            groupBoxRetirar.PerformLayout();
            gboxBtonesCajero.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label lbl_Seleccionelacantidad;
        private GroupBox groupBoxRetirar;
        private GroupBox gboxBtonesCajero;
        private Button btnEnterRetirar;
        private Button btnBorrarNumero;
        private Button btnNumero0;
        private Button btnNumero9;
        private Button btnNumero8;
        private Button btnNumero6;
        private Button btnNumero5;
        private Button btnNumero3;
        private Button btnNumero2;
        private Button btnNumero4;
        private Button btnNumero7;
        private Button btnNumero1;
        private RichTextBox rtboxCantidadRetirar;
    }
}