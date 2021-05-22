using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VentaRespuestosController;
using VentaRespuestosEntidades.entidades;
using VentaRespuestosEntidades.exceptio_ns;

namespace VentaRespuestosConsole
{
    public partial class VentaRespuestos : Form
    {
        string _nombreComercio;
        string _direccion;
        List<Respuesto> listaProductos;
        Categoria categoriaAuto;
        Categoria categoriaCasa;
        Categoria categoriaLimpieza;
        public VentaRespuestos(string nombreComercio, string direccion, Form1 formAnterior)
        {
            this.Owner = formAnterior;
            this.NombreComercio = nombreComercio;
            this.Direccion = direccion;
            this.listaProductos = new List<Respuesto>();
            this.categoriaAuto = new Categoria(1, "Accesorio para autos");
            this.categoriaCasa = new Categoria(2, "Herramientas de casa");
            this.categoriaLimpieza = new Categoria(3, "utiles de limpieza");
            Respuesto repuestoAuto = new Respuesto(1, "neumatico", 1000, 5, categoriaAuto);
            Respuesto repuestoAuto2 = new Respuesto(2, "motor", 100, 3, categoriaAuto);
            Respuesto repuestoCasa = new Respuesto(3, "Mesa", 5000, 5, categoriaCasa);
            Respuesto repuestoCasa2 = new Respuesto(4, "Sillon", 20000, 3, categoriaCasa);
            Respuesto repuestoLimpieza = new Respuesto(5, "Trapo de piso", 50, 5, categoriaLimpieza);
            Respuesto repuestoLimpieza2 = new Respuesto(6, "lavandina", 100, 3, categoriaLimpieza);
            listaProductos.Add(repuestoAuto);
            listaProductos.Add(repuestoAuto2);
            listaProductos.Add(repuestoCasa);
            listaProductos.Add(repuestoCasa2);
            listaProductos.Add(repuestoLimpieza);
            listaProductos.Add(repuestoLimpieza2);

            InitializeComponent();
        }

        public string NombreComercio { get => _nombreComercio; set => _nombreComercio = value; }
        public string Direccion { get => _direccion; set => _direccion = value; }

        private void formABMRespuesto_Load(object sender, EventArgs e)
        {
            cargarListas();
            limpiar();
            this.labelBienvenida.Text = getMensajeBienvenida();
            this.lblFiltro.Text = getMensajeFiltro();
            listRepuestos.Text = "Elige un filtro";
        }

