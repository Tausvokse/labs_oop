#include "Header.h"

int main() {
	line line1;
	cout << "Enter xA: ";
	cin >> line1.xA;
	cout << "Enter yA: ";
	cin >> line1.yA;
	cout << "Enter xB: ";
	cin >> line1.xB;
	cout << "Enter yB: ";
	cin >> line1.yB;

	cout << "A(" << line1.xA << ";" << line1.yA << ") and B(" << line1.xB << ";" << line1.yB << ")" << endl;
	float dovzhina1 = line1.dovzhina();
	cout << "Dovzhina is: " << dovzhina1 << endl;
	float kyt1 = line1.kyt();
	cout << "Kyt is: " << kyt1 << endl;
}