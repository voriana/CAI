
namespace ClienteCapaPresentacion
{
    partial class FrmListarClientes
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
            this._lstClientes = new System.Windows.Forms.ListBox();
            this._btnRefrescarLista = new System.Windows.Forms.Button();
            this._btnAgregarCliente = new System.Windows.Forms.Button();
            this._btnModificarCliente = new System.Windows.Forms.Button();
            this._btnEliminarCliente = new System.Windows.Forms.Button();
            this._btnVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _lstClientes
            // 
            this._lstClientes.FormattingEnabled = true;
            this._lstClientes.Location = new System.Drawing.Point(74, 97);
            this._lstClientes.Name = "_lstClientes";
            this._lstClientes.Size = new System.Drawing.Size(261, 147);
            this._lstClientes.TabIndex = 0;
            // 
            // _btnRefrescarLista
            // 
            this._btnRefrescarLista.Location = new System.Drawing.Point(74, 273);
            this._btnRefrescarLista.Name = "_btnRefrescarLista";
            this._btnRefrescarLista.Size = new System.Drawing.Size(116, 23);
            this._btnRefrescarLista.TabIndex = 1;
            this._btnRefrescarLista.Text = "Refrescar";
            this._btnRefrescarLista.UseVisualStyleBackColor = true;
            this._btnRefrescarLista.Click += new System.EventHandler(this._btnRefrescarLista_Click);
            // 
            // _btnAgregarCliente
            // 
            this._btnAgregarCliente.Location = new System.Drawing.Point(372, 65);
            this._btnAgregarCliente.Name = "_btnAgregarCliente";
            this._btnAgregarCliente.Size = new System.Drawing.Size(126, 23);
            this._btnAgregarCliente.TabIndex = 2;
            this._btnAgregarCliente.Text = "Agregar Cliente";
            this._btnAgregarCliente.UseVisualStyleBackColor = true;
            this._btnAgregarCliente.Click += new System.EventHandler(this._btnAgregarCliente_Click);
            // 
            // _btnModificarCliente
            // 
            this._btnModificarCliente.Location = new System.Drawing.Point(372, 137);
            this._btnModificarCliente.Name = "_btnModificarCliente";
            this._btnModificarCliente.Size = new System.Drawing.Size(126, 23);
            this._btnModificarCliente.TabIndex = 3;
            this._btnModificarCliente.Text = "Modificar Cliente";
            this._btnModificarCliente.UseVisualStyleBackColor = true;
            // 
            // _btnEliminarCliente
            // 
            this._btnEliminarCliente.Location = new System.Drawing.Point(372, 221);
            this._btnEliminarCliente.Name = "_btnEliminarCliente";
            this._btnEliminarCliente.Size = new System.Drawing.Size(126, 23);
            this._btnEliminarCliente.TabIndex = 4;
            this._btnEliminarCliente.Text = "Eliminar Cliente";
            this._btnEliminarCliente.UseVisualStyleBackColor = true;
            // 
            // _btnVolver
            // 
            this._btnVolver.Location = new System.Drawing.Point(261, 273);
            this._btnVolver.Name = "_btnVolver";
            this._btnVolver.Size = new System.Drawing.Size(116, 23);
            this._btnVolver.TabIndex = 5;
            this._btnVolver.Text = "Volver";
            this._btnVolver.UseVisualStyleBackColor = true;
            this._btnVolver.Click += new System.EventHandler(this._btnVolver_Click);
            // 
            // FrmListarClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this._btnVolver);
            this.Controls.Add(this._btnEliminarCliente);
            this.Controls.Add(this._btnModificarCliente);
            this.Controls.Add(this._btnAgregarCliente);
            this.Controls.Add(this._btnRefrescarLista);
            this.Controls.Add(this._lstClientes);
            this.Name = "FrmListarClientes";
            this.Text = "Listar Clientes";
            this.Load += new System.EventHandler(this.FrmListarClientes_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox _lstClientes;
        private System.Windows.Forms.Button _btnRefrescarLista;
        private System.Windows.Forms.Button _btnAgregarCliente;
        private System.Windows.Forms.Button _btnModificarCliente;
        private System.Windows.Forms.Button _btnEliminarCliente;
        private System.Windows.Forms.Button _btnVolver;
    }
}