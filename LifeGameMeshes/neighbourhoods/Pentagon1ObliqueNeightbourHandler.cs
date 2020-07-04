namespace neighbourhoods {

  using System.Collections.Generic; 

   //Calculates neighbourhood number of one cell
  public class Pentagon1ObliqueNeightbourHandler : NeightbourHandler {
  //OBLIQUE neighbourhood for the mesh PENTAGON1 

    private Pentagon1UlamNeightbourHandler phc;

    public Pentagon1ObliqueNeightbourHandler(){
      this.phc = new Pentagon1UlamNeightbourHandler();
    }
    override public int neightbours_number(ModuloIndexableList<ModuloIndexableList<int> > matrix, int i, int j){
    //A koordinátákat azért kell felcserélni, hogy összhangban legyünk a rajzolással

      int l = phc.neightbours_number(matrix, i, j);

      if (j % 2 == 1){
        l = l + matrix[i-1][j-1];  
      }
      else if (j % 2 == 0){
        l = l + matrix[i-1][j];  
      }
    
      else System.Console.WriteLine("False.");
      return l;
    } 
  }
}