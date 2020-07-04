namespace neighbourhoods {

//Type to setting neighbourhood
public enum NeighbourhoodType
    {
	ULAM, //Neighbours at edges
	CONWAY, //Neighbours at edges and vedges
	KNIGHT, //Neighbours like check knight
	GREAT_CONWAY, //Neighbours at edges and all vedges
	OBLIQUE //Pentagon-like neighbours
    };
  }