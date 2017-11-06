using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace CrossWordExpress
{
    public partial class MainForm : Form
    {
        int countX; int countY; int countQ; 
        public string[,] crosswordChar;

        public static int n=30; public static int m=30;
        private readonly List<string> _words = new List<string>();
        private readonly List<string> _question = new List<string>();
        private List<string> _order;
        Random _rand = new Random();

        Crossword.Crossword _board = new Crossword.Crossword(n, m);   
        
        static int Comparer(string a, string b)
        {
            var temp = a.Length.CompareTo(b.Length);
            return temp == 0 ? a.CompareTo(b) : temp;
        }

        void GenerateCrossword()
        {
            hWordsListView.Items.Clear();
            vWordsListView.Items.Clear();
            notUsedListView.Items.Clear();
            _board.Reset();
            Grid.ClearBoard(MidlePanel, n+2, m+2);

            //распределение слов по листам на форме в зависимости от их положения, либо отсутствия в кроссворде
            foreach (var word in _order)
            {
                switch (_board.AddWord(word))
                {
                    case 0:
                        hWordsListView.Items.Add(word); //слова по горизонтали
                        break;
                    case 1:
                        vWordsListView.Items.Add(word); //слова по вертикали
                        break;
                    default:
                        notUsedListView.Items.Add(word); //не использованные слова
                        break;
                }
            }
            Actualize();
        }

        //заполнение сетки на форме символами для кроссворда
        void Actualize()
        {
            var count = _board.N * _board.M;
            var board = _board.GetBoard;
            var p = 0;
            for (var i = 0; i < _board.N; i++)
            {
                for (var j = 0; j < _board.M; j++)
                {
                    var letter = board[i, j] == '*' ? ' ' : board[i, j];
                    if (letter != ' ') count--;
                    if (letter != ' ')
                    {
                        Grid.tbArray[i+1, j+1].Text = letter.ToString();
                        Grid.tbArray[i+1, j+1].Enabled = true;
                    }
                    p++;
                }
            }
            Numeration();
        }

        //сохранение кроссворда в файл
        void SaveCrossword()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Файл кроссворда (*.crs)|*.crs|Все файлы (*.*)|*.*";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                for (int x = 0; x < QuestionList.Items.Count; x++)
                {
                    if (QuestionList.Items[x].Text.Length < 3)
                    {
                        MessageBox.Show("Не все вопросы заполненны, заполните вопросы перед сохранением", "Оповещение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        break;
                    }
                    else
                    {
                        StreamWriter str = new StreamWriter(saveFileDialog.FileName);
                        str.WriteLine((n + 2).ToString() + "X" + (m + 2).ToString() + ":" + QuestionList.Items.Count.ToString());
                        for (var i = 0; i < n + 2; i++)
                        {
                            for (var j = 0; j < m + 2; j++)
                            {
                                if (Grid.tbArray[i, j].Text == "")
                                    str.Write("***" + " ");
                                else
                                {
                                    if (Grid.tbArray[i, j].Text.Length == 2)
                                        str.Write(Grid.tbArray[i, j].Text + "*" + " ");
                                    else if (Grid.tbArray[i, j].Text.Length == 1)
                                        str.Write(Grid.tbArray[i, j].Text + "**" + " ");
                                    else
                                        str.Write(Grid.tbArray[i, j].Text + " ");
                                }
                                if (j == m + 1)
                                    str.WriteLine();
                            }
                        }

                        for (int i = 0; i < QuestionList.Items.Count; i++)
                        {
                            str.WriteLine(QuestionList.Items[i].Text);
                        }
                        str.Close();
                    }
                }
            }
            else
                return;
        }

        //расстановка нумерации кроссворда и вопросов    
        void Numeration ()
        {
            int point = 1;
            for (var i = 1; i < n+1; i++)
            {
                for (var j = 1; j < m+1; j++)
                {
                    if (Grid.tbArray[i - 1, j].Text == "" && Grid.tbArray[i, j].Text != "" && Grid.tbArray[i + 1, j].Text != "")
                    {
                        Grid.tbArray[i - 1, j].Text = point.ToString();
                        QuestionList.Items.Add(point.ToString() + ")");
                        point++;
                    }
                    if (Grid.tbArray[i, j - 1].Text == "" && Grid.tbArray[i, j].Text != "" && Grid.tbArray[i, j + 1].Text != "")
                    {
                        Grid.tbArray[i, j - 1].Text = point.ToString();
                        QuestionList.Items.Add(point.ToString() + ")");
                        point++;
                    }
                }
            }
        }
        
        void GenOrder()
        {
            _order = _words.Where(word => _rand.NextDouble() > 0.3).ToList();;
        }

        public MainForm()
        {    
            InitializeComponent();
        }

        private void AddFileToolbtn_Click(object sender, EventArgs e)
        {           
            try
            {
                OpenFileDialog _dialog = new OpenFileDialog();
                _dialog.Filter = "Text files (*.txt)|*.txt";
                _dialog.ShowDialog();
                    var reader = new StreamReader(_dialog.FileName, true);

                    while (!reader.EndOfStream)
                    {
                        var word = reader.ReadLine().Trim().ToLower();
                        WordList.Items.Add(word);
                        _words.Add(word);
                    }
            }
            catch (Exception)
            { return; }
            newWordTextBox.Focus();         
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //Grid.Create(MidlePanel, n + 2, m + 2);

            // создание кроссворда по умолчанию
            
            try
            {
                var reader = new StreamReader("default.crs", true);
                if (QuestionList.Items.Count != 0)
                {
                    QuestionList.Items.Clear();
                    Grid.KillTB(countX, countY);
                }
                string secondLine = File.ReadLines("default.crs").First();
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
                Grid.Create(MidlePanel, countX, countY);
                crosswordChar = new string[countX, countY];
                string[] lines = File.ReadAllLines("default.crs").Skip(1).Take(countX).ToArray();
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
                            {
                                Grid.tbArray[i, j].Enabled = true;
                                Grid.tbArray[i, j].Text = crosswordChar[i, j];
                            }
                        }
                    }
                }
                string[] question = File.ReadAllLines("default.crs").Skip(1 + countX).Take(countQ).ToArray();
                for (int i = 0; i < countQ; i++)
                {
                    QuestionList.Items.Add(question[i]);
                }

                string[] all = File.ReadAllLines("default.crs").Skip(12 + countX).Take(countQ).ToArray();
                for (int i = 0; i < countQ; i++)
                {
                    WordList.Items.Add(all[i]);
                }

                string[] vertical = File.ReadAllLines("default.crs").Skip(23 + countX).Take(6).ToArray();
                for (int i = 0; i < 6; i++)
                {
                    vWordsListView.Items.Add(all[i]);
                }

                string[] horizontal = File.ReadAllLines("default.crs").Skip(34 + countX).Take(4).ToArray();
                for (int i = 0; i < 4; i++)
                {
                    hWordsListView.Items.Add(all[i]);
                }

            }
            catch (Exception)
            { return; }
            
        }

        private void GenerateCrosswordToolbtn_Click(object sender, EventArgs e)
        {
            if (WordList.Items.Count > 2)
            {
                _words.Sort(Comparer);
                _words.Reverse();
                _order = _words;
                QuestionList.Clear();
                QtextBox.Text = "";
                GenerateCrossword();
            }
            else
            {
                MessageBox.Show("В словаре не достаточно слов", "Оповещение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void AddWordBtn_Click(object sender, EventArgs e)
        {
            var word = newWordTextBox.Text.Trim();
            if (word.Length != 0)
            {

                if (_words.Contains(word))
                {
                    MessageBox.Show("Такое слово уже имеется", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    newWordTextBox.Text = "";
                    return;
                }

                _words.Add(word);
                WordList.Items.Add(word);
            }

            newWordTextBox.Text = "";
            newWordTextBox.Focus();
        }

        private void оРазработчикеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Other.AboutAuthor();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Other.Help();
        }

        private void NewToolbtn_Click(object sender, EventArgs e)
        {
            try
            {
                QuestionList.Items.Clear();
                QtextBox.Text = "";
                newWordTextBox.Text = "";
                Grid.ClearBoard(MidlePanel, n + 2, m + 2);
                WordList.Items.Clear();
                hWordsListView.Items.Clear();
                vWordsListView.Items.Clear();
                notUsedListView.Items.Clear();
                _board.Reset();
                _words.Clear();
                _order.Clear();
                _board.Reset();
                _words.Clear();
                _order.Clear();
                _question.Clear();

            }
            catch
            { return; }
        }

        private void SaveToolbtn_Click(object sender, EventArgs e)
        {
            SaveCrossword();
        }

        private void Qbutton_Click(object sender, EventArgs e)
        {
            for (int i=0;i<QuestionList.Items.Count;i++)
            {
                if (QuestionList.Items[i].Text.Length < 4)
                {
                    var question = QtextBox.Text;
                    if (question.Length >= 2)
                    {
                        if (_question.Contains(question))
                        {
                            MessageBox.Show("Такой вопрос уже имеется", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            QtextBox.Text = "";
                            return;
                        }
                        _question.Add(question);
                        QuestionList.Items[i].Text += " " + question;
                    }
                    QtextBox.Text = "";
                    QtextBox.Focus();
                    break;
                }
            }
        }

        private void разгадатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CrosswordForm form1 = new CrosswordForm();
            Hide(); form1.Show();

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
