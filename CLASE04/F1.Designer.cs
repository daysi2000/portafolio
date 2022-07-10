namespace CLASE04
{
    partial class F1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_nobreUsuario = new Clases.LabelText02();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_password = new Clases.LabelText02();
            this.labelText021 = new Clases.LabelText02();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.Cmb_EstadoUsuario = new CLASE04.Clases.ComboBox01();
            this.C1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.FlatAppearance.BorderSize = 0;
            this.btn_cerrar.Location = new System.Drawing.Point(398, 4);
            // 
            // btn_minimizar
            // 
            this.btn_minimizar.FlatAppearance.BorderSize = 0;
            this.btn_minimizar.Location = new System.Drawing.Point(312, 4);
            // 
            // btn_maximizar
            // 
            this.btn_maximizar.FlatAppearance.BorderSize = 0;
            this.btn_maximizar.Location = new System.Drawing.Point(355, 4);
            // 
            // txt_nobreUsuario
            // 
            this.txt_nobreUsuario._Ancho = 10;
            this.txt_nobreUsuario._Decimales = 2;
            this.txt_nobreUsuario._Etiqueta = "Nomb. Usuario";
            this.txt_nobreUsuario._MensajeError = null;
            this.txt_nobreUsuario._Nombre_campo = null;
            this.txt_nobreUsuario._Nombre_tabla = null;
            this.txt_nobreUsuario._ReadOnly = false;
            this.txt_nobreUsuario._Text = "";
            this.txt_nobreUsuario._TipoDato = Clases.LabelText02.TipoDato.texto;
            this.txt_nobreUsuario._Validable = false;
            this.txt_nobreUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nobreUsuario.Location = new System.Drawing.Point(111, 72);
            this.txt_nobreUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nobreUsuario.Name = "txt_nobreUsuario";
            this.txt_nobreUsuario.Size = new System.Drawing.Size(228, 28);
            this.txt_nobreUsuario.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(260, 243);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 26);
            this.button1.TabIndex = 3;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txt_password
            // 
            this.txt_password._Ancho = 10;
            this.txt_password._Decimales = 2;
            this.txt_password._Etiqueta = "Numero";
            this.txt_password._MensajeError = null;
            this.txt_password._Nombre_campo = null;
            this.txt_password._Nombre_tabla = null;
            this.txt_password._ReadOnly = false;
            this.txt_password._Text = "       .";
            this.txt_password._TipoDato = Clases.LabelText02.TipoDato.numero;
            this.txt_password._Validable = false;
            this.txt_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.Location = new System.Drawing.Point(111, 108);
            this.txt_password.Margin = new System.Windows.Forms.Padding(4);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(228, 28);
            this.txt_password.TabIndex = 4;
            // 
            // labelText021
            // 
            this.labelText021._Ancho = 10;
            this.labelText021._Decimales = 2;
            this.labelText021._Etiqueta = "Fecha Nacimiento";
            this.labelText021._MensajeError = null;
            this.labelText021._Nombre_campo = null;
            this.labelText021._Nombre_tabla = null;
            this.labelText021._ReadOnly = false;
            this.labelText021._Text = "  /  /";
            this.labelText021._TipoDato = Clases.LabelText02.TipoDato.fecha;
            this.labelText021._Validable = false;
            this.labelText021.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelText021.Location = new System.Drawing.Point(111, 36);
            this.labelText021.Margin = new System.Windows.Forms.Padding(4);
            this.labelText021.Name = "labelText021";
            this.labelText021.Size = new System.Drawing.Size(228, 28);
            this.labelText021.TabIndex = 5;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(260, 143);
            this.maskedTextBox1.Mask = "9999999.99";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(75, 20);
            this.maskedTextBox1.TabIndex = 6;
            this.maskedTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Cmb_EstadoUsuario
            // 
            this.Cmb_EstadoUsuario._MensajeError = null;
            this.Cmb_EstadoUsuario._Nombre_campo = null;
            this.Cmb_EstadoUsuario._Nombre_tabla = null;
            this.Cmb_EstadoUsuario._tabla_cargar_combo = "EstadosUsuarios";
            this.Cmb_EstadoUsuario._tabla_cargar_descriptor = "n_estado_usuario";
            this.Cmb_EstadoUsuario._tabla_cargar_pk = "id_estado_usuario";
            this.Cmb_EstadoUsuario._Validable = false;
            this.Cmb_EstadoUsuario.FormattingEnabled = true;
            this.Cmb_EstadoUsuario.Location = new System.Drawing.Point(214, 169);
            this.Cmb_EstadoUsuario.Name = "Cmb_EstadoUsuario";
            this.Cmb_EstadoUsuario.Size = new System.Drawing.Size(121, 21);
            this.Cmb_EstadoUsuario.TabIndex = 7;
            // 
            // C1
            // 
            this.C1.FormattingEnabled = true;
            this.C1.Location = new System.Drawing.Point(214, 196);
            this.C1.Name = "C1";
            this.C1.Size = new System.Drawing.Size(121, 21);
            this.C1.TabIndex = 8;
            // 
            // F1
            // 
            this._FormularioMovil = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(444, 294);
            this.Controls.Add(this.C1);
            this.Controls.Add(this.Cmb_EstadoUsuario);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.labelText021);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_nobreUsuario);
            this.Name = "F1";
            this.Load += new System.EventHandler(this.F1_Load);
            this.Controls.SetChildIndex(this.btn_cerrar, 0);
            this.Controls.SetChildIndex(this.btn_maximizar, 0);
            this.Controls.SetChildIndex(this.btn_minimizar, 0);
            this.Controls.SetChildIndex(this.txt_nobreUsuario, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.txt_password, 0);
            this.Controls.SetChildIndex(this.labelText021, 0);
            this.Controls.SetChildIndex(this.maskedTextBox1, 0);
            this.Controls.SetChildIndex(this.Cmb_EstadoUsuario, 0);
            this.Controls.SetChildIndex(this.C1, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Button button1;
        public CLASE04.Clases.LabelText02 txt_password;
        private CLASE04.Clases.LabelText02 txt_nobreUsuario;
        private CLASE04.Clases.LabelText02 labelText021;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private Clases.ComboBox01 Cmb_EstadoUsuario;
        private System.Windows.Forms.ComboBox C1;
    }
}
