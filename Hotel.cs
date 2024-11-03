using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management_Module
{
    internal class Hotel:CommonAccommodation
    {
        private float starHotel;

        public int StarHote
        {
            get { return starHotel; }
            set { starHotel = value; }
        }

        public Hotel(int idAcc, string nameAcc, string addressAcc, string cityAcc, float rateAcc, float starHotel)
            :base(idAcc, nameAcc, addressAcc, cityAcc, rateAcc)
        {
            this.starHotel = starHotel;
        }

        public Hotel(int idAcc, string nameAcc, string addressAcc, string cityAcc, List<Room> listRoomOfAcc, float rateAcc, float starHotel)
            :base(idAcc, nameAcc, addressAcc, cityAcc, listRoomOfAcc, rateAcc)
        {
            this.starHotel = starHotel;
        }

        public string toString()
        {
            return $"\tHotel Information!!!\nID: {IdAcc}. Name: {NameAcc}.\nAddress: {AddressAcc}. City: {CityAcc}.\n*** Star ***: {StarHote}.";
        }
    }
}
