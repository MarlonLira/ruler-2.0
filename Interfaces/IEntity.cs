using System.Collections.Generic;
using System.Threading.Tasks;

namespace Ruler.Interfaces
{
  interface IEntity
  {
    Task Save<T>(T Entity) where T : class;
    ICollection<dynamic> Search(int Id);
    void Update<T>(T Entity) where T : class;
    void Delete(int Id);
    
  }
}
