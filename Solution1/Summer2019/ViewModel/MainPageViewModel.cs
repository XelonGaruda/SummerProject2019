using Summer2019.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summer2019.ViewModel
{
    public class MainPageViewModel
    {
        public Game MyGame { get; set; }

        public MainPageViewModel()
        {
            MyGame = new Game();
        }
    }
}
