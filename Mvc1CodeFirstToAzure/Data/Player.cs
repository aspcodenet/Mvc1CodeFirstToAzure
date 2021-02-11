namespace Mvc1CodeFirstToAzure.Data
{
    public class Player
    {
        //Jag har tjuvstartat lite...nytt projekt
        //en klass här i Data som ska bli min (enda) entitet (tabell)
        public int Id { get; set; }
        public string Namn { get; set; }
        public int Jersey { get; set; }
        public string Team { get; set; }
    }
}