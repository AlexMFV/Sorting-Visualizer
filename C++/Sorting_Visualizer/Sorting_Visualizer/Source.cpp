#include <SFML/Graphics.hpp>
#include "Common.h"
#include "Array.h"
#include <vector>
#include <iostream>

int main() {

	CreateNewArray(ARRAY_NUMBERS, ARRAY_SIZE);

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
					SortArray(Algorithm::Bubble_Sort, ARRAY_NUMBERS); //Change to Enum
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