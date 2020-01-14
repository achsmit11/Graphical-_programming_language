using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphical_Programming_Language_Application
{
    class ShapeFactory
    {
        /// <summary>
        /// passing value on shapetype
        /// </summary>
        /// <param name="shapeType"></param>
        /// <returns></returns>
        public Shape GetShape(String shapeType)
        {
            if (shapeType == "circle")
            {
                return new Circle();
            }
            else if (shapeType == "rectangle")
            {
                return new Rectangle();
            }
            else if (shapeType == "line")
            {
                return new Line();
            }
            else if (shapeType == "triangle")
            {
                return new Triangle();
            }
            else if (shapeType == "polygon")
            {
                return new Polygon();
            }
            return null;
        }
    }
}
