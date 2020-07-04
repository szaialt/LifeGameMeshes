namespace neighbourhoods {

  using System.Collections.Generic; 

   //Calculates neighbourhood number of one cell
  public class TriangleConwayNeightbourHandler : NeightbourHandler {

    private TriangleUlamNeightbourHandler thc;

    public TriangleConwayNeightbourHandler() {
      this.thc = new TriangleUlamNeightbourHandler();
    }
  //CONWAY neighbourhood for the mesh TRIANGLE

    override public int neightbours_number(ModuloIndexableList<ModuloIndexableList<int> > matrix, int i, int j){
      int l = thc.neightbours_number(matrix, i, j);

        if (i % 4 == 0){
          l = l + matrix[i-2][j-1];  
          l = l + matrix[i-1][j-1];
          l = l + matrix[i][j-1];
        
          l = l + matrix[i-2][j];  
          l = l + matrix[i-1][j+1];
          l = l + matrix[i][j+1];
        
          l = l + matrix[i+2][j-1];  
          l = l + matrix[i+3][j];
          l = l + matrix[i+2][j];
        }
        else if (i % 4 == 1){
          l = l + matrix[i-2][j];  
          l = l + matrix[i-3][j];
          l = l + matrix[i-2][j+1];
        
          l = l + matrix[i+2][j];  
          l = l + matrix[i+1][j-1];
          l = l + matrix[i][j-1];
        
          l = l + matrix[i+2][j+1];  
          l = l + matrix[i+1][j+1];
          l = l + matrix[i][j+1];
        }
        else if (i % 4 == 2){
          l = l + matrix[i-2][j];  
          l = l + matrix[i-1][j-1];
          l = l + matrix[i][j-1];
        
          l = l + matrix[i-2][j+1];  
          l = l + matrix[i-1][j+1];
          l = l + matrix[i][j+1];
        
          l = l + matrix[i+2][j];  
          l = l + matrix[i+3][j];
          l = l + matrix[i+2][j+1];
        }
        else if (i % 4 == 3){
          l = l + matrix[i-1][j-1];  
          l = l + matrix[i-2][j-1];
          l = l + matrix[i-3][j];
        
          l = l + matrix[i][j-1];  
          l = l + matrix[i+1][j-1];
          l = l + matrix[i+2][j];
        
          l = l + matrix[i][j+1];  
          l = l + matrix[i+1][j+1];
          l = l + matrix[i+2][j];
        }
   
      return l;
    } 
  }
}