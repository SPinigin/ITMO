﻿#include <iostream>
#include <math.h>
using namespace std;

double areaEqTr(double);
double areaVerTr(double, double, double);

int main()
{
    int num;
    double a, b, c;
    cout << "For quilateral triangle choose 1\n";
    cout << "For versatile triangle choose 2\n";
    cin >> num;
    if (num == 1)
    {
        cout << "Input a side of triangle: ";
        cin >> a;
        cout << "The area of triangle with the side " << a << " is: " << areaEqTr(a) << endl;
    }
    else if (num == 2)
    {
        cout << "Input sides of triangle: ";
        cin >> a >> b >> c;
        cout << "The area of triangle with sides " << a << ", " << b << ", " << c << " is: " << areaVerTr(a, b, c) << endl;
    }
    else
    {
        cout << "You need to choose 1 or 2";
    }
}

double areaEqTr(double a)
{
    double areaEq = ((a * a) * sqrt(3) / 4);
    return areaEq;
}

double areaVerTr(double a, double b, double c)
{
    double per = a + b + c;
    double pper = per / 2;
    double areaVer = sqrt((pper * (pper - a) * (pper - b) * (pper - c)));
    return areaVer;
}