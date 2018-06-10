namespace Task_2
{
    public class Rectangle
    {
        /// <summary>
        /// First length of rectangle
        /// </summary>
        private double side1;

        /// <summary>
        /// Second length of rectangle
        /// </summary>
        private double side2;

        /// <summary>
        /// Property returns area of rectangle 
        /// </summary>
        public double Area => AreaCalculator();

        /// <summary>
        /// Property returns perimeter of rectangle 
        /// </summary>
        public double Perimeter => PerimeterCalculator();

        /// <summary>
        /// Create rectangle
        /// </summary>
        /// <param name="side2">Length of first side</param>
        /// <param name="side2">Length of second side</param>
        public Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }

        /// <summary>
        /// Method which calculates area of rectangle
        /// </summary>
        /// <returns>Area</returns>
        public double AreaCalculator()
        {
            return side1 * side2;
        }

        /// <summary>
        /// Method which calculates perimeter of rectangle
        /// </summary>
        /// <returns>Perimeter</returns>
        public double PerimeterCalculator()
        {
            return 2 * (side1 + side2);
        }
    }
}