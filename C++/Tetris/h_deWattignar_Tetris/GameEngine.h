#pragma once

#include "Board.h"

class GameEngine
{
	Board *mBoard;
	Piece *activePiece;
	

public:
	GameEngine(void);	
	
	void runGame();
	bool gameStarted;
	void CreatNewPiece();	
	void InitGame();

	void DrawBoard();
	void DrawPiece();
	void DrawNextPiece();

	bool isValidDrop();
	bool isValidRightShift();
	bool isValidLeftShift();
	bool isBlockCollision();

	void dropPiece();
	void shiftPiece(int y);
	void rotatePiece();	
};
