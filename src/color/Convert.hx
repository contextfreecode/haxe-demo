package color;

using color.Color;
using color.Tools;

class Convert {

  static var namedColors: Map<String, Color> = [
    "red" => Rgb(1.0, 0.0, 0.0),
    "yellow" => Rgb(1.0, 1.0, 0.0),
    "blue" => Rgb(0.0, 0.0, 1.0),
  ];

  static public function colorToRgb(color:Color):Color {
    return switch (color) {
      case Rgb(_): color;
      case Hsv(h, s, v): hsvToRgb(h, s, v);
      case Named(name): namedColors[name];
    }
  }

  static public function hsvToRgb(h:Float, s:Float, v:Float):Color {
    // From: https://en.wikipedia.org/wiki/HSL_and_HSV#HSV_to_RGB
    var c = s * v;
    var h1 = h * 6;
    var x = c * (1 - Math.abs(h1 % 2 - 1));
    var rgb1 =
      if (h1 < 1) Rgb(c, x, 0);
      else if (h1 < 2) Rgb(x, c, 0);
      else if (h1 < 3) Rgb(0, c, x);
      else if (h1 < 4) Rgb(0, x, c);
      else if (h1 < 5) Rgb(x, 0, c);
      else Rgb(c, 0, x);
    var m = v - c;
    var rgb = rgb1.extract(Rgb(r, g, b) => Rgb(r + m, g + m, b + m));
    return rgb;
  }

}
