namespace neighbourhoods {

  using System.Collections.Generic; 

     //Calculates neighbourhood number of one cell
  public class Pentagon12ObliqueNeightbourHandler : NeightbourHandler {
  //OBLIQUE neighbourhood for the mesh PENTAGON12

    private Pentagon12UlamNeightbourHandler phc;

    public Pentagon12ObliqueNeightbourHandler(){
      this.phc = new Pentagon12UlamNeightbourHandler();
    }

    override public int neightbours_number(ModuloIndexableList<ModuloIndexableList<int> > matrix, int i, int j){
      int l = phc.neightbours_number(matrix, i, j);
      if (i % 2 == 0){
        if (j % 8 == 0){
          l = l + matrix[i-1][j-1];
          l = l + matrix[i][j+2];
          l = l + matrix[i+1][j-3];
          l = l + matrix[i+1][j];
          l = l + matrix[i+1][j+1];
          l = l + matrix[i][j-2];
        }
        else if (j % 8 == 1){
          l = l + matrix[i][j+2];
          l = l + matrix[i+1][j];
          l = l + matrix[i][j-2];
          l = l + matrix[i][j-3];
          l = l + matrix[i-1][j+2];
        }
        else if (j % 8 == 2){
          l = l + matrix[i-1][j];
          l = l + matrix[i][j+2];
          l = l + matrix[i][j+3];
          l = l + matrix[i+1][j-2];
          l = l + matrix[i][j-2];
        }
        else if (j % 8 == 3){
          l = l + matrix[i][j+1];
          l = l + matrix[i][j+3];
          l = l + matrix[i+1][j+1];
          l = l + matrix[i][j-2];
          l = l + matrix[i-1][j-1];
        }
        else if (j % 8 == 4){
          l = l + matrix[i][j-1];
          l = l + matrix[i][j-2];
          l = l + matrix[i-1][j];
          l = l + matrix[i-1][j+2];
          l = l + matrix[i][j+2];
          l = l + matrix[i][j+7];
        }
        else if (j % 8 == 5){
          l = l + matrix[i][j+3];
          l = l + matrix[i][j+2];
          l = l + matrix[i][j-3];
          l = l + matrix[i-1][j-1];
          l = l + matrix[i-1][j];
        }
        else if (j % 8 == 6){
          l = l + matrix[i][j-2];
          l = l + matrix[i][j+3];
          l = l + matrix[i+1][j];
          l = l + matrix[i+1][j+1];
          l = l + matrix[i][j-3];
        }
        else if (j % 8 == 7){
          l = l + matrix[i][j-2];
          l = l + matrix[i+1][j-7];
          l = l + matrix[i+1][j-2];
          l = l + matrix[i+1][j];
          l = l + matrix[i][j+1];
          l = l + matrix[i][j+2];
        }
      }
      else if (i % 2 == 1){
        if (j % 8 == 0){
          l = l + matrix[i][j-1];
          l = l + matrix[i][j-2];
          l = l + matrix[i-1][j];
          l = l + matrix[i-1][j+2];
          l = l + matrix[i][j+2];
          l = l + matrix[i][j+7];
        }
        else if (j % 8 == 1){
          l = l + matrix[i][j+3];
          l = l + matrix[i][j+2];
          l = l + matrix[i][j-3];
          l = l + matrix[i-1][j-1];
          l = l + matrix[i-1][j];
        }
        else if (j % 8 == 2){
          l = l + matrix[i][j-2];
          l = l + matrix[i][j+3];
          l = l + matrix[i+1][j];
          l = l + matrix[i+1][j+1];
          l = l + matrix[i][j-3];
        }
        else if (j % 8 == 3){
          l = l + matrix[i][j-2];
          l = l + matrix[i+1][j-7];
          l = l + matrix[i+1][j-2];
          l = l + matrix[i+1][j];
          l = l + matrix[i][j+1];
          l = l + matrix[i][j+2];
        }
        else if (j % 8 == 4){
          l = l + matrix[i-1][j-1];
          l = l + matrix[i][j+2];
          l = l + matrix[i+1][j-3];
          l = l + matrix[i+1][j];
          l = l + matrix[i+1][j+1];
          l = l + matrix[i][j-2];
        }
        else if (j % 8 == 5){
          l = l + matrix[i][j+2];
          l = l + matrix[i+1][j];
          l = l + matrix[i][j-2];
          l = l + matrix[i][j-3];
          l = l + matrix[i-1][j+2];
        }
        else if (j % 8 == 6){
          l = l + matrix[i-1][j];
          l = l + matrix[i][j+2];
          l = l + matrix[i][j+3];
          l = l + matrix[i+1][j-2];
          l = l + matrix[i][j-2];
        }
        else if (j % 8 == 7){
          l = l + matrix[i][j-2];
          l = l + matrix[i+1][j-7];
          l = l + matrix[i+1][j-2];
          l = l + matrix[i+1][j];
          l = l + matrix[i][j+1];
          l = l + matrix[i][j+2];
        }
      }
      else System.Console.WriteLine("False.");
      return l;
    } 
  }
}