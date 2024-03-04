#include <iostream>
#include <math.h>
#include <tuple>
using namespace std;

using Tuple = tuple<double, double, int>;

Tuple Sqrtroot(double a, double b, double c);

int main()
{
	double a, b, c;

	cout << "Input a, b, c: \n";
	cin >> a >> b >> c;

	Tuple root = Sqrtroot(a, b, c);
	if (get<2>(root) == 1)
	{
		cout << "The roots: x1 = " << get<0>(root) << ", x2 = " << get<1>(root) << "." << endl;
	}
	else if (get<2>(root) == 0)
	{
		cout << "The root: x1 = x2 = " << get<0>(root) << "." << endl;
	}
	else
	{
		cout << "There are no roots." << endl;
	}
}

Tuple Sqrtroot(double a, double b, double c)
{
	double x1, x2;
	int flag;
	double D = pow(b, 2) - 4 * a * c;
	if (D > 0)
	{
		x1 = (-b - sqrt(D)) / (2 * a);
		x2 = (-b + sqrt(D)) / (2 * a);
		flag = 1;
	}
	else if (D == 0)
	{
		x1 = x2 = (-b) / (2 * a);
		flag = 0;
	}
	else
	{
		flag = -1;
	}
	return make_tuple(x1, x2, flag);
}
