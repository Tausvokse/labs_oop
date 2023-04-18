#include "Rectangle.h"
#include <stdexcept>
#include <cmath>

Rectangle::Rectangle(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4)
    : Line(x1, y1, x2, y2), x3(x3), y3(y3), x4(x4), y4(y4)
{
    if (!IsRectangle())
    {
        throw std::invalid_argument("Not a rectangle.");
    }

    height = sqrt(pow(y3 - y1, 2) + pow(x3 - x1, 2));
}

double Rectangle::getX3() { return x3; }
void Rectangle::setX3(double x) { x3 = x; }
double Rectangle::getY3() { return y3; }
void Rectangle::setY3(double y) { y3 = y; }
double Rectangle::getX4() { return x4; }
void Rectangle::setX4(double x) { x4 = x; }
double Rectangle::getY4() { return y4; }
void Rectangle::setY4(double y) { y4 = y; }
double Rectangle::getHeight() { return height; }
void Rectangle::setHeight(double h) { height = h; }

double Rectangle::Area() { return Length() * height; }

double Rectangle::Perimeter() { return 2 * Length() + 2 * height; }

bool Rectangle::IsRectangle()
{
    double cx, cy;
    double dd1, dd2, dd3, dd4;

    cx = (x + x2 + x3 + x4) / 4;
    cy = (y + y2 + y3 + y4) / 4;

    dd1 = sqrt(pow(cx - x, 2) + pow(cy - y, 2));
    dd2 = sqrt(pow(cx - x2, 2) + pow(cy - y2, 2));
    dd3 = sqrt(pow(cx - x3, 2) + pow(cy - y3, 2));
    dd4 = sqrt(pow(cx - x4, 2) + pow(cy - y4, 2));
    return dd1 == dd2 && dd1 == dd3 && dd1 == dd4 && dd1 != 0 && dd2 != 0 && dd3 != 0 && dd4 != 0;
}
