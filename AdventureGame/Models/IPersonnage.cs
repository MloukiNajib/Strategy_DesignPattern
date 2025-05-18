using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame.Models
{
    internal interface IPersonnage
    {
        void SetArme(IUtiliserArme arme);
        void Combattre();
    }
}
