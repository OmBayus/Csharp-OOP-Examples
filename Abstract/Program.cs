using System;

namespace Abstract
{
    abstract class Shape
    {

        public Shape(int w,int h)
        {
            this.Width = w;
            this.Height = h;
        }
        public int Width { get; set; }
        public int Height { get; set; }

        public abstract void Draw();

        public int CalculateArea(){
            return this.Width * this.Height;
        }
    }

    class Square: Shape{

        public Square(int w,int h):base(w,h)
        {
            this.Width = w;
            this.Height = h;
        }
        public override void Draw(){
            Console.WriteLine("Draw a square");
        }
    }

    class Rectangle: Shape{

        public Rectangle(int w,int h):base(w,h)
        {
            this.Width = w;
            this.Height = h;
        }
        public override void Draw(){
            Console.WriteLine("Draw a rectangle");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var shapes = new Shape[3];

            shapes[0] = new Rectangle(10,20);
            shapes[1] = new Square(3,6);
            shapes[2] = new Rectangle(2,4);

            foreach (var shape in shapes){
                shape.Draw();
                Console.WriteLine(shape.CalculateArea());
            }
        }
    }
}