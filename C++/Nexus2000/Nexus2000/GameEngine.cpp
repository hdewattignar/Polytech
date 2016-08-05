#include "StdAfx.h"
#include "GameEngine.h"
#include "Board.h"
#include "Drawer.h"
#include "Node.h"
#include <time.h>


//the game engine controlls the running of the game

//initialize the game engine class
GameEngine::GameEngine()
{	
	mBoard = new Board();
	prevBoard = new Board();
	pNode;	
	
	for (int i = 0; i < BOARD_HEIGHT; i++)
	{
		for (int j = 0; j < BOARD_WIDTH; j++)
		{
			emptyCells.push_back(std::make_pair(i, j));
		}
	}	
}

// populate the board
//called when the player clicks the start button
void GameEngine::startGame()
{
	mBoard->initBoard();
	gameStarted = true;
	generatePieces();
}

//runs at the start of every turn
//generates new pieces
//checks for completed lines
//updates the score
void GameEngine::runGame()
{		
	resetVector();
	generatePieces();
	mBoard->checkHoriLine();
	mBoard->checkVertLine();
	mBoard->checkLDiag();
	mBoard->checkRDiag();	
	score = mBoard->getScore();
}

//set the state the game will go back to
void GameEngine::setUndoState()
{
	for (int i = 0; i < BOARD_WIDTH; i++)
	{
		for (int j = 0; j < BOARD_HEIGHT; j++)
		{
			prevBoard->setCellValue(i, j, mBoard->getCell(i, j));
		}
	}	
	prevScore = score;
	resetVector();
}

//undo game state one turn
void GameEngine::Undo()
{
	for (int i = 0; i < BOARD_WIDTH; i++)
	{
		for (int j = 0; j < BOARD_HEIGHT; j++)
		{
			mBoard->setCellValue(i, j, prevBoard->getCell(i,j));
		}
	}	
	score = prevScore;
}

//draw a game over screen
void GameEngine::GameOver()
{
	Drawer::DrawGameOver();
}

//add random new pieces to the board
void GameEngine::generatePieces()
{
	srand(time(0));

	for (int i = 0; i < 3; i++)
	{		
		if (emptyCells.size() > 3)
		{
			index = rand() % emptyCells.size();
		}
		else
			GameOver();

		indexPair = emptyCells.at(index);
		value = rand() % 7;
		mBoard->setCellValue(indexPair.first, indexPair.second, value);
		emptyCells.erase(emptyCells.begin() + index);
	}
}

//stores the index of all the empty cells in the grid
void GameEngine::resetVector()
{
	emptyCells.clear();

	for (int i = 0; i < BOARD_HEIGHT; i++)
	{
		for (int j = 0; j < BOARD_WIDTH; j++)
		{
			
			if (mBoard->getCell( i, j) == 0)
			{
				emptyCells.push_back(make_pair(i, j));
			}
		}
	}
}

//draws the board
void GameEngine::drawBoard()
{	
	mBoard->drawBoard();
}

//used by the form to animate the ball on its path to the goal
//deletes the previous cell and adds the next cell
void GameEngine::DrawPathToGoal(int i)
{	
	if (i + 1 != pathToGoal.size())
	{
		mBoard->setCellValue(pathToGoal[i + 1]->first, pathToGoal[i + 1]->second, 0);
	}
	mBoard->setCellValue(pathToGoal[i]->first, pathToGoal[i]->second, pNode->getValue());			
}

//used by the form to get the score
int GameEngine::getScore()
{
	return score;
}

//takes an x and y to set the active node
void GameEngine::setNode(int x, int y)
{
	nNode = mBoard->getCell(x,y);

	if (nNode > 0 && nNode < 7)
	{
		pNode = new Node(x, y, nNode);
	}
	else
		nodeSelected = false;
}

