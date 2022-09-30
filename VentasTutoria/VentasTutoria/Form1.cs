using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VentasTutoria
{
    public partial class Form1 : Form
    {
        List<Facturas> Factura ;
        List<Facturas> FacturasFiltradas;
        public Form1()
        {
            InitializeComponent();
            consultaFactura();
        }
        private void consultaFactura()
        {
            Factura = new List<Facturas>()
            {
                new Facturas{factura=1, cliente="David",producto="chocolate", Empleado="Juan Perez", Total=1000.5},
                new Facturas{factura=1, cliente="Maria",producto="sopa", Empleado="Juan Perez", Total=1000.5}
            };
            dataFactura.DataSource = Factura;
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void butMayoresA1000_Click(object sender, EventArgs e)
        {
            //utilizando la interzas ienumerable como metodo
            FacturasFiltradas= Factura.Where(x => x.Total> 1000).ToList();
            dataFactura.DataSource = FacturasFiltradas;
            //utilizando la interfas ienumerable como consulta
            FacturasFiltradas = (from datos in Factura where datos.Total > 1000 select datos).ToList();
            dataFactura.DataSource = FacturasFiltradas;
        }

        private void butEmpleado_Click(object sender, EventArgs e)
        {
            FacturasFiltradas = Factura.Where(x => x.Empleado =="Juan Peres").ToList();
            dataFactura.DataSource = FacturasFiltradas;

        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            consultaFactura();
        }
    }
}
