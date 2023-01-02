#pragma once
#define _CRT_SECURE_NO_WARNINGS
#include <iostream>
#include <Windows.h>
#include <string.h>
#include <conio.h>
#include <iomanip>
#include <vector>


using namespace std;


class PhoneBook
{

private:

	int number;
	char* FIO;
	char* MobPhone;
	char* Group;

public:
	
	PhoneBook();
	PhoneBook(int _number, const char *_fio, const char* _mobphone, const char* _group);
	
	//конструктор копирования
	PhoneBook(const PhoneBook& obj);

	//поиск абонента
	void SearchAbon(PhoneBook* p, char const* charsearch, int const countabon);

	//добавление абонента
	void AddAbon(PhoneBook*& p, int* countabon, int* _number);

	//удаление абонента
	void DelAbon(PhoneBook*& p, int* countabon, int* _number);

	//деструктор
	~PhoneBook();

	//печать книги абонентов
	void ShowPhoneBook();

	int Getnumber();
	char GetFIO();
	char GetMobPhone();

};



//-----------------------------------------------------------------------------------------------

void gotoxy(int, int);

void ChangeCursorStatus(bool);
void MenuFun1();
void MenuFun2();
void MenuFun3();
void MenuFun4();

void ExitOption();
//-----------------------------------------------------------------------------------------------