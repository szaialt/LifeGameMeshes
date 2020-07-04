namespace coordinate_calculators {

  using System;
  using System.Collections.Generic; 

  public class Pentagon11CoordinateCalculator : CoordinateCalculator {

    public override List<Tuple<double, double>> calculate_polygon_coordinates(int i, int j){
      //For the mesh PENTAGON11
      double great_side = Math.Sqrt(5) * 2;
      int j1 = j / 8;
      int j2 = j % 8;
      double small_side = Math.Sqrt(2);
      //Coordinates of middle point
      double x0 = i * great_side;
      double y0 = j1 * great_side;
      double x1 = i * great_side;
      double y1 = j1 * great_side;
      double x2 = i * great_side;
      double y2 = j1 * great_side;
      double x3 = i * great_side;
      double y3 = j1 * great_side;
      double x4 = i * great_side;
      double y4 = j1 * great_side;
      //A második és a harmadik pontot kell elfelezni
      if (j2 == 0){
        x1 = x1 - small_side;
        y4 = y4 - small_side;
        x2 = x1 - small_side/2;
        y2 = y1 - small_side/2;
        x3 = x4 - small_side/2;
        y3 = y4 - small_side/2;
        x2 = (x4 + x2)/2;
      }
      else if (j2 == 1){
        x1 = x1 - small_side;
        y4 = y4 - small_side;
        x2 = x1 - small_side/2;
        y2 = y1 - small_side/2;
        x3 = x4 - small_side/2;
        y3 = y4 - small_side/2;
        x4 = (x4 + x2)/2;
      }
      else if (j2 == 2){
        y1 = y1 - small_side;
        x4 = x4 + small_side;
        x2 = x1 + small_side/2;
        y2 = y1 - small_side/2;
        x3 = x4 + small_side/2;
        y3 = y4 - small_side/2;
        y2 = (y4 + y2)/2;
      }
      else if (j2 == 3){
        y1 = y1 - small_side;
        x4 = x4 + small_side;
        x2 = x1 + small_side/2;
        y2 = y1 - small_side/2;
        x3 = x4 + small_side/2;
        y3 = y4 - small_side/2;
        y4 = (y4 + y2)/2;
      }
      else if (j2 == 4){
        x1 = x1 + small_side;
        y4 = y4 + small_side;
        x2 = x1 + small_side/2;
        y2 = y1 + small_side/2;
        x3 = x4 + small_side/2;
        y3 = y4 + small_side/2;
        x2 = (x4 + x2)/2;
      }
      else if (j2 == 5){
        x1 = x1 + small_side;
        y4 = y4 + small_side;
        x2 = x1 + small_side/2;
        y2 = y1 + small_side/2;
        x3 = x4 + small_side/2;
        y3 = y4 + small_side/2;
        x4 = (x4 + x2)/2;
      }
      else if (j2 == 6){
        y1 = y1 + small_side;
        x4 = x4 - small_side;
        x2 = x1 - small_side/2;
        y2 = y1 + small_side/2;
        x3 = x4 - small_side/2;
        y3 = y4 + small_side/2;
        y2 = (y4 + y2)/2;
      }
      else if (j2 == 7){
        y1 = y1 + small_side;
        x4 = x4 - small_side;
        x2 = x1 - small_side/2;
        y2 = y1 + small_side/2;
        x3 = x4 - small_side/2;
        y3 = y4 + small_side/2;
        y4 = (y4 + y2)/2;
      }
    
      Tuple<double, double> p0 = new Tuple<double, double>(x0, y0);
      Tuple<double, double> p1 = new Tuple<double, double>(x1, y1);
      Tuple<double, double> p2 = new Tuple<double, double>(x2, y2);
      Tuple<double, double> p3 = new Tuple<double, double>(x3, y3);
      Tuple<double, double> p4 = new Tuple<double, double>(x4, y4);
    
      List<Tuple<double, double>> points = new List<Tuple<double, double>>();
      points.Add(p0);
      points.Add(p1);
      points.Add(p2);
      points.Add(p3);
      points.Add(p4);
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