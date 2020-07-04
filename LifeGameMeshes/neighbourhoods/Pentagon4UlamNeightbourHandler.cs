namespace neighbourhoods {

  using System.Collections.Generic; 

  public class Pentagon4UlamNeightbourHandler : NeightbourHandler {
  //ULAM neighbourhood for the mesh PENTAGON4

     //Calculates neighbourhood number of one cell
    override public int neightbours_number(ModuloIndexableList<ModuloIndexableList<int> > matrix, int i, int j){
    int l = 0;
      if (j % 4 == 0){
        l = l + matrix[i-1][j+3];  
        l = l + matrix[i-1][j+2];
        l = l + matrix[i][j+1];
        l = l + matrix[i][j+3];
        l = l + matrix[i][j-3];
      }
      else if (j % 4 == 1){
        l = l + matrix[i-1][j+1];  
        l = l + matrix[i][j+3];
        l = l + matrix[i][j+6];
        l = l + matrix[i][j+1];
        l = l + matrix[i][j-1];
      }
      else if (j % 4 == 2){
        l = l + matrix[i][j-1];  
        l = l + matrix[i][j+5];
        l = l + matrix[i+1][j-1];
        l = l + matrix[i+1][j-2];
        l = l + matrix[i][j+1];
      }
      else if (j % 4 == 3){
        l = l + matrix[i][j-3];  
        l = l + matrix[i][j-11];
        l = l + matrix[i+1][j-3];
        l = l + matrix[i][j-5];
        l = l + matrix[i][j-6];
      }
      return l;
    } 
  }
}