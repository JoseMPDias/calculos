    /// <summary>
    /// Conversão de temperaturas.
    /// </summary>
    /// <param name="conversao">A conversão a efetuar.</param>
    /// <param name="temperatura">A temperatua a converter.</param>
    /// <returns>Retorna o resultado da conversão da temperatura.</returns>

    /// <summary>
    /// Tipo de conversão de distâncias.
    /// </summary>
    public enum ConversaoDistancia
    {
        Nulo = 0,
        MetrosMilhas,
        MilhasMetros
    }


    /// <summary>
    /// Conversão de distâncias.
    /// </summary>
    /// <param name="conversao">A conversão a efetuar.</param>
    /// <param name="distancia">A distância a converter</param>
    /// <returns>Retorna o resultado da conversão da distância.</returns>
    public static double ConverterDistancias(ConversaoDistancia conversao, double distancia)
    {
        if (conversao == ConversaoDistancia.MetrosMilhas)
        {
            return distancia * 0.0006213712;
        }
        else if (conversao == ConversaoDistancia.MilhasMetros)
        {
            return distancia * 1609.344;
        }

        return -1;
    }