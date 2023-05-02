#pragma once
#include "Line.h"

class Rectangle : public Line
{
protected:
    double x3;
    double y3;
    double x4;
    double y4;
    double height;

public:
    Rectangle(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4);

    double getX3();
    void setX3(double x);
    double getY3();
    void setY3(double y);
    double getX4();
    void setX4(double x);
    double getY4();
    void setY4(double y);
    double getHeight();
    void setHeight(double h);

    double Area();
    double Perimeter();
    bool IsRectangle();
};
