using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        GestorBiblioteca gestor = new GestorBiblioteca();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (Utilidades.ValidarCampoVacio(txtCodigo.Text))
            {
                Utilidades.MostrarMensaje("Ingrese el Codigo:");
                txtCodigo.Focus();
                return;
            }
            if (Utilidades.ValidarCampoVacio(txtTitulo.Text)) 
            {
                Utilidades.MostrarMensaje("Ingrese el titulo");
                txtTitulo.Focus();
                return;
            }
            if (Utilidades.ValidarCampoVacio(txtAutor.Text)) 
            {
                Utilidades.MostrarMensaje("Ingrese el Autor:");
                txtAutor.Focus();
                return;
            }
            int anio;
            if (!int.TryParse(txtAnio.Text, out anio))
            {
                Utilidades.MostrarMensaje("Ingrese un año valido");
                txtAnio.Focus();
                return;
            }
            Libro libro = new Libro(
                txtCodigo.Text, txtTitulo.Text, txtAutor.Text,
                anio);
            gestor.AgregarLibro(libro);
            Utilidades.MostrarMensaje("Libro registrado correctamente");
            

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            MostrarDatos();
        }

        private void MostrarDatos()
        {
            dgvLibros.Rows.Clear();
            foreach (Libro libro in gestor.ObtenerLibros())
            {
                dgvLibros.Rows.Add(
                    libro.Codigo,
                    libro.Titulo,
                    libro.Autor,
                    libro.AnioPublicacion
                    );
            }
            lblTotaldeLibros.Text = "Total Libros:" + dgvLibros.Rows.Count;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Libro libro = gestor.BuscarLibro(txtCodigo.Text);
            if ( libro != null )
            {
                txtTitulo.Text = libro.Titulo;
                txtCodigo.Text = libro.Codigo;
                txtAnio.Text = libro.AnioPublicacion.ToString();
                Utilidades.MostrarMensaje("Libro encontrado");
            }
            else
            {
                Utilidades.MostrarMensaje("Libro no encontrado");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            bool eliminado = gestor.EliminarLibro(txtCodigo.Text);
            if (eliminado)
            {
                Utilidades.MostrarMensaje("Libro eliminado");
                MostrarDatos();
            }
            else
            {
                Utilidades.MostrarMensaje("El Codigo no existe");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Utilidades.LimpiarTextBox(
                txtCodigo, txtTitulo, txtAutor, txtAnio);
        }
        //codigo para el guardar txt
        private void btnGuardarTxt_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog dialogo = new SaveFileDialog())
            {
                dialogo.Filter = "Archivo de texto (*.txt)|*.txt";
                dialogo.FileName = "libros.txt";

                if (dialogo.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter escritor = new StreamWriter(dialogo.FileName))
                    {
                        foreach (Libro libro in listaLibros)
                        {
                            escritor.WriteLine(
                                $"{libro.Codigo}|{libro.Titulo}|{libro.Autor}|{libro.AnioPublicacion}");
                        }
                    }

                    MessageBox.Show("Libros guardados en TXT.");
                }
            }
        }

        //codigo para leer txt
        private void btnLeerTxt_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialogo = new OpenFileDialog())
            {
                dialogo.Filter = "Archivo de texto (*.txt)|*.txt";

                if (dialogo.ShowDialog() == DialogResult.OK)
                {
                    listaLibros.Clear();

                    foreach (string linea in File.ReadAllLines(dialogo.FileName))
                    {
                        string[] datos = linea.Split('|');

                        if (datos.Length == 4 &&
                            int.TryParse(datos[3], out int anio))
                        {
                            listaLibros.Add(new Libro
                            {
                                Codigo = datos[0],
                                Titulo = datos[1],
                                Autor = datos[2],
                                AnioPublicacion = anio
                            });
                        }
                    }

                    MostrarLibros();
                    MessageBox.Show("Libros cargados desde TXT.");
                }
            }
        }

        //codigo para guardar bin
        private void btnGuardarBin_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog dialogo = new SaveFileDialog())
            {
                dialogo.Filter = "Archivo binario (*.bin)|*.bin";
                dialogo.FileName = "libros.bin";

                if (dialogo.ShowDialog() == DialogResult.OK)
                {
                    using (FileStream archivo = new FileStream(
                        dialogo.FileName, FileMode.Create))
                    {
                        BinaryFormatter serializador = new BinaryFormatter();
                        serializador.Serialize(archivo, listaLibros);
                    }

                    MessageBox.Show("Libros guardados en BIN.");
                }
            }
        }

        //codigo para leer bin
        private void btnLeerBin_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialogo = new OpenFileDialog())
            {
                dialogo.Filter = "Archivo binario (*.bin)|*.bin";

                if (dialogo.ShowDialog() == DialogResult.OK)
                {
                    using (FileStream archivo = new FileStream(
                        dialogo.FileName, FileMode.Open))
                    {
                        BinaryFormatter serializador = new BinaryFormatter();
                        listaLibros =
                            (List<Libro>)serializador.Deserialize(archivo);
                    }

                    MostrarLibros();
                    MessageBox.Show("Libros cargados desde BIN.");
                }
            }
        }
    }
}
