using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CLASE04.Clases;

namespace CLASE04.Formularios.Usuarios
{
    public partial class Frm_Usuario_Alta : CLASE04.Formularios.Usuarios.Frm_Usuario
    {
        public Frm_Usuario_Alta()
        {
            InitializeComponent();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            //1) validar los datos del formulario
            // la validacion de todo ok => grabo en la base de datos
            // la validacion de error => ir a corregir el error
            TratamientosEspeciales _TE = new TratamientosEspeciales();

            if (_TE.Validar(this.Controls) == TratamientosEspeciales.RespuestaValidacion.Correcta)
                MessageBox.Show("Validación correcta");

        }
    }
}
