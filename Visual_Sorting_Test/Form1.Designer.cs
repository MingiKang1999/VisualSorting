namespace Visual_Sorting_Test
{
    partial class sortingForm
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.runMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.runSelectionMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.runBubbleMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.runQuickMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.runExitMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.exitButton = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.selectionButton = new System.Windows.Forms.Button();
            this.bubbleButton = new System.Windows.Forms.Button();
            this.quickButton = new System.Windows.Forms.Button();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.runMenu});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(874, 28);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";
            // 
            // runMenu
            // 
            this.runMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.runSelectionMenu,
            this.runBubbleMenu,
            this.runQuickMenu,
            this.runExitMenu});
            this.runMenu.Name = "runMenu";
            this.runMenu.Size = new System.Drawing.Size(117, 24);
            this.runMenu.Text = "Run Sort / Exit";
            // 
            // runSelectionMenu
            // 
            this.runSelectionMenu.Name = "runSelectionMenu";
            this.runSelectionMenu.Size = new System.Drawing.Size(213, 26);
            this.runSelectionMenu.Text = "Run &Selection Sort";
            this.runSelectionMenu.Click += new System.EventHandler(this.runSelectionMenu_Click);
            // 
            // runBubbleMenu
            // 
            this.runBubbleMenu.Name = "runBubbleMenu";
            this.runBubbleMenu.Size = new System.Drawing.Size(213, 26);
            this.runBubbleMenu.Text = "Run &Bubble Sort";
            this.runBubbleMenu.Click += new System.EventHandler(this.runBubbleMenu_Click);
            // 
            // runQuickMenu
            // 
            this.runQuickMenu.Name = "runQuickMenu";
            this.runQuickMenu.Size = new System.Drawing.Size(213, 26);
            this.runQuickMenu.Text = "Run &Quick Sort";
            this.runQuickMenu.Click += new System.EventHandler(this.runQuickMenu_Click);
            // 
            // runExitMenu
            // 
            this.runExitMenu.Name = "runExitMenu";
            this.runExitMenu.Size = new System.Drawing.Size(213, 26);
            this.runExitMenu.Text = "E&xit";
            this.runExitMenu.Click += new System.EventHandler(this.runExitMenu_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(656, 138);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(158, 85);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Font = new System.Drawing.Font("Haan Baekje B", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.resultLabel.Location = new System.Drawing.Point(301, 101);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(0, 25);
            this.resultLabel.TabIndex = 3;
            // 
            // selectionButton
            // 
            this.selectionButton.Location = new System.Drawing.Point(49, 138);
            this.selectionButton.Name = "selectionButton";
            this.selectionButton.Size = new System.Drawing.Size(158, 85);
            this.selectionButton.TabIndex = 1;
            this.selectionButton.Text = "Selection Sorting";
            this.selectionButton.UseVisualStyleBackColor = true;
            this.selectionButton.Click += new System.EventHandler(this.selectionButton_Click);
            // 
            // bubbleButton
            // 
            this.bubbleButton.Location = new System.Drawing.Point(253, 138);
            this.bubbleButton.Name = "bubbleButton";
            this.bubbleButton.Size = new System.Drawing.Size(158, 85);
            this.bubbleButton.TabIndex = 4;
            this.bubbleButton.Text = "Bubble Sorting";
            this.bubbleButton.UseVisualStyleBackColor = true;
            this.bubbleButton.Click += new System.EventHandler(this.bubbleButton_Click);
            // 
            // quickButton
            // 
            this.quickButton.Location = new System.Drawing.Point(457, 138);
            this.quickButton.Name = "quickButton";
            this.quickButton.Size = new System.Drawing.Size(158, 85);
            this.quickButton.TabIndex = 5;
            this.quickButton.Text = "Quick Sorting";
            this.quickButton.UseVisualStyleBackColor = true;
            this.quickButton.Click += new System.EventHandler(this.quickButton_Click);
            // 
            // sortingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 485);
            this.Controls.Add(this.quickButton);
            this.Controls.Add(this.bubbleButton);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.selectionButton);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "sortingForm";
            this.Text = "Visual Sorting Test";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem runMenu;
        private System.Windows.Forms.ToolStripMenuItem runSelectionMenu;
        private System.Windows.Forms.ToolStripMenuItem runBubbleMenu;
        private System.Windows.Forms.ToolStripMenuItem runQuickMenu;
        private System.Windows.Forms.ToolStripMenuItem runExitMenu;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Button selectionButton;
        private System.Windows.Forms.Button bubbleButton;
        private System.Windows.Forms.Button quickButton;
    }
}

