namespace CubeIntersection
{
    
 
    
    public abstract class Figure
    {
        public Point _center;
        public Point _maxXYZ;
        public Point _minXYZ;

        public Figure(Point center){
            _center= center;
        }

        public abstract double getVolume();
        public abstract void getPositions();
    }
}