#pragma once
#include "Board.h"
#include "Node.h"
#include <vector>

using namespace std;
using namespace System;

class GameEngine
{
	Board *mBoard;
	Board *prevBoard;
	Node *pNode;
	vector<pair<int,int>> emptyCells;	
	pair<int, int> indexPair;

	int index;	
	int value;
	int nNode;
	int score = 0;
	int prevScore= 0;
	int highScore = 0;

	//pathfinding
	
	Node *GetNextCell();	
	Node *startNode;
	Node *goalNode;
	vector<Node*> openList;
	vector<Node*> closedList;
	

public:

	vector<pair<int, int>*> pathToGoal;
	bool gameStarted = false;
	bool nodeSelected = false;

	GameEngine();	
	void startGame();
	void runGame();
	void drawBoard();
	void DrawPathToGoal(int i);
	void generatePieces();
	void resetVector();
	void setNode(int x, int y);
	void moveNode(int x, int y);
	int getScore();
	void ActiveNode();	
	void GameOver();
	void setUndoState();
	void Undo();

	//pathfinding

	bool initStartGoal = false;
	bool foundGoal = false;
	void InitSearch(Node* start, Node* goal);
	void CheckNode(int x, int y, float newCost, Node *parent);
	Node* GameEngine::getNextNode();
	void FindPath();	
};
