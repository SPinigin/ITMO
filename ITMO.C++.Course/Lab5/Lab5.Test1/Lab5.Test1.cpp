#include <iostream>
using namespace std;

int* enterArray(int);
void showArray(int[], const int);
void arrayDefinition(int[], const int);
void sortArray(int[], const int);

int main()
{
    const int n = 5;
    int* mas = enterArray(n);

    showArray(mas, n);
    arrayDefinition(mas, n);
    sortArray(mas, n);
    showArray(mas, n);
}

//fill array
int* enterArray(int n) {
    int* mas = new int[n];
    for (int i = 0; i < n; i++)
    {
        cout << "mas[" << i << "]=";
        cin >> mas[i];
    }
    return mas;
}


//show array
void showArray(int mas[], const int n)
{
    for (int i = 0; i < n; i++)
        cout << mas[i] << " ";
    cout << "\n";
}


void arrayDefinition(int mas[], const int n)
{
    int sum = 0;
    for (int i = 0; i < n; i++)
    {
        sum += mas[i];
    }
    cout << "The sum of all elements of the array is: " << sum << endl;

    double averige = double(sum) / n;
    cout << "The averige value of the array elements is: " << averige << endl;

    int negSum = 0;
    for (int i = 0; i < n; i++)
    {
        if (mas[i] < 0) {
            negSum += mas[i];
        }
    }
    cout << "The sum of negative element of the array is: " << negSum << endl;

    int posSum = 0;
    for (int i = 0; i < n; i++)
    {
        if (mas[i] > 0) {
            posSum += mas[i];
        }
    }
    cout << "The sum of positive elements of the array is: " << posSum << endl;

    int oddSum = 0;
    for (int i = 0; i < n; i++)
    {
        if (i % 2 != 0) {
            oddSum += mas[i];
        }
    }
    cout << "The sum of elements with odd indexes of the array is: " << oddSum << endl;

    int evenSum = 0;
    for (int i = 0; i < n; i++)
    {
        if (i % 2 == 0) {
            evenSum += mas[i];
        }
    }
    cout << "The sum of elements with even indexes of the array is: " << evenSum << endl;

    int maxElement = mas[0];
    for (int i = 0; i < n; i++)
    {
        if (mas[i] > maxElement)
        {
            maxElement = mas[i];
        }
    }

    int minElement = mas[0];
    for (int i = 0; i < n; i++)
    {
        if (mas[i] < minElement)
        {
            minElement = mas[i];
        }
    }

    cout << "Max and min elements of the array are: " << maxElement << " and " << minElement << endl;
}

//sort array
void sortArray(int mas[], const int n)
{
    int min = 0;
    int buf = 0;

    for (int i = 0; i < n; i++)
    {
        min = i;

        for (int j = i + 1; j < n; j++)
            min = (mas[j] < mas[min]) ? j : min;

        if (i != min)
        {
            buf = mas[i];
            mas[i] = mas[min];
            mas[min] = buf;
        }
    }

}
