namespace VentasTutoria
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
            this.components = new System.ComponentModel.Container();
            this.butMayoresA1000 = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.butEmpleado = new System.Windows.Forms.Button();
            this.dataFactura = new System.Windows.Forms.DataGridView();
            this.btnIniciar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataFactura)).BeginInit();
            this.SuspendLayout();
            // 
            // butMayoresA1000
            // 
            this.butMayoresA1000.Location = new System.Drawing.Point(228, 99);
            this.butMayoresA1000.Name = "butMayoresA1000";
            this.butMayoresA1000.Size = new System.Drawing.Size(132, 23);
            this.butMayoresA1000.TabIndex = 0;
            this.butMayoresA1000.Text = "Factura mayores a 1000";
            this.butMayoresA1000.UseVisualStyleBackColor = true;
            this.butMayoresA1000.Click += new System.EventHandler(this.butMayoresA1000_Click);
            // 
            // butEmpleado
            // 
            this.butEmpleado.Location = new System.Drawing.Point(377, 98);
            this.butEmpleado.Name = "butEmpleado";
            this.butEmpleado.Size = new System.Drawing.Size(132, 23);
            this.butEmpleado.TabIndex = 1;
            this.butEmpleado.Text = "Factura por Juan Perez";
            this.butEmpleado.UseVisualStyleBackColor = true;
            this.butEmpleado.Click += new System.EventHandler(this.butEmpleado_Click);
            // 
            // dataFactura
            // 
            this.dataFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataFactura.Location = new System.Drawing.Point(145, 198);
            this.dataFactura.Name = "dataFactura";
            this.dataFactura.Size = new System.Drawing.Size(510, 150);
            this.dataFactura.TabIndex = 2;
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(377, 41);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(75, 23);
            this.btnIniciar.TabIndex = 3;
            this.btnIniciar.Text = "button1";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.dataFactura);
            this.Controls.Add(this.butEmpleado);
            this.Controls.Add(this.butMayoresA1000);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataFactura)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button butMayoresA1000;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button butEmpleado;
        private System.Windows.Forms.DataGridView dataFactura;
        private System.Windows.Forms.Button btnIniciar;
    }
}

