namespace TiendaTecnologia
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
            this.textId = new System.Windows.Forms.TextBox();
            this.textDescripcion = new System.Windows.Forms.TextBox();
            this.textCantidad = new System.Windows.Forms.TextBox();
            this.textPrecioCompra = new System.Windows.Forms.TextBox();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboCategoria = new System.Windows.Forms.ComboBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.rtbInventario = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textFiltroCategoria = new System.Windows.Forms.TextBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.rtbFiltro = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // textId
            // 
            this.textId.Location = new System.Drawing.Point(175, 26);
            this.textId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textId.Name = "textId";
            this.textId.Size = new System.Drawing.Size(155, 26);
            this.textId.TabIndex = 0;
            // 
            // textDescripcion
            // 
            this.textDescripcion.Location = new System.Drawing.Point(175, 112);
            this.textDescripcion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textDescripcion.Name = "textDescripcion";
            this.textDescripcion.Size = new System.Drawing.Size(284, 26);
            this.textDescripcion.TabIndex = 1;
            // 
            // textCantidad
            // 
            this.textCantidad.Location = new System.Drawing.Point(175, 206);
            this.textCantidad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textCantidad.Name = "textCantidad";
            this.textCantidad.Size = new System.Drawing.Size(155, 26);
            this.textCantidad.TabIndex = 2;
            // 
            // textPrecioCompra
            // 
            this.textPrecioCompra.Location = new System.Drawing.Point(175, 257);
            this.textPrecioCompra.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textPrecioCompra.Name = "textPrecioCompra";
            this.textPrecioCompra.Size = new System.Drawing.Size(155, 26);
            this.textPrecioCompra.TabIndex = 4;
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(175, 62);
            this.textNombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(284, 26);
            this.textNombre.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Location = new System.Drawing.Point(25, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 22);
            this.label1.TabIndex = 7;
            this.label1.Text = "idProducto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label2.Location = new System.Drawing.Point(12, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 22);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nombre producto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label3.Location = new System.Drawing.Point(18, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 22);
            this.label3.TabIndex = 9;
            this.label3.Text = "Descripción";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label4.Location = new System.Drawing.Point(25, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 22);
            this.label4.TabIndex = 10;
            this.label4.Text = "Categoria";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label5.Location = new System.Drawing.Point(25, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 22);
            this.label5.TabIndex = 11;
            this.label5.Text = "Cantidad";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label6.Location = new System.Drawing.Point(10, 257);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 22);
            this.label6.TabIndex = 12;
            this.label6.Text = "PrecioCompra";
            // 
            // comboCategoria
            // 
            this.comboCategoria.FormattingEnabled = true;
            this.comboCategoria.Items.AddRange(new object[] {
            "Disp.Almacenamiento",
            "Disp.Entrada",
            "Disp.Salida",
            "Disp.Redes"});
            this.comboCategoria.Location = new System.Drawing.Point(175, 161);
            this.comboCategoria.Name = "comboCategoria";
            this.comboCategoria.Size = new System.Drawing.Size(284, 28);
            this.comboCategoria.TabIndex = 13;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(722, 20);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(126, 28);
            this.btnRegistrar.TabIndex = 14;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click_1);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(722, 155);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(126, 28);
            this.btnEliminar.TabIndex = 15;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Enabled = false;
            this.btnGuardar.Location = new System.Drawing.Point(722, 109);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(126, 28);
            this.btnGuardar.TabIndex = 16;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(722, 62);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(126, 28);
            this.btnBuscar.TabIndex = 17;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // rtbInventario
            // 
            this.rtbInventario.Location = new System.Drawing.Point(25, 296);
            this.rtbInventario.Name = "rtbInventario";
            this.rtbInventario.Size = new System.Drawing.Size(849, 128);
            this.rtbInventario.TabIndex = 18;
            this.rtbInventario.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label7.Location = new System.Drawing.Point(18, 439);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 22);
            this.label7.TabIndex = 20;
            this.label7.Text = "Filtro por";
            // 
            // textFiltroCategoria
            // 
            this.textFiltroCategoria.Location = new System.Drawing.Point(102, 439);
            this.textFiltroCategoria.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textFiltroCategoria.Name = "textFiltroCategoria";
            this.textFiltroCategoria.Size = new System.Drawing.Size(357, 26);
            this.textFiltroCategoria.TabIndex = 19;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(707, 438);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(126, 28);
            this.btnFiltrar.TabIndex = 21;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // rtbFiltro
            // 
            this.rtbFiltro.Location = new System.Drawing.Point(25, 473);
            this.rtbFiltro.Name = "rtbFiltro";
            this.rtbFiltro.Size = new System.Drawing.Size(849, 128);
            this.rtbFiltro.TabIndex = 22;
            this.rtbFiltro.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(910, 621);
            this.Controls.Add(this.rtbFiltro);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textFiltroCategoria);
            this.Controls.Add(this.rtbInventario);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.comboCategoria);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.textPrecioCompra);
            this.Controls.Add(this.textCantidad);
            this.Controls.Add(this.textDescripcion);
            this.Controls.Add(this.textId);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textId;
        private System.Windows.Forms.TextBox textDescripcion;
        private System.Windows.Forms.TextBox textCantidad;
        private System.Windows.Forms.TextBox textPrecioCompra;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboCategoria;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.RichTextBox rtbInventario;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textFiltroCategoria;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.RichTextBox rtbFiltro;
    }
}

