using Ruler.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading.Tasks;

namespace Ruler.Controllers
{
  [NotMapped]
  public class ClientController : BaseController<Client>
  {
    public new bool Delete(int Id) => base.Delete(Id);

    public new bool Save(Client Entity) => base.Save(Entity);

    public new ICollection<Client> Search(int Id) => base.Search(Id);

    public new bool Update(Client Entity) => base.Update(Entity);
  }
}