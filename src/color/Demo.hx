package color;

using color.Color;
using color.Convert;

class Demo {

  static public function main():Void {
    var colors = [Hsv(1, 1, 1), Named("yellow"), Rgb(0, 0, 1)];
    for (index => color in colors) {
      trace('Color ${index}: ${Convert.colorToRgb(color)}');
    }
  }

}
