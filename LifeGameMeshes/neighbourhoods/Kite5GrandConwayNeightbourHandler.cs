namespace neighbourhoods {

  using System.Collections.Generic; 

   //Calculates neighbourhood number of one cell
  public class Kite5GrandConwayNeightbourHandler : NeightbourHandler {
  //GREAT_CONWAY neighbourhood for the mesh KITE5

    private Kite5SmallConwayNeightbourHandler phc;
  
    public Kite5GrandConwayNeightbourHandler(){
      this.phc = new Kite5SmallConwayNeightbourHandler();
    }

    override public int neightbours_number(ModuloIndexableList<ModuloIndexableList<int> > matrix, int i, int j){
  
      int l = phc.neightbours_number(matrix, i, j);
      if (j % 6 == 0){
        l = l + matrix[i][j+2];  
        l = l + matrix[i][j+3];
        l = l + matrix[i][j+4];
      }
      else if (j % 6 == 1){
        l = l + matrix[i][j+2];  
        l = l + matrix[i][j+3];
        l = l + matrix[i][j+4];
      }
      else if (j % 6 == 2){
        l = l + matrix[i][j+2];  
        l = l + matrix[i][j+3];
        l = l + matrix[i][j-2];
      }
      else if (j % 6 == 3){
        l = l + matrix[i][j+2];  
        l = l + matrix[i][j-3];
        l = l + matrix[i][j-2];
      }
      else if (j % 6 == 4) {
        l = l + matrix[i][j-4];  
        l = l + matrix[i][j-3];
        l = l + matrix[i][j-2];
      }
      else if (j % 6 == 5){
        l = l + matrix[i][j-4];  
        l = l + matrix[i][j-3];
        l = l + matrix[i][j-2];
      }
      else System.Console.WriteLine("False.");
      return l;
    } 
  }
}