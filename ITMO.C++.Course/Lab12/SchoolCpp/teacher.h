//teacher.h
#include "human.h"
#include<string>
#pragma once

using namespace std;

class teacher : public human
{
public:
	teacher(string last_name, string name, string second_name, unsigned int work_time)
		: human(last_name, name, second_name)
	{
		this->work_time = work_time;
	}

	unsigned int get_work_time()
	{
		return this->work_time;
	}
private:
	unsigned int work_time;
};
