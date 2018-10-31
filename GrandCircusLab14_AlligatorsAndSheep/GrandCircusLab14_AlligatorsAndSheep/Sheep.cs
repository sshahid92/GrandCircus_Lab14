using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandCircusLab14_AlligatorsAndSheep
{
    class Sheep : ICountable, ICloneable
    {
        private int _count { get; set; }
        public string Name { get; set; }

        public Sheep(int count, string name)
        {
            _count = count;
            Name = name;
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
            return (_count).ToString() + " " + Name;
        }

        public object Clone()
        {
            return (Sheep) this.MemberwiseClone();

        }
    }
}
