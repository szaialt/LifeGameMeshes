namespace coordinate_calculators {

  using System;
  using System.Collections.Generic; 

  //Calculates coordinates of polygons given by coordinates
  public abstract class CoordinateCalculator {
    public abstract List<Tuple<double, double>> calculate_polygon_coordinates(int i, int j);
  
    //To give know that is a given neighbourhood implemented
    public virtual bool hasUlam(){
      return false;
    }
  
    public virtual bool hasConway(){
      return false;
    }

    public virtual bool hasKnight(){
      return false;
    }
  
    public virtual bool hasGreatConway(){
      return false;
    }
  
    public virtual bool hasOblique(){
      return false;
    }
	
  }
}