#include <iostream>
#include <cmath>
#include "Point.h"
#include "Line.h"
#include "Rectangle.h"

using namespace std;

int main()
{
    bool restart = true;
    while (restart)
    {
        system("cls");
        cout << "Enter coordinates of first point:" << endl;
        double x1, y1, x2, y2;
        cin >> x1 >> y1;
        cout << "Enter coordinates of second point:" << endl;
        cin >> x2 >> y2;

        Point point1(x1, y1);
        Point point2(x2, y2);

        Line line(point1.getX(), point1.getY(), point2.getX(), point2.getY());

        Rectangle* rectangle = nullptr;
        while (rectangle == nullptr)
        {
            cout << "Enter two more points (4 coordinates):" << endl;
            double x3, y3, x4, y4;
            cin >> x3 >> y3 >> x4 >> y4;

            Point point3(x3, y3);
            Point point4(x4, y4);

            rectangle = new Rectangle(point1.getX(), point1.getY(), point2.getX(), point2.getY(), point3.getX(), point3.getY(), point4.getX(), point4.getY());
            if (!rectangle->IsRectangle())
            {
                cout << "Not a rectangle. Try again." << endl;
                delete rectangle;
                rectangle = nullptr;
            }
        }

        cout << "Length of the line: " << line.Length() << endl;
        cout << "Height of the rectangle: " << rectangle->getHeight() << endl;
        cout << "Area of the rectangle: " << rectangle->Area() << endl;
        cout << "Perimeter of the rectangle: " << rectangle->Perimeter() << endl;
        cout << "Do you want to restart? Yes - 'Y', No - 'N'." << endl;
        string answer;
        cin >> answer;

        if (answer == "N" || answer == "n")
        {
            restart = false;
        }
        else if (answer == "S" || answer == "s")
        {
            system("cls");
            exit(0);
        }
    }

    return 0;
}