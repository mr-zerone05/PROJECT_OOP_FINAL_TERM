using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management_Module
{
    internal class Resort:CommonAccommodation
    {
        private float starResort;
        private bool isPool;

        public float StarResort
        {
            get { return starResort; }
            set { starResort = value; }
        }

        public bool IsPool
        {
            get { return isPool; }
            set { isPool = value; }
        }

        public Resort(int idAcc, string nameAcc, string addressAcc, string cityAcc, float rateAcc, float starResort, bool isPool)
            :base(idAcc, nameAcc, addressAcc, cityAcc, rateAcc)
        {
            StarResort = starResort;
            IsPool = isPool;
        }

        public Resort(int idAcc, string nameAcc, string addressAcc, string cityAcc, List<Room> listRoomOfAcc, float rateAcc, float starResort, bool isPool)
            :base(idAcc, nameAcc, addressAcc, cityAcc, listRoomOfAcc, rateAcc)
        {
            StarResort = starResort;
            IsPool = isPool;
        }

        public string toString()
        {
            return $"\tResort Information!!!\nID: {IdAcc}. Name: {NameAcc}.\nAddress: {AddressAcc}. City: {CityAcc}.\n*** Star ***: {StarResort}.\n\n";
        }
    }
}
