
namespace OOP_lab12
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.DrawPanel = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonHighlight = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.LightPurple = new System.Windows.Forms.Panel();
            this.Purple = new System.Windows.Forms.Panel();
            this.Teal = new System.Windows.Forms.Panel();
            this.Blue = new System.Windows.Forms.Panel();
            this.SkyBlue = new System.Windows.Forms.Panel();
            this.Lime = new System.Windows.Forms.Panel();
            this.Green = new System.Windows.Forms.Panel();
            this.Yellow = new System.Windows.Forms.Panel();
            this.Orange = new System.Windows.Forms.Panel();
            this.Red = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panelColor = new System.Windows.Forms.Panel();
            this.Color = new System.Windows.Forms.Label();
            this.White = new System.Windows.Forms.Panel();
            this.Brown = new System.Windows.Forms.Panel();
            this.Gray = new System.Windows.Forms.Panel();
            this.Black = new System.Windows.Forms.Panel();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DrawPanel
            // 
            this.DrawPanel.BackColor = System.Drawing.Color.White;
            this.DrawPanel.Location = new System.Drawing.Point(12, 109);
            this.DrawPanel.Name = "DrawPanel";
            this.DrawPanel.Size = new System.Drawing.Size(1236, 474);
            this.DrawPanel.TabIndex = 0;
            this.DrawPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawPanel_Paint);
            this.DrawPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DrawPanel_MouseDown);
            this.DrawPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DrawPanel_MouseMove);
            this.DrawPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DrawPanel_MouseUp);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.buttonHighlight);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.LightPurple);
            this.groupBox1.Controls.Add(this.Purple);
            this.groupBox1.Controls.Add(this.Teal);
            this.groupBox1.Controls.Add(this.Blue);
            this.groupBox1.Controls.Add(this.SkyBlue);
            this.groupBox1.Controls.Add(this.Lime);
            this.groupBox1.Controls.Add(this.Green);
            this.groupBox1.Controls.Add(this.Yellow);
            this.groupBox1.Controls.Add(this.Orange);
            this.groupBox1.Controls.Add(this.Red);
            this.groupBox1.Controls.Add(this.panel4);
            this.groupBox1.Controls.Add(this.White);
            this.groupBox1.Controls.Add(this.Brown);
            this.groupBox1.Controls.Add(this.Gray);
            this.groupBox1.Controls.Add(this.Black);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1236, 62);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(6, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(804, 41);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            // 
            // buttonHighlight
            // 
            this.buttonHighlight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonHighlight.Image = global::OOP_lab12.Properties.Resources.software_selection_rectangle_97727;
            this.buttonHighlight.Location = new System.Drawing.Point(1098, 7);
            this.buttonHighlight.Name = "buttonHighlight";
            this.buttonHighlight.Size = new System.Drawing.Size(75, 55);
            this.buttonHighlight.TabIndex = 20;
            this.buttonHighlight.TabStop = false;
            this.buttonHighlight.UseVisualStyleBackColor = true;
            this.buttonHighlight.Click += new System.EventHandler(this.buttonMark_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(1179, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(51, 26);
            this.button1.TabIndex = 19;
            this.button1.TabStop = false;
            this.button1.Text = "Erase";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LightPurple
            // 
            this.LightPurple.BackColor = System.Drawing.Color.Violet;
            this.LightPurple.Location = new System.Drawing.Point(1069, 36);
            this.LightPurple.Name = "LightPurple";
            this.LightPurple.Size = new System.Drawing.Size(20, 15);
            this.LightPurple.TabIndex = 17;
            this.LightPurple.Click += new System.EventHandler(this.LightPurple_Click);
            // 
            // Purple
            // 
            this.Purple.BackColor = System.Drawing.Color.Purple;
            this.Purple.Location = new System.Drawing.Point(1069, 15);
            this.Purple.Name = "Purple";
            this.Purple.Size = new System.Drawing.Size(20, 15);
            this.Purple.TabIndex = 16;
            this.Purple.Click += new System.EventHandler(this.Purple_Click);
            // 
            // Teal
            // 
            this.Teal.BackColor = System.Drawing.Color.Teal;
            this.Teal.Location = new System.Drawing.Point(1043, 36);
            this.Teal.Name = "Teal";
            this.Teal.Size = new System.Drawing.Size(20, 15);
            this.Teal.TabIndex = 15;
            this.Teal.Click += new System.EventHandler(this.Teal_Click);
            // 
            // Blue
            // 
            this.Blue.BackColor = System.Drawing.Color.Blue;
            this.Blue.Location = new System.Drawing.Point(1017, 36);
            this.Blue.Name = "Blue";
            this.Blue.Size = new System.Drawing.Size(20, 15);
            this.Blue.TabIndex = 14;
            this.Blue.Click += new System.EventHandler(this.Blue_Click);
            // 
            // SkyBlue
            // 
            this.SkyBlue.BackColor = System.Drawing.Color.SkyBlue;
            this.SkyBlue.Location = new System.Drawing.Point(991, 36);
            this.SkyBlue.Name = "SkyBlue";
            this.SkyBlue.Size = new System.Drawing.Size(20, 15);
            this.SkyBlue.TabIndex = 13;
            this.SkyBlue.Click += new System.EventHandler(this.SkyBlue_Click);
            // 
            // Lime
            // 
            this.Lime.BackColor = System.Drawing.Color.Lime;
            this.Lime.Location = new System.Drawing.Point(965, 36);
            this.Lime.Name = "Lime";
            this.Lime.Size = new System.Drawing.Size(20, 15);
            this.Lime.TabIndex = 12;
            this.Lime.Click += new System.EventHandler(this.Lime_Click);
            // 
            // Green
            // 
            this.Green.BackColor = System.Drawing.Color.Green;
            this.Green.Location = new System.Drawing.Point(939, 36);
            this.Green.Name = "Green";
            this.Green.Size = new System.Drawing.Size(20, 15);
            this.Green.TabIndex = 8;
            this.Green.Click += new System.EventHandler(this.Green_Click);
            // 
            // Yellow
            // 
            this.Yellow.BackColor = System.Drawing.Color.Yellow;
            this.Yellow.Location = new System.Drawing.Point(1043, 15);
            this.Yellow.Name = "Yellow";
            this.Yellow.Size = new System.Drawing.Size(20, 15);
            this.Yellow.TabIndex = 11;
            this.Yellow.Click += new System.EventHandler(this.Yellow_Click);
            // 
            // Orange
            // 
            this.Orange.BackColor = System.Drawing.Color.Orange;
            this.Orange.Location = new System.Drawing.Point(1017, 15);
            this.Orange.Name = "Orange";
            this.Orange.Size = new System.Drawing.Size(20, 15);
            this.Orange.TabIndex = 10;
            this.Orange.Click += new System.EventHandler(this.Orange_Click);
            // 
            // Red
            // 
            this.Red.BackColor = System.Drawing.Color.Red;
            this.Red.Location = new System.Drawing.Point(991, 15);
            this.Red.Name = "Red";
            this.Red.Size = new System.Drawing.Size(20, 15);
            this.Red.TabIndex = 8;
            this.Red.Click += new System.EventHandler(this.Red_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panelColor);
            this.panel4.Controls.Add(this.Color);
            this.panel4.Location = new System.Drawing.Point(816, 13);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(78, 49);
            this.panel4.TabIndex = 8;
            // 
            // panelColor
            // 
            this.panelColor.BackColor = System.Drawing.Color.Black;
            this.panelColor.Location = new System.Drawing.Point(3, 0);
            this.panelColor.Name = "panelColor";
            this.panelColor.Size = new System.Drawing.Size(72, 29);
            this.panelColor.TabIndex = 1;
            // 
            // Color
            // 
            this.Color.AutoSize = true;
            this.Color.Location = new System.Drawing.Point(19, 28);
            this.Color.Name = "Color";
            this.Color.Size = new System.Drawing.Size(36, 15);
            this.Color.TabIndex = 0;
            this.Color.Text = "Color";
            // 
            // White
            // 
            this.White.BackColor = System.Drawing.Color.White;
            this.White.Location = new System.Drawing.Point(913, 36);
            this.White.Name = "White";
            this.White.Size = new System.Drawing.Size(20, 15);
            this.White.TabIndex = 7;
            this.White.Click += new System.EventHandler(this.White_Click);
            // 
            // Brown
            // 
            this.Brown.BackColor = System.Drawing.Color.Brown;
            this.Brown.Location = new System.Drawing.Point(965, 15);
            this.Brown.Name = "Brown";
            this.Brown.Size = new System.Drawing.Size(20, 15);
            this.Brown.TabIndex = 6;
            this.Brown.Click += new System.EventHandler(this.Brown_Click);
            // 
            // Gray
            // 
            this.Gray.BackColor = System.Drawing.Color.Gray;
            this.Gray.Location = new System.Drawing.Point(939, 15);
            this.Gray.Name = "Gray";
            this.Gray.Size = new System.Drawing.Size(20, 15);
            this.Gray.TabIndex = 5;
            this.Gray.Click += new System.EventHandler(this.Gray_Click);
            // 
            // Black
            // 
            this.Black.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Black.Location = new System.Drawing.Point(913, 15);
            this.Black.Name = "Black";
            this.Black.Size = new System.Drawing.Size(20, 15);
            this.Black.TabIndex = 4;
            this.Black.Click += new System.EventHandler(this.Black_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.backToolStripMenuItem,
            this.vToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1260, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.openToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dESToolStripMenuItem});
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // dESToolStripMenuItem
            // 
            this.dESToolStripMenuItem.Checked = true;
            this.dESToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.dESToolStripMenuItem.Name = "dESToolStripMenuItem";
            this.dESToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.dESToolStripMenuItem.Text = "DES";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Image = global::OOP_lab12.Properties.Resources.icons8_u___образная_стрелка_влево_24;
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(28, 20);
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
            // 
            // vToolStripMenuItem
            // 
            this.vToolStripMenuItem.Image = global::OOP_lab12.Properties.Resources.icons8_u___образная_стрелка_вправо_24;
            this.vToolStripMenuItem.Name = "vToolStripMenuItem";
            this.vToolStripMenuItem.Size = new System.Drawing.Size(28, 20);
            this.vToolStripMenuItem.Click += new System.EventHandler(this.vToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1260, 595);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DrawPanel);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Graphics editor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.groupBox1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel DrawPanel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panelColor;
        private System.Windows.Forms.Label Color;
        private System.Windows.Forms.Panel White;
        private System.Windows.Forms.Panel Brown;
        private System.Windows.Forms.Panel Gray;
        private System.Windows.Forms.Panel Black;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Panel Red;
        private System.Windows.Forms.Panel Yellow;
        private System.Windows.Forms.Panel Orange;
        private System.Windows.Forms.Panel Lime;
        private System.Windows.Forms.Panel Green;
        private System.Windows.Forms.Panel Blue;
        private System.Windows.Forms.Panel SkyBlue;
        private System.Windows.Forms.Panel Teal;
        private System.Windows.Forms.Panel LightPurple;
        private System.Windows.Forms.Panel Purple;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vToolStripMenuItem;
        private System.Windows.Forms.Button buttonHighlight;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ToolStripMenuItem dESToolStripMenuItem;
    }
}

