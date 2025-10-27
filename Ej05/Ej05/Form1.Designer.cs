namespace Ej05
{
    partial class Form1
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
            this.lblCliente = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnAtender = new System.Windows.Forms.Button();
            this.lstCola = new System.Windows.Forms.ListBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(303, 35);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(140, 20);
            this.lblCliente.TabIndex = 0;
            this.lblCliente.Text = "Nombre del cliente";
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(298, 64);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(147, 26);
            this.txtCliente.TabIndex = 1;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(161, 107);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(167, 30);
            this.btnRegistrar.TabIndex = 2;
            this.btnRegistrar.Text = "Registrar cliente";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(397, 107);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(163, 30);
            this.btnMostrar.TabIndex = 3;
            this.btnMostrar.Text = "Mostrar cola";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // btnAtender
            // 
            this.btnAtender.Location = new System.Drawing.Point(298, 157);
            this.btnAtender.Name = "btnAtender";
            this.btnAtender.Size = new System.Drawing.Size(147, 41);
            this.btnAtender.TabIndex = 4;
            this.btnAtender.Text = "Atender cliente";
            this.btnAtender.UseVisualStyleBackColor = true;
            this.btnAtender.Click += new System.EventHandler(this.btnAtender_Click);
            // 
            // lstCola
            // 
            this.lstCola.FormattingEnabled = true;
            this.lstCola.ItemHeight = 20;
            this.lstCola.Location = new System.Drawing.Point(161, 222);
            this.lstCola.Name = "lstCola";
            this.lstCola.Size = new System.Drawing.Size(399, 184);
            this.lstCola.TabIndex = 5;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblEstado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEstado.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblEstado.Location = new System.Drawing.Point(298, 423);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(2, 22);
            this.lblEstado.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lstCola);
            this.Controls.Add(this.btnAtender);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.lblCliente);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnAtender;
        private System.Windows.Forms.ListBox lstCola;
        private System.Windows.Forms.Label lblEstado;
    }
}

