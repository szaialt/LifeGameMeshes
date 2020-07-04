namespace coordinate_calculators {

  using System;
  using System.Collections.Generic; 

  public class TiledRectangle1CoordinateCalculator : CoordinateCalculator{

  // ---- 
  // ----
  // ||----
  // ||----
  // --||
  // --||

    public override List<Tuple<double, double>> calculate_polygon_coordinates(int i, int j){
      //For the mesh TILED_RECTANGLE1
      Rectangle1CoordinateCalculator rc = new Rectangle1CoordinateCalculator();
    
      List<Tuple<double, double>> squareCoords = rc.calculate_polygon_coordinates(i/2, j/2);
      Tuple<double, double> nullCoords = squareCoords[0];
      Tuple<double, double> oneCoords = squareCoords[2];
     
      double x0 = nullCoords.Item1 * 2;
      double y0 = nullCoords.Item2 * 2;
      double x1 = oneCoords.Item1 * 2;
      double y1 = oneCoords.Item2 * 2;
    
      if (i % 4 < 2){ // --
        x1 = x0 + 2;  // --
        y1 = y0 + 1;
        if (i % 4  == 0){
          y0 = y0 - 1;
          y1 = y1 - 1;
        }
      }
      else if (i % 4 >= 2){ // ||
        x1 = x0 + 1;        // ||
        y1 = y0 + 2;
        if (i % 4  == 3){
          x0 = x0 - 1;
          x1 = x1 - 1;
        }
      }
      Tuple<double, double> p0 = new Tuple<double, double>(x0, y0);
      Tuple<double, double> p1 = new Tuple<double, double>(x1, y0);
      Tuple<double, double> p2 = new Tuple<double, double>(x1, y1);
      Tuple<double, double> p3 = new Tuple<double, double>(x0, y1);
      List<Tuple<double, double>> points = new List<Tuple<double, double>>();
      points.Add(p0);
      points.Add(p1);
      points.Add(p2);
      points.Add(p3);
      return points;
    }
    
     public override bool hasUlam(){
      return true;
    }
  
    public override bool hasConway(){
      return true;
    }
  
    public override bool hasOblique(){
      return true;
    }
    
  }
}