using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaMedico
{
    public partial class Ususario : Form
    {
        public Ususario()
        {
            InitializeComponent();
        }

        private void btnComenzarDiag_Click(object sender, EventArgs e)
        {
            string nombreUsuario = txtNombre.Text;

            // Abre el formulario de diagnóstico y pasa el nombre del usuario
            Form1 formDiagnostico = new Form1(nombreUsuario);
            formDiagnostico.FormClosed += (s, args) => this.Close();  // Cierra este formulario cuando Form1 se cierre
            formDiagnostico.Show();
            this.Hide();  // Oculta este formulario en lugar de cerrarlo
        }





    }//cierre
}//cierre
