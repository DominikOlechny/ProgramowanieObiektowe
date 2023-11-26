using LAB4._1;
using System.Security.Cryptography.X509Certificates;

List<Shape> shapes = new List<Shape>();

Rectangle rectangle = new Rectangle(0, 12, 5, 3);

shapes.Add(rectangle);

foreach (Shape shape in shapes)
{
    shape.Draw();
}