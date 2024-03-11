#include <iostream>
#include "time.h"
using namespace std;

int main()
{
	int hours;
	int minutes;
	int seconds;

	cout << "Input hours : minutes : seconds " << "\n";
	cin >> hours >> minutes >> seconds;

	Time time1 = Time(hours, minutes, seconds);
	Time time2 = Time(10, 20, 30);
	Time time3;

	cout << "\nFirst time is: ";
	time1.ShowTime();
	cout << "\nSecond time is: ";
	time2.ShowTime();

	time3 = time1.PlusTime(time2);
	cout << "\nSum of first and secont time is: ";
	time3.ShowTime();
}
