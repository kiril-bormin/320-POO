using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Drones
{
    public partial class Building
    {
        protected int _x;
        protected int _y;
        private const int HEIGHT = 40;
        private const int DEPTH = 40;
        private string _color = "";

        public Building(int x, int y)
        {
            _x = x;
            _y = y;
        }

        public int X
        {
            get
            {
                return _x;
            }
            set
            {
                _x = value;
            }
        }
        public int Y
        {
            get
            {
                return _y;
            }
            set
            {
                _y = value;
            }
        }
       /* public string Color
        {
            get
            {
                return _color;
            }
            set
            {
                _color = value;
            }
        }*/

    }
}
