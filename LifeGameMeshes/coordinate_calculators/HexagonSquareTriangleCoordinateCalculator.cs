namespace coordinate_calculators {

  using System;
  using System.Collections.Generic; 

  public class HexagonSquareTriangleCoordinateCalculator : CoordinateCalculator {
  
    private HexagonCoordinateCalculator hcg;
  
    public HexagonSquareTriangleCoordinateCalculator(){
      this.hcg = new HexagonCoordinateCalculator();
    }
  
    public override List<Tuple<double, double>> calculate_polygon_coordinates(int i, int j){
      //For the meshes HEXAGON_SQUARE_TRIANGLE and DODECAGON_HEXAGON_SQUARE
      int j0 = j/6;
      List<Tuple<double, double>> hexagonPoints = hcg.calculate_polygon_coordinates(i, j0);
      double littleSide = 0.2;
      List<Tuple<double, double>> points = new List<Tuple<double, double>>();
   
      double x0 = hexagonPoints[0].Item1;
      double y0 = hexagonPoints[0].Item2;
      double x1 = hexagonPoints[1].Item1;
      double y1 = hexagonPoints[1].Item2;
      double x2 = hexagonPoints[2].Item1;
      double y2 = hexagonPoints[2].Item2;
      double x3 = hexagonPoints[3].Item1;
      double y3 = hexagonPoints[3].Item2;
      double x4 = hexagonPoints[4].Item1;
      double y4 = hexagonPoints[4].Item2;
      double x5 = hexagonPoints[5].Item1;
      double y5 = hexagonPoints[5].Item2;
      double ox = (x0 + x2 + x4)/3;
      double oy = (y0 + y2 + y4)/3;
      //A kis hatszög koordinátái
      x0 = ox + (x0 - ox) * littleSide;
      y0 = oy + (y0 - oy) * littleSide * 1.75;
      x1 = ox + (x1 - ox) * littleSide;
      y1 = oy + (y1 - oy) * littleSide * 1.75;
      x2 = ox + (x2 - ox) * littleSide;
      y2 = oy + (y2 - oy) * littleSide * 1.75;
      x3 = ox + (x3 - ox) * littleSide;
      y3 = oy + (y3 - oy) * littleSide * 1.75;
      x4 = ox + (x4 - ox) * littleSide;
      y4 = oy + (y4 - oy) * littleSide * 1.75;
      x5 = ox + (x5 - ox) * littleSide;
      y5 = oy + (y5 - oy) * littleSide * 1.75;
      //Az első négyzet másik két csúcsa (ami jó volt)
      double q02 = -(x1 - x0) + y0;
      double q01 = (y1 - y0) + x0;
      double q12 = (x0 - x1) + y1;
      double q11 = -(y0 - y1) + x1;

      //Miért nem lehet kisebbre venni a szélességet?
      double q22 = -(x3 - x2) + y2;
      double q21 = (y3 - y2) + x2;
      double q32 = (x2 - x3) + y3;
      double q31 = -(y2 - y3) + x3;

      //Miért nem lehet ezt lekicsinyíteni?
      double q42 = -(x5 - x4) + y4;
      double q41 = (y5 - y4) + x4;
      double q52 = (x4 - x5) + y5;
      double q51 = -(y4 - y5) + x5;

      if (j % 6 == 0){
        Tuple<double, double> p0 = new Tuple<double, double>(x0, y0);
        Tuple<double, double> p1 = new Tuple<double, double>(x1, y1);
        Tuple<double, double> p2 = new Tuple<double, double>(x2, y2);
        Tuple<double, double> p3 = new Tuple<double, double>(x3, y3);
        Tuple<double, double> p4 = new Tuple<double, double>(x4, y4);
        Tuple<double, double> p5 = new Tuple<double, double>(x5, y5);
        points.Add(p0);
        points.Add(p1);
        points.Add(p2);
        points.Add(p3);
        points.Add(p4);
        points.Add(p5);
    } 
      else if (j % 6 == 1){
        Tuple<double, double> p0 = new Tuple<double, double>(x0, y0);
        Tuple<double, double> p1 = new Tuple<double, double>(x1, y1);
        Tuple<double, double> p2 = new Tuple<double, double>(q11, q12);
        Tuple<double, double> p3 = new Tuple<double, double>(q01, q02);
        points.Add(p0);
        points.Add(p1);
        points.Add(p2);
        points.Add(p3);
      }
      else if (j % 6 == 2){
        double qa02 = -(x2 - x1) + y1;
        double qa01 = (y2 - y1) + x1;
        Tuple<double, double> p0 = new Tuple<double, double>(x1, y1);
        Tuple<double, double> p1 = new Tuple<double, double>(q11, q12);
        Tuple<double, double> p2 = new Tuple<double, double>(qa01, qa02);
        points.Add(p0);
        points.Add(p1);
        points.Add(p2);
      }
      else if (j % 6 == 3){
        Tuple<double, double> p0 = new Tuple<double, double>(x2, y2);
        Tuple<double, double> p1 = new Tuple<double, double>(x3, y3);
        Tuple<double, double> p2 = new Tuple<double, double>(q31, q32);
        Tuple<double, double> p3 = new Tuple<double, double>(q21, q22);
        points.Add(p0);
        points.Add(p1);
        points.Add(p2);
        points.Add(p3);
      }
      else if (j % 6 == 4){
        double qb02 = -(x4 - x3) + y3;
        double qb01 = (y4 - y3) + x3;
        Tuple<double, double> p0 = new Tuple<double, double>(x4, y4);
        Tuple<double, double> p1 = new Tuple<double, double>(q31, q32);
        Tuple<double, double> p2 = new Tuple<double, double>(qb01, qb02);
        points.Add(p0);
        points.Add(p1);
        points.Add(p2);
       }
      else if (j % 6 == 5){
        Tuple<double, double> p0 = new Tuple<double, double>(x4, y4);
        Tuple<double, double> p1 = new Tuple<double, double>(x5, y5);
        Tuple<double, double> p2 = new Tuple<double, double>(q51, q52);
        Tuple<double, double> p3 = new Tuple<double, double>(q41, q42);
        points.Add(p0);
        points.Add(p1);
        points.Add(p2);
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