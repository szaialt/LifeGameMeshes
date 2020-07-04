namespace neighbourhoods {

  using System.Collections.Generic; 

   //Calculates neighbourhood number of one cell
  public class Pentagon11ObliqueNeightbourHandler : NeightbourHandler {
  //OBLIQUE neighbourhood for the mesh PENTAGON11

    private Pentagon11UlamNeightbourHandler phc;

    public Pentagon11ObliqueNeightbourHandler(){
      this.phc = new Pentagon11UlamNeightbourHandler();
    }

    override public int neightbours_number(ModuloIndexableList<ModuloIndexableList<int> > matrix, int i, int j){
      int l = phc.neightbours_number(matrix, i, j);
      if (j % 8 == 0){
        l = l + matrix[i][j+5];
      }
      else if (j % 8 == 1){
        l = l + matrix[i][j+3];
      }
      else if (j % 8 == 2){
        l = l + matrix[i-1][j+13];
      }
      else if (j % 8 == 3){
        l = l + matrix[i-1][j+11];
      }
      else if (j % 8 == 4){
        l = l + matrix[i][j-3];
      }
      else if (j % 8 == 5){
        l = l + matrix[i][j-5];
      }
      else if (j % 8 == 6){
        l = l + matrix[i+1][j-11];
      }
      else if (j % 8 == 7){
        l = l + matrix[i+1][j-13];
      }
      else System.Console.WriteLine("False.");
      return l;
    } 
  }
}