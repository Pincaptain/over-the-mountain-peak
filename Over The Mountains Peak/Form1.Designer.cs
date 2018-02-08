namespace Over_The_Mountains_Peak {
    partial class BaseForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseForm));
            this.BaseMenu = new System.Windows.Forms.MenuStrip();
            this.FileDropdownMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.NewToolMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenToolMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveToolMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.EditDropdownMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutToolMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.QuitToolMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.BasePanel = new System.Windows.Forms.Panel();
            this.UserControl = new System.Windows.Forms.TabControl();
            this.ControlPage = new System.Windows.Forms.TabPage();
            this.AddDescriptionGroupBox = new System.Windows.Forms.GroupBox();
            this.DescriptionAudioPathTextBox = new System.Windows.Forms.TextBox();
            this.DescriptionAudioPathLabel = new System.Windows.Forms.Label();
            this.DescriptionImageDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.DescriptionSelectImageButton = new System.Windows.Forms.Button();
            this.DescriptionImagePathTextBox = new System.Windows.Forms.TextBox();
            this.DescriptionClearButton = new System.Windows.Forms.Button();
            this.DescriptionAddButton = new System.Windows.Forms.Button();
            this.DescriptionContentRichTextBox = new System.Windows.Forms.RichTextBox();
            this.DescriptionContentLabel = new System.Windows.Forms.Label();
            this.DescriptionTitleTextBox = new System.Windows.Forms.TextBox();
            this.DescriptionTitleLabel = new System.Windows.Forms.Label();
            this.AddCategoryGroupBox = new System.Windows.Forms.GroupBox();
            this.CategoryAddButton = new System.Windows.Forms.Button();
            this.CategoryHintLabel = new System.Windows.Forms.Label();
            this.CategoryTitleTextBox = new System.Windows.Forms.TextBox();
            this.ViewPage = new System.Windows.Forms.TabPage();
            this.DetailAudioMediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.DetailImageDescriptionLabel = new System.Windows.Forms.Label();
            this.DetailTextHolderPanel = new System.Windows.Forms.Panel();
            this.DetailContentLabel = new System.Windows.Forms.Label();
            this.DetailImagePictureBox = new System.Windows.Forms.PictureBox();
            this.DetailTitleLabel = new System.Windows.Forms.Label();
            this.CategoryTree = new System.Windows.Forms.TreeView();
            this.ImageListTreeView = new System.Windows.Forms.ImageList(this.components);
            this.BaseMenu.SuspendLayout();
            this.BasePanel.SuspendLayout();
            this.UserControl.SuspendLayout();
            this.ControlPage.SuspendLayout();
            this.AddDescriptionGroupBox.SuspendLayout();
            this.AddCategoryGroupBox.SuspendLayout();
            this.ViewPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DetailAudioMediaPlayer)).BeginInit();
            this.DetailTextHolderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DetailImagePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // BaseMenu
            // 
            this.BaseMenu.Font = new System.Drawing.Font("Bahnschrift Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BaseMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileDropdownMenu,
            this.EditDropdownMenu,
            this.AboutToolMenu,
            this.QuitToolMenu});
            this.BaseMenu.Location = new System.Drawing.Point(0, 0);
            this.BaseMenu.Name = "BaseMenu";
            this.BaseMenu.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.BaseMenu.Size = new System.Drawing.Size(1224, 24);
            this.BaseMenu.TabIndex = 2;
            this.BaseMenu.Text = "Menu";
            // 
            // FileDropdownMenu
            // 
            this.FileDropdownMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewToolMenu,
            this.OpenToolMenu,
            this.SaveToolMenu});
            this.FileDropdownMenu.Name = "FileDropdownMenu";
            this.FileDropdownMenu.Size = new System.Drawing.Size(38, 20);
            this.FileDropdownMenu.Text = "File";
            // 
            // NewToolMenu
            // 
            this.NewToolMenu.Name = "NewToolMenu";
            this.NewToolMenu.Size = new System.Drawing.Size(102, 22);
            this.NewToolMenu.Text = "New";
            this.NewToolMenu.Click += new System.EventHandler(this.NewToolMenu_Click);
            // 
            // OpenToolMenu
            // 
            this.OpenToolMenu.Name = "OpenToolMenu";
            this.OpenToolMenu.Size = new System.Drawing.Size(102, 22);
            this.OpenToolMenu.Text = "Open";
            this.OpenToolMenu.Click += new System.EventHandler(this.OpenToolMenu_Click);
            // 
            // SaveToolMenu
            // 
            this.SaveToolMenu.Name = "SaveToolMenu";
            this.SaveToolMenu.Size = new System.Drawing.Size(102, 22);
            this.SaveToolMenu.Text = "Save";
            this.SaveToolMenu.Click += new System.EventHandler(this.SaveToolMenu_Click);
            // 
            // EditDropdownMenu
            // 
            this.EditDropdownMenu.Name = "EditDropdownMenu";
            this.EditDropdownMenu.Size = new System.Drawing.Size(40, 20);
            this.EditDropdownMenu.Text = "Edit";
            // 
            // AboutToolMenu
            // 
            this.AboutToolMenu.Name = "AboutToolMenu";
            this.AboutToolMenu.Size = new System.Drawing.Size(52, 20);
            this.AboutToolMenu.Text = "About";
            // 
            // QuitToolMenu
            // 
            this.QuitToolMenu.Name = "QuitToolMenu";
            this.QuitToolMenu.Size = new System.Drawing.Size(41, 20);
            this.QuitToolMenu.Text = "Quit";
            this.QuitToolMenu.Click += new System.EventHandler(this.QuitToolMenu_Click);
            // 
            // BasePanel
            // 
            this.BasePanel.Controls.Add(this.UserControl);
            this.BasePanel.Controls.Add(this.CategoryTree);
            this.BasePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BasePanel.Location = new System.Drawing.Point(0, 24);
            this.BasePanel.Name = "BasePanel";
            this.BasePanel.Size = new System.Drawing.Size(1224, 563);
            this.BasePanel.TabIndex = 3;
            // 
            // UserControl
            // 
            this.UserControl.Controls.Add(this.ControlPage);
            this.UserControl.Controls.Add(this.ViewPage);
            this.UserControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserControl.Location = new System.Drawing.Point(180, 0);
            this.UserControl.Name = "UserControl";
            this.UserControl.SelectedIndex = 0;
            this.UserControl.Size = new System.Drawing.Size(1044, 563);
            this.UserControl.TabIndex = 1;
            // 
            // ControlPage
            // 
            this.ControlPage.Controls.Add(this.AddDescriptionGroupBox);
            this.ControlPage.Controls.Add(this.AddCategoryGroupBox);
            this.ControlPage.Location = new System.Drawing.Point(4, 25);
            this.ControlPage.Name = "ControlPage";
            this.ControlPage.Padding = new System.Windows.Forms.Padding(3);
            this.ControlPage.Size = new System.Drawing.Size(1036, 534);
            this.ControlPage.TabIndex = 0;
            this.ControlPage.Text = "Control";
            this.ControlPage.UseVisualStyleBackColor = true;
            // 
            // AddDescriptionGroupBox
            // 
            this.AddDescriptionGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddDescriptionGroupBox.Controls.Add(this.DescriptionAudioPathTextBox);
            this.AddDescriptionGroupBox.Controls.Add(this.DescriptionAudioPathLabel);
            this.AddDescriptionGroupBox.Controls.Add(this.DescriptionImageDescriptionTextBox);
            this.AddDescriptionGroupBox.Controls.Add(this.DescriptionSelectImageButton);
            this.AddDescriptionGroupBox.Controls.Add(this.DescriptionImagePathTextBox);
            this.AddDescriptionGroupBox.Controls.Add(this.DescriptionClearButton);
            this.AddDescriptionGroupBox.Controls.Add(this.DescriptionAddButton);
            this.AddDescriptionGroupBox.Controls.Add(this.DescriptionContentRichTextBox);
            this.AddDescriptionGroupBox.Controls.Add(this.DescriptionContentLabel);
            this.AddDescriptionGroupBox.Controls.Add(this.DescriptionTitleTextBox);
            this.AddDescriptionGroupBox.Controls.Add(this.DescriptionTitleLabel);
            this.AddDescriptionGroupBox.Location = new System.Drawing.Point(9, 112);
            this.AddDescriptionGroupBox.Name = "AddDescriptionGroupBox";
            this.AddDescriptionGroupBox.Size = new System.Drawing.Size(1019, 414);
            this.AddDescriptionGroupBox.TabIndex = 0;
            this.AddDescriptionGroupBox.TabStop = false;
            this.AddDescriptionGroupBox.Text = "Add Description";
            // 
            // DescriptionAudioPathTextBox
            // 
            this.DescriptionAudioPathTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DescriptionAudioPathTextBox.Location = new System.Drawing.Point(515, 43);
            this.DescriptionAudioPathTextBox.Name = "DescriptionAudioPathTextBox";
            this.DescriptionAudioPathTextBox.Size = new System.Drawing.Size(498, 23);
            this.DescriptionAudioPathTextBox.TabIndex = 9;
            // 
            // DescriptionAudioPathLabel
            // 
            this.DescriptionAudioPathLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DescriptionAudioPathLabel.AutoSize = true;
            this.DescriptionAudioPathLabel.Location = new System.Drawing.Point(512, 23);
            this.DescriptionAudioPathLabel.Name = "DescriptionAudioPathLabel";
            this.DescriptionAudioPathLabel.Size = new System.Drawing.Size(106, 16);
            this.DescriptionAudioPathLabel.TabIndex = 8;
            this.DescriptionAudioPathLabel.Text = "Audio File Source";
            // 
            // DescriptionImageDescriptionTextBox
            // 
            this.DescriptionImageDescriptionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DescriptionImageDescriptionTextBox.Location = new System.Drawing.Point(10, 381);
            this.DescriptionImageDescriptionTextBox.Name = "DescriptionImageDescriptionTextBox";
            this.DescriptionImageDescriptionTextBox.Size = new System.Drawing.Size(163, 23);
            this.DescriptionImageDescriptionTextBox.TabIndex = 7;
            // 
            // DescriptionSelectImageButton
            // 
            this.DescriptionSelectImageButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DescriptionSelectImageButton.Location = new System.Drawing.Point(325, 381);
            this.DescriptionSelectImageButton.Name = "DescriptionSelectImageButton";
            this.DescriptionSelectImageButton.Size = new System.Drawing.Size(101, 23);
            this.DescriptionSelectImageButton.TabIndex = 6;
            this.DescriptionSelectImageButton.Text = "Select Image";
            this.DescriptionSelectImageButton.UseVisualStyleBackColor = true;
            this.DescriptionSelectImageButton.Click += new System.EventHandler(this.DescriptionSelectImageButton_Click);
            // 
            // DescriptionImagePathTextBox
            // 
            this.DescriptionImagePathTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DescriptionImagePathTextBox.Location = new System.Drawing.Point(179, 381);
            this.DescriptionImagePathTextBox.Name = "DescriptionImagePathTextBox";
            this.DescriptionImagePathTextBox.ReadOnly = true;
            this.DescriptionImagePathTextBox.Size = new System.Drawing.Size(140, 23);
            this.DescriptionImagePathTextBox.TabIndex = 5;
            // 
            // DescriptionClearButton
            // 
            this.DescriptionClearButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DescriptionClearButton.Location = new System.Drawing.Point(679, 377);
            this.DescriptionClearButton.Name = "DescriptionClearButton";
            this.DescriptionClearButton.Size = new System.Drawing.Size(164, 31);
            this.DescriptionClearButton.TabIndex = 4;
            this.DescriptionClearButton.Text = "Clear";
            this.DescriptionClearButton.UseVisualStyleBackColor = true;
            this.DescriptionClearButton.Click += new System.EventHandler(this.DescriptionClearButton_Click);
            // 
            // DescriptionAddButton
            // 
            this.DescriptionAddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DescriptionAddButton.Location = new System.Drawing.Point(849, 377);
            this.DescriptionAddButton.Name = "DescriptionAddButton";
            this.DescriptionAddButton.Size = new System.Drawing.Size(164, 31);
            this.DescriptionAddButton.TabIndex = 3;
            this.DescriptionAddButton.Text = "Add";
            this.DescriptionAddButton.UseVisualStyleBackColor = true;
            this.DescriptionAddButton.Click += new System.EventHandler(this.DescriptionAddButton_Click);
            // 
            // DescriptionContentRichTextBox
            // 
            this.DescriptionContentRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DescriptionContentRichTextBox.Location = new System.Drawing.Point(10, 89);
            this.DescriptionContentRichTextBox.Name = "DescriptionContentRichTextBox";
            this.DescriptionContentRichTextBox.Size = new System.Drawing.Size(1003, 276);
            this.DescriptionContentRichTextBox.TabIndex = 3;
            this.DescriptionContentRichTextBox.Text = "";
            // 
            // DescriptionContentLabel
            // 
            this.DescriptionContentLabel.AutoSize = true;
            this.DescriptionContentLabel.Location = new System.Drawing.Point(7, 69);
            this.DescriptionContentLabel.Name = "DescriptionContentLabel";
            this.DescriptionContentLabel.Size = new System.Drawing.Size(52, 16);
            this.DescriptionContentLabel.TabIndex = 2;
            this.DescriptionContentLabel.Text = "Content";
            // 
            // DescriptionTitleTextBox
            // 
            this.DescriptionTitleTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DescriptionTitleTextBox.Location = new System.Drawing.Point(9, 43);
            this.DescriptionTitleTextBox.Name = "DescriptionTitleTextBox";
            this.DescriptionTitleTextBox.Size = new System.Drawing.Size(500, 23);
            this.DescriptionTitleTextBox.TabIndex = 1;
            // 
            // DescriptionTitleLabel
            // 
            this.DescriptionTitleLabel.AutoSize = true;
            this.DescriptionTitleLabel.Location = new System.Drawing.Point(7, 23);
            this.DescriptionTitleLabel.Name = "DescriptionTitleLabel";
            this.DescriptionTitleLabel.Size = new System.Drawing.Size(32, 16);
            this.DescriptionTitleLabel.TabIndex = 0;
            this.DescriptionTitleLabel.Text = "Title";
            // 
            // AddCategoryGroupBox
            // 
            this.AddCategoryGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddCategoryGroupBox.Controls.Add(this.CategoryAddButton);
            this.AddCategoryGroupBox.Controls.Add(this.CategoryHintLabel);
            this.AddCategoryGroupBox.Controls.Add(this.CategoryTitleTextBox);
            this.AddCategoryGroupBox.Location = new System.Drawing.Point(9, 6);
            this.AddCategoryGroupBox.Name = "AddCategoryGroupBox";
            this.AddCategoryGroupBox.Size = new System.Drawing.Size(1019, 100);
            this.AddCategoryGroupBox.TabIndex = 0;
            this.AddCategoryGroupBox.TabStop = false;
            this.AddCategoryGroupBox.Text = "Add Category";
            // 
            // CategoryAddButton
            // 
            this.CategoryAddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CategoryAddButton.Location = new System.Drawing.Point(849, 60);
            this.CategoryAddButton.Name = "CategoryAddButton";
            this.CategoryAddButton.Size = new System.Drawing.Size(164, 31);
            this.CategoryAddButton.TabIndex = 2;
            this.CategoryAddButton.Text = "Add";
            this.CategoryAddButton.UseVisualStyleBackColor = true;
            this.CategoryAddButton.Click += new System.EventHandler(this.CategoryAddButton_Click);
            // 
            // CategoryHintLabel
            // 
            this.CategoryHintLabel.AutoSize = true;
            this.CategoryHintLabel.Location = new System.Drawing.Point(6, 59);
            this.CategoryHintLabel.MaximumSize = new System.Drawing.Size(300, 0);
            this.CategoryHintLabel.Name = "CategoryHintLabel";
            this.CategoryHintLabel.Size = new System.Drawing.Size(294, 32);
            this.CategoryHintLabel.TabIndex = 1;
            this.CategoryHintLabel.Text = "The specified category can only be added to the root category or another previous" +
    "ly selected category.";
            // 
            // CategoryTitleTextBox
            // 
            this.CategoryTitleTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CategoryTitleTextBox.Location = new System.Drawing.Point(7, 23);
            this.CategoryTitleTextBox.Name = "CategoryTitleTextBox";
            this.CategoryTitleTextBox.Size = new System.Drawing.Size(1006, 23);
            this.CategoryTitleTextBox.TabIndex = 0;
            // 
            // ViewPage
            // 
            this.ViewPage.Controls.Add(this.DetailAudioMediaPlayer);
            this.ViewPage.Controls.Add(this.DetailImageDescriptionLabel);
            this.ViewPage.Controls.Add(this.DetailTextHolderPanel);
            this.ViewPage.Controls.Add(this.DetailImagePictureBox);
            this.ViewPage.Controls.Add(this.DetailTitleLabel);
            this.ViewPage.Font = new System.Drawing.Font("Bahnschrift Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewPage.Location = new System.Drawing.Point(4, 25);
            this.ViewPage.Name = "ViewPage";
            this.ViewPage.Padding = new System.Windows.Forms.Padding(3);
            this.ViewPage.Size = new System.Drawing.Size(1036, 534);
            this.ViewPage.TabIndex = 1;
            this.ViewPage.Text = "View";
            this.ViewPage.UseVisualStyleBackColor = true;
            // 
            // DetailAudioMediaPlayer
            // 
            this.DetailAudioMediaPlayer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DetailAudioMediaPlayer.Enabled = true;
            this.DetailAudioMediaPlayer.Location = new System.Drawing.Point(655, 320);
            this.DetailAudioMediaPlayer.Name = "DetailAudioMediaPlayer";
            this.DetailAudioMediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("DetailAudioMediaPlayer.OcxState")));
            this.DetailAudioMediaPlayer.Size = new System.Drawing.Size(373, 45);
            this.DetailAudioMediaPlayer.TabIndex = 5;
            this.DetailAudioMediaPlayer.Visible = false;
            // 
            // DetailImageDescriptionLabel
            // 
            this.DetailImageDescriptionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DetailImageDescriptionLabel.AutoSize = true;
            this.DetailImageDescriptionLabel.Location = new System.Drawing.Point(655, 368);
            this.DetailImageDescriptionLabel.MaximumSize = new System.Drawing.Size(355, 0);
            this.DetailImageDescriptionLabel.Name = "DetailImageDescriptionLabel";
            this.DetailImageDescriptionLabel.Size = new System.Drawing.Size(0, 18);
            this.DetailImageDescriptionLabel.TabIndex = 4;
            // 
            // DetailTextHolderPanel
            // 
            this.DetailTextHolderPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DetailTextHolderPanel.AutoScroll = true;
            this.DetailTextHolderPanel.Controls.Add(this.DetailContentLabel);
            this.DetailTextHolderPanel.Location = new System.Drawing.Point(13, 47);
            this.DetailTextHolderPanel.Name = "DetailTextHolderPanel";
            this.DetailTextHolderPanel.Size = new System.Drawing.Size(636, 481);
            this.DetailTextHolderPanel.TabIndex = 3;
            // 
            // DetailContentLabel
            // 
            this.DetailContentLabel.AutoSize = true;
            this.DetailContentLabel.Location = new System.Drawing.Point(4, 4);
            this.DetailContentLabel.MaximumSize = new System.Drawing.Size(600, 0);
            this.DetailContentLabel.Name = "DetailContentLabel";
            this.DetailContentLabel.Size = new System.Drawing.Size(0, 18);
            this.DetailContentLabel.TabIndex = 0;
            // 
            // DetailImagePictureBox
            // 
            this.DetailImagePictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DetailImagePictureBox.Location = new System.Drawing.Point(655, 7);
            this.DetailImagePictureBox.Name = "DetailImagePictureBox";
            this.DetailImagePictureBox.Size = new System.Drawing.Size(373, 307);
            this.DetailImagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.DetailImagePictureBox.TabIndex = 2;
            this.DetailImagePictureBox.TabStop = false;
            // 
            // DetailTitleLabel
            // 
            this.DetailTitleLabel.AutoSize = true;
            this.DetailTitleLabel.Font = new System.Drawing.Font("Bahnschrift Light", 22F);
            this.DetailTitleLabel.Location = new System.Drawing.Point(7, 7);
            this.DetailTitleLabel.Name = "DetailTitleLabel";
            this.DetailTitleLabel.Size = new System.Drawing.Size(0, 36);
            this.DetailTitleLabel.TabIndex = 0;
            // 
            // CategoryTree
            // 
            this.CategoryTree.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CategoryTree.Dock = System.Windows.Forms.DockStyle.Left;
            this.CategoryTree.Location = new System.Drawing.Point(0, 0);
            this.CategoryTree.Name = "CategoryTree";
            this.CategoryTree.SelectedImageIndex = 0;
            this.CategoryTree.Size = new System.Drawing.Size(180, 563);
            this.CategoryTree.TabIndex = 0;
            this.CategoryTree.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.CategoryTreeNode_Selected);
            // 
            // ImageListTreeView
            // 
            this.ImageListTreeView.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ImageListTreeView.ImageSize = new System.Drawing.Size(16, 16);
            this.ImageListTreeView.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 587);
            this.Controls.Add(this.BasePanel);
            this.Controls.Add(this.BaseMenu);
            this.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.BaseMenu;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "BaseForm";
            this.Text = "Over The Mountains Peak";
            this.BaseMenu.ResumeLayout(false);
            this.BaseMenu.PerformLayout();
            this.BasePanel.ResumeLayout(false);
            this.UserControl.ResumeLayout(false);
            this.ControlPage.ResumeLayout(false);
            this.AddDescriptionGroupBox.ResumeLayout(false);
            this.AddDescriptionGroupBox.PerformLayout();
            this.AddCategoryGroupBox.ResumeLayout(false);
            this.AddCategoryGroupBox.PerformLayout();
            this.ViewPage.ResumeLayout(false);
            this.ViewPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DetailAudioMediaPlayer)).EndInit();
            this.DetailTextHolderPanel.ResumeLayout(false);
            this.DetailTextHolderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DetailImagePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip BaseMenu;
        private System.Windows.Forms.ToolStripMenuItem FileDropdownMenu;
        private System.Windows.Forms.ToolStripMenuItem EditDropdownMenu;
        private System.Windows.Forms.ToolStripMenuItem AboutToolMenu;
        private System.Windows.Forms.ToolStripMenuItem QuitToolMenu;
        private System.Windows.Forms.ToolStripMenuItem NewToolMenu;
        private System.Windows.Forms.ToolStripMenuItem OpenToolMenu;
        private System.Windows.Forms.ToolStripMenuItem SaveToolMenu;
        private System.Windows.Forms.Panel BasePanel;
        private System.Windows.Forms.TreeView CategoryTree;
        private System.Windows.Forms.TabControl UserControl;
        private System.Windows.Forms.TabPage ControlPage;
        private System.Windows.Forms.TabPage ViewPage;
        private System.Windows.Forms.GroupBox AddDescriptionGroupBox;
        private System.Windows.Forms.GroupBox AddCategoryGroupBox;
        private System.Windows.Forms.TextBox CategoryTitleTextBox;
        private System.Windows.Forms.Label CategoryHintLabel;
        private System.Windows.Forms.Button CategoryAddButton;
        private System.Windows.Forms.TextBox DescriptionTitleTextBox;
        private System.Windows.Forms.Label DescriptionTitleLabel;
        private System.Windows.Forms.Label DescriptionContentLabel;
        private System.Windows.Forms.RichTextBox DescriptionContentRichTextBox;
        private System.Windows.Forms.Button DescriptionAddButton;
        private System.Windows.Forms.Button DescriptionClearButton;
        private System.Windows.Forms.TextBox DescriptionImagePathTextBox;
        private System.Windows.Forms.Button DescriptionSelectImageButton;
        private System.Windows.Forms.Label DetailTitleLabel;
        private System.Windows.Forms.PictureBox DetailImagePictureBox;
        private System.Windows.Forms.Panel DetailTextHolderPanel;
        private System.Windows.Forms.Label DetailContentLabel;
        private System.Windows.Forms.Label DetailImageDescriptionLabel;
        private System.Windows.Forms.TextBox DescriptionImageDescriptionTextBox;
        private AxWMPLib.AxWindowsMediaPlayer DetailAudioMediaPlayer;
        private System.Windows.Forms.TextBox DescriptionAudioPathTextBox;
        private System.Windows.Forms.Label DescriptionAudioPathLabel;
        private System.Windows.Forms.ImageList ImageListTreeView;
    }
}

