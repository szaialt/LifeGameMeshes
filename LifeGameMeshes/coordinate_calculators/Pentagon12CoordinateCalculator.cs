namespace coordinate_calculators {

  using System;
  using System.Collections.Generic; 

  public class Pentagon12CoordinateCalculator : CoordinateCalculator{

  // |/|--
  //    \\
  // |/|--
  // --|/|
  // \\
  // --|/|

    public override List<Tuple<double, double>> calculate_polygon_coordinates(int i, int j){
      //For the mesh PENTAGON12
      Rectangle2CoordinateCalculator rc = new Rectangle2CoordinateCalculator();
    
      List<Tuple<double, double>> squareCoords = rc.calculate_polygon_coordinates(i/2, j/2);
      Tuple<double, double> nullCoords = squareCoords[0];
      Tuple<double, double> oneCoords = squareCoords[2];
     
      double x0 = nullCoords.Item1;
      double y0 = nullCoords.Item2;
      double x1 = oneCoords.Item1;
      double y1 = oneCoords.Item2;
    
  
      Tuple<double, double> p0 = new Tuple<double, double>(x0, y0);
      Tuple<double, double> p1 = new Tuple<double, double>(x1, y0);
      Tuple<double, double> p2 = new Tuple<double, double>(x1, y1);
      Tuple<double, double> p3 = new Tuple<double, double>(x0, y1);
      List<Tuple<double, double>> points = new List<Tuple<double, double>>();
    
      if (j % 2 == 0){
        points.Add(p0);
        points.Add(p2);
        points.Add(p3);
      }
      else if (j % 2 == 1){
        points.Add(p1);
        points.Add(p2);
        points.Add(p0);
      }


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