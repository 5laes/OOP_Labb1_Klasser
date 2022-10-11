using System;
using System.Collections.Generic;
using System.Text;

namespace CalculateArea
{
    class Triangle
    {
        float _base;
        float _height;

        public Triangle(float _base, float height)
        {
            this._base = _base;
            this._height = height;
        }

        public float GetTriangleArea()
        {
            float area = (_base * _height) / 2;
            return area;
        }

        public float GetPyramidVolume()
        {
            float volume = _base * _base * _height / 3;
            return volume;
        }
    }
}
