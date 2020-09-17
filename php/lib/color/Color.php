<?php
/**
 * Generated by Haxe 4.1.2
 */

namespace color;

use \php\Boot;
use \php\_Boot\HxEnum;

class Color extends HxEnum {
	/**
	 * @param float $h
	 * @param float $s
	 * @param float $v
	 * 
	 * @return Color
	 */
	static public function Hsv ($h, $s, $v) {
		return new Color('Hsv', 1, [$h, $s, $v]);
	}

	/**
	 * @param string $name
	 * 
	 * @return Color
	 */
	static public function Named ($name) {
		return new Color('Named', 2, [$name]);
	}

	/**
	 * @param float $r
	 * @param float $g
	 * @param float $b
	 * 
	 * @return Color
	 */
	static public function Rgb ($r, $g, $b) {
		return new Color('Rgb', 0, [$r, $g, $b]);
	}

	/**
	 * Returns array of (constructorIndex => constructorName)
	 *
	 * @return string[]
	 */
	static public function __hx__list () {
		return [
			1 => 'Hsv',
			2 => 'Named',
			0 => 'Rgb',
		];
	}

	/**
	 * Returns array of (constructorName => parametersCount)
	 *
	 * @return int[]
	 */
	static public function __hx__paramsCount () {
		return [
			'Hsv' => 3,
			'Named' => 1,
			'Rgb' => 3,
		];
	}
}

Boot::registerClass(Color::class, 'color.Color');