        private String getMensajeBienvenida()
        {
            string nombreComercioVar;
            if (this._nombreComercio.ToString() == "1")
            {
                nombreComercioVar = "Juli Repuestos S.A";
            }
            else
            {
                nombreComercioVar = "Mati Repuestos S.A";
            }
            return $"bienvenidos al home page del comercio: {nombreComercioVar} con direccion: {this._direccion}";
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void cargarListas()
        {
            this.cmbCategoria.DataSource = FormABMRespuestosController.GetListaCategorias();
            this.cmbCategoria.DisplayMember = "Descripcion";
            this.cmbCategoria.ValueMember = "Codigo";
        }

        private void limpiar()
        {
            this.cmbCategoria.SelectedIndex = 0;
        }

        private void insertarDatosEnListBox()
        {
            Categoria categoriaAuto = new Categoria(1, "Accesorio para autos");
            Categoria categoriaCasa = new Categoria(2, "Herramientas de casa");
            Categoria categoriaLimpieza = new Categoria(3, "limpieza");


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnVolver2_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void lblFiltro_Click(object sender, EventArgs e)
        {
            lblFiltro.Text = "Por favor seleccione categoria y luego oprima el botton de filtrado";
        }

        private String getMensajeFiltro()
        {
            return "Por favor seleccione categoria y luego oprima el botton de mostrar";
        }

        private void btnMostrarListaCat_Click(object sender, EventArgs e)
        {
            listRepuestos.DataSource = null;
            if (this.cmbCategoria.SelectedIndex == 0)
            {
                MessageBox.Show("Por favor seleccione una categoria");
            }
            else if (this.cmbCategoria.SelectedIndex == 1)
            {
                List<Respuesto> listaRepuestoAutos = listaProductos.Where(l => l.Categoria.Codigo == this.categoriaAuto.Codigo).ToList();
                listRepuestos.DataSource = listaRepuestoAutos;
            }
            else if (this.cmbCategoria.SelectedIndex == 2)
            {
                List<Respuesto> listaRepuestoCasas = listaProductos.Where(l => l.Categoria.Codigo == this.categoriaCasa.Codigo).ToList();
                listRepuestos.DataSource = listaRepuestoCasas;
            }
            else if (this.cmbCategoria.SelectedIndex == 3)
            {
                List<Respuesto> listaRepuestoLimpieza = listaProductos.Where(l => l.Categoria.Codigo == this.categoriaLimpieza.Codigo).ToList();
                listRepuestos.DataSource = listaRepuestoLimpieza;
            }
        }

        private void agregarRepuesto_Click(object sender, EventArgs e)
        {
            try
            {
                listRepuestos.DataSource = null;
                validar();
                Respuesto repuestoAAgregar = new Respuesto(int.Parse(txtStock.Text), txtName.Text, Double.Parse(txtPrecio.Text), int.Parse(txtStock.Text));
                if (cmbCategoria.SelectedIndex == 1)
                {
                    repuestoAAgregar.Categoria = this.categoriaAuto;
                }
                else if (cmbCategoria.SelectedIndex == 2)
                {
                    repuestoAAgregar.Categoria = this.categoriaCasa;
                }
                else if (cmbCategoria.SelectedIndex == 3)
                {
                    repuestoAAgregar.Categoria = this.categoriaLimpieza;
                }

                listaProductos.Add(repuestoAAgregar);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void validar()
        {
            if (this.cmbCategoria.SelectedIndex == 0)
            {
                MessageBox.Show("Por favor seleccione una categoria");
            }
            if (txtCodigo == null || txtName == null || txtPrecio == null || txtStock == null)
            {
                throw new Exception("Parametros invalidos, intente nuevamente");
            }
        }

        private void listRepuestos_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (listRepuestos.SelectedIndex == null)
                {
                    throw new Exception("Por favor parese en algun lado");
                }
                Respuesto respuesto = (Respuesto)listRepuestos.SelectedValue;
                if (respuesto == null)
                {
                    throw new Exception("Repuesto vacio");
                }
                txtName.Text = respuesto.Nombre;
                txtCodigo.Text = respuesto.Codigo.ToString();
                txtPrecio.Text = respuesto.Precio.ToString();
                txtStock.Text = respuesto.Stock.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void modificarPrecio_Click(object sender, EventArgs e)
        {
            if (txtPrecio.Text == null || txtCodigo == null)
            {
                MessageBox.Show("valores nulo, intente nuevamente");
            }

            listaProductos.Where(l => l.Codigo == int.Parse(txtCodigo.Text)).ToList().ForEach(l => l.Precio = double.Parse(txtPrecio.Text));

        }

        private void quitarRepuesto_Click(object sender, EventArgs e)
        {
            try
            {
                validar();

                if (int.Parse(txtStock.Text) <= 0)
                {
                    throw new StockLessTanZeroException("El stock es menor q cero");
                }

                Respuesto respuestoAEliminar = listaProductos.FirstOrDefault(l => l.Codigo == int.Parse(txtCodigo.Text));
                if (respuestoAEliminar == null)
                {
                    throw new Exception("Cliente no existente");
                }
                listaProductos.Remove(respuestoAEliminar);
                listRepuestos.DataSource = null;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void agregarStock_Click(object sender, EventArgs e)
        {
            try
            {
                validar();

                Respuesto respuestoAEliminar = listaProductos.FirstOrDefault(l => l.Codigo == int.Parse(txtCodigo.Text));
                respuestoAEliminar.Stock = int.Parse(txtStock.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
               
            }
        }

        private void quitarStock_Click(object sender, EventArgs e)
        {
            try
            {
                validar();

                Respuesto respuestoAEliminarStock = listaProductos.FirstOrDefault(l => l.Codigo == int.Parse(txtCodigo.Text));
                respuestoAEliminarStock.Stock = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
        }

        private void actualizar_Click(object sender, EventArgs e)
        {
            if (this.cmbCategoria.SelectedIndex == 0)
            {
                MessageBox.Show("Por favor seleccione una categoria");
            }
            else if (this.cmbCategoria.SelectedIndex == 1)
            {
                List<Respuesto> listaRepuestoAutos = listaProductos.Where(l => l.Categoria.Codigo == this.categoriaAuto.Codigo).ToList();
                listRepuestos.DataSource = listaRepuestoAutos;
            }
            else if (this.cmbCategoria.SelectedIndex == 2)
            {
                List<Respuesto> listaRepuestoCasas = listaProductos.Where(l => l.Categoria.Codigo == this.categoriaCasa.Codigo).ToList();
                listRepuestos.DataSource = listaRepuestoCasas;
            }
            else if (this.cmbCategoria.SelectedIndex == 3)
            {
                List<Respuesto> listaRepuestoLimpieza = listaProductos.Where(l => l.Categoria.Codigo == this.categoriaLimpieza.Codigo).ToList();
                listRepuestos.DataSource = listaRepuestoLimpieza;
            }

        }
    }
}
