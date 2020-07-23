package color;

enum Color {
  Rgb(r:Float, g:Float, b:Float);
  Hsv(h:Float, s:Float, v:Float);
  Named(name:String);
}

class Demo {

  static var namedColors: Map<String, Color> = [
    "red" => Rgb(1, 0, 0),
    "yellow" => Rgb(1, 1, 0),
    "blue" => Rgb(0, 0, 1),
  ];

  static public function colorToRgb(color:Color):Color {
    return switch (color) {
      case Rgb(_): color;
      case Hsv(h, s, v): hsvToRgb(h, s, v);
      case Named(name): namedColors[name];
    }
  }

  static public function hsvToRgb(h:Float, s:Float, v:Float):Color {
    return Rgb(h, s, v);
  }

  static public function main():Void {
    var named = Named("red");
    var colors = [Hsv(1, 1, 1), Named("yellow"), Rgb(0, 0, 1)];
    for (index => color in colors) {
      trace('Color ${index}: ${colorToRgb(color)}');
    }
  }

}
