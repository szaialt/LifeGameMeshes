using System;
using System.Drawing;
using System.Windows.Forms;
using matrix_handlers;
using neighbourhoods;
using coordinate_calculators;

//General settings form, expect of mesh and rules
class Settings : Form {
    private MeshType mesh;
    //Size in direction x
    private int sizeX;
    //Size in direction y
    private int sizeY;
    
    //Cancelling button
    private CheckBox cancel;
    //OK button
    private CheckBox ok;
    
    //Panel for setting starting matrix
    private Panel matrixPanel;
    private RadioButton pointRb;
    private RadioButton randomRb;
    //Panel for setting starting neighbourhood
    private Panel neighbourhoodPanel;
    private RadioButton ulamRb;
    private RadioButton conwayRb;
    private RadioButton knightRb;
    private RadioButton greatConwayRb;
    private RadioButton obliqueRb;

    public Settings(MeshType mesh) {
        this.mesh = mesh;
        Console.WriteLine(mesh);
        Text = "Beállítások";
        sizeX = 660;
        sizeY = 340;
        Size = new Size(sizeX, sizeY);
        
        //Cancelling button
        cancel = new CheckBox();
        cancel.Text = "Mégsem";
        cancel.Parent = this;
        cancel.Location = new Point(100, 215);
        cancel.BackColor = Color.Coral;
        cancel.Show();
        cancel.Visible = true;
        Controls.Add(cancel);
        
        //Okey button
        ok = new CheckBox();
        ok.Text = "OK";
        ok.Parent = this;
        ok.Location = new Point(400, 215);
        ok.BackColor = Color.Coral;
        ok.Show();
        ok.Visible = true;
        Controls.Add(ok);
        
        //Labels of panels
        Label matrixLabel = new Label();
        matrixLabel.Parent = this;
        matrixLabel.Text = "Kezdőmátrix";
        matrixLabel.Location = new Point(30, 30);
        matrixLabel.BackColor = Color.Coral;
        
        Label neighbourhoodLabel = new Label();
        neighbourhoodLabel.Parent = this;
        neighbourhoodLabel.Text = "Szomszédság";
        neighbourhoodLabel.Location = new Point(240, 30);
        neighbourhoodLabel.BackColor = Color.Coral;
        
        //Starting matrix is empty, expect of the middle point
        pointRb = new RadioButton();
        pointRb.Parent = this;
        pointRb.Location = new Point(30, 30);
        pointRb.Text = "Egy pont";
        pointRb.Checked = false;

        //Strationg matrix is filled by random
        randomRb = new RadioButton();
        randomRb.Parent = this;
        randomRb.Location = new Point(30, 60);
        randomRb.Text = "Véletlen";
        randomRb.Checked = false;
        
        matrixPanel = new Panel();
        matrixPanel.Parent = this;
        matrixPanel.Location = new Point(30, 30);
        matrixPanel.Text = "";
        matrixPanel.BackColor = Color.Coral;
        matrixPanel.Controls.Add(pointRb);
        matrixPanel.Controls.Add(randomRb);
        matrixPanel.AutoSize = true;
        
        CoordinateCalculatorFactory factory = new CoordinateCalculatorFactory();
        CoordinateCalculator cc = factory.produce(mesh);
        
        //Neighbours are cells joining by side
        if (cc.hasUlam()){
          ulamRb = new RadioButton();
          ulamRb.Parent = this;
          ulamRb.Location = new Point(150, 30);
          ulamRb.Text = "Ulam";
          ulamRb.Checked = false;
        }
        //Neighbours are cells joining by side or by diagonally
        if (cc.hasConway()){
          conwayRb = new RadioButton();
          conwayRb.Parent = this;
          conwayRb.Location = new Point(150, 60);
          conwayRb.Text = "Conway";
          conwayRb.Checked = false;
        }
        //Neighbours are cells at knight move
        if (cc.hasKnight()){
          knightRb = new RadioButton();
          knightRb.Parent = this;
          knightRb.Location = new Point(150, 90);
          knightRb.Text = "Lóugrás";
          knightRb.Checked = false;
        }
         //Neighbours are cells joining by side or by diagonally
        if (cc.hasGreatConway()){
          greatConwayRb = new RadioButton();
          greatConwayRb.Parent = this;
          greatConwayRb.Location = new Point(150, 120);
          greatConwayRb.Text = "Nagy Conway";
          greatConwayRb.Checked = false;
        }
        //Neighbours are cells that would join by side or by diagonally 
        //if the cells would be pentagons
        if (cc.hasOblique()){
          obliqueRb = new RadioButton();
          obliqueRb.Parent = this;
          obliqueRb.Location = new Point(150, 150);
          obliqueRb.Text = "Ferde";
          obliqueRb.Checked = false;
        }
        neighbourhoodPanel = new Panel();
        neighbourhoodPanel.Parent = this;
        neighbourhoodPanel.Location = new Point(150, 30);
        neighbourhoodPanel.Text = "";
        neighbourhoodPanel.BackColor = Color.Coral;
        
        neighbourhoodPanel.Controls.Add(ulamRb);
        neighbourhoodPanel.Controls.Add(conwayRb);
        neighbourhoodPanel.Controls.Add(knightRb);
        neighbourhoodPanel.Controls.Add(greatConwayRb);
        neighbourhoodPanel.Controls.Add(obliqueRb);
        
        neighbourhoodPanel.AutoSize = true;
        
        
        
      
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
      MatrixType matrix = MatrixType.RANDOM;
      NeighbourhoodType neighbourhood = NeighbourhoodType.CONWAY;
    
      if (pointRb.Checked){
        matrix = MatrixType.ONE_POINT;
      }
      else if (randomRb.Checked){
        matrix = MatrixType.RANDOM;
      }
      if (ulamRb.Checked){
        neighbourhood = NeighbourhoodType.ULAM;
      }
      else if (conwayRb.Checked){
        neighbourhood = NeighbourhoodType.CONWAY;
      }
      else if (knightRb.Checked){
        neighbourhood = NeighbourhoodType.KNIGHT;
      }
      else if (greatConwayRb.Checked){
        neighbourhood = NeighbourhoodType.GREAT_CONWAY;
      }
      else if (obliqueRb.Checked){
        neighbourhood = NeighbourhoodType.OBLIQUE;
      }

      if (mesh == MeshType.SQUARE)    {
         
            cancel.BackColor = Color.Red;
        
        }
        cancel.Show();
        cancel.Visible = true;
      //Constructs the window for RuleSettings
      RuleSettings rules = new RuleSettings(matrix, neighbourhood, mesh);
      rules.ShowDialog();
      this.Visible = false;
      this.Hide();
      this.Dispose();
    }
      
    }
    
    void OnExit(object sender, EventArgs e) {
        Close();
    }
}


