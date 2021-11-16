using System;

namespace Task01
{

    class Point
    {

        private double _phi;
        private double _ro;
        private double _x;
        private double _y;

        public Point(double x, double y)
        {
            _x = x;
            _y = y;
            _phi = GetPhi();
        }


        private double GetPhi()
        {
            if (_x > 0 && _y >= 0)
                return Math.Atan(_y / _x);
            if (_x > 0 && Y < 0)
                return Math.Atan(_y / _x) + 2 * Math.PI;
            if (_x < 0)
                return Math.Atan(_y / _x) + Math.PI;
            if (_x == 0 && _y > 0)
                return Math.PI / 2;
            if (_x == 0 && _y < 0)
                return (3 * Math.PI) / 2;
            if (_x == 0 && _y == 0)
                return 0;
            return 0;
        }

        public double Phi { get => _phi; }
        public double Ro { get => _ro; }
        public double X { get => _x; }
        public double Y { get => _y; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
