namespace neighbourhoods {

  using System.Collections.Generic; 

   //Calculates neighbourhood number of one cell
  public class TiledRectangle1ConwayNeightbourHandler : NeightbourHandler {

    private TiledRectangle1UlamNeightbourHandler phc;
  //CONWAY neighbourhood for the mesh TILED_RECTANGLE1

    public TiledRectangle1ConwayNeightbourHandler(){
      this.phc = new TiledRectangle1UlamNeightbourHandler();
    }
    override public int neightbours_number(ModuloIndexableList<ModuloIndexableList<int> > matrix, int i, int j){
      int l = phc.neightbours_number(matrix, i, j);

      if (i % 4 == 0){
        if (j % 2 == 0){
          l = l + matrix[i-1][j+1];  
          l = l + matrix[i+1][j-2];
        }
        else if (j % 2 == 1){
          l = l + matrix[i+1][j-2];  
          l = l + matrix[i+1][j-1];
          l = l + matrix[i-1][j+1]; 
        }
      }
      else if (i % 4 == 1){
        if (j % 2 == 0){
          l = l + matrix[i-1][j+1];  
          l = l + matrix[i-1][j+2];
        }
        else if (j % 2 == 1){
          l = l + matrix[i-1][j-1];  
          l = l + matrix[i-1][j+2];
        }
      }
      else if (i % 4 == 2){
        if (j % 2 == 0){
          l = l + matrix[i-1][j+1];  
        }
        else if (j % 2 == 1){
          l = l + matrix[i+1][j-1];  
          l = l + matrix[i-1][j-1];
          l = l + matrix[i+1][j+2];  
        }
      }
      else if (i % 4 == 3){
        if (j % 2 == 0){
          l = l + matrix[i-1][j-2];  
        }
        else if (j % 2 == 1){
          l = l + matrix[i-1][j-2];  
          l = l + matrix[i-1][j-1];
          l = l + matrix[i+1][j-1];
        }
      }
      else System.Console.WriteLine("False.");
      return l;
    } 
  }
}