namespace neighbourhoods {

  using System.Collections.Generic; 

  public class Pentagon1UlamNeightbourHandler : NeightbourHandler {
  //ULAM neighbourhood for the mesh PENTAGON1

     //Calculates neighbourhood number of one cell
    override public int neightbours_number(ModuloIndexableList<ModuloIndexableList<int> > matrix, int i, int j){
      int l = 0;
      //A koordinátákat azért kell felxcserélni, hogy összhangban legyünk a rajzolással
      if (j % 2 == 0){
        l = l + matrix[i-1][j];  
        l = l + matrix[i][j-1];
        l = l + matrix[i+1][j-1];
        l = l + matrix[i+1][j];
        l = l + matrix[i][j+1];
      }
      else if (j % 2 == 1){
        l = l + matrix[i-1][j];  
        l = l + matrix[i][j+1];
        l = l + matrix[i+1][j+1];
        l = l + matrix[i+1][j];
        l = l + matrix[i][j-1];
      }
      return l;
    } 
  }
}