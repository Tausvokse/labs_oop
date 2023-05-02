#include "Line.h"

Line::Line(double x1, double y1, double x2, double y2) : Point(x1, y1)
{
	this->x2 = x2;
	this->y2 = y2;
}

double Line::getX2() const
{
	return x2;
}

void Line::setX2(double x2)
{
	this->x2 = x2;
}

double Line::getY2() const
{
	return y2;
}

void Line::setY2(double y2)
{
	this->y2 = y2;
}

double Line::Length() const
{
	return std::sqrt(std::pow(x2 - x, 2) + std::pow(y2 - y, 2));
}