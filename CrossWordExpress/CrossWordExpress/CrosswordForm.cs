using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CrossWordExpress
{
    public partial class CrosswordForm : Form
    {
        int countX; int countY; int countQ;
        public string[,] crosswordChar;
        Bitmap b, c;

        public CrosswordForm()
        {
            InitializeComponent();

            b = new Bitmap(LeftPanel.ClientRectangle.Width, LeftPanel.ClientRectangle.Height);
            c = new Bitmap(QuestionListView.ClientRectangle.Width, QuestionListView.ClientRectangle.Height);
        }

        private void CrosswordForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void OpenToolStripButton_Click(object sender, EventArgs e)
        {
                try
                {
                    OpenFileDialog _dialog = new OpenFileDialog();
                    _dialog.Filter = "Файл кроссворда (*.crs)|*.crs";
                    _dialog.ShowDialog();
                    var reader = new StreamReader(_dialog.FileName, true);
                    if (QuestionListView.Items.Count != 0)
                    {
                        QuestionListView.Items.Clear();
                        Grid.KillTB(countX, countY);
                    }
                    string secondLine = File.ReadLines(_dialog.FileName).First();
                    if (secondLine.Length < 9)
                    {
                        countX = Convert.ToInt32(secondLine.Substring(0, 2));
                        countY = Convert.ToInt32(secondLine.Substring(3, 2));
                        countQ = Convert.ToInt32(secondLine.Substring(6, 2));
                    }
                    if (secondLine.Length > 9 && secondLine.Length <= 11)
                    {
                        countX = Convert.ToInt32(secondLine.Substring(0, 3));
                        countY = Convert.ToInt32(secondLine.Substring(4, 3));
                        countQ = Convert.ToInt32(secondLine.Substring(7, 3));
                    }
                    Grid.Create(LeftPanel, countX, countY);
                    crosswordChar = new string[countX, countY];
                    string[] lines = File.ReadAllLines(_dialog.FileName).Skip(1).Take(countX).ToArray();
                    Regex Nums = new Regex(@"^\d+$");
                    for (int i = 0; i < countX; i++)
                    {
                        string[] znach = lines[i].Split(new char[] { ' ' });
                        for (int j = 0; j < countY; j++)
                        {
                            crosswordChar[i, j] = znach[j].Replace("*", "");
                            if (znach[j].Replace("*", "") != "")
                            {
                                if (Nums.IsMatch(znach[j].Replace("*", "")))
                                    Grid.tbArray[i, j].Text = znach[j].Replace("*", "");
                                else
                                    Grid.tbArray[i, j].Enabled = true;
                            }
                        }
                    }
                    string[] question = File.ReadAllLines(_dialog.FileName).Skip(1 + countX).Take(countQ).ToArray();
                    for (int i = 0; i < countQ; i++)
                    {
                        QuestionListView.Items.Add(question[i]);
                    }

                }
                catch (Exception)
                { return; }
        }

        private void CheckButton_Click(object sender, EventArgs e)
        {
            int checkPoint = 0;
            for (int i = 0; i < countX; i++)
            {
                for(int j = 0 ; j < countY ; j++)
                {
                    if (crosswordChar[i, j] != Grid.tbArray[i, j].Text)
                        checkPoint++;
                }
            }
            if(checkPoint>0)
            {
                MessageBox.Show("Ответ не верный. Попробуйте другой вариант подстановки", "Не верный ответ", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }
            else
            {
                MessageBox.Show("Абсолютно верно! Вы победили!", "Оповещение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                QuestionListView.Items.Clear();
                Grid.KillTB(countX, countY);
            }
        }

        private void вернутьсяКРедакторуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainForm form = new MainForm();
            Hide(); form.Show();
        }

        private void оРазработчикеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Other.AboutAuthor();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Other.Help();
        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            LeftPanel.DrawToBitmap(b, LeftPanel.ClientRectangle);
            QuestionListView.DrawToBitmap(c, QuestionListView.ClientRectangle);

            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
                printDocument1.Print();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle rect, rect2;
            int pbWidth = e.MarginBounds.Width;
            int pbHeight = e.MarginBounds.Height;
            int pcWidth = e.MarginBounds.Width;
            int pcHeight = e.MarginBounds.Height;
            int ImageWidth1 = b.Width; int ImageHeight1 = b.Height;
            int ImageWidth2 = c.Width; int ImageHeight2 = c.Height;

            SizeF sizef = new SizeF(ImageWidth1 / b.HorizontalResolution, ImageHeight1 / b.VerticalResolution);
            float fSeale = Math.Min(pbWidth / sizef.Width, pbHeight / sizef.Height);
            sizef.Width *= fSeale;
            sizef.Height *= fSeale;
            Size size = Size.Ceiling(sizef);
            rect = new Rectangle(e.MarginBounds.Location.X, e.MarginBounds.Location.Y, size.Width, size.Height);
            g.DrawImage(b, rect);

            SizeF sizef2 = new SizeF(ImageWidth2 / c.HorizontalResolution, ImageHeight2 / c.VerticalResolution);
            float fSeale2 = Math.Min(pcWidth / sizef2.Width, pcHeight / sizef2.Height);
            sizef2.Width *= fSeale2;
            sizef2.Height *= fSeale2;
            Size size2 = Size.Ceiling(sizef2);
            rect2 = new Rectangle(e.MarginBounds.Location.X, e.MarginBounds.Location.Y + 550, size2.Width, size2.Height);
            g.DrawImage(c, rect2);
        }

        private void CrosswordForm_Load(object sender, EventArgs e)
        {

        }
    }
}
