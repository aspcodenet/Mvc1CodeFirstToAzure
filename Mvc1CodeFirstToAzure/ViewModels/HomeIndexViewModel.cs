using System.Collections.Generic;

namespace Mvc1CodeFirstToAzure.ViewModels
{
    public class HomeIndexViewModel
    {
        public class PlayerViewModel
        {
            public int Id { get; set; }
            public string Namn { get; set; }
        }
        public List<PlayerViewModel> Players { get; set; }
    }
}