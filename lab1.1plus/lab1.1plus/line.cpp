#include "Header.h"

float line::dovzhina() {
	return sqrt(pow(xB - xA, 2) + pow(yB - yA, 2));
}
float line::kyt() {
	float vert = yB - yA;
	float hor = xB - xA;
	return (float)round(atan2(vert, hor) * (180 / M_PI));
}