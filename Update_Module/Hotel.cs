using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module
{
    public class Hotel : CommonAccommodation
    {
        private int startHotel;
        public int StartHotel { get => startHotel; set => startHotel = value; }
        public Hotel (int idAcc, string nameAcc, string addressAcc, string cityAcc, List<Room> listRoomOfAcc, float rateAcc, int startHotel) : base (idAcc, nameAcc, addressAcc, cityAcc, listRoomOfAcc, rateAcc)
        {
            StartHotel = startHotel;
        }
        public Hotel (int idAcc, string nameAcc, string addressAcc, string cityAcc, float rateAcc, int startHotel) : base (idAcc, nameAcc, addressAcc, cityAcc, new List<Room>(), rateAcc)
        {
            StartHotel = startHotel;
        }
        public string toString()
        {
            string s = $"Hotel [{IdAcc}, {StartHotel}, {NameAcc}, {AddressAcc}, {CityAcc}]";
            return s;
        }
    }
}
