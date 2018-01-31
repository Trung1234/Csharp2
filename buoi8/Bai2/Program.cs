using System;

namespace Bai2
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape rectangle = new Rectangle(4,5);
            rectangle.getArea();
            rectangle.getPerimeter();

            Shape circle = new Circle(4);
            circle.getArea();
            circle.getPerimeter();
        }
    }    
    public abstract class Shape{
        
        public abstract void getArea();
        public abstract void getPerimeter();
    }
    public class Rectangle : Shape{
        
        private double width;
        private double height;

        public Rectangle(double width,double height){
            this.width = width;
            this.height= height;
        }
        public override void getArea(){
            Console.WriteLine($"dien tich hinh chu nhat la {Width*Height}");
        }
        public override void getPerimeter(){
            Console.WriteLine($"chu vi hinh chu nhat la {(Width + Height) * 2}");
        }
        public double Width { get {return width;} set { width = value;} }
        public double Height { get {return height;} set { height = value;} }
    }
    public class Circle : Shape{
        
        private double banKinh;

        public Circle(double banKinh){
            this.banKinh = banKinh;
        }
        public override void getArea(){
            Console.WriteLine($"dien tich hinh tron la {R*R*Math.PI}");
        }
        public override void getPerimeter(){
            Console.WriteLine($"chu vi hinh tron la {2*R*Math.PI}");
        }
        public double R { get {return banKinh;} set { banKinh = value;} }
    }
}
