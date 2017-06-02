using Nancy;
using System;
using System.Collections.Generic;

namespace Wordcount
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      //code
      Get["/"] = _ => "Hello world";
    }
  }
}
