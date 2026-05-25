public interface IRepository<T>
{
    List<T> GetAll();
    T? GetById(int id);
    bool Insert(T obj);
    bool Delete(int id);
    bool Update(T obj);

}