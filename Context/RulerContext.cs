using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Ruler.Context
{
  public class RulerContext : DbContext
  {
    public RulerContext() : base("ruler")
    {

    }
  }
}