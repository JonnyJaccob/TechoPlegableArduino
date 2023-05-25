using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Runtime.InteropServices;
using System.Drawing.Text;
using Timer = System.Timers.Timer;
using System.Timers;
using System.IO;
using System.Threading;

namespace TechoPlegableArduino
{
	public partial class Form1 : Form
	{

		[DllImport("gdi32.dll")]
		//Funcion de la DLL externa
		private static extern IntPtr AddFontMemResourceEx(IntPtr pFileView, uint cjSize, IntPtr pvResrved, [In] ref uint pNumFonts);
		public Form1()
		{
			InitializeComponent();
		}
		private int temperatura = 0;
		private int segundos = 5; // Variable que almacena los segundos
		private int limite = 32;
		private int limMin = 20;
		bool IsPrueba = false;
		static string rutaBase = Application.StartupPath;
		//private static string imagenNormal = Path.Combine(rutaBase, "SemaforoApag1_2.png");

		SerialPort serialPort1;
		private void Form1_Load(object sender, EventArgs e)
		{
			serialPort1 = new SerialPort("COM3", 9600); // Reemplaza "COM3" con el puerto COM correcto
			//Cargar fuente personalizada
			Font fuente_DS_DIGIT = new Font(CargarFuente(Properties.Resources.DS_DIGIT), 40, FontStyle.Regular);

			lblTemperatura.Font = fuente_DS_DIGIT;


		}
		private FontFamily CargarFuente(byte[] fuente)
		{
			FontFamily fuenteNueva;

			//Asignar memoria y copiar bytes
			IntPtr data = Marshal.AllocCoTaskMem(fuente.Length);
			Marshal.Copy(fuente, 0, data, fuente.Length);

			uint cFonts = 0;
			AddFontMemResourceEx(data, (uint)fuente.Length, IntPtr.Zero, ref cFonts);

			PrivateFontCollection fontCollection = new PrivateFontCollection();

			//Pasar fuente a PrivateFontCollection
			fontCollection.AddMemoryFont(data, fuente.Length);

			//Liberar memoria
			Marshal.FreeCoTaskMem(data);

			fuenteNueva = fontCollection.Families[0];

			return fuenteNueva;
		}
		Timer timer;
		private void btnConectar_Click(object sender, EventArgs e)
		{
			string puerto = "COM3"; // Puerto COM que deseas utilizar

			if (!IsPrueba)
			{
				if (!serialPort1.IsOpen)
				{
					string[] puertosDisponibles = SerialPort.GetPortNames();
					bool puertoExiste = puertosDisponibles.Contains(puerto);

					if (puertoExiste)
					{
						// El puerto COM existe, puedes proceder con la conexión
						serialPort1.PortName = puerto;
						serialPort1.BaudRate = 9600;
						serialPort1.Open();
						btnConectar.Text = "Desconectar";

						// Inicializar y comenzar el temporizador
						timer = new Timer();
						timer.Interval = ConvertSecondsToMilliseconds(segundos); // Convertir segundos a milisegundos
						timer.Elapsed += Timer_Elapsed;
						timer.Start();
					}
					else
					{
						// El puerto COM no existe, muestra un mensaje de error o realiza alguna acción
						MessageBox.Show("El puerto " + puerto + " no está disponible");
					}
				}
				else
				{
					serialPort1.Close();
					btnConectar.Text = "Conectar";

					// Detener y eliminar el temporizador
					if (timer != null)
					{
						timer.Stop();
						timer.Dispose();
					}
				}
			}
		}

		private void btnSalir_Click(object sender, EventArgs e)
		{

			if (serialPort1 != null && serialPort1.IsOpen)
			{
				serialPort1.Close();
			}

			Application.Exit();
		}
		private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
		{
			// Leer los datos desde el puerto serial
			string data = serialPort1.ReadLine();
			// Procesar los datos recibidos aquí
			// Puedes analizar la cadena `data` para obtener la temperatura
			// y luego actualizar el valor en el Label utilizando el método ActualizarValor
			ActualizarValor(data);

			if(temperatura <= limite)
			{
				
			}
			else
			{
				// Mostrar la animación de calor
				MostrarAnimacionCalor();
			}
		}
		private void MostrarAnimacionCalor()
		{
			// Mostrar el PictureBox
			pictureBoxCalor.Invoke(new Action(() => pictureBoxCalor.Visible = true));
			
		}
		
