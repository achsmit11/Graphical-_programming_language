using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graphical_Programming_Language_Application
{
    class factory_class
    {
    }


    public interface shape_all
    {
        void Draw();
    }


    public class Rectangle1
    {
        public void draw()
        {
            MessageBox.Show("draw rectangle");
        }
    }

    public class shapefactory1
    {
        public shape_all GetShape(String shapeType1)
        {
            if (shapeType1 == null)
            {
                return null;
            }
            if (shapeType1 == "rectangle")
            {
                return new Rectangle1();
            }
            return null;
        }
    }
    public class factorypatern
    {
        shapefactory1 shapeFactory = new shapefactory1();
        shape_all shape2 = shapeFactory.GetShape("RECTANGLE");
        shape2.draw();
    }
}
