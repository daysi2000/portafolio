using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CLASE04.Clases;

namespace CLASE04
{
    public partial class F1 : CLASE04.Formularios.FrmBASE.FrmBase
    {
        public F1()
        {
            InitializeComponent();
        }

        private void F1_Load(object sender, EventArgs e)
        {
            Cmb_EstadoUsuario._Cargar();
            cargarComboC1();
        }
        private void cargarComboC1()
        {
            BE_Acceso_Datos _BD = new BE_Acceso_Datos();
            string sql = "SELECT id_estado_usuario, n_estado_usuario FROM EstadosUsuarios";
            C1.DisplayMember = "n_estado_usuario";
            C1.ValueMember = "id_estado_usuario";
            C1.DataSource = _BD.EjecutarSelect(sql);
        }
    }

}
