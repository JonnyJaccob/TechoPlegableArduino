namespace TechoPlegableArduino
{
	partial class CambiarTemperatura
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
			this.btnRegresar = new System.Windows.Forms.Button();
			this.btnCambiar = new System.Windows.Forms.Button();
			this.btnMas = new System.Windows.Forms.Button();
			this.btnMenos = new System.Windows.Forms.Button();
			this.txtTemperatura = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// btnRegresar
			// 
			this.btnRegresar.Location = new System.Drawing.Point(94, 53);
			this.btnRegresar.Name = "btnRegresar";
			this.btnRegresar.Size = new System.Drawing.Size(75, 23);
			this.btnRegresar.TabIndex = 9;
			this.btnRegresar.Text = "Regresar";
			this.btnRegresar.UseVisualStyleBackColor = true;
			this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click_2);
			// 
			// btnCambiar
			// 
			this.btnCambiar.Location = new System.Drawing.Point(12, 54);
			this.btnCambiar.Name = "btnCambiar";
			this.btnCambiar.Size = new System.Drawing.Size(75, 23);
			this.btnCambiar.TabIndex = 8;
			this.btnCambiar.Text = "Cambiar";
			this.btnCambiar.UseVisualStyleBackColor = true;
			this.btnCambiar.Click += new System.EventHandler(this.btnCambiar_Click);
			// 
			// btnMas
			// 
			this.btnMas.Location = new System.Drawing.Point(145, 13);
			this.btnMas.Name = "btnMas";
			this.btnMas.Size = new System.Drawing.Size(20, 23);
			this.btnMas.TabIndex = 7;
			this.btnMas.Text = "+";
			this.btnMas.UseVisualStyleBackColor = true;
			this.btnMas.Click += new System.EventHandler(this.btnMas_Click);
			// 
			// btnMenos
			// 
			this.btnMenos.Location = new System.Drawing.Point(12, 12);
			this.btnMenos.Name = "btnMenos";
			this.btnMenos.Size = new System.Drawing.Size(21, 23);
			this.btnMenos.TabIndex = 6;
			this.btnMenos.Text = "-";
			this.btnMenos.UseVisualStyleBackColor = true;
			this.btnMenos.Click += new System.EventHandler(this.btnMenos_Click);
			// 
			// txtTemperatura
			// 
			this.txtTemperatura.Location = new System.Drawing.Point(39, 15);
			this.txtTemperatura.Name = "txtTemperatura";
			this.txtTemperatura.ReadOnly = true;
			this.txtTemperatura.Size = new System.Drawing.Size(100, 20);
			this.txtTemperatura.TabIndex = 5;
			this.txtTemperatura.Text = "5";
			this.txtTemperatura.TextChanged += new System.EventHandler(this.txtTemperatura_TextChanged);
			// 
			// CambiarTemperatura
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(190, 87);
			this.Controls.Add(this.btnRegresar);
			this.Controls.Add(this.btnCambiar);
			this.Controls.Add(this.btnMas);
			this.Controls.Add(this.btnMenos);
			this.Controls.Add(this.txtTemperatura);
			this.Name = "CambiarTemperatura";
			this.Text = "CambiarTemperatura";
			this.Load += new System.EventHandler(this.CambiarTemperatura_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnRegresar;
		private System.Windows.Forms.Button btnCambiar;
		private System.Windows.Forms.Button btnMas;
		private System.Windows.Forms.Button btnMenos;
		private System.Windows.Forms.TextBox txtTemperatura;
	}
}