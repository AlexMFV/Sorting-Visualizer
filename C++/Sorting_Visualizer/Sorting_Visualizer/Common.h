#pragma once

//Window Variables
int WIN_W = 1200;
int WIN_H = 800;
const char* WIN_TITLE = "Teste";

sf::RenderWindow window(sf::VideoMode(WIN_W, WIN_H), WIN_TITLE);

//Array Variables
std::vector<int> ARRAY_NUMBERS;
int ARRAY_SIZE = 100; //Must always be less than half of the height?

//Visualizer Variables
int VIS_OFFSET = 5; //Pixels between borders and drawn array
int VIS_WIDTH = (WIN_W - (VIS_OFFSET * ARRAY_SIZE)) / ARRAY_SIZE;
int VIS_HEIGHT = (WIN_H - VIS_OFFSET * 2) / ARRAY_SIZE; //Multiplier

//Sorting Variables
float sort_speed = 0; //In microseconds