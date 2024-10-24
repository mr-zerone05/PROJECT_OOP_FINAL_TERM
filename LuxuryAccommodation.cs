using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management_Module
{
    internal class LuxuryAccommodation : Accommodation
    {
        protected bool isPool;
        protected bool isDrinkWelcome;
        protected bool isFreeBrfast;
        protected bool isGym;
        protected int maxPerson;
        protected double cost1NightLuxury;
        public LuxuryAccommodation(int idAcc, string nameAcc, string addressAcc, string cityAcc) : base(idAcc, nameAcc, addressAcc, cityAcc)
        { }
        public LuxuryAccommodation(int idAcc, string nameAcc, string addressAcc, string cityAcc, bool isPool, bool isDrinkWelcome, bool isFreeBrfast, bool isGym, int maxPerson, double cost1NightLuxury) :
            base(idAcc, nameAcc, addressAcc, cityAcc)
        {
            this.isPool = isPool;
            this.isDrinkWelcome = isDrinkWelcome;
            this.isFreeBrfast = isFreeBrfast;
            this.isGym = isGym;
            this.maxPerson = maxPerson;
            this.cost1NightLuxury = cost1NightLuxury;
        }
    }
}
