namespace MyWallet.Domain.Enum
{
    public enum PaymentMethod
    {
        Cash = 1,        // Dinheiro
        DebitCard = 2,   // Cartão de Débito
        CreditCard = 3,  // Cartão de Crédito (Ativa parcelas)
        Pix = 4,         // Pix
        BankSlip = 5,    // Boleto
        Transfer = 6     // Transferência Bancária (TED/DOC)
    }
}
