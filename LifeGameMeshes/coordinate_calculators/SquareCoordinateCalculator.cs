namespace coordinate_calculators {
  using System;
  using System.Collections.Generic; 

  public class SquareCoordinateCalculator : CoordinateCalculator{
    public override List<Tuple<double, double>> calculate_polygon_coordinates(int i, int j){
      //For meshes SQUARE and OCTOGON_SQUARE
      double x0 = i;
      double x1 = i+1;
      double y0 = j;
      double y1 = j+1;
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
  
    public override bool hasKnight(){
      return true;
    }
  }
}