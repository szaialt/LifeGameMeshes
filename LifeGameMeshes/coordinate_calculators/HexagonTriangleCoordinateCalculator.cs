namespace coordinate_calculators {

  using System;
  using System.Collections.Generic; 

  public class HexagonTriangleCoordinateCalculator : CoordinateCalculator {
    private SquareCoordinateCalculator sgc;
 
    public HexagonTriangleCoordinateCalculator(){
      this.sgc = new SquareCoordinateCalculator();
    }

    public override List<Tuple<double, double>> calculate_polygon_coordinates(int i, int j){
      //For meshes HEXAGON_TRIANGLE1 and DODECAGON_TRIANGLE
      List<Tuple<double, double>> squarePoints = sgc.calculate_polygon_coordinates(i, (j + 1)/3);
      //négyszögpontok
                   //    s0       d0       s1
                   //    ------------------
                   //    |          \     |
                   //    |           \  1 |
                   //    |            \   |
                   //  d3|\            \  |
                   //    | \     0      \ |d1
                   //    |  \             |
                   //    | 2 \            |
                   //    |    \           |
                   // s3 ------------------s2
                   //         d2
      double xs0 = squarePoints[0].Item1;               
      double ys0 = squarePoints[0].Item2;               
      double xs1 = squarePoints[1].Item1;              
      double ys1 = squarePoints[1].Item2;              
      double xs2 = squarePoints[2].Item1;           
      double ys2 = squarePoints[2].Item2;               
      double xs3 = squarePoints[3].Item1;               
      double ys3 = squarePoints[3].Item2;  
    
      //felezőpontok
      double xd0 = (xs0 + xs1)/2.0;
      double yd0 = (ys0 + ys1)/2.0;
      double xd1 = (xs1 + xs2)/2.0;
      double yd1 = (ys1 + ys2)/2.0;
      double xd2 = (xs2 + xs3)/2.0;
      double yd2 = (ys2 + ys3)/2.0;
      double xd3 = (xs3 + xs0)/2.0;
      double yd3 = (ys3 + ys0)/2.0;
    
      Tuple<double, double> p0 = new Tuple<double, double>(xd0, yd0);
      Tuple<double, double> p1 = new Tuple<double, double>(xd1, yd1);
      Tuple<double, double> p2 = new Tuple<double, double>(xd2, yd2);
      Tuple<double, double> p3 = new Tuple<double, double>(xd3, yd3);
    
      List<Tuple<double, double>> points = new List<Tuple<double, double>>();
    
      if (j % 3 == 0){
        points.Add(p0);
        points.Add(p1);
        points.Add(squarePoints[2]);
        points.Add(p2);
        points.Add(p3);
        points.Add(squarePoints[0]);
      }
      else if (j % 3 == 1){
        points.Add(p0);
        points.Add(squarePoints[1]);
        points.Add(p1);
      }
      else if (j % 3 == 2){
        //h2, h3, h4
        points.Add(p2);
        points.Add(squarePoints[3]);
        points.Add(p3);
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