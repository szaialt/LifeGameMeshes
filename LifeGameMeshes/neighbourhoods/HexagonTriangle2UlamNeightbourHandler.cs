namespace neighbourhoods {

  using System.Collections.Generic; 

  public class HexagonTriangle2UlamNeightbourHandler : NeightbourHandler {
  //ULAM neighbourhood for the mesh HEXAGON_TRIANGLE2

     //Calculates neighbourhood number of one cell
    override public int neightbours_number(ModuloIndexableList<ModuloIndexableList<int> > matrix, int i, int j){
      int l = 0;
      if (i % 3 == 0){
        if (j % 9 == 0){
          l = l + matrix[i][j+1];
          l = l + matrix[i][j+2];
          l = l + matrix[i][j+3];  
          l = l + matrix[i][j+4];
          l = l + matrix[i][j+5];
          l = l + matrix[i][j+6];
        }
        else if (j % 9 == 1){
          l = l + matrix[i][j-3];  
          l = l + matrix[i][j-6];
          l = l + matrix[i][j-1];
        }
        else if (j % 9 == 2){
          l = l + matrix[i][j-2];  
          l = l + matrix[i+1][j-6];
          l = l + matrix[i+1][j-3];
        }
        else if (j % 9 == 3){
          l = l + matrix[i][j-3];  
          l = l + matrix[i+1][j+3];
          l = l + matrix[i+1][j+4];
        }
        else if (j % 9 == 4){
          l = l + matrix[i][j-4];  
          l = l + matrix[i][j+6];
          l = l + matrix[i][j+4];
        }
        else if (j % 9 == 5){
          l = l + matrix[i][j-5];  
          l = l + matrix[i-1][j+6];
          l = l + matrix[i-1][j+2];
        }
        else if (j % 9 == 6){
          l = l + matrix[i][j-6];  
          l = l + matrix[i-1][j-3];
          l = l + matrix[i][j-7];
        }
        else if (j % 9 == 7){
          l = l + matrix[i][j-4];  
          l = l + matrix[i][j+3];
          l = l + matrix[i-1][j-2];
        }
        else if (j % 9 == 8){
          l = l + matrix[i][j-4];  
          l = l + matrix[i][j+7];
          l = l + matrix[i-1][j+3];
        }
      }
      else if (i % 3 == 1){
        if (j % 9 == 0){
          l = l + matrix[i][j+1];
          l = l + matrix[i][j+2];
          l = l + matrix[i][j+3];  
          l = l + matrix[i][j+4];
          l = l + matrix[i][j+5];
          l = l + matrix[i][j+6];
        }
        else if (j % 9 == 1){
          l = l + matrix[i][j-6];
          l = l + matrix[i][j-3];  
          l = l + matrix[i][j-1];
        }
        else if (j % 9 == 2){
          l = l + matrix[i+1][j+6];  
          l = l + matrix[i+1][j+3];
          l = l + matrix[i][j-2];
        }
        else if (j % 9 == 3){
          l = l + matrix[i][j-3];
          l = l + matrix[i+1][j+2];
          l = l + matrix[i][j+4];
        }
        else if (j % 9 == 4){
          l = l + matrix[i][j-4];
          l = l + matrix[i][j+6];  
          l = l + matrix[i][j+4];
        }
        else if (j % 9 == 5){
          l = l + matrix[i][j-5];  
          l = l + matrix[i-1][j+6];
          l = l + matrix[i-1][j+2];
        }
        else if (j % 9 == 6){
          l = l + matrix[i][j-7];
          l = l + matrix[i][j-6];
          l = l + matrix[i-1][j-3];
        }
        else if (j % 9 == 7){
          l = l + matrix[i][j-4];
          l = l + matrix[i][j+7];  
          l = l + matrix[i][j+3];
        }
        else if (j % 9 == 8){
          l = l + matrix[i][j-4];  
          l = l + matrix[i][j+7];
          l = l + matrix[i-1][j+3];
        }
      }
      if (i % 3 == 2){
        if (j % 9 == 0){
          l = l + matrix[i][j+1];
          l = l + matrix[i][j+2];
          l = l + matrix[i][j+3];  
          l = l + matrix[i][j+4];
          l = l + matrix[i][j+5];
          l = l + matrix[i][j+6];
        }
        else if (j % 9 == 1){
          l = l + matrix[i][j-1];  
          l = l + matrix[i][j-6];
          l = l + matrix[i][j-3];
        }
        else if (j % 9 == 2){
          l = l + matrix[i+1][j-6];  
          l = l + matrix[i+1][j-3];
          l = l + matrix[i][j-2];
        }
        else if (j % 9 == 3){
          l = l + matrix[i][j-3];  
          l = l + matrix[i+1][j+3];
          l = l + matrix[i][j+4];
        }
        else if (j % 9 == 4){
          l = l + matrix[i][j-4];  
          l = l + matrix[i][j+6];
          l = l + matrix[i][j+4];
        }
        else if (j % 9 == 5){
          l = l + matrix[i][j-5];  
          l = l + matrix[i-1][j-3];
          l = l + matrix[i-1][j-7];
        }
        else if (j % 9 == 6){
          l = l + matrix[i][j-6];  
          l = l + matrix[i][j-7];
          l = l + matrix[i-1][j-12];
        }
        else if (j % 9 == 7){
          l = l + matrix[i][j-4];  
          l = l + matrix[i+1][j-2];
          l = l + matrix[i][j+3];
        }
        else if (j % 9 == 8){
          l = l + matrix[i][j-4];  
          l = l + matrix[i][j+7];
          l = l + matrix[i-1][j-6];
        }
      }
   
      return l;
    } 
  }
}