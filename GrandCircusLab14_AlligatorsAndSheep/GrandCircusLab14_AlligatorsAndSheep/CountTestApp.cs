using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandCircusLab14_AlligatorsAndSheep
{
    class CountTestApp
    {
        
        public CountTestApp()
        {
            
        }

        public void Alligator()
        {
            Alligator alligator = new Alligator(0);

            CountUtil.Count(alligator, 3);
            

            Sheep sheep = new Sheep(0, "Doug");
            CountUtil.Count(sheep, 2);
            var newSheep = (Sheep)sheep.Clone();
            newSheep.Name = "Billy";
            newSheep.ResetCount();
            CountUtil.Count(newSheep, 3);
            sheep.ResetCount();
            CountUtil.Count(sheep, 1);
            Console.ReadLine();

        }



    }
}
