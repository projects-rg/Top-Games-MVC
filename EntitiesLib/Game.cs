using System;


namespace UWS.Shared
{
    public class Game
    {
        public int GameID {get;set;}

       
        public string GameName{get;set;}
        public int CategoryID{get;set;}
        public DateTime ReleaseDate {get;set;}
        public int PublisherID{get;set;}
        public decimal? Sales{get;set;} = 0;


        //related entities 
        public Category Category {get;set;}
        public Publisher Publisher{get;set;}

    }
}
