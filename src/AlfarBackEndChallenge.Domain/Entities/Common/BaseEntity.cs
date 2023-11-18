namespace AlfarBackEndChallenge.Domain.Entities.Common
{
    public abstract class BaseEntity
    {
        public Guid Code { get; set; }
        public int Status { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime LastUpdated { get; set; }
    }
}