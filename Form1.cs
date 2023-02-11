using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //List<char> romeChars = new List<char>() { 'I', 'V', 'X', 'L', 'C', 'D', 'M' };
        Dictionary<char, int> romeChars = new Dictionary<char, int>
        {
            {'I', 1 },
            {'V', 5 },
            {'X', 10 },
            {'L', 50 },
            {'C', 100 },
            {'D', 500 },
            {'M', 1000 }
        };
        //char[] romeChars = { 'I', 'V', 'X', 'L', 'C', 'D', 'M' };

        int romeToInt(string input)
        {
            return 0;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string input = textBox1.Text.ToUpper();
            //input.ToUpper();
            textBox1.Text = input.ToUpper();
            char[] chInput = input.ToCharArray();
            foreach (char ch in chInput)
            {
                if (!romeChars.ContainsKey(ch)) textBox2.Text = "Вы ввели неправильные римские цифры!";
                else
                {
                    int output = 0;
                    for(int i = 0; i < input.Length; i++)
                    {
                        char currentRCh = input[i];
                        try { 
                        if (i+1 < input.Length && romeChars[input[i + 1]] > romeChars[currentRCh]) output -= romeChars[currentRCh];
                        else output += romeChars[currentRCh];
                        }
                        catch
                        {
                            textBox2.Text = "Вы ввели неправильные римские цифры!";
                        }
                    }
                    textBox2.Text = output.ToString();
                }
            }
        }
    }
}
