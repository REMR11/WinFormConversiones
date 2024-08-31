using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        private float baseTemperature;
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
        public float GetTemperature()
        {
            float result = 0.0f;
            switch (optionConverter)
            {
                case TipoConversion.CelsiusAKelvin:
                    result = baseTemperature * 273.15f; break;
                case TipoConversion.CelsiusAFahrenheit:
                    result = (baseTemperature * 1.8f) + 32; break;
                case TipoConversion.FahrenheitACelsius:
                    result = (baseTemperature - 32) / 1.8f; break;
            }
            return result;
        }

        // Propiedades
        public float BaseTemperature
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
