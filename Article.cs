using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace  NewYorkTimesApiConsoleApp
{
  public class Article 
  {
    public string Section {get; set;}
    public string Title {get; set;}
    public string Abstract {get;set;}
    public string Url {get;set;}
    public string Byline {get;set;}
  }
}