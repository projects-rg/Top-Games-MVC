using System;
using System.Collections.Generic;

namespace UWS.Shared
{
    public class Category
    {
        public int CategoryID{get;set;}
        public string CategoryName { get; set; }
        public string Description { get; set; }

        public ICollection<Game> Games { get; set; }
    }
}
