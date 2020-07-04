namespace neighbourhoods {

  using System.Collections.Generic; 

  public class Pentagon11UlamNeightbourHandler : NeightbourHandler {
  //ULAM neighbourhood for the mesh PENTAGON11

     //Calculates neighbourhood number of one cell
    override public int neightbours_number(ModuloIndexableList<ModuloIndexableList<int> > matrix, int i, int j){
      int l = 0;
       //Pentagon4-et kell felosztani
      if (j % 8 == 0){
        l = l + matrix[i][j-5];  
        l = l + matrix[i][j+1];
        l = l + matrix[i][j-4];
        l = l + matrix[i][j+7];
      }
      else if (j % 8 == 1){
        l = l + matrix[i][j-6];  
        l = l + matrix[i-1][j+6];
        l = l + matrix[i-1][j+5];
        l = l + matrix[i][j+1];
        l = l + matrix[i][j-1];
      }
      else if (j % 8 == 2){
        l = l + matrix[i][j-1];  
        l = l + matrix[i][j+5];
        l = l + matrix[i+1][j-1];
        l = l + matrix[i+1][j-2];
      }
      else if (j % 8 == 3){
        l = l + matrix[i][j-1];  
        l = l + matrix[i-1][j+2];
        l = l + matrix[i][j+6];
        l = l + matrix[i][j+5];
        l = l + matrix[i][j+11];
      }
      else if (j % 8 == 4){
        l = l + matrix[i][j-1];  
        l = l + matrix[i][j+4];
        l = l + matrix[i][j+11];
        l = l + matrix[i][j+1];
      }
      else if (j % 8 == 5){
        l = l + matrix[i][j-1];  
        l = l + matrix[i][j+10];
        l = l + matrix[i+1][j-2];
        l = l + matrix[i+1][j-3];
        l = l + matrix[i][j+1];
      }
      else if (j % 8 == 6){
        l = l + matrix[i][j-1];  
        l = l + matrix[i+1][j-4];
        l = l + matrix[i+1][j-5];
        l = l + matrix[i][j+1];
      }
      else if (j % 8 == 7){
        l = l + matrix[i][j-1];  
        l = l + matrix[i+1][j-6];
        l = l + matrix[i][j-10];
        l = l + matrix[i][j-11];
        l = l + matrix[i][j-7];
      }
      return l;
    } 
  }
}