namespace neighbourhoods {

  using System.Collections.Generic; 

  public class HexagonSquareTriangleUlamNeightbourHandler : NeightbourHandler {
  //ULAM neighbourhood for the mesh HEXAGON_SQUARE_TRIANGLE

     //Calculates neighbourhood number of one cell
    override public int neightbours_number(ModuloIndexableList<ModuloIndexableList<int> > matrix, int i, int j){
      int l = 0;
      if (i % 2 == 0){
        if (j % 6 == 0){
          l = l + matrix[i][j+1];  
          l = l + matrix[i+1][j+5];
          l = l + matrix[i][j+3];
          l = l + matrix[i][j+7];
          l = l + matrix[i][j+5];
          l = l + matrix[i-1][j+3];
        }
        else if (j % 6 == 1){
          l = l + matrix[i][j-7];  
          l = l + matrix[i][j+1];
          l = l + matrix[i][j-1];
          l = l + matrix[i][j-3];
        }
        else if (j % 6 == 2){
          l = l + matrix[i][j-5];  
          l = l + matrix[i+1][j+3];
          l = l + matrix[i][j-1];
        }
        else if (j % 6 == 3){
          l = l + matrix[i+1][j+1];  
          l = l + matrix[i+1][j+3];
          l = l + matrix[i+1][j+8];
          l = l + matrix[i][j-1];
        }
        else if (j % 6 == 4){
          l = l + matrix[i][j+1];  
          l = l + matrix[i][j+3];
          l = l + matrix[i-1][j+5];
        }
        else if (j % 6 == 5){
          l = l + matrix[i][j-5];  
          l = l + matrix[i][j-1];
          l = l + matrix[i-1][j+1];
          l = l + matrix[i-1][j+3];
        }
      }
      else if (i % 2 == 1){
        if (j % 6 == 0){
          l = l + matrix[i][j+1];
          l = l + matrix[i+1][j-1];
          l = l + matrix[i][j+3];
          l = l + matrix[i][j+7];
          l = l + matrix[i][j+5];
          l = l + matrix[i-1][j-3];
        }
        else if (j % 6 == 1){
          l = l + matrix[i][j-7];
          l = l + matrix[i][j+1];  
          l = l + matrix[i][j-1];
          l = l + matrix[i][j-3];
        }
        else if (j % 6 == 2){
          l = l + matrix[i][j-5];  
          l = l + matrix[i+1][j-3];
          l = l + matrix[i][j-1];
        }
        else if (j % 6 == 3){
          l = l + matrix[i+1][j-5];
          l = l + matrix[i][j+5];
          l = l + matrix[i+1][j-3];
          l = l + matrix[i][j-3];
        }
        else if (j % 6 == 4){
          l = l + matrix[i][j+3];
          l = l + matrix[i-1][j-1];  
          l = l + matrix[i][j+1];
        }
        else if (j % 6 == 5){
          l = l + matrix[i][j-5];  
          l = l + matrix[i-1][j-5];
          l = l + matrix[i-1][j-3];
          l = l + matrix[i][j-1];
        }
      }
      return l;
    } 
  }
}