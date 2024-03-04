#include <iostream>
#include <fstream>
#include <string>
using namespace std;

int main()
{
	const int N = 10;
	int a[N] = { 1,25,6,32,43,5,96,23,4,55 };
	int min = 0;
	int buf = 0;

	string text1;
	for (int i : a)
	{
		text1 += " " + to_string(i);
	}
	cout << text1 << endl;

	ofstream out;
	out.open("Array.txt");
	out << text1 << endl;
	out.close();

	for (int i = 0; i < N; i++)
	{
		min = i;

		for (int j = i + 1; j < N; j++)
			min = (a[j] < a[min]) ? j : min;

		if (i != min)
		{
			buf = a[i];
			a[i] = a[min];
			a[min] = buf;
		}
	}

	string text2;
	for (int i : a)
	{
		text2 += " " + to_string(i);
	}
	cout << text2 << endl;

	out.open("Array.txt", ios::app);
	out << text2 << endl;
	out.close();
}
