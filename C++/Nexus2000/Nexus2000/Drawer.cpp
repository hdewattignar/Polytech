#include "StdAfx.h"
#include "Drawer.h"


void Drawer::Init(Graphics^ form)
{
	formGraphics = form;

	border = gcnew Pen(Color::White);
	outline = gcnew Pen(Color::Black);
	emptyBoardBrush = gcnew SolidBrush(Color::Black);	
}

void Drawer::DrawBoard(Board &b)
{	
	for (int i = 0; i < 9; i++)
	{
		for (int j = 0; j < 9; j++)
		{
			switch (b.getCell(i, j))
			{
			case 0:		

				formGraphics->DrawImage(free, Rectangle(j * 40, i * 40, 40, 40));
				break;

			case 1:

				formGraphics->DrawImage(bleau, Rectangle(j * 40, i * 40, 40, 40));
				break;

			case 2:

				formGraphics->DrawImage(green, Rectangle(j * 40, i * 40, 40, 40));
				break;

			case 3:

				formGraphics->DrawImage(purple, Rectangle(j * 40, i * 40, 40, 40));
				break;

			case 4:

				formGraphics->DrawImage(red, Rectangle(j * 40, i * 40, 40, 40));
				break;

			case 5:

				formGraphics->DrawImage(yellow, Rectangle(j * 40, i * 40, 40, 40));
				break;

			case 6:

				formGraphics->DrawImage(blue, Rectangle(j * 40, i * 40, 40, 40));
				break;

			case 7:

				formGraphics->DrawImage(selected, Rectangle(j * 40, i * 40, 40, 40));
				break;

			default:

				formGraphics->FillRectangle(emptyBoardBrush, Rectangle(j * BLOCK_SIZE, i * BLOCK_SIZE, BLOCK_SIZE, BLOCK_SIZE));
				break;

			}
		}		
	}	
}

void Drawer::DrawGameOver()
{
	formGraphics->DrawImage((Bitmap^)Image::FromFile("img\\blue.png", true), Rectangle(40, 40, 40, 40));
}