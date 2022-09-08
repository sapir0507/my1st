using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace my1st
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            /*
                Enables visual styles for the application.
                Visual styles are the colors, fonts, and other visual elements that form an operating system theme. 
                Controls will draw with visual styles if the control and the operating system support it. 
                To have an effect, EnableVisualStyles() must be called before creating any controls in the application; 
                typically, EnableVisualStyles() is the first line in the Main function. 
                A separate manifest is not required to enable visual styles when calling EnableVisualStyles().
             */
            Application.SetCompatibleTextRenderingDefault(false);
            /*
                Application.SetCompatibleTextRenderingDefault(false);
                You can only call this method before the first window is created by your Windows Forms application.

                The default value to use for new controls. 
                If true, new controls that support UseCompatibleTextRendering use the GDI+ 
                based Graphics class for text rendering; 
                if false, new controls use the GDI based TextRenderer class.
             */
            Application.Run(new Form1());
            /*
                runs Form1 
             */
        }
    }
}