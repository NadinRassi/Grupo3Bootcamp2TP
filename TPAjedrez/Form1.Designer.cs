namespace TPAjedrez
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
            this.btnGenerarPeon = new System.Windows.Forms.Button();
            this.btnCrearTorre = new System.Windows.Forms.Button();
            this.btnCrearCaballo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGenerarPeon
            // 
            this.btnGenerarPeon.Location = new System.Drawing.Point(121, 140);
            this.btnGenerarPeon.Name = "btnGenerarPeon";
            this.btnGenerarPeon.Size = new System.Drawing.Size(196, 23);
            this.btnGenerarPeon.TabIndex = 0;
            this.btnGenerarPeon.Text = "Crear peón";
            this.btnGenerarPeon.UseVisualStyleBackColor = true;
            this.btnGenerarPeon.Click += new System.EventHandler(this.btnGenerarPeon_Click);
            // 
            // btnCrearTorre
            // 
            this.btnCrearTorre.Location = new System.Drawing.Point(180, 220);
            this.btnCrearTorre.Name = "btnCrearTorre";
            this.btnCrearTorre.Size = new System.Drawing.Size(75, 23);
            this.btnCrearTorre.TabIndex = 1;
            this.btnCrearTorre.Text = "Crear torre";
            this.btnCrearTorre.UseVisualStyleBackColor = true;
            this.btnCrearTorre.Click += new System.EventHandler(this.btnCrearTorre_Click);
            // 
            // btnCrearCaballo
            // 
            this.btnCrearCaballo.Location = new System.Drawing.Point(162, 70);
            this.btnCrearCaballo.Name = "btnCrearCaballo";
            this.btnCrearCaballo.Size = new System.Drawing.Size(116, 23);
            this.btnCrearCaballo.TabIndex = 2;
            this.btnCrearCaballo.Text = "Crear caballo";
            this.btnCrearCaballo.UseVisualStyleBackColor = true;
            this.btnCrearCaballo.Click += new System.EventHandler(this.btnCrearCaballo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 331);
            this.Controls.Add(this.btnCrearCaballo);
            this.Controls.Add(this.btnCrearTorre);
            this.Controls.Add(this.btnGenerarPeon);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGenerarPeon;
        private System.Windows.Forms.Button btnCrearTorre;
        private System.Windows.Forms.Button btnCrearCaballo;
    }
}

