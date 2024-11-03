using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management_Module
{
    internal class Homestay:CommonAccommodation
    {
        public Homestay(int idAcc, string nameAcc, string addressAcc, string cityAcc, float rateAcc)
            :base(idAcc, nameAcc, addressAcc, cityAcc, rateAcc)
        {
        }

        public Homestay(int idAcc, string nameAcc, string addressAcc, string cityAcc, List<Room> listRoomOfAcc, float rateAcc)
            :base(idAcc, nameAcc, addressAcc, cityAcc, listRoomOfAcc, rateAcc)
        {
        }

        public string toString()
        {
            return $"\tHomestay Information!!!\nID: {IdAcc}. Name: {NameAcc}.\nAddress: {AddressAcc}. City: {CityAcc}.";
        }
    }
}
