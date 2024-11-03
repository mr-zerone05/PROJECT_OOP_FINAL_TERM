using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management_Module
{
    internal class CommonAccommodation:Accommodation
    {
        protected List<Room> listRoomOfAcc = new List<Room>();
        protected float rateAcc;

        public float RateAcc
        {
            get { return rateAcc; }
            set { rateAcc = value; }
        }

        public List<Room> ListRoomOfAcc
        {
            get { return listRoomOfAcc; }
            set { listRoomOfAcc = value; }
        }

        public CommonAccommodation(int idAcc, string nameAcc, string addressAcc, string cityAcc, float rateAcc)
            :base(idAcc, nameAcc, addressAcc, cityAcc)
        {
            this.rateAcc = rateAcc;
        }
        public CommonAccommodation(int idAcc, string nameAcc, string addressAcc, string cityAcc, List<Room> listRoomOfAcc, float rateAcc)
            :base(idAcc, nameAcc, addressAcc, cityAcc)
        {
            this.listRoomOfAcc = listRoomOfAcc;
            this.rateAcc = rateAcc;
        }
    }
}
