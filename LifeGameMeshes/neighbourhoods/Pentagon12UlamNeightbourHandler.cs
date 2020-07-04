namespace neighbourhoods {

  using System.Collections.Generic; 

  //Az elnevezési konvenció nem tartható, mert ezt a nevet foglaltnak jelzi
  public class Pentagon12UlamNeightbourHandler : NeightbourHandler {
  //ULAM neighbourhood for the mesh PENTAGON12

     //Calculates neighbourhood number of one cell
    override public int neightbours_number(ModuloIndexableList<ModuloIndexableList<int> > matrix, int i, int j){
      int l = 0;
      //Rectangle1-et kell felosztani
      if (i % 2 == 0){
        if (j % 8 == 0){
          l = l + matrix[i-1][j+3];  
          l = l + matrix[i][j+1];
          l = l + matrix[i][j-4];
          l = l + matrix[i][j-2];
        }
        else if (j % 8 == 1){
          l = l + matrix[i][j-1];  
          l = l + matrix[i][j+1];
          l = l + matrix[i+1][j-1];
        }
        else if (j % 8 == 2){
          l = l + matrix[i-1][j+1];  
          l = l + matrix[i][j+1];
          l = l + matrix[i][j-1];
        }
        else if (j % 8 == 3){
          l = l + matrix[i][j-1];  
          l = l + matrix[i][j+2];
          l = l + matrix[i][j+4];
          l = l + matrix[i+1][j-3];
        }
        else if (j % 8 == 4){
          l = l + matrix[i-1][j+1];  
          l = l + matrix[i-1][j+3];
          l = l + matrix[i][j+4];
          l = l + matrix[i][j+1];
        }
        else if (j % 8 == 5){
          l = l + matrix[i][j-1];  
          l = l + matrix[i][j+1];
          l = l + matrix[i+1][j-2];
        }
        else if (j % 8 == 6){
          l = l + matrix[i][j-1];  
          l = l + matrix[i][j+1];
          l = l + matrix[i][j+2];
        }
        else if (j % 8 == 7){
          l = l + matrix[i][j-1];  
          l = l + matrix[i][j-4];
          l = l + matrix[i+1][j-3];
          l = l + matrix[i+1][j-1];
        }
      }
      else if (i % 2 == 1){
        if (j % 8 == 0){
          l = l + matrix[i-1][j+1];  
          l = l + matrix[i-1][j+3];
          l = l + matrix[i][j+4];
          l = l + matrix[i][j+1];
        }
        else if (j % 8 == 1){
          l = l + matrix[i][j-1];  
          l = l + matrix[i][j+1];
          l = l + matrix[i+1][j-2];
        }
        else if (j % 8 == 2){
          l = l + matrix[i][j-1];  
          l = l + matrix[i][j+1];
          l = l + matrix[i][j+2];
        }
        else if (j % 8 == 3){
          l = l + matrix[i][j-1];  
          l = l + matrix[i][j-4];
          l = l + matrix[i+1][j-3];
          l = l + matrix[i+1][j-1];
        }
        else if (j % 8 == 4){
          l = l + matrix[i-1][j+3];  
          l = l + matrix[i][j+1];
          l = l + matrix[i][j-4];
          l = l + matrix[i][j-2];
        }
        else if (j % 8 == 5){
          l = l + matrix[i][j-1];  
          l = l + matrix[i][j+1];
          l = l + matrix[i+1][j-1];
        }
        else if (j % 8 == 6){
          l = l + matrix[i-1][j+1];  
          l = l + matrix[i][j+1];
          l = l + matrix[i][j-1];
        }
        else if (j % 8 == 7){
          l = l + matrix[i][j-1];  
          l = l + matrix[i][j-4];
          l = l + matrix[i+1][j-3];
          l = l + matrix[i+1][j-1];
        }
      }
      return l;
    } 
  }
}