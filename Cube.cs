using System;

namespace CubeIntersection
{
    public class Cube : Figure
    {
        private readonly double _edge;

        public Cube(double edge, Point center)
        :base(center)
        {
                _edge = edge;              
               
        }

        public override double getVolume(){
            return Math.Pow(_edge,3);
        } 

        public override void getPositions(){
            _maxXYZ = new Point(_center._x+(_edge/2),_center._y+(_edge/2),_center._z+(_edge/2));
            _minXYZ = new Point(_center._x-(_edge/2),_center._y-(_edge/2),_center._z-(_edge/2));
            
        }
    }
}