namespace ALGORITMOS
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dda = new System.Windows.Forms.Button();
            this.bresenham = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(10, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(523, 379);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseClick);
            // 
            // dda
            // 
            this.dda.Location = new System.Drawing.Point(554, 22);
            this.dda.Name = "dda";
            this.dda.Size = new System.Drawing.Size(107, 23);
            this.dda.TabIndex = 1;
            this.dda.Text = "DDA";
            this.dda.UseVisualStyleBackColor = true;
            this.dda.Click += new System.EventHandler(this.dda_Click);
            // 
            // bresenham
            // 
            this.bresenham.Location = new System.Drawing.Point(681, 22);
            this.bresenham.Name = "bresenham";
            this.bresenham.Size = new System.Drawing.Size(107, 23);
            this.bresenham.TabIndex = 2;
            this.bresenham.Text = "BRESEMHAM";
            this.bresenham.UseVisualStyleBackColor = true;
            this.bresenham.Click += new System.EventHandler(this.bresenham_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bresenham);
            this.Controls.Add(this.dda);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button dda;
        private System.Windows.Forms.Button bresenham;
    }
}

