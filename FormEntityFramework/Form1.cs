using FormEntityFramework.Database;
using FormEntityFramework.Models;

namespace FormEntityFramework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCargarDatos_Click(object sender, EventArgs e)
        {
            using (DataBaseContext context = new DataBaseContext()) {

                List<Usuario> productos = context.Usuarios.ToList();

                this.dgvLista.DataSource = productos;

            }
        }
    }
}

