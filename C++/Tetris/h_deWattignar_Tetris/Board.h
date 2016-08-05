#pragma once

# include "Piece.h"

#define BOARD_WIDTH 10
#define BOARD_HEIGHT 20
#define BLOCK_SIZE 25

class Board
{
	char mBoard[BOARD_HEIGHT][BOARD_WIDTH];

public:
	Board(void);	
	void InitBoard();
	int cellType(int, int);
	void Draw();
	void deleteLine(int y);
	void DeletePossibleLines();
	void StorePiece(Piece&);
	bool IsGameOver();

private:	
	Piece *mPiece;	
};
