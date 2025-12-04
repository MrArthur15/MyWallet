using MyWallet.Domain.Base;


namespace MyWallet.Domain.Entities
{
    public class Bank : BaseEntity<int>
    {
        public Bank() { }
        public Bank(int id, string name, string code, User user) : base(id)
        {
            Name = name;
            Code = code;
            User = user;
        }
        public string Name { get; set; }
        public string Code { get; set; }
        public User User { get; set; }
    }
}
