package color;

enum Color {
  Rgb(r:Float, g:Float, b:Float);
  Hsv(h:Float, s:Float, v:Float);
  Named(name:String);
}
