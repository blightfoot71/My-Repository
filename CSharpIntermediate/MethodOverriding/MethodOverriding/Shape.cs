using System;

namespace MethodOverriding
{
    class Circle : Shape
    {
        public override void Draw()
        {
            //Any code specific to the circle itself
            Console.WriteLine("Draw a circle");

            // base.Draw(); //Was put here automatically by Visual Studio when I selected autocomplete Draw()
            // This would call the base or parent class in this case Shape, but in this case we have not implemented that.
            // Should be removed, but I left it here just to show it.
        }
    }
    class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Draw a rectangle");
        }
    }
    public class Triangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Draw a Triangle");
        }
    }
    public class Shape
    {
        public int Width { get; set; }
        public int Heigth { get; set; }
        //public Position Position { get; set; }
        // public ShapeType Type { get; set; }  We get rid of this in our better solution

        public virtual void Draw()
        {

        }
    }
}
