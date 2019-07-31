using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//using System.Windows.Controls; //Tue 07/30/2019 4:41:23.47 
// Microsoft's website doesn't know what it's talking about...
// https://docs.microsoft.com/en-us/dotnet/api/system.windows.controls.richtextbox.caretposition?view=netframework-4.8
// srsly what is that? ^
// Tue 07/30/2019 5:11:11.11


using Engine; //Added to be able to reference Player. 3:17 PM 7/25/2019
//using static Engine.World; //this could get rid of some "World."'s

namespace SuperAdventure
{
    public partial class SuperAdventure : Form
    {
        private Player _player;
        private Monster _currentMonster;

        /**has to do with region RJM Button Testing Stuff
         * (not a normal part of the show, as it were)*/
        private string _selectedStat;
        private const int INCREASE = 1;
        private const int DECREASE = 2; 

        public SuperAdventure()
        {
            /**line auto added by visual studio*/
            InitializeComponent();

            //3 lines code
            #region Setup Player
            _player = new Player(10, 10, 20, 0, 1);
            MoveTo(World.LocationByID(World.LOCATION_ID_HOME));
            _player.Inventory.Add(new InventoryItem(World.ItemByID(World.ITEM_ID_RUSTY_SWORD), 1));
            #endregion Setup Player

            //5 lines code 
            #region Setup Form Labels with _player properties
            lblCurrentHitPoints.Text = _player.CurrentHitPoints.ToString();
            lblMaximumHitPoints.Text = _player.MaximumHitPoints.ToString();
            lblGold.Text             = _player.Gold.            ToString();
            lblExperience.Text       = _player.ExperiencePoints.ToString();
            lblLevel.Text            = _player.Level.           ToString();
            /** ^ Since the Text property is a string, and the CurrentHitPoints, Gold, Experience-
             * Points, and Level properties are all integers, we need to add the ToString() at the end of
             * them. This is a common way to convert numbers to strings.*/
            #endregion Setup Form Labels with _player properties
        }

        //BUTTON CLICKS, N/E/W/S.
        private void BtnNorth_Click(object sender, EventArgs e)
        {
            MoveTo(_player.CurrentLocation.LocationToNorth);
        }
        private void BtnEast_Click(object sender, EventArgs e)
        {
            MoveTo(_player.CurrentLocation.LocationToEast);
        }
        private void BtnWest_Click(object sender, EventArgs e)
        {
            MoveTo(_player.CurrentLocation.LocationToWest);
        }
        private void BtnSouth_Click(object sender, EventArgs e)
        {
            MoveTo(_player.CurrentLocation.LocationToSouth);
        }

        ///BOOKMARK: Beginning of MOVE TO 

