using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Character
{
   
    public partial class Form1 : Form
    {

        List<Character> characterList = new List<Character>();

        public Form1()
        {
            InitializeComponent();            

            // create default characters
            characterList.Add(new King("Dennis", BattleBox));
            characterList.Add(new Queen("Dee", BattleBox));
            characterList.Add(new Knight("Mac", BattleBox));
            characterList.Add(new Knight("Charlie", BattleBox));
            characterList.Add(new Troll("Frank", BattleBox));

            // add characters to battle list
            for (int i = 0; i < characterList.Count; i++ )
                checkedListBox1.Items.Add(characterList[i].getName());

            // add characters to change weapon list
            for (int i = 0; i < characterList.Count; i++)
                checkedListBox2.Items.Add(characterList[i].getName());
        }

        private void btnAddCharacter_Click(object sender, EventArgs e)
        {           
            //add a new character
            //make sure a name has been entered
            if (txtName.Text != "")
            {
                // get thtext from the text box
                String characterName = txtName.Text;

                // find the checked radio button
                // and add the new character to the list boxes
                if (rdKing.Checked == true)
                {
                    checkedListBox1.Items.Add(new King(characterName, BattleBox).getName());
                    checkedListBox2.Items.Add(new King(characterName, BattleBox).getName());
                }
                else if (rdQueen.Checked == true)
                {
                    checkedListBox1.Items.Add(new Queen(characterName, BattleBox).getName());
                    checkedListBox2.Items.Add(new Queen(characterName, BattleBox).getName());
                }
                else if (rdKnight.Checked == true)
                {
                    checkedListBox1.Items.Add(new Knight(characterName, BattleBox).getName());
                    checkedListBox2.Items.Add(new Knight(characterName, BattleBox).getName());
                }
                else if (rdTroll.Checked == true)
                {
                    checkedListBox1.Items.Add(new Troll(characterName, BattleBox).getName());
                    checkedListBox2.Items.Add(new Troll(characterName, BattleBox).getName());
                }
                else
                    MessageBox.Show("Please choose a character type");
            }    
            else
                MessageBox.Show("Please enter character name");
        }

        private void btnBattle_Click(object sender, EventArgs e)
        {
            // get all the checked characters and add them to a list
            List<Character> checkedList = new List<Character>();
                        
            for (int i = 0; i < checkedListBox1.CheckedItems.Count; i++)
            {
                for (int j = 0; j < characterList.Count; j++)
                {
                    if (characterList[j].getName() == (String) checkedListBox1.CheckedItems[i])
                    {
                        checkedList.Add(characterList[j]);
                    }
                }
            }

            // loop through the list adding the characters to the battle box
            for (int i = 0; i < checkedList.Count; i++)
            {
                BattleBox.Items.Add("----------------------------------------------------------------------------------------------");
                checkedList[i].StateName();
                checkedList[i].Declaim();
                checkedList[i].Battle();
                BattleBox.Items.Add("----------------------------------------------------------------------------------------------");
            }
        }

        private void btn_changeWeapon(object sender, EventArgs e)
        {

            // get all the checked characters and add them to a list
            List<Character> checkedList = new List<Character>();

            for (int i = 0; i < checkedListBox2.CheckedItems.Count; i++)
            {
                for (int j = 0; j < characterList.Count; j++)
                {
                    if (characterList[j].getName() == (String)checkedListBox2.CheckedItems[i])
                    {
                        checkedList.Add(characterList[j]);
                    }
                }
            }

            //get the selected weapon from the check boxes and loop through the checked characters and set there new weapons
            IWeapon newWeapon = null;

            if (rdSword.Checked == true)
            {
                newWeapon = new WeaponSword();
            }
            else if (rdKnife.Checked == true)
            {
                newWeapon = new WeaponKnife();
            }
            else if (rdBow.Checked == true)
            {
                newWeapon = new WeaponBow();
            }
            else
                MessageBox.Show("Please choose a weapon");


            if (newWeapon != null)
            {
                for (int i = 0; i < checkedList.Count; i++)
                {
                    checkedList[i].setWeapon(newWeapon);
                }
            }
        }
    }
}
