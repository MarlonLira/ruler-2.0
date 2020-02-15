using Ruler.Context;
using Ruler.Interfaces;
using Ruler.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ruler.Controllers
{
  public class BaseController : IEntity
  {
    protected RulerContext _context = new RulerContext();

    public void Delete(int Id)
    {
      throw new NotImplementedException();
    }

    public virtual void Save<T>(T Entity) where T : class
    {
      try
      {
        _context.Set<T>().Add(Entity);
        _context.SaveChanges();
      }
      catch
      {
        throw;
      }
    }

    public ICollection<dynamic> Search(int Id)
    {
      throw new NotImplementedException();
    }

    public void Update<T>(T Entity) where T : class
    {
      throw new NotImplementedException();
    }
  }
}