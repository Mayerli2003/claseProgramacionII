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

namespace Listas
{
    public partial class Form1 : Form
    {

        List<string> Productos = new List<string>();
        int iModificar;
        int id;

        public Form1()
        {
            InitializeComponent();
        }

        //Limpiar campos
        void LimpiarCampos()
        {
            txtNombre.Clear();
            txtCategoria.Clear();
            txtPrecio.Clear();
        }

        //Registrar a la lista
        public void Registrar()
        {
            try
            {
                if(txtNombre.Text != "" && txtCategoria.Text != "" && txtPrecio.Text != "")
                {
                    Productos.Add(txtNombre.Text);
                    Productos.Add(txtCategoria.Text);
                    Productos.Add(txtPrecio.Text);
                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar producto" + ex);
            }
        }


        //Metedo para mostrar los registros en la lista
        public void MostrarRegistro()
        {
            try
            {
                string Lista = "";
                for (int i = 0; i < Productos.Count; i +=3 )
                {
                    Lista = Lista + i + "---- " + Productos[i] + " " + Productos[i+1] + "  $" + Productos[i+2] + "\n";
                }
                rtbListaProductos.Text = Lista;
            }
            catch (Exception ex)
            {
                MessageBox.Show("EL libro con nombre: " + txtNombre + " no se ha encontrado", ex.Message);
            }
        }


        //Metodo para buscar un registro atraves del nombre
        void BuscarRegistro()
        {
            try
            {

                if (Productos.Contains(txtNombre.Text))
                {
                    for (int i = 0; i < Productos.Count; i += 3)
                    {
                       
                        if (Productos[i].ToString() == txtNombre.Text)
                        {

                            txtNombre.Text = Productos[i].ToString();
                            txtCategoria.Text = Productos[i + 1].ToString();
                            txtPrecio.Text = Productos[i + 2].ToString();                         
                            iModificar = i;

                        }
                        else
                        {
                            //MessageBox.Show("El campo de busqueda esta vacio");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("El campo de busqueda esta vacio");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("EL libro con nombre: " + txtNombre + " no se ha encontrado", e.Message);
            }
        }

        //Metodo para vaciar la lista
        void VaciarLista()
        {
            Productos.Clear();
        }


        //Metodo para Eliminar
        void Eliminar()
        {
            try
            {
                if (txtNombre.Text != "")
                {
                    for (int i = 0; i < Productos.Count() - 1; i++)
                    {
                        if (txtNombre.Text == Productos[i])
                        {
                            Productos.RemoveAt(i);
                            Productos.RemoveAt(i);
                            Productos.RemoveAt(i);
                            LimpiarCampos();
                            MostrarRegistro();
                            break;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Campo nombre esta vacio!!");

                }



            }
            catch (Exception)
            {
                MessageBox.Show("Error al elminar registro");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            
            Eliminar();
            MostrarRegistro();
            LimpiarCampos();
            
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Registrar();
            MostrarRegistro();
            LimpiarCampos();
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            EditarRegistro();
            MostrarRegistro();
            LimpiarCampos();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Buscar();
        }
        private void btnVaciar_Click(object sender, EventArgs e)
        {
            VaciarLista();
            MostrarRegistro();
           
        }
        public void EditarRegistro()
        {
            try
            {
                Productos.Insert(id, txtNombre.Text);
                Productos.Insert(id+1,txtCategoria.Text);
                Productos.Insert(id+2,txtPrecio.Text);
                btnBuscar.Enabled = true;
                btnGuardar.Enabled = false;
                LimpiarCampos();
                MostrarRegistro();

            }
            catch(Exception)
            {
                MessageBox.Show("Error al guardar los cambios!!");
                

            }
        }


        ////Metodo para modificar los datos
        //public void GuardarCambio()
        //{
        //    try
        //    {
        //        if (txtNombre.Text != "" && txtCategoria.Text != "" && txtPrecio.Text != "")
        //        {
        //            Productos[iModificar] = txtNombre.Text;
        //            Productos[iModificar + 1] = txtCategoria.Text;
        //            Productos[iModificar + 2] = txtPrecio.Text;
                   
        //            MessageBox.Show("Se ha guardado correctamente!!!!");
        //        }
        //        else
        //        {
        //            MessageBox.Show("Todos los los campos son obligatorios");
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        MessageBox.Show("Error al guardar los cambios generados en la modificacion " + e.Message);
        //    }
        //}
        public void Buscar()
        {
            try
            {
                if (txtNombre.Text!=null)
                {
                    for(int i=0; i<Productos.Count; i++)
                    {
                        if (txtNombre.Text == Productos[i])
                        {
                            txtCategoria.Text = Productos[i+1];
                            txtPrecio.Text = Productos[i+2].ToString();
                            
                            DialogResult respuesta = MessageBox.Show("Editaras el registro","Editar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if(respuesta==DialogResult.Yes)
                            {
                                id = i;
                                btnGuardar.Enabled = true;
                                btnBuscar.Enabled = false;
                            }
                            break;

                        }

                    }
                }
                else
                {
                    MessageBox.Show("El campo nombre esta vacio!!");
                }

            }
            catch(Exception)
            {
                MessageBox.Show("Error en la busqueda");

            }
        }



       
    }
}
