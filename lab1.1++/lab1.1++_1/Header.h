#pragma once
#define _USE_MATH_DEFINES
#include <math.h>

class line {
public:
	float xA, yA, xB, yB;

	float dovzhina() {
		return sqrt(pow(xB - xA, 2) + pow(yB - yA, 2));
	}

	float kyt() {
		float vert = yB - yA;
		float hor = xB - xA;
		return (float)round(atan2(vert, hor) * (180 / M_PI));
	}
};