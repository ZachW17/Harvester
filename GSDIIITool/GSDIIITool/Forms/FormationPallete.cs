﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace GSDIIITool
{
    public partial class FormationPallete : Form
    {
        //Attributes
        #region
        //Attributes
        
        //Points
        private Point _pointColumn1;
        private Point _pointColumn2;

        private Point _pointRow1;
        private Point _pointRow2;

        //String type of the ship you chose
        private string _shipType;

        //button you clicked
        private Button _button;

        //Ship to represent what you are creating
        private Ship _newShip;

        //Boolean to toggle the visability of the referance ship
        private Boolean _toggleBoolean;

        //Turn on the mouse to click on the canvas, true the mouse is on, false mouse is off
        private Boolean _mouseMode;

        //A list of ships to keep track of, this will be used later in saving
        private List<Ship> _shipList;

        //A list of picture boxes to keep track of, this will be used in removing them
        private List<PictureBox> _pictureBoxList;

        private IOForm _IOForm;

        //private IOForm _IOForm;

        /// <summary>
        /// Property for the list. Only gets no sets because I don't want anything editing the list
        /// </summary>
        public List<Ship> ShipList { get { return _shipList; } }
        #endregion
        public FormationPallete()
        {
            //New IO form
            _IOForm = new IOForm();

            //Create a new picture box
            HeroShipPicture = new PictureBox();

            //Intilize the ship list
            _shipList = new List<Ship>();
            //Intilize the picuture box list
            _pictureBoxList = new List<PictureBox>();

            //Set initial values
            _newShip = null;
            _toggleBoolean = false;
            _mouseMode = false;
            _button = null;

            //Set up the Hero Ship
            HeroShipPicture.Location = new Point(640, 653);

            //Define points
            _pointColumn1 = new Point();
            _pointColumn2 = new Point();

            _pointRow1 = new Point();
            _pointRow2 = new Point();

            InitializeComponent();
        }

        #region Button Clicks
        private void regularEnemy_Click(object sender, EventArgs e)
        {
            //Set the button
            _button = enemy_fighter;
            //Set the name
            _shipType = enemy_fighter.Name;

            //Activate the mouse
            _mouseMode = true;
        }

        private void BomberBeetle_Click(object sender, EventArgs e)
        {
            //Set the button
            _button = bomber;

            //Set the name
            _shipType = bomber.Name;
            //Activate the mouse
            _mouseMode = true;
        }

        private void EnergyClaw_Click(object sender, EventArgs e)
        {
            //Set the button
            _button = energy_claw;

            //Set the name
            _shipType = energy_claw.Name;

            _mouseMode = true;
        }

        private void ImperialBoss_Click(object sender, EventArgs e)
        {
            //Set the button
            _button = imperial_boss;

            //Set the name
            _shipType = imperial_boss.Name;

            //Activate the mouse
            _mouseMode = true;
        }

        private void Kamikaze_Click(object sender, EventArgs e)
        {
            //Set the button
            _button = kamikaze;

            //Set the name
            _shipType = kamikaze.Name;

            //Activate the mouse
            _mouseMode = true;
        }

        #endregion
        /// <summary>
        /// Create an enemy
        /// </summary>
        /// <param name="shipType">the ship name to be passed in</param>
        /// <param name="buttonID"> the buttonID that we are using</param>
        public void AddEnemy(Button buttonID, string shipType)
        { 
            //Create a ship at the location where the mouse is and with the name passed in, -300 in the x and -10 in the y because the canvas is off set by that much
            _newShip = new Ship(MousePosition.X, MousePosition.Y, shipType);
            
            //Set up picturebox properties
            #region
            PictureBox enemy = new PictureBox();
            enemy.Size = new Size(100, 100);
            enemy.BorderStyle = BorderStyle.FixedSingle;
            
            Controls.Add(enemy);

            //Picture box settings
            enemy.Image = buttonID.Image;

            //Set the location
            //Subtract half the picturebox's width and subtract 27 from the Y to account for the top bar and also half the height to place it in the center
            //Exactly where your center mouse is
            enemy.Location = new Point((_newShip.X - enemy.Width / 2) , (_newShip.Y - 27 - (enemy.Height / 2)));

            //Add the enemy to the list of picture boxes
            _pictureBoxList.Add(enemy);
            #endregion

            
           _shipList.Add(_newShip);

            //Output for testing purposes you can use this to double check what is in the text boxes on the panel
            Console.WriteLine(_newShip.X.ToString() + " " + _newShip.Y.ToString());

        }

        /// <summary>
        /// Decides when to snap the mouse
        /// </summary>
        /// <returns>Returns true if you can snap the mouse, False if you can't snap it</returns>
        public Boolean SnapMouse()
        {
            return false;
        }

        ///<summary>
        ///Clicking the Hero's button
        ///</summary>
        #region
        //Toggle between showing the refrence hero image
        private void PhxMkII_Click(object sender, EventArgs e)
        {
            //If the button isn't on
            if (_toggleBoolean == false)
            {
                //Set the visiblity to false
                HeroShipPicture.Visible = false;

                //Turn the button on
                _toggleBoolean = true;

                //Exit
                return;
            }

            //If the button has been turned on
            if (_toggleBoolean == true)
            {
                //Set the visiblity equal to true
                HeroShipPicture.Visible = true;

                //Turn the button off
                _toggleBoolean = false;
            }
        }
        #endregion

        private void FormationPallete_Click(object sender, EventArgs e)
        {
            //If the mouse is within the bounds
            if (MousePosition.X < 1479 && MousePosition.X > 395 && MousePosition.Y < 633 && MousePosition.Y > 113)
            {
                if (_mouseMode == true)
                {
                    //Create an enemy
                    AddEnemy(_button, _shipType);

                    //Turn off the mouse
                    _mouseMode = false;
                }
            }
        }

        //Everytime the timer ticks
        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        /// <summary>
        /// Was partially created by someone from msdn http://msdn.microsoft.com/en-us/library/ztxk24yx(v=vs.80).aspx
        /// </summary>
        private void FormationPallete_Paint(object sender, PaintEventArgs e)
        {
            //Create a rectangle
            Rectangle background = new Rectangle(300, 10, 1200, 700);

            //Create a graphics object
            System.Drawing.Graphics graphics;
            graphics = CreateGraphics();

            //Draw the filled in rectangle
            graphics.FillRectangle(new System.Drawing.SolidBrush(Color.White), background);

            //Draw the boarder
            //Create graphics for this control
            graphics.DrawRectangle(new Pen(Color.Black, 2), background);

            //Draw the grid columns
            for (int i = 0; i < 1200; i = i + 100)
            {
                //Set the new X
                _pointColumn1.X = i + 300;
                _pointColumn2.X = i + 300;

                //Set Y
                _pointColumn1.Y = 10;
                _pointColumn2.Y = 710;
                //Draw line with pen x + the off set and at 0 to x + offset plust height of the rectangle. Hard coded for now
                graphics.DrawLine(new Pen(Color.DarkGray, 2), _pointColumn1, _pointColumn2);
            }

            //Draw the rows
            for (int i = 0; i < 700; i += 100)
            {
                //Set the x first, they are constant
                _pointRow1.X = 300;
                _pointRow2.X = 1500;

                //Set the y, it changes
                _pointRow1.Y = i + 10;
                _pointRow2.Y = i + 10;

                //X always starts off at the offset, Y increases
                graphics.DrawLine(new Pen(Color.DarkGray, 2), _pointRow1, _pointRow2);
            }
            graphics.Dispose();
        }

        //When you click on save button
        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                //make a new File Stream, using means dispose of it after this is done
                using (FileStream stream = new FileStream(_IOForm.FilePath.Text + "\\" + _IOForm.FileName.Text + ".frm", FileMode.Create))
                {
                    //Make a new binaryWriter, using means dispose of it after this is done
                    using (BinaryWriter writer = new BinaryWriter(stream))
                    {
                        //Write the total ship count. This is used to read in the correct number of lines later when the file is read in
                        writer.Write(_shipList.Count);

                        //For the length of the list
                        for (int i = 0; i < _shipList.Count; i++)
                        {
                            //Write x position
                            writer.Write(_shipList[i].X);
                            //Write y position
                            writer.Write(_shipList[i].Y);
                            //Write name
                            writer.Write(_shipList[i].Name);
                        }
                    }
                }
                //Show that it was a success
                MessageBox.Show("Success!");
            }


            catch (FileNotFoundException fE)
            {
                MessageBox.Show("The message can't be opened " + fE.Message);
            }

            catch (Exception ex)
            {
                MessageBox.Show("The message can't be opened " + ex.Message);
            }
        }

        //When you click on open
        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            
            //Make each box invisible
            foreach (PictureBox p in _pictureBoxList)
            {
                p.Visible = false;
            }
            //Reset the whole canvas
            //Clear the lists
            _shipList.Clear();
            _pictureBoxList.Clear();

            Stream inStream = null;
            BinaryReader reader = null;
            try
            {
                //make a new File Stream, using means dispose of it after this is done

                inStream = File.OpenRead(_IOForm.FilePath.Text + "\\" + _IOForm.FileName.Text + ".frm");

                //Make a new binaryReader, using means dispose of it after this is done
                reader = new BinaryReader(inStream);

                //read in the number of ships in the ship list. It isn't nesasary to the rest of the process
                //but if you don't everything will get out of place
                int temp = reader.ReadInt32();
                
                while (reader.BaseStream.Position != reader.BaseStream.Length)
                {
                    //Read x
                    int x = reader.ReadInt32();
                    //Read y
                    int y = reader.ReadInt32();
                    //Read the name
                    string name = reader.ReadString();

                    //Using that info add a new ship to the list
                    _shipList.Add(new Ship(x, y, name));
                }

                //For every ship in the list
                for (int i = 0; i < _shipList.Count; i++)
                {
                    //var list = GSDIIITool.Properties.Resources.ResourceManager.GetResourceSet(new System.Globalization.CultureInfo("en-us"),true,true);

                    //Make a new enemy PictureBox
                    PictureBox enemy = new PictureBox();

                    //Set the size
                    enemy.Size = new Size(100, 100);

                    //Set the border
                    enemy.BorderStyle = BorderStyle.FixedSingle;

                    //Add the control
                    Controls.Add(enemy);

                    //Big Switch around names
                    #region
                    switch (_shipList[i].Name)
                    {
                        case ("enemy_fighter"):
                            enemy.Image = GSDIIITool.Properties.Resources.Ship___Enemy_Fighter_v1;
                            //Set the location
                            //Subtract half the picturebox's width and subtract 27 from the Y to account for the top bar and also half the height to place it in the center
                            //Exactly where the imported ship is
                            enemy.Location = new Point(_shipList[i].X - enemy.Width / 2, _shipList[i].Y - 27 - (enemy.Height / 2));
                            //Show the box
                            enemy.Show();
                            break;
                        case ("bomber"):
                            enemy.Image = GSDIIITool.Properties.Resources.Ship___Bomber_Beetle_v2;
                            //Set the location
                            //Subtract half the picturebox's width and subtract 27 from the Y to account for the top bar and also half the height to place it in the center
                            //Exactly where the imported ship is
                            enemy.Location = new Point(_shipList[i].X - enemy.Width / 2, _shipList[i].Y - 27 - (enemy.Height / 2));
                            //Show the box
                            enemy.Show();
                            break;
                        case ("energy_claw"):
                            enemy.Image = GSDIIITool.Properties.Resources.Ship___Energy_Claw_v1;
                            //Set the location
                            //Subtract half the picturebox's width and subtract 27 from the Y to account for the top bar and also half the height to place it in the center
                            //Exactly where the imported ship is
                            enemy.Location = new Point(_shipList[i].X - enemy.Width / 2, _shipList[i].Y - 27 - (enemy.Height / 2));
                            //Show the box
                            enemy.Show();
                            break;
                        case ("imperial_boss"):
                            enemy.Image = GSDIIITool.Properties.Resources.Ship___Imperial_v2__Boss_;
                            //Set the location
                            //Subtract half the picturebox's width and subtract 27 from the Y to account for the top bar and also half the height to place it in the center
                            //Exactly where the imported ship is
                            enemy.Location = new Point(_shipList[i].X - enemy.Width / 2, _shipList[i].Y - 27 - (enemy.Height / 2));
                            //Show the box
                            enemy.Show();
                            break;
                        case ("kamikaze"):
                            enemy.Image = GSDIIITool.Properties.Resources.Ship___Kamikaze_v1;
                            //Set the location
                            //Subtract half the picturebox's width and subtract 27 from the Y to account for the top bar and also half the height to place it in the center
                            //Exactly where the imported ship is
                            enemy.Location = new Point(_shipList[i].X - enemy.Width / 2, _shipList[i].Y - 27 - (enemy.Height / 2));
                            //Show the box
                            enemy.Show();
                            break;
                    }
                    #endregion

                    //For testing purposes you can use output to double check what is in the text boxes on the panel
                    //Console.WriteLine(_newShip.X.ToString() + " " + _newShip.Y.ToString());
                    //Add the enemy to the list of picture boxes
                    _pictureBoxList.Add(enemy);
                }
                //Show that it was a success
                MessageBox.Show("Success!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (reader != null)
                    reader.Close();
                else if (inStream != null)
                    inStream.Close();
            }
        }

        //When you click on start
        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            //Make each box invisible
            foreach (PictureBox p in _pictureBoxList)
            {
                p.Visible = false;
            }
            //Clear the lists
            _shipList.Clear();
            _pictureBoxList.Clear();
        }

        private void helpToolStripButton_Click(object sender, EventArgs e)
        {
            HelpForm helpForm = new HelpForm();
            helpForm.Show();
        }

        private void printToolStripButton_Click(object sender, EventArgs e)
        {
            //make a new stream writer
            StreamWriter output = null;

            try
            {
                //Create the stream writer
                output = new StreamWriter(_IOForm.FilePath.Text + "\\" + _IOForm.FileName.Text + ".txt");

                //Write some info
                output.WriteLine("Start");

                //Write the ship list number
                output.WriteLine("Number of ships: " + _shipList.Count.ToString());
                
                for (int i = 0; i < _shipList.Count; i++)
                {
                    //Write spacing
                    output.WriteLine();
                    //Write name, I know it is first when all the other times it was last but this is for readability
                    output.WriteLine("Name: " + _shipList[i].Name);
                    //Write X
                    output.WriteLine("X Position: " + _shipList[i].X);
                    //Write Y
                    output.WriteLine("Y Position: " + _shipList[i].Y);
                }
                //Write spacing
                output.WriteLine();
                //Write some other info
                output.WriteLine("End");

                //Show that it was a success
                MessageBox.Show("Success!");
            }

            catch (Exception ex)
            {
                Console.WriteLine("Error writing file: " + ex.Message);
            }
            finally
            {
                if (output != null)
                {
                    output.Close();
                }
            }
        }

        private void FormationPallete_Load(object sender, EventArgs e)
        {
            _IOForm.Show();
        }
    }
}
