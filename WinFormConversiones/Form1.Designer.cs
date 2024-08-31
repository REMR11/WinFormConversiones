namespace WinFormConversiones
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtTemperaturaBase = new System.Windows.Forms.TextBox();
            this.rbtnCelsiusAKelvin = new System.Windows.Forms.RadioButton();
            this.rbtnCelsiusAFahrenheit = new System.Windows.Forms.RadioButton();
            this.rbtnFahrenheitACelsius = new System.Windows.Forms.RadioButton();
            this.btnConvertir = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.gBoxOperaciones = new System.Windows.Forms.GroupBox();
            this.gBoxOperaciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(30, 21);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(336, 31);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Proporciona temperatura";
            // 
            // txtTemperaturaBase
            // 
            this.txtTemperaturaBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTemperaturaBase.Location = new System.Drawing.Point(424, 21);
            this.txtTemperaturaBase.Name = "txtTemperaturaBase";
            this.txtTemperaturaBase.Size = new System.Drawing.Size(184, 38);
            this.txtTemperaturaBase.TabIndex = 1;
            this.txtTemperaturaBase.Text = "0.0";
            this.txtTemperaturaBase.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTemperaturaBase.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTemperaturaBase_KeyPress);
            // 
            // rbtnCelsiusAKelvin
            // 
            this.rbtnCelsiusAKelvin.AutoSize = true;
            this.rbtnCelsiusAKelvin.Checked = true;
            this.rbtnCelsiusAKelvin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnCelsiusAKelvin.Location = new System.Drawing.Point(6, 19);
            this.rbtnCelsiusAKelvin.Name = "rbtnCelsiusAKelvin";
            this.rbtnCelsiusAKelvin.Size = new System.Drawing.Size(170, 29);
            this.rbtnCelsiusAKelvin.TabIndex = 2;
            this.rbtnCelsiusAKelvin.TabStop = true;
            this.rbtnCelsiusAKelvin.Text = "Celsius a Kelvin";
            this.rbtnCelsiusAKelvin.UseVisualStyleBackColor = true;
            // 
            // rbtnCelsiusAFahrenheit
            // 
            this.rbtnCelsiusAFahrenheit.AutoSize = true;
            this.rbtnCelsiusAFahrenheit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnCelsiusAFahrenheit.Location = new System.Drawing.Point(6, 54);
            this.rbtnCelsiusAFahrenheit.Name = "rbtnCelsiusAFahrenheit";
            this.rbtnCelsiusAFahrenheit.Size = new System.Drawing.Size(209, 29);
            this.rbtnCelsiusAFahrenheit.TabIndex = 3;
            this.rbtnCelsiusAFahrenheit.TabStop = true;
            this.rbtnCelsiusAFahrenheit.Text = "Celsius a Fahrenheit";
            this.rbtnCelsiusAFahrenheit.UseVisualStyleBackColor = true;
            // 
            // rbtnFahrenheitACelsius
            // 
            this.rbtnFahrenheitACelsius.AutoSize = true;
            this.rbtnFahrenheitACelsius.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnFahrenheitACelsius.Location = new System.Drawing.Point(6, 89);
            this.rbtnFahrenheitACelsius.Name = "rbtnFahrenheitACelsius";
            this.rbtnFahrenheitACelsius.Size = new System.Drawing.Size(209, 29);
            this.rbtnFahrenheitACelsius.TabIndex = 4;
            this.rbtnFahrenheitACelsius.TabStop = true;
            this.rbtnFahrenheitACelsius.Text = "Fahrenheit a Celsius";
            this.rbtnFahrenheitACelsius.UseVisualStyleBackColor = true;
            // 
            // btnConvertir
            // 
            this.btnConvertir.BackColor = System.Drawing.Color.GreenYellow;
            this.btnConvertir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConvertir.FlatAppearance.BorderSize = 0;
            this.btnConvertir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvertir.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnConvertir.Location = new System.Drawing.Point(494, 159);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(114, 38);
            this.btnConvertir.TabIndex = 5;
            this.btnConvertir.Text = "Convertir";
            this.btnConvertir.UseVisualStyleBackColor = false;
            this.btnConvertir.Click += new System.EventHandler(this.btnConvertir_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FloralWhite;
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(362, 159);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(114, 38);
            this.btnLimpiar.TabIndex = 6;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblResult.Location = new System.Drawing.Point(488, 89);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(55, 31);
            this.lblResult.TabIndex = 1;
            this.lblResult.Text = "0.0";
            // 
            // gBoxOperaciones
            // 
            this.gBoxOperaciones.Controls.Add(this.rbtnCelsiusAKelvin);
            this.gBoxOperaciones.Controls.Add(this.rbtnCelsiusAFahrenheit);
            this.gBoxOperaciones.Controls.Add(this.rbtnFahrenheitACelsius);
            this.gBoxOperaciones.Location = new System.Drawing.Point(36, 70);
            this.gBoxOperaciones.Name = "gBoxOperaciones";
            this.gBoxOperaciones.Size = new System.Drawing.Size(236, 127);
            this.gBoxOperaciones.TabIndex = 7;
            this.gBoxOperaciones.TabStop = false;
            this.gBoxOperaciones.Text = "Operaciones";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 213);
            this.Controls.Add(this.gBoxOperaciones);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnConvertir);
            this.Controls.Add(this.txtTemperaturaBase);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblTitle);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conversor de temperaturas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gBoxOperaciones.ResumeLayout(false);
            this.gBoxOperaciones.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtTemperaturaBase;
        private System.Windows.Forms.RadioButton rbtnCelsiusAKelvin;
        private System.Windows.Forms.RadioButton rbtnCelsiusAFahrenheit;
        private System.Windows.Forms.RadioButton rbtnFahrenheitACelsius;
        private System.Windows.Forms.Button btnConvertir;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.GroupBox gBoxOperaciones;
    }
}

