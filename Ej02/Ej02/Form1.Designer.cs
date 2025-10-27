namespace Ej02
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
            this.lblPalabra = new System.Windows.Forms.Label();
            this.txtPalabra = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lstPila = new System.Windows.Forms.ListBox();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPalabra
            // 
            this.lblPalabra.AutoSize = true;
            this.lblPalabra.Location = new System.Drawing.Point(295, 29);
            this.lblPalabra.Name = "lblPalabra";
            this.lblPalabra.Size = new System.Drawing.Size(227, 30);
            this.lblPalabra.TabIndex = 0;
            this.lblPalabra.Text = "Ingrese una palabra";
            // 
            // txtPalabra
            // 
            this.txtPalabra.Location = new System.Drawing.Point(290, 53);
            this.txtPalabra.Name = "txtPalabra";
            this.txtPalabra.Size = new System.Drawing.Size(159, 26);
            this.txtPalabra.TabIndex = 1;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(196, 85);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(151, 36);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar palabra";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(386, 85);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(157, 36);
            this.btnMostrar.TabIndex = 3;
            this.btnMostrar.Text = "Mostrar pila";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(299, 137);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(150, 42);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar palabra";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lstPila
            // 
            this.lstPila.FormattingEnabled = true;
            this.lstPila.ItemHeight = 20;
            this.lstPila.Location = new System.Drawing.Point(196, 195);
            this.lstPila.Name = "lstPila";
            this.lstPila.Size = new System.Drawing.Size(347, 144);
            this.lstPila.TabIndex = 5;
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblMensaje.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMensaje.Location = new System.Drawing.Point(192, 366);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(3, 33);
            this.lblMensaje.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.lstPila);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtPalabra);
            this.Controls.Add(this.lblPalabra);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPalabra;
        private System.Windows.Forms.TextBox txtPalabra;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.ListBox lstPila;
        private System.Windows.Forms.Label lblMensaje;
    }
}

