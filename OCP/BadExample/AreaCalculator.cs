using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Demo.OCP.BadExample
{
    internal class AreaCalculator
    {
        public double TotalArea(object[] shapeObjects)
        {
            double area = 0;
            Rectangle objRectangle;
            Circle objCircle;
            foreach (var obj in shapeObjects)
            {
                if (obj is Rectangle)
                {
                    objRectangle = (Rectangle)obj;
                    area += objRectangle.Height * objRectangle.Width;
                }
                else
                {
                    objCircle = (Circle)obj;
                    area += objCircle.Radius * objCircle.Radius * Math.PI;
                }
            }
            return area;
        }
    }
}
