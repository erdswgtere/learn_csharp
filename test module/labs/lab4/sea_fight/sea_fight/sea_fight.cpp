//============================================================================
// Name        : morskoy_boy.cpp
// Author      : 
// Version     : 0.1
// Copyright   : GPL v. 3
// Description : Консольная игра "Морской бой"
//============================================================================
#include <iostream>
#include <iomanip>
#include <vector>
#include <random>
#include <ctime>
using namespace std;
// Прототипы для создания карты
// Поворот носа
void roth(int, int&);
void rotv(int, int&);
// Определение доступности места размещения
bool test(vector<vector<bool>>&, pair<int, int>&, int, bool&);
// Получение координат
pair<int, int> coord(int&, bool&);
// Создание карты
void mapSea(vector<vector<bool>>&, bool&);
// Рисование корабля
void ship(vector<vector<bool>>&, int&, bool&, pair<int, int>&);

// INI
void mapsIni(vector<vector<bool>>&, vector<vector<char>>&,
	vector<vector<bool>>&, vector<vector<char>>&);
void mapSeaUserCreat(vector<vector<bool>>&, vector<vector<char>>&,
	vector<vector<bool>>&, vector<vector<char>>&, bool&);
void printMapUser(vector<vector<char>>&, vector<vector<bool>>&, bool&);
void printMapComp(vector<vector<char>>&);

// battle
void battle(vector<vector<bool>>&, vector<vector<char>>&,
	vector<vector<bool>>&, vector<vector<char>>&);
void shot_user(vector<vector<bool>>&, vector<vector<char>>&,
	int&, bool&, pair<int, int>&);
void shot_comp(vector<vector<bool>>&, vector<vector<char>>&, int&, bool&);
pair<int, int> crdcomp();

int main() {
	setlocale(LC_ALL, "RU");
	vector<vector<bool>> SEA(10);
	vector<vector<bool>> USER(10);
	vector<vector<char>> SeaVision(10);
	vector<vector<char>> UserVision(10);
	bool flag = false; // Подготовка
	mapSeaUserCreat(USER, UserVision, SEA, SeaVision, flag);
	return 0;
}

