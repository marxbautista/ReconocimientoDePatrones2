namespace ReconocimientoDePatrones
{
    partial class Controles
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
            this.label1 = new System.Windows.Forms.Label();
            this.txbCantidad = new System.Windows.Forms.TextBox();
            this.txbDimension = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbK = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbSalida = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cantidad=";
            // 
            // txbCantidad
            // 
            this.txbCantidad.Location = new System.Drawing.Point(64, 12);
            this.txbCantidad.Name = "txbCantidad";
            this.txbCantidad.Size = new System.Drawing.Size(33, 20);
            this.txbCantidad.TabIndex = 1;
            this.txbCantidad.Text = "10";
            // 
            // txbDimension
            // 
            this.txbDimension.Location = new System.Drawing.Point(82, 42);
            this.txbDimension.Name = "txbDimension";
            this.txbDimension.Size = new System.Drawing.Size(33, 20);
            this.txbDimension.TabIndex = 3;
            this.txbDimension.Text = "2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Dimensiones=";
            // 
            // txbK
            // 
            this.txbK.Location = new System.Drawing.Point(38, 71);
            this.txbK.Name = "txbK";
            this.txbK.Size = new System.Drawing.Size(33, 20);
            this.txbK.TabIndex = 5;
            this.txbK.Text = "10";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "K=";
            // 
            // txbSalida
            // 
            this.txbSalida.Location = new System.Drawing.Point(12, 128);
            this.txbSalida.Multiline = true;
            this.txbSalida.Name = "txbSalida";
            this.txbSalida.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txbSalida.Size = new System.Drawing.Size(242, 325);
            this.txbSalida.TabIndex = 7;
            // 
            // Controles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 543);
            this.ControlBox = false;
            this.Controls.Add(this.txbSalida);
            this.Controls.Add(this.txbK);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbDimension);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbCantidad);
            this.Controls.Add(this.label1);
            this.Name = "Controles";
            this.ShowInTaskbar = false;
            this.Text = "Controles";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbCantidad;
        private System.Windows.Forms.TextBox txbDimension;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbK;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbSalida;
    }
}