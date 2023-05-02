#include "BaseString.h"

BaseString::BaseString(std::string str)
{
    this->str = str;
}

int BaseString::Length()
{
    return str.length();
}