#pragma once 
using namespace std;

class Time
{
public:
	Time(int, int, int);
	Time();

	void set_hours(int);
	void set_minutes(int);
	void set_seconds(int);

	int get_hours();
	int get_minutes();
	int get_seconds();

	void ShowTime();
	Time PlusTime(Time&);

private:
	int hours;
	int minutes;
	int seconds;
};
