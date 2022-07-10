namespace CLASE04.Formularios.Usuarios
{
    partial class Frm_ABM_Usuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ABM_Usuario));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grid_usuarios = new CLASE04.Clases.Grid01();
            this.txt_patron = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_id_usuario = new System.Windows.Forms.MaskedTextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btn_blan_patron = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rb_nombre = new System.Windows.Forms.RadioButton();
            this.rb_apellido = new System.Windows.Forms.RadioButton();
            this.rb_n_usuario = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_usuarios)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_blan_patron);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.txt_id_usuario);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_patron);
            this.groupBox1.Location = new System.Drawing.Point(13, 82);
            this.groupBox1.Size = new System.Drawing.Size(582, 112);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.Controls.SetChildIndex(this.btn_buscar, 0);
            this.groupBox1.Controls.SetChildIndex(this.txt_patron, 0);
            this.groupBox1.Controls.SetChildIndex(this.label2, 0);
            this.groupBox1.Controls.SetChildIndex(this.label3, 0);
            this.groupBox1.Controls.SetChildIndex(this.txt_id_usuario, 0);
            this.groupBox1.Controls.SetChildIndex(this.groupBox2, 0);
            this.groupBox1.Controls.SetChildIndex(this.btn_blan_patron, 0);
            // 
            // btn_buscar
            // 
            this.btn_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscar.Location = new System.Drawing.Point(497, 79);
            this.btn_buscar.Size = new System.Drawing.Size(79, 26);
            this.btn_buscar.TabIndex = 5;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // btn_alta
            // 
            this.btn_alta.TabIndex = 2;
            this.btn_alta.Click += new System.EventHandler(this.btn_alta_Click);
            // 
            // btn_modificar
            // 
            this.btn_modificar.TabIndex = 3;
            // 
            // btn_borrar
            // 
            this.btn_borrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_borrar.BackgroundImage")));
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.FlatAppearance.BorderSize = 0;
            this.btn_cerrar.Location = new System.Drawing.Point(559, 4);
            // 
            // btn_minimizar
            // 
            this.btn_minimizar.FlatAppearance.BorderSize = 0;
            this.btn_minimizar.Location = new System.Drawing.Point(473, 4);
            this.btn_minimizar.Visible = false;
            // 
            // btn_maximizar
            // 
            this.btn_maximizar.FlatAppearance.BorderSize = 0;
            this.btn_maximizar.Location = new System.Drawing.Point(516, 4);
            this.btn_maximizar.Visible = false;
            // 
            // grid_usuarios
            // 
            this.grid_usuarios._formatoLetraHeader = System.Drawing.FontStyle.Bold;
            this.grid_usuarios._tamannoLetraHeader = 9;
            this.grid_usuarios.AllowUserToAddRows = false;
            this.grid_usuarios.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grid_usuarios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grid_usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_usuarios.Location = new System.Drawing.Point(13, 202);
            this.grid_usuarios.Name = "grid_usuarios";
            this.grid_usuarios.ReadOnly = true;
            this.grid_usuarios.Size = new System.Drawing.Size(582, 178);
            this.grid_usuarios.TabIndex = 1;
            // 
            // txt_patron
            // 
            this.txt_patron.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_patron.Location = new System.Drawing.Point(155, 28);
            this.txt_patron.Mask = "LLLLLLLLLLLLLLL";
            this.txt_patron.Name = "txt_patron";
            this.txt_patron.Size = new System.Drawing.Size(100, 23);
            this.txt_patron.TabIndex = 0;
            this.toolTip1.SetToolTip(this.txt_patron, "Escriba un patrón de búsqueda que tenga que ver con la selección del tipo de búsq" +
        "ueda");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Patrón de Búsqueda";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(75, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "id_usuario";
            // 
            // txt_id_usuario
            // 
            this.txt_id_usuario.Location = new System.Drawing.Point(155, 61);
            this.txt_id_usuario.Mask = "99";
            this.txt_id_usuario.Name = "txt_id_usuario";
            this.txt_id_usuario.Size = new System.Drawing.Size(29, 23);
            this.txt_id_usuario.TabIndex = 4;
            // 
            // btn_blan_patron
            // 
            this.btn_blan_patron.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_blan_patron.Location = new System.Drawing.Point(257, 28);
            this.btn_blan_patron.Name = "btn_blan_patron";
            this.btn_blan_patron.Size = new System.Drawing.Size(19, 23);
            this.btn_blan_patron.TabIndex = 8;
            this.toolTip1.SetToolTip(this.btn_blan_patron, "Limpiar el patrón de búsqueda");
            this.btn_blan_patron.UseVisualStyleBackColor = false;
            this.btn_blan_patron.Click += new System.EventHandler(this.btn_blan_patron_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rb_nombre);
            this.groupBox2.Controls.Add(this.rb_apellido);
            this.groupBox2.Controls.Add(this.rb_n_usuario);
            this.groupBox2.Location = new System.Drawing.Point(278, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(298, 54);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Buscar por: ";
            // 
            // rb_nombre
            // 
            this.rb_nombre.AutoSize = true;
            this.rb_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_nombre.Location = new System.Drawing.Point(205, 19);
            this.rb_nombre.Name = "rb_nombre";
            this.rb_nombre.Size = new System.Drawing.Size(81, 21);
            this.rb_nombre.TabIndex = 6;
            this.rb_nombre.TabStop = true;
            this.rb_nombre.Text = "nombres";
            this.rb_nombre.UseVisualStyleBackColor = true;
            // 
            // rb_apellido
            // 
            this.rb_apellido.AutoSize = true;
            this.rb_apellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_apellido.Location = new System.Drawing.Point(124, 19);
            this.rb_apellido.Name = "rb_apellido";
            this.rb_apellido.Size = new System.Drawing.Size(75, 21);
            this.rb_apellido.TabIndex = 5;
            this.rb_apellido.TabStop = true;
            this.rb_apellido.Text = "apellido";
            this.rb_apellido.UseVisualStyleBackColor = true;
            // 
            // rb_n_usuario
            // 
            this.rb_n_usuario.AutoSize = true;
            this.rb_n_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_n_usuario.Location = new System.Drawing.Point(29, 19);
            this.rb_n_usuario.Name = "rb_n_usuario";
            this.rb_n_usuario.Size = new System.Drawing.Size(89, 21);
            this.rb_n_usuario.TabIndex = 4;
            this.rb_n_usuario.TabStop = true;
            this.rb_n_usuario.Text = "n_usuario";
            this.rb_n_usuario.UseVisualStyleBackColor = true;
            // 
            // Frm_ABM_Usuario
            // 
            this._titulo = "ABM Usuario";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(605, 440);
            this.Controls.Add(this.grid_usuarios);
            this.Location = new System.Drawing.Point(0, 50);
            this.Name = "Frm_ABM_Usuario";
            this.Load += new System.EventHandler(this.Frm_ABM_Usuario_Load);
            this.Controls.SetChildIndex(this.btn_cerrar, 0);
            this.Controls.SetChildIndex(this.btn_maximizar, 0);
            this.Controls.SetChildIndex(this.btn_minimizar, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.btn_alta, 0);
            this.Controls.SetChildIndex(this.btn_modificar, 0);
            this.Controls.SetChildIndex(this.btn_borrar, 0);
            this.Controls.SetChildIndex(this.grid_usuarios, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_usuarios)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Clases.Grid01 grid_usuarios;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txt_patron;
        private System.Windows.Forms.MaskedTextBox txt_id_usuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rb_nombre;
        private System.Windows.Forms.RadioButton rb_apellido;
        private System.Windows.Forms.RadioButton rb_n_usuario;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btn_blan_patron;
    }
}
