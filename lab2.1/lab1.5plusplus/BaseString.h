#pragma once
#include <string>


class BaseString
{
protected:
    std::string str;

public:
    BaseString(std::string str);
    int Length();
};