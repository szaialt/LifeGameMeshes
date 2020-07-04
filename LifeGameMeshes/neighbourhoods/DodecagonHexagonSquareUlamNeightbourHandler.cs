namespace neighbourhoods {

  using System.Collections.Generic; 

   //Calculates neighbourhood number of one cell
  public class DodecagonHexagonSquareUlamNeightbourHandler : NeightbourHandler {
  //ULAM neighbourhood for the mesh DODECAGON_HEXAGON_SQUARE
    private HexagonSquareTriangleUlamNeightbourHandler phc;
  
    public DodecagonHexagonSquareUlamNeightbourHandler(){
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
          ;
        }
        else if (j % 6 == 2){
          l = l + matrix[i][j-8];  
          l = l + matrix[i][j-2];
          l = l + matrix[i+1][j-2];  
        }
        else if (j % 6 == 3){
          ;
        }
        else if (j % 6 == 4){
          l = l + matrix[i][j-4];  
          l = l + matrix[i][j+2];
          l = l + matrix[i-1][j+2];  
        }
        else if (j % 6 == 5){
          ; 
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
         ;
        }
        else if (j % 6 == 2){
          l = l + matrix[i][j-8];  
          l = l + matrix[i+1][j-8];
          l = l + matrix[i][j-2];  
        }
        else if (j % 6 == 3){
          ;
        }
        else if (j % 6 == 4){
          l = l + matrix[i][j-4];  
          l = l + matrix[i][j+2];
          l = l + matrix[i-1][j-4];  
        }
        else if (j % 6 == 5){
          ;
        }
      }
      else System.Console.WriteLine("False.");
      return l;
    } 
  }
}