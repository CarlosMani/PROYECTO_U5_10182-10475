using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Taller_Mecanico
{
    public partial class TotalDeVenta : Form
    {
        ProduCtos Mecanics = new ProduCtos();
      //  TotalDeVenta Venta;
        public TotalDeVenta()
        {
            InitializeComponent();
            //Venta = new TotalDeVenta();


        }

        private void TotalDeVenta_Load(object sender, EventArgs e)
        {
            Mecanics.casos();

            lbTotalDeCompra.Text = Mecanics.sumapagos.ToString("C");

       }
    }
}
