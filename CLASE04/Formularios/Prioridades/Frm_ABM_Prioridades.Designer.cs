namespace CLASE04.Formularios.Prioridades
{
    partial class Frm_ABM_Prioridades
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
            this.grid011 = new CLASE04.Clases.Grid01();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid011)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.FlatAppearance.BorderSize = 0;
            // 
            // btn_minimizar
            // 
            this.btn_minimizar.FlatAppearance.BorderSize = 0;
            // 
            // btn_maximizar
            // 
            this.btn_maximizar.FlatAppearance.BorderSize = 0;
            // 
            // grid011
            // 
            this.grid011.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid011.Location = new System.Drawing.Point(13, 200);
            this.grid011.Name = "grid011";
            this.grid011.Size = new System.Drawing.Size(581, 161);
            this.grid011.TabIndex = 5;
            // 
            // Frm_ABM_Prioridades
            // 
            this._titulo = "ABM Prioridades";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(606, 439);
            this.Controls.Add(this.grid011);
            this.Name = "Frm_ABM_Prioridades";
            this.Controls.SetChildIndex(this.btn_cerrar, 0);
            this.Controls.SetChildIndex(this.btn_maximizar, 0);
            this.Controls.SetChildIndex(this.btn_minimizar, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.btn_alta, 0);
            this.Controls.SetChildIndex(this.btn_modificar, 0);
            this.Controls.SetChildIndex(this.btn_borrar, 0);
            this.Controls.SetChildIndex(this.grid011, 0);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid011)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Clases.Grid01 grid011;
    }
}
