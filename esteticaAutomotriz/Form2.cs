using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace esteticaAutomotriz
{   
    public partial class frmOrden : Form
    {
        //Este es el FORM 2
        public double st { get; set; }

        public frmOrden()
        {
            InitializeComponent();
        }

        private void frmOrden_Load(object sender, EventArgs e)
        {
            double iva, total;
            iva = st * 0.16;    //16% del subTotal
            total = iva + st;
            lblSubtotal.Text = "Sub Total - $ " + st;
            lblIVA.Text = "IVA - $ " + iva;
            lblPagoTotal.Text = "Total - $ " + total;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog guardar = new SaveFileDialog())
            {
                guardar.Filter = "Archivo de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
                guardar.Title = "Guardar archivo como";
                guardar.FileName = "ordenGenerada.txt";
                if (guardar.ShowDialog() == DialogResult.OK)
                {
                    string contenido = "Orden del cliente: " + lblCliente.Text + "\n";
                    contenido = contenido + "Dirección: " + lblDomicilio.Text + "\n";
                    contenido = contenido + "Vehiculo: " + lblMarca.Text + ", tipo: " + lblTipo.Text + "\n";
                    contenido = contenido + "Modelo: " + lblModelo.Text + "\n";
                    contenido = contenido + "\nServicios contratados \n";
                    for (int i = 0; i < listaContratados.Items.Count; i = i + 1)
                    {
                        contenido = contenido + listaContratados.Items[i] + "\n";
                    }
                    try
                    {
                        File.WriteAllText(guardar.FileName, contenido);
                        MessageBox.Show("Archivo guardado exitosamente", "Exito");
                    }
                    catch
                    {
                        MessageBox.Show("Error al guardar el archivo");
                    }
                }
            }
        }


    }
}