        //MOVE TO
        /**Huge method, from line 71 to 391. update: ~294 9:49 PM 7/27/2019
         * Used once in region Setup Player in constructor,
         *  and four times in BUTTON CLICKS, N/E/W/S.
         * 1:42 PM 7/27/2019*/  
        private void MoveTo(Location newLocation)
        {
            //Does the location have any required items?
            if (!_player.HasRequiredItemToEnterThisLocation(newLocation))
            {
                rtbMessages.Text += $"You must have a {newLocation.ItemRequiredToEnter.Name} to enter this location.\n";
                return;
            }

            //Update player's current location.
            _player.CurrentLocation = newLocation;

            //Show/Hide available movement buttons.
            btnNorth.Visible = (newLocation.LocationToNorth != null);
            btnEast. Visible = (newLocation.LocationToEast  != null);
            btnWest. Visible = (newLocation.LocationToWest  != null);
            btnSouth.Visible = (newLocation.LocationToSouth != null);

            //Display current location name and description
            rtbLocation.Text = newLocation.Name + "\n";
            rtbLocation.Text += newLocation.Description + "\n";

            //Fully heal the player (it says here on this card™)
            _player.CurrentHitPoints = _player.MaximumHitPoints;

            //Update HP in UI
            lblCurrentHitPoints.Text = _player.CurrentHitPoints.ToString();
            /**^Occurs to me that I've already written a method for this in region RJM Button Testing Stuff... Guess I'll play along with the PDF for now. 2:25 AM 7/27/2019*/

            //Does the location have a quest?
            /**Large section, from line 106 ~ 258 ... updated ~ 177 9:43 PM 7/27/2019*/
            if (newLocation.QuestAvailableHere != null)
            {
                //See if the player already has the quest, and if they've completed it.
                bool playerAlreadyHasQuest = _player.HasThisQuest(newLocation.QuestAvailableHere);
                bool playerAlreadyCompletedQuest = _player.CompletedThisQuest(newLocation.QuestAvailableHere);

                //See if the player already has the quest.
                if (playerAlreadyHasQuest)
                {
                    //If the player has not completed the quest yet...
                    if (!playerAlreadyCompletedQuest)
                    {
                        //See if the player has all the items needed to complete the quest.
                        bool playerHasAllItemsToCompleteQuest = _player.HasAllQuestCompletionItems(newLocation.QuestAvailableHere);
                        
                        //The player has all items required to complete the quest
                        if (playerHasAllItemsToCompleteQuest)
                        {
                            //Display message
                            rtbMessages.Text += "\nYou complete the " +
                                newLocation.QuestAvailableHere.Name + "quest.\n";

                            //Remove quest items from inventory
                            _player.RemoveQuestCompletionItems(newLocation.QuestAvailableHere);
                            
                            // Give quest rewards
                            rtbMessages.Text += "You receive: \n" + newLocation.QuestAvailableHere.RewardExperiencePoints.ToString() + " experience points\n";
                            rtbMessages.Text += newLocation.QuestAvailableHere.RewardGold.ToString() + " gold\n";
                            rtbMessages.Text += newLocation.QuestAvailableHere.RewardItem.Name + "\n";

                            _player.ExperiencePoints += newLocation.QuestAvailableHere.RewardExperiencePoints;
                            _player.Gold += newLocation.QuestAvailableHere.RewardGold;
                            UpdateExperiencePointsLabel();
                            UpdateGoldLabel();              /**These two Update lines seemed to be missing from the PDF. - RJM Tue 07/30/2019 3:50:35.19*/


                            // Add the reward item to the player's inventory
                            _player.AddItemToInventory(newLocation.QuestAvailableHere.RewardItem);


                            // Mark the quest as completed
                            _player.MarkQuestCompleted(newLocation.QuestAvailableHere);
                            //CURSOR
                        }
                    }
                }

                else
                {
                    //The player does not already have the quest.
                    //Display the messages..
                    rtbMessages.Text += "You receive the " + newLocation.QuestAvailableHere.Name + " quest.\n";
                    rtbMessages.Text += newLocation.QuestAvailableHere.Description + "\n";
                    rtbMessages.Text += "To complete it, return with:\n";
                    foreach(QuestCompletionItem qci in newLocation.QuestAvailableHere.QuestCompletionItems)
                    {
                        if (qci.Quantity == 1)
                        {
                            rtbMessages.Text += qci.Quantity.ToString() + " " + qci.Details.Name + "\n";
                        }
                        else
                        {
                            rtbMessages.Text += qci.Quantity.ToString() + " " + qci.Details.NamePlural + "\n";
                        }

                    }
                    rtbMessages.Text += "\n";

                    //Add the quest to the player's quest list
                    _player.Quests.Add(new PlayerQuest(newLocation.QuestAvailableHere));
                }
            }
            ///End of MoveTo's Quest section.

            //Does the location have a monster?
            if (newLocation.MonsterLivingHere != null)
            {
                rtbMessages.Text += "You see a " + newLocation.MonsterLivingHere.Name + "\n";

                //Make a new monster, using the values from the standard monster in the World.Monster list
                Monster standardMonster = World.MonsterByID(newLocation.MonsterLivingHere.ID);

                _currentMonster = new Monster(standardMonster.ID, standardMonster.Name, standardMonster.MaximumDamage, standardMonster.RewardExperiencePoints, standardMonster.RewardGold, standardMonster.CurrentHitPoints, standardMonster.MaximumHitPoints);

                foreach(LootItem lootItem in standardMonster.LootTable)
                {
                    _currentMonster.LootTable.Add(lootItem);
                }

                cboWeapons.Visible = true;
                cboPotions.Visible = true;
                btnUseWeapon.Visible = true;
                btnUsePotion.Visible = true;
            }
            else
            {
                _currentMonster = null;

                cboWeapons.Visible = false;
                cboPotions.Visible = false;
                btnUseWeapon.Visible = false;
                btnUsePotion.Visible = false;
            }

            // Refresh player's inventory list
            UpdateInventoryListInUI();
            // Refresh player's quest list
            UpdateQuestListInUI();
            // Refresh player's weapons combobox
            UpdateWeaponListInUI();
            // Refresh player's potions combobox
            UpdatePotionListInUI();

            ///Mon 07/29/2019 4:38:10.45
        }
        ///BOOKMARK: end MoveTo


