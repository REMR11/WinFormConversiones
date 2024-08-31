using System;
using System.Windows.Forms;


namespace WinFormConversiones
{
    /// <summary>
    /// <author>Ronald Eduardo Mejia Reinosa</author>
    /// Carne: MR100823
    /// </summary>
    /// Proyecto de escritorio encargado de recibir y convertir temperaturas
    /// Proyecto Aplicacion de Windows Form de .NET
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
