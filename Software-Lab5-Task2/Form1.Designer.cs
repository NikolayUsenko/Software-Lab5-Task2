namespace Software_Lab5_Task2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            MainStatusStrip = new StatusStrip();
            toolStripStatusLabelState = new ToolStripStatusLabel();
            toolStripStatusLabelClock = new ToolStripStatusLabel();
            ToolStripDropDownButtonDateTime = new ToolStripDropDownButton();
            toolStripMenuItemDate = new ToolStripMenuItem();
            toolStripMenuItemTime = new ToolStripMenuItem();
            timerDateTimeUpdate = new System.Windows.Forms.Timer(components);
            MainStatusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // MainStatusStrip
            // 
            MainStatusStrip.ImageScalingSize = new Size(20, 20);
            MainStatusStrip.Items.AddRange(new ToolStripItem[] { toolStripStatusLabelState, toolStripStatusLabelClock, ToolStripDropDownButtonDateTime });
            MainStatusStrip.Location = new Point(0, 424);
            MainStatusStrip.Name = "MainStatusStrip";
            MainStatusStrip.Size = new Size(800, 26);
            MainStatusStrip.TabIndex = 0;
            MainStatusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabelState
            // 
            toolStripStatusLabelState.Name = "toolStripStatusLabelState";
            toolStripStatusLabelState.Size = new Size(747, 20);
            toolStripStatusLabelState.Spring = true;
            toolStripStatusLabelState.TextAlign = ContentAlignment.TopLeft;
            // 
            // toolStripStatusLabelClock
            // 
            toolStripStatusLabelClock.BorderSides = ToolStripStatusLabelBorderSides.Left | ToolStripStatusLabelBorderSides.Top | ToolStripStatusLabelBorderSides.Right | ToolStripStatusLabelBorderSides.Bottom;
            toolStripStatusLabelClock.Name = "toolStripStatusLabelClock";
            toolStripStatusLabelClock.Size = new Size(4, 20);
            // 
            // ToolStripDropDownButtonDateTime
            // 
            ToolStripDropDownButtonDateTime.DisplayStyle = ToolStripItemDisplayStyle.Image;
            ToolStripDropDownButtonDateTime.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItemDate, toolStripMenuItemTime });
            ToolStripDropDownButtonDateTime.Image = (Image)resources.GetObject("ToolStripDropDownButtonDateTime.Image");
            ToolStripDropDownButtonDateTime.ImageTransparentColor = Color.Magenta;
            ToolStripDropDownButtonDateTime.Name = "ToolStripDropDownButtonDateTime";
            ToolStripDropDownButtonDateTime.Size = new Size(34, 24);
            ToolStripDropDownButtonDateTime.Text = "toolStripDropDownButton1";
            // 
            // toolStripMenuItemDate
            // 
            toolStripMenuItemDate.Name = "toolStripMenuItemDate";
            toolStripMenuItemDate.Size = new Size(224, 26);
            toolStripMenuItemDate.Text = "Текущая дата";
            toolStripMenuItemDate.Click += toolStripMenuItemDate_Click;
            // 
            // toolStripMenuItemTime
            // 
            toolStripMenuItemTime.Name = "toolStripMenuItemTime";
            toolStripMenuItemTime.Size = new Size(224, 26);
            toolStripMenuItemTime.Text = "Текущее время";
            toolStripMenuItemTime.Click += toolStripMenuItemTime_Click;
            // 
            // timerDateTimeUpdate
            // 
            timerDateTimeUpdate.Enabled = true;
            timerDateTimeUpdate.Interval = 1000;
            timerDateTimeUpdate.Tick += timerDateTimeUpdate_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(MainStatusStrip);
            Name = "Form1";
            Text = "Form1";
            MouseMove += Form1_MouseMove;
            MainStatusStrip.ResumeLayout(false);
            MainStatusStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private StatusStrip MainStatusStrip;
        private ToolStripStatusLabel toolStripStatusLabelState;
        private ToolStripStatusLabel toolStripStatusLabelClock;
        private ToolStripDropDownButton ToolStripDropDownButtonDateTime;
        private ToolStripMenuItem toolStripMenuItemDate;
        private ToolStripMenuItem toolStripMenuItemTime;
        private System.Windows.Forms.Timer timerDateTimeUpdate;
    }
}
