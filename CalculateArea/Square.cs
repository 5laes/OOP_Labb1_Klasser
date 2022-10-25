using System;
using System.Collections.Generic;
using System.Text;

namespace CalculateArea
{
    class Square
    {
        int _sideLength;

        //Konstruktor som tar in en int
        public Square(int sideLength)
        {
            this._sideLength = sideLength;
        }

        //metod för att räkna ut area
        public int GetSquareArea()
        {
            int area = _sideLength * _sideLength;
            return area;
        }

        //Metod för att räkna ut volym
        public int GetCubeVolume()
        {
            int volume = _sideLength * _sideLength * _sideLength;
            return volume;
        }
    }
}
