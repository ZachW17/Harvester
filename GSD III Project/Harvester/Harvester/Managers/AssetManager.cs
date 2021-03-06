﻿/*
 * public class MediaManager
 * @author Theodore Greene
 * 
 * Notes: This is what is known as a Singleton. A Singleton is a little weird, it is a static class with public methods and can only be made once.
 *        This helps reduce the number of global variables while providing functionality.
 *        See also:http://msdn.microsoft.com/en-us/library/ff650316.aspx and http://www.dotnetperls.com/singleton-static
 *        To call any method or get/ set any property say AssetManager.Instance.*Something*
 *        This isn't a replacement for static classes, this is only for when you one want ONE instance.
 * 
 * Version: $1.0.0$
 * 
 * Revisions: 1.0.1(Theodore Greene)
 *          -Created the class and its basic contents
 *            1.2(Theodore Greene)
 *            -Finished working methods FindFiles,FindTextures,FindSpriteFonts
 *            1.2.3(Theodore Greene)
 *            -Added LoadFromSource to read in tool files, its not quite done because it can't read anything but formation but that's all thats done for nowww
 * 
 */
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using System.Collections;

namespace Harvester
{
    //Attributes
    public enum LoadType
    {
        EnemySetting,
        Formation,
        GameSettings,
        PlayerSetting,
        Highscore
    }
    
    public class AssetManager : Game
    {
        //Attributes

        //Arrays
        #region

        //Array of strings to be used through out the various content loading
        private String[] _loadArray;

        //Array of strings to be used to retrive texture values from the dictionary
        private String[] _textureArray;

        //Array of strigns to be used to retrive spritefont values from the dictionary
        private String[] _spritefontArray;

        //Array of strings to be used to retrive spritefont values from the dictionary
        private String[] _audioArray;

        //Variable for the enum
        private static LoadType _theLoadType;

        /// <summary>
        /// Property for the load type
        /// </summary>
        public static LoadType TheLoadType { get { return _theLoadType; } set { _theLoadType = value; } }

        #endregion

        ///<summary>
        ///Set up the Singleton
        ///</summary>
        #region
        //Here is how this works

        //First make a static variable of type Asset Manager
        private static AssetManager _instance;

        //Then make a property so you can access it
        public static AssetManager Instance
        {
            get
            {
                //if it hasn't been initilized
                if (_instance == null)
                {
                    //Make a new one
                    _instance = new AssetManager();
                }

                //Otherwise return the inStance of
                return _instance;
            }
        }

        #endregion
        /// <summary>
        /// Private contructor ensures nothing can make a new Asset Manager
        /// </summary>
        private AssetManager()
        {
            //Initialize the arrays
            //64 is the highest that I think we will ever have of any one element(64 images, 64 sounds, 64 etc) but it can be changed
            _loadArray = new String[64];
            _textureArray = new String[64];
            //I think we probably will never have no more than 8 sprite fonts
            _spritefontArray = new String[8];
            
            _audioArray = new String[64];
        }

