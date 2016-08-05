using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace RainbowChicken2016
{
    public class PelletList
    {
        Pellet headPointer = null;
        Pellet tailPointer = null;

        Rectangle boundsRectangle;

        //==============================================================================
        // Ctor
        //==============================================================================
        public PelletList(Rectangle boundsRectangle)
        {
            this.boundsRectangle = boundsRectangle;
        }

        //==============================================================================
        // Add Pellet newPellet at the end of the list.
        //==============================================================================
        public void addPellet(Pellet newPellet)
        {
            if (headPointer == null)
            {
                headPointer = newPellet;
                tailPointer = newPellet;                
            }
            else
            {
                tailPointer.Next = newPellet;
                tailPointer = newPellet;
            }
        }

        //==============================================================================
        // Walk the list, counting the number of Pellet. Return the count.
        //==============================================================================
        public int Count()
        {
            int count = 0;

            Pellet nodeWalker = headPointer;

            while(nodeWalker != null)
            {
                count++;
                nodeWalker = nodeWalker.Next;
            }

            return count;
        }

        //==============================================================================
        // Walk the list, calling the Move() method of each Pellet
        //==============================================================================
        public void Move()
        {
            Pellet nodeWalker = headPointer;

            while (nodeWalker != null)
            {
                nodeWalker.Move();
                nodeWalker = nodeWalker.Next;
            }
        }

        //==============================================================================
        // Walk the list. For each Pellet, call TestOutOfBounds, passing boundsRectangle.
        // For each node that is out of bounds, set its IsAlive property to false.
        //==============================================================================
        public void KillOutOfBounds()
        {
            Pellet nodeWalker = headPointer;

            while (nodeWalker != null)
            {
                if (nodeWalker.TestOutOfBounds(boundsRectangle) == true)
                {
                    nodeWalker.IsAlive = false;
                }

                nodeWalker = nodeWalker.Next;
            }
        }

        //==============================================================================
        // Delete the argument Pellet pelletToDelete from the list.
        // Be careful to maintain the integrity of the list, including
        // headPointer and tailPointer.
        //==============================================================================
        public void DeleteOne(Pellet pelletToDelete)
        {
            pelletToDelete.IsAlive = false;
        }

        //==============================================================================
        // Walk the list, deleting all nodes whose IsAlive propoerty is false
        //==============================================================================
        public void DeleteNotAlive()
        {
            Pellet nodeWalker = headPointer;           
                        
            while (nodeWalker != null)
            {
                if (nodeWalker.IsAlive == false)
                {
                    

                    //if the node to delete is the only node
                    if(nodeWalker == headPointer && nodeWalker == tailPointer)
                    {
                        //set both head and tail to null
                        headPointer = null;
                        tailPointer = null;
                    }

                    // if the node to delete is the head
                    else if (nodeWalker == headPointer)
                    {
                        //set head to the next node in the list
                        headPointer = nodeWalker.Next;
                    }

                    //if the node th be deleted is the last node
                    else if (nodeWalker == tailPointer)
                    {
                        Pellet nw = headPointer;


                        //find the node before the tail node and moke it the new tail
                        while (nw != null)
                        {
                            if (nw.Next == nodeWalker)
                            {
                                tailPointer = nw;
                            }

                            nw = nw.Next;
                        }
                    }

                    //if the node to be deleted is in the middle of the list
                    else
                    {
                        Pellet nw = headPointer;

                        //find the node before the node to be deleted and set it's next to the node after the node to be deleted
                        while (nw != null)
                        {
                            if (nw.Next == nodeWalker)
                            {
                                nw.Next = nodeWalker.Next;
                            }

                            nw = nw.Next;
                        }
                    }                  
                }

                nodeWalker = nodeWalker.Next;
            }
        }

        //==============================================================================
        // Walk the list, calling each node's Draw method
        //==============================================================================
        public void Draw()
        {
            Pellet nodeWalker = headPointer;

            while (nodeWalker != null)
            {
                nodeWalker.Draw();
                nodeWalker = nodeWalker.Next;
            }
        }
    }
}
