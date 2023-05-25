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
	public partial class CambiarTiempo : Form
	{
		public CambiarTiempo()
		{
			InitializeComponent();
		}
		public int temperatura { get; set; }
		public int minimo { get; set; }
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
			if(temperatura>0)
			{
				temperatura--;
				txtTemperatura.Text = temperatura.ToString();
			}
		}

		private void btnMas_Click(object sender, EventArgs e)
		{
			if(temperatura<100)
			{
				temperatura++;
				txtTemperatura.Text = temperatura.ToString(); 
			}
		}

		private void CambiarTiempo_Load(object sender, EventArgs e)
		{
			temperatura = 32;
			minimo = 20;
		}

		private void btnRegresar_Click_1(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.No;
			this.Close();
		}

		private void btnMenos2_Click(object sender, EventArgs e)
		{
			if (temperatura > 0)
			{
				minimo--;
				txtMinimo.Text = minimo.ToString();
			}
		}

		private void btnMas2_Click(object sender, EventArgs e)
		{
			if (temperatura < 100)
			{
				minimo++;
				txtMinimo.Text = minimo.ToString();
			}
		}
	}
}
