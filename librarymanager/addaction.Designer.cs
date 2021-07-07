
namespace librarymanager
{
    partial class addaction
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
            this.type = new System.Windows.Forms.Label();
            this.bookRButton = new System.Windows.Forms.RadioButton();
            this.CDRButton = new System.Windows.Forms.RadioButton();
            this.artRButton = new System.Windows.Forms.RadioButton();
            this.levelBox = new System.Windows.Forms.TextBox();
            this.level = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.authorBox = new System.Windows.Forms.TextBox();
            this.author = new System.Windows.Forms.Label();
            this.numberBox = new System.Windows.Forms.TextBox();
            this.number = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // type
            // 
            this.type.AutoSize = true;
            this.type.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.type.Location = new System.Drawing.Point(58, 28);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(51, 17);
            this.type.TabIndex = 0;
            this.type.Text = "类型:";
            // 
            // bookRButton
            // 
            this.bookRButton.AutoSize = true;
            this.bookRButton.Location = new System.Drawing.Point(111, 28);
            this.bookRButton.Name = "bookRButton";
            this.bookRButton.Size = new System.Drawing.Size(58, 19);
            this.bookRButton.TabIndex = 1;
            this.bookRButton.TabStop = true;
            this.bookRButton.Text = "图书";
            this.bookRButton.UseVisualStyleBackColor = true;
            this.bookRButton.CheckedChanged += new System.EventHandler(this.bookRButton_CheckedChanged);
            // 
            // CDRButton
            // 
            this.CDRButton.AutoSize = true;
            this.CDRButton.Location = new System.Drawing.Point(185, 28);
            this.CDRButton.Name = "CDRButton";
            this.CDRButton.Size = new System.Drawing.Size(88, 19);
            this.CDRButton.TabIndex = 2;
            this.CDRButton.TabStop = true;
            this.CDRButton.Text = "视频光盘";
            this.CDRButton.UseVisualStyleBackColor = true;
            this.CDRButton.CheckedChanged += new System.EventHandler(this.CDRButton_CheckedChanged);
            // 
            // artRButton
            // 
            this.artRButton.AutoSize = true;
            this.artRButton.Location = new System.Drawing.Point(300, 28);
            this.artRButton.Name = "artRButton";
            this.artRButton.Size = new System.Drawing.Size(58, 19);
            this.artRButton.TabIndex = 3;
            this.artRButton.TabStop = true;
            this.artRButton.Text = "图画";
            this.artRButton.UseVisualStyleBackColor = true;
            this.artRButton.CheckedChanged += new System.EventHandler(this.artRButton_CheckedChanged);
            // 
            // levelBox
            // 
            this.levelBox.Location = new System.Drawing.Point(134, 167);
            this.levelBox.Name = "levelBox";
            this.levelBox.Size = new System.Drawing.Size(235, 25);
            this.levelBox.TabIndex = 28;
            // 
            // level
            // 
            this.level.AutoSize = true;
            this.level.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.level.Location = new System.Drawing.Point(69, 170);
            this.level.Name = "level";
            this.level.Size = new System.Drawing.Size(51, 17);
            this.level.TabIndex = 27;
            this.level.Text = "评级:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(134, 260);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(235, 25);
            this.textBox3.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(34, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 25;
            this.label3.Text = "页数:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(134, 229);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(235, 25);
            this.textBox2.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(35, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 23;
            this.label2.Text = "ISBN号:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(134, 198);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(235, 25);
            this.textBox1.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(34, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "出版社:";
            // 
            // authorBox
            // 
            this.authorBox.Location = new System.Drawing.Point(134, 136);
            this.authorBox.Name = "authorBox";
            this.authorBox.Size = new System.Drawing.Size(235, 25);
            this.authorBox.TabIndex = 20;
            // 
            // author
            // 
            this.author.AutoSize = true;
            this.author.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.author.Location = new System.Drawing.Point(69, 139);
            this.author.Name = "author";
            this.author.Size = new System.Drawing.Size(51, 17);
            this.author.TabIndex = 19;
            this.author.Text = "作者:";
            // 
            // numberBox
            // 
            this.numberBox.Location = new System.Drawing.Point(134, 103);
            this.numberBox.Name = "numberBox";
            this.numberBox.Size = new System.Drawing.Size(235, 25);
            this.numberBox.TabIndex = 18;
            // 
            // number
            // 
            this.number.AutoSize = true;
            this.number.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.number.Location = new System.Drawing.Point(69, 107);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(51, 17);
            this.number.TabIndex = 17;
            this.number.Text = "编号:";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(134, 72);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(235, 25);
            this.nameBox.TabIndex = 16;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.name.Location = new System.Drawing.Point(69, 75);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(51, 17);
            this.name.TabIndex = 15;
            this.name.Text = "标题:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(145, 317);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 39);
            this.button1.TabIndex = 29;
            this.button1.Text = "添加";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // addaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 385);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.levelBox);
            this.Controls.Add(this.level);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.authorBox);
            this.Controls.Add(this.author);
            this.Controls.Add(this.numberBox);
            this.Controls.Add(this.number);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.name);
            this.Controls.Add(this.artRButton);
            this.Controls.Add(this.CDRButton);
            this.Controls.Add(this.bookRButton);
            this.Controls.Add(this.type);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "addaction";
            this.Text = "库存添加";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label type;
        private System.Windows.Forms.RadioButton bookRButton;
        private System.Windows.Forms.RadioButton CDRButton;
        private System.Windows.Forms.RadioButton artRButton;
        private System.Windows.Forms.TextBox levelBox;
        private System.Windows.Forms.Label level;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox authorBox;
        private System.Windows.Forms.Label author;
        private System.Windows.Forms.TextBox numberBox;
        private System.Windows.Forms.Label number;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Button button1;
    }
}