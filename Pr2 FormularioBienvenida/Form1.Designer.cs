namespace FormularioBienvenida
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
            lblNombre = new Label();
            txtNombre = new TextBox();
            txtEdad = new TextBox();
            lblEdad = new Label();
            lblResultado = new Label();
            btnAceptar = new Button();
            btnLimpiar = new Button();
            lblAyuda = new Label();
            lblCurso = new Label();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.ForeColor = Color.Yellow;
            lblNombre.Location = new Point(307, 125);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(54, 15);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre:";
            lblNombre.Click += lblNombre_Click;
            // 
            // txtNombre
            // 
            txtNombre.ForeColor = SystemColors.MenuHighlight;
            txtNombre.Location = new Point(367, 122);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(101, 23);
            txtNombre.TabIndex = 1;
            // 
            // txtEdad
            // 
            txtEdad.ForeColor = SystemColors.MenuHighlight;
            txtEdad.Location = new Point(367, 164);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(101, 23);
            txtEdad.TabIndex = 2;
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.ForeColor = Color.Yellow;
            lblEdad.Location = new Point(325, 167);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(36, 15);
            lblEdad.TabIndex = 3;
            lblEdad.Text = "Edad:";
            lblEdad.Click += lblEdad_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Times New Roman", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblResultado.ForeColor = Color.White;
            lblResultado.Location = new Point(343, 289);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(140, 15);
            lblResultado.TabIndex = 4;
            lblResultado.Text = "Aqui aparecera el resultado";
            lblResultado.Click += lblResultado_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(307, 234);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(76, 23);
            btnAceptar.TabIndex = 5;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(436, 234);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(76, 23);
            btnLimpiar.TabIndex = 6;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // lblAyuda
            // 
            lblAyuda.AutoSize = true;
            lblAyuda.Font = new Font("Segoe UI", 7F);
            lblAyuda.ForeColor = SystemColors.ButtonHighlight;
            lblAyuda.Location = new Point(367, 190);
            lblAyuda.Name = "lblAyuda";
            lblAyuda.Size = new Size(116, 12);
            lblAyuda.TabIndex = 7;
            lblAyuda.Text = "La edad debe ser positiva";
            // 
            // lblCurso
            // 
            lblCurso.AutoSize = true;
            lblCurso.Location = new Point(329, 426);
            lblCurso.Name = "lblCurso";
            lblCurso.Size = new Size(183, 15);
            lblCurso.TabIndex = 8;
            lblCurso.Text = "Desarrollo de Interfaces · 2.º DAM";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(799, 450);
            Controls.Add(lblCurso);
            Controls.Add(lblAyuda);
            Controls.Add(btnLimpiar);
            Controls.Add(btnAceptar);
            Controls.Add(lblResultado);
            Controls.Add(lblEdad);
            Controls.Add(txtEdad);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private TextBox txtNombre;
        private TextBox txtEdad;
        private Label lblEdad;
        private Label lblResultado;
        private Button btnAceptar;
        private Button btnLimpiar;
        private Label lblAyuda;
        private Label lblCurso;
    }
}
