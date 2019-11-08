#include <SFML/Graphics.hpp>
#include "Array.h"
#include <vector>
#include <iostream>

void DrawArray(sf::RenderWindow &win, int winW, int winH, std::vector<int> vect, int width, int height, int offset);

int main() {

	//Window Variables
	int WIN_W = 1200;
	int WIN_H = 800;
	const char* WIN_TITLE = "Teste";

	//Array Variables
	std::vector<int> ARRAY_NUMBERS;
	int ARRAY_SIZE = 100; //Must always be less than half of the height?

	CreateNewArray(ARRAY_NUMBERS, ARRAY_SIZE);

	//Visualizer Variables
	int VIS_OFFSET = 5; //Pixels between borders and drawn array
	//int VIS_SPACING; //Spacing between array numbers
	int VIS_WIDTH = (WIN_W - (VIS_OFFSET * ARRAY_SIZE)) / ARRAY_SIZE;
	int VIS_HEIGHT = (WIN_H - VIS_OFFSET * 2) / ARRAY_SIZE; //Multiplier

	sf::RenderWindow window(sf::VideoMode(WIN_W, WIN_H), WIN_TITLE);

	//Main app loop
	while (window.isOpen()) {
		//Handle all the events
		sf::Event event;
		while (window.pollEvent(event)) {
			if (event.type == sf::Event::Closed)
				window.close();

			if (event.type == sf::Event::KeyPressed) {
				if (event.key.code == sf::Keyboard::Space)
					ShuffleArray(ARRAY_NUMBERS);
				if (event.key.code == sf::Keyboard::S)
					SortArray(0, ARRAY_NUMBERS); //Change to Enum
			}
		}

		//App Processes
		window.clear(sf::Color::Black);

		//std::cout << ARRAY_NUMBERS[0] << std::endl;
		DrawArray(window, WIN_W, WIN_H, ARRAY_NUMBERS, VIS_WIDTH, VIS_HEIGHT, VIS_OFFSET);

		window.display();
	}

	return 0;
}

//Draws the complete array to the screen
void DrawArray(sf::RenderWindow &win, int winW, int winH, std::vector<int> vect, int width, int height, int offset) {
	for (int i = 0; i < vect.size(); i++) {
		sf::RectangleShape rect(sf::Vector2f(width, vect[i] * height));
		rect.setPosition(sf::Vector2f(i * width + (offset * i+1), winH - (vect[i] * height) - offset));
		//rect.setScale(sf::Vector2f(width, height));
		rect.setFillColor(sf::Color::White);
		win.draw(rect);
	}	
}