        /// <summary>
        /// Goes to the content directory and gets all the files of a certain type
        /// </summary>
        /// <param name="fileExtension">file extension you want to find include the .</param>
        /// <returns>array of strings for use as keys</returns>
        public string[] FindFiles(string fileExtension)
        {
            //Get the current directory and store it as a string
            String currentDirectory = Directory.GetCurrentDirectory();

            //Create a directory info for use
            DirectoryInfo dInfo = new DirectoryInfo(currentDirectory);

            try
            {
                //While there is some directory info
                while (dInfo != null)
                {

                    //Move up
                    dInfo = dInfo.Parent.Parent;

                    //If the current file path is Harvester (The first one
                    if (dInfo.Name == "Harvester")
                    {

                        //It should be at ...\GSD III Project\Harvester
                        //Move into art
                        currentDirectory = dInfo.FullName + "\\HarvesterContent";
                        //Break out of the loop
                        break;
                    }

                }

                //Get all the files in the current directory of the certain file type and put them in a string 
                _loadArray = Directory.GetFiles(currentDirectory, "*" + fileExtension, SearchOption.AllDirectories);

                //Loop through to save only the closet path and no file extension
                for (int i = 0; i < _loadArray.Length; i++)
                {
                    //Remove the large unimportant path infront
                    _loadArray[i] = _loadArray[i].Remove(0, currentDirectory.Count());
                    //Remove the file extenstion

                    //If the extension is png
                    if (fileExtension == ".png")
                    {
                        //take off the last 4 charecters(. + png)
                        _loadArray[i] = _loadArray[i].Remove(_loadArray[i].Count() - 4);
                    }

                    //If it is spritefont
                    if (fileExtension == ".spritefont")
                    {
                        //take off the last 11 charecters . + spritefont
                        _loadArray[i] = _loadArray[i].Remove(_loadArray[i].Count() - 11);
                    }
                    if (fileExtension == ".wav")
                    {
                        //take off the last 4 charecters(. + wav)
                        _loadArray[i] = _loadArray[i].Remove(_loadArray[i].Count() - 4);
                    }
                }

                //If the program is reading in textures
                if (fileExtension == ".png")
                {
                    //Copy it to the array of strings representing textures so that way it wont change when we load something else
                    _loadArray.CopyTo(_textureArray, 0);
                }
                //If the program is reading in spritefonts
                if (fileExtension == ".spritefont")
                {
                    //Copy it to the array of strings representing spritefonts so that way it wont change when we load something else
                    _loadArray.CopyTo(_spritefontArray, 0);
                }
                //If the program is reading in audio wavs
                if (fileExtension == ".wav")
                {
                    _loadArray.CopyTo(_audioArray, 0);
                }
                return _loadArray;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        /// <summary>
        /// this gets the texture based off the asset name only by adding in the pesky \Folder_Name\ for convienace
        /// </summary>
        /// <param name="assetName">the asset name you want to load</param>
        /// <returns></returns>
        public Texture2D FindTexture(string assetName)
        {
            //First find what the passed in name is inside the array of strings
            for (int i = 0; i < _textureArray.Length; i++)
            {
                if (_textureArray[i].Contains(assetName))
                {
                    //now the key equals the value, a unified system
                    return Engine.TextureDic[_textureArray[i]];
                }
            }
            return null;
        }

        /// <summary>
        /// this gets the spritefont based off the asset name only by adding in the pesky \Folder_Name\ for convienace
        /// </summary>
        /// <param name="assetName">the asset name you want to load</param>
        /// <returns></returns>
        public SpriteFont FindSpriteFont(string assetName)
        {
            //First find what the passed in name is inside the array of strings
            for (int i = 0; i < _spritefontArray.Length; i++)
            {
                if (_spritefontArray[i].Contains(assetName))
                {
                    //now the key equals the value, a unified system
                    return Engine.SpriteFontDic[_spritefontArray[i]];
                }
            }
            return null;
        }
        /// <summary>
        /// this gets the audio file based off the asset name only by adding in the pesky \Folder_Name\ for convienace
        /// </summary>
        /// <param name="assetName">the asset name you want to load</param>
        /// <returns></returns>
        public SoundEffect FindSound(string assetName)
        {
            //First find what the passed in name is inside the array of strings
            for (int i = 0; i < _audioArray.Length; i++)
            {
                if (_audioArray[i].Contains(assetName))
                {
                    //now the key equals the value, a unified system
                    return Engine.AudioDic[_audioArray[i]];
                }
            }
            return null;
        }
        /// <summary>
        /// Return the current directory 
        /// </summary>
        /// <returns>arrayList of items to be used</returns>
        /// <param name="fileName">fileName to read</param>
        /// <param name="loadType">a load type to switch around, possible values are EnemySettings,Formation,GameSettings, and PlayerSetting</param>
        public ArrayList LoadFromSource(string fileName, LoadType loadType)
        {
            ArrayList arrayList = new ArrayList();

            //Move through the directories
            #region
            //Get where you currently are, the bottem
            string currentDirectory = Directory.GetCurrentDirectory();

            //Create directory info for use
            DirectoryInfo directoryInfo = new DirectoryInfo(currentDirectory);

            //Move up three directories
            for (int i = 0; i < 3; i++)
            {
                //get the parent of the current directory
                directoryInfo = Directory.GetParent(currentDirectory);

                //set the current directory to the parent (inside of the full path so you can keep moving up
                currentDirectory = directoryInfo.FullName;
            }

            //Go down one level into Mods
            currentDirectory = currentDirectory + "\\Mods";
            #endregion

            #region
            //Load it 

            //Create a general stream
            Stream inStream = null;
            BinaryReader input = null;

            //Extension to be added in
            string fileExtension = " ";

            //Switch on the directories name
            switch (loadType)
            {
                case LoadType.EnemySetting:
                    currentDirectory = currentDirectory + "\\EnemySettings";
                    fileExtension = ".est";
                    break;

                case LoadType.Formation:
                    currentDirectory = currentDirectory + "\\Formations";
                    fileExtension = ".frm";
                    break;

                case LoadType.GameSettings:
                    currentDirectory = currentDirectory + "\\Game Settings";
                    fileExtension = ".gst";
                    break;

                case LoadType.PlayerSetting:
                    currentDirectory = currentDirectory + "\\Player Settings";
                    fileExtension = ".pst";
                    break;
            }

            // Try to make and read data
            try
            {
                inStream = File.OpenRead(currentDirectory + "\\" + fileName + fileExtension);
                input = new BinaryReader(inStream);

                //Read in the number of ships to be used as the for loop condition
                int listCount= input.ReadInt32();


                for (int i = 0; i < listCount; i++)
                {
                    // Read some data
                    int x = input.ReadInt32();
                    int y = input.ReadInt32();
                    String shipType = input.ReadString();

                    //Add the items to the arrayList
                    arrayList.Add(x);
                    arrayList.Add(y);
                    arrayList.Add(shipType);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error reading" + fileName + ": " + e.Message);
            }
            finally
            {
                if (input != null)
                    input.Close();
                else if (inStream != null)
                    inStream.Close();
            }

            return arrayList;

            #endregion
        }
    }
}
