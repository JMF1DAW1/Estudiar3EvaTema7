
namespace Cuenta
{
    /// <summary>
    /// <para>Clase que representa una cuenta corriente.</para>
    /// </summary>
    public class JMF2021Cuenta
    {
        /// <summary>
        /// Saldo de la cuenta en euros.
        /// </summary>
        private decimal saldo;

        /// <summary>
        /// Obtiene el saldo de la cuenta.
        /// </summary>
        /// <value>El saldo</value>
        public decimal Saldo
        {
            get { return saldo; }
        }

        /// <summary>
        /// <para>Ingresa la cantidad de dinero indicada.</para>
        /// <para>El valor del parámetro <paramref name="cantidad"/> debe ser mayor que 0.</para>
        /// </summary>
        /// <remarks>Recuerda que ingresar modifica el saldo.</remarks>
        /// <param name="cantidad">Número introducido por el usuario con precision decimal</param>
        public void JMF2021Ingresar (decimal cantidad)
        {
            if (cantidad > 0)
                saldo = saldo + cantidad;
        }

        /// <summary>
        /// <para>Retira la cantidad de dinero indicada.</para>
        /// <para>El valor del parámetro <paramref name="cantidad"/> debe ser mayor que 0 y menor o igual que el saldo de la cuenta</para>
        /// </summary>
        /// <param name="cantidad">Número introducido por el usuario con precision decimal</param>
        /// <remarks>Recuerda que retirar modifica el saldo.</remarks>
        /// <returns>El dinero que ha retirado el cliente en su cuenta</returns>
        public decimal JMF2021Retirar (decimal cantidad)
        {
            decimal retirado = 0; //Cantidad que se retira
            if (cantidad > 0 && cantidad <= saldo)
            {
                retirado = cantidad;
                saldo = saldo - cantidad;
            }

            return retirado;
        }
    }
}
