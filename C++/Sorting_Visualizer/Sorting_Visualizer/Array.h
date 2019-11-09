#pragma once
#include <random>
#include <chrono>
#include <algorithm>
#include <windows.h>

enum Algorithm {
	Bubble_Sort
};

void CreateNewArray(std::vector<int> &arr, int size);
void ShuffleArray(std::vector<int> &arr);
void SortArray(int algorithm, std::vector<int>& arr);
void Swap(std::vector<int>& arr, int before, int after);
void DrawArray(sf::RenderWindow& win, int winW, int winH, std::vector<int> vect, int width, int height, int offset);
void Redraw(int a);

//Sorting Prototypes
void BubbleSort(std::vector<int>& arr);

void CreateNewArray(std::vector<int> &arr, int size) {
	arr.clear();

	for (int i = 1; i <= size; i++)
		arr.push_back(i);
}

void ShuffleArray(std::vector<int> &arr) {
	std::random_shuffle(arr.begin(), arr.end());
}

void SortArray(int algorithm, std::vector<int> &arr) {
	switch (algorithm) {
		case Algorithm::Bubble_Sort: BubbleSort(arr);
	}
}

void Swap(std::vector<int>& arr, int before, int after) {
	int value = arr[before];
	arr[before] = arr[after];
	arr[after] = value;
}

//Draws the complete array to the screen
void DrawArray(sf::RenderWindow& win, int winW, int winH, std::vector<int> vect, int width, int height, int offset) {
	for (int i = 0; i < vect.size(); i++) {
		sf::RectangleShape rect(sf::Vector2f(width, vect[i] * height));
		rect.setPosition(sf::Vector2f(i * width + (offset * i + 1), winH - (vect[i] * height) - offset));
		//rect.setScale(sf::Vector2f(width, height));
		rect.setFillColor(sf::Color::White);
		win.draw(rect);
	}
} 

void Redraw(int a) {
	window.clear(sf::Color::Black);
	DrawArray(window, WIN_W, WIN_H, ARRAY_NUMBERS, VIS_WIDTH, VIS_HEIGHT, VIS_OFFSET);
	window.display();
}

#pragma region Sorting Algorithms

void BubbleSort(std::vector<int>& arr) {
	bool isSorted = false;
	int aux;
	while (!isSorted) {
		aux = 0;
		isSorted = true;

		while (aux < arr.size() - 1) {
			aux++;
			if (arr[aux - 1] > arr[aux]) {
				Swap(arr, aux - 1, aux);
				isSorted = false;
			}
			Sleep(sort_speed);
			Redraw(1);
		}
	}
}

#pragma endregion