using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CLASE04.Formularios.FrmBASE
{
     public partial class FrmBase : Form
    {
        bool dragging;
        int posicionX, posicionY;

        public bool _FormularioMovil { get; set; }

        public bool Pp_minimizarVisible
        {
            set { btn_minimizar.Visible = value; }
        }
        public bool Pp_maximizarVisible
        {
            set { btn_maximizar.Visible = value; }
        }
        public FrmBase()
        {
            InitializeComponent();
        }

        private void btn_minimizar_MouseMove(object sender, MouseEventArgs e)
        {
            this.btn_minimizar.BackgroundImage = CLASE04.Properties.Resources.minimizar_g;
        }

        private void btn_minimizar_MouseLeave(object sender, EventArgs e)
        {
            this.btn_minimizar.BackgroundImage = CLASE04.Properties.Resources.minimizar;
        }
        private void btn_maximizar_MouseMove(object sender, MouseEventArgs e)
        {
            this.btn_maximizar.BackgroundImage = CLASE04.Properties.Resources.maximizar_g;
        }
        private void btn_maximizar_MouseLeave(object sender, EventArgs e)
        {
            this.btn_maximizar.BackgroundImage = CLASE04.Properties.Resources.maximizar;
        }
        private void btn_cerrar_MouseMove(object sender, MouseEventArgs e)
        {
            this.btn_cerrar.BackgroundImage = CLASE04.Properties.Resources.cerrar_r;
        }
        private void btn_cerrar_MouseLeave(object sender, EventArgs e)
        {
            this.btn_cerrar.BackgroundImage = CLASE04.Properties.Resources.cerrar;
        }
        private void FrmBase_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            posicionX = e.X;
            posicionY = e.Y;
        }
        private void FrmBase_MouseMove(object sender, MouseEventArgs e)
        {
            if (_FormularioMovil == false)
                return;
            if (dragging == true)
            {
                this.Location = new Point(this.Location.X + e.X - posicionX, this.Location.Y + e.Y - posicionY);
                this.Refresh();
            }
        }
        private void FrmBase_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.cerrar();
        }
        public void cerrar()
        {
            this.Close();
        }
    }
}
