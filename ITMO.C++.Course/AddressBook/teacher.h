//teacher.h
#include "human.h"
#include<string>

using namespace std;

class teacher : public human
{
public:
	teacher() :human() {
		addRecord();
	}

	teacher(string last_name, string name, string phone, string lesson)
		: human(last_name, name)
	{
		this->phone = phone;
		this->lesson = lesson;
	}

	string get_full_data() override
	{
		return
			"Teacher's name and last name are: " + human::get_full_data() +
			"; Lesson: " + this->lesson +
			"; Phone: " + this->phone + "\n";
	}

	teacher addRecord() {
		this->set_name();
		this->set_lastName();
		cout << "Enter a lesson: " << endl;
		cin >> lesson;
		cout << "Enter a phone: " << endl;
		cin >> phone;
		return teacher(human::get_lastName(), human::get_name(), phone, lesson);
	}

private:
	string phone;
	string lesson;
};
