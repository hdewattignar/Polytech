#include "StdAfx.h"
#include "GameEngine.h"
#include "Board.h"
#include "Piece.h"
#include "Drawer.h"



GameEngine::GameEngine(void)
{
	mBoard = 0;
	activePiece = new Piece();
	mBoard = new Board();
	
}

void GameEngine::InitGame()
{
	mBoard->InitBoard();
	//totalScore = 0;
	gameStarted = true;
	activePiece->setActivePiece(System::Random().Next(7),0);
}

void GameEngine::runGame()
{
	dropPiece();
	if (!isValidDrop() || !isBlockCollision())
	{
		mBoard->StorePiece(*activePiece);
		mBoard->DeletePossibleLines();		
		activePiece->resetPieceXY();
		CreatNewPiece();
		
		if (mBoard->IsGameOver() == true)
			gameStarted = false;		
	}	
	
}

void GameEngine::CreatNewPiece()
{	
	activePiece->setActivePiece();

	int newPiece = System::Random().Next(7);
	activePiece->setNextPiece(newPiece, 0);
	
}

void GameEngine::rotatePiece()
{
	int pType = activePiece->getType();	
	activePiece->setActivePiece(pType, 1);		
}


void GameEngine::dropPiece()
{	
	activePiece->setY(1);
}

void GameEngine::shiftPiece(int x)
{
	if (x > 0)
	{
		if (isValidRightShift() && isBlockCollision())
		{
			activePiece->setX(x);
		}
	}
	if (x < 0)
	{
		if (isValidLeftShift() && isBlockCollision())
		{
			activePiece->setX(x);
		}
	}
	

}

bool GameEngine::isValidRightShift()
{		
	if (activePiece->getX() + 1 == BOARD_WIDTH - 2)
	{
		return false;
	}
	if (activePiece->getX() + 1 == BOARD_WIDTH - 3)
	{
		for (int i = 0; i < 5; i++)
		if (activePiece->cellType(3, i) > 0)
			return false;
	}
	if (activePiece->getX() + 1 == BOARD_HEIGHT - 4)
	{
		for (int i = 0; i < 5; i++)
		if (activePiece->cellType(4, i) > 0)
			return false;
	}	

	return true;
}

bool GameEngine::isValidLeftShift()
{	
	if (activePiece->getX() == -3)
	{
		return false;
	}
	if (activePiece->getX() == -1)
	{
		for (int i = 0; i < 5; i++)
		if (activePiece->cellType(1, i) > 0)
			return false;
	}
	if (activePiece->getX() == -2)
	{
		for (int i = 0; i < 5; i++)
		if (activePiece->cellType(2, i) > 0)
			return false;
	}
	
	return true;	
}

bool GameEngine::isValidDrop()
{		
	if (activePiece->getY() + 1 == BOARD_HEIGHT - 3)
	{
		for (int i = 0; i < 5; i++)
		if (activePiece->cellType( i, 3) > 0)
			return false;
	}
	if (activePiece->getY() + 1 == BOARD_HEIGHT - 4)
	{
		for (int i = 0; i < 5; i++)
		if (activePiece->cellType( i, 4) > 0)
			return false;
	}
	if (activePiece->getY() + 1 == BOARD_HEIGHT - 2)
	{
		return false;
	}	
		
	return true;
}

bool GameEngine::isBlockCollision()
{
	for (int i = 0; i < 5; i++)
	{
		for (int j = 0; j < 5; j++)
		{
			if (activePiece->cellType(i, j) > 0 &&
				mBoard->cellType(activePiece->getY() + (j + 1), activePiece->getX() + i) > 0)
			{
				return false;
			}
		}
	}

	return true;
}


void GameEngine::DrawBoard()
{
	mBoard->Draw();
}
void GameEngine::DrawPiece()
{
	activePiece->Draw();
}

void GameEngine::DrawNextPiece()
{
	activePiece->Draw();
}