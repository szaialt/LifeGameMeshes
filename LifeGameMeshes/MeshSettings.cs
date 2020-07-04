using System;
using System.Drawing;
using System.Windows.Forms;
using matrix_handlers;
using neighbourhoods;

//Settings form for meshes
class MeshSettings : Form {
    //Panel for setting starting mesh   
    //Size in direction x
    private int sizeX;
    //Size in direction y
    private int sizeY;
    
    //Cancelling button
    private CheckBox cancel;
    //OK button
    private CheckBox ok;
    private Panel meshPanel;
    //Radiobuttons for meshes
    private RadioButton squareRb;
    private RadioButton triangleRb;
    private RadioButton hexagonRb;    
    private RadioButton pentagon1Rb;
    private RadioButton pentagon3Rb;
    private RadioButton pentagon4Rb;    
    private RadioButton kite5Rb;
    private RadioButton pentagon10Rb;
    private RadioButton pentagon11Rb;
    private RadioButton pentagon12Rb;
    private RadioButton pentagon14Rb;
    private RadioButton rectangle1Rb;    
    private RadioButton rectangle2Rb;
    private RadioButton tiledRectangle1Rb;
    private RadioButton rectangleSquareRb;
    private RadioButton squareTriangle1Rb;
    private RadioButton squareTriangle2Rb;
    private RadioButton hexagonTriangle1Rb;
    private RadioButton hexagonTriangle2Rb;
    private RadioButton octogonSquareRb;
    private RadioButton dodecagonTriangleRb;
    private RadioButton hexagonSquareTriangleRb;
    private RadioButton dodecagonHexagonSquareRb;
    
