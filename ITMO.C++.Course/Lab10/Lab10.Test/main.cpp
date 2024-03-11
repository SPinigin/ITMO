#include <iostream>
#include "dot.h"
#include "triangleAgregate.h"
#include "triangleComposition.h"
using namespace std;

int main() {

	Dot d1(1, 2);
	Dot d2(4, 8);
	Dot d3(-1, 3);

	TriangleComposition trComp(d1, d2, d3);
	TriangleAgregate trAgr(&d1, &d2, &d3);

	cout << "Perimeter is: " << trComp.Perimeter() << endl;
	cout << "\nSquare is: " << trComp.Square() << endl;
	cout << "\nTriangle sides are: ";
	trComp.showSides();

	cout << "\n\nPerimeter is : " << trAgr.Perimeter() << endl;
	cout << "\nSquare is: " << trAgr.Square() << endl;
	cout << "\nTriangle sides are: ";
	trAgr.showSides();
}
