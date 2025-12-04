namespace MyWallet.Domain.Enum
{
    public enum TransactionType
    {
        Revenue = 1,     // Receita / Entrada
        Expense = 2,     // Despesa / Saída
        Transfer = 3     // Transferência (Apenas para movimentação, não se aplica a Categoria)
    }
}
