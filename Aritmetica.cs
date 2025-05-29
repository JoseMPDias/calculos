    /// <summary>
    /// Implementa operações aritméticas.
    /// </summary>
    internal class Aritmetica
    {
        public int Somar(int x, int y)
        {
            return x + y;
        }
    }

    public int Subtrair(int x, int y)
    {
        return x - y;
    }

    /// <summary>
    /// Operação soma.
    /// </summary>
    /// <returns>Retorna a soma de dois números.</returns>

    /// <summary>
    /// Operação subtração.
    /// </summary>
    /// <returns>Retorna o resultado da subtração de dois números.</returns>

    /// <summary>
    /// Tipo de conversão de temperatura a executar.
    /// </summary>
    public enum ConversaoTemperatura
    {
        Nulo = 0,
        CelsiusFahrenheit,
        FahrenheitCelsius
    }


    public double ConverterTemperatura(ConversaoTemperatura conversao, double temperatura)
    {
        if (conversao == ConversaoTemperatura.CelsiusFahrenheit)
        {
            return (temperatura * 1.8000 + 32);
        }
        else if (conversao == ConversaoTemperatura.FahrenheitCelsius)
        {
            return ((temperatura - 32) / 1.8000);
        }

        return -1;
    }

    public static int Multiplicar(int x, int y)
    {
        return x * y;
    }