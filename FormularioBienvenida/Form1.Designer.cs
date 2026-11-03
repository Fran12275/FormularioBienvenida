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
            lblNombre.Location = new Point(307, 167);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(54, 15);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(367, 159);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(101, 23);
            txtNombre.TabIndex = 1;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(367, 207);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(101, 23);
            txtEdad.TabIndex = 2;
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Location = new Point(325, 210);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(36, 15);
            lblEdad.TabIndex = 3;
            lblEdad.Text = "Edad:";
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(345, 333);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(150, 15);
            lblResultado.TabIndex = 4;
            lblResultado.Text = "Aqui aparecera el resultado";
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(337, 274);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(76, 23);
            btnAceptar.TabIndex = 5;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(419, 274);
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
            lblAyuda.Location = new Point(367, 233);
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
            lblCurso.Size = new Size(166, 15);
            lblCurso.TabIndex = 8;
            lblCurso.Text = "Desarrollo de Interfaces · DAM";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
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
