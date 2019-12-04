namespace SpaLujoso
{
    partial class Form1
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
            this.ListToallas = new System.Windows.Forms.ListBox();
            this.txtNumUsu = new System.Windows.Forms.TextBox();
            this.checkBoxDucha = new System.Windows.Forms.CheckBox();
            this.btnUsuario = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ListToallas
            // 
            this.ListToallas.FormattingEnabled = true;
            this.ListToallas.Location = new System.Drawing.Point(27, 114);
            this.ListToallas.Name = "ListToallas";
            this.ListToallas.Size = new System.Drawing.Size(168, 186);
            this.ListToallas.TabIndex = 0;
            // 
            // txtNumUsu
            // 
            this.txtNumUsu.Location = new System.Drawing.Point(54, 51);
            this.txtNumUsu.Name = "txtNumUsu";
            this.txtNumUsu.Size = new System.Drawing.Size(32, 20);
            this.txtNumUsu.TabIndex = 1;
            // 
            // checkBoxDucha
            // 
            this.checkBoxDucha.AutoSize = true;
            this.checkBoxDucha.Location = new System.Drawing.Point(237, 160);
            this.checkBoxDucha.Name = "checkBoxDucha";
            this.checkBoxDucha.Size = new System.Drawing.Size(58, 17);
            this.checkBoxDucha.TabIndex = 2;
            this.checkBoxDucha.Text = "Ducha";
            this.checkBoxDucha.UseVisualStyleBackColor = true;
            // 
            // btnUsuario
            // 
            this.btnUsuario.Location = new System.Drawing.Point(237, 219);
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Size = new System.Drawing.Size(96, 23);
            this.btnUsuario.TabIndex = 3;
            this.btnUsuario.Text = "Nuevo Usuario";
            this.btnUsuario.UseVisualStyleBackColor = true;
            this.btnUsuario.Click += new System.EventHandler(this.BtnUsuario_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Usuarios en cola";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 358);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUsuario);
            this.Controls.Add(this.checkBoxDucha);
            this.Controls.Add(this.txtNumUsu);
            this.Controls.Add(this.ListToallas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ListToallas;
        private System.Windows.Forms.TextBox txtNumUsu;
        private System.Windows.Forms.CheckBox checkBoxDucha;
        private System.Windows.Forms.Button btnUsuario;
        private System.Windows.Forms.Label label1;
    }
}

