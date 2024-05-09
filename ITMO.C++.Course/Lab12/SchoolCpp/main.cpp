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

	student* stud = new student("Petrov", "Ivan", "Alekseevich", scores);
	cout << "Student's full name is: " << stud->get_full_name() << endl;
	cout << "Student's average score is: " << stud->get_average_score() << endl;

	unsigned int teacher_work_time = 40;

	teacher* tch = new teacher("Segreev", "Dmitriy", "Sergeevich", teacher_work_time);
	cout << "\nTeacher's full name is: " << tch->get_full_name() << endl;
	cout << "Number of his work time is: " << tch->get_work_time() << " hours" << endl;
	return 0;
}
