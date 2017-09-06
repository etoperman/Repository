namespace CSharp7
{
    using System.Diagnostics;
    using System.Drawing;

    public class Program
    {
        static void Main(string[] args)
        {
        }

        public void PrintCoordinates(Point p)
        {
            int x, y;   //Have to "predeclare"
            GetCoordinates(p, out x, out y);
            Debug.WriteLine( $"({x}, {y})" );
        }

        public void GetCoordinates(Point p, out int x, out int y)
        {
            x = 1;
            y = 1;
        }
    }
}