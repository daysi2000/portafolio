using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CLASE04.Clases 
{
    public partial class LabelText01 : UserControl
    {
     
        public string _Etiqueta
        {
            get { return lblEtiqueta.Text; }
            set { lblEtiqueta.Text = value; }
        }
        public bool _Validable { get; set; }
        public string _Nombre_campo { get; set; }
        public string _Nombre_tabla { get; set; }
        public string _MensajeError { get; set; }
        public string _Mask 
       {
            get { return TxtDato.Mask; }
            set { TxtDato.Mask = value; }
        } 
        public string _Text
        {
            get { return TxtDato.Text; }
            set { TxtDato.Text = value; }
        }

        public bool _ReadOnly
        {
            get => TxtDato.ReadOnly;
            set => TxtDato.ReadOnly = value;
        }
     
        public LabelText01()
        {
            InitializeComponent();
        }
    }
}
