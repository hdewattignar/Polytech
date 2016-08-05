using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MixAndMatch
{
    enum CharacterTypes { Fairy, Frankenstein, Skeleton, Vampire, Werewolf, Witch}
   
    class CharacterMaker
    {
        Head head { get; set; }
        Body body { get; set; }
        Feet feet { get; set; }

        
        public Character createCharacter(int newHead, int newBody, int newFeet)
        {
            switch (newHead)
            {
                case 0:
                    head = new FairyHead();
                    break;
                case 1:
                    head = new FrankensteinHead();
                    break;
                case 2:
                    head = new SkeletonHead();
                    break;
                case 3:
                    head = new VampireHead();
                    break;
                case 4:
                    head = new WerewolfHead();
                    break;
                case 5:
                    head = new WitchHead();
                    break;
            }

            switch (newBody)
            {
                case 0:
                    body = new FairyBody();
                    break;
                case 1:
                    body = new FrankensteinBody();
                    break;
                case 2:
                    body = new SkeletonBody();
                    break;
                case 3:
                    body = new VampireBody();
                    break;
                case 4:
                    body = new WerewolfBody();
                    break;
                case 5:
                    body = new WitchBody();
                    break;
            }

            switch (newFeet)
            {
                case 0:
                    feet = new FairyFeet();
                    break;
                case 1:
                    feet = new FrankensteinFeet();
                    break;
                case 2:
                    feet = new SkeletonFeet();
                    break;
                case 3:
                    feet = new VampireFeet();
                    break;
                case 4:
                    feet = new WerewolfFeet();
                    break;
                case 5:
                    feet = new WitchFeet();
                    break;
            }

            Character character = new Character(head, body, feet);
            return character;
        }
    }
}
