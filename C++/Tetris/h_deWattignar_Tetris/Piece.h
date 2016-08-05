#pragma once

class Piece
{
	int pPiece[5][5];
	int nPiece[5][5];
	int nRotation[5][5];
	int type;
	int rotation;
	int pX;
	int pY;

public:	
	Piece();	
	void Piece::Draw();	
	void rotatePiece();
	
	int  cellType(int x, int y);
	int  nCellType(int x, int y);
	void resetPieceXY();

	void setActivePiece();
	void setActivePiece(int pType, int pRotation);
	void setNextPiece(int pType, int pRotation);
	void nextRotation(int pType, int pRotation);

	int  getX();
	int  getY();
	void setX(int newX);
	void setY(int newY);
	int  getRotation();
	int  getType();		
};
