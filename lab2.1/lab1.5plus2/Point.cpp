#include "Point.h"

Point::Point(double x, double y)
{
	this->x = x;
	this->y = y;
}

double Point::getX() const
{
	return x;
}

void Point::setX(double x)
{
	this->x = x;
}

double Point::getY() const
{
	return y;
}

void Point::setY(double y)
{
	this->y = y;
}