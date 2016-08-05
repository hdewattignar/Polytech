#pragma once
#include "Board.h"
#include "Piece.h"

using namespace System::Drawing;

ref class Drawer
{
	static SolidBrush^ blockBrush;
	static SolidBrush^ emptyBrush;
	static SolidBrush^ fillBoardBrush;
	static SolidBrush^ emptyBoardBrush;
	static Pen^ border;
	static Graphics^ formGraphics;
public:
	static void Init(Graphics^ f);
	static void DrawPiece(Piece&);
	static void DrawNextPiece(Piece&);
	static void DrawBoard(Board&);
};

