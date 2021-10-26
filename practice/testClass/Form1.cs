using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testClass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnMessageBox_Click(object sender, EventArgs e)
        {
            //Human human1 = new Human("김덕배", 78);
            //Human human2 = new Human("권중범", 67);

            //Swap(human1, human2);
            //Console.WriteLine($"h1: {human1.Age} h2: {human2.Age}");
            //Swap(human1, human2);
            //Console.WriteLine($"h1: {human1.Age} h2: {human2.Age}");
            //human1.DisplayInfo();

            ParameterArray(1, 2, 3, 4, 5, 6);
        }

        private void Swap(Human h1, Human h2)
        {
            // ref 키워드를 사용하지 않아도.
            // 객체 멤버들은 call by reference 로 동작함
            // 근데 객체 자체를 스왑하면 바뀌지 않음..
            //int temp = h1.Age;
            //h1.Age = h2.Age;
            //h2.Age = temp;

            // 이 경우 동작이 call by value 방식으로 되는듯
            Human t = h1;
            h1 = h2;
            h2 = t;
        }

        private void ParameterArray(params int[] args)
        {
            int sum = 0;
            for (int i = 0; i < args.Length; ++i)
                sum += args[i];

            Console.WriteLine($"다 더하면 -> {sum}");
        }
    }

    public class Human
    {
        private string _name;
        private int _age;

        public int Age
        {
            get { return _age; }
            set
            {
                _age = Math.Max(0, Math.Min(200, value));
            }
        }

        public Human(string name, int age)
        {
            this._name = name;
            Age = age;
        }
        
        public void DisplayInfo()
        {
            MessageBox.Show($"이름: {_name}, 나이: {Age}");
        }
    }
}