    //To set the mesh
    public MeshSettings() {
      Text = "Rács beállítása";
      sizeX = 660;
      sizeY = 340;
      Size = new Size(sizeX, sizeY);
      
      //Cancelling button
        cancel = new CheckBox();
        cancel.Text = "Mégsem";
        cancel.Parent = this;
        cancel.Location = new Point(100, 235);
        cancel.BackColor = Color.Coral;
        cancel.Show();
        cancel.Visible = true;
        Controls.Add(cancel);
        
        //Okey button
        ok = new CheckBox();
        ok.Text = "OK";
        ok.Parent = this;
        ok.Location = new Point(400, 235);
        ok.BackColor = Color.Coral;
        ok.Show();
        ok.Visible = true;
        Controls.Add(ok);
      
      //Square mesh
        squareRb = new RadioButton();
        squareRb.Parent = this;
        squareRb.Location = new Point(10, 30);
        squareRb.Text = "Négyzetrács";
        squareRb.Checked = false;
        
        //Triangle mesh
        triangleRb = new RadioButton();
        triangleRb.Parent = this;
        triangleRb.Location = new Point(10, 60);
        triangleRb.Text = "Háromszögrács";
        triangleRb.Checked = false;
      
        //Hexagon mesh
        hexagonRb = new RadioButton();
        hexagonRb.Parent = this;
        hexagonRb.Location = new Point(10, 90);
        hexagonRb.Text = "Hatszögrács";
        hexagonRb.Checked = false;
        
        //Pentagon1 mesh
        pentagon1Rb = new RadioButton();
        pentagon1Rb.Parent = this;
        pentagon1Rb.Location = new Point(10, 120);
        pentagon1Rb.Text = "Ötszögrács 1";
        pentagon1Rb.Checked = false;
        
        //Pentagon3 mesh
        pentagon3Rb = new RadioButton();
        pentagon3Rb.Parent = this;
        pentagon3Rb.Location = new Point(10, 150);
        pentagon3Rb.Text = "Ötszögrács 3";
        pentagon3Rb.Checked = false;
      
        //Pentagon4 mesh
        pentagon4Rb = new RadioButton();
        pentagon4Rb.Parent = this;
        pentagon4Rb.Location = new Point(10, 180);
        pentagon4Rb.Text = "Ötszögrács 4";
        pentagon4Rb.Checked = false;
        
        //Kite5 mesh
        kite5Rb = new RadioButton();
        kite5Rb.Parent = this;
        kite5Rb.Location = new Point(160, 30);
        kite5Rb.Text = "Deltoidrács";
        kite5Rb.Checked = false;
        
        //Pentagon10 mesh
        pentagon10Rb = new RadioButton();
        pentagon10Rb.Parent = this;
        pentagon10Rb.Location = new Point(160, 60);
        pentagon10Rb.Text = "Ötszögrács 10";
        pentagon10Rb.Checked = false;
      
        //Pentagon11 mesh
        pentagon11Rb = new RadioButton();
        pentagon11Rb.Parent = this;
        pentagon11Rb.Location = new Point(160, 90);
        pentagon11Rb.Text = "Ötszögrács 11";
        pentagon11Rb.Checked = false;
        
        //Pentagon12 mesh
        pentagon12Rb = new RadioButton();
        pentagon12Rb.Parent = this;
        pentagon12Rb.Location = new Point(160, 120);
        pentagon12Rb.Text = "Ötszögrács 12";
        pentagon12Rb.Checked = false;
        
        //Pentagon14 mesh
        pentagon14Rb = new RadioButton();
        pentagon14Rb.Parent = this;
        pentagon14Rb.Location = new Point(160, 150);
        pentagon14Rb.Text = "Ötszögrács 14";
        pentagon14Rb.Checked = false;
      
        //Rectangle1 mesh
        rectangle1Rb = new RadioButton();
        rectangle1Rb.Parent = this;
        rectangle1Rb.Location = new Point(160, 180);
        rectangle1Rb.Text = "Téglalaprács 1";
        rectangle1Rb.Checked = false;
        
        //Rectangle2 mesh
        rectangle2Rb = new RadioButton();
        rectangle2Rb.Parent = this;
        rectangle2Rb.Location = new Point(320, 30);
        rectangle2Rb.Text = "Téglalaprács 2";
        rectangle2Rb.Checked = false;
        
        //Tiled rectangle1  mesh
        tiledRectangle1Rb = new RadioButton();
        tiledRectangle1Rb.Parent = this;
        tiledRectangle1Rb.Location = new Point(320, 60);
        tiledRectangle1Rb.Text = "Felosztott téglalaprács";
        tiledRectangle1Rb.Checked = false;
      
        //Rectangle-square mesh
        rectangleSquareRb = new RadioButton();
        rectangleSquareRb.Parent = this;
        rectangleSquareRb.Location = new Point(320, 90);
        rectangleSquareRb.Text = "Téglalap- és négyzet rács";
        rectangleSquareRb.Checked = false;
        
        //Square-triangle1 mesh
        squareTriangle1Rb = new RadioButton();
        squareTriangle1Rb.Parent = this;
        squareTriangle1Rb.Location = new Point(320, 120);
        squareTriangle1Rb.Text = "Négyzet- és háromszögrács 1";
        squareTriangle1Rb.Checked = false;
        
        //Square-triangle2 mesh
        squareTriangle2Rb = new RadioButton();
        squareTriangle2Rb.Parent = this;
        squareTriangle2Rb.Location = new Point(320, 150);
        squareTriangle2Rb.Text = "Négyzet- és háromszögrács 2";
        squareTriangle2Rb.Checked = false;
      
        //Hexagon-triangle1 mesh
        hexagonTriangle1Rb = new RadioButton();
        hexagonTriangle1Rb.Parent = this;
        hexagonTriangle1Rb.Location = new Point(320, 180);
        hexagonTriangle1Rb.Text = "Hatszög- és háromszög rács 1";
        hexagonTriangle1Rb.Checked = false;
        
        //Hexagon-triangle2 mesh
        hexagonTriangle2Rb = new RadioButton();
        hexagonTriangle2Rb.Parent = this;
        hexagonTriangle2Rb.Location = new Point(460, 30);
        hexagonTriangle2Rb.Text = "Hatszög- és háromszög rács 2";
        hexagonTriangle2Rb.Checked = false;
        
        //Octogon-square mesh
        octogonSquareRb = new RadioButton();
        octogonSquareRb.Parent = this;
        octogonSquareRb.Location = new Point(460, 60);
        octogonSquareRb.Text = "Nyolcsszög- és négyzet rács";
        octogonSquareRb.Checked = false;
      
        //Dodecagon-triangle mesh
        dodecagonTriangleRb = new RadioButton();
        dodecagonTriangleRb.Parent = this;
        dodecagonTriangleRb.Location = new Point(460, 90);
        dodecagonTriangleRb.Text = "Tizenkétszög- és háromszög rács";
        dodecagonTriangleRb.Checked = false;
        
        //Hexagon-square-triangle mesh
        hexagonSquareTriangleRb = new RadioButton();
        hexagonSquareTriangleRb.Parent = this;
        hexagonSquareTriangleRb.Location = new Point(460, 120);
        hexagonSquareTriangleRb.Text = "Hatszög-, négyzet- és háromszög rács";
        hexagonSquareTriangleRb.Checked = false;
        
        //Dodecagon-hexagon-sqzare mesh
        dodecagonHexagonSquareRb = new RadioButton();
        dodecagonHexagonSquareRb.Parent = this;
        dodecagonHexagonSquareRb.Location = new Point(460, 150);
        dodecagonHexagonSquareRb.Text = "Tizenkétszög-, hatszög- és négyzet rács";
        dodecagonHexagonSquareRb.Checked = false;
      
      
      meshPanel = new Panel();
        meshPanel.Parent = this;
        meshPanel.Location = new Point(0, 0);
        meshPanel.Text = "";
        meshPanel.BackColor = Color.Coral;
        meshPanel.Controls.Add(squareRb);
        meshPanel.Controls.Add(triangleRb);  
        meshPanel.Controls.Add(hexagonRb);  
        meshPanel.Controls.Add(pentagon1Rb);
        meshPanel.Controls.Add(pentagon3Rb);  
        meshPanel.Controls.Add(pentagon4Rb); 
        meshPanel.Controls.Add(kite5Rb);
        meshPanel.Controls.Add(pentagon10Rb);  
        meshPanel.Controls.Add(pentagon11Rb); 
        meshPanel.Controls.Add(pentagon12Rb);
        meshPanel.Controls.Add(pentagon14Rb);  
        meshPanel.Controls.Add(rectangle1Rb); 
        meshPanel.Controls.Add(rectangle2Rb);
        meshPanel.Controls.Add(tiledRectangle1Rb);  
        meshPanel.Controls.Add(rectangleSquareRb); 
        meshPanel.Controls.Add(squareTriangle1Rb);
        meshPanel.Controls.Add(squareTriangle2Rb);  
        meshPanel.Controls.Add(hexagonTriangle1Rb); 
        meshPanel.Controls.Add(hexagonTriangle2Rb);
        meshPanel.Controls.Add(octogonSquareRb);  
        meshPanel.Controls.Add(dodecagonTriangleRb);
        meshPanel.Controls.Add(hexagonSquareTriangleRb);
        meshPanel.Controls.Add(dodecagonHexagonSquareRb);  
        meshPanel.AutoSize = true;
        
        //The eventhandler of the buttons is the function OnChanged(object sender, EventArgs e)
        cancel.CheckedChanged += new EventHandler(OnChanged);
        ok.CheckedChanged += new EventHandler(OnChanged);
        Paint += new PaintEventHandler(OnPaint);
        CenterToScreen();
    }
    
