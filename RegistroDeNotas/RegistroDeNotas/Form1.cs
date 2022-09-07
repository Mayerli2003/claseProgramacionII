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

namespace RegistroDeNotas
{
    public partial class Form1 : Form
    {
        ArrayList RegistroNotas = new ArrayList();
        int indice, numcod=0;
        string codigo;
        double promedio;
        void LimpiarObjetos()
        {
            textNombre.Clear();
            textApellido.Clear();
            textAsignatura.Clear();
            textLaboratorio.Clear();
            textParcial.Clear();    
        }
       
        void RegistrarNotas()
        {
            codigo = "ST-00" + numcod;
            numcod++;
            RegistroNotas.Add(codigo);
            RegistroNotas.Add(textNombre.Text);
            RegistroNotas.Add(textApellido.Text);
            RegistroNotas.Add(textAsignatura.Text);
            RegistroNotas.Add(textLaboratorio.Text);
            RegistroNotas.Add(textParcial.Text);
            promedio=((Convert.ToDouble(textLaboratorio.Text)+Convert.ToDouble(textParcial.Text))/2);
            RegistroNotas.Add(promedio);

        }
        void MostrarRegistros()
        {
            string Regdatos = "";
            for (int i = 0; i < RegistroNotas.Count; i += 7) 
            {
                Regdatos = Regdatos +RegistroNotas[i] +" "+ RegistroNotas[i+1]+" " + RegistroNotas[i+2]+" " + RegistroNotas[i+3]+" " + RegistroNotas[i+4]+" " + RegistroNotas[i+5]+" " + RegistroNotas[i+6] + " \n";
            }
            rtbRegistros.Text= Regdatos;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            RegistrarNotas();
            MostrarRegistros();
            LimpiarObjetos();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
