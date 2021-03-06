
#include <stdafx.h>
#include <iostream> 
#include <string>
using namespace std;


string encrypt(string text, int s)
{
	string result = "";

	for (int i = 0; i < text.length(); i++)
	{

		if (isupper(text[i]))
		{
			result += char(int(text[i] + s - 65) % 26 + 65);
		}
		else
		{
			result += char(int(text[i] + s - 97) % 26 + 97);
		}
	}

	return result;
}


int main()
{
	string text = "ThisIsAtest";
	int s = 3;
	cout << "Text : " << text;
	cout << "\nShift: " << s;
	cout << "\nCipher: " << encrypt(text, s);

	string encripted = encrypt(text, s);
	cout << "\nDecrypt: " << encrypt(encripted, (26 - s));
	
	getchar();
	return 0;
}