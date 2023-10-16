using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Bai24
{
    internal class Program
    {
        public class Point2D
        {
            float x;
            public float X { get { return x; } set { x = value; } }
            float y;  
            public float Y { get { return y; } set { y = value; } }  
            public void GenerateRan2D()
            {
                Random random= new Random();
                X = random.Next(0, 200);
                Y = random.Next(0, 200);
            }
        }
        static void Main(string[] args)
        {
            Form testForm = new Form();
            testForm.Paint += new PaintEventHandler(testForm_paint);
            Application.Run(testForm);
            Console.ReadLine();
        }

        public static void testForm_paint(Object sender, PaintEventArgs pea)
        {
            Form f = (Form)sender;
            Graphics g = pea.Graphics;
            Point2D point = new Point2D();
            point.GenerateRan2D();
            g.DrawString("Paint Event", f.Font, Brushes.Black, point.X, point.Y);
        }
        



    }
}
