using Ruler.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ruler.Controllers
{
  [NotMapped]
  public class ClientController : BaseController<Client>
  {
    public new bool Delete(int Id) => base.Delete(Id);

    public new bool Save(Client Entity) => base.Save(Entity);

    public new ICollection<Client> Search(int Id = 0) => base.Search(Id);

    public bool Update(Client Entity) => base.Update(Entity.Id, Entity);

    //public new ICollection<Client> Select(Func<Client, bool> Predicate) => base.Find().Where(Predicate).ToList();
  }
}