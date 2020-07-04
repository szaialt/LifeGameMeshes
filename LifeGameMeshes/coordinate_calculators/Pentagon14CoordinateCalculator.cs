namespace coordinate_calculators {

  using System;
  using System.Collections.Generic; 

  public class Pentagon14CoordinateCalculator : CoordinateCalculator {
  
    private HexagonCoordinateCalculator hgc;
 
    public Pentagon14CoordinateCalculator(){
      this.hgc = new HexagonCoordinateCalculator();
    }

    public override List<Tuple<double, double>> calculate_polygon_coordinates(int i, int j){
      //For the mesh PENTAGON14
      List<Tuple<double, double>> hexagonPoints = hgc.calculate_polygon_coordinates(i, j/4);
      //points of teh hexagon
      double xh0 = hexagonPoints[0].Item1;               //        d0
      double yh0 = hexagonPoints[0].Item2;               //    h0------h1
      double xh1 = hexagonPoints[1].Item1;               //  d5 / \   /\d1
      double yh1 = hexagonPoints[1].Item2;               //    /   \ /  \
      double xh2 = hexagonPoints[2].Item1;               //h5 /     |    \h2
      double yh2 = hexagonPoints[2].Item2;               //   \     |    /
      double xh3 = hexagonPoints[3].Item1;               //    \   / \  /
      double yh3 = hexagonPoints[3].Item2;               // d4  \ /   \/d2
      double xh4 = hexagonPoints[4].Item1;               //   h4 ------h3
      double yh4 = hexagonPoints[4].Item2;               //        d3
      double xh5 = hexagonPoints[5].Item1;
      double yh5 = hexagonPoints[5].Item2;
      //middle points
      double xd0 = (xh0 + xh1)/2.0;
      double yd0 = (yh0 + yh1)/2.0;
      double xd1 = (xh1 + xh2)/2.0;
      double yd1 = (yh1 + yh2)/2.0;
      double xd2 = (xh2 + xh3)/2.0;
      double yd2 = (yh2 + yh3)/2.0;
      double xd4 = (xh4 + xh5)/2.0;
      double yd4 = (yh4 + yh5)/2.0;
    
    
      double x0 = 0;
      double y0 = 0;
      double x1 = 0;
      double y1 = 0;
      double x2 = 0;
      double y2 = 0;
      double x3 = 0;
      double y3 = 0;
      double x4 = 0;
      double y4 = 0;
      
      if ((i % 2 == 1) && (j % 4 == 2)) {
        // division in another direction
        x0 = xh0; 
        y0 = yh0;
        x1 = xh1; 
        y1 = yh1;
        x2 = xh2; 
        y2 = yh2;
        x3 = xd2; 
        y3 = yd2;
        x4 = xd4; 
        y4 = yd4;
      } 
      if ((i % 2 == 1) && (j % 4 == 3)) {
        // division in another direction
        x0 = xh3; 
        y0 = yh3;
        x1 = xh4; 
        y1 = yh4;
        x2 = xh5; 
        y2 = yh5;
        x3 = xd4; 
        y3 = yd4;
        x4 = xd2; 
        y4 = yd2;
      }
      else {
      // division in majority direction
        if (j % 2 == 0){
          x0 = xh1; 
          y0 = yh1;
          x1 = xh2; 
          y1 = yh2;
          x2 = xh3; 
          y2 = yh3;
          x3 = xd1; 
          y3 = yd1;
          x4 = xd0; 
          y4 = yd0;
        }
        if (j % 2 == 1){
        // division in majority direction
          x0 = xh4; 
          y0 = yh4;
          x1 = xh5; 
          y1 = yh5;
          x2 = xh0; 
          y2 = yh0;
          x3 = xd0; 
          y3 = yd0;
          x4 = xd1; 
          y4 = yd1;
        }
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
    
  }
}