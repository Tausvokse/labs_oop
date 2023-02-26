#pragma once
#define _USE_MATH_DEFINES
#include <math.h>
#include <iostream>
using namespace std;

class line {
public:
	float xA, yA, xB, yB;
	char choice;
	int dia;
	bool oper4;
	float check(float N);
	float dovzhina();
	float kyt();
};
