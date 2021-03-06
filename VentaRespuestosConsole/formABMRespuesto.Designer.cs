namespace VentaRespuestosConsole
{
    partial class VentaRespuestos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelBienvenida = new System.Windows.Forms.Label();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listRepuestos = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.agregarRepuesto = new System.Windows.Forms.Button();
            this.modificarPrecio = new System.Windows.Forms.Button();
            this.quitarRepuesto = new System.Windows.Forms.Button();
            this.agregarStock = new System.Windows.Forms.Button();
            this.btnVolver2 = new System.Windows.Forms.Button();
            this.quitarStock = new System.Windows.Forms.Button();
            this.btnMostrarListaCat = new System.Windows.Forms.Button();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.actualizar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelBienvenida
            // 
            this.labelBienvenida.AutoSize = true;
            this.labelBienvenida.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBienvenida.Location = new System.Drawing.Point(65, 29);
            this.labelBienvenida.Name = "labelBienvenida";
            this.labelBienvenida.Size = new System.Drawing.Size(12, 18);
            this.labelBienvenida.TabIndex = 0;
            this.labelBienvenida.Text = "l";
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(113, 94);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(121, 21);
            this.cmbCategoria.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Categoria";
            // 
            // listRepuestos
            // 
            this.listRepuestos.FormattingEnabled = true;
            this.listRepuestos.Location = new System.Drawing.Point(12, 131);
            this.listRepuestos.Name = "listRepuestos";
            this.listRepuestos.Size = new System.Drawing.Size(306, 212);
            this.listRepuestos.TabIndex = 4;
            this.listRepuestos.SelectedIndexChanged += new System.EventHandler(this.listRepuestos_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(390, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "codigo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(387, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "nombre";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(387, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "precio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(387, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "stock";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(457, 69);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 9;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(457, 109);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 10;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(457, 147);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 20);
            this.txtPrecio.TabIndex = 11;
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(457, 183);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(100, 20);
            this.txtStock.TabIndex = 12;
            // 
            // agregarRepuesto
            // 
            this.agregarRepuesto.Location = new System.Drawing.Point(333, 221);
            this.agregarRepuesto.Name = "agregarRepuesto";
            this.agregarRepuesto.Size = new System.Drawing.Size(106, 23);
            this.agregarRepuesto.TabIndex = 13;
            this.agregarRepuesto.Text = "agregarRepuesto";
            this.agregarRepuesto.UseVisualStyleBackColor = true;
            this.agregarRepuesto.Click += new System.EventHandler(this.agregarRepuesto_Click);
            // 
            // modificarPrecio
            // 
            this.modificarPrecio.Location = new System.Drawing.Point(457, 221);
            this.modificarPrecio.Name = "modificarPrecio";
            this.modificarPrecio.Size = new System.Drawing.Size(100, 23);
            this.modificarPrecio.TabIndex = 14;
            this.modificarPrecio.Text = "modificarPrecio";
            this.modificarPrecio.UseVisualStyleBackColor = true;
            this.modificarPrecio.Click += new System.EventHandler(this.modificarPrecio_Click);
            // 
            // quitarRepuesto
            // 
            this.quitarRepuesto.Location = new System.Drawing.Point(583, 221);
            this.quitarRepuesto.Name = "quitarRepuesto";
            this.quitarRepuesto.Size = new System.Drawing.Size(93, 23);
            this.quitarRepuesto.TabIndex = 15;
            this.quitarRepuesto.Text = "quitarRespuesto";
            this.quitarRepuesto.UseVisualStyleBackColor = true;
            this.quitarRepuesto.Click += new System.EventHandler(this.quitarRepuesto_Click);
            // 
            // agregarStock
            // 
            this.agregarStock.Location = new System.Drawing.Point(345, 279);
            this.agregarStock.Name = "agregarStock";
            this.agregarStock.Size = new System.Drawing.Size(75, 23);
            this.agregarStock.TabIndex = 16;
            this.agregarStock.Text = "agregarStock";
            this.agregarStock.UseVisualStyleBackColor = true;
            this.agregarStock.Click += new System.EventHandler(this.agregarStock_Click);
            // 
            // btnVolver2
            // 
            this.btnVolver2.Location = new System.Drawing.Point(583, 279);
            this.btnVolver2.Name = "btnVolver2";
            this.btnVolver2.Size = new System.Drawing.Size(75, 23);
            this.btnVolver2.TabIndex = 18;
            this.btnVolver2.Text = "volver";
            this.btnVolver2.UseVisualStyleBackColor = true;
            this.btnVolver2.Click += new System.EventHandler(this.btnVolver2_Click);
            // 
            // quitarStock
            // 
            this.quitarStock.Location = new System.Drawing.Point(457, 279);
            this.quitarStock.Name = "quitarStock";
            this.quitarStock.Size = new System.Drawing.Size(75, 23);
            this.quitarStock.TabIndex = 19;
            this.quitarStock.Text = "quitarStock";
            this.quitarStock.UseVisualStyleBackColor = true;
            this.quitarStock.Click += new System.EventHandler(this.quitarStock_Click);
            // 
            // btnMostrarListaCat
            // 
            this.btnMostrarListaCat.Location = new System.Drawing.Point(48, 377);
            this.btnMostrarListaCat.Name = "btnMostrarListaCat";
            this.btnMostrarListaCat.Size = new System.Drawing.Size(75, 23);
            this.btnMostrarListaCat.TabIndex = 20;
            this.btnMostrarListaCat.Text = "Mostrar";
            this.btnMostrarListaCat.UseVisualStyleBackColor = true;
            this.btnMostrarListaCat.Click += new System.EventHandler(this.btnMostrarListaCat_Click);
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Location = new System.Drawing.Point(25, 71);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(35, 13);
            this.lblFiltro.TabIndex = 21;
            this.lblFiltro.Text = "label6";
            this.lblFiltro.Click += new System.EventHandler(this.lblFiltro_Click);
            // 
            // actualizar
            // 
            this.actualizar.Location = new System.Drawing.Point(201, 376);
            this.actualizar.Name = "actualizar";
            this.actualizar.Size = new System.Drawing.Size(75, 23);
            this.actualizar.TabIndex = 22;
            this.actualizar.Text = "Actualizar";
            this.actualizar.UseVisualStyleBackColor = true;
            this.actualizar.Click += new System.EventHandler(this.actualizar_Click);
            // 
            // VentaRespuestos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.actualizar);
            this.Controls.Add(this.lblFiltro);
            this.Controls.Add(this.btnMostrarListaCat);
            this.Controls.Add(this.quitarStock);
            this.Controls.Add(this.btnVolver2);
            this.Controls.Add(this.agregarStock);
            this.Controls.Add(this.quitarRepuesto);
            this.Controls.Add(this.modificarPrecio);
            this.Controls.Add(this.agregarRepuesto);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listRepuestos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbCategoria);
            this.Controls.Add(this.labelBienvenida);
            this.Name = "VentaRespuestos";
            this.Text = "formABMRespuesto";
            this.Load += new System.EventHandler(this.formABMRespuesto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelBienvenida;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listRepuestos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Button agregarRepuesto;
        private System.Windows.Forms.Button modificarPrecio;
        private System.Windows.Forms.Button quitarRepuesto;
        private System.Windows.Forms.Button agregarStock;
        private System.Windows.Forms.Button btnVolver2;
        private System.Windows.Forms.Button quitarStock;
        private System.Windows.Forms.Button btnMostrarListaCat;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.Button actualizar;
    }
}