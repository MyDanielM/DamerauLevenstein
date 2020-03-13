using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Search
{
    public partial class Form1 : Form
    {
        string path = "dic1.txt";
        string[] separators = new string[] { "\r", "\n" };
        string[] dic;
        public Form1()
        {
            InitializeComponent();
            dictionary1.BackColor = Color.Gold;
            dictionary2.BackColor = Color.White;
            dictionary3.BackColor = Color.White;
            dic = getDic(path);
        }

        #region DamerauLevenshtein
        private int Minimum(int a, int b) => a < b ? a : b;

        private int Minimum(int a, int b, int c) => (a = a < b ? a : b) < c ? a : c;
        private int DamerauLevenshteinDistance(string firstText, string secondText)
        {
            var n = firstText.Length + 1;
            var m = secondText.Length + 1;
            var arrayD = new int[n, m];

            for (var i = 0; i < n; i++)
            {
                arrayD[i, 0] = i;
            }

            for (var j = 0; j < m; j++)
            {
                arrayD[0, j] = j;
            }

            for (var i = 1; i < n; i++)
            {
                for (var j = 1; j < m; j++)
                {
                    var cost = firstText[i - 1] == secondText[j - 1] ? 0 : 1;

                    arrayD[i, j] = Minimum(arrayD[i - 1, j] + 1,          // удаление
                                            arrayD[i, j - 1] + 1,         // вставка
                                            arrayD[i - 1, j - 1] + cost); // замена

                    if (i > 1 && j > 1
                        && firstText[i - 1] == secondText[j - 2]
                        && firstText[i - 2] == secondText[j - 1])
                    {
                        arrayD[i, j] = Minimum(arrayD[i, j],
                                           arrayD[i - 2, j - 2] + cost); // перестановка
                    }
                }
            }

            return arrayD[n - 1, m - 1];
        }
        #endregion

        /// <summary>
        /// Метод читает подключенный словарь
        /// </summary>
        /// <param name="path">Путь до словаря</param>
        /// <returns></returns>
        private string[] getDic(string path)
        {
            string[] allText = new string[0];
            using (StreamReader srtoEnd = new StreamReader(path, System.Text.Encoding.UTF8))
            {
                string s = srtoEnd.ReadToEnd();
                allText = s.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            }
            return allText;
        }

        private void inputTextBox_TextChanged(object sender, EventArgs e)
        {
            byte count = 0;
            string searchWord = inputTextBox.Text;
            outputFull.Text = "";
            outputNotFull.Text = "";
           
            foreach(string word in dic)
            { 
                    int distance = DamerauLevenshteinDistance(searchWord, word);
                    if (distance == 0)
                    {
                        count = 1;
                        outputFull.Text = word;

                    }
                    if (distance > 0 && distance < 5)
                    {
                        if (count != 1)
                            outputNotFull.Text += word + "\n";

                    }
            }
        }

        private void dictionary1_Click(object sender, EventArgs e)
        {
            path = "dic1.txt";
            dictionary1.BackColor = Color.Gold;
            dictionary2.BackColor = Color.White;
            dictionary3.BackColor = Color.White;
            dic = getDic(path);
        }

        private void dictionary2_Click(object sender, EventArgs e)
        {
            path = "dic2.txt";
            dictionary1.BackColor = Color.White;
            dictionary2.BackColor = Color.Gold;
            dictionary3.BackColor = Color.White;
            dic = getDic(path);
        }
    }
}
