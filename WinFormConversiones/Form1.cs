using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace WinFormConversiones
{
    /// <summary>
    /// Clase principal del formulario de conversión de temperaturas.
    /// </summary>
    public partial class Form1 : Form
    {
        /// <summary>
        /// Constructor del formulario.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Evento que se lanza cuando se carga el formulario.
        /// Inicializa los valores de objetos.
        /// </summary>
        private void Form1_Load(object sender, EventArgs e)
        {
            txtTemperaturaBase.Text = "0.0";
            lblResult.Text = "0.0";
        }
        /// <summary>
        /// Evento que se lanza cuando se hace clic en el botón Convertir.
        /// Realiza la conversión de temperatura según la opción seleccionada.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertir_Click(object sender, EventArgs e)
        {
            ConversorTemperaturas conversorTemperaturas = new ConversorTemperaturas();

            conversorTemperaturas.BaseTemperature = Convert.ToDouble(txtTemperaturaBase.Text);

            if (rbtnCelsiusAFahrenheit.Checked == true)
            {
                conversorTemperaturas.OptionConverter = TipoConversion.CelsiusAFahrenheit;
            }
            else if (rbtnCelsiusAKelvin.Checked == true)
            {
                conversorTemperaturas.OptionConverter = TipoConversion.CelsiusAKelvin;
            }
            else
            {
                conversorTemperaturas.OptionConverter = TipoConversion.FahrenheitACelsius;
            }

            lblResult.Text = conversorTemperaturas.GetTemperature().ToString("F2");
            lblResult.ForeColor = Color.Red;

        }

        /// <summary>
        /// Evento que se lanza cuando se presiona una tecla en el campo de texto de temperatura base.
        /// Valida que solo se permitan dígitos y un punto decimal.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtTemperaturaBase_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            else if (e.KeyChar == '.' && txtTemperaturaBase.Text.Contains('.'))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Evento que se lanza cuando se hace clic en el botón Limpiar.
        /// Limpia los campos de texto y restaura los valores predeterminados.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtTemperaturaBase.Text = "0.0";
            txtTemperaturaBase.Focus();
            rbtnCelsiusAKelvin.Checked = true;
            rbtnCelsiusAFahrenheit.Checked = false;
            rbtnFahrenheitACelsius.Checked = false;
            lblResult.Text = "0.0";
            lblResult.ForeColor = Color.Gray;
        }

    }
}
