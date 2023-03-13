#include "Header.h"

int main() {
    setlocale(LC_CTYPE, "ukr");

    line line1;
    double b;
    bool bVar = 0;

    do {
        line1.setMethod();
        float dovzhina1 = line1.dovzhina();
        float kyt1 = line1.kyt();
        do {
            line line2{};
            cout << "\033[0;32m" << "Choose an operation:\n";
            cout << "0: Show your cordinates\n";
            cout << "1: Calculate length of line segment\n";
            cout << "2: Calculate angle between line segment and X-axis\n";
            cout << "3: Do all operations (0-2)\n";
            cout << "4: Operator Segemnt - Double (Double - segment) (1-2)\n";
            cout << "5: Operator Segment - Segment (3)\n";
            cout << "6: Operator Segment > Segment (4)\n";
            cout << "7: Operator Segment++ (5)\n";
            cout << "8: Operator (true Ц повернути true, €кщо будь-€ке закрите поле не дорiвнюЇ 0) (6)\n";
            cout << "9: Restart programm\n";
            cout << "10: Stop programm\n" << "\033[0m";
            cin >> line1.dia;
            line1.oper4 = 0;

            switch (line1.dia) {
            case 0:
                line1.outCoordinates();
                break;
            case 1:
                line1.outDovzhina(dovzhina1);
                break;
            case 2:
                line1.outKyt(kyt1);
                break;
            case 3:
                line1.outCoordinates();
                line1.outDovzhina(dovzhina1);
                line1.outKyt(kyt1);
                break;
             case 4:
                 cout << "\033[0;33m" << "Enter the double var: " << "\033[0m";
                 while (!(cin >> b)) {
                     cin.clear();
                     cin.ignore(numeric_limits<streamsize>::max(), '\n');
                     cout << "\033[0;33m" << "Invalid input. Please enter numerical values.\n";
                     cout << "Enter the double var: " << "\033[0m";
                 }
                 line1 = line1 - (float)b;
                 line1.outCoordinates();
                 break;
             case 5:
                 line2.setMethod();
                 line1 = line1 - line2;
                 break;
             case 6:
                if ( line2.xA && line2.xB && line2.yA && line2.yB ) {}
                else {
                    line2.setMethod();
                }
                bVar = line1 > line2;
                if (bVar) {
                    cout << "\033[0;33m" << "ѕерший вiдрiзок бiльший за другий\n" << "\033[0m";
                }
                else {
                    cout << "\033[0;33m" << "ѕерший вiдрiзок не бiльший за другий\n" << "\033[0m";
                }
                bVar = line1 > line2;
                break;

             case 7:
                ++line1;
                break;
             case 8:
                 if (line1 != 0) {
                     cout << "\033[0;33m" << "At least one variable has a non-zero value" << "\033[0m" << endl;
                 }
                 else {
                     cout << "\033[0;33m" << "All variables are equal to zero" << "\033[0m" << endl;
                 }
                break;
            case 9:
                line1.oper4 = true;
                break;
            case 10:
                return 0;
            default:
                cout << "\033[0;32m" << "ERROR: Invalid choice. Please enter from 0 to 10.\n" << "\033[0m";
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