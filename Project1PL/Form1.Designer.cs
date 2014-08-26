namespace Project1PL
{
    partial class MainWindow
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnRun = new System.Windows.Forms.Button();
            this.BtnClean = new System.Windows.Forms.Button();
            this.TxtBoxCode = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnRun
            // 
            this.BtnRun.Location = new System.Drawing.Point(508, 304);
            this.BtnRun.Name = "BtnRun";
            this.BtnRun.Size = new System.Drawing.Size(75, 23);
            this.BtnRun.TabIndex = 0;
            this.BtnRun.Text = "Run";
            this.BtnRun.UseVisualStyleBackColor = true;
            this.BtnRun.Click += new System.EventHandler(this.BtnRun_Click);
            // 
            // BtnClean
            // 
            this.BtnClean.Location = new System.Drawing.Point(427, 304);
            this.BtnClean.Name = "BtnClean";
            this.BtnClean.Size = new System.Drawing.Size(75, 23);
            this.BtnClean.TabIndex = 1;
            this.BtnClean.Text = "Clean";
            this.BtnClean.UseVisualStyleBackColor = true;
            // 
            // TxtBoxCode
            // 
            this.TxtBoxCode.Location = new System.Drawing.Point(12, 12);
            this.TxtBoxCode.Multiline = true;
            this.TxtBoxCode.Name = "TxtBoxCode";
            this.TxtBoxCode.Size = new System.Drawing.Size(591, 286);
            this.TxtBoxCode.TabIndex = 2;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 337);
            this.Controls.Add(this.TxtBoxCode);
            this.Controls.Add(this.BtnClean);
            this.Controls.Add(this.BtnRun);
            this.Name = "MainWindow";
            this.Text = "Lua Interpreter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnRun;
        private System.Windows.Forms.Button BtnClean;
        private System.Windows.Forms.TextBox TxtBoxCode;
    }
}

