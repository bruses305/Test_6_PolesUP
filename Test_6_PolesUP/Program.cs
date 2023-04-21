using System;

namespace Test_6_PolesUP
{
    class Program
    {
        static string Translation(double num)
        {
            string num1 = $"{num}";
            string str_num = "";
            for(int i = 0;i<num1.Length;i++)
            {
                if(num1[i] == '0') {str_num+="zero "; }
                else if(num1[i] == '1') {str_num+="one "; }
                else if(num1[i] == '2') {str_num+="two "; }
                else if(num1[i] == '3') {str_num+="three "; }
                else if(num1[i] == '4') {str_num+="four "; }
                else if(num1[i] == '5') {str_num+="five "; }
                else if(num1[i] == '6') {str_num+="six "; }
                else if(num1[i] == '7') {str_num+="seven "; }
                else if(num1[i] == '8') {str_num+="eight "; }
                else if(num1[i] == '9') {str_num+="nine "; }
                else if(num1[i] == ',') {str_num+="point "; }
                else if(num1[i] == '-') {str_num+="minus "; }
            }
            return str_num;
        }
        static void Main(string[] args)
        {
            double num = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(Translation(num));
        }
    }
}
