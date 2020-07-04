namespace coordinate_calculators {

  using System;
  using System.Collections.Generic; 

  public class Kite5CoordinateCalculator : CoordinateCalculator {
    public override List<Tuple<double, double>> calculate_polygon_coordinates(int i, int j){
      //For the mesh KITE5
      double incircle_radius = Math.Sqrt(3)/2;
      double x0, y0, x1, y1, x2, y2, x3, y3, x4, y4, x5, y5;
    
      int t = 0;

      if (j % 6 == 0) t = -100;
      else if (j % 6 == 1) t = 0;
      else if (j % 6 == 2) t = -20;
      else if (j % 6 == 3) t = -40;
      else if (j % 6 == 4) t = -60;
      else if (j % 6 == 5) t = -80;
    
      int u = 0;
      if (j % 6 == 0) u = -120;
      else if (j % 6 == 1) u = -90;
      else if (j % 6 == 2) u = -120;
      else if (j % 6 == 3) u = -80;
      else if (j % 6 == 4) u = -120;
      else if (j % 6 == 5) u = -150;    
    
      x0 = 2 * i + incircle_radius + u * incircle_radius;
      y0 = 2 * incircle_radius * j - incircle_radius + t * incircle_radius;
      x1 = 2 * i + 3*incircle_radius/2 + u * incircle_radius;
      y1 = 2 * incircle_radius * j + t * incircle_radius;
      x2 = 2 * i + incircle_radius + u * incircle_radius;
      y2 = 2 * incircle_radius * j + incircle_radius + t * incircle_radius;
      x3 = 2 * i - incircle_radius - 1 + u * incircle_radius;
      y3 = 2 * incircle_radius * j + incircle_radius + t * incircle_radius;
      x4 = 2 * i - 3*incircle_radius/2 - 1 + u * incircle_radius;
      y4 = 2 * incircle_radius * j + t * incircle_radius;
      x5 = 2 * i - incircle_radius - 1 + u * incircle_radius;
      y5 = 2 * incircle_radius * j - incircle_radius + t * incircle_radius;
      if (i % 2 == 1){
        y0 = y0 + 6*incircle_radius;
        y1 = y1 + 6*incircle_radius;
        y2 = y2 + 6*incircle_radius;
        y3 = y3 + 6*incircle_radius;
        y4 = y4 + 6*incircle_radius;
        y5 = y5 + 6*incircle_radius;
      }
      double xm = (x0 + x1 + x2 + x3 + x4 + x5)/6;
      double ym = (y0 + y1 + y2 + y3 + y4 + y5)/6;
      double x50 = (x5 + x0)/2;
      double y50 = (y5 + y0)/2;
      double x01 = (x1 + x0)/2;
      double y01 = (y1 + y0)/2;
      double x12 = (x1 + x2)/2;
      double y12 = (y1 + y2)/2;
      double x23 = (x3 + x2)/2;
      double y23 = (y3 + y2)/2;
      double x34 = (x3 + x4)/2;
      double y34 = (y3 + y4)/2;
      double x45 = (x5 + x4)/2;
      double y45 = (y5 + y4)/2;
     
      Tuple<double, double> p0 = new Tuple<double, double>(x0, y0);
      Tuple<double, double> p1 = new Tuple<double, double>(x1, y1);
      Tuple<double, double> p2 = new Tuple<double, double>(x2, y2);
      Tuple<double, double> p3 = new Tuple<double, double>(x3, y3);
      Tuple<double, double> p4 = new Tuple<double, double>(x4, y4);
      Tuple<double, double> p5 = new Tuple<double, double>(x5, y5);
      Tuple<double, double> p50 = new Tuple<double, double>(x50, y50);
      Tuple<double, double> p01 = new Tuple<double, double>(x01, y01);
      Tuple<double, double> p12 = new Tuple<double, double>(x12, y12);
      Tuple<double, double> p23 = new Tuple<double, double>(x23, y23);
      Tuple<double, double> p34 = new Tuple<double, double>(x34, y34);
      Tuple<double, double> p45 = new Tuple<double, double>(x45, y45);
      Tuple<double, double> pm = new Tuple<double, double>(xm, ym);
      List<Tuple<double, double>> points = new List<Tuple<double, double>>();
      if (j % 6 == 0){
        points.Add(p50);
        points.Add(p0);
        points.Add(p01);
        points.Add(pm);
      }
      else if (j % 6 == 1){
        points.Add(p01);
        points.Add(p1);
        points.Add(p12);
        points.Add(pm);
      }
      else if (j % 6 == 2){
        points.Add(p12);
        points.Add(p2);
        points.Add(p23);
        points.Add(pm);
      }
      else if (j % 6 == 3){
        points.Add(p23);
        points.Add(p3);
        points.Add(p34);
        points.Add(pm);
      }
      else if (j % 6 == 4){
        points.Add(p34);
        points.Add(p4);
        points.Add(p45);
        points.Add(pm);
      }
      else if (j % 6 == 5){
        points.Add(p45);
        points.Add(p5);
        points.Add(p50);
        points.Add(pm);
      }
      return points;
    }
    
    public override bool hasUlam(){
      return true;
    }
  
    public override bool hasConway(){
      return true;
    }
    
    public override bool hasGreatConway(){
      return true;
    }
  
    public override bool hasOblique(){
      return true;
    }
  
  }
}