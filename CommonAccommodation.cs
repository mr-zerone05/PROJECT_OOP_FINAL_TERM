using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_OOP_2024
{
    public class CommonAccommodation : Accommodation
    {
        List<Room> DanhSachPhong = new List<Room>();
        private float rate;

        public float Rate { get => rate; set => rate = value; }

        public CommonAccommodation(int id, string name, string street, string city, List<Room> danhSachPhong, float rate) : base(id, name, street, city)
        {
            DanhSachPhong = danhSachPhong;
            Rate = rate;
        }
        public CommonAccommodation(int id, string name, string street, string city, float rate) : base(id, name, street, city)
        {
            Rate = rate;
        }
    }
}
