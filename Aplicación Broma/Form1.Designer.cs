namespace Aplicación_Broma
{
    partial class AplicacionBroma
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
            this.BotonBroma = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BotonBroma
            // 
            this.BotonBroma.Location = new System.Drawing.Point(340, 257);
            this.BotonBroma.Name = "BotonBroma";
            this.BotonBroma.Size = new System.Drawing.Size(147, 72);
            this.BotonBroma.TabIndex = 0;
            this.BotonBroma.Text = "¡¡¡¡ HAZ CLICK AQUÍ !!!!";
            this.BotonBroma.UseVisualStyleBackColor = true;
            this.BotonBroma.MouseEnter += new System.EventHandler(this.BotonBroma_MouseEnter);
            // 
            // AplicacionBroma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Aplicación_Broma.Properties.Resources.riacrdoarjona4k;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BotonBroma);
            this.Name = "AplicacionBroma";
            this.Text = "AplicacionBroma";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BotonBroma;
    }
}

