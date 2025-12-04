namespace MyWallet.Domain.Enum
{
    public enum PriorityLevel
    {
        None = 0,         // Para Receitas (que não têm prioridade de gasto)
        Essential = 1,    // Indispensável (Aluguel, Mercado)
        Superfluous = 2   // Supérfluo (Pode cortar)
    }
}
