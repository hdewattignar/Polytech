#include "StdAfx.h"
#include "Drawer.h"
#include <iostream>

using namespace std;

void Drawer::Init(Graphics^ f)
{
	formGraphics = f;
	blockBrush = gcnew SolidBrush(Color::Red);
	emptyBrush = gcnew SolidBrush(Color::Green);
	fillBoardBrush = gcnew SolidBrush(Color::Blue);
	emptyBoardBrush = gcnew SolidBrush(Color::Gray);
	border = gcnew Pen(Color::Black);

}

void Drawer::DrawPiece(Piece &p)
{
	for (int i = 0; i < 5; i++)
	{
		for (int j = 0; j < 5; j++)
		{			
			if (p.cellType(i, j) > 0)
			{
				formGraphics->FillRectangle(blockBrush, Rectangle((p.getX() + i) * BLOCK_SIZE, (p.getY() + j) * BLOCK_SIZE, BLOCK_SIZE, BLOCK_SIZE));
				formGraphics->DrawRectangle(border, Rectangle((p.getX() + i) * BLOCK_SIZE, (p.getY() + j) * BLOCK_SIZE, BLOCK_SIZE, BLOCK_SIZE));
			}
			
		}		
	}	
}

void Drawer::DrawBoard(Board &b)
{
	for (char i = 0; i < BOARD_HEIGHT; i++)
	{
		for (char j = 0; j < BOARD_WIDTH; j++)
		{
			//formGraphics->FillRectangle(boardBrush, Rectangle(j * BLOCK_SIZE, i * BLOCK_SIZE, BLOCK_SIZE, BLOCK_SIZE));
			
			if (b.cellType(i, j) > 0)
			{
				formGraphics->FillRectangle(fillBoardBrush, Rectangle(j * BLOCK_SIZE, i * BLOCK_SIZE, BLOCK_SIZE, BLOCK_SIZE));
			}
			else
			{
				formGraphics->FillRectangle(emptyBoardBrush, Rectangle(j * BLOCK_SIZE, i * BLOCK_SIZE, BLOCK_SIZE, BLOCK_SIZE));
				formGraphics->DrawRectangle(border, Rectangle(j * BLOCK_SIZE, i * BLOCK_SIZE, BLOCK_SIZE, BLOCK_SIZE));				
			}			
		}
	}
}

void Drawer::DrawNextPiece(Piece &nP)
{
	for (int i = 0; i < 5; i++)
	{
		for (int j = 0; j < 5; j++)
		{
			if (nP.nCellType(i, j) > 0)
			{
				formGraphics->FillRectangle(emptyBrush, Rectangle( i * BLOCK_SIZE,  j * BLOCK_SIZE, BLOCK_SIZE, BLOCK_SIZE));
			}
			else
			{
				formGraphics->FillRectangle(emptyBoardBrush, Rectangle( i * BLOCK_SIZE, j * BLOCK_SIZE, BLOCK_SIZE, BLOCK_SIZE));
			}
		}
	}
}
