#pragma once
#include <vector>

#define BLOCK_SIZE 40
#define BOARD_HEIGHT 9
#define BOARD_WIDTH 9

using namespace std;

class Board
{
	int mBoard[BOARD_HEIGHT][BOARD_WIDTH];
	vector<pair<int, int>> line;
	int score = 0;

public:	
	Board();
	void initBoard();
	void drawBoard();
	void checkVertLine();
	void checkHoriLine();
	void checkLDiag();
	void checkRDiag();
	void deleteLine();
	void setCellValue(int x, int y, int value);
	int getCell(int x, int y);
	int getScore();
	
};
