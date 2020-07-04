namespace coordinate_calculators {

  using System;
  using System.Collections.Generic; 

  public class Rectangle2CoordinateCalculator : CoordinateCalculator{

  // ||--
  // ||--
  // --||
  // --||

    public override List<Tuple<double, double>> calculate_polygon_coordinates(int i, int j){
      // For the mesh RECTANGLE2
      double x0 = i * 2;
      double y0 = (j/2) * 2;
      double x1 = x0;
      double y1 = y0;
      if ((i + j/2) % 2 == 0){ // --
        x1 = x0 + 2;           // --
        y1 = y0 + 1;
      }
      else if ((i + j/2) % 2 == 1){ // ||
        x1 = x0 + 1;                // ||
        y1 = y0 + 2;
      }
      if (j % 2 == 1){
        if ((i + j/2) % 2 == 0){ // --
          y0 = y0 + 1;           // --
          y1 = y1 + 1;
        }
      else if ((i + j/2) % 2 == 1){ // ||
          x0 = x0 + 1;              // ||
          x1 = x1 + 1;
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
    
  }
}