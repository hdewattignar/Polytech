#include "StdAfx.h"
#include "Board.h"
#include "Drawer.h"

Board::Board()
{
	initBoard();
}


//put 0's in all cells to initialize board
void Board::initBoard()
{
	for (int i = 0; i < BOARD_WIDTH; i++)
	{
		for (int j = 0; j < BOARD_HEIGHT; j++)
		{
			mBoard[i][j] = 0;
		}
	}
}

//pass the board object to the drawer
void Board::drawBoard()
{
	Drawer::DrawBoard(*this);
}

//********************** check for completed lines **********************
//initerate through the board array
//if the current cell has the same value as the next cell add it through the vector
//then increment the next cell
//if you have a vector larger than 5 delete all the cells in the vector
void Board::checkVertLine()
{
	int nextPlace = 1;
	for (int i = 0; i < BOARD_HEIGHT; i++)
	{
		for (int j = 0; j < BOARD_WIDTH; j++)
		{
			if (mBoard[i][j] != 0)
			{				
				line.push_back(std::make_pair(i, j));

				while ((i + nextPlace != BOARD_HEIGHT) && (mBoard[i][j] == mBoard[i + nextPlace][j]))
				{					
					line.push_back(std::make_pair(i + nextPlace, j));
					nextPlace++;
				}

				if (line.size() >= 5)
				{
					deleteLine();
				}
			}
			line.clear();
			nextPlace = 1;			
		}		
	}	
}

void Board::checkHoriLine()
{
	int nextPlace = 1;
	for (int i = 0; i < BOARD_HEIGHT; i++)
	{
		for (int j = 0; j < BOARD_WIDTH; j++)
		{
			if (mBoard[i][j] != 0)
			{				
				line.push_back(std::make_pair(i, j));

				while ((j + nextPlace != BOARD_WIDTH) && (mBoard[i][j] == mBoard[i][j + nextPlace]))
				{					
					line.push_back(std::make_pair(i, j + nextPlace));
					nextPlace++;
				}

				if (line.size() >= 5)
				{
					deleteLine();
				}
			}			
			line.clear();
			nextPlace = 1;			
		}		
	}
}

void Board::checkLDiag()
{
	int nextPlace = 1;
	for (int i = 0; i < BOARD_HEIGHT; i++)
	{
		for (int j = 0; j < BOARD_WIDTH; j++)
		{
			if (mBoard[i][j] != 0)
			{
				line.push_back(std::make_pair(i, j));

				while ((j + nextPlace != BOARD_WIDTH) && (mBoard[i][j] == mBoard[i - nextPlace][j + nextPlace]))
				{
					line.push_back(std::make_pair(i - nextPlace, j + nextPlace));
					nextPlace++;
				}

				if (line.size() >= 5)
				{
					deleteLine();
				}
			}
			line.clear();
			nextPlace = 1;
		}
	}
}

void Board::checkRDiag()
{
	int nextPlace = 1;
	for (int i = 0; i < BOARD_HEIGHT; i++)
	{
		for (int j = 0; j < BOARD_WIDTH; j++)
		{
			if (mBoard[i][j] != 0)
			{
				line.push_back(std::make_pair(i, j));

				while ((j + nextPlace != BOARD_WIDTH) && (mBoard[i][j] == mBoard[i + nextPlace][j + nextPlace]))
				{
					line.push_back(std::make_pair(i + nextPlace, j + nextPlace));
					nextPlace++;
				}

				if (line.size() >= 5)
				{
					deleteLine();
				}
			}
			line.clear();
			nextPlace = 1;
		}
	}
}

//delete all the cells from the completed line vector
//add to score
void Board::deleteLine()
{
	for (unsigned int i = 0; i < line.size(); i++)
	{
		mBoard[line.at(i).first][line.at(i).second] = 0;		
	}

	score = score + (line.size() * 5);
}

//set the value of an index
void Board::setCellValue(int x, int y, int value)
{
	mBoard[x][y] = value;
}

//returns cell value
int Board::getCell(int x, int y)
{
	return mBoard[x][y];
}

//return the score
int Board::getScore()
{
	return score;
}

