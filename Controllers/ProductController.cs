using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Ruler.Models;

namespace Ruler.Controllers
{
  [NotMapped]
  public class ProductController : BaseController<Product>
  {
    public void Delete() => base.Delete(0);

    public void Save(Product Entity) => base.Save(Entity);

    public ICollection<Product> Search(int Id) => base.Search(Id).Result;

    public void Update(Product Entity) => base.Update(Entity);
  }
}