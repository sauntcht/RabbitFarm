using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RabbitFarm
{
    class Farm 
    {
       
        int bunnyNum;

        MainWindow mainWindow = new MainWindow();
        List<Bunny> bunnies = new List<Bunny>() { };
        Random random = new Random();
        public void AddBunny()
        { 
            bunnyNum++;
            if (random.Next(1, 5) >= 3)
            {
                bunnies.Add(new Bunny(bunnyNum, 0, true, false, 0, false));
            }
            bunnies.Add(new Bunny(bunnyNum, 0, false, false, 0, false));
        }
        public void UpdateRabbitPopulation() 
        {
            int rabbitPop = 0;

            foreach (Bunny bunny in bunnies)
            { 
                rabbitPop++;
            }

            mainWindow.rabbitPopulationBox.Text = rabbitPop.ToString();


        }

    }
}
