using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace desafio3
{
    public partial class Form1 : Form
    {
        List<Producto> lp = new List<Producto>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        public void CargarGrilla()
        {
            GrillaProductos.DataSource = null;
            GrillaProductos.DataSource = lp;
        }
        public void agregarProducto (Producto p)
        {
            lp.Add(p);
            CargarGrilla();
        }

        private void btnAgregarProd_Click(object sender, EventArgs e)
        {

        }
    }
}