        ///PDF Lesson 16.1, pg 98 //10:57 PM 7/28/2019

        ///UPDATE LISTS IN USER INTERFACE

        //UPDATE INVENTORY LIST IN USER INTERFACE
        private void UpdateInventoryListInUI()
        {
            dgvInventory.RowHeadersVisible = false;
            dgvInventory.ColumnCount = 2;
            dgvInventory.Columns[0].Name = "Name";
            dgvInventory.Columns[0].Width = 197;
            dgvInventory.Columns[1].Name = "Quantity";
            dgvInventory.Rows.Clear();
            foreach(InventoryItem inventoryItem in _player.Inventory)
            {
                if (inventoryItem.Quantity > 0)
                {
                    dgvInventory.Rows.Add(new[]
                    {
                        inventoryItem.Details.Name,
                        inventoryItem.Quantity.ToString()
                    });
                }
            }
        }

        //UPDATE QUEST LIST IN USER INTERFACE
        private void UpdateQuestListInUI()
        {
            dgvQuests.RowHeadersVisible = false;
            dgvQuests.ColumnCount = 2;
            dgvQuests.Columns[0].Name = "Name";
            dgvQuests.Columns[0].Width = 197;
            dgvQuests.Columns[1].Name = "Done?";
            dgvQuests.Rows.Clear();
            foreach(PlayerQuest playerQuest in _player.Quests)
            {
                dgvQuests.Rows.Add(new[]
                {
                    playerQuest.Details.Name,
                    playerQuest.IsCompleted.ToString()
                });
            }
        }

        //UPDATE WEAPON LIST IN USER INTERFACE
        private void UpdateWeaponListInUI()
        {
            List<Weapon> weapons = new List<Weapon>();
            foreach(InventoryItem inventoryItem in _player.Inventory)
            {
                if(inventoryItem.Details is Weapon)
                {
                    if (inventoryItem.Quantity > 0)
                    {
                        weapons.Add((Weapon)inventoryItem.Details);
                    }
                }
            }
            if (weapons.Count == 0)
            {
                ///The player doesn't have any weapons, so hide the weapon combobox and "Use button.
                cboWeapons.Visible = false;
                btnUseWeapon.Visible = false;
            }
            else
            {
                cboWeapons.DataSource = weapons;
                cboWeapons.DisplayMember = "Name";
                cboWeapons.ValueMember = "ID";
                cboWeapons.SelectedIndex = 0;
            }
        }

        //UPDATE POTION LIST IN USER INTERFACE
        private void UpdatePotionListInUI()
        {
            List<HealingPotion> healingPotions = new List<HealingPotion>();
            foreach(InventoryItem inventoryItem in _player.Inventory)
            {
                if(inventoryItem.Details is HealingPotion)
                {
                    if (inventoryItem.Quantity > 0)
                    {
                        healingPotions.Add((HealingPotion)inventoryItem.Details);
                    }
                }
            }
            if (healingPotions.Count == 0)
            {
                ///The player doesn't have any potions, so hide the potion combobox and "Use" button.
                cboPotions.Visible = false;
                btnUsePotion.Visible = false;
            }
            else
            {
                cboPotions.DataSource = healingPotions;
                cboPotions.DisplayMember = "Name";
                cboPotions.ValueMember = "ID";
                cboPotions.SelectedIndex = 0;
            }
        }

        ///BOOKMARK: Previous four methods: PDF Lesson 16.1, pg 98 //Mon 07/29/2019 4:15:05.65
        /// Next : Button Clicks.

