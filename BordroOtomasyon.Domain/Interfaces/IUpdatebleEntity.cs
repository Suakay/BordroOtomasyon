namespace BordroOtomasyon.Domain.Interfaces
{
    public interface IUpdatebleEntity:ICreatableEntity
    {
        public string? ModifiedBy {  get; set; }    
        public DateTime? ModifiedDate { get; set; }

    }
}
