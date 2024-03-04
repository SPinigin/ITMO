#include <iostream>
#include <math.h>
using namespace std;

int main()
{
	int score = 0;
	int shots = 0;

	while (score < 50) {
		int x, y;
		cout << "Input coordinates of shot:\n";
		cin >> x;
		cin >> y;

		double radius = sqrt((x * x) + (y * y));

		if (radius <= 1)
			score += 10;
		else if (radius <= 2)
			score += 5;
		else score = 0;
		shots++;
	}

	cout << "Your score is: " << score << "\n" << "Your did " << shots << " shots" << endl;

	if (shots == 5)
		cout << "Congrats, you are a sniper!" << endl;
	else if (shots > 5 && score < 10)
		cout << "Not bad. But you can more" << endl;

	else cout << "You are a loser:(" << endl;

}
