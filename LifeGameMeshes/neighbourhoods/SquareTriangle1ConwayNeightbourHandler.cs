namespace neighbourhoods {

  using System.Collections.Generic; 

   //Calculates neighbourhood number of one cell
  public class SquareTriangle1ConwayNeightbourHandler : NeightbourHandler {
  //CONWAY neighbourhood for the mesh SQUARE_TRIANGLE1

    private SquareTriangle1UlamNeightbourHandler phc;
  
    public SquareTriangle1ConwayNeightbourHandler(){
      phc = new SquareTriangle1UlamNeightbourHandler();
    }

    override public int neightbours_number(ModuloIndexableList<ModuloIndexableList<int> > matrix, int i, int j){
      int l = phc.neightbours_number(matrix, i, j);
      if (i % 2 == 0){
        if (j % 3 == 0){
          l = l + matrix[i-1][j-2];  
          l = l + matrix[i-1][j+1];
          l = l + matrix[i][j-1];  
          l = l + matrix[i][j+4];
          l = l + matrix[i][j-3];  
          l = l + matrix[i][j+3];
        }
        else if (j % 3 == 1){
          l = l + matrix[i-1][j-2];  
          l = l + matrix[i-1][j+1];
          l = l + matrix[i+1][j-1];  
          l = l + matrix[i+1][j-4];
          l = l + matrix[i][j-4];  
          l = l + matrix[i][j+2];
          l = l + matrix[i][j-2];  
          l = l + matrix[i][j+4];
        }
        else if (j % 3 == 2){
          l = l + matrix[i][j-4];  
          l = l + matrix[i][j+2];
          l = l + matrix[i+1][j-4];  
          l = l + matrix[i+1][j-1];
          l = l + matrix[i][j-3];  
          l = l + matrix[i][j+3];
        }
      }
      else if (i % 2 == 1){
        if (j % 3 == 0){
          l = l + matrix[i-1][j+1];  
          l = l + matrix[i-1][j+4];
          l = l + matrix[i][j-2];  
          l = l + matrix[i][j+4];
          l = l + matrix[i][j-3];  
          l = l + matrix[i][j+3];
        }
        else if (j % 3 == 1){
          l = l + matrix[i-1][j+1];  
          l = l + matrix[i-1][j+4];
          l = l + matrix[i+1][j+2];  
          l = l + matrix[i+1][j-1];
          l = l + matrix[i][j-4];  
          l = l + matrix[i][j+2];
          l = l + matrix[i][j-2];  
          l = l + matrix[i][j+4];
        }
        else if (j % 3 == 2){
          l = l + matrix[i][j-4];  
          l = l + matrix[i][j+2];
          l = l + matrix[i+1][j-1];  
          l = l + matrix[i+1][j+2];
          l = l + matrix[i][j-3];  
          l = l + matrix[i][j+3];
        }
      }
      else System.Console.WriteLine("False.");
      return l;
    } 
  }
}