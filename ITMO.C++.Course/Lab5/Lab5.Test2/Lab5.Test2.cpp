#include <iostream>
#include <vector>
using namespace std;

int* max_vect(int, int[], int[]);

int main()
{
	int a[] = { 1,2,3,4,5,6,7,2 };
	int b[] = { 7,6,5,4,3,2,1,3 };
	int kc = sizeof(a) / sizeof(a[0]);
	int* c;
	c = max_vect(kc, a, b);
	for (int i = 0; i < kc; i++)
		cout << c[i] << " ";
	cout << endl;
	delete[]c;
}

int* max_vect(int size, int masA[], int masB[])
{
	int* masC = new int[size];
	for (int i = 0; i < size; i++)
	{
		if (masA[i] > masB[i])
		{
			masC[i] = masA[i];
		}
		else
		{
			masC[i] = masB[i];
		}
	}
	return masC;
}
