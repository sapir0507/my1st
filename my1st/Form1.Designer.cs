namespace my1st
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            /*
                creating the components that will be shown on our app screen.
                2 radio buttons
                2 regular buttons
                1 picture box
                
                next, we use casting to tell the picture box that
                he's supposed to be class System.ComponentModel.ISuppoirtInitionalize 
                to use the premade BeginItit() that initialize the picture box.
             */
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            /*
                next we give the picture box the styles we want it to have, such as the background color
                the border style, where we want it to be painted on the screen ect...
                Do note that we use System's premade classes and functions to do all that. We don't need to make our
                own.
             */
            this.pictureBox1.BackColor = System.Drawing.Color.Teal;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(330, 249);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            /*
                Event handlers are services that operate in the background, and wait for an event to happen.
                when it does, the event handler will inject his own code which will handle the event before
                the rest of the program continues.
                In this case, there are 4 event handlers:
                    paint, mouse down, mouse move and mouse up. when any of those happens, we want to change the
                    current form to refelect the changes those things represent. 
                    For example, we want to see the mouse move on the screen when we move it on the desk in the real
                    world.
             */
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(371, 17);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(51, 17);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Circle";
            this.radioButton1.UseVisualStyleBackColor = true;
            /*
                this event handler will fire when the state of the radio button changes. False to True, True to False.
             */
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(371, 40);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(74, 17);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.Text = "Rectangle";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(370, 112);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 34);
            this.button1.TabIndex = 3;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            /*
             as opposed to the radio button before, this event handler will fire up any time the button is clicked.
             */
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(372, 152);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 30);
            this.button2.TabIndex = 4;
            this.button2.Text = "Load";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            /*
                and now we come to the Form itself, which should also be initialized. 
                Next, we will add all the components we created beforehand to the Form,
                This means that they now will appear inside the Form.
                Finally, we will tell the picturebox that we finished initializing it, using the premade function of
                class System.ComponentModel.ISupportInitialize.
                the last two lines will take all that we created before and force the window to render it now.

                The SuspendLayout and ResumeLayout methods are used in tandem to suppress multiple Layout events 
                while you adjust multiple attributes of the control. For example, you would typically call the 
                SuspendLayout method, then set the Size, Location, Anchor, or Dock properties of the control, 
                and then call the ResumeLayout method to enable the changes to take effect.

                There must be no pending calls to SuspendLayout for ResumeLayout to be successfully called.
             */
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 280);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

