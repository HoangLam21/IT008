using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Http.Headers;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Bai1_Project
{
    internal class Program
    {
        public class Point2D
        {
            float x;
            public float X { get { return x; } set { x = value; } }
            float y;
            public float Y { get { return y; } set { y = value; } }
            public void Point2DIn()
            {
                Console.Write("x = ");
                X = float.Parse(Console.ReadLine());
                Console.Write("y = ");
                Y = float.Parse(Console.ReadLine());
            }
            public string Poin2DToString()
            {
                return "(" + X.ToString() + ";" + Y.ToString() + ")";
            }
            public float DistantTo(Point2D other)
            {
                return (float)(Math.Sqrt((X - other.X) * (X - other.X) + (Y - other.Y) * (Y - other.Y)));
            }
        }
        public class Shape
        {
            string name;
            virtual public string Name
            {
                get { return name; }
            }

            virtual public void Input()
            {

            }
            virtual public void Draw()
            {

            }
            virtual public float CalcSquare()
            {
                return 0;
            }

        }

        public class Circle : Shape
        {
            float r;
            public float R
            {
                get { return r; }
                set { r = value; }
            }

            Point2D mind;
            public Point2D Mind { get { return mind; } set { mind = value; } }
            override public string Name
            {
                get { return "Circle"; }
            }

            public bool CheckInput(float r)
            {
                return (r > 0) ? true : false;
            }
            public override void Input()
            {
                Console.WriteLine("Radius of this Circle: ");
                R = float.Parse(Console.ReadLine());
                Console.WriteLine("The Mind:");
                mind = new Point2D();
                Mind.Point2DIn();
                if (CheckInput(R))
                {
                    return;
                }
                else
                {
                    Console.WriteLine("This is not a right value (r > 0),  please type again");
                    Input();
                }
            }


            public override void Draw()
            {
                Console.WriteLine("The " + Name);
                Console.WriteLine("Mind is: " + Mind.Poin2DToString());
                Console.WriteLine("Raius is: " + R);
            }

            public override float CalcSquare()
            {
                return (float)(R * R * Math.PI);
            }

        }

        public class Triangle : Shape
        {
            Point2D vertex1;
            public Point2D Vertex1 { get { return vertex1; } set { vertex1 = value; } }
            Point2D vertex2;
            public Point2D Vertex2 { get { return vertex2; } set { vertex2 = value; } }
            Point2D vertex3;
            public Point2D Vertex3 { get { return vertex3; } set { vertex3 = value; } }
            override public string Name
            {
                get { return "Triangle"; }
            }
            public bool CheckingInput()
            {
                float a = Vertex1.DistantTo(Vertex2);
                float b = Vertex2.DistantTo(Vertex3);
                float c = Vertex3.DistantTo(Vertex1);
                bool check1 = a + b > c;
                bool check2 = b + c > a;
                bool check3 = c + a > b;
                return check1 && check2 && check3;
            }
            override public void Input()
            {
                Console.WriteLine("Type the axis of 3 vertexs of " + Name + ": ");
                vertex1 = new Point2D();
                vertex2 = new Point2D();
                vertex3 = new Point2D();
                Console.WriteLine("1st vertex: ");
                Vertex1.Point2DIn();
                Console.WriteLine("2nd vertex: ");
                Vertex2.Point2DIn();
                Console.WriteLine("3rd vertex: ");
                Vertex3.Point2DIn();
                if (CheckingInput())
                {
                    return;
                }
                else
                {
                    Console.WriteLine("They are not a right value, please type again");
                    Input();
                }
            }
            override public void Draw()
            {
                Console.WriteLine(Name + " with 3 vertexes is: ");
                Console.WriteLine("Vertex1: " + Vertex1.Poin2DToString());
                Console.WriteLine("Vertex2: " + Vertex2.Poin2DToString());
                Console.WriteLine("Vertex3: " + Vertex3.Poin2DToString());
            }

            override public float CalcSquare()
            {
                float a = Vertex1.DistantTo(Vertex2);
                float b = Vertex2.DistantTo(Vertex3);
                float c = Vertex3.DistantTo(Vertex1);
                float p = (a + b + c) / 2;
                return (float)(Math.Sqrt(p * (p - a) * (p - b) * (p - c)));
            }

        }

        public class Rectangle : Shape
        {
            Point2D vertex1;
            public Point2D Vertex1 { get { return vertex1; } set { vertex1 = value; } }
            Point2D vertex2;
            public Point2D Vertex2 { get { return vertex2; } set { vertex2 = value; } }
            Point2D vertex3;
            public Point2D Vertex3 { get { return vertex3; } set { vertex3 = value; } }
            Point2D vertex4;
            public Point2D Vertex4 { get { return vertex4; } set { vertex4 = value; } }
            override public string Name
            {
                get { return "Rectangle"; }
            }
            virtual public bool CheckingInput()
            {
                float a = Vertex1.DistantTo(Vertex2);

                float b = Vertex2.DistantTo(Vertex3);

                float c = Vertex3.DistantTo(Vertex4);

                float d = Vertex4.DistantTo(Vertex1);

                bool check1 = a == c;
                bool check2 = b == d;
                return check1 && check2;
            }
            override public void Input()
            {
                Console.WriteLine("Type the axis of 4 vertexs of " + Name + " *with order:");
                vertex1 = new Point2D();
                vertex2 = new Point2D();
                vertex3 = new Point2D();
                vertex4 = new Point2D();
                Console.WriteLine("1st vertex: ");
                Vertex1.Point2DIn();
                Console.WriteLine("2nd vertex: ");
                Vertex2.Point2DIn();
                Console.WriteLine("3rd vertex: ");
                Vertex3.Point2DIn();
                Console.WriteLine("4rd vertex: ");
                Vertex4.Point2DIn();
                if (CheckingInput())
                {
                    return;
                }
                else
                {
                    Console.WriteLine("They are not a right value, please try again");
                    Input();
                }

            }
            override public void Draw()
            {
                Console.WriteLine(Name + " with 4 vertexes is: ");
                Console.WriteLine("Vertex1: " + Vertex1.Poin2DToString());
                Console.WriteLine("Vertex2: " + Vertex2.Poin2DToString());
                Console.WriteLine("Vertex3: " + Vertex3.Poin2DToString());
                Console.WriteLine("Vertex4: " + Vertex4.Poin2DToString());
            }
            public override float CalcSquare()
            {
                float a = Vertex1.DistantTo(Vertex2);
                float b = Vertex2.DistantTo(Vertex3);
                return a * b;
            }

        }

        public class Square : Rectangle
        {
            override public string Name
            {
                get { return "Square"; }
            }
            public override bool CheckingInput()
            {
                float a = base.Vertex1.DistantTo(base.Vertex2);

                float b = Vertex2.DistantTo(Vertex3);

                float c = Vertex3.DistantTo(Vertex4);

                float d = Vertex4.DistantTo(Vertex1);

                bool check1 = a == b;
                bool check2 = b == c;
                bool check3 = c == d;
                return check1 && check2 && check3;
            }
            override public void Input()
            {
                base.Input();
            }
            override public void Draw()
            {
                base.Draw();
            }
            public override float CalcSquare()
            {
                return base.CalcSquare();
            }

        }

        public class ManageShape
        {
            static int n = 1000;
            static int N { get { return n; } set { n = value; } }
            Shape[] shapes = new Shape[N];
            static int GenerateRandomNumber(int min, int max)
            {
                Random random = new Random();
                int randomNumber = random.Next(min, max + 1);
                return randomNumber;
            }

            public void In()
            {
                Console.WriteLine("The numbers of your shapes: ");
                N = int.Parse(Console.ReadLine());
                for (int i = 0; i < N; i++)
                {
                    int ran = GenerateRandomNumber(1, 4);
                    switch (ran)
                    {
                        case 1:
                            shapes[i] = new Circle();
                            shapes[i].Input();
                            break;
                        case 2:
                            shapes[i] = new Triangle();
                            shapes[i].Input();
                            break;
                        case 3:
                            shapes[i] = new Rectangle();
                            shapes[i].Input();
                            break;
                        case 4:
                            shapes[i] = new Square();
                            shapes[i].Input();
                            break;
                    }

                }
            }
            public void Out()
            {
                
                 for (int i = 0; i < N; i++)
                 {
                      shapes[i].Draw();
                      Console.WriteLine("Square of " + shapes[i].Name + " is: " + shapes[i].CalcSquare());
                 }
             
            }

        }
        static void Main(string[] args)
        {
            ManageShape example = new ManageShape();
            example.In();
            example.Out();
            Console.ReadLine();

        }
    }
}



