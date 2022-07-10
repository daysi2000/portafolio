namespace CLASE04.Formularios.FrmBASE
{
    partial class FrmBase_AMB_Entrada
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.btn_alta = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btn_modificar = new System.Windows.Forms.Button();
            this.btn_borrar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.FlatAppearance.BorderSize = 0;
            this.btn_cerrar.Location = new System.Drawing.Point(560, 4);
            // 
            // btn_minimizar
            // 
            this.btn_minimizar.FlatAppearance.BorderSize = 0;
            this.btn_minimizar.Location = new System.Drawing.Point(474, 4);
            // 
            // btn_maximizar
            // 
            this.btn_maximizar.FlatAppearance.BorderSize = 0;
            this.btn_maximizar.Location = new System.Drawing.Point(517, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Titulo";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_buscar);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(582, 113);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Restricciones de Búsqueda";
            // 
            // btn_buscar
            // 
            this.btn_buscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_buscar.ForeColor = System.Drawing.Color.Black;
            this.btn_buscar.Location = new System.Drawing.Point(501, 75);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(75, 27);
            this.btn_buscar.TabIndex = 0;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = false;
            // 
            // btn_alta
            // 
            this.btn_alta.BackgroundImage = global::CLASE04.Properties.Resources.agregar;
            this.btn_alta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_alta.Location = new System.Drawing.Point(9, 386);
            this.btn_alta.Name = "btn_alta";
            this.btn_alta.Size = new System.Drawing.Size(40, 41);
            this.btn_alta.TabIndex = 4;
            this.toolTip1.SetToolTip(this.btn_alta, "Permite ingresar al formulario de Altas de registro\r\n");
            this.btn_alta.UseVisualStyleBackColor = true;
            // 
            // btn_modificar
            // 
            this.btn_modificar.BackgroundImage = global::CLASE04.Properties.Resources.modificar01;
            this.btn_modificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_modificar.Location = new System.Drawing.Point(55, 386);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(40, 41);
            this.btn_modificar.TabIndex = 4;
            this.toolTip1.SetToolTip(this.btn_modificar, "Permite el ingreso a el formulario de modificaciones");
            this.btn_modificar.UseVisualStyleBackColor = true;
            // 
            // btn_borrar
            // 
            this.btn_borrar.BackgroundImage = global::CLASE04.Properties.Resources.cancelar4;
            this.btn_borrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_borrar.Location = new System.Drawing.Point(101, 386);
            this.btn_borrar.Name = "btn_borrar";
            this.btn_borrar.Size = new System.Drawing.Size(40, 41);
            this.btn_borrar.TabIndex = 4;
            this.toolTip1.SetToolTip(this.btn_borrar, "Permite el ingreso al formulario de borrado");
            this.btn_borrar.UseVisualStyleBackColor = true;
            // 
            // FrmBase_AMB_
            // 
            this._FormularioMovil = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(606, 439);
            this.Controls.Add(this.btn_borrar);
            this.Controls.Add(this.btn_modificar);
            this.Controls.Add(this.btn_alta);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "FrmBase_AMB_";
            this.toolTip1.SetToolTip(this, "Permite ingresar al formulario de Altas de registros\r\n");
            this.Controls.SetChildIndex(this.btn_cerrar, 0);
            this.Controls.SetChildIndex(this.btn_maximizar, 0);
            this.Controls.SetChildIndex(this.btn_minimizar, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.btn_alta, 0);
            this.Controls.SetChildIndex(this.btn_modificar, 0);
            this.Controls.SetChildIndex(this.btn_borrar, 0);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        protected System.Windows.Forms.GroupBox groupBox1;
        protected System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.ToolTip toolTip1;
        protected System.Windows.Forms.Button btn_alta;
        protected System.Windows.Forms.Button btn_modificar;
        protected System.Windows.Forms.Button btn_borrar;
    }
}
