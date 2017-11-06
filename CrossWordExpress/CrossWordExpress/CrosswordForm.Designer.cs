namespace CrossWordExpress
{
    partial class CrosswordForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrosswordForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.OpenToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.CheckToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.PrintButton = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьКроссвордToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.проверитьКроссвордToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редакторToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вернутьсяКРедакторуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.помощьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оРазработчикеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FooterPanel = new System.Windows.Forms.Panel();
            this.AuthorPanel = new System.Windows.Forms.Label();
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.RightPanel = new System.Windows.Forms.Panel();
            this.CheckButton = new System.Windows.Forms.Button();
            this.QuestionListView = new System.Windows.Forms.ListView();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.FooterPanel.SuspendLayout();
            this.RightPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenToolStripButton,
            this.toolStripSeparator2,
            this.CheckToolStripButton,
            this.toolStripSeparator1,
            this.PrintButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(998, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // OpenToolStripButton
            // 
            this.OpenToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.OpenToolStripButton.Image = global::CrossWordExpress.Properties.Resources._1493902157_icon_folder;
            this.OpenToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OpenToolStripButton.Name = "OpenToolStripButton";
            this.OpenToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.OpenToolStripButton.Text = "Открыть кроссворд";
            this.OpenToolStripButton.Click += new System.EventHandler(this.OpenToolStripButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // CheckToolStripButton
            // 
            this.CheckToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CheckToolStripButton.Image = global::CrossWordExpress.Properties.Resources._1496634376_files_folders_44;
            this.CheckToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CheckToolStripButton.Name = "CheckToolStripButton";
            this.CheckToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.CheckToolStripButton.Text = "Проверить Кроссворд";
            this.CheckToolStripButton.Click += new System.EventHandler(this.CheckButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // PrintButton
            // 
            this.PrintButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.PrintButton.Image = global::CrossWordExpress.Properties.Resources.if_print_172530;
            this.PrintButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.Size = new System.Drawing.Size(23, 22);
            this.PrintButton.Text = "toolStripButton1";
            this.PrintButton.Click += new System.EventHandler(this.PrintButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.редакторToolStripMenuItem,
            this.помощьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(998, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьКроссвордToolStripMenuItem,
            this.проверитьКроссвордToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьКроссвордToolStripMenuItem
            // 
            this.открытьКроссвордToolStripMenuItem.Image = global::CrossWordExpress.Properties.Resources._1493902157_icon_folder;
            this.открытьКроссвордToolStripMenuItem.Name = "открытьКроссвордToolStripMenuItem";
            this.открытьКроссвордToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.открытьКроссвордToolStripMenuItem.Text = "Открыть кроссворд";
            this.открытьКроссвордToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripButton_Click);
            // 
            // проверитьКроссвордToolStripMenuItem
            // 
            this.проверитьКроссвордToolStripMenuItem.Image = global::CrossWordExpress.Properties.Resources._1496634376_files_folders_44;
            this.проверитьКроссвордToolStripMenuItem.Name = "проверитьКроссвордToolStripMenuItem";
            this.проверитьКроссвордToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.проверитьКроссвордToolStripMenuItem.Text = "Проверить кроссворд";
            this.проверитьКроссвордToolStripMenuItem.Click += new System.EventHandler(this.CheckButton_Click);
            // 
            // редакторToolStripMenuItem
            // 
            this.редакторToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.вернутьсяКРедакторуToolStripMenuItem});
            this.редакторToolStripMenuItem.Name = "редакторToolStripMenuItem";
            this.редакторToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.редакторToolStripMenuItem.Text = "Редактор";
            // 
            // вернутьсяКРедакторуToolStripMenuItem
            // 
            this.вернутьсяКРедакторуToolStripMenuItem.Image = global::CrossWordExpress.Properties.Resources._1496761768_back_alt;
            this.вернутьсяКРедакторуToolStripMenuItem.Name = "вернутьсяКРедакторуToolStripMenuItem";
            this.вернутьсяКРедакторуToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.вернутьсяКРедакторуToolStripMenuItem.Text = "Вернуться к редактору";
            this.вернутьсяКРедакторуToolStripMenuItem.Click += new System.EventHandler(this.вернутьсяКРедакторуToolStripMenuItem_Click);
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
            // FooterPanel
            // 
            this.FooterPanel.Controls.Add(this.AuthorPanel);
            this.FooterPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.FooterPanel.Location = new System.Drawing.Point(0, 625);
            this.FooterPanel.Name = "FooterPanel";
            this.FooterPanel.Size = new System.Drawing.Size(998, 24);
            this.FooterPanel.TabIndex = 4;
            // 
            // AuthorPanel
            // 
            this.AuthorPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AuthorPanel.Location = new System.Drawing.Point(868, 0);
            this.AuthorPanel.Name = "AuthorPanel";
            this.AuthorPanel.Size = new System.Drawing.Size(130, 24);
            this.AuthorPanel.TabIndex = 1;
            this.AuthorPanel.Text = "Created by BelarusNoob";
            this.AuthorPanel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LeftPanel
            // 
            this.LeftPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LeftPanel.AutoScroll = true;
            this.LeftPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LeftPanel.Cursor = System.Windows.Forms.Cursors.Default;
            this.LeftPanel.Location = new System.Drawing.Point(0, 49);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(630, 576);
            this.LeftPanel.TabIndex = 5;
            // 
            // RightPanel
            // 
            this.RightPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RightPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RightPanel.Controls.Add(this.CheckButton);
            this.RightPanel.Controls.Add(this.QuestionListView);
            this.RightPanel.Location = new System.Drawing.Point(632, 49);
            this.RightPanel.Name = "RightPanel";
            this.RightPanel.Size = new System.Drawing.Size(366, 576);
            this.RightPanel.TabIndex = 6;
            // 
            // CheckButton
            // 
            this.CheckButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CheckButton.Location = new System.Drawing.Point(3, 547);
            this.CheckButton.Name = "CheckButton";
            this.CheckButton.Size = new System.Drawing.Size(358, 23);
            this.CheckButton.TabIndex = 1;
            this.CheckButton.Text = "Проверить правильность кроссворда";
            this.CheckButton.UseVisualStyleBackColor = true;
            this.CheckButton.Click += new System.EventHandler(this.CheckButton_Click);
            // 
            // QuestionListView
            // 
            this.QuestionListView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.QuestionListView.Location = new System.Drawing.Point(3, 3);
            this.QuestionListView.Name = "QuestionListView";
            this.QuestionListView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.QuestionListView.ShowGroups = false;
            this.QuestionListView.Size = new System.Drawing.Size(358, 540);
            this.QuestionListView.TabIndex = 0;
            this.QuestionListView.UseCompatibleStateImageBehavior = false;
            this.QuestionListView.View = System.Windows.Forms.View.List;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // CrosswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 649);
            this.Controls.Add(this.RightPanel);
            this.Controls.Add(this.LeftPanel);
            this.Controls.Add(this.FooterPanel);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CrosswordForm";
            this.Text = "CrossWordExpress";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CrosswordForm_FormClosing);
            this.Load += new System.EventHandler(this.CrosswordForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.FooterPanel.ResumeLayout(false);
            this.RightPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel FooterPanel;
        private System.Windows.Forms.Label AuthorPanel;
        private System.Windows.Forms.Panel LeftPanel;
        private System.Windows.Forms.Panel RightPanel;
        private System.Windows.Forms.ToolStripButton OpenToolStripButton;
        private System.Windows.Forms.ToolStripButton CheckToolStripButton;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьКроссвордToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem проверитьКроссвордToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem помощьToolStripMenuItem;
        private System.Windows.Forms.Button CheckButton;
        private System.Windows.Forms.ListView QuestionListView;
        private System.Windows.Forms.ToolStripMenuItem редакторToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вернутьсяКРедакторуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оРазработчикеToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton PrintButton;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}