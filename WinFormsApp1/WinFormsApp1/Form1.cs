namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
    }
}
// ========================================================
// DOBLE CLIC EN BOTÓN "AGREGAR"
// ========================================================
// private void btnAgregar_Click(object sender, EventArgs e)
// {
p.AgregarProducto(
    txtNombre.Text,
    Convert.ToDouble(txtPrecio.Text));
MessageBox.Show("Datos Completos");
dgvProductos.Rows.Add(
    txtNombre.Text, txtPrecio.Text);
txtNombre.Clear();
txtPrecio.Clear();
// }

// ========================================================
// DOBLE CLIC EN BOTÓN "MOSTRAR"
// ========================================================
// private void btnMostrar_Click(object sender, EventArgs e)
// {
string datos = "";
dgvProductos.Rows.Clear();
for (int i = 0; i < p.nombres.Count; i++)
{
    datos += p.nombres[i] + "S/" +
        p.precios[i] + "\n";
}
MessageBox.Show(datos);
// }

// ========================================================
// DOBLE CLIC EN BOTÓN "REPLACE"
// ========================================================
// private void btnReplace_Click(object sender, EventArgs e)
// {
p.Reemplazar(
    txtVieja.Text,
    txtNueva.Text
    );
dgvProductos.Rows.Clear();
for (int i = 0; p.nombres.Count > 0; i++)
{
    dgvProductos.Rows.Add(
        p.nombres, p.precios);
}
MessageBox.Show("Palabra reemplazada");
// }

// ========================================================
// DOBLE CLIC EN BOTÓN "BUSCAR PALABRA"
// ========================================================
// private void BtnBuscarPa_Click(object sender, EventArgs e)
// {
MessageBox.Show(p.BuscarPalabra(txtBuscar.Text));
// }

// ========================================================
// DOBLE CLIC EN BOTÓN "BUSCAR PRODUCTO"
// ========================================================
// private void btnBuscarPro_Click(object sender, EventArgs e)
// {
int pos = p.Buscar(txtBuscar.Text);
if (pos != -1)
{
    MessageBox.Show(
        "Producto: " +
        p.nombres[pos] +
        "Precio: " +
        p.precios[pos]);
}
else
    MessageBox.Show("Producto no encontrado");
// }

// ========================================================
// DOBLE CLIC EN BOTÓN "SPLIT"
// ========================================================
// private void btnSplit_Click(object sender, EventArgs e)
// {
MessageBox.Show(p.SepararPalabra());
// }

// ========================================================
// DOBLE CLIC EN BOTÓN "SUBSTRING"
// ========================================================
// private void btnSubstring_Click(object sender, EventArgs e)
// {
MessageBox.Show(p.MostrarSubString());
// }

// ========================================================
// DOBLE CLIC EN BOTÓN "ORDENAR"
// ========================================================
// private void btnOrdenar_Click(object sender, EventArgs e)
// {
p.Ordenar();
dgvProductos.Rows.Clear();
dgvProductos.Rows.Clear();
for (int i = 0; p.nombres.Count > 0; i++)
{
    dgvProductos.Rows.Add(
        p.nombres, p.precios);
}
MessageBox.Show("Productos ordenados");
        // }
    }

   
    

