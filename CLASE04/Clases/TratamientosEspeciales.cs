using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;




namespace CLASE04.Clases
{
    class TratamientosEspeciales
    {
        public enum RespuestaValidacion { Correcta, Error }

        public RespuestaValidacion Validar(Control.ControlCollection Controles)
        {
            foreach (var item in Controles)
            {
                if (item.GetType().Name == "LabelText02")
                {
                    if(((LabelText02)item)._Validable==true)
                    {
                        if(((LabelText02)item)._Text==string.Empty)
                        {
                            MessageBox.Show(((LabelText02)item)._MensajeError);
                            ((LabelText02)item).Focus();
                            return RespuestaValidacion.Error;
                        }
                    }
                }
                if (item.GetType().Name == "ComboBox01")
                {
                  if (((ComboBox01)item)._Validable == true)
                    {
                        if(((ComboBox01)item).SelectedIndex == -1)
                        {
                            MessageBox.Show(((ComboBox01)item)._MensajeError);
                            ((ComboBox01)item).Focus();
                            return RespuestaValidacion.Error;
                        }
                    }
                }
            }
            return RespuestaValidacion.Correcta;
        }

    }
}
