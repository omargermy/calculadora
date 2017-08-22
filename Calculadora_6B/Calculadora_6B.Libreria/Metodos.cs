using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_6B.Libreria
{
    public class Metodos
    {
        /// <summary>
        /// Metodo Publico Que Envia Saludo
        /// </summary>
        /// <returns>Una Cadena</returns>
        public string Saludar()
        {
            return "Hola Mundo";
        }
        /// <summary>
        /// Funcion Que Realiza La Suma De Dos Números
        /// </summary>
        /// <param name="Valor1">Flotante</param>
        /// <param name="Valor2">Flotante</param>
        /// <returns>Resultado Flotante</returns>
        public float Sumar(float Valor1, float Valor2)
        {
            var Resultado = Valor1 + Valor2;
            return Resultado;
        }
        /// <summary>
        /// Funcion Que Realiza La Resta De Dos Números
        /// </summary>
        /// <param name="Valor1">Flotante</param>
        /// <param name="Valor2">Flotante</param>
        /// <returns>Resultado Flotante</returns>
        public float Restar(float Valor1, float Valor2)
        {
            var Resultado = Valor1 - Valor2;
            return Resultado;
        }
        /// <summary>
        /// Funcion Que Realiza La Multiplicacion De Dos Números
        /// </summary>
        /// <param name="Valor1">Flotante</param>
        /// <param name="Valor2">Flotante</param>
        /// <returns>Resultado Flotante</returns>
        public float Multiplicar(float Valor1, float Valor2)
        {
            var Resultado = Valor1 * Valor2;
            return Resultado;
        }
        /// <summary>
        /// Funcion Que Realiza La Division De Dos Números
        /// </summary>
        /// <param name="Valor1">Flotante</param>
        /// <param name="Valor2">Flotante</param>
        /// <returns>Resultado Flotante</returns>
        public float Dividir(float Valor1, float Valor2)
        {
            var Resultado = Valor1 / Valor2;
            return Resultado;
        }
    }
}
