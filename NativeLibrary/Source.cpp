#include <iostream>

extern "C" __declspec(dllexport) void HelloWorld();
extern "C" __declspec(dllexport) int Add(int, int);


void HelloWorld()
{
	std::cout << "Hello World";
}

int Add(int a, int b)
{
	return a + b;
}