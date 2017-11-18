using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccesoLogica;

namespace Consultar_Precios
{
    public partial class Productos : Form
    {
        public Productos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rbnombre.Checked == false && rbcodigo.Checked == false)
            {
                MessageBox.Show("Porfavor elija una opcion de busqueda");
                groupBox1.BackColor = Color.Red;
            }
            else
            {
                if (txtbuscar.TextLength == 0)
                {
                    MessageBox.Show("Agregar un nombre p codigo para buscar");
                    txtbuscar.BackColor = Color.Red;
                    return;
                }
                else
                {
                    if (rbnombre.Checked)
                    {
                        AccesoLogica.Logica_productos.buscar(txtbuscar.Text);
                        dgvproductos.DataSource = Logica_productos.buscar(txtbuscar.Text);
                        txtbuscar.BackColor = Color.White;
                    }
                    else
                    {
                        AccesoLogica.Logica_productos.buscar1(txtbuscar.Text);
                        dgvproductos.DataSource = Logica_productos.buscar1(txtbuscar.Text);
                        txtbuscar.BackColor = Color.White;
                    }
                }
                groupBox1.BackColor = Color.WhiteSmoke;
            }
            
            
        }

        private void Productos_Load(object sender, EventArgs e)
        {
            dgvproductos.DataSource = AccesoLogica.Logica_productos.obtenerprod();
        }

        private void dgvproductos_Click(object sender, EventArgs e)
        {
            try
            {
                int seleccion;
                int fila = dgvproductos.CurrentRow.Index;
                txtcantidad.Text = dgvproductos.Rows[fila].Cells[1].Value.ToString();
                txtunidad.Text = dgvproductos.Rows[fila].Cells[2].Value.ToString();
                txtcodigo.Text = dgvproductos.Rows[fila].Cells[3].Value.ToString();
                txtdesc.Text = dgvproductos.Rows[fila].Cells[4].Value.ToString();
                txtprecio.Text = dgvproductos.Rows[fila].Cells[5].Value.ToString();
                txtcod.Text = dgvproductos.Rows[fila].Cells[0].Value.ToString();
                seleccion = dgvproductos.CurrentRow.Index;
            }
            catch (Exception es)
            {

                MessageBox.Show(es.Message);
            }
            
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
           
            try
            {
                if (AccesoLogica.Logica_productos.actualizarproducto(Double.Parse(txtcantidad.Text),txtunidad.Text,txtcodigo.Text,txtdesc.Text,double.Parse(txtprecio.Text),txtcod.Text))
                {
                    MessageBox.Show("Registro Actualizado");
                    dgvproductos.DataSource = AccesoLogica.Logica_productos.obtenerprod();
                    btnsave.Enabled = false;
                    bteditar.Enabled = true;
                }
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private void bteditar_Click(object sender, EventArgs e)
        {
            btnsave.Enabled = true;
            bteditar.Enabled = false;
        }

        private void btcargar_Click(object sender, EventArgs e)
        {
            dgvproductos.DataSource = AccesoLogica.Logica_productos.obtenerprod();
        }
    }
}
