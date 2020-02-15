using System.Collections.Generic;

namespace Ruler.Interfaces
{
  interface IEntity
  {
    void Save<T>(T Entity) where T : class;
    ICollection<dynamic> Search(int Id);
    void Update<T>(T Entity) where T : class;
    void Delete(int Id);
    
  }
}
