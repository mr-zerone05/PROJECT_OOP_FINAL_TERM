using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management_Module
{
    internal class CruiseShip : LuxuryAccommodation
    {
        private bool isBar;
        public bool IsBar() { return isBar; }
        public CruiseShip(int idAcc, string nameAcc, string addressAcc, string cityAcc, bool isPool, bool isDrinkWelcome, bool isFreeBrfast, bool isGym, int maxPerson, double cost1NightLuxury, bool isBar) :
            base(idAcc, nameAcc, addressAcc, cityAcc, isPool, isDrinkWelcome, isFreeBrfast, isGym, maxPerson, cost1NightLuxury)
        {
            this.isBar = isBar;
        }
        public string toString()
        {
            return $"CruiseShip [{idAcc}, {nameAcc}, {addressAcc}, {cityAcc}, {isBar}, {isPool}, {isDrinkWelcome}, {isFreeBrfast}, {isGym}]";
        }
    }
}
