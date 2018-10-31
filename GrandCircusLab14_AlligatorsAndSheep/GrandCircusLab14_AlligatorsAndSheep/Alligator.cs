using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandCircusLab14_AlligatorsAndSheep
{
    class Alligator : ICountable
    {
        private int _count { get; set; }

        public Alligator(int count)
        {
            _count = count;
        }

        public void IncrementCount()
        {
            _count++;
        }

        public void ResetCount()
        {
            _count = 0;
        }

        public int GetCount()
        {
            return _count;
        }

        public string GetCountString()
        {
            return (_count).ToString() + " Alligator";
        }



    }
}
