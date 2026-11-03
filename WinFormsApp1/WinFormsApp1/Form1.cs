using WindowsFormsApp1;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        GestorProducto gestor = new GestorProducto();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto(
                txtCodigo.Text,
                txtNombre.Text,
                Convert.ToDouble(txtPrecio.Text),
                Convert.ToInt32(txtStock.Text)
            );
            gestor.AgregarProducto(producto);
            MessageBox.Show("Producto agregado correctamente");
            Limpiar();
        }
        private void Limpiar()
        {
            txtCodigo.Clear();
            txtNombre.Clear();
            txtPrecio.Clear();
            txtStock.Clear();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            foreach (Producto p in gestor.MostrarProducto())
            {
                dataGridView1.Rows.Add(
                    p.Codigo, p.Nombre, p.Precio, p.Stock);
            }
        }

        private void btnGuardarTxt_Click(object sender, EventArgs e)
        {
            gestor.GuardarTexto("productos.txt");
            MessageBox.Show("Datos guardados correctamente en Txt");
        }

        private void btnLeerTxt_Click(object sender, EventArgs e)
        {
            gestor.LeerTexto("productos.txt");
            gestor.MostrarProducto();
            MessageBox.Show("Datos leídos correctamente desde Txt");
        }

        private void btnGuardarBin_Click(object sender, EventArgs e)
        {
            gestor.GuardarBinario("productos.dat");
            MessageBox.Show("Datos guardados correctamente en Binario");
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            gestor.LeerBinario("productos.dat");
            gestor.MostrarProducto();
            MessageBox.Show("Datos leídos correctamente desde Binario");
        }
    }
}

    