        //BUTTON CLICKS, USE WPN/POTION     
        private void BtnUseWeapon_Click(object sender, EventArgs e)
        {
            /**Get the currently selected weapon from the cboWeapons ComboBox*/
            Weapon currentWeapon = (Weapon)cboWeapons.SelectedItem;

            /**Determine the amount of damage to do to the monster*/
            int damageToMonster = RandomNumberGenerator.NumberBetween(currentWeapon.MinimumDamage, currentWeapon.MaximumDamage);

            /**Apply the damage to the monster's CurrentHitPoints*/
            _currentMonster.CurrentHitPoints -= damageToMonster;

            /**Display message*/
            rtbMessages.Text += "You hit the " + _currentMonster.Name + " for " + damageToMonster.ToString() + " points." + Environment.NewLine;

            /**Check if the monster is dead*/
            if (_currentMonster.CurrentHitPoints <= 0)
            {
                /**Monster is dead*/
                rtbMessages.Text += Environment.NewLine;
                rtbMessages.Text += "You defeated the " + _currentMonster.Name + Environment.NewLine;

                /**Give player experience points for killing the monster*/
                _player.ExperiencePoints += _currentMonster.RewardExperiencePoints;
                rtbMessages.Text += "You receive " + _currentMonster.RewardExperiencePoints.ToString() + " experience points" + Environment.NewLine;

                /**Give player gold for killing the monster*/
                _player.Gold += _currentMonster.RewardGold;
                rtbMessages.Text += "You receive " + _currentMonster.RewardGold.ToString() + " gold" + Environment.NewLine;

                /**Get random loot items from the monster*/
                List<InventoryItem> lootedItems = new List<InventoryItem>();

                /**Add items to the lootedItems list, comparing a random number to the drop percentage*/
                foreach(LootItem lootItem in _currentMonster.LootTable)
                {
                    if (RandomNumberGenerator.NumberBetween(1, 100) <= lootItem.DropPercentage)
                    {
                        lootedItems.Add(new InventoryItem(lootItem.Details, 1));
                    }
                }

                /**If no items were randomly selected, then add the default loot item(s)*/
                if (lootedItems.Count == 0)
                {
                    foreach(LootItem lootItem in _currentMonster.LootTable)
                    {
                        if (lootItem.IsDefaultItem)
                        {
                            lootedItems.Add(new InventoryItem(lootItem.Details, 1));
                        }
                    }
                }

                /**Add the looted items to the player's inventory*/
                foreach(InventoryItem inventoryItem in lootedItems)
                {
                    _player.AddItemToInventory(inventoryItem.Details);
                    string pluralOrNotString = (inventoryItem.Quantity == 1) ? inventoryItem.Details.Name : inventoryItem.Details.NamePlural;
                    rtbMessages.Text += "You loot" + inventoryItem.Quantity.ToString() + " " + pluralOrNotString + Environment.NewLine;
                }

                /**Refresh player information and inventory controls*/  /**Tue 07/30/2019 2:15:35.58*/
                lblCurrentHitPoints.Text = _player.CurrentHitPoints.ToString();
                lblGold.Text = _player.Gold.ToString();
                lblExperience.Text = _player.ExperiencePoints.ToString();
                lblLevel.Text = _player.Level.ToString();

                UpdateInventoryListInUI();
                UpdateWeaponListInUI();
                UpdatePotionListInUI();

                /**Add a blank line to the messages box, just for appearance*/
                rtbMessages.Text += Environment.NewLine;

                /**Move player to current location (to heal player and create a new monster to fight)*/
                MoveTo(_player.CurrentLocation);
            }
            else
            {
                /**Monster is still alive*/
                
                /**Determine the amount of damage the monster does to the player*/
                int damageToPlayer = RandomNumberGenerator.NumberBetween(0, _currentMonster.MaximumDamage);

                /**Display message*/
                rtbMessages.Text += "the " + _currentMonster.Name + " did " + damageToPlayer.ToString() +" points of damage." + Environment.NewLine;

                /**Subtract damage from player*/
                _player.CurrentHitPoints -= damageToPlayer;

                /**Refresh player data in UI*/
                lblCurrentHitPoints.Text = _player.CurrentHitPoints.ToString();

                if (_player.CurrentHitPoints <= 0)
                {
                    /**Display message*/
                    rtbMessages.Text += "the " + _currentMonster.Name + " killed you." + Environment.NewLine;

                    /**Move player to "Home"*/
                    MoveTo(World.LocationByID(World.LOCATION_ID_HOME));
                }
                

            }

            
        }

