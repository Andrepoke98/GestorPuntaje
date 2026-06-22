namespace GestorPuntaje
{
    partial class CantidadJugadoresDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CantidadJugadoresDialog));
            this.trackBarJugadores = new System.Windows.Forms.TrackBar();
            this.lblCantidadJugadores = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnListo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarJugadores)).BeginInit();
            this.SuspendLayout();
            // 
            // trackBarJugadores
            // 
            this.trackBarJugadores.Location = new System.Drawing.Point(95, 247);
            this.trackBarJugadores.Maximum = 8;
            this.trackBarJugadores.Minimum = 2;
            this.trackBarJugadores.Name = "trackBarJugadores";
            this.trackBarJugadores.Size = new System.Drawing.Size(705, 90);
            this.trackBarJugadores.TabIndex = 0;
            this.trackBarJugadores.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarJugadores.Value = 2;
            this.trackBarJugadores.Scroll += new System.EventHandler(this.trackBarJugadores_Scroll);
            // 
            // lblCantidadJugadores
            // 
            this.lblCantidadJugadores.AutoSize = true;
            this.lblCantidadJugadores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadJugadores.Location = new System.Drawing.Point(412, 340);
            this.lblCantidadJugadores.Name = "lblCantidadJugadores";
            this.lblCantidadJugadores.Size = new System.Drawing.Size(35, 37);
            this.lblCantidadJugadores.TabIndex = 1;
            this.lblCantidadJugadores.Text = "2";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(82, 54);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(718, 73);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Cantidad de Jugadores";
            // 
            // btnListo
            // 
            this.btnListo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListo.Location = new System.Drawing.Point(372, 432);
            this.btnListo.Name = "btnListo";
            this.btnListo.Size = new System.Drawing.Size(111, 43);
            this.btnListo.TabIndex = 3;
            this.btnListo.Text = "Listo";
            this.btnListo.UseVisualStyleBackColor = true;
            this.btnListo.Click += new System.EventHandler(this.btnListo_Click);
            // 
            // CantidadJugadoresDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 517);
            this.Controls.Add(this.btnListo);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblCantidadJugadores);
            this.Controls.Add(this.trackBarJugadores);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CantidadJugadoresDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestor de Puntajes";
            ((System.ComponentModel.ISupportInitialize)(this.trackBarJugadores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trackBarJugadores;
        private System.Windows.Forms.Label lblCantidadJugadores;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnListo;
    }
}

