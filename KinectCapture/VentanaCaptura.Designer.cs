
namespace KinectCapture
{
    partial class VentanaCaptura
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
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblIdConexion = new System.Windows.Forms.Label();
            this.btnCaptura = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pbCaptura = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbCaptura)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(100, 9);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(10, 13);
            this.lblEstado.TabIndex = 0;
            this.lblEstado.Text = "-";
            // 
            // lblIdConexion
            // 
            this.lblIdConexion.AutoSize = true;
            this.lblIdConexion.Location = new System.Drawing.Point(100, 35);
            this.lblIdConexion.Name = "lblIdConexion";
            this.lblIdConexion.Size = new System.Drawing.Size(10, 13);
            this.lblIdConexion.TabIndex = 1;
            this.lblIdConexion.Text = "-";
            // 
            // btnCaptura
            // 
            this.btnCaptura.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCaptura.Location = new System.Drawing.Point(514, 714);
            this.btnCaptura.Name = "btnCaptura";
            this.btnCaptura.Size = new System.Drawing.Size(118, 23);
            this.btnCaptura.TabIndex = 2;
            this.btnCaptura.Text = "Iniciar captura";
            this.btnCaptura.UseVisualStyleBackColor = true;
            this.btnCaptura.Click += new System.EventHandler(this.btnCaptura_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Estado:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "ID de conexión:";
            // 
            // pbCaptura
            // 
            this.pbCaptura.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbCaptura.Location = new System.Drawing.Point(15, 73);
            this.pbCaptura.Name = "pbCaptura";
            this.pbCaptura.Size = new System.Drawing.Size(617, 626);
            this.pbCaptura.TabIndex = 5;
            this.pbCaptura.TabStop = false;
            // 
            // CaptureWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 749);
            this.Controls.Add(this.pbCaptura);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCaptura);
            this.Controls.Add(this.lblIdConexion);
            this.Controls.Add(this.lblEstado);
            this.Name = "CaptureWindow";
            this.Text = "Captura de Kinect";
            ((System.ComponentModel.ISupportInitialize)(this.pbCaptura)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblIdConexion;
        private System.Windows.Forms.Button btnCaptura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbCaptura;
    }
}

