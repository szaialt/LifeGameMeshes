namespace coordinate_calculators {

  using System;
  using System.Collections.Generic; 

  public class SquareTriangle1CoordinateCalculator : CoordinateCalculator {
  //Miért nem találja????
    private HexagonCoordinateCalculator hgc;
 
    public SquareTriangle1CoordinateCalculator(){
      this.hgc = new HexagonCoordinateCalculator();
    }

    public override List<Tuple<double, double>> calculate_polygon_coordinates(int i, int j){
      //For the mesh SQUARE_TRIANGLE1
      List<Tuple<double, double>> hexagonPoints = hgc.calculate_polygon_coordinates(i, j/3);
      //points of hexagon
                   //        
                   //    h1------h2
                   //     /    /  \
                   //    / 0 /     \
                   //h0 /  / 1    / \h3
                   //   \/      /   /
                   //    \    /    /
                   //     \ /  2  /
                   //   h5 ------h4
                   //        
    
      List<Tuple<double, double>> points = new List<Tuple<double, double>>();
    
      if (j % 3 == 0){
        //h3, h4, h5
        points.Add(hexagonPoints[3]);
        points.Add(hexagonPoints[4]);
        points.Add(hexagonPoints[5]);
      
      }
      else if (j % 3 == 1){
        //h1 h4 h5 h0
        points.Add(hexagonPoints[1]);
        points.Add(hexagonPoints[4]);
        points.Add(hexagonPoints[5]);
        points.Add(hexagonPoints[0]);
      }
      else if (j % 3 == 2){
        //h0, h1, h2
        points.Add(hexagonPoints[0]);
        points.Add(hexagonPoints[1]);
        points.Add(hexagonPoints[2]);
      } 
    
      return points;
    }
    
    public override bool hasUlam(){
      return true;
    }
  
    public override bool hasConway(){
      return true;
    }
    
  }
  
}