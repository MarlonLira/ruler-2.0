using Ruler.Context;
using Ruler.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Ruler.Controllers
{
  public class BaseController<T> : IEntity<T> where T : class
  {
    public bool Delete(int Id)
    {
      using (var context = new RulerContext())
      {
        var Found = context.Set<T>().Find(Id);
        if (Found == null) return false;
        
        context.Set<T>().Remove(Found);
        context.SaveChanges();
        return true;
      }
    }

    public bool Save(T Entity)
    {
      if (Entity == null) return false;
      using (var context = new RulerContext())
      {
        context.Set<T>().Add(Entity);
        context.SaveChanges();
        return true;
      }
    }

    public bool Update(int Id, T Entity)
    {
      using (var context = new RulerContext())
      {
        var Found = context.Set<T>().Find(Id);
        if (Found == null) return false;

        context.Entry(Found).State = System.Data.Entity.EntityState.Modified;
        context.Entry(Found).CurrentValues.SetValues(Entity);
        context.SaveChanges();
        return true;
      }
    }

    public ICollection<T> Find(int Id = 0) => Id == 0 ?
      new RulerContext().Set<T>().AsEnumerable().ToList() :
      new List<T>() { new RulerContext().Set<T>().Find(Id) };

    public ICollection<T> Search(int Id = 0)
    {
      try
      {
        using (var context = new RulerContext())
          return Id == 0 ? context.Set<T>().AsEnumerable().ToList() : new List<T>() { context.Set<T>().Find(Id) };
      }
      catch (Exception Except)
      {
        throw new Exception(Except.Message);
      }
    }
  }
}