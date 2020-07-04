using Tao.Sdl;
using System;
using System.Collections.Generic; 
using System.Linq;
using System.Drawing;
using System.Windows.Forms;
using matrix_handlers;
using coordinate_calculators;
using neighbourhoods;

public class MainDrawing {
  Random random = new Random();

  //Setted information
  private MatrixType matrix;
  private NeighbourhoodType neighbourhood;
  private MeshType mesh;
  private List<int> borns;
  private List<int> survives;
  private bool ageT;
  
  public MainDrawing(MatrixType matrix, //= MatrixType.RANDOM, 
                NeighbourhoodType neighbourhood, //= NeighbourhoodType.CONWAY, 
                MeshType mesh, //= MeshType.SQUARE,
                List<int> borns, //= {2, 3},
                List<int> survives, //= {2},
                bool ageT //= false*/
                ){
    this.matrix = matrix;
    this.neighbourhood = neighbourhood;
    this.mesh = mesh;
    this.borns = borns;
    this.survives = survives;
    this.ageT = ageT;
      
  }
  
    //Maximum function
  int max(int a, int b){
    if (a > b) return a;
    else return b;
  } 
  
  [STAThread]
  public void Drawing() {
    //Default colors
    color black = new color(0, 0, 0, ColorHandler.colorMaxValue);

    color white = new color(ColorHandler.colorMaxValue, ColorHandler.colorMaxValue, ColorHandler.colorMaxValue, ColorHandler.colorMaxValue);

   //Initialization of graphics and opening painting window
   Sdl.SDL_Event ev = new Sdl.SDL_Event();
 
    Sdl.SDL_Init(Sdl.SDL_INIT_VIDEO);
    System.IntPtr screen = Sdl.SDL_SetVideoMode(0, 0, 0, Sdl.SDL_ANYFORMAT);
     if (screen == IntPtr.Zero) {
         System.Console.WriteLine("Nem sikerult megnyitni az ablakot!\n");
         return;
     }
    Sdl.SDL_WM_SetCaption("SDL peldaprogram", "SDL peldaprogram");

    //Sets NeightbourHandler
    NeightbourhoodFactory nfactory = new NeightbourhoodFactory();
    NeightbourHandler nh = nfactory.produce(mesh, neighbourhood);
    //Sets MatrixHandler and ColorHandler
    MatrixHandler game = new QuadraticMatrixHandler(random, nh, ageT);
    ColorHandler ch = new ColorHandler(random);

    //Gets sizes of screen
    int width = Screen.PrimaryScreen.Bounds.Width;
    int height = Screen.PrimaryScreen.Bounds.Height;

    //Calculates main datas
    int cellSize = 10;
    const int half = ColorHandler.colorMaxValue/2;
    const int state_number = 2;
    int n = width/cellSize;
    int m = height/cellSize;
    int del = 0;
    int delt = max(n, m) * 2;
   
    //Sets CoordinateCalculator
    CoordinateCalculatorFactory factory = new CoordinateCalculatorFactory();
    CoordinateCalculator cc = factory.produce(mesh);
    
    //Sets sizes of the matrix to fill the full monitor
    if (mesh == MeshType.PENTAGON10) {
      n = n * 2;
      m = m * 2;
    }
    else if (mesh == MeshType.PENTAGON11) {
      m = m * 2;
    }
    else if (mesh == MeshType.PENTAGON12) {
      m = m * 2;
    }  
    else if (mesh == MeshType.RECTANGLE_SQUARE) {
      m = m * 2;
    }   
    else if (mesh == MeshType.SQUARE_TRIANGLE1) {
      m = m * 2;
    }
    else if (mesh == MeshType.SQUARE_TRIANGLE2) {
      m = m * 4;
    }
    else if (mesh == MeshType.HEXAGON_TRIANGLE1) {
      m = m * 3;
    }
    else if (mesh == MeshType.DODECAGON_TRIANGLE) {
      m = m * 3;
    }
    else if (mesh == MeshType.HEXAGON_TRIANGLE2){
      m = m * 5;
    }
    else if (mesh == MeshType.HEXAGON_SQUARE_TRIANGLE){
      m = m * 2;
    }
    else if (mesh == MeshType.DODECAGON_HEXAGON_SQUARE){
      m = m * 2;
    }
    
    //Generates random matrix as default 
    double probability = 0.3;
    ModuloIndexableList<ModuloIndexableList<int> > cell_matrix  = 
           game.generate_random_matrix(n,m,probability);
    if (matrix == MatrixType.ONE_POINT){
      cell_matrix = game.generate_matrix(n, m);
    }

    //Adds state rules in order of states
    List<List<int> > rule = new List<List<int> >();
    rule.Add(borns);
    rule.Add(survives);

    //Generating and setting colors
    List<color> colors = ch.generate_colors_();
    int index1 = random.Next(0, colors.Count);
    color c1 = colors[index1];
    Dictionary<color, List<color> > color_matrix = ch.generate_colors();
    List<color> cls = color_matrix[c1];
    int index2 = random.Next(0, cls.Count);
    color col = cls[index2];
    color col1 = white;
    color col2 = black;

    int wt = random.Next(0, 6);
    if (wt == 0) {
      col1 = c1;
      col2 = ch.generate_dark(col);
    }
    else if (wt == 1) {
      col1 = ch.generate_light(col);
      col2 = c1;
    }
    else if (wt == 2) {
      col1 = col;
      col2 = c1;
    }
    else if (wt == 3) {
      col1 = c1;
      col2 = col;
    }
    else if (wt == 4) {
      col1 = c1;
      col2 = ch.generate_light(col);
    }
    if (wt == 5) {
      col1 = ch.generate_dark(col);
      col2 = c1;
    }
    Sdl.SDL_WaitEvent(out ev);
    //Drawing loop
    while (ev.type!=Sdl.SDL_QUIT && ev.type != Sdl.SDL_KEYDOWN){
       if (ev.type == Sdl.SDL_KEYDOWN)
         {
          
          System.Console.WriteLine("Billentyű észlelve.");
          Sdl.SDL_Quit();
        }
      else if (ev.type == Sdl.SDL_MOUSEBUTTONDOWN)
         {
           
          System.Console.WriteLine("Egér észlelve.");
          Sdl.SDL_Quit();
        }
        
        for (int i = 0; i < n; i++){
          for (int j = 0; j < m; j++){
            if (mesh == MeshType.SQUARE){
              short x1 = (short)(i*cellSize + 1);
              short y1 = (short)(j*cellSize + 1);  
              short x2 = (short)((i+1)*cellSize);
              short y2 = (short)((j+1)*cellSize); 
 
            // drawing quadratic mesh with age                
            if (ageT){
              List<color> cols = ch.generate_age_colors();
              if (cell_matrix[i][j] == 0) {
                Tao.Sdl.SdlGfx.boxRGBA(screen, x1, y1, x2, y2,
                (byte)(black.red), (byte)(black.green), (byte)(black.blue), (byte)(black.alpha));
              }
              else {
                int ix = cell_matrix[i][j] % cols.Count;
                if (ix < 0) ix = ix + cols.Count;
                Tao.Sdl.SdlGfx.boxRGBA(screen, x1, y1, x2, y2,
                (byte)((cols[ix]).red), (byte)((cols[ix]).green), (byte)((cols[ix]).blue), (byte)(cols[ix].alpha));
              }
            }
              else {
                // drawing quadratic mesh without age  
              if (cell_matrix[i][j] == 1)
                Tao.Sdl.SdlGfx.boxRGBA(screen, x1, y1, x2, y2,
                (byte)(col2.red), (byte)(col2.green), (byte)(col2.blue), (byte)(col2.alpha));
              else if (cell_matrix[i][j] == 0)
                Tao.Sdl.SdlGfx.boxRGBA(screen, x1, y1, x2, y2,
                (byte)(col1.red), (byte)(col1.green), (byte)(col1.blue), (byte)(col1.alpha));
              }
            }
            else {
            // drawing another mesh 
              List<Tuple<double, double>> points = cc.calculate_polygon_coordinates(i, j);
              short[] vx = new short[points.Count];
              short[] vy = new short[points.Count];
              for (int k = 0; k < points.Count; k++){
                double xx = points[k].Item1;
                double yy = points[k].Item2;
                xx = xx * cellSize;
                yy = yy * cellSize;
                if (mesh == MeshType.TRIANGLE){
                  //to have better rates of sides and hights
                  xx = xx * Math.Sqrt(3);
                  //to set the middle into the middle
                  xx = xx - width/14;
                  yy = yy - height/21;
                }
                else if (mesh == MeshType.HEXAGON){
                  xx = xx  * 2;
                  //to set the middle into the middle
                  xx = xx -  2 * width/9;
                  yy = yy - height/35;
                }
                else if (mesh == MeshType.PENTAGON1){
                   //to set the middle into the middle
                   yy = yy - height/3;
                }
                else if (mesh == MeshType.PENTAGON3){
                   //to set the middle into the middle
                  xx = xx - width/2;
                  yy = yy - height;
                }
                else if (mesh == MeshType.PENTAGON11){
                  //to set the middle into the middle
                  xx = xx - 1.75 * width;
                }
                else if (mesh == MeshType.PENTAGON14){
                   xx = xx  * 2;
                  //to set the middle into the middle
                  xx = xx - 2 * width/9 - width/4;
                  yy = yy - height/35;
                  yy = 2 * yy + height/8;
                 }
                else if (mesh == MeshType.RECTANGLE1){
                   //to set the middle into the middle
                   //rotating by 45 degrees
                   double zz = Math.Sqrt(2)/2 * xx + Math.Sqrt(3)/2 * yy;
                   xx = -Math.Sqrt(3)/2 * xx + Math.Sqrt(2)/2 * yy + (3/2) * width + 2 * width/5;
                   yy = zz - height/2 - height/4;
                   xx = xx + width/12;
                 }
                 else if (mesh == MeshType.RECTANGLE2){
                   //to set the middle into the middle
                   xx = xx - width/2;
                 }
                 else if ((mesh == MeshType.TILED_RECTANGLE1) || (mesh == MeshType.RECTANGLE_SQUARE)){
                   //to set the middle into the middle
                   //rotating by 45 degrees
                   double zz = Math.Sqrt(2)/2 * xx + Math.Sqrt(3)/2 * yy;
                   xx = -Math.Sqrt(3)/2 * xx + Math.Sqrt(2)/2 * yy + (3/2) * width + 2 * width/5;
                   yy = zz - height/2 - height/4;
                   if (mesh == MeshType.TILED_RECTANGLE1){
                     xx = xx + width/8;
                   }
                   else {
                     xx = xx - width/8;
                     yy = yy - height/12;
                   }
                 }
                 else if ((mesh == MeshType.SQUARE_TRIANGLE1) || (mesh == MeshType.SQUARE_TRIANGLE2)){
                 //to set the middle into the middle
                 yy = yy - height/8;
                }
                
                 else if ((mesh == MeshType.HEXAGON_SQUARE_TRIANGLE) || (mesh == MeshType.DODECAGON_HEXAGON_SQUARE)){
                  xx = xx * 2;
                  yy = yy * 2;
                  //to set the middle into the middle
                  xx = xx - width/2;
                  yy = yy - height/12;
                }
                else if (mesh == MeshType.HEXAGON_TRIANGLE2){
                  //to set the middle into the middle
                  xx = xx - 2*width/3;
                  yy = yy - 3*height;
                }
                int xt = (int)xx;
                int yt = (int)yy;
                short xs = (short)xt;
                short ys = (short)yt;
                vx[k] = xs;
                vy[k] = ys;
                if ((mesh == MeshType.TRIANGLE) || (mesh == MeshType.HEXAGON)){
                  vx[k] = ys;
                  vy[k] = xs;
                }
                
              }
              if (ageT){
                // drawing mesh with age  
                List<color> cols = ch.generate_age_colors();
                if (cell_matrix[i][j] == 0) {
                Tao.Sdl.SdlGfx.filledPolygonRGBA (screen, vx, vy, points.Count, 
                   (byte)(black.red), (byte)(black.green), (byte)(black.blue), (byte)(black.alpha));
                }
                else {
                int ix = cell_matrix[i][j] % cols.Count;
                if (ix < 0) ix = ix + cols.Count;
                Tao.Sdl.SdlGfx.filledPolygonRGBA (screen, vx, vy, points.Count, 
                  (byte)((cols[ix]).red), (byte)((cols[ix]).green), (byte)((cols[ix]).blue), (byte)(cols[ix].alpha));
                }
              }
              else {
                // drawing mesh without age  
              if (cell_matrix[i][j] == 1){
              Tao.Sdl.SdlGfx.filledPolygonRGBA (screen, vx, vy, points.Count, 
                (byte)(col2.red), (byte)(col2.green), (byte)(col2.blue), (byte)(col2.alpha));
              }
              else if (cell_matrix[i][j] == 0){
              Tao.Sdl.SdlGfx.filledPolygonRGBA (screen, vx, vy, points.Count, 
                (byte)(col1.red), (byte)(col1.green), (byte)(col1.blue), (byte)(col1.alpha));
              }
              
              }
            }
          }
        }
       
      if (del == delt){
      //Generates new beginning matrix with new colors
        if (matrix == MatrixType.RANDOM)
          cell_matrix = game.generate_random_matrix(n,m,probability);
        else if (matrix == MatrixType.ONE_POINT){
          cell_matrix = game.generate_matrix(n, m);
        del = 0;
        }
        wt = random.Next(0, 6);
        if (wt == 0) {
          col1 = c1;
          col2 = ch.generate_dark(col);
        }
        else if (wt == 1) {
          col1 = ch.generate_light(col);
          col2 = c1;
        }
        else if (wt == 2) {
          col1 = col;
          col2 = c1;
        }
        else if (wt == 3) {
          col1 = c1;
          col2 = col;
        }
        else if (wt == 4) {
          col1 = c1;
          col2 = ch.generate_light(col);
        }
        if (wt == 5) {
          col1 = ch.generate_dark(col);
          col2 = c1;
        }
      }
      else {
        cell_matrix = game.new_matrix(cell_matrix, rule);
       }

     /* Flips drawings */
     Sdl.SDL_Flip(screen);
     Sdl.SDL_WaitEvent(out ev);
     System.Threading.Thread.Sleep(1000);
        
    del = del + 1;
    }
 
    /* closing window */
    Sdl.SDL_Quit();
    return;
  }
 
}