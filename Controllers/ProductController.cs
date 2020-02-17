using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Ruler.Models;

namespace Ruler.Controllers
{
  [NotMapped]
  public class ProductController : BaseController<Product>
  {
    public new bool Delete(int Id) => base.Delete(Id);

    public new bool Save(Product Entity) => base.Save(Entity);

    public new ICollection<Product> Search(int Id) => base.Search(Id);

    public new bool Update(Product Entity) => base.Update(Entity);
  }
}