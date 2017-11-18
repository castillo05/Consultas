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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            dgvproductos.DataSource=AccesoLogica.Logica_productos.obtenerprod();
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            //AccesoLogica.Logica_productos.buscar(txtbuscar.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rbnombre.Checked==false && rbcodigo.Checked==false)
            {
                MessageBox.Show("Porfavor elija una opcion de busqueda");
                groupBox1.BackColor = Color.Red;
            }
            else
            {
                        if (txtbuscar.TextLength==0)
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

        private void btcargar_Click(object sender, EventArgs e)
        {
            dgvproductos.DataSource = AccesoLogica.Logica_productos.obtenerprod();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgvproductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
