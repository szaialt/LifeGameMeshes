namespace neighbourhoods {

  using System.Collections.Generic; 

  public class Rectangle2UlamNeightbourHandler : NeightbourHandler {
  //ULAM neighbourhood for the mesh RECTANGLE2

     //Calculates neighbourhood number of one cell
    override public int neightbours_number(ModuloIndexableList<ModuloIndexableList<int> > matrix, int i, int j){
      int l = 0;
      //A koordinátákat azért kell felcserélni, hogy összhangban legyünk a rajzolással
      if (j % 4 == 0){
        l = l + matrix[i-1][j+1];  
        l = l + matrix[i][j+1];
        l = l + matrix[i+1][j+1];
        l = l + matrix[i][j-1];
        l = l + matrix[i][j-2];
      }
      else if (j % 4 == 1){
        l = l + matrix[i-1][j];  
        l = l + matrix[i][j-1];
        l = l + matrix[i+1][j-1];
        l = l + matrix[i][j+2];
        l = l + matrix[i][j-1];
      }
      else if (j % 4 == 2){
        l = l + matrix[i-1][j];  
        l = l + matrix[i-1][j+1];
        l = l + matrix[i][j+2];
        l = l + matrix[i][j+1];
        l = l + matrix[i][j-1];
      }
      else if (j % 4 == 3){
        l = l + matrix[i][j-1];  
        l = l + matrix[i][j+1];
        l = l + matrix[i+1][j];
        l = l + matrix[i+1][j-1];
        l = l + matrix[i][j-2];
      }
      return l;
    } 
  }
}