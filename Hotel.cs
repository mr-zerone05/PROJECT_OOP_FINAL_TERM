using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_OOP_2024
{
    public class Hotel : CommonAccommodation
    {
        private int stars;

        public int Stars { get => stars; set => stars = value; }

        public Hotel(int id, string name, string street, string city, List<Room> danhSachPhong, float rate, int stars) : base(id, name, street, city, danhSachPhong, rate)
        {
            Stars = stars;
        }
        public Hotel(int id, string name, string street, string city, float rate, int stars) : base(id, name, street, city, rate)
        {
            Stars = stars;
        }

        public override string ToString()
        {
            return $"Hotel [{Id}, {Stars}, {Name}, {Street}, {City}]";
        }
    }
}
