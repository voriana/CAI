
namespace ClienteCapaPresentacion
{
    partial class FrmMaster
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
            this.btnListarCliente = new System.Windows.Forms.Button();
            this._btnAltaCuenta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnListarCliente
            // 
            this.btnListarCliente.Location = new System.Drawing.Point(69, 102);
            this.btnListarCliente.Name = "btnListarCliente";
            this.btnListarCliente.Size = new System.Drawing.Size(141, 23);
            this.btnListarCliente.TabIndex = 0;
            this.btnListarCliente.Text = "Listar Clientes";
            this.btnListarCliente.UseVisualStyleBackColor = true;
            this.btnListarCliente.Click += new System.EventHandler(this.btnListarCliente_Click);
            // 
            // _btnAltaCuenta
            // 
            this._btnAltaCuenta.Location = new System.Drawing.Point(69, 162);
            this._btnAltaCuenta.Name = "_btnAltaCuenta";
            this._btnAltaCuenta.Size = new System.Drawing.Size(141, 23);
            this._btnAltaCuenta.TabIndex = 1;
            this._btnAltaCuenta.Text = "Alta cuenta";
            this._btnAltaCuenta.UseVisualStyleBackColor = true;
            // 
            // FrmMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this._btnAltaCuenta);
            this.Controls.Add(this.btnListarCliente);
            this.Name = "FrmMaster";
            this.Text = "Pantalla Principal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnListarCliente;
        private System.Windows.Forms.Button _btnAltaCuenta;
    }
}

