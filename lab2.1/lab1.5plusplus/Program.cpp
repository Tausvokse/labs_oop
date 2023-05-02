#include "LetterString.h"


int main()
{
    bool restart = true;
    while (restart)
    {
        system("cls");
        std::cout << "Enter string value:" << endl;
        string input;
        getline(cin, input);
        LetterString s(input);
        cout << "String: " << s.GetString() << endl;
        cout << "Length: " << s.Length() << endl;
        s.Sort();
        cout << "Sorted: " << s.GetString() << endl;
        cout << "Do you want to restart? Yes - 'Y', No - 'N'. Press 'S' to exit." << endl;
        string answer;
        getline(cin, answer);

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