#include <iostream>
#include <set>
#include <Windows.h>

using namespace std;

int main()
{
	SetConsoleCP(1251);
	SetConsoleOutputCP(1251);
	multiset<int> mySet;

	for (size_t i = 0; i < 20; i++)
	{
		mySet.insert(rand() % 20);
	}

	for (auto& item : mySet)
	{
		cout << item << " ";
	}

	cout<< "" << endl;

	for (size_t i = 0; i < 20; i++)
	{	
			cout << "Число: " << i << " повторилося: " << mySet.count(i) << " разів" << endl;	
	}

	
    
    

       
}
