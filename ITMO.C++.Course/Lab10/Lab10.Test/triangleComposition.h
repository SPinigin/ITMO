#pragma once
#include "dot.h"
#include <iostream>

using namespace std;

class TriangleComposition {
private:
    Dot dot1;
    Dot dot2;
    Dot dot3;
public:

    TriangleComposition(Dot d1, Dot d2, Dot d3);
    void showSides();
    double Perimeter();
    double Square();
    void set_dot1(Dot d);
    void set_dot2(Dot d);
    void set_dot3(Dot d);
};
