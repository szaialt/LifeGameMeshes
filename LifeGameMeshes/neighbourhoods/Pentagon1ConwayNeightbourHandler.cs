namespace neighbourhoods {

  using System.Collections.Generic; 

   //Calculates neighbourhood number of one cell
  public class Pentagon1ConwayNeightbourHandler : NeightbourHandler {
  //CONWAY neighbourhood for the mesh PENTAGON1

    private Pentagon1UlamNeightbourHandler phc;

    public Pentagon1ConwayNeightbourHandler(){
      this.phc = new Pentagon1UlamNeightbourHandler();
    }
    override public int neightbours_number(ModuloIndexableList<ModuloIndexableList<int> > matrix, int i, int j){
    //A koordinátákat azért kell felxcserélni, hogy összhangban legyünk a rajzolással

      int l = phc.neightbours_number(matrix, i, j);

      if (j % 2 == 1){
        l = l + matrix[i-1][j-1];  
        l = l + matrix[i+1][j-1];
      }
      else if (j % 2 == 0){
        l = l + matrix[i-1][j];  
        l = l + matrix[i+1][j+1];
      }
    
      else System.Console.WriteLine("False.");
      return l;
    } 
  }
}