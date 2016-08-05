#pragma once
#include "Board.h"

using namespace System::Drawing;

ref class Drawer
{
	/*
	static array<Bitmap^>^ ball =
	{
		,
		(Bitmap^)Image::FromFile("img\\blue.png", true),
		(Bitmap^)Image::FromFile("img\\bleau.png", true),
		(Bitmap^)Image::FromFile("img\\green.png", true),
		(Bitmap^)Image::FromFile("img\\purple.png", true),
		(Bitmap^)Image::FromFile("img\\red.png", true),
		(Bitmap^)Image::FromFile("img\\yellow.png", true),
		(Bitmap^)Image::FromFile("img\\selected.png", true)
	};
	*/

	static Image^ free = Image::FromFile("img\\free.png", true);
	static Image^ bleau = Image::FromFile("img\\bleau.png", true);
	static Image^ green = Image::FromFile("img\\green.png", true);
	static Image^ purple = Image::FromFile("img\\purple.png", true);
	static Image^ red = Image::FromFile("img\\red.png", true);
	static Image^ yellow = Image::FromFile("img\\yellow.png", true);
	static Image^ blue = Image::FromFile("img\\blue.png", true);
	static Image^ selected = Image::FromFile("img\\selected.png", true);

	static Graphics^ formGraphics;
	static Pen^ border;
	static Pen^ outline;
	static SolidBrush^ emptyBoardBrush;
	static Bitmap^ emptyCell;

public:
	static void Init(Graphics^ f);
	static void DrawBoard(Board&);
	static void DrawGameOver();
};
