using Tao.Sdl;
using System;
using System.Collections.Generic; 
using System.Linq;

public class ColorHandler {

  Random random;
  public const byte colorMaxValue = 255;
  const byte half = colorMaxValue/2;
  
  public ColorHandler(Random random) {
    this.random = random;
  }

  public int approximately(int x, int y, int d) {
    if (((x-y) < d) || ((y-x) < d)) return 0;
    else return 1;
  }
  
public List<T> CloneList<T>(List<T> originalList) where T : ICloneable
{
    return originalList.ConvertAll(x => (T) x.Clone());
}
  
public Dictionary<color, List<color> > generate_colors() {
  Dictionary<color, List<color> > colors = new Dictionary<color, List<color> >();
  List<color> clrs = generate_colors_();
  
  //fehér 0
  List<color> clrs_white = CloneList(clrs);
  clrs_white.RemoveAt(0);
  colors.Add(clrs[0], clrs_white);
  
    //rózsaszín1 1
  List<color> clrs_pink = CloneList(clrs);
  clrs_pink.RemoveAt(4);
  clrs_pink.RemoveAt(3);
  clrs_pink.RemoveAt(2);
  clrs_pink.RemoveAt(1);

  colors.Add(clrs[1], clrs_pink);
  
  //rózsaszín2 2
  colors.Add(clrs[2], clrs_pink);

  //rózsaszín3 3
  colors.Add(clrs[3], clrs_pink);

  //rózsaszín4 4
  colors.Add(clrs[4], clrs_pink);

  //piros1 5
  List<color> clrs_red = CloneList(clrs); //(List<color>)clrs.Clone();
  clrs_red.RemoveAt(15);
  clrs_red.RemoveAt(6);
  clrs_red.RemoveAt(5);
  colors.Add(clrs[5], clrs_red);
    
  //piros2 6
  colors.Add(clrs[6], clrs_red);

  //bordó 7
  List<color> clrs_bordeaux = CloneList(clrs);
  clrs_bordeaux.RemoveAt(23);
  clrs_bordeaux.RemoveAt(15);
  clrs_bordeaux.RemoveAt(7);
  colors.Add(clrs[7], clrs_bordeaux);

  //1 8
  List<color> clrs_orange = CloneList(clrs);
  clrs_orange.RemoveAt(22);
  clrs_orange.RemoveAt(21);
  clrs_orange.RemoveAt(16);
  clrs_orange.RemoveAt(15);
  clrs_orange.RemoveAt(10);
  clrs_orange.RemoveAt(9);
  clrs_orange.RemoveAt(8);
  colors.Add(clrs[8], clrs_orange);

    //2 9
  colors.Add(clrs[9], clrs_orange);

  //narancssárga3 10
  colors.Add(clrs[10], clrs_orange);

  //sárga 11
  List<color> clrs_yellow = CloneList(clrs);
  clrs_yellow.RemoveAt(23);
  clrs_yellow.RemoveAt(22);
  clrs_yellow.RemoveAt(21);
  clrs_yellow.RemoveAt(15);
  clrs_yellow.RemoveAt(11);
  colors.Add(clrs[11], clrs_yellow);

  //sárgászöld 12
  List<color> clrs_virid = CloneList(clrs);
  clrs_virid.RemoveAt(12);
  colors.Add(clrs[12], clrs_virid);

  //zöld1 13
List<color> clrs_green = CloneList(clrs);
  clrs_green.RemoveAt(14);
  clrs_green.RemoveAt(13);
  colors.Add(clrs[13], clrs_green);

  //zöld2 14
  colors.Add(clrs[14], clrs_green);

  //kékeszöld 15
  List<color> clrs_turquoise = CloneList(clrs);
  clrs_turquoise.RemoveAt(15);
  clrs_turquoise.RemoveAt(11);
  clrs_turquoise.RemoveAt(10);
  clrs_turquoise.RemoveAt(9);
  clrs_turquoise.RemoveAt(8);
  clrs_turquoise.RemoveAt(7);
  clrs_turquoise.RemoveAt(6);
  clrs_turquoise.RemoveAt(5);
  colors.Add(clrs[15], clrs_turquoise);

  //világoskék 16
  List<color> clrs_blue = CloneList(clrs);
  clrs_blue.RemoveAt(16);
  clrs_blue.RemoveAt(10);
  clrs_blue.RemoveAt(9);
  clrs_blue.RemoveAt(7);
  colors.Add(clrs[16], clrs_blue);

  //kék1 17
  List<color> clrs_blue2 = CloneList(clrs);
  clrs_blue2.RemoveAt(18);
  clrs_blue2.RemoveAt(17);
  colors.Add(clrs[17], clrs_blue2);

  //kék2 18
  colors.Add(clrs[18], clrs_blue2);

  //sötétkék 19
  List<color> clrs_blue3 = CloneList(clrs);
  clrs_blue3.RemoveAt(20);
  clrs_blue3.RemoveAt(19);
  colors.Add(clrs[19], clrs_blue3);

  //kékeslila 20
  colors.Add(clrs[20], clrs_blue3);

  //lila1 21
  List<color> clrs_lilac = CloneList(clrs);
  clrs_lilac.RemoveAt(22);
  clrs_lilac.RemoveAt(21);
  clrs_lilac.RemoveAt(11);
  clrs_lilac.RemoveAt(10);
  clrs_lilac.RemoveAt(9);
  clrs_lilac.RemoveAt(8);
  colors.Add(clrs[21], clrs_lilac);

  //lila2 22
  colors.Add(clrs[22], clrs_lilac);

  //bíbor 23
  List<color> clrs_purple = CloneList(clrs);
  clrs_purple.RemoveAt(23);
  clrs_purple.RemoveAt(11);
  clrs_purple.RemoveAt(8);
  colors.Add(clrs[23], clrs_purple);

  return colors;
}
 
public List<color> generate_age_colors() {   
  List<color> colors = new List<color>();
  //fehér
  color white = new color(colorMaxValue, colorMaxValue, colorMaxValue, colorMaxValue);
  colors.Add(white);
  
  //piros2
  color red2 = new color(colorMaxValue, 0, 0, colorMaxValue);
  colors.Add(red2);
  
  //kék1
  color blue1 = new color(0, 0, colorMaxValue, colorMaxValue);
  colors.Add(blue1);
  
  //lila1
  color lilac1 = new color(colorMaxValue/2, colorMaxValue/4, colorMaxValue, colorMaxValue);
  colors.Add(lilac1);
   
   //2
  color orange2 = new color(colorMaxValue, colorMaxValue/4, 0, colorMaxValue);
  colors.Add(orange2);
  
  //zöld1
  color dark_green = new color(0, colorMaxValue/2, 0, colorMaxValue);
  colors.Add(dark_green);
  
  //sárga
  color yellow = new color(colorMaxValue, colorMaxValue, 0, colorMaxValue);
  colors.Add(yellow);
  
  //bordó
  color bordeaux = new color(colorMaxValue/2, 0, 0, colorMaxValue);
  colors.Add(bordeaux);
  
    //világoskék
  color bright_blue = new color(colorMaxValue/2, colorMaxValue/2, colorMaxValue, colorMaxValue);
  colors.Add(bright_blue);
  
    //rózsaszín3
  color pink3 = new color(colorMaxValue/2, colorMaxValue/4, colorMaxValue/4, colorMaxValue);
  colors.Add(pink3);
  
    //sárgászöld
  color viridian = new color(colorMaxValue/3, colorMaxValue, 0, colorMaxValue);
  colors.Add(viridian);
  
    //kékeslila
  color bluish_lilac = new color(colorMaxValue/4, 0, colorMaxValue/2, colorMaxValue);
  colors.Add(bluish_lilac);
  
    return colors;
}
 
public List<color> generate_colors_() {   
  List<color> colors = new List<color>();
  //fehér
  color white = new color(colorMaxValue, colorMaxValue, colorMaxValue, colorMaxValue);
  colors.Add(white);
    
  //rózsaszín1
  color pink1 = new color(colorMaxValue, colorMaxValue/2, colorMaxValue/2, colorMaxValue);
  colors.Add(pink1);

    //rózsaszín2
  color pink2 = new color(colorMaxValue, colorMaxValue/3, colorMaxValue/3, colorMaxValue);
  colors.Add(pink2);

    //rózsaszín3
  color pink3 = new color(colorMaxValue/2, colorMaxValue/4, colorMaxValue/4, colorMaxValue);
  colors.Add(pink3);
  
    //rózsaszín4
  color pink4 = new color(colorMaxValue, 0, colorMaxValue/4, colorMaxValue);
  colors.Add(pink4);

    //piros1
  color red1 = new color(colorMaxValue, 0, colorMaxValue/16, colorMaxValue);
  colors.Add(red1);
    
      //piros2
  color red2 = new color(colorMaxValue, 0, 0, colorMaxValue);
  colors.Add(red2);

    //bordó
  color bordeaux = new color(colorMaxValue/2, 0, 0, colorMaxValue);
  colors.Add(bordeaux);

    //1
  color orange1 = new color(colorMaxValue/3, colorMaxValue/16, colorMaxValue, colorMaxValue);
  colors.Add(orange1);

      //2
  color orange2 = new color(colorMaxValue, colorMaxValue/4, 0, colorMaxValue);
  colors.Add(orange2);

    //narancssárga3
  color orange3 = new color(colorMaxValue, colorMaxValue/2, 0, colorMaxValue);
  colors.Add(orange3);

    //sárga
  color yellow = new color(colorMaxValue, colorMaxValue, 0, colorMaxValue);
  colors.Add(yellow);

    //sárgászöld
  color viridian = new color(colorMaxValue/3, colorMaxValue, 0, colorMaxValue);
  colors.Add(viridian);

    //zöld1
  color dark_green = new color(0, colorMaxValue/2, 0, colorMaxValue);
  colors.Add(dark_green);

    //zöld2
  color bright_green = new color(0, colorMaxValue, 0, colorMaxValue);
  colors.Add(bright_green);

    //kékeszöld
  color turquoise = new color(0, colorMaxValue/2, colorMaxValue/2, colorMaxValue);
  colors.Add(turquoise);

    //világoskék
  color bright_blue = new color(colorMaxValue/2, colorMaxValue/2, colorMaxValue, colorMaxValue);
  colors.Add(bright_blue);

  //kék1
  color blue1 = new color(0, 0, colorMaxValue, colorMaxValue);
  colors.Add(blue1);
  
    //kék2
  color blue2 = new color(colorMaxValue/4, colorMaxValue/2, colorMaxValue, colorMaxValue);
  colors.Add(blue2);

    //sötétkék
  color dark_blue = new color(0, 0, colorMaxValue/2, colorMaxValue);
  colors.Add(dark_blue);

    //kékeslila
  color bluish_lilac = new color(colorMaxValue/4, 0, colorMaxValue/2, colorMaxValue);
  colors.Add(bluish_lilac);

    //lila1
  color lilac1 = new color(colorMaxValue/2, colorMaxValue/4, colorMaxValue, colorMaxValue);
  colors.Add(lilac1);

    //lila2
  color lilac2 = new color(colorMaxValue/4, colorMaxValue/254, colorMaxValue/2, colorMaxValue);
  colors.Add(lilac2);

    //bíbor
  color purple = new color(colorMaxValue/2, 0, colorMaxValue/4, colorMaxValue);
  colors.Add(purple);

  return colors;
}

public color generate_light(color col){
  if (col.red < half) col.red = col.red + (colorMaxValue - col.red) / 2;;
  if (col.green < half) col.green = col.green + (colorMaxValue - col.green) / 2;;
  if (col.blue < half) col.blue = col.blue + (colorMaxValue - col.blue) / 2;;
  return col;     
} 
 
public color generate_dark(color col){
  int dist = 20;
  int wt = random.Next(0, 2);
  if ((col.red > half) && (col.green > half) && (col.blue > half)){
      //I still hate grey
    if (approximately(col.red, col.green, dist) == 0){
      if (wt == 1)
        col.red = col.red - half;
      else
        col.green = col.green - half;
    }
    else if (approximately(col.blue, col.green, dist) == 0){
      if (wt == 1)
        col.green = col.green - half;
      else
        col.blue = col.blue - half;
    }
    else if (approximately(col.blue, col.red, dist) == 0){
      if (wt == 1)
        col.red = col.red - half;
      else
        col.blue = col.blue - half;
    }
    else if ((col.red > col.green) && (col.red > col.blue)){
      if (wt == 1)
        col.green = col.green - half;
      else
        col.blue = col.blue - half;    
    }
    else if ((col.green > col.red) && (col.green > col.blue)){
      if (wt == 1)
        col.red = col.red - half;
      else
        col.blue = col.blue - half;
      }
    else if ((col.blue > col.green) && (col.blue > col.red)){
      col.blue = col.blue - half;
    }

    else {
      int wt2 = random.Next(0, 6);
    if (wt2 < 0){
       wt2 = wt2 + 6;
    }
    if (wt2 == 0){
       col.red = col.red - half;
     }
     else if (wt2 == 1){
       col.green = col.green - half;
     }
     else if (wt2 == 2){
       col.blue = col.blue - half;
     }
     else if (wt2 == 3){
       col.red = col.red - half;
       col.green = col.green - half;
     }
     else if (wt2 == 4){
       col.green = col.green - half;
       col.blue = col.blue - half;
     }
     else if (wt2 == 5){
       col.blue = col.blue - half;
       col.red = col.red - half;
     }
    }
  }
  return col;
}
} 