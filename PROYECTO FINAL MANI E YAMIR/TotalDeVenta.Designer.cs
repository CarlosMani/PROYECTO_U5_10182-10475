namespace Proyecto_Taller_Mecanico
{
    partial class TotalDeVenta
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
            this.lbAtencion = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbUstedSrOSra = new System.Windows.Forms.Label();
            this.lbLoAtendio = new System.Windows.Forms.Label();
            this.lbTotalDeCompra = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbAtencion
            // 
            this.lbAtencion.AutoSize = true;
            this.lbAtencion.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAtencion.Location = new System.Drawing.Point(12, 53);
            this.lbAtencion.Name = "lbAtencion";
            this.lbAtencion.Size = new System.Drawing.Size(85, 17);
            this.lbAtencion.TabIndex = 0;
            this.lbAtencion.Text = "Lo Atendio:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Usted Sr(a):";
            // 
            // lbUstedSrOSra
            // 
            this.lbUstedSrOSra.AutoSize = true;
            this.lbUstedSrOSra.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUstedSrOSra.Location = new System.Drawing.Point(115, 85);
            this.lbUstedSrOSra.Name = "lbUstedSrOSra";
            this.lbUstedSrOSra.Size = new System.Drawing.Size(38, 17);
            this.lbUstedSrOSra.TabIndex = 3;
            this.lbUstedSrOSra.Text = "-----";
            // 
            // lbLoAtendio
            // 
            this.lbLoAtendio.AutoSize = true;
            this.lbLoAtendio.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLoAtendio.Location = new System.Drawing.Point(115, 53);
            this.lbLoAtendio.Name = "lbLoAtendio";
            this.lbLoAtendio.Size = new System.Drawing.Size(38, 17);
            this.lbLoAtendio.TabIndex = 2;
            this.lbLoAtendio.Text = "-----";
            // 
            // lbTotalDeCompra
            // 
            this.lbTotalDeCompra.AutoSize = true;
            this.lbTotalDeCompra.BackColor = System.Drawing.Color.Transparent;
            this.lbTotalDeCompra.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalDeCompra.Location = new System.Drawing.Point(159, 121);
            this.lbTotalDeCompra.Name = "lbTotalDeCompra";
            this.lbTotalDeCompra.Size = new System.Drawing.Size(38, 17);
            this.lbTotalDeCompra.TabIndex = 17;
            this.lbTotalDeCompra.Text = "-----";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Total de la compra:";
            // 
            // TotalDeVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 320);
            this.Controls.Add(this.lbTotalDeCompra);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbUstedSrOSra);
            this.Controls.Add(this.lbLoAtendio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbAtencion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TotalDeVenta";
            this.Text = "TotalDeVenta";
            this.Load += new System.EventHandler(this.TotalDeVenta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbAtencion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbUstedSrOSra;
        private System.Windows.Forms.Label lbLoAtendio;
        private System.Windows.Forms.Label lbTotalDeCompra;
        private System.Windows.Forms.Label label1;
    }
}