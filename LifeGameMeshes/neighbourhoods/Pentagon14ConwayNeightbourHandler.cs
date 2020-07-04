namespace neighbourhoods {

  using System.Collections.Generic; 

   //Calculates neighbourhood number of one cell
  public class Pentagon14ConwayNeightbourHandler : NeightbourHandler {
  //CONWAY neighbourhood for the mesh PENTAGON14

    private Pentagon14UlamNeightbourHandler phc;
  
    public Pentagon14ConwayNeightbourHandler(){
      this.phc = new Pentagon14UlamNeightbourHandler();
    }

    override public int neightbours_number(ModuloIndexableList<ModuloIndexableList<int> > matrix, int i, int j){
  
      int l = phc.neightbours_number(matrix, i, j);

      if (j % 4 > 1){
        ;
      }
      if (i % 2 == 0) {
        if (j % 4 == 0) {
          l = l + matrix[i-1][j+1];
          l = l + matrix[i+1][j+1];
        }
        else if (j % 4 == 1) {
          l = l + matrix[i-1][j-1];
          l = l + matrix[i+1][j-1];
        }
      }
      else if (i % 2 == 1) {
        if (j % 4 == 0) {
          l = l + matrix[i-1][j+1];
          l = l + matrix[i+1][j+1];
        }
        else if (j % 4 == 1) {
          l = l + matrix[i-1][j-1];
          l = l + matrix[i+1][j-1];
        }
      }
      else System.Console.WriteLine("False.");
      return l;
    } 
  }
}