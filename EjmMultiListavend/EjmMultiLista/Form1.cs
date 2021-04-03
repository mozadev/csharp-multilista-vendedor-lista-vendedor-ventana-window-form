using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjmMultiLista
{
    public partial class Form1 : Form
    {
        // variable a nivel de toda clase que es mi lista de vendedor
        // la cual al momento de inicializar o crear el formulario, vamo a instanciarlo
        //como una nueva lista de vendedor
        // va a poner todo en null y van poner todo los valores en cero que son cosas q hac por defect
        private ListVendedor listVendedor;
        public Form1()
        {
            InitializeComponent();
            listVendedor = new ListVendedor();
        }

        private void button1_Click(object sender, EventArgs e)
        {// creo mi variable = creo una nueva instancia vendedro.
            var vendedor = new Vendedor()
            {
                Codigo = txtCodigoAgregar.Text,
                Nombre = txtNombreAgregar.Text
            };

            listVendedor.Add(vendedor);
            MostrarVendedores();
        }

        private void MostrarVendedores() {
            var vendedor = listVendedor.Inicio;
            txtElementos.Text = "Elementos: " + 
                                listVendedor.NumElementos + 
                                Environment.NewLine;

            while (vendedor != null)
            {
                txtElementos.Text +=    vendedor.Codigo + 
                                        ": " + 
                                        vendedor.Nombre + 
                                        Environment.NewLine;

                vendedor = vendedor.Siguiente;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var vendedor = listVendedor.Find(txtCodigoEliminar.Text);
            if (vendedor != null)
            {
                listVendedor.Remove(vendedor);
                MostrarVendedores();
            }
        }
    }
}
