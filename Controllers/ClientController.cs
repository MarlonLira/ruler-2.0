using Ruler.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading.Tasks;

namespace Ruler.Controllers
{
  [NotMapped]
  public class ClientController : BaseController
  {
    public void Delete() => base.Delete(0);

    public void Save(Client Entity) =>  base.Save(Entity);

    public ICollection<dynamic> Search() => base.Search(0);

    public void Update(Client Entity) => base.Update(Entity);
  }
}