using System.Collections.Generic;
using UWS.Shared;

namespace GamesMVC.Models
{
  public class HomeIndexViewModel
  {
    public int VisitorCount;
    public IList<Category> Categories { get; set; } 
    public IList<Game> Games { get; set; }
  }
}