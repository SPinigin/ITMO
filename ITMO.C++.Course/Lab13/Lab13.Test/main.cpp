//main.cpp
#include<iostream>
#include<vector>
#include"human.h"
#include"student.h"
#include"teacher.h"

using namespace std;

int main()
{
	vector<int> scores;
	scores.push_back(5);
	scores.push_back(3);
	scores.push_back(4);
	scores.push_back(4);
	scores.push_back(5);
	scores.push_back(3);
	scores.push_back(3);
	scores.push_back(3);
	scores.push_back(3);

	human* stud = new student("Petrov", "Ivan", "Alekseevich", scores);
	cout << "Student's full name is: ";
	stud->print_full_data();

	unsigned int teacher_work_time = 40;
	human* tch = new teacher("Segreev", "Dmitriy", "Sergeevich", teacher_work_time);
	cout << "\nTeacher's full name is: ";
	tch->print_full_data();

	return 0;
}