        private void BtnUsePotion_Click(object sender, EventArgs e)
        {
            /**Get the currently selected potion from the combobox*/
            HealingPotion potion = (HealingPotion)cboPotions.SelectedItem;

            /**Add healing amount to the player's current hit points*/
            _player.CurrentHitPoints = (_player.CurrentHitPoints + potion.AmountToHeal);

            /**CurrentHitPoints cannot exceed player's MaximumHitPoints*/
            if(_player.CurrentHitPoints > _player.MaximumHitPoints)
            {
                _player.CurrentHitPoints = _player.MaximumHitPoints;
            }

            /**Remove the potion from the player's inventory*/
            foreach (InventoryItem ii in _player.Inventory)
            {
                if (ii.Details.ID == potion.ID)
                {
                    ii.Quantity--;
                    break;
                }
            }

            /**Display message*/
            rtbMessages.Text += "You drink a " + potion.Name + Environment.NewLine;

            /**Monster gets their turn to attack*/

            /**Determine the amount of damage the monster does to the player*/
            int damageToPlayer = RandomNumberGenerator.NumberBetween(0, _currentMonster.MaximumDamage);

            /**Display message*/
            rtbMessages.Text += "The " + _currentMonster.Name + " did " + damageToPlayer.ToString() + " points of damage." + Environment.NewLine;

            /**Subtract damage from player*/
            _player.CurrentHitPoints -= damageToPlayer;

            if (_player.CurrentHitPoints <= 0)
            {
                /**Display message*/
                rtbMessages.Text += "The " + _currentMonster.Name + " killed you." + Environment.NewLine;

                /**Move player to "Home"*/
                MoveTo(World.LocationByID(World.LOCATION_ID_HOME));
            }

            /**Refresh player data in UI*/
            lblCurrentHitPoints.Text = _player.CurrentHitPoints.ToString();
            UpdateInventoryListInUI();
            UpdatePotionListInUI();
        }


        /*TEST AREA - This spans to the end of the document, thinkin keep it at the end. 3:13 PM 7/25/2019 */
        /*Started on 7/22/2019*/
        //5 sub regions, spanning 232 lines (comments, white space included) 
        /**This region is all related to the increase and decrease buttons i've created. 
         * The test is regarding changing the functionality of these buttons, depending 
         * on what stat is selected. When the labels referenced here are clicked, 
         * the increase and decrease buttons will then apply to the stat associated 
         * with that label, and will then increase and decrease accordingly when clicked.
         * 4:51 AM 7/24/2019*/
        #region RJM Button Testing Stuff
        /**v*/

        //2 methods, 1 line each
        /**The Increase and Decrease button click methods. 
         * (what I've been testing around with.)
         * 4:20 AM 7/24/2019 - RJM*/
        #region Increase / Decrease Buttons
        //INCREASE BUTTON
        private void BtnIncreaseValue_Click(object sender, EventArgs e) => DetermineChangeAndUpdateSelectedStat(INCREASE);
        
        //DECREASE BUTTON
        private void BtnDecreaseValue_Click(object sender, EventArgs e) => DetermineChangeAndUpdateSelectedStat(DECREASE);
        #endregion Increase / Decrease Buttons

///BOOKMARK 1 : Selected Stat if block

