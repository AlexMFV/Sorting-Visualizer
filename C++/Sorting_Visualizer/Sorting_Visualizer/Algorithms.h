#pragma once
#include "Array.h"

enum Algorithm {
	Bubble_Sort
};

void BubbleSort(std::vector<int>& arr);
void Swap(std::vector<int>& arr, int before, int after);

void BubbleSort(std::vector<int>& arr) {
	bool isSorted = false;
	int aux;
	while (!isSorted) {
		aux = 0;
		isSorted = true;

		while (aux < arr.size()-1) {
			aux++;
			if (arr[aux - 1] > arr[aux]) {
				Swap(arr, aux - 1, aux);
				isSorted = false;
			}
		}
	}
}

void Swap(std::vector<int> &arr, int before, int after) {
	int value = arr[before];
	arr[before] = arr[after];
	arr[after] = value;
}