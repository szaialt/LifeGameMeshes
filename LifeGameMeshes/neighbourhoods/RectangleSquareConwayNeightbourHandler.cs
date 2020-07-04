namespace neighbourhoods {

  using System.Collections.Generic; 

   //Calculates neighbourhood number of one cell
  public class RectangleSquareConwayNeightbourHandler : NeightbourHandler {
      //CONWAY neighbourhood for the mesh RECTANGLE_SQUARE

    private RectangleSquareUlamNeightbourHandler rhc;
  
    public RectangleSquareConwayNeightbourHandler(){
      this.rhc = new RectangleSquareUlamNeightbourHandler();
    }
  
    override public int neightbours_number(ModuloIndexableList<ModuloIndexableList<int> > matrix, int i, int j){
  
      int l = rhc.neightbours_number(matrix, i, j);
  
      if (j % 3 == 0){
        l = l + matrix[i-1][j+3];  
        l = l + matrix[i+1][j-3];
      }
      else if (j % 3 == 1){
        l = l + matrix[i][j+3];  
        l = l + matrix[i][j-3];  
      }
      else if (j % 3 == 2){
        ;
      }
      else System.Console.WriteLine("False.");
      return l;
    } 
  }
}