        //1 large method, 23 lines, 
        /**used only for increase and decrease buttons in form.*/
        #region Determine Change Update Selected Stat
        //INCR / DECR BUTTON FUNCTIONALITY
        private void DetermineChangeAndUpdateSelectedStat(int increaseOrDecrease)
        {
            int changeValue = increaseOrDecrease == INCREASE ? 1 : -1;
            string changeString = changeValue == 1 ? "INCREASE" : "DECREASE";
            const int MAX_LEVEL = 10; //maybe move somewhere else, later; 3:56 AM 7/24/2019 - RJM
                 if (_selectedStat == "CurrentHitPoints") { _player.CurrentHitPoints += changeValue; verifyHPBounds(1); UpdateHitPointsLabel(); }
            else if (_selectedStat == "MaximumHitPoints") { _player.MaximumHitPoints += changeValue; verifyHPBounds(2); UpdateHitPointsLabel(); }
            else if (_selectedStat == "HitPoints")        { _player.MaximumHitPoints += changeValue;
                                                            _player.CurrentHitPoints = _player.MaximumHitPoints;
                                                                                                     verifyHPBounds(2); UpdateHitPointsLabel(); }
            else if (_selectedStat == "Gold")             { _player.Gold             += changeValue; _player.Gold = Math.Max(0, _player.Gold); UpdateGoldLabel();             }
            else if (_selectedStat == "Experience")       { _player.ExperiencePoints += changeValue; _player.ExperiencePoints = Math.Max(0,_player.ExperiencePoints);  UpdateExperiencePointsLabel(); }
            else if (_selectedStat == "Level")            { _player.Level            += changeValue; _player.Level = Math.Max(1, Math.Min(MAX_LEVEL, _player.Level));  UpdateLevelLabel();            }
            else    { Console.WriteLine($"({changeString}) No Stat selected."); }
            
            void verifyHPBounds(int opt)
            {
                if ((opt==1)&&(_player.CurrentHitPoints > _player.MaximumHitPoints)) { _player.MaximumHitPoints = _player.CurrentHitPoints; }
                if ((opt==2)&&(_player.MaximumHitPoints < _player.CurrentHitPoints)) { _player.CurrentHitPoints = _player.MaximumHitPoints; }
                if (_player.CurrentHitPoints <= 0) { _player.CurrentHitPoints = 1; }
                if (_player.MaximumHitPoints <= 0) { _player.MaximumHitPoints = 1; }
            }
        }
        #endregion Determine Change Update Selected Stat

        //6 methods, 1 line each.
        /**All 6 are used in DetermineChangeAndUpdateSelectedStat method, just above,
         * here in region RJM Button Testing Stuff. 1:59 AM, 7/23/2019 ~RJM*/
        #region Update Stat Labels
        private void UpdateCurrentHitPointsLabel() => lblCurrentHitPoints.Text = _player.CurrentHitPoints.ToString();
        private void UpdateMaximumHitPointsLabel() => lblMaximumHitPoints.Text = _player.MaximumHitPoints.ToString();
        private void UpdateHitPointsLabel()         { UpdateCurrentHitPointsLabel(); UpdateMaximumHitPointsLabel(); }
        private void UpdateGoldLabel()             => lblGold.Text             = _player.Gold            .ToString();
        private void UpdateExperiencePointsLabel() => lblExperience.Text       = _player.ExperiencePoints.ToString();
        private void UpdateLevelLabel()            => lblLevel.Text            = _player.Level           .ToString();
        #endregion Update Stat Labels


        ///BOOKMARK 2 : Enters and Leaves.

        //12 methods, each with between 2 and 5 lines code each.
        /** Region has to do with indicating to the user that the banners (labels) displaying
         * Hitpoints, Gold, Experince, etc are clickable by the user.  Visually, color changes
         * when the mouse enters the label's area, and returns to original colors when mouse 
         * leaves.*/
        #region Mouse Enters and Leaves Methods

        //CURR WHITE ENTER 1:06 PM 7/28/20191:06 PM 7/28/2019
        private void Label5_Current_White_MouseEnter(object sender, EventArgs e)
        {
            label_Current_White.Visible = false;
            pictureBox_Current_Aqua_Test.Visible = true;
            pictureBox_Current_Aqua_Test.Location = label_Current_White.Location;
        }
        
        //MAX WHITE ENTER
        private void Label6_Max_White_MouseEnter(object sender, EventArgs e)
        {
            label_Max_White.Visible = false;
            pictureBox_Max_Aqua_Test.Visible = true;
            pictureBox_Max_Aqua_Test.Location = label_Max_White.Location;
        }
        
