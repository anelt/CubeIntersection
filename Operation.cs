using System;

namespace CubeIntersection
{
    public class Operation : IOperation
    {
       
        Figure _figureOne;
        Figure _figureTwo;

        public Operation(Figure figureOne,Figure figureTwo){
            _figureOne = figureOne;
            _figureTwo = figureTwo;
        }

        public double getIntersectedVolume()
        {
            return  overlap(_figureOne._minXYZ._x,_figureOne._maxXYZ._x,_figureTwo._minXYZ._x,_figureTwo._maxXYZ._x)*
                    overlap(_figureOne._minXYZ._y,_figureOne._maxXYZ._y,_figureTwo._minXYZ._y,_figureTwo._maxXYZ._y) *
                    overlap(_figureOne._minXYZ._z,_figureOne._maxXYZ._z,_figureTwo._minXYZ._z,_figureTwo._maxXYZ._z)
            ;
        }

        public bool isCollinding()
        {
          bool isCollindingInX = difference(_figureOne._minXYZ._x,_figureOne._maxXYZ._x,_figureTwo._minXYZ._x,_figureTwo._maxXYZ._x)>=0;
          bool isCollindingInY = difference(_figureOne._minXYZ._y,_figureOne._maxXYZ._y,_figureTwo._minXYZ._y,_figureTwo._maxXYZ._y)>=0;
          bool isCollindingInZ = difference(_figureOne._minXYZ._z,_figureOne._maxXYZ._z,_figureTwo._minXYZ._z,_figureTwo._maxXYZ._z)>=0;
          return isCollindingInX && isCollindingInY && isCollindingInZ;
        }

        private double overlap(double firstMin, double firstMax, double secondMin, double secondMax){
            return difference(firstMin,firstMax,secondMin,secondMax);
        }

         private double difference (double firstMin, double firstMax, double secondMin, double secondMax){
            return Math.Min(firstMax,secondMax) - Math.Max(firstMin,secondMin);
        }
    }
}