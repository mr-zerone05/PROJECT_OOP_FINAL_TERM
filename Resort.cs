using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_OOP_2024
{
    public class Resort : CommonAccommodation
    {
        private int star;
        private bool swim;

        public int Star { get => star; set => star = value; }
        public bool Swim { get => swim; set => swim = value; }

        public Resort (int id, string name, string street, string city, List<Room> danhSachPhong, float rate, int star, bool swim) : base ( id, name, street, city, danhSachPhong, rate)
        {
            Star = star;
            Swim = swim;
        }
        public Resort (int id, string name, string street, string city, float rate, int star, bool swim) : base (id, name, street, city, rate)
        {
            Star = star;
            Swim = swim;
        }

        public override string ToString()
        {
            return $"Resort [{Id}, {Name}, {Star}, {Street}, {Swim}, {City}]";
        }
    }
}
