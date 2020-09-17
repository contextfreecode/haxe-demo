# type: ignore

from color import color_Color as Color


def color_to_rgb(color):
    from color import color_Convert as Convert

    return Convert.colorToRgb(color)


def main():
    colors = [
        Color.Hsv(1.0, 1.0, 1.0),
        Color.Named("yellow"),
        Color.Rgb(0.0, 0.0, 1.0),
    ]
    for index, color in enumerate(colors):
        print(f"Color {index}: {color_to_rgb(color)}")


if __name__ == "__main__":
    main()
