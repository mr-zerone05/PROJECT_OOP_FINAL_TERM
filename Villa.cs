using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management_Module
{
    internal class Villa : LuxuryAccommodation
    {
        public Villa(int idAcc, string nameAcc, string addressAcc, string cityAcc, bool isPool, bool isDrinkWelcome, bool isFreeBrfast, bool isGym, int maxPerson, double cost1NightLuxury) :
            base(idAcc, nameAcc, addressAcc, cityAcc, isPool, isDrinkWelcome, isFreeBrfast, isGym, maxPerson, cost1NightLuxury)
        { }
        public string toString()
        {
            return $"Villa [{idAcc}, {nameAcc}, {addressAcc}, {cityAcc}, {isPool}, {isDrinkWelcome}, {isFreeBrfast}, {isGym}, {maxPerson}, {cost1NightLuxury}]";
        }
    }
}
