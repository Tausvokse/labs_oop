#ifndef LINE_H
#define LINE_H

#include "Point.h"
#include <cmath>

class Line : public Point
{
protected:
	double x2;
	double y2;

public:
	Line(double x1, double y1, double x2, double y2);
	double getX2() const;
	void setX2(double x2);
	double getY2() const;
	void setY2(double y2);
	double Length() const;
};

#endif