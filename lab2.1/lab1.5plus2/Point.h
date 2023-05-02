#ifndef POINT_H
#define POINT_H

class Point
{
protected:
	double x;
	double y;

public:
	Point(double x, double y);
	double getX() const;
	void setX(double x);
	double getY() const;
	void setY(double y);
};

#endif