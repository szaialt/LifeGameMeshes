namespace coordinate_calculators {

  using System;
  using System.Collections.Generic; 

  public class HexagonCoordinateCalculator : CoordinateCalculator {
    public override List<Tuple<double, double>> calculate_polygon_coordinates(int i, int j){
      //For the mesh HEXAGON
      //Unit is radius of excircle
      double incircle_radius = Math.Sqrt(3)/2;
      double x0, y0, x1, y1, x2, y2, x3, y3, x4, y4, x5, y5;
      x0 = i + incircle_radius;
      y0 = 2 * incircle_radius * j - incircle_radius;
      x1 = i + 3*incircle_radius/2;
      y1 = 2 * incircle_radius * j;
      x2 = i + incircle_radius;
      y2 = 2 * incircle_radius * j + incircle_radius;
      x3 = i - incircle_radius - 1;
      y3 = 2 * incircle_radius * j + incircle_radius;
      x4 = i - 3*incircle_radius/2 - 1;
      y4 = 2 * incircle_radius * j;
      x5 = i - incircle_radius - 1;
      y5 = 2 * incircle_radius * j - incircle_radius;
      if (i % 2 == 1){
        y0 = y0 + incircle_radius;
        y1 = y1 + incircle_radius;
        y2 = y2 + incircle_radius;
        y3 = y3 + incircle_radius;
        y4 = y4 + incircle_radius;
        y5 = y5 + incircle_radius;
      }
      Tuple<double, double> p0 = new Tuple<double, double>(x0, y0);
      Tuple<double, double> p1 = new Tuple<double, double>(x1, y1);
      Tuple<double, double> p2 = new Tuple<double, double>(x2, y2);
      Tuple<double, double> p3 = new Tuple<double, double>(x3, y3);
      Tuple<double, double> p4 = new Tuple<double, double>(x4, y4);
      Tuple<double, double> p5 = new Tuple<double, double>(x5, y5);
      List<Tuple<double, double>> points = new List<Tuple<double, double>>();
      points.Add(p0);
      points.Add(p1);
      points.Add(p2);
      points.Add(p3);
      points.Add(p4);
      points.Add(p5);
      return points;
    }
  
    public override bool hasUlam(){
      return true;
    }
  
    public override bool hasConway(){
      return true;
    }
  
    public override bool hasKnight(){
      return true;
    }
  }
}