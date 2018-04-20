namespace Task_3
{
    class Coordinates
    {

        private double x;
        public double X { get => x; set => x = value; }

        private double y;
        public double Y { get => y; set => y = value; }

        private double z;
        public double Z { get => z; set => z = value; }

        public Coordinates(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }
    }
}
