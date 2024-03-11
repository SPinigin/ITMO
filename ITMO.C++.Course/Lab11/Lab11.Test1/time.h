#pragma once
#include <iostream>
#include<string>
using namespace std;

class Time
{
public:
	class TimeError {
	public:
		TimeError() : message("Wrong time") { };;
		void printMessage() const { cout << message << endl; };
	private:
		string message;
	};

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

	Time operator+ (const Time&) const;
	Time operator- (const Time&) const;
	friend Time operator+ (float, const Time&);
	friend Time operator+ (const Time&, float);
	Time operator= (const Time&) const;

private:
	int hours;
	int minutes;
	int seconds;
};
