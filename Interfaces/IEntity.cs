using System.Collections.Generic;
using System.Threading.Tasks;

namespace Ruler.Interfaces
{
  interface IEntity<T>
  {
    Task Save(T Entity);
    Task<ICollection<T>> Search(int Id);
    Task Update(T Entity);
    Task Delete(int Id);
  }
}
