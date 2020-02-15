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
    protected RulerContext _context = new RulerContext();

    public Task Delete(int Id)
    {
      throw new NotImplementedException();
    }

    public virtual async Task Save(T Entity)
    {
      try
      {
        _context.Set<T>().Add(Entity);
        await _context.SaveChangesAsync();
      }
      catch
      {
        throw;
      }
      finally
      {
        if (_context != null && _context.SaveChangesAsync().IsCompleted) _context.Dispose();
      }
    }

    public virtual async Task<ICollection<T>> Search(int Id)
    {
      var _result = new List<T>();
      try
      {
        var Found = _context.Set<T>().FindAsync(Id);
        _result.Add(Found.Result);
      }
      catch
      {
        throw;
      }
      finally
      {
        if (_context != null && _context.SaveChangesAsync().IsCompleted) _context.Dispose();
      }

      return _result;
    }

    public Task Update(T Entity)
    {
      throw new NotImplementedException();
    }
  }
}