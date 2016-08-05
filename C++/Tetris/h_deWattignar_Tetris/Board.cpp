#include "StdAfx.h"
#include "Board.h"
#include "Drawer.h"



Board::Board()
{
	InitBoard();
}

void Board::InitBoard()
{
	for (int i = 0; i < BOARD_WIDTH; i++)
	{
		for (int j = 0; j < BOARD_HEIGHT; j++)
			mBoard[i][j] = 0;
	}	
}

void Board::Draw()
{
	Drawer::DrawBoard(*this);
}

void Board::StorePiece(Piece& p)
{
	for (int i = 0; i < 5; i++)
	{
		for (int j = 0; j < 5; j++)
		{
			if (p.cellType(i, j) > 0 && (p.getY() + i) >= 0 && (p.getX() + j) >= 0)
			{
				mBoard[p.getY() + j][p.getX() + i] = 1;
			}
		}
	}
}


bool Board::IsGameOver()
{
	for (int i = 0; i < BOARD_WIDTH; i++)
	{
		if (mBoard[0][i] == 1) return true;
	}

	return false;
}


int Board::cellType(int x, int y)
{
	if (y >= 0 && y < BOARD_WIDTH && x >= 0 && x < BOARD_HEIGHT)
		return mBoard[x][y];
	else
		return -1;
}

void Board::deleteLine(int pY)
{
	// Moves all the upper lines one row down
	for (int i = pY; i > 0; i--)
	{
		for (int j = 0; j < BOARD_WIDTH; j++)
		{
			mBoard[i][j] = mBoard[i][j - 1];
		}
	}
}

void Board::DeletePossibleLines()
{
	for (int i = 0; i < BOARD_HEIGHT; i++)
	{
		int j = 0;
		while (j < BOARD_WIDTH)
		{
			if (mBoard[i][j] != 1) 
				break;
			j++;
		}

		if (j == BOARD_WIDTH ) 
			deleteLine(i);
	}
}


