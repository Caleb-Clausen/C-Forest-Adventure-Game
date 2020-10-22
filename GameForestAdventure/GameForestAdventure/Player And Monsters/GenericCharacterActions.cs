// This Interface is the overall Program helper to allow the PlayerCharacter and Monster classes to have the same action methods
// Provides functionality to remove health from the current object calling Attack()
// Provides functionality to remove health from the current object calling SpellAttack()

using System;
using System.Collections.Generic;
using System.Text;
using GameForestAdventure.MenuObjects.DataHelper;

namespace GameForestAdventure.Player_And_Monsters
{
    interface IGenericCharacterActions
    {
        //TODO: Implement Attack to allow the Player and monsters to attack each other
        private void Attack(Object current)
        {

        }
        //TODO: Implement SpellAttack to allow the Player and monsters to attack each other
        private void SpellAttack(Object current)
        {
        
        }

    }
}
