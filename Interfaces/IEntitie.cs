using System.Collections.Generic;

namespace Ruler.Interfaces
{
  interface IEntitie
  {
    void Save();
    IEnumerable<dynamic> Search();
    void Update();
    void Delete();
    
  }
}
