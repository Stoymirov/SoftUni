using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
    public class GraphicEditor
    {
        List<IShape> shapes = new List<IShape>()
        {
            new Circle(),
            new Rectangle(),
            new Square(),
            new Weirdo()
        };

        public void DrawShape(IShape shape)
        {
            foreach (var shape1 in shapes)
            {
                if (shape.GetType() == shape1.GetType())
                {
                    shape.Draw();
                }
            }
        }
    }
}
