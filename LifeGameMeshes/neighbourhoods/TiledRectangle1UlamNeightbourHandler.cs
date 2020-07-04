namespace neighbourhoods {

  using System.Collections.Generic; 

  public class TiledRectangle1UlamNeightbourHandler : NeightbourHandler {
  //ULAM neighbourhood for the mesh TILED_RECTANGLE1

     //Calculates neighbourhood number of one cell
    override public int neightbours_number(ModuloIndexableList<ModuloIndexableList<int> > matrix, int i, int j){
      int l = 0;
      if (i % 4 == 0){
        if (j % 2 == 0){
          l = l + matrix[i+1][j-1];  
          l = l + matrix[i][j+1];
          l = l + matrix[i+1][j];
          l = l + matrix[i+2][j-2];
        }
        else if (j % 2 == 0){
          l = l + matrix[i-1][j];  
          l = l + matrix[i-2][j];
          l = l + matrix[i-1][j+2];
          l = l + matrix[i+1][j];
          l = l + matrix[i+1][j-1];
          l = l + matrix[i-1][j-1];
        }
      }
      else if (i % 4 == 1){
        if (j % 2 == 0){
          l = l + matrix[i-1][j];  
          l = l + matrix[i][j+1];
          l = l + matrix[i+1][j+2];
          l = l + matrix[i+2][j+2];
          l = l + matrix[i+1][j];
        }
        else if (j % 2 == 1){
          l = l + matrix[i-1][j];  
          l = l + matrix[i-2][j+2];
          l = l + matrix[i-1][j+1];
          l = l + matrix[i][j-1];
        }
      }
      else if (i % 4 == 2){
      if (j % 2 == 0){
          l = l + matrix[i-1][j];  
          l = l + matrix[i-2][j+2];
          l = l + matrix[i-1][j+2];
          l = l + matrix[i][j+1];
          l = l + matrix[i+1][j];
        }
        else if (j % 2 == 1){
          l = l + matrix[i][j-1];  
          l = l + matrix[i+1][j+1];
          l = l + matrix[i+2][j];
          l = l + matrix[i+1][j];
        }
      }
      else if (i % 4 == 3){
        if (j % 2 == 0){
          l = l + matrix[i-2][j-2];  
          l = l + matrix[i-1][j];
          l = l + matrix[i][j+1];
          l = l + matrix[i-1][j-1];
        }
        else if (j % 2 == 1){
          l = l + matrix[i][j-1];  
          l = l + matrix[i-1][j];
          l = l + matrix[i+1][j];
          l = l + matrix[i+2][j-2];
          l = l + matrix[i+1][j-2];
        }
      }
      return l;
    } 
  }
}