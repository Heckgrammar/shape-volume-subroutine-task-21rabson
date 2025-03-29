namespace ShapeAreaCalculatorTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write subroutines to calculate the areas of 
            // Circle 
            // Triangle 
            // Rectangle 
            // Pentagon 
            // Octagon
        }
        static int areaOfRectangle(int length, int width)//Add the parameters
        { 
            return length * width;
        }
        static double areaOfCircle(int radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }
        static double areaOfTriangle(int length, int height)
        {
            return 0.5 * length * height;
        }
        static double areaOfPentagon(int perimeter, int apothem)
        {
            return 0.5 * perimeter * apothem;
        }
        static double areaOfOctagon(int sideLength)
        {
            return 2 * Math.Pow(sideLength, 2) * (1 + Math.Sqrt(2));
        }
    }
}
