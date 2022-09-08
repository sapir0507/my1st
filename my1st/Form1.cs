using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using System.IO;
using System.Runtime.Serialization;//!!!!!!
using System.Runtime.Serialization.Formatters.Binary;

using FIGURES; //!3b-//!3e

namespace my1st
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            /*
             * creates the initialized components and paints them on the Form in the locations specified.
             */
            InitializeComponent();
        }

        /*
            creates an empty list of rectangles and circles
            sets the index to -1 which means nothing was created yet
            sets the type to be added next to the list to 0 (circle)
         */
        FigureList pts = new FigureList();
        int curIndex=-1;
        int radius = 6;
        int futureKind = 0; //!4b-//!4e

        //!5b
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            /*
                there are two possible options for a mouse down event, one is creating a new object
                be it retangle or circle, and the second is updating the location of a previously created
                object.
                we initialize our currIndex to the start (-1) and make sure that the point's coordinates 
                doesn't exist.
                If they do, we need to update them, or remove them, depanding on wheter it's left click or right click. 
             */
            curIndex=-1;
            for (int i = 0; i < pts.NextIndex; i++ )
            {                           
                if (pts[i].isInside(e.X,e.Y))
                {
                    curIndex = i;
                    string s = e.Button.ToString(); //right click or left click
                    if (s == "Right") //if Right button pressed - Remove
                    {
                        pts.Remove(curIndex);
                        curIndex = -1;
                        pictureBox1.Invalidate();
                        return;
                    }
                    break;
                }
            }
            /*
             * if it's a new object, the curIndex will still be -1
             * if we removed an object, the curIndex will still be -1
             * in both cases, we want to repaint the object array.
             * pts.NextIndex is the index of the next object to add.
             * Now we need to make sure that the object in pts[pts.NextIndex] is a circle or a rectangle.
             * We determine it with futureKind.
             */
            if (curIndex < 0)
            {
                switch (futureKind)
                {
                    case 0:
                       pts[pts.NextIndex] = new myCircle(e.X, e.Y, 5);
                        break;
                    case 1:
                        pts[pts.NextIndex] = new myRectangle(e.X, e.Y, 20,10);
                        break;
                }
                curIndex = pts.NextIndex - 1;
                pictureBox1.Invalidate();
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            /*
                as long as curIndex isn't -1 we creat a new Figure object in the next to add position.
             */
            if (curIndex>=0)
            {
                Figure c = (Figure)pts[curIndex];
                c.X=e.X;
                c.Y=e.Y;
                pictureBox1.Invalidate();
            }

        }
        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            curIndex = -1;
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            pts.DrawAll(g);
            
        }
        //!5e

        //!6b
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            futureKind = 1;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            futureKind = 0;
        }
        //!6e

        //!8b
        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();// + "..\\myModels";
            saveFileDialog1.Filter = "model files (*.mdl)|*.mdl|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                IFormatter formatter = new BinaryFormatter();
                using (Stream stream = new FileStream(saveFileDialog1.FileName, FileMode.Create, FileAccess.Write, FileShare.None))
                {
                    //!!!!
                    formatter.Serialize(stream, pts);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();// + "..\\myModels";
            openFileDialog1.Filter = "model files (*.mdl)|*.mdl|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Stream stream = File.Open(openFileDialog1.FileName, FileMode.Open);
                var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                //!!!!
                pts=(FigureList)binaryFormatter.Deserialize(stream);
                pictureBox1.Invalidate();
            }
        }
        //!8e
    }
}