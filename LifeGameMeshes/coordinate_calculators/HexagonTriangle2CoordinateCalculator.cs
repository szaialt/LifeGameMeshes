namespace coordinate_calculators {

  using System;
  using System.Collections.Generic; 
  using System.Linq;
  public class HexagonTriangle2CoordinateCalculator : CoordinateCalculator {

    TriangleCoordinateCalculator thc;

    public HexagonTriangle2CoordinateCalculator(){
      this.thc = new TriangleCoordinateCalculator();
    }

    public override List<Tuple<double, double>> calculate_polygon_coordinates(int i, int j){
      // For the mesh HEXAGON_TRIANGLE2
      int j0 = j / 9;
      int a = 6 * j0 + 2 * i;
      int b = 1 + 2 * i + (i + j0)/2;
    
      //       -----
      //  t5  /\t0 /\ t1
      //     /__\_/__\
      //     \  / \  / t2
      //  t4  \/ t3\/
      //       -----
    
      if ((i + j0) % 2 == 0){
        if (j % 9 == 0){
          List<Tuple<double, double>> t0 = thc.calculate_polygon_coordinates(a, b);
          List<Tuple<double, double>> t1 = thc.calculate_polygon_coordinates(a+1, b);
          List<Tuple<double, double>> t2 = thc.calculate_polygon_coordinates(a+2, b);
          List<Tuple<double, double>> t3 = thc.calculate_polygon_coordinates(a+3, b);
          List<Tuple<double, double>> t4 = thc.calculate_polygon_coordinates(a+2, b-1);
          List<Tuple<double, double>> t5 = thc.calculate_polygon_coordinates(a+1, b-1);
        
          List<List<Tuple<double, double>>> lxs = new List<List<Tuple<double, double>>>();

          lxs.Add(t0);
          lxs.Add(t1);
          lxs.Add(t2);
          lxs.Add(t3);
          lxs.Add(t4);
          lxs.Add(t5);
          List<Tuple<double, double>> list = lxs.SelectMany(p => p).ToList();
          return list;
        }
        else if (j % 9 == 1){
          return thc.calculate_polygon_coordinates(a-1, b);
        }
        else if (j % 9 == 2){
          return thc.calculate_polygon_coordinates(a, b+1);
        }
        else if (j % 9 == 3){
          return thc.calculate_polygon_coordinates(a+3, b+1);
        }
        else if (j % 9 == 4){
          return thc.calculate_polygon_coordinates(a+4, b);
        }
        else if (j % 9 == 5){
          return thc.calculate_polygon_coordinates(a+3, b-1);
        }
        else if (j % 9 == 6){
          return thc.calculate_polygon_coordinates(a, b-1);
        }
        else if (j % 9 == 7){
          return thc.calculate_polygon_coordinates(a+4, b+1);
        }
        else if (j % 9 == 8){
          return thc.calculate_polygon_coordinates(a+5, b-1);
        }
      }
      else if ((i + j0) % 2 == 1){
        if (j % 9 == 0){
          List<Tuple<double, double>> t0 = thc.calculate_polygon_coordinates(a, b);
          List<Tuple<double, double>> t1 = thc.calculate_polygon_coordinates(a+1, b+1);
          List<Tuple<double, double>> t2 = thc.calculate_polygon_coordinates(a+2, b+1);
          List<Tuple<double, double>> t3 = thc.calculate_polygon_coordinates(a+3, b);
          List<Tuple<double, double>> t4 = thc.calculate_polygon_coordinates(a+2, b);
          List<Tuple<double, double>> t5 = thc.calculate_polygon_coordinates(a+1, b);

          List<List<Tuple<double, double>>> lxs = new List<List<Tuple<double, double>>>();

          lxs.Add(t0);
          lxs.Add(t1);
          lxs.Add(t2);
          lxs.Add(t3);
          lxs.Add(t4);
          lxs.Add(t5);
          List<Tuple<double, double>> list = lxs.SelectMany(p => p).ToList();
          return list;
        }
        else if (j % 9 == 1){
          return thc.calculate_polygon_coordinates(a-1, b);
        }
        else if (j % 9 == 2){
          return thc.calculate_polygon_coordinates(a, b+1);
        }
        else if (j % 9 == 3){
          return thc.calculate_polygon_coordinates(a+3, b+1);
        }
        else if (j % 9 == 4){
          return thc.calculate_polygon_coordinates(a+4, b);
        }
        else if (j % 9 == 5){
          return thc.calculate_polygon_coordinates(a+3, b-1);
        }
        else if (j % 9 == 6){
          return thc.calculate_polygon_coordinates(a, b-1);
        }
        else if (j % 9 == 7){
          return thc.calculate_polygon_coordinates(a+4, b+1);
        }
        else if (j % 9 == 8){
          return thc.calculate_polygon_coordinates(a+5, b);
        }
      }
      return new List<Tuple<double, double>>();
    }
    
    public override bool hasUlam(){
      return true;
    }
  
    public override bool hasConway(){
      return true;
    }
    
  }
} 