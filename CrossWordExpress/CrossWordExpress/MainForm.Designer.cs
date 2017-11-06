namespace CrossWordExpress
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.header = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.кроссвордToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.помощьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.footer = new System.Windows.Forms.Panel();
            this.VersionLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.AddWordBtn = new System.Windows.Forms.Button();
            this.newWordTextBox = new System.Windows.Forms.TextBox();
            this.WordList = new System.Windows.Forms.ListView();
            this.notUsedListView = new System.Windows.Forms.ListView();
            this.vWordsListView = new System.Windows.Forms.ListView();
            this.hWordsListView = new System.Windows.Forms.ListView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.WordsLabel = new System.Windows.Forms.Label();
            this.MidlePanel = new System.Windows.Forms.Panel();
            this.rightPanel = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.Qbutton = new System.Windows.Forms.Button();
            this.QtextBox = new System.Windows.Forms.TextBox();
            this.QuestionList = new System.Windows.Forms.ListView();
            this.NewToolbtn = new System.Windows.Forms.ToolStripButton();
            this.SaveToolbtn = new System.Windows.Forms.ToolStripButton();
            this.AddFileToolbtn = new System.Windows.Forms.ToolStripButton();
            this.GenerateCrosswordToolbtn = new System.Windows.Forms.ToolStripButton();
            this.создатьКроссвордToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.разгадатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оРазработчикеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.header.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.footer.SuspendLayout();
            this.leftPanel.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.SystemColors.ControlDark;
            this.header.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.header.Controls.Add(this.toolStrip1);
            this.header.Controls.Add(this.menuStrip1);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(1095, 51);
            this.header.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewToolbtn,
            this.SaveToolbtn,
            this.toolStripSeparator1,
            this.AddFileToolbtn,
            this.GenerateCrosswordToolbtn,
            this.toolStripSeparator2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1093, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.кроссвордToolStripMenuItem,
            this.помощьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1093, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьКроссвордToolStripMenuItem,
            this.сохранитьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // кроссвордToolStripMenuItem
            // 
            this.кроссвордToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.разгадатьToolStripMenuItem});
            this.кроссвордToolStripMenuItem.Name = "кроссвордToolStripMenuItem";
            this.кроссвордToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.кроссвордToolStripMenuItem.Text = "Кроссворд";
            // 
            // помощьToolStripMenuItem
            // 
            this.помощьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem,
            this.оРазработчикеToolStripMenuItem});
            this.помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
            this.помощьToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.помощьToolStripMenuItem.Text = "Помощь";
            // 
            // footer
            // 
            this.footer.BackColor = System.Drawing.SystemColors.Control;
            this.footer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.footer.Controls.Add(this.VersionLabel);
            this.footer.Controls.Add(this.label4);
            this.footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.footer.Location = new System.Drawing.Point(0, 625);
            this.footer.Name = "footer";
            this.footer.Size = new System.Drawing.Size(1095, 24);
            this.footer.TabIndex = 1;
            // 
            // VersionLabel
            // 
            this.VersionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.VersionLabel.Location = new System.Drawing.Point(3, -1);
            this.VersionLabel.Name = "VersionLabel";
            this.VersionLabel.Size = new System.Drawing.Size(130, 24);
            this.VersionLabel.TabIndex = 1;
            this.VersionLabel.Text = "CrossWordExpress v 1.0";
            this.VersionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Location = new System.Drawing.Point(960, -2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "Created by BelarusNoob";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // leftPanel
            // 
            this.leftPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.leftPanel.Controls.Add(this.AddWordBtn);
            this.leftPanel.Controls.Add(this.newWordTextBox);
            this.leftPanel.Controls.Add(this.WordList);
            this.leftPanel.Controls.Add(this.notUsedListView);
            this.leftPanel.Controls.Add(this.vWordsListView);
            this.leftPanel.Controls.Add(this.hWordsListView);
            this.leftPanel.Controls.Add(this.label3);
            this.leftPanel.Controls.Add(this.label2);
            this.leftPanel.Controls.Add(this.label1);
            this.leftPanel.Controls.Add(this.WordsLabel);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 51);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(315, 574);
            this.leftPanel.TabIndex = 2;
            // 
            // AddWordBtn
            // 
            this.AddWordBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddWordBtn.Location = new System.Drawing.Point(6, 541);
            this.AddWordBtn.Name = "AddWordBtn";
            this.AddWordBtn.Size = new System.Drawing.Size(146, 23);
            this.AddWordBtn.TabIndex = 2;
            this.AddWordBtn.Text = "Добавить слово";
            this.AddWordBtn.UseVisualStyleBackColor = true;
            this.AddWordBtn.Click += new System.EventHandler(this.AddWordBtn_Click);
            // 
            // newWordTextBox
            // 
            this.newWordTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.newWordTextBox.Location = new System.Drawing.Point(6, 515);
            this.newWordTextBox.Name = "newWordTextBox";
            this.newWordTextBox.Size = new System.Drawing.Size(146, 20);
            this.newWordTextBox.TabIndex = 1;
            // 
            // WordList
            // 
            this.WordList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.WordList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.WordList.Location = new System.Drawing.Point(6, 27);
            this.WordList.Name = "WordList";
            this.WordList.Size = new System.Drawing.Size(146, 482);
            this.WordList.TabIndex = 0;
            this.WordList.UseCompatibleStateImageBehavior = false;
            this.WordList.View = System.Windows.Forms.View.Tile;
            // 
            // notUsedListView
            // 
            this.notUsedListView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.notUsedListView.Location = new System.Drawing.Point(158, 430);
            this.notUsedListView.Name = "notUsedListView";
            this.notUsedListView.Size = new System.Drawing.Size(146, 138);
            this.notUsedListView.TabIndex = 0;
            this.notUsedListView.UseCompatibleStateImageBehavior = false;
            this.notUsedListView.View = System.Windows.Forms.View.Tile;
            // 
            // vWordsListView
            // 
            this.vWordsListView.Location = new System.Drawing.Point(158, 228);
            this.vWordsListView.Name = "vWordsListView";
            this.vWordsListView.Size = new System.Drawing.Size(146, 173);
            this.vWordsListView.TabIndex = 0;
            this.vWordsListView.UseCompatibleStateImageBehavior = false;
            this.vWordsListView.View = System.Windows.Forms.View.Tile;
            // 
            // hWordsListView
            // 
            this.hWordsListView.Location = new System.Drawing.Point(158, 27);
            this.hWordsListView.Name = "hWordsListView";
            this.hWordsListView.Size = new System.Drawing.Size(146, 172);
            this.hWordsListView.TabIndex = 0;
            this.hWordsListView.UseCompatibleStateImageBehavior = false;
            this.hWordsListView.View = System.Windows.Forms.View.Tile;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(155, 404);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "Не использованные:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(155, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "По вертикали:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(155, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "По горизонтали:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WordsLabel
            // 
            this.WordsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WordsLabel.Location = new System.Drawing.Point(3, 0);
            this.WordsLabel.Name = "WordsLabel";
            this.WordsLabel.Size = new System.Drawing.Size(143, 23);
            this.WordsLabel.TabIndex = 1;
            this.WordsLabel.Text = "Слова для кроссворда:";
            this.WordsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MidlePanel
            // 
            this.MidlePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MidlePanel.AutoScroll = true;
            this.MidlePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MidlePanel.Location = new System.Drawing.Point(312, 51);
            this.MidlePanel.Name = "MidlePanel";
            this.MidlePanel.Size = new System.Drawing.Size(507, 574);
            this.MidlePanel.TabIndex = 3;
            // 
            // rightPanel
            // 
            this.rightPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rightPanel.Controls.Add(this.label5);
            this.rightPanel.Controls.Add(this.Qbutton);
            this.rightPanel.Controls.Add(this.QtextBox);
            this.rightPanel.Controls.Add(this.QuestionList);
            this.rightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.rightPanel.Location = new System.Drawing.Point(817, 51);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(278, 574);
            this.rightPanel.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(0, 1);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(271, 23);
            this.label5.TabIndex = 6;
            this.label5.Text = "Вопросы к кроссворду:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Qbutton
            // 
            this.Qbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Qbutton.Location = new System.Drawing.Point(3, 545);
            this.Qbutton.Name = "Qbutton";
            this.Qbutton.Size = new System.Drawing.Size(271, 23);
            this.Qbutton.TabIndex = 4;
            this.Qbutton.Text = "Добавить вопрос";
            this.Qbutton.UseVisualStyleBackColor = true;
            this.Qbutton.Click += new System.EventHandler(this.Qbutton_Click);
            // 
            // QtextBox
            // 
            this.QtextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.QtextBox.Location = new System.Drawing.Point(3, 519);
            this.QtextBox.Name = "QtextBox";
            this.QtextBox.Size = new System.Drawing.Size(271, 20);
            this.QtextBox.TabIndex = 3;
            // 
            // QuestionList
            // 
            this.QuestionList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.QuestionList.Location = new System.Drawing.Point(3, 27);
            this.QuestionList.Name = "QuestionList";
            this.QuestionList.Size = new System.Drawing.Size(274, 486);
            this.QuestionList.TabIndex = 2;
            this.QuestionList.TileSize = new System.Drawing.Size(500, 30);
            this.QuestionList.UseCompatibleStateImageBehavior = false;
            this.QuestionList.View = System.Windows.Forms.View.Tile;
            // 
            // NewToolbtn
            // 
            this.NewToolbtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.NewToolbtn.Image = global::CrossWordExpress.Properties.Resources._1493902105_add_circle_outline;
            this.NewToolbtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NewToolbtn.Name = "NewToolbtn";
            this.NewToolbtn.Size = new System.Drawing.Size(23, 22);
            this.NewToolbtn.Text = "Создать новый";
            this.NewToolbtn.Click += new System.EventHandler(this.NewToolbtn_Click);
            // 
            // SaveToolbtn
            // 
            this.SaveToolbtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SaveToolbtn.Image = global::CrossWordExpress.Properties.Resources._1493087841_BT_save;
            this.SaveToolbtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveToolbtn.Name = "SaveToolbtn";
            this.SaveToolbtn.Size = new System.Drawing.Size(23, 22);
            this.SaveToolbtn.Text = "Сохранить кроссворд";
            this.SaveToolbtn.Click += new System.EventHandler(this.SaveToolbtn_Click);
            // 
            // AddFileToolbtn
            // 
            this.AddFileToolbtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AddFileToolbtn.Image = global::CrossWordExpress.Properties.Resources._1493904069_document_text_add;
            this.AddFileToolbtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddFileToolbtn.Name = "AddFileToolbtn";
            this.AddFileToolbtn.Size = new System.Drawing.Size(23, 22);
            this.AddFileToolbtn.Text = "Добавить словарь";
            this.AddFileToolbtn.Click += new System.EventHandler(this.AddFileToolbtn_Click);
            // 
            // GenerateCrosswordToolbtn
            // 
            this.GenerateCrosswordToolbtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.GenerateCrosswordToolbtn.Image = global::CrossWordExpress.Properties.Resources.Crossword_512;
            this.GenerateCrosswordToolbtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.GenerateCrosswordToolbtn.Name = "GenerateCrosswordToolbtn";
            this.GenerateCrosswordToolbtn.Size = new System.Drawing.Size(23, 22);
            this.GenerateCrosswordToolbtn.Text = "Сгенерировать кроссворд";
            this.GenerateCrosswordToolbtn.Click += new System.EventHandler(this.GenerateCrosswordToolbtn_Click);
            // 
            // создатьКроссвордToolStripMenuItem
            // 
            this.создатьКроссвордToolStripMenuItem.Image = global::CrossWordExpress.Properties.Resources._1493902105_add_circle_outline;
            this.создатьКроссвордToolStripMenuItem.Name = "создатьКроссвордToolStripMenuItem";
            this.создатьКроссвордToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.создатьКроссвордToolStripMenuItem.Text = "Новый";
            this.создатьКроссвордToolStripMenuItem.Click += new System.EventHandler(this.NewToolbtn_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Image = global::CrossWordExpress.Properties.Resources._1493087841_BT_save;
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.SaveToolbtn_Click);
            // 
            // разгадатьToolStripMenuItem
            // 
            this.разгадатьToolStripMenuItem.Image = global::CrossWordExpress.Properties.Resources._1496635996_play_player_start_button_control_media;
            this.разгадатьToolStripMenuItem.Name = "разгадатьToolStripMenuItem";
            this.разгадатьToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.разгадатьToolStripMenuItem.Text = "Разгадать";
            this.разгадатьToolStripMenuItem.Click += new System.EventHandler(this.разгадатьToolStripMenuItem_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Image = global::CrossWordExpress.Properties.Resources._1493902247_aiga_information;
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // оРазработчикеToolStripMenuItem
            // 
            this.оРазработчикеToolStripMenuItem.Image = global::CrossWordExpress.Properties.Resources._1493902198_user_male2;
            this.оРазработчикеToolStripMenuItem.Name = "оРазработчикеToolStripMenuItem";
            this.оРазработчикеToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.оРазработчикеToolStripMenuItem.Text = "О разработчике";
            this.оРазработчикеToolStripMenuItem.Click += new System.EventHandler(this.оРазработчикеToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 649);
            this.Controls.Add(this.rightPanel);
            this.Controls.Add(this.MidlePanel);
            this.Controls.Add(this.leftPanel);
            this.Controls.Add(this.footer);
            this.Controls.Add(this.header);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "CrossWordExpress";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.footer.ResumeLayout(false);
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            this.rightPanel.ResumeLayout(false);
            this.rightPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.Panel footer;
        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Panel MidlePanel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьКроссвордToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem помощьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оРазработчикеToolStripMenuItem;
        private System.Windows.Forms.Label WordsLabel;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton NewToolbtn;
        private System.Windows.Forms.ToolStripButton SaveToolbtn;
        private System.Windows.Forms.ToolStripButton AddFileToolbtn;
        private System.Windows.Forms.ToolStripButton GenerateCrosswordToolbtn;
        private System.Windows.Forms.ToolStripMenuItem кроссвордToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem разгадатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ListView WordList;
        private System.Windows.Forms.ListView vWordsListView;
        private System.Windows.Forms.ListView hWordsListView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView notUsedListView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AddWordBtn;
        private System.Windows.Forms.TextBox newWordTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel rightPanel;
        private System.Windows.Forms.ListView QuestionList;
        private System.Windows.Forms.Button Qbutton;
        private System.Windows.Forms.TextBox QtextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label VersionLabel;
    }
}

