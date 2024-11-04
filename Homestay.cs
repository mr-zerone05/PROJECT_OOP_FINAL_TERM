using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_OOP_2024
{
    public class Homestay : CommonAccommodation
    {
        public Homestay(int id, string name, string street, string city, List<Room> danhSachPhong, float rate) : base(id, name, street, city, danhSachPhong, rate)
        {
        }
        public Homestay(int id, string name, string street, string city, float rate) : base(id, name, street, city, rate)
        {
        }

        public override string ToString()
        {
            return $"Homestay [{Id}, {Name}, {Street}, {Rate}, {City}]";
        }
    }
}