        void OnPaint(object sender, PaintEventArgs e)
    {      
        Graphics g = e.Graphics;
            
        g.FillRectangle(Brushes.Coral, 0, 0, sizeX, sizeY);

        g.Dispose();
        
    }
      
    void OnChanged(object sender, EventArgs e)
    {
    CheckBox clickedButton = sender as CheckBox;
    //CheckBox clickedButton = (CheckBox)sender;
    if (clickedButton == null) // just to be on the safe side
        return;

    //Cancel closes the window
    if (cancel.Checked)
    {
      Close();
    }
    //OK sends the information
    else if(ok.Checked)
    {
      //Sending information to the next form, 
      //that saves and gives away it.
      MeshType mesh = MeshType.SQUARE;
    
      if (squareRb.Checked){
        mesh = MeshType.SQUARE;
      }
      else if (triangleRb.Checked){
        mesh = MeshType.TRIANGLE;
      }
      else if (hexagonRb.Checked){
        mesh = MeshType.HEXAGON;
      }
      
      else if (pentagon1Rb.Checked){
        mesh = MeshType.PENTAGON1;
      }
      else if (pentagon3Rb.Checked){
        mesh = MeshType.PENTAGON3;
      }
      else if (pentagon4Rb.Checked){
        mesh = MeshType.PENTAGON4;
      }
      else if (kite5Rb.Checked){
        mesh = MeshType.KITE5;
      }
      else if (pentagon10Rb.Checked){
        mesh = MeshType.PENTAGON10;
      }
      else if (pentagon11Rb.Checked){
        mesh = MeshType.PENTAGON11;
      }
      else if (pentagon12Rb.Checked){
        mesh = MeshType.PENTAGON12;
      }
      else if (pentagon14Rb.Checked){
        mesh = MeshType.PENTAGON14;
      }
      else if (rectangle1Rb.Checked){
        mesh = MeshType.RECTANGLE1;
      }
      else if (rectangle2Rb.Checked){
        mesh = MeshType.RECTANGLE2;
      }
      else if (tiledRectangle1Rb.Checked){
        mesh = MeshType.TILED_RECTANGLE1;
      }
      else if (rectangleSquareRb.Checked){
        mesh = MeshType.RECTANGLE_SQUARE;
      }
      else if (squareTriangle1Rb.Checked){
        mesh = MeshType.SQUARE_TRIANGLE1;
      }
      else if (squareTriangle2Rb.Checked){
        mesh = MeshType.SQUARE_TRIANGLE2;
      }
      else if (hexagonTriangle1Rb.Checked){
        mesh = MeshType.HEXAGON_TRIANGLE1;
      }
      else if (hexagonTriangle2Rb.Checked){
        mesh = MeshType.HEXAGON_TRIANGLE2;
      }
      else if (octogonSquareRb.Checked){
        mesh = MeshType.OCTOGON_SQUARE;
      }
      else if (dodecagonTriangleRb.Checked){
        mesh = MeshType.DODECAGON_TRIANGLE;
      }
      else if (hexagonSquareTriangleRb.Checked){
        mesh = MeshType.HEXAGON_SQUARE_TRIANGLE;
      }
      else if (dodecagonHexagonSquareRb.Checked){
        mesh = MeshType.DODECAGON_HEXAGON_SQUARE;
      }
      Console.WriteLine(mesh);
      Settings settings = new Settings(mesh);
      settings.ShowDialog();

    }
      
    
    // Ha az előbbiek felsorolási típusok lesznek, akkor itt konstruáljuk meg
    // az él-hal szabály párbeszédablakát
    }
    
    void OnExit(object sender, EventArgs e) {
        Close();
    }
}

class MApplication {
  public static void Main() {
    Application.Run(new MeshSettings());
  }
}