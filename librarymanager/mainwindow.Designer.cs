
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
            this.图书数据ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.导入用户数据ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UserMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutme = new System.Windows.Forms.ToolStripMenuItem();
            this.switchuser = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutappMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.numberRButton = new System.Windows.Forms.RadioButton();
            this.titalRButton = new System.Windows.Forms.RadioButton();
            this.BookListButton = new System.Windows.Forms.Button();
            this.UserListButton = new System.Windows.Forms.Button();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.BorrowButton = new System.Windows.Forms.Button();
            this.ReturnButton = new System.Windows.Forms.Button();
            this.addBookButton = new System.Windows.Forms.Button();
            this.typeRButton = new System.Windows.Forms.RadioButton();
            this.listView = new System.Windows.Forms.ListView();
            this.CDListButton = new System.Windows.Forms.Button();
            this.ArtListButton = new System.Windows.Forms.Button();
            this.DetailButton = new System.Windows.Forms.Button();
            this.光盘数据ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.图画数据ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.图书数据ToolStripMenuItem,
            this.光盘数据ToolStripMenuItem,
            this.图画数据ToolStripMenuItem,
            this.导入用户数据ToolStripMenuItem});
            this.导入ToolStripMenuItem.Name = "导入ToolStripMenuItem";
            this.导入ToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.导入ToolStripMenuItem.Text = "导入";
            // 
            // 图书数据ToolStripMenuItem
            // 
            this.图书数据ToolStripMenuItem.Name = "图书数据ToolStripMenuItem";
            this.图书数据ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.图书数据ToolStripMenuItem.Text = "图书数据";
            // 
            // 导入用户数据ToolStripMenuItem
            // 
            this.导入用户数据ToolStripMenuItem.Name = "导入用户数据ToolStripMenuItem";
            this.导入用户数据ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.导入用户数据ToolStripMenuItem.Text = "用户数据";
            // 
            // UserMenu
            // 
            this.UserMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutme,
            this.switchuser});
            this.UserMenu.Name = "UserMenu";
            this.UserMenu.Size = new System.Drawing.Size(53, 24);
            this.UserMenu.Text = "用户";
            // 
            // aboutme
            // 
            this.aboutme.Name = "aboutme";
            this.aboutme.Size = new System.Drawing.Size(224, 26);
            this.aboutme.Text = "个人信息";
            // 
            // switchuser
            // 
            this.switchuser.Name = "switchuser";
            this.switchuser.Size = new System.Drawing.Size(224, 26);
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
            this.aboutappMenu.Size = new System.Drawing.Size(224, 26);
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
            // UserListButton
            // 
            this.UserListButton.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.UserListButton.Location = new System.Drawing.Point(353, 32);
            this.UserListButton.Name = "UserListButton";
            this.UserListButton.Size = new System.Drawing.Size(95, 30);
            this.UserListButton.TabIndex = 5;
            this.UserListButton.Text = "用户列表";
            this.UserListButton.UseVisualStyleBackColor = true;
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
            // 
            // BorrowButton
            // 
            this.BorrowButton.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BorrowButton.Location = new System.Drawing.Point(12, 474);
            this.BorrowButton.Name = "BorrowButton";
            this.BorrowButton.Size = new System.Drawing.Size(95, 30);
            this.BorrowButton.TabIndex = 9;
            this.BorrowButton.Text = "借书";
            this.BorrowButton.UseVisualStyleBackColor = true;
            // 
            // ReturnButton
            // 
            this.ReturnButton.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ReturnButton.Location = new System.Drawing.Point(124, 474);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(95, 30);
            this.ReturnButton.TabIndex = 10;
            this.ReturnButton.Text = "还书";
            this.ReturnButton.UseVisualStyleBackColor = true;
            // 
            // addBookButton
            // 
            this.addBookButton.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.addBookButton.Location = new System.Drawing.Point(363, 473);
            this.addBookButton.Name = "addBookButton";
            this.addBookButton.Size = new System.Drawing.Size(95, 30);
            this.addBookButton.TabIndex = 12;
            this.addBookButton.Text = "添加";
            this.addBookButton.UseVisualStyleBackColor = true;
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
            // 
            // DetailButton
            // 
            this.DetailButton.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DetailButton.Location = new System.Drawing.Point(241, 473);
            this.DetailButton.Name = "DetailButton";
            this.DetailButton.Size = new System.Drawing.Size(95, 30);
            this.DetailButton.TabIndex = 16;
            this.DetailButton.Text = "详情";
            this.DetailButton.UseVisualStyleBackColor = true;
            this.DetailButton.Click += new System.EventHandler(this.DetailButton_Click);
            // 
            // 光盘数据ToolStripMenuItem
            // 
            this.光盘数据ToolStripMenuItem.Name = "光盘数据ToolStripMenuItem";
            this.光盘数据ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.光盘数据ToolStripMenuItem.Text = "光盘数据";
            // 
            // 图画数据ToolStripMenuItem
            // 
            this.图画数据ToolStripMenuItem.Name = "图画数据ToolStripMenuItem";
            this.图画数据ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.图画数据ToolStripMenuItem.Text = "图画数据";
            // 
            // mainwindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 522);
            this.Controls.Add(this.DetailButton);
            this.Controls.Add(this.ArtListButton);
            this.Controls.Add(this.CDListButton);
            this.Controls.Add(this.typeRButton);
            this.Controls.Add(this.addBookButton);
            this.Controls.Add(this.ReturnButton);
            this.Controls.Add(this.BorrowButton);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.UserListButton);
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
        private System.Windows.Forms.ToolStripMenuItem aboutme;
        private System.Windows.Forms.ToolStripMenuItem switchuser;
        private System.Windows.Forms.ToolStripMenuItem HelpMenu;
        private System.Windows.Forms.ToolStripMenuItem aboutappMenu;
        private System.Windows.Forms.RadioButton numberRButton;
        private System.Windows.Forms.RadioButton titalRButton;
        private System.Windows.Forms.Button BookListButton;
        private System.Windows.Forms.Button UserListButton;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button BorrowButton;
        private System.Windows.Forms.Button ReturnButton;
        private System.Windows.Forms.Button addBookButton;
        private System.Windows.Forms.RadioButton typeRButton;
        private System.Windows.Forms.ToolStripMenuItem 导入ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 导入用户数据ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 图书数据ToolStripMenuItem;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.Button CDListButton;
        private System.Windows.Forms.Button ArtListButton;
        private System.Windows.Forms.Button DetailButton;
        private System.Windows.Forms.ToolStripMenuItem 光盘数据ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 图画数据ToolStripMenuItem;
    }
}