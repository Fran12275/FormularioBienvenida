namespace FormularioBienvenida
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string textoEdad = txtEdad.Text;

            if (string.IsNullOrWhiteSpace(nombre))
            {
                MessageBox.Show("Por favor, ingrese su nombre.");
                return;
            }

            if (!int.TryParse(textoEdad, out int edad) || edad < 0)
            {
                MessageBox.Show("Introduce una edad válida.");
                return;
            }

            lblResultado.Text =
                $"Hola, {nombre}. \n{((edad < 18) ? $"Tienes {edad} años y eres menor" : $"Tienes {edad} años")}";

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtEdad.Clear();
            lblResultado.Text = "";
        }
    }
}
