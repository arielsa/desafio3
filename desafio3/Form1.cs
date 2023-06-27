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
        List<Producto> productos;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            productos = new List<Producto>();
        }

        private void btnAgregarProd_Click(object sender, EventArgs e)
        {

        }
    }
}
