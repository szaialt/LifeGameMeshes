namespace neighbourhoods {

  using System.Collections.Generic; 

  public class Pentagon3UlamNeightbourHandler : NeightbourHandler {
  //ULAM neighbourhood for the mesh PENTAGON3

     //Calculates neighbourhood number of one cell
    override public int neightbours_number(ModuloIndexableList<ModuloIndexableList<int> > matrix, int i, int j){
      int l = 0;
      if (j % 3 == 0){
        l = l + matrix[i-1][j-2];  
        l = l + matrix[i-1][j+2];
        l = l + matrix[i-1][j-1];
        l = l + matrix[i][j-2];
        l = l + matrix[i][j+2];
        l = l + matrix[i][j+1];
      }
      else if (j % 3 == 1){
        l = l + matrix[i-1][j+1];  
        l = l + matrix[i][j-1];
        l = l + matrix[i][j+1];
        l = l + matrix[i][j+2];
        l = l + matrix[i-1][j+4];
        l = l + matrix[i-1][j+2];
      }
      else if (j % 3 == 2){
        l = l + matrix[i][j-2];  
        l = l + matrix[i][j-4];
        l = l + matrix[i+1][j-2];
        l = l + matrix[i+1][j-1];
        l = l + matrix[i][j+1];
        l = l + matrix[i][j-1];
      }
      return l;
    } 
  }
}