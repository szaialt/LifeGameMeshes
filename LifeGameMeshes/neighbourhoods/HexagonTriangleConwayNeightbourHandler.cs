namespace neighbourhoods {

  using System.Collections.Generic; 

   //Calculates neighbourhood number of one cell
  public class HexagonTriangleConwayNeightbourHandler : NeightbourHandler {
  //CONWAY neighbourhood for the mesh HEXAGON_TRIANGLE1

    private HexagonTriangleUlamNeightbourHandler phc;
  
    public HexagonTriangleConwayNeightbourHandler(){
      phc = new HexagonTriangleUlamNeightbourHandler();
    }

    override public int neightbours_number(ModuloIndexableList<ModuloIndexableList<int> > matrix, int i, int j){
      int l = phc.neightbours_number(matrix, i, j);
      if (i % 2 == 0){
        if (j % 3 == 0){
          l = l + matrix[i-1][j];  
          l = l + matrix[i][j+3];
          l = l + matrix[i+1][j];  
          l = l + matrix[i+1][j-3];
          l = l + matrix[i][j-3];  
          l = l + matrix[i-1][j+3];
        }
        else if (j % 3 == 1){
          l = l + matrix[i-1][j+1];  
          l = l + matrix[i][j+1];
          l = l + matrix[i-1][j+1];  
        }
        else if (j % 3 == 2){
          l = l + matrix[i][j+1];  
          l = l + matrix[i+1][j-2];
          l = l + matrix[i][j-2];  
        }
      }
      else if (i % 2 == 1){
        if (j % 3 == 0){
          l = l + matrix[i-1][j+3];  
          l = l + matrix[i][j+3];
          l = l + matrix[i+1][j+3];  
          l = l + matrix[i+1][j];
          l = l + matrix[i][j-3];  
          l = l + matrix[i-1][j];
        }
        else if (j % 3 == 1){
          l = l + matrix[i-1][j+4];  
          l = l + matrix[i][j+1];
          l = l + matrix[i-1][j+1];  
        }
        else if (j % 3 == 2){
          l = l + matrix[i][j-1];  
          l = l + matrix[i+1][j+2];
          l = l + matrix[i+1][j-1];  
        }
      }
      else System.Console.WriteLine("False.");
      return l;
    } 
  }
}