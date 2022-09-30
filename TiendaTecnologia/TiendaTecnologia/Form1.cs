using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace TiendaTecnologia
{
    public partial class Form1 : Form
    {
        List<clsProducto> ListaInventario = new List<clsProducto>();
        clsProducto Pdt = new clsProducto();
        int id = 0;
        public Form1()
        {
            InitializeComponent();
            idproductos();
        }
        public void LimpiarObjetos()
        {
            textId.Clear();
            textNombre.Clear();
            textDescripcion.Clear();
            comboCategoria.Text = "";
            textCantidad.Clear();
            textPrecioCompra.Clear();
        }
        void idproductos()
        {
            
            textId.Text = id.ToString();
            id=id+1;
        }
        public void MostarRegistros()
        {
            string Datos = "";
            foreach (clsProducto pt in ListaInventario)
            {
                Datos= Datos+"  "+pt.idProducto+"  "+pt.nomProducto+" "+ pt.descripcion+"  "+ pt.categoria+"  "+ pt.stock+ "  "+pt.precioCompra+"  "+pt.precioVenta + "\n";

            }
            rtbInventario.Text = Datos;

        }
        public void FiltrarCategoria()
        {
            string datos = " ";
            var consulta = from cat in ListaInventario
                           where cat.categoria.Equals(textFiltroCategoria.Text)
                           select cat;
            foreach (clsProducto c in consulta )
            {
                datos = datos + "  " + c.idProducto + "  " + c.nomProducto + " " + c.descripcion + "  " + c.categoria + "  " + c.stock + "  " + c.precioCompra + "  " + c.precioVenta + "\n";

            }
            rtbFiltro.Text = datos;


        }


        private void btnRegistrar_Click(object sender, EventArgs e)
        {

            
            

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {


        }
        public void RegistrarProducto()
        {
            clsProducto Pdt= new clsProducto();
            double pVenta;
            Pdt.idProducto = int.Parse(textId.Text);
            Pdt.nomProducto = textNombre.Text;
            Pdt.stock = int.Parse(textCantidad.Text);
            Pdt.precioCompra = double.Parse(textPrecioCompra.Text);
            pVenta = double.Parse(textPrecioCompra.Text) + (double.Parse(textPrecioCompra.Text) * 0.10);
            Pdt.precioVenta = pVenta;
            Pdt.descripcion = textDescripcion.Text;
            Pdt.categoria = comboCategoria.Text;
            ListaInventario.Add(Pdt);
            LimpiarObjetos();
            idproductos();
            MostarRegistros();
           


        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            FiltrarCategoria();
        }

        private void btnRegistrar_Click_1(object sender, EventArgs e)
        {
            RegistrarProducto();
        }
    }
}
