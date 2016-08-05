#include "stdafx.h"
#include "Node.h"


Node::Node(int nX, int nY, int t)
{
	nodeX = nX;
	nodeY = nY;
	pieceType = t;
	
	G = 0;
	H = 0;	
	parent = 0;
}

Node::Node(int nX, int nY, Node *_parent, float moveCost, Node* nodeEnd)
{
	nodeX = nX;
	nodeY = nY;
	parent = _parent;

	pieceType = 0;
	G = _parent->GetG() + moveCost;
	H = ManDist(nodeEnd);
}

int Node::getValue()
{
	return pieceType;
}

void Node::setNode(int nX, int nY, int nT)
{
	nodeX = nX;
	nodeY = nY;
	pieceType = nT;
}

int Node::getX()
{
	return nodeX;
}

int Node::getY()
{
	return nodeY;
}

float Node::GetG()
{
	return G;
}

float Node::ManDist(Node* nodeEnd)
{
	int x = (fabs((float)this->getX() - nodeEnd->getX()));
	int y = (fabs((float)this->getY() - nodeEnd->getY()));
		
	return x + y;
}

float Node::GetF()
{ 
	return G + H; 
}