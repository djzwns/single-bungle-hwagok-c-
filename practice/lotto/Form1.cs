using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lotto
{
    public partial class Lotto : Form
    {
        private const int MAX_NUM = 45;
        private const int PICK_NUM = 7;

        private int[] numbers = new int[MAX_NUM];
        private List<int> pickNumbers = new List<int>(PICK_NUM);

        private TextBox[] tbWins = new TextBox[PICK_NUM];

        private Random rand = new Random();

        public Lotto()
        {
            InitializeComponent();
        }

        private void Lotto_Load(object sender, EventArgs e)
        {
            tbWins[0] = tbWin0;
            tbWins[1] = tbWin1;
            tbWins[2] = tbWin2;
            tbWins[3] = tbWin3;
            tbWins[4] = tbWin4;
            tbWins[5] = tbWin5;
            tbWins[6] = tbWinBonus;
        }

        private void Init()
        {
            for (int i = 0; i < MAX_NUM; ++i)
            {
                numbers[i] = i + 1;
            }
            pickNumbers.Clear();
        }

        private void PickNumber()
        {
            int index = 0;
            int bonus = 0;

            for (int i = 0; i < PICK_NUM; ++i)
            {
                index = rand.Next(MAX_NUM);
                if (numbers[index] == 0)
                {
                    --i;
                    continue;
                }

                Console.WriteLine($"{i}번째 번호: {numbers[index]}");
                // 보너스 번호 아닐 때
                if (i != PICK_NUM - 1) pickNumbers.Add(numbers[index]);

                // 보너스 번호 일 때
                else bonus = numbers[index];
                numbers[index] = 0;
            }

            pickNumbers.Sort();

            pickNumbers.Add(bonus);
        }

        private void UpdateUI()
        {
            for (int i = 0; i < PICK_NUM; ++i)
                tbWins[i].Text = pickNumbers[i].ToString();
        }

        private void testEvent(int a, int b)
        {
            Console.WriteLine($"a:{a}, b:{b}!!!");
        }

        private void btnPickNumber_Click(object sender, EventArgs e)
        {
            //int a = 20;
            //int b = 30;
            //Swap<int>(ref a, ref b);
            //Console.WriteLine($"a: {a}, b: {b}");
            //MyClass mc1 = new MyClass();
            //mc1[0] = "Hello";
            //mc1[1] = "World";
            //mc1.Age = 20;
            //MyClass mc2 = new MyClass();
            //mc2[0] = "World";
            //mc2[1] = "Hello";
            //mc2.Age = 30;
            //Console.WriteLine($"{mc1[0]} {mc1[1]}, {mc1.Age}");

            //MyClass.myevent += testEvent;
            //MyClass mc3 = mc1 + mc2;

            //Console.WriteLine($"{mc3[0]}, {mc3.Age}");




            Init();
            PickNumber();
            UpdateUI();
        }

        private void Swap<T> (ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
    }

    public class MyClass
    {
        private int age;

        public int Age
        {
            get { return age; }
            set { age = Math.Max(0, Math.Min(value, 200)); }
        }

        private string[] data = new string[5];
        public string this[int index]
        {
            get { return data[index]; }
            set { data[index] = value; }
        }

        public static MyClass operator+(MyClass a, MyClass b)
        {
            MyClass o = new MyClass();
            o.age = a.age + b.age;
            o[0] = a[0] + b[0];
            if (myevent != null)
                myevent(a.age, b.age);
            return o;
        }

        public delegate void myEvent(int a, int b);
        public static myEvent myevent;
    }
}
