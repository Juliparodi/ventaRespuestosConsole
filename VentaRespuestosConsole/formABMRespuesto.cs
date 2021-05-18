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

namespace VentaRespuestosConsole
{
    public partial class VentaRespuestos : Form
    {
        string _nombreComercio;
        string _direccion;
        public VentaRespuestos(string nombreComercio, string direccion, Form1 formAnterior)
        {
            this.Owner = formAnterior;
            this.NombreComercio = nombreComercio;
            this.Direccion = direccion;
            InitializeComponent();
        }

        public string NombreComercio { get => _nombreComercio; set => _nombreComercio = value; }
        public string Direccion { get => _direccion; set => _direccion = value; }

        private void formABMRespuesto_Load(object sender, EventArgs e)
        {
            cargarListas();
            limpiar();
            this.labelBienvenida.Text = getMensajeBienvenida();
        }

        private String getMensajeBienvenida()
        {
            return $"bienvenidos al home page del comercio: {this._nombreComercio.ToString()} con direccion: {this._direccion}";
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

        private void limpiar() {
            this.cmbCategoria.SelectedIndex = 0;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnVolver2_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }
    }
}
