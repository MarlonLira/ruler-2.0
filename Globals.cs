﻿using System;
using System.Web;

namespace Ruler
{
  public static class Globals
  {
    public static String FormatUrl(String Url)
    {
      String Result = (HttpContext.Current.Request.Url.Authority + @"/" + Url.Replace(@"~/", @"/"));
      while (Result.IndexOf(@"//") > -1)
      {
        Result = Result.Replace(@"//", @"/");
        Result = Result.Replace("../", "/");
        Result = Result.Replace("./", "/");
      }
      return HttpContext.Current.Request.Url.Scheme + @"://" + Result;
    }
  }
}