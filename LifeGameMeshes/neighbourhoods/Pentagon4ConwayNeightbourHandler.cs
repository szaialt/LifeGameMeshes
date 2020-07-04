namespace neighbourhoods {

  using System.Collections.Generic; 

   //Calculates neighbourhood number of one cell
  public class Pentagon4ConwayNeightbourHandler : NeightbourHandler {
  //CONWAY neighbourhood for the mesh PENTAGON4

    private Pentagon4UlamNeightbourHandler phc;

    public Pentagon4ConwayNeightbourHandler(){
      this.phc = new Pentagon4UlamNeightbourHandler();
    }

    override public int neightbours_number(ModuloIndexableList<ModuloIndexableList<int> > matrix, int i, int j){
      int l = phc.neightbours_number(matrix, i, j);
      if (j % 4 == 0){
        l = l + matrix[i-1][j-2];  
        l = l + matrix[i][j+2];
      }
      else if (j % 4 == 1){
        l = l + matrix[i-1][j+6];  
        l = l + matrix[i][j+2];
      }
      else if (j % 4 == 2){
        l = l + matrix[i][j-2];  
        l = l + matrix[i+1][j+2];
      }
      else if (j % 4 == 3){
        l = l + matrix[i+1][j-6];  
        l = l + matrix[i][j-2];
      }
      else System.Console.WriteLine("False.");
      return l;
    } 
  }
}