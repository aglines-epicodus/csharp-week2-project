using Nancy;
using System;
using System.Collections.Generic;

namespace Wordcount
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => View["submitword.cshtml"];

      Post["/result"] = _ =>
      {
        string userInputWord = Request.Form["user-input-word"];
        string userInputString = Request.Form["user-input-string"];
        int countOfRepeats = RepeatCounter.CountRepeats(userInputWord, userInputString);
        return View["result.cshtml", countOfRepeats];
      };
    }
  }
}
