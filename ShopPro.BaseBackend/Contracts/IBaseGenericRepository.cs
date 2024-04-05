

namespace ShopPro.BaseBackend.Contracts;

public interface IBaseGenericRepository<TEntity> where TEntity : class
{

    TEntity GetById(object id);
    List<TEntity> GetAll();
    bool Insert(TEntity item);
    bool Update(TEntity item);
    bool Delete(int id);
}
