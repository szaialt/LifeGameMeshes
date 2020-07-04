namespace neighbourhoods {

  using System.Collections.Generic; 

   //Calculates neighbourhood number of one cell
  public class Rectangle2ConwayNeightbourHandler : NeightbourHandler {
  //CONWAY neighbourhood for the mesh RECTANGLE2

    private Rectangle2UlamNeightbourHandler phc;

    public Rectangle2ConwayNeightbourHandler(){
      this.phc = new Rectangle2UlamNeightbourHandler();
    }
    override public int neightbours_number(ModuloIndexableList<ModuloIndexableList<int> > matrix, int i, int j){
    //A koordinátákat azért kell felxcserélni, hogy összhangban legyünk a rajzolással

      int l = phc.neightbours_number(matrix, i, j);

      if (j % 4 == 0){
        l = l + matrix[i-1][j-1];  
        l = l + matrix[i+1][j-1];
      }
      else if (j % 4 == 1){
        l = l + matrix[i-1][j+1];  
        l = l + matrix[i+1][j+1];
      }
      else if (j % 4 == 2){
        l = l + matrix[i-1][j-1];  
        l = l + matrix[i-1][j+3];
      }
      else if (j % 4 == 3){
        l = l + matrix[i+1][j-3];  
        l = l + matrix[i+1][j+1];
      }
      else System.Console.WriteLine("False.");
      return l;
    } 
  }
}