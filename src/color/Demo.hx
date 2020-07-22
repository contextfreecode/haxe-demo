package color;

enum Color {
  Rgb(r:Float, g:Float, b:Float);
  Hsv(h:Float, s:Float, v:Float);
  Named(name:String);
}

class Demo {

  static public function toRgb(color:Color): Color {
    return switch (color) {
      case Rgb(_): color;
      case Hsv(h, s, v): color;
      case Named(name): color;
    }
  }

  static public function main():Void {
    var named = Named("red");
    trace("Hi there!");
  }

}
