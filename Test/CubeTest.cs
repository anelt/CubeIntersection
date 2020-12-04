using CubeIntersection;
using NUnit.Framework;


[TestFixture] 
public class CubeTest{


[Test]
public void Cube_isCollindingTrueTest(){    
    
            Cube cubeOne = new Cube(8,new Point(4,4,4));
            Cube cubeTwo = new Cube(8,new Point(6,6,6));
            cubeOne.getPositions();
            cubeTwo.getPositions();

            Operation op = new Operation(cubeOne,cubeTwo);
            bool isColliding=  op.isCollinding();

            Assert.IsTrue(isColliding);

    }
[Test]
public void Cube_isCollindingFalseTest(){    
    
            Cube cubeOne = new Cube(8,new Point(4,4,4));
            Cube cubeTwo = new Cube(7,new Point(20,10,6));
            cubeOne.getPositions();
            cubeTwo.getPositions();

             Operation op  = new Operation(cubeOne,cubeTwo);
            bool isColliding=  op.isCollinding();

            Assert.IsFalse(isColliding);

    }

[Test]
public void Cube_getIntersectedVolumeTest(){    
    
            double intersection=0;
            bool isColliding=  true;
            
            Cube cubeOne = new Cube(8,new Point(4,4,4));
            Cube cubeTwo = new Cube(8,new Point(6,6,6));
            cubeOne.getPositions();
            cubeTwo.getPositions();

            Operation op  = new Operation(cubeOne,cubeTwo);
            
            if(isColliding){
                intersection = op.getIntersectedVolume();
            }

            Assert.AreEqual(216.0,intersection);

    }

}