﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using CLASE04.Formularios.InicioSistema;
using CLASE04.Formularios.FrmBASE;
using CLASE04.Formularios.Usuarios;

namespace CLASE04
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
           //Application.Run(new Frm_Escritorio());
            //Application.Run(new Frm_Login());
            //Application.Run(new FrmLogin());
            Application.Run(new Frm_ABM_Usuario());
            //Application.Run(new Frm_Usuario_Alta());

        }
    }
}
