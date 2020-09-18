#include <iostream>

extern "C" __declspec(dllexport) void HelloWorld();
extern "C" __declspec(dllexport) int Add(int, int);
extern "C" __declspec(dllexport) bool IsLengthGreaterThanFive(const char*);


void HelloWorld()
{
	std::cout << "Hello World";
}

int Add(int a, int b)
{
	return a + b;
}

bool IsLengthGreaterThanFive(const char* value)
{
	return strlen(value) > 5;
}