using System;
using System.Collections.Generic;
using System.Text;

namespace Engine
{
    public class Player : LivingCreature
    {
        public int Gold { get; set; }
        public int ExperiencePoints { get; set; }
        public int Level { get; set; }
        public List<InventoryItem> Inventory { get; set; }
        public List<PlayerQuest> Quests { get; set; }
        public Location CurrentLocation { get; set; }

        //CONSTRUCTOR
        public Player(int currentHitPoints, int maximumHitPoints,
            int gold, int exp, int level) : base(currentHitPoints, maximumHitPoints)
        {
            Gold = gold;
            ExperiencePoints = exp;
            Level = level;
            Inventory = new List<InventoryItem>();
            Quests = new List<PlayerQuest>();

        }

        //HAS REQUIRED ITEM TO ENTER LOCATION
        /**Used in MOVE TO in SuperAdventure
         * 2:23 PM 7/27/2019*/
        public bool HasRequiredItemToEnterThisLocation(Location location)
        {
            if (location.ItemRequiredToEnter == null)
            {
                //There is no req'd item for this loc, so ret true;
                return true;
            }

            //See if the player has the req'd item in their inv.
            foreach(InventoryItem ii in Inventory)
            {
                if (ii.Details.ID == location.ItemRequiredToEnter.ID)
                {
                    //We found the req'd item, so return true;
                    return true;
                }
            }

            //We didn't find the req'd item in pla. inv, so ret false;
            return false;
        }

        //HAS THIS QUEST
        public bool HasThisQuest(Quest quest)
        {
            foreach(PlayerQuest playerQuest in Quests)
            {
                if(playerQuest.Details.ID == quest.ID)
                {
                    return true;
                }
            }
            return false;
        }

        //COMPLETED THIS QUEST
        public bool CompletedThisQuest(Quest quest)
        {
            foreach(PlayerQuest playerQuest in Quests)
            {
                if (playerQuest.Details.ID == quest.ID)
                {
                    return playerQuest.IsCompleted;
                }
            }
            return false;
        }

        //HAS ALL QUEST COMPLETION ITEMS
        public bool HasAllQuestCompletionItems(Quest quest)
        {
            //See if the player has all the items needed to complete the quest here
            foreach(QuestCompletionItem qci in quest.QuestCompletionItems)
            {
                bool foundItemInPlayersInventory = false;

                //Check each item in the player's inventory, to see if they have it, and enough of it.
                foreach (InventoryItem ii in Inventory)
                {
                    // The player has the item in their inventory
                    if (ii.Details.ID == qci.Details.ID)
                    {
                        foundItemInPlayersInventory = true;
                        // The player does not have enough of this item to complete the quest
                        if (ii.Quantity < qci.Quantity)
                        {
                            return false;
                        }
                    }
                }

                // The player does not have any of this quest completion item in their inventory
                if (!foundItemInPlayersInventory)
                {
                    return false;
                }

            }

            // If we got here, then the player must have all the required items, and enough of them, to complete the quest.
            return true;
            
        }//CURSOR:

        //REMOVE QUEST COMPLETION ITEMS
        public void RemoveQuestCompletionItems(Quest quest)
        {
            foreach(QuestCompletionItem qci in quest.QuestCompletionItems)
            {
                foreach(InventoryItem ii in Inventory)
                {
                    if (ii.Details.ID == qci.Details.ID)
                    {
                        //Subtract the quantity from the player's inventory that was needed to complete the quest.
                        ii.Quantity -= qci.Quantity;
                        break;
                        
                    }
                }
            }
        }

        //ADD ITEM TO INVENTORY
        public void AddItemToInventory(Item itemToAdd)
        {
            foreach(InventoryItem ii in Inventory)
            {
                if (ii.Details.ID == itemToAdd.ID)
                {
                    //Player has the item in their inventory, so incr the quantity by one.
                    ii.Quantity++;

                    return; //We added the item, and are done, so get out of this function.
                }
            }
            //Player didn't have the item, so add it to their inventory, with a quantity of 1.
            Inventory.Add(new InventoryItem(itemToAdd, 1));
        }

        //MARK QUEST AS COMPLETED
        public void MarkQuestCompleted(Quest quest)
        {
            //Find the quest in the player's quest list
            foreach(PlayerQuest pq in Quests)
            {
                if (pq.Details.ID == quest.ID)
                {
                    //Mark it as completed.
                    pq.IsCompleted = true;

                    //We found the quest, and marked it complete, so get out of this function.
                    return;
                }
            }
        }
        ///BOOKMARK: CURSOR


    }
}
