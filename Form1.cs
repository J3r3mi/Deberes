namespace InterfazGraficaUsuarios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            
            string nombreUsuario = txtNombre.Text;

            
            if (!string.IsNullOrWhiteSpace(nombreUsuario))
            {
               
                lstUsuarios.Items.Add(nombreUsuario);

                
                txtNombre.Clear();
            }
            else
            {
                // Mensaje de Advertencia.
                MessageBox.Show("Por favor, ingresa un nombre de usuario.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
