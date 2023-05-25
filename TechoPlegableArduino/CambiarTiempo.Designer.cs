namespace TechoPlegableArduino
{
	partial class CambiarTiempo
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
			this.txtTemperatura = new System.Windows.Forms.TextBox();
			this.btnMenos = new System.Windows.Forms.Button();
			this.btnMas = new System.Windows.Forms.Button();
			this.btnCambiar = new System.Windows.Forms.Button();
			this.btnRegresar = new System.Windows.Forms.Button();
			this.btnMas2 = new System.Windows.Forms.Button();
			this.btnMenos2 = new System.Windows.Forms.Button();
			this.txtMinimo = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// txtTemperatura
			// 
			this.txtTemperatura.Location = new System.Drawing.Point(40, 19);
			this.txtTemperatura.Name = "txtTemperatura";
			this.txtTemperatura.ReadOnly = true;
			this.txtTemperatura.Size = new System.Drawing.Size(100, 20);
			this.txtTemperatura.TabIndex = 0;
			this.txtTemperatura.Text = "32";
			// 
			// btnMenos
			// 
			this.btnMenos.Location = new System.Drawing.Point(13, 17);
			this.btnMenos.Name = "btnMenos";
			this.btnMenos.Size = new System.Drawing.Size(21, 23);
			this.btnMenos.TabIndex = 1;
			this.btnMenos.Text = "-";
			this.btnMenos.UseVisualStyleBackColor = true;
			this.btnMenos.Click += new System.EventHandler(this.btnMenos_Click);
			// 
			// btnMas
			// 
			this.btnMas.Location = new System.Drawing.Point(148, 16);
			this.btnMas.Name = "btnMas";
			this.btnMas.Size = new System.Drawing.Size(20, 23);
			this.btnMas.TabIndex = 2;
			this.btnMas.Text = "+";
			this.btnMas.UseVisualStyleBackColor = true;
			this.btnMas.Click += new System.EventHandler(this.btnMas_Click);
			// 
			// btnCambiar
			// 
			this.btnCambiar.Location = new System.Drawing.Point(12, 91);
			this.btnCambiar.Name = "btnCambiar";
			this.btnCambiar.Size = new System.Drawing.Size(75, 23);
			this.btnCambiar.TabIndex = 3;
			this.btnCambiar.Text = "Cambiar";
			this.btnCambiar.UseVisualStyleBackColor = true;
			this.btnCambiar.Click += new System.EventHandler(this.btnCambiar_Click);
			// 
			// btnRegresar
			// 
			this.btnRegresar.Location = new System.Drawing.Point(93, 91);
			this.btnRegresar.Name = "btnRegresar";
			this.btnRegresar.Size = new System.Drawing.Size(75, 23);
			this.btnRegresar.TabIndex = 4;
			this.btnRegresar.Text = "Regresar";
			this.btnRegresar.UseVisualStyleBackColor = true;
			this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click_1);
			// 
			// btnMas2
			// 
			this.btnMas2.Location = new System.Drawing.Point(148, 65);
			this.btnMas2.Name = "btnMas2";
			this.btnMas2.Size = new System.Drawing.Size(20, 23);
			this.btnMas2.TabIndex = 7;
			this.btnMas2.Text = "+";
			this.btnMas2.UseVisualStyleBackColor = true;
			this.btnMas2.Click += new System.EventHandler(this.btnMas2_Click);
			// 
			// btnMenos2
			// 
			this.btnMenos2.Location = new System.Drawing.Point(14, 62);
			this.btnMenos2.Name = "btnMenos2";
			this.btnMenos2.Size = new System.Drawing.Size(21, 23);
			this.btnMenos2.TabIndex = 6;
			this.btnMenos2.Text = "-";
			this.btnMenos2.UseVisualStyleBackColor = true;
			this.btnMenos2.Click += new System.EventHandler(this.btnMenos2_Click);
			// 
			// txtMinimo
			// 
			this.txtMinimo.Location = new System.Drawing.Point(41, 65);
			this.txtMinimo.Name = "txtMinimo";
			this.txtMinimo.ReadOnly = true;
			this.txtMinimo.Size = new System.Drawing.Size(100, 20);
			this.txtMinimo.TabIndex = 5;
			this.txtMinimo.Text = "20";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(38, 3);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(43, 13);
			this.label1.TabIndex = 8;
			this.label1.Text = "Maximo";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(41, 46);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(40, 13);
			this.label2.TabIndex = 9;
			this.label2.Text = "Minimo";
			// 
			// CambiarTiempo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(180, 126);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnMas2);
			this.Controls.Add(this.btnMenos2);
			this.Controls.Add(this.txtMinimo);
			this.Controls.Add(this.btnRegresar);
			this.Controls.Add(this.btnCambiar);
			this.Controls.Add(this.btnMas);
			this.Controls.Add(this.btnMenos);
			this.Controls.Add(this.txtTemperatura);
			this.Name = "CambiarTiempo";
			this.Text = "CambiarTiempo";
			this.Load += new System.EventHandler(this.CambiarTiempo_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtTemperatura;
		private System.Windows.Forms.Button btnMenos;
		private System.Windows.Forms.Button btnMas;
		private System.Windows.Forms.Button btnCambiar;
		private System.Windows.Forms.Button btnRegresar;
		private System.Windows.Forms.Button btnMas2;
		private System.Windows.Forms.Button btnMenos2;
		private System.Windows.Forms.TextBox txtMinimo;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
	}
}