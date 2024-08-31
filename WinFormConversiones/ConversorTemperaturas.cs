namespace WinFormConversiones
{
    /// <summary>
    /// Listado de conversiones
    /// </summary>
    public enum TipoConversion
    {
        CelsiusAKelvin,
        CelsiusAFahrenheit,
        FahrenheitACelsius
    }
    /// <summary>
    /// Clase que contiene logina necesaria para convertir temperaturas 
    /// (1) CelsiusAKelvin 
    /// (2) CelsiusAFahrenheit, 
    /// (3) FahrenheitACelsius
    /// </summary>
    public class ConversorTemperaturas
    {
        /// <summary>
        /// Atributos utilizados
        /// </summary>
        private double baseTemperature;
        private TipoConversion optionConverter;

        /// <summary>
        /// Constructor vacio
        /// </summary>
        public ConversorTemperaturas() { }

        /// <summary>
        /// Obtiene y convierte temperaturas mediante la informacion 
        /// obtenida de las propiedades
        /// </summary>
        /// <returns>float Temperatura convertidf</returns>
        public double GetTemperature()
        {
            double result = 0.0f;
            switch (optionConverter)
            {
                case TipoConversion.CelsiusAKelvin:
                    result = baseTemperature * 273.15; break;
                case TipoConversion.CelsiusAFahrenheit:
                    result = (baseTemperature * 1.8) + 32; break;
                case TipoConversion.FahrenheitACelsius:
                    result = (baseTemperature - 32) / 1.8; break;
            }
            return result;
        }

        // Propiedades
        public double BaseTemperature
        {
            get { return baseTemperature; }
            set { baseTemperature = value; }
        }

        public TipoConversion OptionConverter
        {
            get { return optionConverter; }
            set { optionConverter = value; }
        }
    }
}