//set the start node and end node
void GameEngine::moveNode(int x, int y)
{	
	foundGoal = false;

	startNode = new Node(pNode->getX(), pNode->getY(), pNode->getValue());
	goalNode = new Node(x, y, pNode->getValue());

	InitSearch(startNode , goalNode);
	if (foundGoal)
	{
		initStartGoal = false;
	}
}

//***************************************************************************
//************************  Pathfinding  ************************************
//***************************************************************************

void GameEngine::InitSearch(Node* start, Node* goal)
{
	openList.clear();
	closedList.clear();
	pathToGoal.clear();	

	openList.push_back(start);

	FindPath();
}

void GameEngine::FindPath()
{
	while (foundGoal == false)
	{
		if (openList.empty())
		{
			return;
		}
			
		Node* currentCell = getNextNode();
			
		//check if goal cell has been found
		if (currentCell->nodeX == goalNode->nodeX && currentCell->nodeY == goalNode->nodeY)
		{
			goalNode->parent = currentCell->parent;
			
			Node* getPath;
			
			for (getPath = goalNode; getPath != NULL; getPath = getPath->parent)
			{
				pathToGoal.push_back(new pair<int, int>(getPath->nodeX, getPath->nodeY));
			}			
			
			foundGoal = true;
			return;
		}
			
		//check each surrounding cell
		else
		{
			//rightCell
			CheckNode(currentCell->getX() + 1, currentCell->getY(), 10, currentCell);
			//leftCell
			CheckNode(currentCell->getX() - 1, currentCell->getY(), 10, currentCell);
			//aboveCell
			CheckNode(currentCell->getX(), currentCell->getY() + 1, 10, currentCell);
			//belowCell
			CheckNode(currentCell->getX(), currentCell->getY() - 1, 10, currentCell);			
			//left-up
			CheckNode(currentCell->getX() - 1, currentCell->getY() + 1, 14, currentCell);
			//right-up
			CheckNode(currentCell->getX() + 1, currentCell->getY() + 1, 14, currentCell);
			//left-down
			CheckNode(currentCell->getX() - 1, currentCell->getY() - 1, 14, currentCell);
			//right-down
			CheckNode(currentCell->getX() + 1, currentCell->getY() - 1, 14, currentCell);						
		}
	}
}

void GameEngine::CheckNode(int x, int y, float cost, Node *parent)
{
	//check if x and y are valid
	if (x > 8 || x < 0 || y > 8 || y < 0)
	{
		return;
	}

	//check if the cell is occupied
	if (mBoard->getCell(x, y) != 0)
	{
		return;
	}

	//check if its in closed list so it doesnt back track
	for (int i = 0; i < closedList.size(); i++)
	{
		if (x == closedList[i]->getX() && y == closedList[i]->getY())
		{
			return;
		}
	}

	Node* newChild = new Node(x, y, parent, cost, goalNode);	

	bool onOpenList = false;	
	
	//Check if new node is already in the open list and if it is see if the move cost is less
	for (int i = 0; i < openList.size(); i++)
	{
		//if node is already on the open list
		if (newChild->getX() == openList[i]->getX() && newChild->getY() == openList[i]->getY())
		{			
			//if a shorter path to the current node has been found update node
			if (openList[i]->GetF() > newChild->GetF())
			{
				openList[i]->G = newChild->G;
				openList[i]->parent = newChild->parent;		
				onOpenList = true;
			}			
		}		
	}

	if (onOpenList == false)
	{
		openList.push_back(newChild);
	}
}

Node* GameEngine::getNextNode()
{
	float bestF = 99999.0f;
	int index = -1;
	Node* nextCell;
	
	//find lowest F value
	for (int i = 0; i < openList.size(); i++)
	{
		if (openList[i]->GetF() < bestF)
		{
			bestF = openList[i]->GetF();
			index = i;
		}		
	}

	//set next cell and remove it from open list 
	if (index >= 0)
	{
		nextCell = openList[index];
		closedList.push_back(nextCell);
		openList.erase(openList.begin() + index);
	}
	
	return nextCell;
}