namespace neighbourhoods {

  using System.Collections.Generic; 

   //Calculates neighbourhood number of one cell
  public class Pentagon10ObliqueNeightbourHandler : NeightbourHandler {
  //OBLIQUE neighbourhood for the mesh PENTAGON10

    private Pentagon10UlamNeightbourHandler phc;

    public Pentagon10ObliqueNeightbourHandler(){
      phc = new Pentagon10UlamNeightbourHandler();
    }

    override public int neightbours_number(ModuloIndexableList<ModuloIndexableList<int> > matrix, int i, int j){
      int l = phc.neightbours_number(matrix, i, j);
      if (i % 2 == 0){
        if (j % 6 == 0){
          l = l + matrix[i-1][j+6];
          l = l + matrix[i-1][j-5];
        }
        else if (j % 6 == 1){
          l = l + matrix[i-1][j+3];  
        }
        else if (j % 6 == 2){
          l = l + matrix[i+1][j-5];
          l = l + matrix[i+1][j+3];
        }
        else if (j % 6 == 3){ 
          l = l + matrix[i-1][j-5];
        }
        else if (j % 6 == 4){
          l = l + matrix[i][j-5];
        }
        else if (j % 6 == 5){
          l = l + matrix[i][j+5]; 
        }
      }
      else if (i % 2 == 1){
        if (j % 6 == 0){
          l = l + matrix[i][j-5];  
        }
        else if (j % 6 == 1){
          l = l + matrix[i][j+5]; 
        }
        else if (j % 6 == 2){
          l = l + matrix[i-1][j-3]; 
          l = l + matrix[i-1][j+8]; 
        }
        else if (j % 6 == 3){
          l = l + matrix[i-1][j+5];  
        }
        else if (j % 6 == 4){
          l = l + matrix[i+1][j-3];
          l = l + matrix[i+1][j+5]; 
        }
        else if (j % 6 == 5){
          l = l + matrix[i-1][j-3];  
        }
      }
      else System.Console.WriteLine("False.");
      return l;
    } 
  }
}