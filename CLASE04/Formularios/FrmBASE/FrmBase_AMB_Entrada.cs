﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
//using System.Drawing;

namespace CLASE04.Formularios.FrmBASE
{
    public partial class FrmBase_AMB_Entrada : CLASE04.Formularios.FrmBASE.FrmBase
    {
        public string _titulo
        {
            get { return this.label1.Text; }
            set { label1.Text = value; }
        }

        public FrmBase_AMB_Entrada()
        {
            InitializeComponent();
        }
    }
}
