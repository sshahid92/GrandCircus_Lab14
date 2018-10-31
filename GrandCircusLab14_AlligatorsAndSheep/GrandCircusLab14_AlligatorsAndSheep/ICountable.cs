using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandCircusLab14_AlligatorsAndSheep
{
    interface ICountable
    {
        void IncrementCount();

        void ResetCount();

        int GetCount();

        string GetCountString();
    }
}
