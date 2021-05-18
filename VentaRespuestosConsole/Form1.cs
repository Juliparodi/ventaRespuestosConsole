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
using VentaRespuestosEntidades.exceptio_ns;

namespace VentaRespuestosConsole
{
    public partial class Form1 : Form
    {
        string _direccion;

        public string Direccion { get => _direccion; set => _direccion = value; }

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_botonBienvenida_Click(object sender, EventArgs e)
        {
                try
                {
                    validar();
                setearDireccion();
                VentaRespuestos formABMRespuesto = new VentaRespuestos(this.cmbNombreComercio.SelectedIndex.ToString(), this._direccion, this);
                    formABMRespuesto.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
        }

        private void setearDireccion()
        {
            if ((int)cmbNombreComercio.SelectedValue == 1) {
                this._direccion = "Av corrientes 1999";
            } else if ((int)cmbNombreComercio.SelectedValue == 2)
            {
                this._direccion = "Av cordoba 1989";
            } else
            {
                throw new ComercioNotFoundException("No se pudo encontrar al comercio");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cargarListas();
            limpiar();
            
        }

        private void cargarListas()
        {
            this.cmbNombreComercio.DataSource = Forms1Controller.getListaNombreComercio();
            this.cmbNombreComercio.DisplayMember = "Descripcion";
            this.cmbNombreComercio.ValueMember = "Codigo";

        }

        private void limpiar()
        {
            this.cmbNombreComercio.SelectedIndex = 0;
        }

        private void validar()
        {
            if ((int)cmbNombreComercio.SelectedValue == 0)
                throw new Exception("Seleccione nombre Comercio");
            
        }
    }
}
