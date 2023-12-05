using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Proyecto_Taller_Mecanico
{
    public partial class Form1 : Form
    {
        //Nombre de la clase creada
        ProduCtos Mecanics = new ProduCtos();

        // Variables utilizada en el metodo de "Cambio()"
        double pagocliente;
        //Para asignar hora en el ticket
        string Hora;
        public Form1()
        {

            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //Codigo para asignar hora en el codigo
            Hora = DateTime.Now.ToString("t");
            //Este codigo es para ocultar boton de "Generar ticket's".
            btnTicket.Enabled = false;
           //Ocultar GroupBox de Datos de cliente, placas etc.
            gbDatos.Visible = false;
            //ocultar GroupBox del Total de la compra y Precios de los servicios
            gbTotal.Visible = false;
          Gb_Precios.Visible = false;
        }
        private void cbServiciosOfrecidos_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        // Button para mostrar herramientas en el FORMS llamado: "Menu"
        private void btnPalancaDeInicio_Click(object sender, EventArgs e)
        {
            //Mostrar herramientas dentro de GroupBox utlizadas una vez selecionado menu
            gbDatos.Visible = true;
            gbTotal.Visible = true;
            Gb_Precios.Visible = true;

            //Aqui mostramos todas las herramientas utilizadas como label,TextBox,Buttons ListView.
            txtNombreDelcCliente.Show();
            txtNombreEmpleado.Show();
            cbMarcasAutos.Show();
            gbDatos.Show();
            txtPlacas.Show();
            lbModelo.Show();
            lbplacas.Show();
            s1.Show(); s2.Show(); s3.Show(); s4.Show(); s5.Show(); s6.Show(); s7.Show(); s8.Show(); s9.Show(); s10.Show(); 
            p1.Show(); p2.Show(); p3.Show(); p4.Show(); p5.Show(); p6.Show(); p7.Show(); p8.Show(); p9.Show(); p10.Show();
            lbNameClient.Show();
            lbTotal.Show();
            lbTotalProd.Show();
            gbTotal.Show();
            lbNameWorker.Show();
            lbServicioD.Show();
            cbServiciosOfrecidos.Show();
            btnRegistroDeVenta.Show();
            lvRegistroVenta.Show();
            lbDesplegarMenu.Hide();
            btnPalancaDeInicio.Hide();
            btnTicket.Show();
            SoundPlayer Menu = new SoundPlayer();
            Menu.SoundLocation = "E:/LG Smart TV/Proyecto-TM-Yamir-Mani/PROYECTO FINAL MANI E YAMIR/TheShopTheme.wav";
            Menu.Play();


        }
        //Boton de seleccionar Producto
        private void btnRegistroDeVenta_Click(object sender, EventArgs e)
        {
            //Codigo con el nombre de la  clase para que lea los Datos dentro del boton
            Mecanics.cliente = txtNombreDelcCliente.Text;
            Mecanics.empleado = txtNombreEmpleado.Text;

            Mecanics.placas = txtPlacas.Text;
            //Precios de los servicios creados en la  clase
            //Mostrarlos en un Combobox
            Mecanics.Servicio = cbServiciosOfrecidos.Text;
            //metodo de los precios registrados en la clase  
            Mecanics.casos();
            //Codigo para Mostrar Acumulador en un label segun el servicio que adquiera
            lbTotalProd.Text = Mecanics.sumapagos.ToString("c");
            //Metodo creado para mostrar Datos de Cliente,Servicio,y precio
            ListaRegistro();
            //Para que abra Boton de realizar el pago una vez seleccionado los productos
            btnRealizarPago.Show();
        }
        //Metodo para Registar Datos en listview
        private void ListaRegistro()
        {
            ListViewItem fila = new ListViewItem(Mecanics.empleado);
            fila.SubItems.Add(Mecanics.cliente);
            fila.SubItems.Add(cbServiciosOfrecidos.Text);
            fila.SubItems.Add(Mecanics.PrecioDelServicio.ToString("c"));

            lvRegistroVenta.Items.Add(fila);
        }

        private void btnRealizarPago_Click(object sender, EventArgs e)
        {
            //Metodo de la placa registrada exitosa!!
            placa();
            //Codigo para Habilitar el generador de ticket
            btnTicket.Enabled = true;
        }
        //Boton para Generar Ticket
        private void button1_Click(object sender, EventArgs e)
        {
            //Metodo para Generar Tickets
            Cambio();


        }
        //Metodo de cambio para generar el ticket en un messageBox 
        //Agregando un switch de las marcas de auto segun se le haya hecho el servicio
        private void Cambio()
        {
            //Codigo parar mostrar la fecha actual dentro del Tickket
            DateTime fecha = DateTime.Now;
            //Switch Marcas de Automoviles
            string MARCASAUTO = cbMarcasAutos.Text;
            switch (MARCASAUTO)
            {
                case "ALFA ROMEO":
                    break;
                case "ACURA":
                    break;
                case "AUDI":
                    break;
                case "BENTLEY":
                    break;
                case "BMW":
                    break;
                case "CADILLAK":
                    break;
                case "CHEVROLET":
                    break;
                case "DODGE":
                    break;
                case "JEEP":
                    break;
                case "HONDA":
                    break;
                case "HYUNDAI":
                    break;
                case " FERRARI":
                    break;
                case "FORD":
                    break;
                case "FIAT":
                    break;
                case "SUSUKI":
                    break;
                case "GMC":
                    break;
                case "NISSAN":
                    break;
                case "MAZDA":
                    break;
                case "MERCEDES":
                    break;
                case "RENAULT":
                    break;
                case "KIA":
                    break;
            }
            //Codigo para ingresar la cantidad con la que pagara el cliente
            pagocliente = double.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingresa el pago del cliente"));
            double cambio;

            cambio = pagocliente - Mecanics.sumapagos;
            //Condicion por si el pago es exacto al servicio seleccionado
            if (cambio == 0)
            {
                MessageBox.Show("Pago Exacto");
                MessageBox.Show("Fecha: " + fecha.ToString("d") + "\n Hora: " + Hora + "\n Lo atendio: " + Mecanics.empleado +
        "\n Cliente: " + Mecanics.cliente
        + "\n Total de la compra: " + Mecanics.sumapagos.ToString("c") +
        "\n Marca de auto: " + MARCASAUTO
        + "\n Cantidad de pago: " + pagocliente.ToString("c") + "\n Cambio: " + cambio.ToString("c"), "MECANICS MANYAM");
            }
            // Condicion por si le falta dinero
            else if (cambio < 0)
            {
                //Operacion para que muestre lo que falta si el pago no es igual al total de servicios
                cambio = Mecanics.sumapagos - pagocliente;

                //En cada MessageBox mostrara la fecha,hora,Atendio,cliente,Auto,total,pago del cliente y pago
                //Segun la condicion que se cumpla

                MessageBox.Show("Fecha: " + fecha.ToString("d") + "\n Hora: " + Hora + "\n Lo atendio: " + Mecanics.empleado +
            "\n Cliente: " + Mecanics.cliente
            + "\n Total de la compra: " + Mecanics.sumapagos.ToString("c") + "\n Marca de auto: " + MARCASAUTO +
            "\n Cantidad de pago: " + pagocliente.ToString("c") + "\n Faltante: " + cambio.ToString("c"), "MECANICS MANYAM");
            }
            //Condicion por si el pago es mayor al servicio seleccionado y darle su cambio
            else if (cambio > 0)
            {
                MessageBox.Show("Fecha: " + fecha.ToString("d") + "\n Hora: " + Hora + "\n Lo atendio: " + Mecanics.empleado +
          "\n Cliente: " + Mecanics.cliente
          + "\n Total de la compra: " + Mecanics.sumapagos.ToString("c") + "\n Marca de auto: " + MARCASAUTO +
          "\n Cantidad de pago: " + pagocliente.ToString("c") + "\n Cambio: " + cambio.ToString("c"), "MECANICS MANYAM");

            }
        }
        //Metodo para Registrar 8 digitos en la placa
        // con condicion de que si no los ingresas no te dejara realizar el pago
        private void placa()
        {
            string placa;
            placa = txtPlacas.Text;
            if (placa.Length != 8)
            {
                MessageBox.Show("Placas incorrectas,ingresa de nuevo");
            }
            else
            {
                MessageBox.Show("Placa registrada");
            }
        }
        //Boton para cerra la ventana principal y me mande directo al login
        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Quieres salir de la ventana? ", "MECANICS MANYAM", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes) this.Close();
        }
        private void gbDatos_Enter(object sender, EventArgs e)
        {
        }
    }
    }
    

        

    


