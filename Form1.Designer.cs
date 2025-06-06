namespace zd1Shop_Rogov
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
            comboBoxName = new ComboBox();
            label1 = new Label();
            countProducts = new NumericUpDown();
            label2 = new Label();
            buy = new Button();
            label3 = new Label();
            wallet = new Label();
            listProducts = new ListBox();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            labelProfit = new Label();
            label4 = new Label();
            tabPage2 = new TabPage();
            buttonClear = new Button();
            buttonPerehod = new Button();
            numericPerehod = new NumericUpDown();
            buttonDeleteName = new Button();
            textBoxDeleteName = new TextBox();
            buttonDelete = new Button();
            numericDelete = new NumericUpDown();
            label7 = new Label();
            listMusic = new ListBox();
            label6 = new Label();
            label5 = new Label();
            textBoxTitle = new TextBox();
            textBoxAuthor = new TextBox();
            buttonToFinish = new Button();
            buttonToStart = new Button();
            buttonAddIndex = new Button();
            numericAdd = new NumericUpDown();
            buttonAdd = new Button();
            textBoxPath = new TextBox();
            buttonRight = new Button();
            buttonLeft = new Button();
            ((System.ComponentModel.ISupportInitialize)countProducts).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericPerehod).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericDelete).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericAdd).BeginInit();
            SuspendLayout();
            // 
            // comboBoxName
            // 
            comboBoxName.FormattingEnabled = true;
            comboBoxName.Location = new Point(8, 40);
            comboBoxName.Margin = new Padding(5);
            comboBoxName.Name = "comboBoxName";
            comboBoxName.Size = new Size(277, 39);
            comboBoxName.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 10);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(193, 32);
            label1.TabIndex = 3;
            label1.Text = "Выберите товар";
            // 
            // countProducts
            // 
            countProducts.Location = new Point(8, 117);
            countProducts.Margin = new Padding(5);
            countProducts.Name = "countProducts";
            countProducts.Size = new Size(280, 39);
            countProducts.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 87);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(258, 32);
            label2.TabIndex = 5;
            label2.Text = "Выберите количество";
            // 
            // buy
            // 
            buy.Location = new Point(329, 40);
            buy.Margin = new Padding(5);
            buy.Name = "buy";
            buy.Size = new Size(112, 116);
            buy.TabIndex = 6;
            buy.Text = "Купить";
            buy.UseVisualStyleBackColor = true;
            buy.Click += buy_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(776, 34);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(112, 32);
            label3.TabIndex = 7;
            label3.Text = "Кошелек";
            // 
            // wallet
            // 
            wallet.AutoSize = true;
            wallet.Location = new Point(776, 64);
            wallet.Margin = new Padding(5, 0, 5, 0);
            wallet.Name = "wallet";
            wallet.Size = new Size(113, 32);
            wallet.TabIndex = 8;
            wallet.Text = "1000 руб";
            // 
            // listProducts
            // 
            listProducts.FormattingEnabled = true;
            listProducts.ItemHeight = 31;
            listProducts.Location = new Point(-4, 193);
            listProducts.Name = "listProducts";
            listProducts.SelectionMode = SelectionMode.None;
            listProducts.Size = new Size(1008, 314);
            listProducts.TabIndex = 10;
            listProducts.Visible = false;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(-2, 1);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1012, 564);
            tabControl1.TabIndex = 11;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(labelProfit);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(listProducts);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(wallet);
            tabPage1.Controls.Add(comboBoxName);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(buy);
            tabPage1.Controls.Add(countProducts);
            tabPage1.Controls.Add(label2);
            tabPage1.Location = new Point(4, 40);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1004, 520);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Задание 2";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // labelProfit
            // 
            labelProfit.AutoSize = true;
            labelProfit.Location = new Point(776, 134);
            labelProfit.Margin = new Padding(5, 0, 5, 0);
            labelProfit.Name = "labelProfit";
            labelProfit.Size = new Size(74, 32);
            labelProfit.TabIndex = 12;
            labelProfit.Text = "0 руб";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(776, 104);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(223, 32);
            label4.TabIndex = 11;
            label4.Text = "Прибыль магазина";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(buttonClear);
            tabPage2.Controls.Add(buttonPerehod);
            tabPage2.Controls.Add(numericPerehod);
            tabPage2.Controls.Add(buttonDeleteName);
            tabPage2.Controls.Add(textBoxDeleteName);
            tabPage2.Controls.Add(buttonDelete);
            tabPage2.Controls.Add(numericDelete);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(listMusic);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(textBoxTitle);
            tabPage2.Controls.Add(textBoxAuthor);
            tabPage2.Controls.Add(buttonToFinish);
            tabPage2.Controls.Add(buttonToStart);
            tabPage2.Controls.Add(buttonAddIndex);
            tabPage2.Controls.Add(numericAdd);
            tabPage2.Controls.Add(buttonAdd);
            tabPage2.Controls.Add(textBoxPath);
            tabPage2.Controls.Add(buttonRight);
            tabPage2.Controls.Add(buttonLeft);
            tabPage2.Location = new Point(4, 40);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1004, 520);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Задание 3";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // buttonClear
            // 
            buttonClear.Location = new Point(179, 243);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(151, 39);
            buttonClear.TabIndex = 25;
            buttonClear.Text = "Очистить";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // buttonPerehod
            // 
            buttonPerehod.Font = new Font("Segoe UI", 12F);
            buttonPerehod.Location = new Point(6, 406);
            buttonPerehod.Name = "buttonPerehod";
            buttonPerehod.Size = new Size(150, 39);
            buttonPerehod.TabIndex = 24;
            buttonPerehod.Text = "Перейти к";
            buttonPerehod.UseVisualStyleBackColor = true;
            buttonPerehod.Click += buttonPerehod_Click;
            // 
            // numericPerehod
            // 
            numericPerehod.Location = new Point(8, 361);
            numericPerehod.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericPerehod.Name = "numericPerehod";
            numericPerehod.Size = new Size(150, 39);
            numericPerehod.TabIndex = 23;
            numericPerehod.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // buttonDeleteName
            // 
            buttonDeleteName.Font = new Font("Segoe UI", 12F);
            buttonDeleteName.Location = new Point(178, 173);
            buttonDeleteName.Name = "buttonDeleteName";
            buttonDeleteName.Size = new Size(150, 39);
            buttonDeleteName.TabIndex = 21;
            buttonDeleteName.Text = "По названию";
            buttonDeleteName.UseVisualStyleBackColor = true;
            buttonDeleteName.Click += buttonDeleteName_Click;
            // 
            // textBoxDeleteName
            // 
            textBoxDeleteName.Location = new Point(178, 128);
            textBoxDeleteName.Name = "textBoxDeleteName";
            textBoxDeleteName.PlaceholderText = "Название";
            textBoxDeleteName.Size = new Size(151, 39);
            textBoxDeleteName.TabIndex = 20;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(179, 83);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(150, 39);
            buttonDelete.TabIndex = 19;
            buttonDelete.Text = "По индексу";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // numericDelete
            // 
            numericDelete.Location = new Point(179, 38);
            numericDelete.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericDelete.Name = "numericDelete";
            numericDelete.Size = new Size(150, 39);
            numericDelete.TabIndex = 18;
            numericDelete.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(179, 3);
            label7.Name = "label7";
            label7.Size = new Size(120, 32);
            label7.TabIndex = 17;
            label7.Text = "Удаление";
            // 
            // listMusic
            // 
            listMusic.Font = new Font("Segoe UI", 10F);
            listMusic.FormattingEnabled = true;
            listMusic.ItemHeight = 23;
            listMusic.Location = new Point(345, 38);
            listMusic.Name = "listMusic";
            listMusic.Size = new Size(645, 349);
            listMusic.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(7, 3);
            label6.Name = "label6";
            label6.Size = new Size(151, 32);
            label6.TabIndex = 15;
            label6.Text = "Добавление";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F);
            label5.Location = new Point(0, 170);
            label5.Name = "label5";
            label5.Size = new Size(163, 25);
            label5.TabIndex = 14;
            label5.Text = "В какую позицию";
            // 
            // textBoxTitle
            // 
            textBoxTitle.Location = new Point(7, 38);
            textBoxTitle.Name = "textBoxTitle";
            textBoxTitle.PlaceholderText = "Название";
            textBoxTitle.Size = new Size(151, 39);
            textBoxTitle.TabIndex = 13;
            // 
            // textBoxAuthor
            // 
            textBoxAuthor.Location = new Point(6, 83);
            textBoxAuthor.Name = "textBoxAuthor";
            textBoxAuthor.PlaceholderText = "Автор";
            textBoxAuthor.Size = new Size(151, 39);
            textBoxAuthor.TabIndex = 12;
            // 
            // buttonToFinish
            // 
            buttonToFinish.Location = new Point(795, 406);
            buttonToFinish.Name = "buttonToFinish";
            buttonToFinish.Size = new Size(75, 60);
            buttonToFinish.TabIndex = 11;
            buttonToFinish.Text = ">|";
            buttonToFinish.UseVisualStyleBackColor = true;
            buttonToFinish.Click += buttonToFinish_Click;
            // 
            // buttonToStart
            // 
            buttonToStart.Location = new Point(452, 406);
            buttonToStart.Name = "buttonToStart";
            buttonToStart.Size = new Size(75, 60);
            buttonToStart.TabIndex = 10;
            buttonToStart.Text = "|<";
            buttonToStart.UseVisualStyleBackColor = true;
            buttonToStart.Click += buttonToStart_Click;
            // 
            // buttonAddIndex
            // 
            buttonAddIndex.Location = new Point(6, 288);
            buttonAddIndex.Name = "buttonAddIndex";
            buttonAddIndex.Size = new Size(150, 39);
            buttonAddIndex.TabIndex = 9;
            buttonAddIndex.Text = "По индексу";
            buttonAddIndex.UseVisualStyleBackColor = true;
            buttonAddIndex.Click += buttonAddIndex_Click;
            // 
            // numericAdd
            // 
            numericAdd.Location = new Point(6, 198);
            numericAdd.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericAdd.Name = "numericAdd";
            numericAdd.Size = new Size(150, 39);
            numericAdd.TabIndex = 8;
            numericAdd.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(7, 243);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(151, 39);
            buttonAdd.TabIndex = 7;
            buttonAdd.Text = "Добавить";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // textBoxPath
            // 
            textBoxPath.Location = new Point(7, 128);
            textBoxPath.Name = "textBoxPath";
            textBoxPath.PlaceholderText = "Путь";
            textBoxPath.Size = new Size(151, 39);
            textBoxPath.TabIndex = 6;
            // 
            // buttonRight
            // 
            buttonRight.Location = new Point(705, 406);
            buttonRight.Name = "buttonRight";
            buttonRight.Size = new Size(75, 60);
            buttonRight.TabIndex = 1;
            buttonRight.Text = ">";
            buttonRight.UseVisualStyleBackColor = true;
            buttonRight.Click += buttonRight_Click;
            // 
            // buttonLeft
            // 
            buttonLeft.Location = new Point(542, 406);
            buttonLeft.Name = "buttonLeft";
            buttonLeft.Size = new Size(75, 60);
            buttonLeft.TabIndex = 0;
            buttonLeft.Text = "<";
            buttonLeft.UseVisualStyleBackColor = true;
            buttonLeft.Click += buttonLeft_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1004, 559);
            Controls.Add(tabControl1);
            Font = new Font("Segoe UI", 14F);
            Margin = new Padding(5);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)countProducts).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericPerehod).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericDelete).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericAdd).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown countProducts;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label wallet;
        private System.Windows.Forms.ListBox listProducts;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private Label labelProfit;
        private Label label4;
        private Button buttonRight;
        private Button buttonLeft;
        private Button buttonAddIndex;
        private NumericUpDown numericAdd;
        private Button buttonAdd;
        private TextBox textBoxPath;
        private Label label6;
        private Label label5;
        private TextBox textBoxTitle;
        private TextBox textBoxAuthor;
        private Button buttonToFinish;
        private Button buttonToStart;
        private ListBox listMusic;
        private Button buttonDeleteName;
        private TextBox textBoxDeleteName;
        private Button buttonDelete;
        private NumericUpDown numericDelete;
        private Label label7;
        private Button buttonClear;
        private Button buttonPerehod;
        private NumericUpDown numericPerehod;
    }
}
