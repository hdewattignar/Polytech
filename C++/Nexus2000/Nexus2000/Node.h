#pragma once
#include <math.h>

#define WORLD_SIZE 81

class Node
{
public:

	Node(int nX, int nY, int t);	
	Node(int x, int y, Node *_parent, float moveCost, Node* nodeEnd);

	int nodeX;
	int nodeY;	
	int pieceType;

	Node *parent;
	float G;				//accumilatied distance to goal node
	float H;				//estimated distance to goal
	float GetF();			
	float GetG();
	float ManDist(Node* nodeEnd);	

	int getValue();
	void setNode(int nX, int nY, int t);
	int getX();
	int getY();
	
};

