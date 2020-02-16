using Ruler.Context;
using Ruler.Interfaces;
using Ruler.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace Ruler.Controllers
{
  public class BaseController<T> : IEntity<T> where T : class
  {
    public bool Delete(int Id)
    {
      throw new NotImplementedException();
    }

    public bool Save(T Entity)
    {
      try
      {
        using (var _context = new RulerContext())
        {
          _context.Entry(Entity).State = System.Data.Entity.EntityState.Modified;
          _context.Set<T>().Add(Entity);
          _context.SaveChanges();
          return true;
        }

      }
      catch
      {
        throw;
      }
    }

    public bool Update(T Entity)
    {
      throw new NotImplementedException();
    }

    public ICollection<T> Search(int Id)
    {
      var _result = new List<T>();
      try
      {
        using (var _context = new RulerContext())
        {
          _result.Add(_context.Set<T>().FindAsync(Id).Result);
          return _result;
        }
      }
      catch
      {
        throw;
      }
    }
  }
}