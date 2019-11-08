#pragma once
#include <random>
#include <chrono>
#include <algorithm>


void CreateNewArray(std::vector<int> &arr, int size);
void ShuffleArray(std::vector<int> &arr);

void CreateNewArray(std::vector<int> &arr, int size) {
	arr.clear();

	for (int i = 1; i <= size; i++)
		arr.push_back(i);
}

void ShuffleArray(std::vector<int> &arr) {
	std::random_shuffle(arr.begin(), arr.end());
}

void SortArray(int algorithm, std::vector<int> arr) {

}