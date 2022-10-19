using System;

namespace UWS.Shared
{
    public class Publisher
    {
        public int PublisherID {get;set;}
        public string PublisherName{get;set;}
        


        //related entities 
        public Game Game {get;set;}
        
    }
}
