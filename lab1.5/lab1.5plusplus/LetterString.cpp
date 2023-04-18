#include "LetterString.h"
#include <algorithm>
#include <regex>

LetterString::LetterString(std::string str) : BaseString(str)
{
    std::regex pattern("[^a-zA-Zà-ÿÀ-ß]");
    std::string replacement = "";
    this->str = std::regex_replace(str, pattern, replacement);
}

void LetterString::Sort()
{
    std::sort(str.begin(), str.end());
}

std::string LetterString::GetString()
{
    return str;
}