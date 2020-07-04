namespace coordinate_calculators {
using System;
using System.Collections.Generic; 

public class TriangleCoordinateCalculator : CoordinateCalculator {
  public override List<Tuple<double, double>> calculate_polygon_coordinates(int i, int j){
    //For the mesh TRIANGLE
    double x0 = -1;
    double x1 = -1;
    double x2 = -1;
    double y0 = -1;
    double y1 = -1;
    double y2 = -1;
    //Triangle is \| upside down, 
    if (i % 2 == 0) {
        x0 = i/2;
        y0 = 2 * j - 1;
        x1 = i/2;
        y1 = 2 * j + 1;
        x2 = i/2 + 1;
        y2 = 2 * j;
      }
      //Triangle is |\ up
      else if (i % 2 == 1) {
        x0 = i/2;
        y0 = 2 * j + 1;
        x1 = i/2 + 1;
        y1 = 2 * j;
        x2 = i/2 + 1;
        y2 = 2 * j + 2;
      }
      Tuple<double, double> p0 = new Tuple<double, double>(x0, y0);
      Tuple<double, double> p1 = new Tuple<double, double>(x1, y1);
      Tuple<double, double> p2 = new Tuple<double, double>(x2, y2);
      List<Tuple<double, double>> points = new List<Tuple<double, double>>();
      points.Add(p0);
      points.Add(p1);
      points.Add(p2);
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