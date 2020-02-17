using System.Collections.Generic;

namespace Ruler.Interfaces
{
  interface IEntity<T>
  {
    bool Save(T Entity);
    ICollection<T> Search(int Id);
    bool Update(int Id, T Entity);
    bool Delete(int Id);
  }
}