        //HITPOINTS WHITE ENTER
        private void Label1_Hitpoints_White_MouseEnter(object sender, EventArgs e)
        {
            label_Hitpoints_White.Visible = false;
            pictureBox_Hitpoints_Aqua_Test.Visible = true;
            pictureBox_Hitpoints_Aqua_Test.Location = label_Hitpoints_White.Location;
            Label5_Current_White_MouseEnter(null, null);
            Label6_Max_White_MouseEnter(null, null);
        }
        
        //CURR AQUA LEAVE
        private void PictureBox1_Current_Aqua_Test_MouseLeave(object sender, EventArgs e)
        {
            pictureBox_Current_Aqua_Test.Visible = false;
            label_Current_White.Visible = true;
        }


        //MAX AQUA LEAVE
        private void PictureBox2_Max_Aqua_Test_MouseLeave(object sender, EventArgs e)
        {
            pictureBox_Max_Aqua_Test.Visible = false;
            label_Max_White.Visible = true;
            
        }

        //HITPOINTS AQUA) LEAVE                                           4:39 PM 7/23/2019
        private void PictureBox3_Hitpoints_Aqua_Test_MouseLeave(object sender, EventArgs e)
        {
            label_Hitpoints_White.Visible = true;
            pictureBox_Hitpoints_Aqua_Test.Visible = false;
            PictureBox1_Current_Aqua_Test_MouseLeave(null, null);
            PictureBox2_Max_Aqua_Test_MouseLeave(null, null);       //test 4:52 PM 7/23/2019 - RJM
        }

        //GOLD GOLD ENTER
        private void Label2_Gold_Gold_MouseEnter(object sender, EventArgs e)
        {
            label_Gold_Gold.Visible = false;
            pictureBox_Gold_Light_Yellow_Border.Visible = true;
            pictureBox_Gold_Light_Yellow_Border.Location = label_Gold_Gold.Location;
        }

        //GOLD LIGHT YELLOW LEAVE
        private void PictureBox_Gold_Light_Yellow_Border_MouseLeave(object sender, EventArgs e)
        {
            label_Gold_Gold.Visible = true;
            pictureBox_Gold_Light_Yellow_Border.Visible = false;
        }

        //EXPERIENCE BLACK ON TEAL ENTER
        private void Label_ExperienceBlackOnTeal_MouseEnter(object sender, EventArgs e)
        {
            label_ExperienceBlackOnTeal.Visible = false;
            pictureBox_ExperienceWhiteOnBrightTeal.Visible = true;
            pictureBox_ExperienceWhiteOnBrightTeal.Location = label_ExperienceBlackOnTeal.Location;
        }

        //EXPERIENCE WHITE ON BRIGHT TEAL LEAVE
        private void PictureBox_ExperienceWhiteOnBrightTeal_MouseLeave(object sender, EventArgs e)
        {
            pictureBox_ExperienceWhiteOnBrightTeal.Visible = false;
            label_ExperienceBlackOnTeal.Visible = true;
        }

        //LEVEL LILAC ON INDIGO ENTER
        private void Label_LevelLilacOnIndigo_MouseEnter(object sender, EventArgs e)
        {
            label_LevelLilacOnIndigo.Visible = false;
            pictureBox_LevelRedOnPurple.Visible = true;
            pictureBox_LevelRedOnPurple.Location = label_LevelLilacOnIndigo.Location;
        }

        //LEVEL RED ON PURPLE LEAVE
        private void PictureBox_LevelRedOnPurple_MouseLeave(object sender, EventArgs e)
        {
            pictureBox_LevelRedOnPurple.Visible = false;
            label_LevelLilacOnIndigo.Visible = true;
        }

        #endregion Mouse Enters and Leaves Methods

        ///BOOKMARK 3 : Aqua Clicks. 4:43 PM 7/28/2019

        //7 Methods, <= 2 lines code each.
        /** Region has to do with the functionality of changing the selected stat,
         *  that the Increase and Decrease buttons will then affect when clicked.*/
        #region Aqua Clicks, Etc

        //CURR AQUA CLICK
        private void PictureBox1_Current_Aqua_Test_Click(object sender, EventArgs e)
        {
            _selectedStat = "CurrentHitPoints";
            OutputSelectedStatNotification();
        }

