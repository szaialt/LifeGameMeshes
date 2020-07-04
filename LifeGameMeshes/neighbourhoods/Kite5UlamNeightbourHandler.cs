namespace neighbourhoods {

  using System.Collections.Generic; 

  public class Kite5UlamNeightbourHandler : NeightbourHandler {
  //ULAM neighbourhood for the mesh KITE5

     //Calculates neighbourhood number of one cell
  override public int neightbours_number(ModuloIndexableList<ModuloIndexableList<int> > matrix, int i, int j){
      int l = 0;
      if (i % 2 == 0){
        if (j % 6 == 0){
          l = l + matrix[i-1][j-4];  
          l = l + matrix[i-1][j+4];
          l = l + matrix[i][j+1];
          l = l + matrix[i][j+5];
        }
        else if (j % 6 == 1){
          l = l + matrix[i][j-1];  
          l = l + matrix[i][j+2];
          l = l + matrix[i][j+10];
          l = l + matrix[i][j+1];
        }
        else if (j % 6 == 2){
          l = l + matrix[i][j-1];  
          l = l + matrix[i][j+8];
          l = l + matrix[i+1][j-2];
          l = l + matrix[i][j+1];
        }
        else if (j % 6 == 3){
          l = l + matrix[i][j-1];  
          l = l + matrix[i+1][j+2];
          l = l + matrix[i+1][j-8];
          l = l + matrix[i][j+1];
        }
        else if (j % 6 == 4){
          l = l + matrix[i][j-1];  
          l = l + matrix[i][j-8];
          l = l + matrix[i+1][j-10];
          l = l + matrix[i][j+1];
        }
        else if (j % 6 == 5){
          l = l + matrix[i][j-5];  
          l = l + matrix[i+1][j-10];
          l = l + matrix[i-1][j-8];
          l = l + matrix[i][j-1];
        }
      }
      else if (i % 2 == 1){
        if (j % 6 == 0){
          l = l + matrix[i][j+1];
          l = l + matrix[i][j+5];
          l = l + matrix[i-1][j+2];
          l = l + matrix[i-1][j+10];  
        }
        else if (j % 6 == 1){
          l = l + matrix[i][j-1];
          l = l + matrix[i-1][j+8];  
          l = l + matrix[i][j+10];
          l = l + matrix[i][j+1];
        }
        else if (j % 6 == 2){
          l = l + matrix[i][j-1];  
          l = l + matrix[i][j+8];
          l = l + matrix[i+1][j+4];
          l = l + matrix[i][j+1];
        }
        else if (j % 6 == 3){
          l = l + matrix[i][j-1];  
          l = l + matrix[i+1][j+8];
          l = l + matrix[i+1][j-2];
          l = l + matrix[i][j+1];
        }
        else if (j % 6 == 4){
          l = l + matrix[i][j+1];  
          l = l + matrix[i][j-8];
          l = l + matrix[i+1][j-4];
          l = l + matrix[i][j-1];
        }
        else if (j % 6 == 5){
          l = l + matrix[i][j-5];  
          l = l + matrix[i][j+1];
          l = l + matrix[i][j-10];
          l = l + matrix[i-1][j-2];
        }
      }
      return l;
    } 
  }
}