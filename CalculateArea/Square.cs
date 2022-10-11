using System;
using System.Collections.Generic;
using System.Text;

namespace CalculateArea
{
    class Square
    {
        int _sideLength;

        public Square(int sideLength)
        {
            this._sideLength = sideLength;
        }

        public int GetSquareArea()
        {
            int area = _sideLength * _sideLength;
            return area;
        }

        public int GetCubeVolume()
        {
            int volume = _sideLength * _sideLength * _sideLength;
            return volume;
        }
    }
}
