using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CLASE04.Negocios;

namespace CLASE04.Formularios.Usuarios
{
    public partial class Frm_ABM_Usuario : CLASE04.Formularios.FrmBASE.FrmBase_AMB_Entrada
    {

        public Frm_ABM_Usuario()
        {
            InitializeComponent();
        }

        private void Frm_ABM_Usuario_Load(object sender, EventArgs e)
        {
            this.grid_usuarios.Formatear("id, 75, C; n_usuario, 100, I; Apellido, 170, I; Nombres, 170, I");
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            NE_Usuarios usuario = new NE_Usuarios();

            string columna = "";

            if (txt_patron.Text != string.Empty)
            {
                if (rb_n_usuario.Checked == true)
                    columna = rb_n_usuario.Text;
                if (rb_apellido.Checked == true)
                    columna = rb_apellido.Text;
                if (rb_nombre.Checked == true)
                    columna = rb_nombre.Text;

                grid_usuarios.Cargar(usuario.BuscarUsuario(txt_patron.Text, columna));
                if (grid_usuarios.Rows.Count == 0)
                    MessageBox.Show("No se encontró ningún usuario", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txt_id_usuario.Text != string.Empty)
            {
                grid_usuarios.Cargar(usuario.BuscarUsuario(txt_id_usuario.Text));
                if (grid_usuarios.Rows.Count == 0)
                    MessageBox.Show("No se encontró ningún usuario", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            MessageBox.Show("No hay parámetros de búsqueda", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }
        private void btn_blan_patron_Click(object sender, EventArgs e)
        {
            this.txt_patron.Text = string.Empty;
        }

        private void btn_alta_Click(object sender, EventArgs e)
        {
            Frm_Usuario_Alta frm_altas = new Frm_Usuario_Alta();
            frm_altas.ShowDialog();
        }
    }
}
