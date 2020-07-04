//Type to set mesh
public enum MeshType
    {
	SQUARE, //Regular square tiling
	TRIANGLE, //Regular triangle tiling
	HEXAGON, //Regular hexagon tiling
	PENTAGON1, //Tiling that resembles to pentagonal tiling type 1
	PENTAGON3, //Tiling that resembles to pentagonal tiling type 3
	PENTAGON4, //Tiling that resembles to pentagonal tiling type 4
	KITE5, //Kite tiling that resembles to pentagonal tiling type 5
	PENTAGON10, //Tiling that resembles to pentagonal tiling type 10
	PENTAGON11, //Tiling that resembles to pentagonal tiling type 11
	PENTAGON12, //Tiling that resembles to pentagonal tiling type 12
	PENTAGON14, //Tiling that resembles to pentagonal tiling type 14
	RECTANGLE1, //Rectangular tiling that resembles to parquetry
	RECTANGLE2, //Rectangluar tiling that also tiles squares
	TILED_RECTANGLE1, //Tiled rectangluar1 tiling that resembles to PENTAGON13
	RECTANGLE_SQUARE, //Tiling with rectangles and squares
	SQUARE_TRIANGLE1, //Tiling that resembles the hexagon-tiling with triangles 
	//and squares
	SQUARE_TRIANGLE2,  // is not implemented; another semiregular tiling with 
	//squares and triangles
	HEXAGON_TRIANGLE1, //Semi-regular tiling with hexagons and triangles, it 
	//makes rows
	HEXAGON_TRIANGLE2, //Another tiling with hexagons and triangles
	OCTOGON_SQUARE, //Tiling that resembles to the semiregular tiling with 
	//octogons and squares; with graphics of SQUARE
	DODECAGON_TRIANGLE, //Tiling that resembles to the semiregular tiling with 
	//dodecagons and triangles; with the graphics of HEXAGON_TRIANGLE1
	HEXAGON_SQUARE_TRIANGLE, //Tiling that resembles to the semiregular tiling 
	//with hexagons, squares and triangles
	DODECAGON_HEXAGON_SQUARE // Tiling that resembles to the semiregular 
	//tiling with dodecagons and triangles; with the graphics of 
	//HEXAGON_SQUARE_TRIANGLE
    };