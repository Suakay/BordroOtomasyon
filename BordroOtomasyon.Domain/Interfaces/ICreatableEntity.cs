namespace BordroOtomasyon.Domain.Interfaces
{
    public interface ICreatableEntity:IEntity
    {
        public string CeratedBy {  get; set; }  
        public DateTime CreatedDate { get; set; }   


    }
}
