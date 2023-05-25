using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TechoPlegableArduino
{
	public partial class CambiarTemperatura : Form
	{
		public CambiarTemperatura()
		{
			InitializeComponent();
		}

		private void txtTemperatura_TextChanged(object sender, EventArgs e)
		{

		}
		public int Tiempo { get; set; }
		private void btnCambiar_Click(object sender, EventArgs e)
		{

			this.DialogResult = DialogResult.Yes;
			this.Close();
		}

		private void btnRegresar_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.No;
			this.Close();
		}

		private void btnMenos_Click(object sender, EventArgs e)
		{
			if (Tiempo > 0)
			{
				Tiempo--;
				txtTemperatura.Text = Tiempo.ToString();
			}
		}

		private void btnMas_Click(object sender, EventArgs e)
		{
			if (Tiempo < 100)
			{
				Tiempo++;
				txtTemperatura.Text = Tiempo.ToString();
			}
		}

		private void CambiarTiempo_Load(object sender, EventArgs e)
		{
			Tiempo = 5;
		}

		private void btnRegresar_Click_1(object sender, EventArgs e)
		{
			
		}

		private void btnRegresar_Click_2(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.No;
				this.Close();
		}

		private void CambiarTemperatura_Load(object sender, EventArgs e)
		{
			Tiempo = 5;
		}
	}
}
