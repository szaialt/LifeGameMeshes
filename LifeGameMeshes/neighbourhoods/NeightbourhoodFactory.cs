namespace neighbourhoods {

  using System.Collections.Generic; 

  //Calculates neighbourhood
  public class NeightbourhoodFactory
  {
    public NeightbourHandler produce(MeshType mesh, NeighbourhoodType neighbourhood){
    NeightbourHandler nh = new QuadraticConwayNeightbourHandler();
    if (mesh == MeshType.SQUARE){
      if (neighbourhood == NeighbourhoodType.ULAM) 
        nh = new QuadraticUlamNeightbourHandler();
      else if (neighbourhood == NeighbourhoodType.KNIGHT) 
        nh = new QuadraticKnightNeightbourHandler();
    }
    else if (mesh == MeshType.TRIANGLE){
      if (neighbourhood == NeighbourhoodType.ULAM) 
        nh = new TriangleUlamNeightbourHandler();
      else if (neighbourhood == NeighbourhoodType.CONWAY)
        nh = new TriangleConwayNeightbourHandler();
      else if (neighbourhood == NeighbourhoodType.KNIGHT) 
        nh = new TriangleKnightNeightbourHandler();
    }
    else if (mesh == MeshType.HEXAGON){
      if (neighbourhood == NeighbourhoodType.ULAM) 
        nh = new HexagonUlamNeightbourHandler();
      else if (neighbourhood == NeighbourhoodType.CONWAY)
        nh = new HexagonConwayNeightbourHandler();
      else if (neighbourhood == NeighbourhoodType.KNIGHT) 
        nh = new HexagonKnightNeightbourHandler();
    }
    else if (mesh == MeshType.PENTAGON1){
      if (neighbourhood == NeighbourhoodType.ULAM) 
        nh = new Pentagon1UlamNeightbourHandler();
      else if (neighbourhood == NeighbourhoodType.OBLIQUE) 
        nh = new Pentagon1ObliqueNeightbourHandler();
    }
    else if (mesh == MeshType.PENTAGON3){
      if (neighbourhood == NeighbourhoodType.ULAM) 
        nh = new Pentagon3UlamNeightbourHandler();
    }
    else if (mesh == MeshType.PENTAGON4){
      if (neighbourhood == NeighbourhoodType.ULAM) 
        nh = new Pentagon4UlamNeightbourHandler();
      else if (neighbourhood == NeighbourhoodType.CONWAY)
        nh = new Pentagon4ConwayNeightbourHandler();
    }
    else if (mesh == MeshType.KITE5){
      if (neighbourhood == NeighbourhoodType.ULAM) 
        nh = new Kite5UlamNeightbourHandler();
      else if (neighbourhood == NeighbourhoodType.CONWAY) 
        nh = new Kite5SmallConwayNeightbourHandler();
      else if (neighbourhood == NeighbourhoodType.OBLIQUE) 
        nh = new Kite5ObliqueNeightbourHandler();
      else if (neighbourhood == NeighbourhoodType.GREAT_CONWAY) 
        nh = new Kite5GrandConwayNeightbourHandler();
      }
    else if (mesh == MeshType.PENTAGON10){
      if (neighbourhood == NeighbourhoodType.ULAM) 
        nh = new Pentagon10UlamNeightbourHandler();
      else if (neighbourhood == NeighbourhoodType.CONWAY)
        nh = new Pentagon10ConwayNeightbourHandler();
      else if (neighbourhood == NeighbourhoodType.OBLIQUE) 
        nh = new Pentagon10ObliqueNeightbourHandler();
    }
    else if (mesh == MeshType.PENTAGON11){
      if (neighbourhood == NeighbourhoodType.ULAM) 
        nh = new Pentagon11UlamNeightbourHandler();
      else if (neighbourhood == NeighbourhoodType.CONWAY)
        nh = new Pentagon11ConwayNeightbourHandler();
      else if (neighbourhood == NeighbourhoodType.OBLIQUE) 
        nh = new Pentagon11ObliqueNeightbourHandler();
    }
    else if (mesh == MeshType.PENTAGON12){
      if (neighbourhood == NeighbourhoodType.ULAM) 
        nh = new Pentagon12UlamNeightbourHandler();
      else if (neighbourhood == NeighbourhoodType.CONWAY) 
        nh = new Pentagon12ConwayNeightbourHandler();
      else if (neighbourhood == NeighbourhoodType.OBLIQUE) 
        nh = new Pentagon12ObliqueNeightbourHandler();
      }
    else if (mesh == MeshType.PENTAGON14){
      if (neighbourhood == NeighbourhoodType.ULAM) 
        nh = new Pentagon14UlamNeightbourHandler();
      else if (neighbourhood == NeighbourhoodType.CONWAY)
        nh = new Pentagon14ConwayNeightbourHandler();
    }
    else if (mesh == MeshType.RECTANGLE1){
      if (neighbourhood == NeighbourhoodType.ULAM) 
        nh = new Rectangle1UlamNeightbourHandler();
    }
    else if (mesh == MeshType.RECTANGLE2){
      if (neighbourhood == NeighbourhoodType.ULAM) 
        nh = new Rectangle2UlamNeightbourHandler();
      else if (neighbourhood == NeighbourhoodType.CONWAY) 
        nh = new Rectangle2ConwayNeightbourHandler();
      }
    else if (mesh == MeshType.TILED_RECTANGLE1){
      if (neighbourhood == NeighbourhoodType.ULAM) 
        nh = new TiledRectangle1UlamNeightbourHandler();
      else if (neighbourhood == NeighbourhoodType.CONWAY)
        nh = new TiledRectangle1ConwayNeightbourHandler();
      else if (neighbourhood == NeighbourhoodType.OBLIQUE)
        nh = new TiledRectangle1ObliqueNeightbourHandler();
    }
    else if (mesh == MeshType.RECTANGLE_SQUARE){
      if (neighbourhood == NeighbourhoodType.ULAM) 
        nh = new RectangleSquareUlamNeightbourHandler();
      else if (neighbourhood == NeighbourhoodType.CONWAY)
        nh = new RectangleSquareConwayNeightbourHandler();
    }
    else if (mesh == MeshType.SQUARE_TRIANGLE1){
      if (neighbourhood == NeighbourhoodType.ULAM) 
        nh = new SquareTriangle1UlamNeightbourHandler();
      else if (neighbourhood == NeighbourhoodType.CONWAY) 
        nh = new SquareTriangle1ConwayNeightbourHandler();
      }
    else if (mesh == MeshType.SQUARE_TRIANGLE2){
      if (neighbourhood == NeighbourhoodType.ULAM) 
        nh = new SquareTriangle2UlamNeightbourHandler();
      else if (neighbourhood == NeighbourhoodType.CONWAY)
        nh = new SquareTriangle2ConwayNeightbourHandler();
    }
    else if (mesh == MeshType.HEXAGON_TRIANGLE1){
      if (neighbourhood == NeighbourhoodType.ULAM) 
        nh = new HexagonTriangleUlamNeightbourHandler();
      else if (neighbourhood == NeighbourhoodType.CONWAY)
        nh = new HexagonTriangleConwayNeightbourHandler();
    }
    else if (mesh == MeshType.HEXAGON_TRIANGLE2){
      if (neighbourhood == NeighbourhoodType.ULAM) 
        nh = new HexagonTriangle2UlamNeightbourHandler();
      else if (neighbourhood == NeighbourhoodType.CONWAY) 
        nh = new HexagonTriangle2ConwayNeightbourHandler();
      }
    else if (mesh == MeshType.OCTOGON_SQUARE){
      if (neighbourhood == NeighbourhoodType.ULAM) 
        nh = new OctogonSquareUlamNeightbourHandler();
    }
    else if (mesh == MeshType.DODECAGON_TRIANGLE){
      if (neighbourhood == NeighbourhoodType.ULAM) 
        nh = new DodecagonTriangleUlamNeightbourHandler();
    }
    else if (mesh == MeshType.HEXAGON_SQUARE_TRIANGLE){
      if (neighbourhood == NeighbourhoodType.ULAM) 
        nh = new HexagonSquareTriangleUlamNeightbourHandler();
      else if (neighbourhood == NeighbourhoodType.CONWAY) 
        nh = new HexagonSquareTriangleConwayNeightbourHandler();
      }
    else if (mesh == MeshType.DODECAGON_HEXAGON_SQUARE){
      if (neighbourhood == NeighbourhoodType.ULAM) 
        nh = new DodecagonHexagonSquareUlamNeightbourHandler();
    }
    return nh;
    }
  }

}