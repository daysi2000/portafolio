namespace CLASE04.Formularios.FrmBASE
{
    partial class FrmBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBase));
            this.btn_minimizar = new System.Windows.Forms.Button();
            this.btn_maximizar = new System.Windows.Forms.Button();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_minimizar
            // 
            resources.ApplyResources(this.btn_minimizar, "btn_minimizar");
            this.btn_minimizar.FlatAppearance.BorderSize = 0;
            this.btn_minimizar.Name = "btn_minimizar";
            this.btn_minimizar.UseVisualStyleBackColor = false;
            this.btn_minimizar.MouseLeave += new System.EventHandler(this.btn_minimizar_MouseLeave);
            this.btn_minimizar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btn_minimizar_MouseMove);
            // 
            // btn_maximizar
            // 
            resources.ApplyResources(this.btn_maximizar, "btn_maximizar");
            this.btn_maximizar.FlatAppearance.BorderSize = 0;
            this.btn_maximizar.Name = "btn_maximizar";
            this.btn_maximizar.UseVisualStyleBackColor = false;
            this.btn_maximizar.MouseLeave += new System.EventHandler(this.btn_maximizar_MouseLeave);
            this.btn_maximizar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btn_maximizar_MouseMove);
            // 
            // btn_cerrar
            // 
            resources.ApplyResources(this.btn_cerrar, "btn_cerrar");
            this.btn_cerrar.FlatAppearance.BorderSize = 0;
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.UseVisualStyleBackColor = false;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            this.btn_cerrar.MouseLeave += new System.EventHandler(this.btn_cerrar_MouseLeave);
            this.btn_cerrar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btn_cerrar_MouseMove);
            // 
            // FrmBase
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_minimizar);
            this.Controls.Add(this.btn_maximizar);
            this.Controls.Add(this.btn_cerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmBase";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmBase_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmBase_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FrmBase_MouseUp);
            this.ResumeLayout(false);

        }

        #endregion
        protected System.Windows.Forms.Button btn_cerrar;
        protected System.Windows.Forms.Button btn_minimizar;
        protected System.Windows.Forms.Button btn_maximizar;
    }
}