using System;
using System.Collections.Generic;
using System.Text;

namespace CalculateArea
{
    class Circle
    {
        float _pi = 3.141592f;
        float _radius;

        //Konstruktor som tar in en float
        public Circle(float radius)
        {
            this._radius = radius;
        }

        //metod för att räkna ut area
        public float GetAreaCircle()
        {
            float area = _pi * _radius * _radius;
            return area;
        }

        //Metod för att räkna ut volym
        public float GetVolumeSphere()
        {
            float volume = (4 / 3) * _pi * _radius * _radius * _radius;
            return volume;
        }
    }
}
