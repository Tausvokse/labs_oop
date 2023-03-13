#include "Header.h"

float line::dovzhina() {
	return roundf(sqrtf(powf(xB - xA, 2) + powf(yB - yA, 2)));
}
float line::kyt() {
	float vert = yB - yA;
	float hor = xB - xA;
	return roundf(atan2f(vert, hor) * (180 / M_PI));
}

void line::outCoordinates() {
	cout << "\033[0;31m" << "A(" << xA << ";" << yA << ") and B(" << xB << ";" << yB << ")" << "\033[0m" << endl;
}

void line::outKyt(float n) {
	cout << "\033[0;31m" << "Kyt is: " << n << "\033[0m" << endl;
}

void line::outDovzhina(float n) {
	cout << "\033[0;31m" << "Dovzhina is: " << n << "\033[0m" << endl;
}


line line::operator -(float b) {
	xA -= b;
	xB -= b;
	yA -= b;
	yB -= b;
	return *this;
}

void line::setMethod() {
	cout << "\033[0;33m" << "Enter the coordinates of the first point (x1, y1): " << "\033[0m";
	while (!(cin >> xA >> yA)) {
		cin.clear();
		cin.ignore(numeric_limits<streamsize>::max(), '\n');
		cout << "\033[0;33m" << "Invalid input. Please enter numerical values.\n";
		cout << "Enter the coordinates of the first point (x1, y1): " << "\033[0m";
	}

	cout << "\033[0;33m" << "Enter the coordinates of the second point (x2, y2): " << "\033[0m";
	while (!(cin >> xB >> yB)) {
		cin.clear();
		cin.ignore(numeric_limits<streamsize>::max(), '\n');
		cout << "\033[0;33m" << "Invalid input. Please enter numerical values.\n";
		cout << "Enter the coordinates of the second point (x2, y2): " << "\033[0m";
	}
}

line line::operator -(line a) {
	xB = xA + (xB - xA) - (a.xB - a.xA);
	yB = yA + (yB - yA) - (a.yB - a.yA);
	dovzhina();
	return *this;
}

bool line::operator >(line a) {
	if (xA != a.xA) {
		return xA > a.xA;
	}
	if (yA != a.yA) {
		return yA > a.yA;
	}

	if (xB != a.xB) {
		return xB > a.xB;
	}
	if (yB != a.yB) {
		return yB > a.yB;
	}

	return false;
}

line line::operator ++() {
	xA++;
	xB++;
	yA++;
	yB++;
	return *this;
}

bool line::operator!=(float a)
{
	a = 0;
	if (xA != a || xB != a || yA != a || yB != a) {
		return true;
	}
	else {
		return false;
	}
}
