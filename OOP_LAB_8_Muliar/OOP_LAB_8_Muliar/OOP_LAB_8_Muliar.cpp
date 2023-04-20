#include <iostream>
#include <vector>
#include <windows.h>
#include <algorithm>
#include <math.h>

using namespace std;

int main()
{
	SetConsoleCP(1251);
	SetConsoleOutputCP(1251);

	int idFirst;
	int idLast;
	int count = 20;
    vector<int> vec(20);
	int sum = 0;
	

	srand(time(NULL));

	for (size_t i = 0; i < count; i++)
	{
		vec[i] = rand()%21-10;
		cout << vec[i] << " ";
		
	}

	cout << "" << endl;

	
	for (size_t i = 0; i < count; i++)
	{
		if (i %2 == 1)
		{
			sum += vec[i];
			
		}

		
	}

	cout << "Сума елементів з непарними номерами: " << sum << endl;

	for (size_t i = 0; i < count; i++)
	{
		if (vec[i]< 0)
		{
			idFirst = i;
			break;
		}
	}

	for (size_t i = 0; i < count; i++)
	{
		if (vec[i] < 0)
		{
			idLast = i;
			
		}
	}

	sum - 0;
	for (int i = idFirst + 1; i < idLast; i++)
	{
		sum += vec[i];
	}
	cout << "Сума між першим і останніми відємними елементами: " << sum << endl;


	for (size_t i = 0; i < count; i++)
	{
		if (abs(vec[i]) <= 1)
		{
			vec[i] = -200;
			

		}
		
	}
	

	auto result = remove(vec.begin(), vec.end(), -200);
	vec.erase(result, vec.end());
	
	cout << "_________________________________" << endl;

	count = count - vec.size();
	
	for (size_t i = 0; i < count; i++)
	{
		vec.push_back(0);
	}

	

	for (size_t i = 0; i < vec.size(); i++)
	{
		cout << vec[i] <<" ";
	}




}

