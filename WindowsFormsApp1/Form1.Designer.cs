namespace WindowsFormsApp1
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DesarrolladoLabel = new System.Windows.Forms.Label();
            this.BananaLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.HoraFecha = new System.Windows.Forms.Label();
            this.LogoImagen = new System.Windows.Forms.PictureBox();
            this.dataGridProductos = new System.Windows.Forms.DataGridView();
            this.textCodigo = new System.Windows.Forms.TextBox();
            this.labelTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.LogoImagen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // DesarrolladoLabel
            // 
            this.DesarrolladoLabel.AutoSize = true;
            this.DesarrolladoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DesarrolladoLabel.Location = new System.Drawing.Point(276, 153);
            this.DesarrolladoLabel.Name = "DesarrolladoLabel";
            this.DesarrolladoLabel.Size = new System.Drawing.Size(156, 20);
            this.DesarrolladoLabel.TabIndex = 1;
            this.DesarrolladoLabel.Text = "Desarrollado por:";
            // 
            // BananaLabel
            // 
            this.BananaLabel.AutoSize = true;
            this.BananaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BananaLabel.Location = new System.Drawing.Point(678, 229);
            this.BananaLabel.Name = "BananaLabel";
            this.BananaLabel.Size = new System.Drawing.Size(66, 20);
            this.BananaLabel.TabIndex = 2;
            this.BananaLabel.Text = "Banana";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // HoraFecha
            // 
            this.HoraFecha.AutoSize = true;
            this.HoraFecha.Location = new System.Drawing.Point(502, 78);
            this.HoraFecha.Name = "HoraFecha";
            this.HoraFecha.Size = new System.Drawing.Size(91, 16);
            this.HoraFecha.TabIndex = 3;
            this.HoraFecha.Text = "Hora y Fecha ";
            // 
            // LogoImagen
            // 
            this.LogoImagen.Image = ((System.Drawing.Image)(resources.GetObject("LogoImagen.Image")));
            this.LogoImagen.Location = new System.Drawing.Point(224, 264);
            this.LogoImagen.Name = "LogoImagen";
            this.LogoImagen.Size = new System.Drawing.Size(992, 154);
            this.LogoImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LogoImagen.TabIndex = 4;
            this.LogoImagen.TabStop = false;
            // 
            // dataGridProductos
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProductos.Location = new System.Drawing.Point(22, 108);
            this.dataGridProductos.Name = "dataGridProductos";
            this.dataGridProductos.RowHeadersVisible = false;
            this.dataGridProductos.RowHeadersWidth = 51;
            this.dataGridProductos.RowTemplate.Height = 24;
            this.dataGridProductos.Size = new System.Drawing.Size(240, 150);
            this.dataGridProductos.TabIndex = 5;
            // 
            // textCodigo
            // 
            this.textCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCodigo.Location = new System.Drawing.Point(280, 75);
            this.textCodigo.Name = "textCodigo";
            this.textCodigo.Size = new System.Drawing.Size(100, 38);
            this.textCodigo.TabIndex = 0;
            this.textCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.enter);
            this.textCodigo.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.tab);
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.Location = new System.Drawing.Point(473, 206);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(177, 32);
            this.labelTotal.TabIndex = 7;
            this.labelTotal.Text = "Total: $0.00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.textCodigo);
            this.Controls.Add(this.dataGridProductos);
            this.Controls.Add(this.LogoImagen);
            this.Controls.Add(this.HoraFecha);
            this.Controls.Add(this.BananaLabel);
            this.Controls.Add(this.DesarrolladoLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LogoImagen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label DesarrolladoLabel;
        private System.Windows.Forms.Label BananaLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label HoraFecha;
        private System.Windows.Forms.PictureBox LogoImagen;
        private System.Windows.Forms.DataGridView dataGridProductos;
        private System.Windows.Forms.TextBox textCodigo;
        private System.Windows.Forms.Label labelTotal;
    }
}

