namespace Mobil_Market.Models.IRepositry
{
    public interface IRepositryDBcontext <TEntity>
    {
        IEnumerable<TEntity> GetAllList();
        TEntity Get(string id);
        void Add(TEntity entity);
        void Update(string id , TEntity entity);
        void Delete(string id);
    }
}
