namespace coordinate_calculators {

  using System;
  using System.Collections.Generic; 

  //Calculates coordinates of polygons given by coordinates
  public class CoordinateCalculatorFactory {
    
    public CoordinateCalculator produce(MeshType mesh){
      CoordinateCalculator cc = new SquareCoordinateCalculator();
      if (mesh == MeshType.TRIANGLE) {
        cc = new TriangleCoordinateCalculator();
      }
      else if (mesh == MeshType.HEXAGON) {
        cc = new HexagonCoordinateCalculator();
      }
      else if (mesh == MeshType.PENTAGON1) {
        cc = new Pentagon1CoordinateCalculator();
      }
      else if (mesh == MeshType.PENTAGON3) {
        cc = new Pentagon3CoordinateCalculator();
      }
      else if (mesh == MeshType.PENTAGON4) {
        cc = new Pentagon4CoordinateCalculator();
      }
      else if (mesh == MeshType.KITE5) {
        cc = new Kite5CoordinateCalculator();
      }
      else if (mesh == MeshType.PENTAGON10) {
        cc = new Pentagon10CoordinateCalculator();
      }
      else if (mesh == MeshType.PENTAGON11) {
        cc = new Pentagon11CoordinateCalculator();
      }
      else if (mesh == MeshType.PENTAGON12) {
        cc = new Pentagon12CoordinateCalculator();
      }
      else if (mesh == MeshType.PENTAGON14) {
        cc = new Pentagon14CoordinateCalculator();
      }
      else if (mesh == MeshType.RECTANGLE1) {
        cc = new Rectangle1CoordinateCalculator();
      }
      else if (mesh == MeshType.RECTANGLE2) {
        cc = new Rectangle2CoordinateCalculator();
      }
      else if (mesh == MeshType.TILED_RECTANGLE1) {
        cc = new TiledRectangle1CoordinateCalculator();
      }   
      else if (mesh == MeshType.RECTANGLE_SQUARE) {
        cc = new RectangleSquareCoordinateCalculator();
      }   
      else if (mesh == MeshType.SQUARE_TRIANGLE1) {
        cc = new SquareTriangle1CoordinateCalculator();
      }
      else if (mesh == MeshType.SQUARE_TRIANGLE2) {
        cc = new SquareTriangle1CoordinateCalculator();
      }
      else if (mesh == MeshType.HEXAGON_TRIANGLE1) {
        cc = new HexagonTriangleCoordinateCalculator();
      }
      else if (mesh == MeshType.OCTOGON_SQUARE) {
        cc = new SquareCoordinateCalculator();
      }
      else if (mesh == MeshType.DODECAGON_TRIANGLE) {
        cc = new HexagonTriangleCoordinateCalculator();
      }
      else if (mesh == MeshType.HEXAGON_TRIANGLE2){
        cc = new HexagonTriangle2CoordinateCalculator();
      }
      else if (mesh == MeshType.HEXAGON_SQUARE_TRIANGLE){
        cc = new HexagonSquareTriangleCoordinateCalculator();
      }
      else if (mesh == MeshType.DODECAGON_HEXAGON_SQUARE){
        cc = new HexagonSquareTriangleCoordinateCalculator();
      }
      return cc;
    }
  } 
	
}