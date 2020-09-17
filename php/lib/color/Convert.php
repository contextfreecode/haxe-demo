<?php
/**
 * Generated by Haxe 4.1.2
 */

namespace color;

use \php\Boot;
use \haxe\Exception;
use \haxe\ds\StringMap;

class Convert {
	/**
	 * @var StringMap
	 */
	static public $namedColors;

	/**
	 * @param Color $color
	 * 
	 * @return Color
	 */
	public static function colorToRgb ($color) {
		#src/color/Convert.hx:15: lines 15-19
		$__hx__switch = ($color->index);
		if ($__hx__switch === 0) {
			#src/color/Convert.hx:16: characters 16-17
			$_g = $color->params[2];
			$_g = $color->params[1];
			$_g = $color->params[0];
			#src/color/Convert.hx:16: characters 20-25
			return $color;
		} else if ($__hx__switch === 1) {
			#src/color/Convert.hx:17: characters 22-23
			$v = $color->params[2];
			#src/color/Convert.hx:17: characters 19-20
			$s = $color->params[1];
			#src/color/Convert.hx:17: characters 16-17
			$h = $color->params[0];
			#src/color/Convert.hx:17: characters 26-43
			return Convert::hsvToRgb($h, $s, $v);
		} else if ($__hx__switch === 2) {
			#src/color/Convert.hx:18: characters 18-22
			$name = $color->params[0];
			#src/color/Convert.hx:18: characters 25-42
			return (Convert::$namedColors->data[$name] ?? null);
		}
	}

	/**
	 * @param float $h
	 * @param float $s
	 * @param float $v
	 * 
	 * @return Color
	 */
	public static function hsvToRgb ($h, $s, $v) {
		#src/color/Convert.hx:24: characters 5-19
		$c = $s * $v;
		#src/color/Convert.hx:25: characters 5-20
		$h1 = $h * 6;
		#src/color/Convert.hx:26: characters 5-44
		$x = $c * (1 - abs(fmod($h1, 2) - 1));
		#src/color/Convert.hx:27: lines 27-33
		$rgb1 = ($h1 < 1 ? Color::Rgb($c, $x, 0) : ($h1 < 2 ? Color::Rgb($x, $c, 0) : ($h1 < 3 ? Color::Rgb(0, $c, $x) : ($h1 < 4 ? Color::Rgb(0, $x, $c) : ($h1 < 5 ? Color::Rgb($x, 0, $c) : Color::Rgb($c, 0, $x))))));
		#src/color/Convert.hx:34: characters 5-19
		$m = $v - $c;
		#src/color/Convert.hx:35: characters 5-70
		$rgb = null;
		#src/color/Tools.hx:15: lines 15-18
		if ($rgb1->index === 0) {
			#src/color/Convert.hx:35: characters 38-39
			$b = $rgb1->params[2];
			#src/color/Convert.hx:35: characters 35-36
			$g = $rgb1->params[1];
			#src/color/Convert.hx:35: characters 32-33
			$r = $rgb1->params[0];
			#src/color/Convert.hx:35: characters 5-70
			$rgb = Color::Rgb($r + $m, $g + $m, $b + $m);
		} else {
			#src/color/Tools.hx:17: characters 20-25
			throw Exception::thrown("no match");
		}
		#src/color/Convert.hx:36: characters 5-15
		return $rgb;
	}

	/**
	 * @internal
	 * @access private
	 */
	static public function __hx__init ()
	{
		static $called = false;
		if ($called) return;
		$called = true;


		$_g = new StringMap();
		$_g->data["red"] = Color::Rgb(1.0, 0.0, 0.0);
		$_g->data["yellow"] = Color::Rgb(1.0, 1.0, 0.0);
		$_g->data["blue"] = Color::Rgb(0.0, 0.0, 1.0);
		self::$namedColors = $_g;
	}
}

Boot::registerClass(Convert::class, 'color.Convert');
Convert::__hx__init();
