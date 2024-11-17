namespace Proyecto_Mibanco
{
    partial class FormPConvertidor
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
            btnLimpiar = new Button();
            lblIngresar = new Label();
            textBoxIngresarCant = new TextBox();
            lblConvertia = new Label();
            cboxTipoCammbio = new ComboBox();
            lblEquivale = new Label();
            textBoxConvert = new TextBox();
            lblInfoCambio = new Label();
            SuspendLayout();
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.Red;
            btnLimpiar.FlatAppearance.BorderSize = 0;
            btnLimpiar.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Location = new Point(245, 463);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(264, 42);
            btnLimpiar.TabIndex = 13;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // lblIngresar
            // 
            lblIngresar.AutoSize = true;
            lblIngresar.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblIngresar.Location = new Point(74, 39);
            lblIngresar.Name = "lblIngresar";
            lblIngresar.Size = new Size(174, 30);
            lblIngresar.TabIndex = 14;
            lblIngresar.Text = "Ingresar cantidad";
            // 
            // textBoxIngresarCant
            // 
            textBoxIngresarCant.BackColor = Color.FromArgb(192, 0, 0);
            textBoxIngresarCant.BorderStyle = BorderStyle.None;
            textBoxIngresarCant.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxIngresarCant.ForeColor = SystemColors.InactiveBorder;
            textBoxIngresarCant.Location = new Point(278, 39);
            textBoxIngresarCant.Name = "textBoxIngresarCant";
            textBoxIngresarCant.Size = new Size(206, 32);
            textBoxIngresarCant.TabIndex = 15;
            // 
            // lblConvertia
            // 
            lblConvertia.AutoSize = true;
            lblConvertia.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblConvertia.Location = new Point(129, 190);
            lblConvertia.Name = "lblConvertia";
            lblConvertia.Size = new Size(119, 30);
            lblConvertia.TabIndex = 16;
            lblConvertia.Text = "Convertir a:";
            // 
            // cboxTipoCammbio
            // 
            cboxTipoCammbio.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboxTipoCammbio.FormattingEnabled = true;
            cboxTipoCammbio.Items.AddRange(new object[] { "Dolares", "Euros", "Libra esterlina" });
            cboxTipoCammbio.Location = new Point(278, 180);
            cboxTipoCammbio.Name = "cboxTipoCammbio";
            cboxTipoCammbio.Size = new Size(206, 40);
            cboxTipoCammbio.TabIndex = 17;
            cboxTipoCammbio.SelectedIndexChanged += cboxTipoCammbio_SelectedIndexChanged;
            cboxTipoCammbio.Click += cboxTipoCammbio_Click;
            // 
            // lblEquivale
            // 
            lblEquivale.AutoSize = true;
            lblEquivale.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEquivale.Location = new Point(136, 328);
            lblEquivale.Name = "lblEquivale";
            lblEquivale.Size = new Size(112, 30);
            lblEquivale.TabIndex = 18;
            lblEquivale.Text = "Equivale a:";
            // 
            // textBoxConvert
            // 
            textBoxConvert.BackColor = Color.FromArgb(192, 0, 0);
            textBoxConvert.BorderStyle = BorderStyle.None;
            textBoxConvert.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxConvert.ForeColor = SystemColors.InactiveBorder;
            textBoxConvert.Location = new Point(278, 339);
            textBoxConvert.Name = "textBoxConvert";
            textBoxConvert.Size = new Size(206, 32);
            textBoxConvert.TabIndex = 19;
            textBoxConvert.TextChanged += textBoxConvert_TextChanged;
            // 
            // lblInfoCambio
            // 
            lblInfoCambio.AutoSize = true;
            lblInfoCambio.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInfoCambio.Location = new Point(529, 339);
            lblInfoCambio.Name = "lblInfoCambio";
            lblInfoCambio.Size = new Size(66, 25);
            lblInfoCambio.TabIndex = 20;
            lblInfoCambio.Text = "lblinfo";
            lblInfoCambio.Visible = false;
            // 
            // FormPConvertidor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(692, 561);
            Controls.Add(lblInfoCambio);
            Controls.Add(textBoxConvert);
            Controls.Add(lblEquivale);
            Controls.Add(cboxTipoCammbio);
            Controls.Add(lblConvertia);
            Controls.Add(textBoxIngresarCant);
            Controls.Add(lblIngresar);
            Controls.Add(btnLimpiar);
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(692, 561);
            Name = "FormPConvertidor";
            Text = "FormPConvertidor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnLimpiar;
        private Label lblIngresar;
        private TextBox textBoxIngresarCant;
        private Label lblConvertia;
        private ComboBox cboxTipoCammbio;
        private Label lblEquivale;
        private TextBox textBoxConvert;
        private Label lblInfoCambio;
    }
}