		private void ActualizarValor(string valor)
		{
			// Actualiza el valor en la interfaz de usuario
			// Asigna el valor al Text del Label
			lblTemperatura.Invoke(new Action(() => lblTemperatura.Text = valor + " C °"));
			try
			{
				temperatura = int.Parse(valor);
			}
			catch (Exception ex)
			{
				MessageBox.Show("error:" + ex.Message);
			}
		}

		private int ConvertSecondsToMilliseconds(int seconds)
		{
			return seconds * 1000; // 1000 milisegundos en 1 segundo
		}
		private void ActualizarValor(int valor)
		{
			// Actualiza el valor en la interfaz de usuario
			// Asigna el valor al Text del Label
			lblTemperatura.Invoke(new Action(() => lblTemperatura.Text = valor + " C °"));

		}

		private void btnCambiarTiempo_Click(object sender, EventArgs e)
		{
			using (var formularioSecundario = new CambiarTemperatura())
			{
				if (formularioSecundario.ShowDialog() == DialogResult.Yes)
				{
					segundos = formularioSecundario.Tiempo;
					lblCambiarTiempo.Text = segundos + " segundos.";
				}
			}
		}

		private void btnCambiarLimite_Click(object sender, EventArgs e)
		{
			using (var formularioSecundario = new CambiarTiempo())
			{
				if (formularioSecundario.ShowDialog() == DialogResult.Yes)
				{
					limite = formularioSecundario.temperatura;
					limMin = formularioSecundario.minimo;
					lblTempReal.Text = limite + " C°";
				}
				
			}
			// Verificar si el puerto serie está abierto y conectado al Arduino
			if (serialPort1.IsOpen && VerificarConexionArduino())
			{
				// Enviar los nuevos valores de umbrales al Arduino
				EnviarComando($"U{limite},{limMin}");
			}
			else
			{
				MessageBox.Show("El Arduino no está conectado por lo que los valores de temperatura minimo y maximo no fueron actualizados en el arduino, pulsa reiniciar para regresar a los valores predeterminados.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}
		private bool VerificarConexionArduino()
		{
			// Envía un comando al Arduino y verifica si recibe una respuesta válida
			// Puedes enviar un comando simple como 'V' y esperar una respuesta del Arduino

			// Envía el comando 'V'
			EnviarComando("V");

			// Espera un tiempo breve para recibir la respuesta del Arduino
			// Puedes ajustar el tiempo según tus necesidades
			Thread.Sleep(100);

			// Lee los datos recibidos del puerto serie
			string respuesta = serialPort1.ReadExisting();

			// Verifica si la respuesta es válida
			// Aquí debes definir qué se considera una respuesta válida según tu implementación
			// Puede ser un mensaje específico o un valor específico

			// Por ejemplo, si el Arduino responde con "OK", se considera una conexión exitosa
			return respuesta.Contains("OK");
		}
		private void EnviarComando(string comando)
		{
			if (serialPort1.IsOpen)
			{
				serialPort1.WriteLine(comando);
			}
		}
		private void btnSimular_Click(object sender, EventArgs e)
		{

			if (serialPort1 != null && serialPort1.IsOpen)
			{
				serialPort1.Close();
			}
			if (int.TryParse(txtTemperatura.Text, out int numero))
			{
				// El valor del TextBox es un número válido
				// Puedes almacenar el número en una variable o realizar cualquier otra acción
				// Por ejemplo:
				temperatura = numero;
				ActualizarValor(temperatura);
				IsPrueba = true;
				if (temperatura <= limite)
				{
					
				}
				else
				{
					// Mostrar la animación de calor
					MostrarAnimacionCalor();
				}
			}
		}

		private void btnReiniciar_Click(object sender, EventArgs e)
		{
			IsPrueba = false;
			limite = 32;
			limMin = 20;
		}

		private void pictureBoxCalor_Click(object sender, EventArgs e)
		{

		}
	}
}
