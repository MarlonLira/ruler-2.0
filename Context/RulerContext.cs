using Ruler.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Ruler.Context
{
  public partial class RulerContext : DbContext
  {
    public RulerContext() : base("name=ruler")
    {
    }
    public virtual DbSet<Client> Clients { get; set; }
    public virtual DbSet<Product> Products { get; set; }


  }
}