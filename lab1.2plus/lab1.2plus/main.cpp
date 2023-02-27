#include "Header.h"

int main() {
    line line1;

    do {
        cout << "Enter the coordinates of the first point (x1, y1): ";
        while (!(cin >> line1.xA >> line1.yA)) {
            cin.clear();
            cin.ignore(numeric_limits<streamsize>::max(), '\n');
            cout << "Invalid input. Please enter numerical values.\n";
            cout << "Enter the coordinates of the first point (x1, y1): ";
        }

        cout << "Enter the coordinates of the second point (x2, y2): ";
        while (!(cin >> line1.xB >> line1.yB)) {
            cin.clear();
            cin.ignore(numeric_limits<streamsize>::max(), '\n');
            cout << "Invalid input. Please enter numerical values.\n";
            cout << "Enter the coordinates of the second point (x2, y2): ";
        }

        float dovzhina1 = line1.dovzhina();
        float kyt1 = line1.kyt();
        do {
            cout << "Choose an operation:\n";
            cout << "0: Show your cordinates\n";
            cout << "1: Calculate length of line segment\n";
            cout << "2: Calculate angle between line segment and X-axis\n";
            cout << "3: Do all operations (0-2)\n";
            cout << "4: Restart programm\n";
            cout << "5: Stop programm\n";
            cin >> line1.dia;
            line1.oper4 = 0;

            switch (line1.dia) {
            case 0:
                cout << "A(" << line1.xA << ";" << line1.yA << ") and B(" << line1.xB << ";" << line1.yB << ")" << endl;
                break;
            case 1:
                cout << "Dovzhina is: " << dovzhina1 << endl;
                break;
            case 2:
                cout << "Kyt is: " << kyt1 << endl;
                break;
            case 3:
                cout << "A(" << line1.xA << ";" << line1.yA << ") and B(" << line1.xB << ";" << line1.yB << ")" << endl;
                cout << "Dovzhina is: " << dovzhina1 << endl;
                cout << "Kyt is: " << kyt1 << endl;
                break;
            case 4:
                line1.oper4 = true;
                break;
            case 5:
                return 0;
            default:
                cout << "Invalid choice. Please enter from 0 to 5.\n";
                cin.clear();
                cin.ignore(numeric_limits<streamsize>::max(), '\n');
            }

            if (line1.oper4) {
                break;
            }

        } while (line1.dia <= 5 || line1.dia >= 0);

        line1.choice = 'y';

    } while (line1.choice == 'Y' || line1.choice == 'y');


}