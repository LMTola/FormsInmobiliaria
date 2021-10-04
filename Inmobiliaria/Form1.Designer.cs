
namespace Inmobiliaria
{
    partial class CalcularInmueble
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
            this.gpTipoInmueble = new System.Windows.Forms.GroupBox();
            this.lblNroVentanas = new System.Windows.Forms.Label();
            this.lblNroPiso = new System.Windows.Forms.Label();
            this.textNroVentanas = new System.Windows.Forms.TextBox();
            this.textNroPiso = new System.Windows.Forms.TextBox();
            this.rdLocal = new System.Windows.Forms.RadioButton();
            this.rdPiso = new System.Windows.Forms.RadioButton();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtSuperficie = new System.Windows.Forms.TextBox();
            this.txtAntiguedad = new System.Windows.Forms.TextBox();
            this.txtPrecioBase = new System.Windows.Forms.TextBox();
            this.lblSuperficie = new System.Windows.Forms.Label();
            this.lblAntiguedad = new System.Windows.Forms.Label();
            this.lblPrecioBase = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gpTipoInmueble.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpTipoInmueble
            // 
            this.gpTipoInmueble.Controls.Add(this.lblNroVentanas);
            this.gpTipoInmueble.Controls.Add(this.lblNroPiso);
            this.gpTipoInmueble.Controls.Add(this.textNroVentanas);
            this.gpTipoInmueble.Controls.Add(this.textNroPiso);
            this.gpTipoInmueble.Controls.Add(this.rdLocal);
            this.gpTipoInmueble.Controls.Add(this.rdPiso);
            this.gpTipoInmueble.Location = new System.Drawing.Point(12, 12);
            this.gpTipoInmueble.Name = "gpTipoInmueble";
            this.gpTipoInmueble.Size = new System.Drawing.Size(314, 147);
            this.gpTipoInmueble.TabIndex = 0;
            this.gpTipoInmueble.TabStop = false;
            this.gpTipoInmueble.Text = "Tipo de Inmueble";
            this.gpTipoInmueble.Enter += new System.EventHandler(this.gpTipoInmueble_Enter);
            // 
            // lblNroVentanas
            // 
            this.lblNroVentanas.AutoSize = true;
            this.lblNroVentanas.Location = new System.Drawing.Point(205, 77);
            this.lblNroVentanas.Name = "lblNroVentanas";
            this.lblNroVentanas.Size = new System.Drawing.Size(89, 13);
            this.lblNroVentanas.TabIndex = 5;
            this.lblNroVentanas.Text = "Nro De Ventanas";
            // 
            // lblNroPiso
            // 
            this.lblNroPiso.AutoSize = true;
            this.lblNroPiso.Location = new System.Drawing.Point(15, 78);
            this.lblNroPiso.Name = "lblNroPiso";
            this.lblNroPiso.Size = new System.Drawing.Size(64, 13);
            this.lblNroPiso.TabIndex = 4;
            this.lblNroPiso.Text = "Nro De Piso";
            // 
            // textNroVentanas
            // 
            this.textNroVentanas.Location = new System.Drawing.Point(205, 96);
            this.textNroVentanas.Name = "textNroVentanas";
            this.textNroVentanas.Size = new System.Drawing.Size(100, 20);
            this.textNroVentanas.TabIndex = 3;
            this.textNroVentanas.TextChanged += new System.EventHandler(this.textNroVentanas_TextChanged);
            // 
            // textNroPiso
            // 
            this.textNroPiso.Location = new System.Drawing.Point(15, 97);
            this.textNroPiso.Name = "textNroPiso";
            this.textNroPiso.Size = new System.Drawing.Size(100, 20);
            this.textNroPiso.TabIndex = 2;
            this.textNroPiso.TextChanged += new System.EventHandler(this.textNroPiso_TextChanged);
            // 
            // rdLocal
            // 
            this.rdLocal.AutoSize = true;
            this.rdLocal.Location = new System.Drawing.Point(205, 37);
            this.rdLocal.Name = "rdLocal";
            this.rdLocal.Size = new System.Drawing.Size(51, 17);
            this.rdLocal.TabIndex = 1;
            this.rdLocal.TabStop = true;
            this.rdLocal.Text = "Local";
            this.rdLocal.UseVisualStyleBackColor = true;
            this.rdLocal.CheckedChanged += new System.EventHandler(this.rdLocal_CheckedChanged);
            // 
            // rdPiso
            // 
            this.rdPiso.AutoSize = true;
            this.rdPiso.Location = new System.Drawing.Point(15, 37);
            this.rdPiso.Name = "rdPiso";
            this.rdPiso.Size = new System.Drawing.Size(45, 17);
            this.rdPiso.TabIndex = 0;
            this.rdPiso.TabStop = true;
            this.rdPiso.Text = "Piso";
            this.rdPiso.UseVisualStyleBackColor = true;
            this.rdPiso.CheckedChanged += new System.EventHandler(this.rdPiso_CheckedChanged);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(27, 226);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(279, 20);
            this.txtDireccion.TabIndex = 1;
            this.txtDireccion.TextChanged += new System.EventHandler(this.txtDireccion_TextChanged);
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(27, 207);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(52, 13);
            this.lblDireccion.TabIndex = 2;
            this.lblDireccion.Text = "Direccion";
            // 
            // txtSuperficie
            // 
            this.txtSuperficie.Location = new System.Drawing.Point(27, 304);
            this.txtSuperficie.Name = "txtSuperficie";
            this.txtSuperficie.Size = new System.Drawing.Size(64, 20);
            this.txtSuperficie.TabIndex = 3;
            this.txtSuperficie.TextChanged += new System.EventHandler(this.txtSuperficie_TextChanged);
            // 
            // txtAntiguedad
            // 
            this.txtAntiguedad.Location = new System.Drawing.Point(126, 303);
            this.txtAntiguedad.Name = "txtAntiguedad";
            this.txtAntiguedad.Size = new System.Drawing.Size(72, 20);
            this.txtAntiguedad.TabIndex = 4;
            this.txtAntiguedad.TextChanged += new System.EventHandler(this.txtAntiguedad_TextChanged);
            // 
            // txtPrecioBase
            // 
            this.txtPrecioBase.Location = new System.Drawing.Point(237, 303);
            this.txtPrecioBase.Name = "txtPrecioBase";
            this.txtPrecioBase.Size = new System.Drawing.Size(69, 20);
            this.txtPrecioBase.TabIndex = 5;
            this.txtPrecioBase.TextChanged += new System.EventHandler(this.txtPrecioBase_TextChanged);
            // 
            // lblSuperficie
            // 
            this.lblSuperficie.AutoSize = true;
            this.lblSuperficie.Location = new System.Drawing.Point(27, 285);
            this.lblSuperficie.Name = "lblSuperficie";
            this.lblSuperficie.Size = new System.Drawing.Size(54, 13);
            this.lblSuperficie.TabIndex = 6;
            this.lblSuperficie.Text = "Superficie";
            // 
            // lblAntiguedad
            // 
            this.lblAntiguedad.AutoSize = true;
            this.lblAntiguedad.Location = new System.Drawing.Point(126, 284);
            this.lblAntiguedad.Name = "lblAntiguedad";
            this.lblAntiguedad.Size = new System.Drawing.Size(61, 13);
            this.lblAntiguedad.TabIndex = 7;
            this.lblAntiguedad.Text = "Antiguedad";
            // 
            // lblPrecioBase
            // 
            this.lblPrecioBase.AutoSize = true;
            this.lblPrecioBase.Location = new System.Drawing.Point(237, 283);
            this.lblPrecioBase.Name = "lblPrecioBase";
            this.lblPrecioBase.Size = new System.Drawing.Size(64, 13);
            this.lblPrecioBase.TabIndex = 8;
            this.lblPrecioBase.Text = "Precio Base";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(94, 349);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(136, 23);
            this.btnCalcular.TabIndex = 9;
            this.btnCalcular.Text = "Calcular Precio Final";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 384);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // CalcularInmueble
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 415);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblPrecioBase);
            this.Controls.Add(this.lblAntiguedad);
            this.Controls.Add(this.lblSuperficie);
            this.Controls.Add(this.txtPrecioBase);
            this.Controls.Add(this.txtAntiguedad);
            this.Controls.Add(this.txtSuperficie);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.gpTipoInmueble);
            this.Name = "CalcularInmueble";
            this.Text = "Calcular Precio Inmueble";
            this.Load += new System.EventHandler(this.CalcularInmueble_Load);
            this.gpTipoInmueble.ResumeLayout(false);
            this.gpTipoInmueble.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpTipoInmueble;
        private System.Windows.Forms.Label lblNroVentanas;
        private System.Windows.Forms.Label lblNroPiso;
        private System.Windows.Forms.TextBox textNroVentanas;
        private System.Windows.Forms.TextBox textNroPiso;
        private System.Windows.Forms.RadioButton rdLocal;
        private System.Windows.Forms.RadioButton rdPiso;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox txtSuperficie;
        private System.Windows.Forms.TextBox txtAntiguedad;
        private System.Windows.Forms.TextBox txtPrecioBase;
        private System.Windows.Forms.Label lblSuperficie;
        private System.Windows.Forms.Label lblAntiguedad;
        private System.Windows.Forms.Label lblPrecioBase;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label label1;
    }
}