        //MAX AQUA CLICK
        private void PictureBox2_Max_Aqua_Test_Click(object sender, EventArgs e)
        {
            _selectedStat = "MaximumHitPoints"; ///P was uncapitalized, caused some probs. 5:19 PM 7/23/2019 - RJM
            OutputSelectedStatNotification();
        }

        //HITPOINTS AQUA CLICK
        private void PictureBox3_Hitpoints_Aqua_Test_Click(object sender, EventArgs e)
        {
            _selectedStat = "HitPoints"; /// should affect both _player.CurrentHitPoints AND _player.MaximumHitpoints;
            OutputSelectedStatNotification();
        }

        //GOLD LIGHT YELLOW CLICK
        private void PictureBox_Gold_Light_Yellow_Border_Click(object sender, EventArgs e)
        {
            _selectedStat = "Gold";
            OutputSelectedStatNotification();
        }

        //EXP WHITE ON BRIGHT TEAL CLICK
        private void PictureBox_ExperienceWhiteOnBrightTeal_Click(object sender, EventArgs e)
        {
            _selectedStat = "Experience";
            OutputSelectedStatNotification();
        }

        //LVL RED ON PURPLE CLICK
        private void PictureBox_LevelRedOnPurple_Click(object sender, EventArgs e)
        {
            _selectedStat = "Level";
            OutputSelectedStatNotification();
        }

        //Output Selected Stat Notification. 1:08 PM 7/28/2019
        /** Placeholder for an in-window notification I might do later. 4:05 AM 7/24/2019 - RJM
         * Used in the above Click functions*/
        private void OutputSelectedStatNotification() => Console.WriteLine($"Selected stat: {_selectedStat}");




        #endregion Aqua Clicks, Etc

        /**^*/
        #endregion RJM Button Testing Stuff

        private void BtnRJMRandomTest_Click(object sender, EventArgs e)
        {
            int numRandomValues = 500;
            int numNegatives = 0;
            int numMin = 0;
            int numMax = 0;
            int numBeyondMax = 0;

            int min = 0;
            int max = 5;

            rtbMessages.Text += $"\n+++++\nRandom Test::: of {numRandomValues} random values... \n\n";

            /**Tue 07/30/2019 4:16:38.90
             * Get and print a number of random values between 0 and 5.*/
            for (int ix = 1; ix < numRandomValues; ix++)
            {
                int value = RandomNumberGenerator.NumberBetween(min, max);
                bool testNeg = (value < 0), testMin = (value == 0), testMax = (value == max), testBMax = (value > max);
                bool testAll = testNeg || testMin || testMax || testBMax;
                bool testNegAndBMax = testNeg || testBMax;
                if (testNegAndBMax) rtbMessages.Text += $"Value {ix}: {value}\n";
                numNegatives = (testNeg) ? numNegatives + 1 : numNegatives;
                numMin = (testMin) ? numMin + 1 : numMin;
                numMax = (testMax) ? numMax + 1 : numMax;
                numBeyondMax = (testBMax) ? numBeyondMax + 1 : numBeyondMax;
            }
            /**display tracked number of negatives*/
            rtbMessages.Text += 
                $"Number of negatives: {numNegatives}\n" +
                $"Number of minimum: {numMin}\n" +
                $"Number of maximum: {numMax}\n" +
                $"Number of beyond maximum: {numBeyondMax}\n" +
                $"-----\n";

            /**Attempt to Set the caret position of rtbMessages to the end of the text.
             * Tue 07/30/2019 4:38:39.53*/
            //rtbMessages.SelectionStart = rtbMessages.TextLength;
            ///^will this work? Tue 07/30/2019 5:15:02.48
            /// no it won't...
            /// 
            //rtbMessages.Select(rtbMessages.Text.Length, 0);
            //rtbMessages.ScrollToCaret();
            /**Unnecessary after changing TextChanged event on rtbMessages control, through form SuperAdventure.cs[Design]
             * Tue 07/30/2019 7:02:34.63*/

        }

        private void RtbMessages_TextChanged(object sender, EventArgs e)
        {
            rtbMessages.SelectionStart = rtbMessages.TextLength;
            rtbMessages.ScrollToCaret();
        }
    }
}
