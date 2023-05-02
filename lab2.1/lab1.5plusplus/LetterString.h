#pragma once
#include <iostream>
#include <string>
#include "BaseString.h"
using namespace std;

class LetterString : public BaseString
{
public:
    LetterString(std::string str);
    void Sort();
    std::string GetString();
};