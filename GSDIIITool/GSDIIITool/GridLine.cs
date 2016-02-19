//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Drawing;
//using System.Windows.Forms;

//namespace GSDIIITool
//{
//    class GridLine
//    {
//        //Attributes

//        //Picture box
//        PictureBox gridLinePictureBox;

//        //ints for width and height
//        private int width;
//        private int height;

//        //ints for x and y location
//        private int xLocation;
//        private int yLocation;

//        //Color attributes

//        //Properties

//        /// <summary>
//        /// Property for width
//        /// </summary>
//        public int Width
//        {
//            get { return width; }
//            set { value = width; }
//        }

//        /// <summary>
//        /// Gets and sets height
//        /// </summary>
//        public int Height
//        {
//            get { return height; }
//            set { value = height; }
//        }

//        /// <summary>
//        /// gets and sets x location
//        /// </summary>
//        public int XLocation
//        {
//            get { return xLocation; }
//            set { value = xLocation; }
//        }

//        /// <summary>
//        /// gets and sets y location
//        /// </summary>
//        public int YLocation
//        {
//            get { return yLocation; }
//            set { value = yLocation; }
//        }

//        public GridLine(int width, int height, int x, int y, Color color)
//        {
//            gridLinePictureBox = new PictureBox();
//            gridLinePictureBox.Width = width;
//            gridLinePictureBox.Height = height;
//            gridLinePictureBox.Location = new Point(x, y);
//            gridLinePictureBox.BackColor = color;
//            gridLinePictureBox.Visible = true;
//        }

//    }
//}
