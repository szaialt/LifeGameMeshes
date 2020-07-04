namespace neighbourhoods {

  using System.Collections.Generic; 

  public class OctogonSquareUlamNeightbourHandler : NeightbourHandler {
  //ULAM neighbourhood for the mesh OCTOGON_SQUARE

     //Calculates neighbourhood number of one cell
    override public int neightbours_number(ModuloIndexableList<ModuloIndexableList<int> > matrix, int i, int j){
      int l = 0;
      if ((i + j) % 2 == 0){
        for (int ii = i-1; ii < i+2; ii++){
          for (int jj = j-1; jj < j+2; jj++){
            if ((ii != i) || (jj != j)){
              l = l + matrix[ii][jj];
            }
          }  
        }
      }
      else if ((i + j) % 2 == 1){
        l = l + matrix[i-1][j];  
        l = l + matrix[i+1][j];
        l = l + matrix[i][j-1];
        l = l + matrix[i][j+1];
      }
      return l;
    } 
  }
}