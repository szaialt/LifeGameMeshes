namespace coordinate_calculators {

  using System;
  using System.Collections.Generic; 

  public class Pentagon1CoordinateCalculator : CoordinateCalculator {
    public override List<Tuple<double, double>> calculate_polygon_coordinates(int i, int j){
      // For the mesh PENTAGON1
      // Left and right are separated
      double incircle_radius = Math.Sqrt(3)/2;
      List<Tuple<double, double>> points = new List<Tuple<double, double>>();

      if (j % 2 == 0){
        double x1 = i - incircle_radius - 1;
        double y1 = 2 * incircle_radius * j + incircle_radius;
        double x2 = i - 3*incircle_radius/2 - 1;
        double y2 = 2 * incircle_radius * j;
        double x3 = i - incircle_radius - 1;
        double y3 = 2 * incircle_radius * j - incircle_radius;
        if (i % 2 == 1){
          y1 = y1 + incircle_radius;
          y2 = y2 + incircle_radius;
          y3 = y3 + incircle_radius;
        }
        double x4 = x3 + incircle_radius/4;
        double y4 = y3;
        double x0 = x1 + incircle_radius/4;
        double y0 = y1;
      
        Tuple<double, double> p1 = new Tuple<double, double>(x1, y1);
        Tuple<double, double> p2 = new Tuple<double, double>(x2, y2);
        Tuple<double, double> p3 = new Tuple<double, double>(x3, y3);
    
        Tuple<double, double> p4 = new Tuple<double, double>(x4, y4);
        Tuple<double, double> p0 = new Tuple<double, double>(x0, y0);
    
        //left
        points.Add(p0);
        points.Add(p1);
        points.Add(p2);
        points.Add(p3);
        points.Add(p4);
            
      }
      else if (j % 2 == 1){
        double x1 = i + incircle_radius;
        double y1 = 2 * incircle_radius * j - incircle_radius;
        double x2 = i + 3*incircle_radius/2;
        double y2 = 2 * incircle_radius * j;
        double x3 = i + incircle_radius;
        double y3 = 2 * incircle_radius * j + incircle_radius;
        if (i % 2 == 1){
          y1 = y1 + incircle_radius;
          y2 = y2 + incircle_radius;
          y3 = y3 + incircle_radius;
        }
        double x0 = x3 - incircle_radius/4;
        double y0 = y3;
        double x4 = x1 - incircle_radius/4;
        double y4 = y1;
      
        Tuple<double, double> p1 = new Tuple<double, double>(x1, y1);
        Tuple<double, double> p2 = new Tuple<double, double>(x2, y2);
        Tuple<double, double> p3 = new Tuple<double, double>(x3, y3);
    
        Tuple<double, double> p0 = new Tuple<double, double>(x0, y0);
        Tuple<double, double> p4 = new Tuple<double, double>(x4, y4);
    
        //right
        points.Add(p0);
        points.Add(p1);
        points.Add(p2);
        points.Add(p3);
        points.Add(p4);
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