pair<int, int> coord(int& size, bool& f) {
	// Сначала определяем ориентацию
	// 0 - горизонт, 1 - вертикаль
	static default_random_engine rnd(time(0));
	static uniform_int_distribution<int> t(0, 1);
	f = bool(t(rnd));
	f = bool(t(rnd));
	static uniform_int_distribution<int> d(0, 9);
	int x = d(rnd);
	x = d(rnd);
	int y = d(rnd);
	// Если вышли за пределы карты разворачиваем
	// по горизонтали двигаем влево, так чтобы
	// правым бортом оперся о край карты (нос слева)
	if (!f && x + size > 10) roth(size, x);
	// по вертикали тоже, но опираем задней частью
	// нос вверху
	if (f && y + size > 10) rotv(size, y);
	pair<int, int> xy = make_pair(x, y);
	return xy;
}
void roth(int size, int& x) {
	x = 10 - size;
}
void rotv(const int size, int& y) {
	y = 10 - size;
}
bool test(vector<vector<bool>>& sea, pair<int, int>& crd, int size, bool& f) {
	int x = crd.first,
		y = crd.second;
	bool b = true;
	// Обратить внимание на то, что i -> y, а j -> x !!!
	// Горизонтально
	if (!f) {
		// не боковые и не угловые
		if (x > 0 && y > 0 && x < 10 - size && y < 9) {
			for (int i = y - 1; i <= y + 1; i++)
				for (int j = x - 1; j <= x + size; j++)
					if (sea[i][j] == 1)
						b = false;
			// угловые
		}
		else
			if (x == 0 && y == 0) {
				for (int i = y; i <= y + 1; i++)
					for (int j = x; j <= x + size; j++)
						if (sea[i][j] == 1)
							b = false;
			}
			else
				if (x == 10 - size && y == 0) {
					for (int i = y; i <= y + 1; i++)
						for (int j = x; j <= x + size - 1; j++)
							if (sea[i][j] == 1)
								b = false;
				}
				else
					if (x == 10 - size && y == 9) {
						for (int i = y - 1; i <= y; i++)
							for (int j = x - 1; j <= x + size - 1; j++)
								if (sea[i][j] == 1)
									b = false;
					}
					else
						if (x == 0 && y == 9) {
							for (int i = y - 1; i <= y; i++)
								for (int j = x; j <= x + size; j++)
									if (sea[i][j] == 1)
										b = false;
						}
						else
							// Неугловые по бокам
							if (x > 0 && x < 10 - size && y == 0) {
								for (int i = y; i <= y + 1; i++)
									for (int j = x - 1; j <= x + size; j++)
										if (sea[i][j] == 1)
											b = false;
							}
							else
								if (y > 0 && y < 9 && x == 10 - size) {
									for (int i = y - 1; i <= y + 1; i++)
										for (int j = x - 1; j <= x + size - 1; j++)
											if (sea[i][j] == 1)
												b = false;
								}
								else
									if (x > 0 && x < 10 - size && y == 9) {
										for (int i = y - 1; i <= y; i++)
											for (int j = x - 1; j <= x + size; j++)
												if (sea[i][j] == 1)
													b = false;
									}
									else
										if (y > 0 && y < 9 && x == 0) {
											for (int i = y - 1; i <= y + 1; i++)
												for (int j = x; j <= x + size; j++)
													if (sea[i][j] == 1)
														b = false;
										}
	}
	else {
		// Вертикально
			// не боковые и не угловые
		if (x > 0 && y > 0 && x < 9 && y < 10 - size) {
			for (int i = y - 1; i <= y + size; i++)
				for (int j = x - 1; j <= x + 1; j++)
					if (sea[i][j] == 1)
						b = false;
			// угловые
		}
		else
			if (x == 0 && y == 0) {
				for (int i = y; i <= y + 1; i++)
					for (int j = x; j <= x + size; j++)
						if (sea[i][j] == 1)
							b = false;
			}
			else
				if (x == 9 && y == 0) {
					for (int i = y; i <= y + 1; i++)
						for (int j = x - 1; j <= x; j++)
							if (sea[i][j] == 1)
								b = false;
				}
				else
					if (x == 9 && y == 10 - size) {
						for (int i = y - 1; i <= y + size - 1; i++)
							for (int j = x - 1; j <= x; j++)
								if (sea[i][j] == 1)
									b = false;
					}
					else
						if (x == 0 && y == 10 - size) {
							for (int i = y - 1; i <= y + size - 1; i++)
								for (int j = x; j <= x + 1; j++)
									if (sea[i][j] == 1)
										b = false;
						}
						else
							// неугловые по бокам
							if (x > 0 && x < 9 && y == 0) {
								for (int i = y; i <= y + size; i++)
									for (int j = x - 1; j <= x + 1; j++)
										if (sea[i][j] == 1)
											b = false;
							}
							else
								if (y > 0 && y < 10 - size && x == 9) {
									for (int i = y - 1; i <= y + size; i++)
										for (int j = x - 1; j <= x; j++)
											if (sea[i][j] == 1)
												b = false;
								}
								else
									if (x > 0 && x < 9 && y == 10 - size) {
										for (int i = y - 1; i <= y + size - 1; i++)
											for (int j = x - 1; j <= x + 1; j++)
												if (sea[i][j] == 1)
													b = false;
									}
									else
										if (y > 0 && y < 10 - size && x == 0) {
											for (int i = y - 1; i <= y + size; i++)
												for (int j = x; j <= x + 1; j++)
													if (sea[i][j] == 1)
														b = false;
										}
	}
	return b;
}
void ship(vector<vector<bool>>& sea, int& size, bool& f, pair<int, int>& crd) {
	int x = crd.first;
	int y = crd.second;
	if (!f)
		for (int i = x; i < x + size; i++)
			sea[y][i] = 1;
	else
		for (int i = y; i < y + size; i++)
			sea[i][x] = 1;
}
void mapSea(vector<vector<bool>>& sea, bool& f) {
	// Заполняем карту компа
	// Координаты и ориентация (передается по ссылке bool f)
	pair<int, int> xy;
	// Начинаем с самого большого, потом по нисходящей
	// Размер
	//===========================  4  ===========================
	int size = 4;
	xy = coord(size, f);
	ship(sea, size, f, xy);

	//===========================  3  ===========================
	size--;
	int j = 0; // Здесь уже счетчиком
	bool q; // Для лучшего восприятия кода
	do {
		xy = coord(size, f);
		q = test(sea, xy, size, f);
		if (q) {
			j++;
			ship(sea, size, f, xy);
		}
	} while (j != 2);

	//============================  2  ===========================
	size--;
	j = 0;
	do {
		xy = coord(size, f);
		q = test(sea, xy, size, f);
		if (q) {
			j++;
			ship(sea, size, f, xy);
		}
	} while (j != 3);

	//============================  1  ============================
	size--;
	j = 0;
	do {
		xy = coord(size, f);
		q = test(sea, xy, size, f);
		if (q) {
			j++;
			ship(sea, size, f, xy);
		}
	} while (j != 4);
}
//=================INI============================
void mapsIni(vector<vector<bool>>& usermapbool,
	vector<vector<char>>& uservision,
	vector<vector<bool>>& compmapbool,
	vector<vector<char>>& compvision) {
	for (size_t i = 0; i < 10; i++)
		for (size_t j = 0; j < 10; j++) {
			uservision[i].push_back('.');
			compvision[i].push_back('.');
		}
	for (size_t i = 0; i < 10; i++)
		for (size_t j = 0; j < 10; j++) {
			usermapbool[i].push_back(0);
			compmapbool[i].push_back(0);
		}
}
void printMapUser(vector<vector<char>>& uservision,
	vector<vector<bool>>& usermapbool,
	bool& check) {
	if (check) {
		// Значки:
		// # - контур корабля
		// X - попадание
		// . - море
		// O - промах
		for (int i = 0; i < 10; i++)
			for (int j = 0; j < 10; j++)
				if (usermapbool[i][j] == 1)
					uservision[i][j] = '#';
		cout << "  ";
		for (int i = 1; i < 11; i++) cout << setw(3) << i;
		cout << "\n";
		for (int i = 0; i < 9; i++) {
			cout << i + 1 << setw(4);
			for (int j = 0; j < 10; j++) {
				cout << uservision[i][j] << setw(3);
			}
			cout << "\n";
		}
		cout << "10  ";
		for (int j = 0; j < 10; j++)
			cout << uservision[9][j] << setw(3);
		cout << endl;
	}
	else {
		cout << "  ";
		for (int i = 1; i < 11; i++) cout << setw(3) << i;
		cout << "\n";
		for (int i = 0; i < 9; i++) {
			cout << i + 1 << setw(4);
			for (int j = 0; j < 10; j++) {
				cout << uservision[i][j] << setw(3);
			}
			cout << "\n";
		}
		cout << "10  ";
		for (int j = 0; j < 10; j++)
			cout << uservision[9][j] << setw(3);
		cout << endl;
	}
}
void printMapComp(vector<vector<char>>& compvision) {
	cout << "  ";
	for (int i = 1; i < 11; i++) cout << setw(3) << i;
	cout << "\n";
	for (int i = 0; i < 9; i++) {
		cout << i + 1 << setw(4);
		for (int j = 0; j < 10; j++) {
			cout << compvision[i][j] << setw(3);
		}
		cout << "\n";
	}
	cout << "10  ";
	for (int j = 0; j < 10; j++)
		cout << compvision[9][j] << setw(3);
	cout << endl;
}
//================================================
void mapSeaUserCreat(vector<vector<bool>>& usermapbool,
	vector<vector<char>>& uservision,
	vector<vector<bool>>& compmapbool,
	vector<vector<char>>& compvision,
	bool& check) {
	cout << "Добро пожаловать в игру\n"
		<< "\"Морской бой\"!"
		<< "\nВы должны расставить свои корабли."
		<< "\nГотовы?\nДа - 1\nНет - 0\n => ";
	bool f;
	cin >> f;
	if (!f) {
		cout << "Вы вышли!" << endl;
		exit(0);
	}
	else {
		mapsIni(usermapbool, uservision, compmapbool, compvision);
	}
	cout << "\nВедите координаты носов кораблей:\n"
		<< "горизонтальные - нос слева\n"
		<< "вертикальные - нос сверху;\n"
		<< "начало координат левый верхний угол."
		<< "\nКарта-подсказка:\n" << endl;
	printMapUser(uservision, usermapbool, check);
	cout << "\nВведите координаты (x, y) для 10 кораблей:\n";
	cout << " X Y" << endl;
	int x, y;
	int k = 0;
	int size;
	for (int i = 1; i < 5; i++) {
		size = 5 - i;
		for (int j = 1; j <= i; j++) {
			cout << ++k << " => " << size << "-палубный\nx = ";
			cin >> x;
			cout << "y = ";
			cin >> y;
			--x; --y;
			pair<int, int> xy = make_pair(x, y);
			cout << "Вертикаль (1) или горизонт (0): "; cin >> f;
			ship(usermapbool, size, f, xy);
		}
	}
	check = true;
	cout << "Ваша карта:" << endl;
	printMapUser(uservision, usermapbool, check);
	// Ввести заново? (нужно будет продумать)
	// И создаем новую карту компа
	static default_random_engine rnd(time(0));
	static uniform_int_distribution<int> t(0, 1);
	check = bool(t(rnd));
	check = bool(t(rnd));
	mapSea(compmapbool, check);
	battle(usermapbool, uservision, compmapbool, compvision);
}
void battle(vector<vector<bool>>& usermapbool,
	vector<vector<char>>& uservision,
	vector<vector<bool>>& compmapbool,
	vector<vector<char>>& compvision) {
	int x, y;
	pair<int, int> xy;
	bool step;
	int usr_count = 20;
	int cmp_count = 20;
	do {
		step = true;
		while (step) {
			cout << "Ваш ход!\n"
				<< "Определите цель:"
				<< "\nX = "; 	 cin >> x;
			cout << "Y = "; cin >> y;
			--x; --y;
			xy = make_pair(x, y);
			shot_user(compmapbool, compvision,
				usr_count, step, xy);
			if (step) {
				cout << "Точное попадание!" << endl;
				printMapComp(compvision);
			}
			else {
				cout << "Вы не попали. Играет компьютер" << endl;
			}
		}
		if (!usr_count) {
			cout << "Поздравляем, Вы победили!" << endl;
			break;
		}
		step = true;
		while (step) {
			shot_comp(usermapbool, uservision, cmp_count, step);
			if (step) {
				cout << "Компьютер попал!" << endl;
				bool f = !step;
				printMapUser(uservision, usermapbool, f);
			}
			else {
				cout << "Компьютер не попал!" << endl;
			}
		}
	} while (usr_count && cmp_count);
	cout << "Хотите повторить?\n"
		<< "Да - 1\nНет - 0\n => ";
	bool f;
	cin >> f;
	if (!f) {
		cout << "Вы вышли!" << endl;
		exit(0);
	}
	else {
		f = !f;
		mapsIni(usermapbool, uservision, compmapbool, compvision);
		mapSeaUserCreat(usermapbool, uservision, compmapbool, compvision, f);
	}
}
pair<int, int> crdcomp() {
	static default_random_engine rnd(time(0));
	static uniform_int_distribution<int> d(0, 9);
	int x = d(rnd);
	x = d(rnd);
	int y = d(rnd);
	pair<int, int> xy = make_pair(x, y);
	return xy;
}
void shot_user(vector<vector<bool>>& compmapbool,
	vector<vector<char>>& compvision,
	int& usr_count, bool& usr_step,
	pair<int, int>& xy) {
	int x = xy.first;
	int y = xy.second;
	if (compmapbool[y][x] == 1) {
		usr_count--;
		compvision[y][x] = 'X';
	}
	else {
		compvision[y][x] = 'O';
		usr_step = false;
	}
}
void shot_comp(vector<vector<bool>>& usermapbool,
	vector<vector<char>>& uservision,
	int& cmp_count, bool& usr_step) {
	pair<int, int> xy = crdcomp();
	int x = xy.first;
	int y = xy.second;
	if (usermapbool[y][x] == 1) {
		cmp_count--;
		uservision[y][x] = 'X';
	}
	else {
		uservision[y][x] = 'O';
		usr_step = false;
	}
}
