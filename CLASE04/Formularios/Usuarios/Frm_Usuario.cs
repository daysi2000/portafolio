using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CLASE04.Formularios.Usuarios
{
    public partial class Frm_Usuario : CLASE04.Formularios.FrmBASE.FrmBase
    {
        public string _Titulo
        {
            get { return lbl_titulo.Text; } set { lbl_titulo.Text = value; }
        }

        public Frm_Usuario()
        {
            InitializeComponent();
        }

        private void Frm_Usuario_Load(object sender, EventArgs e)
        {
            cmb_estadosUsuarios._Cargar();
            cmb_perfiles._Cargar();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {

        }
    }
}
