using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Calculator_project
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        float firstNumber, secondNumber; // firstNumber 儲存第一個數字，secondNumber 儲存第二個數字
        int operators = -1; // 記錄選擇哪一種運算符號？0:加、1:減、2:乘、3:除、-1:重新設定
        float finalResults = 0f; //宣告最後計算結果變數

        private void btn_one_Click(object sender, RoutedEventArgs e)
        {
            if (txt_Number.Text == "0")
            {
                txt_Number.Text = "";
            }
            txt_Number.Text = txt_Number.Text + "1";
        }

        private void btn_two_Click(object sender, RoutedEventArgs e)
        {
            if (txt_Number.Text == "0")
            {
                txt_Number.Text = "";
            }
            txt_Number.Text = txt_Number.Text + "2";
        }

        private void btn_three_Click(object sender, RoutedEventArgs e)
        {
            if (txt_Number.Text == "0")
            {
                txt_Number.Text = "";
            }
            txt_Number.Text = txt_Number.Text + "3";
        }

        private void btn_four_Click(object sender, RoutedEventArgs e)
        {
            if (txt_Number.Text == "0")
            {
                txt_Number.Text = "";
            }
            txt_Number.Text = txt_Number.Text + "4";
        }

        private void btn_five_Click(object sender, RoutedEventArgs e)
        {
            if (txt_Number.Text == "0")
            {
                txt_Number.Text = "";
            }
            txt_Number.Text = txt_Number.Text + "5";
        }

        private void btn_six_Click(object sender, RoutedEventArgs e)
        {
            if (txt_Number.Text == "0")
            {
                txt_Number.Text = "";
            }
            txt_Number.Text = txt_Number.Text + "6";
        }

        private void btn_seven_Click(object sender, RoutedEventArgs e)
        {
            if (txt_Number.Text == "0")
            {
                txt_Number.Text = "";
            }
            txt_Number.Text = txt_Number.Text + "7";
        }

        private void btn_eight_Click(object sender, RoutedEventArgs e)
        {
            if (txt_Number.Text == "0")
            {
                txt_Number.Text = "";
            }
            txt_Number.Text = txt_Number.Text + "8";
        }

        private void btn_nine_Click(object sender, RoutedEventArgs e)
        {
            if (txt_Number.Text == "0")
            {
                txt_Number.Text = "";
            }
            txt_Number.Text = txt_Number.Text + "9";
        }
        private void btn_zero_Click(object sender, RoutedEventArgs e)
        {
            if (txt_Number.Text == "0")
            {
                txt_Number.Text = "";
            }
            txt_Number.Text = txt_Number.Text + "0";
        }
        private void btn_add_Click(object sender, RoutedEventArgs e)
        {
            firstNumber = Convert.ToSingle(txt_Number.Text); //將輸入文字框轉換成浮點數，存入第一個數字的全域變數
            txt_Number.Text = "0"; //重新將輸入文字框重新設定為0
            operators = 0; //選擇「加」號
        }

        private void btn_subtration_Click(object sender, RoutedEventArgs e)
        {
            firstNumber = Convert.ToSingle(txt_Number.Text);
            txt_Number.Text = "0";
            operators = 1; //選擇「減」號
        }

        private void btn_time_Click(object sender, RoutedEventArgs e)
        {
            firstNumber = Convert.ToSingle(txt_Number.Text);
            txt_Number.Text = "0";
            operators = 2; //選擇「乘」號
        }

        private void btn_division_Click(object sender, RoutedEventArgs e)
        {
            firstNumber = Convert.ToSingle(txt_Number.Text);
            txt_Number.Text = "0";
            operators = 3; //選擇「減」號
        } 
        private void btn_Percentage_Click(object sender, RoutedEventArgs e)
        {
            finalResults = finalResults / 10000;
            txt_Number.Text = string.Format("{0:P2}", finalResults);
        }
        private void btn_dot_Click(object sender, RoutedEventArgs e)
        {
            // 確認輸入文字框中完全沒有小數點
            if (txt_Number.Text.IndexOf(".") == -1)
                txt_Number.Text = txt_Number.Text + ".";
        }

        private void btn_Clear_Click(object sender, RoutedEventArgs e)
        {
            txt_Number.Text = "0";
            firstNumber = 0f;
            secondNumber = 0f;
            operators = -1;
        }
        public void btn_equal_Click(object sender, RoutedEventArgs e)
        {
            secondNumber = Convert.ToSingle(txt_Number.Text); //將輸入文字框轉換成浮點數，存入第二個數字的全域變數

            //依照四則運算符號的選擇，進行加減乘除
            switch (operators)
            {
                case 0:
                    finalResults = firstNumber + secondNumber;
                    break;
                case 1:
                    finalResults = firstNumber - secondNumber;
                    break;
                case 2:
                    finalResults = firstNumber * secondNumber;
                    break;
                case 3:
                    finalResults = firstNumber / secondNumber;
                    break;
                case 4:
                    txt_Number.Text = string.Format("{0:P2}", finalResults);
                    break;
            }
            txt_Number.Text = string.Format("{0:0.##########}", finalResults); //在輸入文字框中，顯示最後計算結果，並且轉換成格式化的字串內容

            //重置所有全域變數
            firstNumber = 0f;
            secondNumber = 0f;
            operators = -1;
        }
    }
}
