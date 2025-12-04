namespace MyWallet.Domain.Base
{
    public class BaseEntity<TId> : IBaseEntity
    {
        protected BaseEntity()
        {
        }
        public BaseEntity(TId id)
        {
            Id = id;
        }

        public TId Id { get; set; }
    }
}
