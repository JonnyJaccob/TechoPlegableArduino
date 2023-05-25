namespace TechoPlegableArduino
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnCambiarLimite = new System.Windows.Forms.Button();
			this.btnCambiarTiempo = new System.Windows.Forms.Button();
			this.btnSalir = new System.Windows.Forms.Button();
			this.btnConectar = new System.Windows.Forms.Button();
			this.lblTemperatura = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.lblCambiarTiempo = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.lblTempReal = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBoxCalor = new System.Windows.Forms.PictureBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.txtTemperatura = new System.Windows.Forms.TextBox();
			this.btnSimular = new System.Windows.Forms.Button();
			this.btnReiniciar = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxCalor)).BeginInit();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnCambiarLimite);
			this.groupBox1.Controls.Add(this.btnCambiarTiempo);
			this.groupBox1.Controls.Add(this.btnSalir);
			this.groupBox1.Controls.Add(this.btnConectar);
			this.groupBox1.Location = new System.Drawing.Point(22, 189);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(200, 114);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Area de botones";
			// 
			// btnCambiarLimite
			// 
			this.btnCambiarLimite.Location = new System.Drawing.Point(7, 79);
			this.btnCambiarLimite.Name = "btnCambiarLimite";
			this.btnCambiarLimite.Size = new System.Drawing.Size(157, 23);
			this.btnCambiarLimite.TabIndex = 3;
			this.btnCambiarLimite.Text = "Cambiar Limite temp";
			this.btnCambiarLimite.UseVisualStyleBackColor = true;
			this.btnCambiarLimite.Click += new System.EventHandler(this.btnCambiarLimite_Click);
			// 
			// btnCambiarTiempo
			// 
			this.btnCambiarTiempo.Location = new System.Drawing.Point(7, 50);
			this.btnCambiarTiempo.Name = "btnCambiarTiempo";
			this.btnCambiarTiempo.Size = new System.Drawing.Size(157, 23);
			this.btnCambiarTiempo.TabIndex = 2;
			this.btnCambiarTiempo.Text = "Cambiar Tiempo resp";
			this.btnCambiarTiempo.UseVisualStyleBackColor = true;
			this.btnCambiarTiempo.Click += new System.EventHandler(this.btnCambiarTiempo_Click);
			// 
			// btnSalir
			// 
			this.btnSalir.Location = new System.Drawing.Point(89, 20);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(75, 23);
			this.btnSalir.TabIndex = 1;
			this.btnSalir.Text = "Salir";
			this.btnSalir.UseVisualStyleBackColor = true;
			this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
			// 
			// btnConectar
			// 
			this.btnConectar.Location = new System.Drawing.Point(7, 20);
			this.btnConectar.Name = "btnConectar";
			this.btnConectar.Size = new System.Drawing.Size(75, 23);
			this.btnConectar.TabIndex = 0;
			this.btnConectar.Text = "Conectar";
			this.btnConectar.UseVisualStyleBackColor = true;
			this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
			// 
			// lblTemperatura
			// 
			this.lblTemperatura.AutoSize = true;
			this.lblTemperatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
			this.lblTemperatura.Location = new System.Drawing.Point(450, 72);
			this.lblTemperatura.Name = "lblTemperatura";
			this.lblTemperatura.Size = new System.Drawing.Size(138, 63);
			this.lblTemperatura.TabIndex = 1;
			this.lblTemperatura.Text = "X C°";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.lblCambiarTiempo);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.lblTempReal);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Location = new System.Drawing.Point(22, 72);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(200, 111);
			this.groupBox2.TabIndex = 2;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Informacion";
			// 
			// lblCambiarTiempo
			// 
			this.lblCambiarTiempo.AutoSize = true;
			this.lblCambiarTiempo.Location = new System.Drawing.Point(69, 81);
			this.lblCambiarTiempo.Name = "lblCambiarTiempo";
			this.lblCambiarTiempo.Size = new System.Drawing.Size(65, 13);
			this.lblCambiarTiempo.TabIndex = 3;
			this.lblCambiarTiempo.Text = "5 segundos.";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(42, 60);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(95, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Se actualiza cada:";
			// 
			// lblTempReal
			// 
			this.lblTempReal.AutoSize = true;
			this.lblTempReal.Location = new System.Drawing.Point(69, 40);
			this.lblTempReal.Name = "lblTempReal";
			this.lblTempReal.Size = new System.Drawing.Size(33, 13);
			this.lblTempReal.TabIndex = 1;
			this.lblTempReal.Text = "32 C°";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(7, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(175, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "El techo se cerrara al llegar al limite:";
			// 
			// pictureBoxCalor
			// 
			this.pictureBoxCalor.Location = new System.Drawing.Point(2, 1);
			this.pictureBoxCalor.Name = "pictureBoxCalor";
			this.pictureBoxCalor.Size = new System.Drawing.Size(786, 315);
			this.pictureBoxCalor.TabIndex = 3;
			this.pictureBoxCalor.TabStop = false;
			this.pictureBoxCalor.Visible = false;
			this.pictureBoxCalor.Click += new System.EventHandler(this.pictureBoxCalor_Click);
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.btnReiniciar);
			this.groupBox3.Controls.Add(this.btnSimular);
			this.groupBox3.Controls.Add(this.txtTemperatura);
			this.groupBox3.Location = new System.Drawing.Point(22, 1);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(200, 65);
			this.groupBox3.TabIndex = 4;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Simular";
			// 
			// txtTemperatura
			// 
			this.txtTemperatura.Location = new System.Drawing.Point(41, 13);
			this.txtTemperatura.Name = "txtTemperatura";
			this.txtTemperatura.Size = new System.Drawing.Size(100, 20);
			this.txtTemperatura.TabIndex = 0;
			// 
			// btnSimular
			// 
			this.btnSimular.Location = new System.Drawing.Point(10, 36);
			this.btnSimular.Name = "btnSimular";
			this.btnSimular.Size = new System.Drawing.Size(75, 23);
			this.btnSimular.TabIndex = 1;
			this.btnSimular.Text = "Simular";
			this.btnSimular.UseVisualStyleBackColor = true;
			this.btnSimular.Click += new System.EventHandler(this.btnSimular_Click);
			// 
			// btnReiniciar
			// 
			this.btnReiniciar.Location = new System.Drawing.Point(104, 36);
			this.btnReiniciar.Name = "btnReiniciar";
			this.btnReiniciar.Size = new System.Drawing.Size(75, 23);
			this.btnReiniciar.TabIndex = 2;
			this.btnReiniciar.Text = "Reiniciar";
			this.btnReiniciar.UseVisualStyleBackColor = true;
			this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ButtonShadow;
			this.ClientSize = new System.Drawing.Size(800, 315);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.lblTemperatura);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.pictureBoxCalor);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxCalor)).EndInit();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnConectar;
		private System.Windows.Forms.Button btnSalir;
		private System.Windows.Forms.Label lblTemperatura;
		private System.Windows.Forms.Button btnCambiarLimite;
		private System.Windows.Forms.Button btnCambiarTiempo;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label lblTempReal;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblCambiarTiempo;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.PictureBox pictureBoxCalor;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Button btnReiniciar;
		private System.Windows.Forms.Button btnSimular;
		private System.Windows.Forms.TextBox txtTemperatura;
	}
}

