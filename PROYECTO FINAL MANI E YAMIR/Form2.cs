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
    public partial class Form2 : Form
    { 
        //Declarar el Usuario y Contraseña en el login sin que se pueda modificar
        private const int UsuarioCorrecto = 232310182;
        private const int ContraseñaCorrecta = 232310475;
        //Para que se abra el Forms de la ventana principal del Taller
        Form1 Principal;
        public Form2()
        {
            Principal = new Form1();
            InitializeComponent();
        }
        //Boton para Iniciar Sesion "Ingresar"
        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            //Declarar Variables
            int usuario = int.Parse(txtUsuario.Text);
            int contra = int.Parse(txtContrasenia.Text);
            //Condicion para que salga un mensaje de exito al ingresar datos correctos
            if (ValidarCredenciales(usuario, contra))
            {
                MessageBox.Show("Inicio de sesión exitoso", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Principal.ShowDialog();
            }
            // Se usa por si ingresas los datos mal
            else
            {
                MessageBox.Show("Nombre de usuario o contraseña incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool ValidarCredenciales(int usuario, int contra)
        {
            return usuario == UsuarioCorrecto && contra == ContraseñaCorrecta;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //Limpiar los datos del TextBox
            txtUsuario.Clear();
            txtContrasenia.Clear();
        }
        //Boton para cerra la App
        private void btnCerrarAplicacion_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Quieres cerrar la Aplicacion", "MECANICS MANYAM", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes) this.Close();
        }
    }
}
