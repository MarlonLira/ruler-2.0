using System.Collections.Generic;
using System.Threading.Tasks;

namespace Ruler.Interfaces
{
  interface IEntity<T>
  {
    bool Save(T Entity);
    ICollection<T> Search(int Id);
    bool Update(T Entity);
    bool Delete(int Id);
  }
}
