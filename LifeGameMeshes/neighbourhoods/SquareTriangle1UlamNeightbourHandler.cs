namespace neighbourhoods {

  using System.Collections.Generic; 

  public class SquareTriangle1UlamNeightbourHandler : NeightbourHandler {
  //ULAM neighbourhood for the mesh SQUARE_TRIANGLE1

     //Calculates neighbourhood number of one cell
    override public int neightbours_number(ModuloIndexableList<ModuloIndexableList<int> > matrix, int i, int j){
      int l = 0;
      if (i % 2 == 0){
        if (j % 3 == 0){
          l = l + matrix[i-1][j-1];  
          l = l + matrix[i-1][j+2];
          l = l + matrix[i][j+1];
        }
        else if (j % 3 == 1){
          l = l + matrix[i][j-1];  
          l = l + matrix[i][j+3];
          l = l + matrix[i][j+1];
          l = l + matrix[i][j-3];
        }
        else if (j % 3 == 2){
          l = l + matrix[i][j-1];  
          l = l + matrix[i+1][j-2];
          l = l + matrix[i+1][j-5];
        }
      }
      else if (i % 2 == 1){
        if (j % 3 == 0){
          l = l + matrix[i-1][j+2];
          l = l + matrix[i-1][j+5];
          l = l + matrix[i][j+1];
        }
        else if (j % 3 == 1){
          l = l + matrix[i][j-1];
          l = l + matrix[i][j+3];  
          l = l + matrix[i][j+1];
          l = l + matrix[i][j-3];
        }
        else if (j % 3 == 2){
          l = l + matrix[i][j-1];  
          l = l + matrix[i+1][j+1];
          l = l + matrix[i+1][j-2];
        }
      }
      return l;
    } 
  }
}