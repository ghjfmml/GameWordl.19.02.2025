using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project12
{
    public partial class Form1 : Form
    {
        private Label[,] labels;
        private Random random = new Random();

        private int rowIndex = 0;
        private int columnIndex = 0;
        private string[] wordList;
        private string word;
        private string inputWord;
        
    public Form1()
        {
            InitializeComponent();
            labels = new Label[,]{
                { Cell_0_0, Cell_0_1, Cell_0_2, Cell_0_3, Cell_0_4 },
                { Cell_1_0, Cell_1_1, Cell_1_2, Cell_1_3, Cell_1_4 },
                { Cell_2_0, Cell_2_1, Cell_2_2, Cell_2_3, Cell_2_4 },
                { Cell_3_0, Cell_3_1, Cell_3_2, Cell_3_3, Cell_3_4 },
                { Cell_4_0, Cell_4_1, Cell_4_2, Cell_4_3, Cell_4_4 } 
            };
            wordList = new string[] { "Груша", "Карма" };

            ChooseRandomWord();
        }
        private bool[] _useSymbols;
        private void ChooseRandomWord()
        {
            word = wordList[random.Next(wordList.Length)].ToLower();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Key_Click(sender);
        }

        private void btn_Я_Click(object sender, EventArgs e)
        {
            Key_Click(sender);
        }
        private void Key_Click(object sender)
        {
            var btn = sender as Button;
            if ((columnIndex >= 0) && (columnIndex < 5))
            {
                labels[rowIndex, columnIndex].Text = btn.Text;
                columnIndex++;
            }
        }

        private void btn_Del_Click(object sender)
        {
            if ((columnIndex > 0) && (columnIndex <= 5))
            {
                columnIndex--;
                labels[rowIndex, columnIndex].Text = String.Empty;
            }
        }

        private void btn_Ц_Click(object sender, EventArgs e)
        {
            Key_Click(sender);
        }

        private void btn_У_Click(object sender, EventArgs e)
        {
            Key_Click(sender);
        }

        private void btn_К_Click(object sender, EventArgs e)
        {
            Key_Click(sender);
        }

        private void btn_Е_Click(object sender, EventArgs e)
        {
            Key_Click(sender);
        }

        private void btn_Н_Click(object sender, EventArgs e)
        {
            Key_Click(sender);
        }

        private void btn_Г_Click(object sender, EventArgs e)
        {
            Key_Click(sender);
        }

        private void btn_Ш_Click(object sender, EventArgs e)
        {
            Key_Click(sender);
        }

        private void btn_Щ_Click(object sender, EventArgs e)
        {
            Key_Click(sender);
        }

        private void btn_З_Click(object sender, EventArgs e)
        {
            Key_Click(sender);
        }

        private void btn_Х_Click(object sender, EventArgs e)
        {
            Key_Click(sender);
        }

        private void btn_Ъ_Click(object sender, EventArgs e)
        {
            Key_Click(sender);
        }

        private void btn_Ы_Click(object sender, EventArgs e)
        {
            Key_Click(sender);
        }

        private void btn_В_Click(object sender, EventArgs e)
        {
            Key_Click(sender);
        }

        private void btn_А_Click(object sender, EventArgs e)
        {
            Key_Click(sender);
        }

        private void btn_П_Click(object sender, EventArgs e)
        {
            Key_Click(sender);
        }

        private void btn_Р_Click(object sender, EventArgs e)
        {
            Key_Click(sender);
        }

        private void btn_О_Click(object sender, EventArgs e)
        {
            Key_Click(sender);
        }

        private void btn_Л_Click(object sender, EventArgs e)
        {
            Key_Click(sender);
        }

        private void btn_Д_Click(object sender, EventArgs e)
        {
            Key_Click(sender);
        }

        private void btn_Ж_Click(object sender, EventArgs e)
        {
            Key_Click(sender);
        }

        private void btn_Э_Click(object sender, EventArgs e)
        {
            Key_Click(sender);
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            btn_Del_Click(sender);
        }

        private void btn_Ч_Click(object sender, EventArgs e)
        {
            Key_Click(sender);
        }

        private void btn_С_Click(object sender, EventArgs e)
        {
            Key_Click(sender);
        }

        private void btn_М_Click(object sender, EventArgs e)
        {
            Key_Click(sender);
        }

        private void btn_И_Click(object sender, EventArgs e)
        {
            Key_Click(sender);
        }

        private void btn_Т_Click(object sender, EventArgs e)
        {
            Key_Click(sender);
        }

        private void btn_Ь_Click(object sender, EventArgs e)
        {
            Key_Click(sender);
        }

        private void btn_Б_Click(object sender, EventArgs e)
        {
            Key_Click(sender);
        }

        private void btn_Ю_Click(object sender, EventArgs e)
        {
            Key_Click(sender);
        }



        private void btn_Й_Click(object sender, EventArgs e)
        {
            Key_Click(sender);
        }
        private void SetNotUseSymbols()
        {
            _useSymbols = new bool[5] { false, false, false, false, false };
        }
        private void btn_Enter_Click_1(object sender, EventArgs e)
        {
            if (rowIndex < 5 && labels[rowIndex, 4].Text != string.Empty)
            {
                inputWord = "";
                SetNotUseSymbols();
                for (int i = 0; i < 5; i++)
                {
                    inputWord += labels[rowIndex, i].Text.ToLower();
                }

                for (int i = 0; i < 5; i++)
                {
                    if (inputWord[i] == word[i] && !_useSymbols[i])
                    {
                        _useSymbols[i] = true;
                        labels[rowIndex, i].BackColor = Color.Green;
                    }
                }

                for (int i = 0; i < 5; i++)
                {
                    if (_useSymbols[i] == false)
                    {

                        for (int j = 0; j < 5; j++)
                        {

                            if (inputWord[i] == word[j] && i != j && !_useSymbols[j])
                            {
                                _useSymbols[j] = true;
                                labels[rowIndex, i].BackColor = Color.Orange;
                                break;
                            }
                        }

                    }
                }

                columnIndex = 0;
                rowIndex++;

                if (inputWord == word)
                {
                    MessageBox.Show($"Вы победили!");
                }
                else if (rowIndex == 5)
                {
                    MessageBox.Show($"Вы проиграли. Загаданное слово: {word}");
                }
            }
        }
    }
}
