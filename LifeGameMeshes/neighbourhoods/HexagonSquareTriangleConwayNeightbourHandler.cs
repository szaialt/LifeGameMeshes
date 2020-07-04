namespace neighbourhoods {

  using System.Collections.Generic; 

   //Calculates neighbourhood number of one cell
  public class HexagonSquareTriangleConwayNeightbourHandler : NeightbourHandler {
   //CONWAY neighbourhood for the mesh HEXAGON_SQUARE_TRIANGLE

    private HexagonSquareTriangleUlamNeightbourHandler phc;
  
    public HexagonSquareTriangleConwayNeightbourHandler(){
      phc = new HexagonSquareTriangleUlamNeightbourHandler();
    }

    override public int neightbours_number(ModuloIndexableList<ModuloIndexableList<int> > matrix, int i, int j){
      int l = phc.neightbours_number(matrix, i, j);
      if (i % 2 == 0){
        if (j % 6 == 0){
          l = l + matrix[i][j-2];  
          l = l + matrix[i][j+2];
          l = l + matrix[i+1][j+4];  
          l = l + matrix[i][j+8];
          l = l + matrix[i][j+4];  
          l = l + matrix[i-1][j+8];
        }
        else if (j % 6 == 1){
          l = l + matrix[i][j-4];  
          l = l + matrix[i+1][j+4];
          l = l + matrix[i-1][j+2];
          l = l + matrix[i][j-2];
        }
        else if (j % 6 == 2){
          l = l + matrix[i][j-8];  
          l = l + matrix[i][j-2];
          l = l + matrix[i+1][j-2];  
        }
        else if (j % 6 == 3){
          l = l + matrix[i+1][j+1];  
          l = l + matrix[i+1][j+4];
          l = l + matrix[i][j+4];  
          l = l + matrix[i+1][j+8];
        }
        else if (j % 6 == 4){
          l = l + matrix[i][j-4];  
          l = l + matrix[i][j+2];
          l = l + matrix[i-1][j+2];  
        }
        else if (j % 6 == 5){
          l = l + matrix[i-1][j-2];  
          l = l + matrix[i-1][j+2];
          l = l + matrix[i][j+2];  
          l = l + matrix[i-1][j+4]; 
        }
      }
      else if (i % 2 == 1){
        if (j % 6 == 0){
          l = l + matrix[i][j+2];  
          l = l + matrix[i+1][j-2];
          l = l + matrix[i][j-2];  
          l = l + matrix[i][j+8];
          l = l + matrix[i][j+4];  
          l = l + matrix[i-1][j+2];
        }
        else if (j % 6 == 1){
          l = l + matrix[i][j-4];  
          l = l + matrix[i+1][j-2];
          l = l + matrix[i-1][j-4];  
          l = l + matrix[i][j-2];
        }
        else if (j % 6 == 2){
          l = l + matrix[i][j-8];  
          l = l + matrix[i+1][j-8];
          l = l + matrix[i][j-2];  
        }
        else if (j % 6 == 3){
          l = l + matrix[i+1][j-4];  
          l = l + matrix[i+1][j-2];
          l = l + matrix[i+1][j+2];  
          l = l + matrix[i][j+4];
        }
        else if (j % 6 == 4){
          l = l + matrix[i][j-4];  
          l = l + matrix[i][j+2];
          l = l + matrix[i-1][j-4];  
        }
        else if (j % 6 == 5){
          l = l + matrix[i-1][j-8];  
          l = l + matrix[i][j+2];
          l = l + matrix[i-1][j-2];  
          l = l + matrix[i-1][j-3];
        }
      }
      else System.Console.WriteLine("False.");
      return l;
    } 
  }
}