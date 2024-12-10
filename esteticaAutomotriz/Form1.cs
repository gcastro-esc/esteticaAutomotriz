using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace esteticaAutomotriz
{
    public partial class frmPrincipal : Form
    {
        //DECLARACION DE LA VARIABLE GLOBAL SUBTOTAL
        double subtotal = 0;
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            comboMarcas.SelectedIndex = 0;
            comboServicios.SelectedIndex = 0;
        }

        private void txtKilometraje_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Validar que este textBox solo admita números
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //Boton AGREGAR A LA ORDEN
            int servicio = comboServicios.SelectedIndex;
            string descripcion = comboServicios.SelectedItem.ToString();
            listaServicios.Items.Add(descripcion);
            switch (servicio)
            {
                case 0: subtotal = subtotal + 120;
                    break;
                case 1: subtotal = subtotal + 280;
                    break;
                case 2: subtotal = subtotal + 210;
                    break;
                case 3: subtotal = subtotal + 650;
                    break;
                case 4: subtotal = subtotal + 80;
                    break;
                case 5: subtotal = subtotal + 550;
                    break;
                case 6: subtotal = subtotal + 1200;
                    break;
            }
            //Despues del SWITCH
            lblCuenta.Text = "Sub Total $ " + subtotal;
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //Boton RETIRAR DE LA ORDEN
            int servicioABorrar = listaServicios.SelectedIndex;
            string descripcionABorrar = listaServicios.SelectedItem.ToString();
            if (descripcionABorrar == "Lavado de Interiores  - $120")
            {
                subtotal = subtotal - 120;
            }
            if (descripcionABorrar == "Lavado de Motor - $280")
            {
                subtotal = subtotal - 280;
            }
            if (descripcionABorrar == "Púlido y Encerado - $210") 
            {
                subtotal = subtotal - 210;
            }
            if (descripcionABorrar == "Púlido de Faros - $650") 
            {
                subtotal = subtotal - 650;
            }
            if (descripcionABorrar == "Lavado de Carrocería - $80")
            {
                subtotal = subtotal - 80;
            }
            if (descripcionABorrar == "Abrillantado de Pintura - $550")
            {
                subtotal = subtotal - 550;
            }
            if (descripcionABorrar == "Lavado de Vestiduras - $1,200")
            {
                subtotal = subtotal - 1200;
            }
            //Despues de los IF
            lblCuenta.Text = "Sub Total $ " + subtotal;
            listaServicios.Items.RemoveAt(servicioABorrar);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            //Boton NUEVA ORDEN
            //Datos del propietario
            txtPropietario.Clear();
            txtRFC.Clear();
            txtTelefono.Clear();
            txtDireccion.Clear();
            //Datos del vehiculo
            comboMarcas.SelectedIndex = 0;
            txtTipoAuto.Clear();
            numModelo.Value = 1950;
            txtPlacas.Clear();
            txtKilometraje.Clear();
            //Datos del servicio
            comboServicios.SelectedIndex = 0;
            listaServicios.Items.Clear();
            lblCuenta.Text = "Subtotal $0";
            txtPropietario.Focus();
        }
        
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            //boton CONFIRMAR ORDEN
            //Crear instancia para acceder al form2
            frmOrden orden = new frmOrden();
            //Envia el valr del subtotal al objeto ST en el form2
            orden.st = subtotal;
            //Cuenta cuantos elementos hay en una lista y los guarda
            int numeroElementos = listaServicios.Items.Count;
            if (numeroElementos == 0)
            {
                MessageBox.Show("Sin servicios contratados", "Orden Vacía");
            }
            else
            {
                string cliente, rfc, telefono, domicilio, marca, tipo, placas;
                int modelo, kms, numeroIndice;
                cliente = txtPropietario.Text;
                rfc = txtRFC.Text;
                telefono = txtTelefono.Text;
                domicilio = txtDireccion.Text;
                marca = comboMarcas.SelectedItem.ToString();
                tipo = txtTipoAuto.Text;
                modelo = Convert.ToInt32(numModelo.Value);
                kms = Convert.ToInt32(txtKilometraje.Text);
                placas = txtPlacas.Text;

                //Enviar informacion a form2
                orden.lblCliente.Text = "Cliente: " + cliente;
                orden.lblDomicilio.Text = "Direccion: " + domicilio;
                orden.lblRFC.Text = "RFC " + rfc;
                orden.lblTelefono.Text = "Tel " + telefono;
                orden.lblMarca.Text = marca;
                orden.lblTipo.Text = tipo;
                orden.lblPlacas.Text = placas;
                orden.lblModelo.Text = "Año: " + modelo;
                orden.lblKilometraje.Text = "KMS: " + kms;

                //Enviar elementos del listBox hacia form2
                numeroIndice = 0;
                while (numeroIndice < numeroElementos)
                {
                    orden.listaContratados.Items.Add(listaServicios.Items[numeroIndice]);
                    numeroIndice = numeroIndice + 1;
                }

                //Al final siempre
                orden.Show();
            }
        }


    }
}
