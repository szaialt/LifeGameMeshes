namespace coordinate_calculators {

  using System;
  using System.Collections.Generic; 

  public class Pentagon10CoordinateCalculator : CoordinateCalculator{
    public override List<Tuple<double, double>> calculate_polygon_coordinates(int i, int j){
      //For the mesh PENTAGON10
      SquareCoordinateCalculator rc = new SquareCoordinateCalculator();
    
      List<Tuple<double, double>> squareCoords = rc.calculate_polygon_coordinates(i/4, j/4);
      Tuple<double, double> nullCoords = squareCoords[0];
      Tuple<double, double> oneCoords = squareCoords[2];
   
      double x0 = nullCoords.Item1 * 2;
      double y0 = nullCoords.Item2 * 2;
      double x1 = oneCoords.Item1 * 2;
      double y1 = oneCoords.Item2 * 2;
      double x05 = (x0 + x1)/2;
      double y05 = (y0 + y1)/2;
  
      Tuple<double, double> p0 = new Tuple<double, double>(x0, y0);
      Tuple<double, double> p1 = new Tuple<double, double>(x1, y0);
      Tuple<double, double> p2 = new Tuple<double, double>(x1, y1);
      Tuple<double, double> p3 = new Tuple<double, double>(x0, y1);
      Tuple<double, double> p4 = new Tuple<double, double>(x05, y05);
      Tuple<double, double> p5 = new Tuple<double, double>(x05, y0);
      Tuple<double, double> p6 = new Tuple<double, double>(x05, y1);
      List<Tuple<double, double>> points = new List<Tuple<double, double>>();
      if (i % 2 == 0){
        if (j % 6 == 0){
          points.Add(p0);
          points.Add(p4);
          points.Add(p3);
        }
        else if (j % 6 == 1){
          points.Add(p1);
          points.Add(p2);
          points.Add(p4);
        }
        else if (j % 6 == 2){
          points.Add(p4);
          points.Add(p2);
          points.Add(p3);
        }
        else if (j % 6 == 3){
          points.Add(p0);
          points.Add(p4);
          points.Add(p3);
        }
        else if (j % 6 == 4){
          points.Add(p0);
          points.Add(p5);
          points.Add(p6);
          points.Add(p3);
        }
        else if (j % 6 == 5){
          points.Add(p5);
          points.Add(p1);
          points.Add(p2);
          points.Add(p6);
        }
      }
      else if (i % 2 == 1){
        if (j % 6 == 0){
          points.Add(p0);
          points.Add(p5);
          points.Add(p6);
          points.Add(p3);
        }
        else if (j % 6 == 1){
          points.Add(p5);
          points.Add(p1);
          points.Add(p2);
          points.Add(p6);
        }
        else if (j % 6 == 2){
          points.Add(p0);
          points.Add(p4);
          points.Add(p3);
        }
        else if (j % 6 == 3){
          points.Add(p1);
          points.Add(p2);
          points.Add(p4);
        }
        else if (j % 6 == 4){
          points.Add(p4);
          points.Add(p2);
          points.Add(p3);
        }
        else if (j % 6 == 5){
          points.Add(p0);
          points.Add(p4);
          points.Add(p3);
        }
      }
    
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