using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CLASE04.Clases
{
    class TextBox02 : MaskedTextBox
    {
        public enum TipoDato { texto, numero, fecha }

        public bool _Validable { get; set; }
        public string _Nombre_campo { get; set; }
        public string _Nombre_tabla { get; set; }
        public string _MensajeError { get; set; }
        //-----------------------------
        public int _Ancho { get; set; } = 10;
        public int _Decimales { get; set; } = 2;

        public TipoDato _TipoDato
        {
            get { return TipoD; }
            set
            {
                TipoD = value;
                string mascara = "";
                switch (TipoD)
                {
                    case TipoDato.texto:
                        this.Mask = mascara.PadLeft(_Ancho, 'C');
                        this.TextAlign = HorizontalAlignment.Left;
                        break;
                    case TipoDato.numero:

                        if (_Decimales >= 1)
                        {
                            mascara = mascara.PadLeft(_Ancho - _Decimales - 1, '9') + ".";
                            mascara = mascara.PadRight(_Ancho, '9');
                        }
                        else
                            mascara = mascara.PadLeft(_Ancho, '9');
                        this.Mask = mascara;
                        this.TextAlign = HorizontalAlignment.Right;
                        break;
                    case TipoDato.fecha:
                        this.Mask = "00/00/0000";
                        this.TextAlign = HorizontalAlignment.Left;
                        break;
                    default:
                        break;
                }
            }
        }
        public string _Text
        {
            get => this.Text;
            set
            {
                if (TipoD == TipoDato.numero)
                {
                    if (_Decimales == 0)
                        this.Text = string.Format("{0:" + this.Mask.Replace('9', '0') + "}", int.Parse(value));
                    else
                        this.Text = string.Format("{0:" + this.Mask.Replace('9', '0') + "}", double.Parse(value));
                }
            }

        }
        TipoDato TipoD = TipoDato.texto;

        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.ResumeLayout(false);

        }

        public void ControlFormato (object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar("."))
            {
                if (this._TipoDato == TipoDato.numero)
                {
                    this.Text = this.Text.Trim();
                    int blanco = this.Text.IndexOf(' ');
                    int entero = _Ancho - _Decimales - 1;

                    if (blanco <= entero && blanco != -1)
                    {
                        for (int i = 0; i < entero - blanco; i++)
                        {
                            this.Text = " " + this.Text;
                        }
                    }
                    this.SelectionStart = this.Text.Length;
                }
            }
        }
    }
}
