package color;

class Hsv {
  public var h:Float;
  public var s:Float;
  public var v:Float;
  public function new(h:Float, s:Float, v:Float) {
    this.h = h;
    this.s = s;
    this.v = v;
  }
}

// typedef Hsv = {h:Float, s:Float, v:Float};
typedef Rgb = {r:Float, g:Float, b:Float};

enum Color {
  Rgb(rgb:Rgb);
  Hsv(hsv:Hsv);
  Named(name:String);
}

class Demo {

  static var namedColors:Map<String, Rgb> = [
    "red" => {r: 1, g: 0, b: 0},
    "yellow" => {r: 1, g: 1, b: 0},
    "blue" => {r: 0, g: 0, b: 1},
  ];

  static public function colorToRgb(color:Color):Rgb {
    return switch (color) {
      case Rgb(rgb): rgb;
      case Hsv(_): {r: 1, g: 1, b: 1};
      case Named(name): {r: 1, g: 1, b: 1};
    }
  }

  static public function main():Void {
    var named = Named("red");
    var hi = new Hsv(1, 1, 1);
    // var hi: Hsv = {h: 1, s: 1, v: 1};
    trace("Hi there!");
  }

}
