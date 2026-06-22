namespace GestorPuntaje.GUI
{
    partial class VistaPrincipal
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VistaPrincipal));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnTerminarRonda = new System.Windows.Forms.Button();
            this.btnCalcularResultado = new System.Windows.Forms.Button();
            this.gridPuntajes = new System.Windows.Forms.DataGridView();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lblNumRonda = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lblReparte = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridPuntajes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(221, 40);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(586, 73);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Puntaje Jugadores";
            // 
            // btnTerminarRonda
            // 
            this.btnTerminarRonda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTerminarRonda.Location = new System.Drawing.Point(143, 199);
            this.btnTerminarRonda.Name = "btnTerminarRonda";
            this.btnTerminarRonda.Size = new System.Drawing.Size(248, 50);
            this.btnTerminarRonda.TabIndex = 1;
            this.btnTerminarRonda.Text = "Terminar Ronda";
            this.btnTerminarRonda.UseVisualStyleBackColor = true;
            this.btnTerminarRonda.Click += new System.EventHandler(this.btnTerminarRonda_Click);
            // 
            // btnCalcularResultado
            // 
            this.btnCalcularResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcularResultado.Location = new System.Drawing.Point(572, 202);
            this.btnCalcularResultado.Name = "btnCalcularResultado";
            this.btnCalcularResultado.Size = new System.Drawing.Size(290, 50);
            this.btnCalcularResultado.TabIndex = 2;
            this.btnCalcularResultado.Text = "Calcular Resultados";
            this.btnCalcularResultado.UseVisualStyleBackColor = true;
            this.btnCalcularResultado.Click += new System.EventHandler(this.btnCalcularResultado_Click);
            // 
            // gridPuntajes
            // 
            this.gridPuntajes.AllowUserToAddRows = false;
            this.gridPuntajes.AllowUserToDeleteRows = false;
            this.gridPuntajes.AllowUserToResizeColumns = false;
            this.gridPuntajes.AllowUserToResizeRows = false;
            this.gridPuntajes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridPuntajes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridPuntajes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridPuntajes.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridPuntajes.Location = new System.Drawing.Point(12, 258);
            this.gridPuntajes.MultiSelect = false;
            this.gridPuntajes.Name = "gridPuntajes";
            this.gridPuntajes.RowHeadersVisible = false;
            this.gridPuntajes.RowHeadersWidth = 82;
            this.gridPuntajes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridPuntajes.RowTemplate.Height = 33;
            this.gridPuntajes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.gridPuntajes.Size = new System.Drawing.Size(989, 634);
            this.gridPuntajes.TabIndex = 3;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(250, 951);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(120, 37);
            this.lbl1.TabIndex = 4;
            this.lbl1.Text = "Ronda:";
            // 
            // lblNumRonda
            // 
            this.lblNumRonda.AutoSize = true;
            this.lblNumRonda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumRonda.Location = new System.Drawing.Point(376, 951);
            this.lblNumRonda.Name = "lblNumRonda";
            this.lblNumRonda.Size = new System.Drawing.Size(33, 37);
            this.lblNumRonda.TabIndex = 5;
            this.lblNumRonda.Text = "1";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(502, 951);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(138, 37);
            this.lbl2.TabIndex = 6;
            this.lbl2.Text = "Reparte:";
            // 
            // lblReparte
            // 
            this.lblReparte.AutoSize = true;
            this.lblReparte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReparte.Location = new System.Drawing.Point(646, 951);
            this.lblReparte.Name = "lblReparte";
            this.lblReparte.Size = new System.Drawing.Size(132, 37);
            this.lblReparte.TabIndex = 7;
            this.lblReparte.Text = "Nombre";
            // 
            // VistaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1013, 1048);
            this.Controls.Add(this.lblReparte);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lblNumRonda);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.gridPuntajes);
            this.Controls.Add(this.btnCalcularResultado);
            this.Controls.Add(this.btnTerminarRonda);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "VistaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestor de Puntajes";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.VistaPrincipal_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.gridPuntajes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnTerminarRonda;
        private System.Windows.Forms.Button btnCalcularResultado;
        private System.Windows.Forms.DataGridView gridPuntajes;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lblNumRonda;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lblReparte;
    }
}