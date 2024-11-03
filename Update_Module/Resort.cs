using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module
{
    public class Resort : CommonAccommodation
    {
        private int startResort;
        private bool isPool;
        public int StartResort { get => startResort; set => startResort = value; }
        public bool IsPool { get => isPool; set => isPool = value; }
        public Resort ()
        { }
        public Resort(int idAcc, string nameAcc, string addressAcc, string cityAcc, List<Room> listRoomOfAcc, float rateAcc, int startResort, bool isPool) : base ( idAcc, nameAcc, addressAcc, cityAcc, listRoomOfAcc, rateAcc)
        {
            StartResort = startResort;
            IsPool = isPool;
        }
        public string toString()
        {
            string s = $"Resort [{IdAcc}, {NameAcc}, {StartResort}, {AddressAcc},{IsPool}, {CityAcc}]";
            return s ;
        }
    }
}
