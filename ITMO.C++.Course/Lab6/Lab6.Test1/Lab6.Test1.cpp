#include <iostream>
#include <fstream>
#include <string>

using namespace std;

int main()
{
    string poem;
    ofstream out;
    out.open("Poem.txt", ios::out);
    getline(cin, poem, '*');
    out << poem;
    out.close();
}
