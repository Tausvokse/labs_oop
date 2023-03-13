#pragma once
#define _USE_MATH_DEFINES
#include <math.h>
#include <locale>
#include <iostream>
using namespace std;

class line {
public:
	float xA, yA, xB, yB;
	char choice;
	int dia;
	bool oper4;
	float dovzhina();
	float kyt();
	void outCoordinates();
	void outDovzhina(float n);
	void outKyt(float n);
	void setMethod();

	line operator -(float b);
	line operator -(line a);
	bool operator >(line a);
	line operator ++();
	bool operator !=(float a);
};