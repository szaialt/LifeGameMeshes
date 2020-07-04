namespace neighbourhoods {

  using System.Collections.Generic; 

   //Calculates neighbourhood number of one cell
  public class Pentagon11ConwayNeightbourHandler : NeightbourHandler {
  //CONWAY neighbourhood for the mesh PENTAGON11

    private Pentagon11UlamNeightbourHandler phc;

    public Pentagon11ConwayNeightbourHandler(){
      this.phc = new Pentagon11UlamNeightbourHandler();
    }

    override public int neightbours_number(ModuloIndexableList<ModuloIndexableList<int> > matrix, int i, int j){
      int l = phc.neightbours_number(matrix, i, j);
      if (j % 8 == 0){
        l = l + matrix[i][j+2];
        l = l + matrix[i][j+3];
        l = l + matrix[i][j+4];
        l = l + matrix[i][j+5];
        l = l + matrix[i][j+6];
      }
      else if (j % 8 == 1){
        l = l + matrix[i-1][j-1];
        l = l + matrix[i][j+2];
        l = l + matrix[i][j+3];
        l = l + matrix[i][j+4];
        l = l + matrix[i][j+5];
        l = l + matrix[i][j+6];
      }
      else if (j % 8 == 2){
        l = l + matrix[i][j+2];
        l = l + matrix[i][j+3];
        l = l + matrix[i][j+4];
        l = l + matrix[i][j+5];
        l = l + matrix[i][j-2];
      }
      else if (j % 8 == 3){
        l = l + matrix[i-1][j+12];
        l = l + matrix[i][j+2];
        l = l + matrix[i][j+3];
        l = l + matrix[i][j+4];
        l = l + matrix[i][j-3];
        l = l + matrix[i][j-2];
      }
      else if (j % 8 == 4){
        l = l + matrix[i][j+2];
        l = l + matrix[i][j+3];
        l = l + matrix[i][j-4];
        l = l + matrix[i][j-3];
        l = l + matrix[i][j-2];
      }
      else if (j % 8 == 5){
        l = l + matrix[i+1][j+4];
        l = l + matrix[i][j+2];
        l = l + matrix[i][j-5];
        l = l + matrix[i][j-4];
        l = l + matrix[i][j-3];
        l = l + matrix[i][j-2];
      }
      else if (j % 8 == 6){
        l = l + matrix[i][j-6];
        l = l + matrix[i][j-5];
        l = l + matrix[i][j-4];
        l = l + matrix[i][j-3];
        l = l + matrix[i][j-2];
      }
      else if (j % 8 == 7){
        l = l + matrix[i+1][j-11];
        l = l + matrix[i][j-6];
        l = l + matrix[i][j-5];
        l = l + matrix[i][j-4];
        l = l + matrix[i][j-3];
        l = l + matrix[i][j-2];
      }
      else System.Console.WriteLine("False.");
      return l;
    } 
  }
}