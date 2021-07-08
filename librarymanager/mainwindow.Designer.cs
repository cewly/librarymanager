
namespace librarymanager
{
    partial class mainwindow
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
            this.导入ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadinmenu = new System.Windows.Forms.ToolStripMenuItem();
            this.loadoutmenu = new System.Windows.Forms.ToolStripMenuItem();
            this.UserMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.switchuser = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutappMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.numberRButton = new System.Windows.Forms.RadioButton();
            this.titalRButton = new System.Windows.Forms.RadioButton();
            this.BookListButton = new System.Windows.Forms.Button();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.addBookButton = new System.Windows.Forms.Button();
            this.typeRButton = new System.Windows.Forms.RadioButton();
            this.listView = new System.Windows.Forms.ListView();
            this.CDListButton = new System.Windows.Forms.Button();
            this.ArtListButton = new System.Windows.Forms.Button();
            this.DetailButton = new System.Windows.Forms.Button();
            this.deleteBox = new System.Windows.Forms.TextBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.totalButton = new System.Windows.Forms.Button();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.导入ToolStripMenuItem,
            this.UserMenu,
            this.HelpMenu});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(717, 28);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // 导入ToolStripMenuItem
            // 
            this.导入ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadinmenu,
            this.loadoutmenu});
            this.导入ToolStripMenuItem.Name = "导入ToolStripMenuItem";
            this.导入ToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.导入ToolStripMenuItem.Text = "导入/出";
            // 
            // loadinmenu
            // 
            this.loadinmenu.Name = "loadinmenu";
            this.loadinmenu.Size = new System.Drawing.Size(224, 26);
            this.loadinmenu.Text = "导入数据";
            this.loadinmenu.Click += new System.EventHandler(this.loadinmenu_Click);
            // 
            // loadoutmenu
            // 
            this.loadoutmenu.Name = "loadoutmenu";
            this.loadoutmenu.Size = new System.Drawing.Size(224, 26);
            this.loadoutmenu.Text = "导出数据";
            this.loadoutmenu.Click += new System.EventHandler(this.loadoutmenu_Click);
            // 
            // UserMenu
            // 
            this.UserMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.switchuser});
            this.UserMenu.Name = "UserMenu";
            this.UserMenu.Size = new System.Drawing.Size(53, 24);
            this.UserMenu.Text = "用户";
            this.UserMenu.Click += new System.EventHandler(this.UserMenu_Click);
            // 
            // switchuser
            // 
            this.switchuser.Name = "switchuser";
            this.switchuser.Size = new System.Drawing.Size(152, 26);
            this.switchuser.Text = "切换用户";
            this.switchuser.Click += new System.EventHandler(this.switchuser_Click);
            // 
            // HelpMenu
            // 
            this.HelpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutappMenu});
            this.HelpMenu.Name = "HelpMenu";
            this.HelpMenu.Size = new System.Drawing.Size(53, 24);
            this.HelpMenu.Text = "帮助";
            // 
            // aboutappMenu
            // 
            this.aboutappMenu.Name = "aboutappMenu";
            this.aboutappMenu.Size = new System.Drawing.Size(164, 26);
            this.aboutappMenu.Text = "关于应用...";
            this.aboutappMenu.Click += new System.EventHandler(this.aboutappMenu_Click);
            // 
            // numberRButton
            // 
            this.numberRButton.AutoSize = true;
            this.numberRButton.Checked = true;
            this.numberRButton.Location = new System.Drawing.Point(76, 76);
            this.numberRButton.Name = "numberRButton";
            this.numberRButton.Size = new System.Drawing.Size(58, 19);
            this.numberRButton.TabIndex = 2;
            this.numberRButton.TabStop = true;
            this.numberRButton.Text = "编号";
            this.numberRButton.UseVisualStyleBackColor = true;
            // 
            // titalRButton
            // 
            this.titalRButton.AutoSize = true;
            this.titalRButton.Location = new System.Drawing.Point(12, 77);
            this.titalRButton.Name = "titalRButton";
            this.titalRButton.Size = new System.Drawing.Size(58, 19);
            this.titalRButton.TabIndex = 3;
            this.titalRButton.Text = "标题";
            this.titalRButton.UseVisualStyleBackColor = true;
            // 
            // BookListButton
            // 
            this.BookListButton.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BookListButton.Location = new System.Drawing.Point(13, 32);
            this.BookListButton.Name = "BookListButton";
            this.BookListButton.Size = new System.Drawing.Size(95, 30);
            this.BookListButton.TabIndex = 4;
            this.BookListButton.Text = "图书列表";
            this.BookListButton.UseVisualStyleBackColor = true;
            this.BookListButton.Click += new System.EventHandler(this.BookListButton_Click);
            // 
            // SearchBox
            // 
            this.SearchBox.Location = new System.Drawing.Point(202, 74);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(398, 25);
            this.SearchBox.TabIndex = 6;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(606, 74);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(81, 25);
            this.SearchButton.TabIndex = 7;
            this.SearchButton.Text = "搜索";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // addBookButton
            // 
            this.addBookButton.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.addBookButton.Location = new System.Drawing.Point(161, 474);
            this.addBookButton.Name = "addBookButton";
            this.addBookButton.Size = new System.Drawing.Size(95, 30);
            this.addBookButton.TabIndex = 12;
            this.addBookButton.Text = "添加";
            this.addBookButton.UseVisualStyleBackColor = true;
            this.addBookButton.Click += new System.EventHandler(this.addBookButton_Click);
            // 
            // typeRButton
            // 
            this.typeRButton.AutoSize = true;
            this.typeRButton.Location = new System.Drawing.Point(138, 76);
            this.typeRButton.Name = "typeRButton";
            this.typeRButton.Size = new System.Drawing.Size(58, 19);
            this.typeRButton.TabIndex = 13;
            this.typeRButton.Text = "类型";
            this.typeRButton.UseVisualStyleBackColor = true;
            // 
            // listView
            // 
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(13, 105);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(680, 353);
            this.listView.TabIndex = 8;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // CDListButton
            // 
            this.CDListButton.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CDListButton.Location = new System.Drawing.Point(127, 32);
            this.CDListButton.Name = "CDListButton";
            this.CDListButton.Size = new System.Drawing.Size(95, 30);
            this.CDListButton.TabIndex = 14;
            this.CDListButton.Text = "光盘列表";
            this.CDListButton.UseVisualStyleBackColor = true;
            this.CDListButton.Click += new System.EventHandler(this.CDListButton_Click);
            // 
            // ArtListButton
            // 
            this.ArtListButton.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ArtListButton.Location = new System.Drawing.Point(240, 32);
            this.ArtListButton.Name = "ArtListButton";
            this.ArtListButton.Size = new System.Drawing.Size(95, 30);
            this.ArtListButton.TabIndex = 15;
            this.ArtListButton.Text = "图画列表";
            this.ArtListButton.UseVisualStyleBackColor = true;
            this.ArtListButton.Click += new System.EventHandler(this.ArtListButton_Click);
            // 
            // DetailButton
            // 
            this.DetailButton.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DetailButton.Location = new System.Drawing.Point(39, 474);
            this.DetailButton.Name = "DetailButton";
            this.DetailButton.Size = new System.Drawing.Size(95, 30);
            this.DetailButton.TabIndex = 16;
            this.DetailButton.Text = "详情";
            this.DetailButton.UseVisualStyleBackColor = true;
            this.DetailButton.Click += new System.EventHandler(this.DetailButton_Click);
            // 
            // deleteBox
            // 
            this.deleteBox.Location = new System.Drawing.Point(426, 480);
            this.deleteBox.Name = "deleteBox";
            this.deleteBox.Size = new System.Drawing.Size(174, 25);
            this.deleteBox.TabIndex = 17;
            this.deleteBox.TextChanged += new System.EventHandler(this.deleteBox_TextChanged);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(606, 480);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(81, 25);
            this.deleteButton.TabIndex = 18;
            this.deleteButton.Text = "删除";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // totalButton
            // 
            this.totalButton.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.totalButton.Location = new System.Drawing.Point(289, 474);
            this.totalButton.Name = "totalButton";
            this.totalButton.Size = new System.Drawing.Size(95, 30);
            this.totalButton.TabIndex = 19;
            this.totalButton.Text = "统计";
            this.totalButton.UseVisualStyleBackColor = true;
            this.totalButton.Click += new System.EventHandler(this.totalButton_Click);
            // 
            // mainwindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 522);
            this.Controls.Add(this.totalButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.deleteBox);
            this.Controls.Add(this.DetailButton);
            this.Controls.Add(this.ArtListButton);
            this.Controls.Add(this.CDListButton);
            this.Controls.Add(this.typeRButton);
            this.Controls.Add(this.addBookButton);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.BookListButton);
            this.Controls.Add(this.titalRButton);
            this.Controls.Add(this.numberRButton);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "mainwindow";
            this.Text = "媒体库管理系统";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem UserMenu;
        private System.Windows.Forms.ToolStripMenuItem switchuser;
        private System.Windows.Forms.ToolStripMenuItem HelpMenu;
        private System.Windows.Forms.ToolStripMenuItem aboutappMenu;
        private System.Windows.Forms.RadioButton numberRButton;
        private System.Windows.Forms.RadioButton titalRButton;
        private System.Windows.Forms.Button BookListButton;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button addBookButton;
        private System.Windows.Forms.RadioButton typeRButton;
        private System.Windows.Forms.ToolStripMenuItem 导入ToolStripMenuItem;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.Button CDListButton;
        private System.Windows.Forms.Button ArtListButton;
        private System.Windows.Forms.Button DetailButton;
        private System.Windows.Forms.ToolStripMenuItem loadinmenu;
        private System.Windows.Forms.ToolStripMenuItem loadoutmenu;
        private System.Windows.Forms.TextBox deleteBox;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button totalButton;
    }
}