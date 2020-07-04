using System;

//Color record for drawing
  public struct color : ICloneable {
    public int red;
    public int green;
    public int blue;
    public int alpha;
    
  //It must be clonable, see ColorHandler class
    public object Clone(){
      return this.MemberwiseClone();
    }
    
    //A konstructor that makes the life more simple
    public color(int red, int green, int blue, int alpha){
      this.red = red;
      this.green = green;
      this.blue = blue;
      this.alpha = alpha;
    }
  }