using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Microsoft.Office.Interop.Word;
using static System.Net.WebRequestMethods;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace TerVer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //осн прога

            Microsoft.Office.Interop.Word.Application app = new Microsoft.Office.Interop.Word.Application();
            Document doc = app.Documents.Add(Visible: false);
            Document doc2 = app.Documents.Add(Visible: false);
            Range r = doc.Range();
            Range r2 = doc2.Range();
            int i = Convert.ToInt32(textBox1.Text);
            r.Text = "";
            r2.Text = "";
            for (int j = 1; j <= i; j++)
            {
                r.Text += "Тест 2. Вариант " + j;
                r2.Text += "Вариант "+j;
                r.Text += "Фамилия____________________ Имя____________________\n";

                //1
                
                int[] ex1 = new int[12];
                ex1[0] = j + 2; ex1[1] = j + 3; ex1[2] = j + 5; ex1[3] = j + 6; ex1[4] = j + 7; ex1[5] = j + 8; ex1[6] = j + 15; ex1[7] = j + 18; ex1[8] = j + 19; ex1[9] = j + 22; ex1[10] = j + 24;
                ex1[11] = ex1[5] + 1;
                double ans1 = (ex1[5] + ex1[11])/2;
                Random rnd1 = new Random();
                double[] nums1 = new double[4];//места для ответов
                nums1[0] = ex1[6]+2;
                nums1[1] = ex1[6]+4;
                nums1[2] = ex1[6] + 7;
                nums1[3] = ans1;
                int t1 = rnd1.Next(4);
                double copy = nums1[t1];
                nums1[t1] = ans1;
                nums1[3] = copy;
                r.Text += "1. Медиана вариационного ряда " + ex1[0] + ", " + ex1[1] + ", " + ex1[2] + ", " + ex1[3] + ", " + ex1[4] + ", " + ex1[5] +", x7, " + ex1[6] + ", " + ex1[7] + ", " + ex1[8] + ", " + ex1[9] + ", " + ex1[10] + " равна " +ans1+". Тогда значение варианты x7 равно:";
                r.Text += "1) " + nums1[0] +"\t2) "+ nums1[1] + "\t3) " + nums1[2] + "\t4) " + nums1[3] +"\n";
                t1 = t1 + 1;
                r2.Text += "1 = " + t1;
                

                //2
                
                Random rnd2 = new Random();
                double[] nums2 = new double[4];
                int ans = j+4;
                int dopdigit = j + 5;
                nums2[0] = j+1;
                nums2[1] = j +2;
                nums2[2] = j +3;
                nums2[3] = ans;
                r.Text += "2. Мода вариационного ряда " + nums2[0] + ", " + nums2[1] + ", " + nums2[1] + ", " + nums2[2] + ", " + nums2[2] + ", " + nums2[3] + ", " + nums2[3] + ", " + nums2[3] + ", " + dopdigit + " " + " равна:";
                int t2 = rnd2.Next(4);
                double copy2 = nums2[t2];
                nums2[t2] = ans;
                nums2[3] = copy2;
                r.Text += "1) " + nums2[0] + "\t2) " + nums2[1] + "\t3) " + nums2[2] + "\t4) " + nums2[3] + "\n";
                t2++;
                r2.Text += "2 = " + t2;
                

                //3
                
                int n_num3 =81+j;
                int ans3 = n_num3 - 67;
                Random rnd3 = new Random();
                double[] nums3 = new double[4];
                nums3[0] = ans3+1;
                nums3[1] = ans3+2;
                nums3[2] = ans3+8;
                nums3[3] = ans3;
                int t3 = rnd3.Next(4);
                double copy3 = nums3[t3];
                nums3[t3] = ans3;
                nums3[3] = copy3;
                r.Text += "3. Из генеральной совокупности извлечена выборка объема n = " + n_num3 + ". Тогда значение n2 равно:";
                r.Text += "|   Xi-Xi+1   |    0 - 2    |    2 - 4    |    4 - 6    |    6 - 8    |   8 - 10    |";
                r.Text += "------------------------------------------------------------------------------------";
                r.Text += "|      ni        |       5       |      n2      |      34      |      22      |       6       |";
                r.Text += "";
                r.Text += "1) " + nums3[0] + "\t2) " + nums3[1] + "\t3) " + nums3[2] + "\t4) " + nums3[3] + "\n";
                t3 = t3 + 1;
                r2.Text += "3 = " + t3;
                
                //4
                
                double n_num4_1 = 100 + j;
                double n_nim4_2 = n_num4_1 - 55;
                double n4 = n_nim4_2 / n_num4_1;
                double ans4 =Math.Round(n4,2);
                Random rnd4 = new Random();
                double[] nums4 = new double[4];
                nums4[0] = ans4 - 0.1;
                nums4[1] = ans4 - 0.2;
                nums4[2] = ans4 + 0.03;
                nums4[3] = ans4;
                int t4 = rnd4.Next(4);
                double copy4 = nums4[t4];
                nums4[t4] = ans4;
                nums4[3] = copy4;
                r.Text += "4. Из генеральной совокупности извлечена выборка объема n = " + n_num4_1 + ". Тогда относительная частота варианты xi = 5 равна:";
                r.Text += "|     Xi     |     3     |     4     |     5     |     6     |     7     |";
                r.Text += "-----------------------------------------------------------------";
                r.Text += "|     ni     |     7     |    25    |    n3    |    21    |     2     |";
                r.Text += "";
                r.Text += "1) " + nums4[0] + "\t2) " + nums4[1] + "\t3) " + nums4[2] + "\t4) " + nums4[3] + "\n";
                t4 = t4 + 1;
                r2.Text += "4 = " + t4;
                
                //5
                
                double n5 = 25 + j;
                double n5_all = 25+n5;
                double n5_1 = Math.Round(10 / n5_all, 2);
                double n5_2 = Math.Round(25 / n5_all, 2);
                string ans5 = "1) F*(x) = 0, при x ≤ 1,\t\t 2) F*(x) = 0, при x < 1,\n" +
                                "     F*(x) = "+n5_1+ ", при 1 < x ≤ 4,\t      F*(x) = "+n5_1+ ", при 1 < x < 4,\n" +
                                "     F*(x) = "+n5_2+ ", при 4 < x ≤ 6,\t      F*(x) = "+n5_2+ ", при 4 < x < 6,\n" +
                                "     F*(x) = 1, при x > 6.\t                     F*(x) = 1, при x > 6.";
                string ans5_2 = "3) F*(x) = 0, при x ≤ 1,\t\t 4) F*(x) = 0, при x < 1,\n" +
                                "     F*(x) = " + n5_2 + ", при 1 < x ≤ 4,\t      F*(x) = " + n5_1 + ", при 1 < x ≤ 4,\n" +
                                "     F*(x) = " + n5_1 + ", при 4 < x ≤ 6,\t      F*(x) = " + n5_2 + ", при 4 < x ≤ 6,\n" +
                                "     F*(x) = 1, при x > 6.\t                     F*(x) = 1, при x ≥ 6.";
                r.Text += "5. Найти эмпирическую функцию по данному распределению выборки:";
                r.Text += "xi     1     4     6";
                r.Text += "ni    10  15   "+n5;
                r.Text += ans5 + "\n" + ans5_2+"\n";
                r2.Text += "5 = " + 1;

                //6
                
                double[] ex6 = new double[5];
                ex6[0] =5.5+j; ex6[1] =6.2+j; ex6[2] = 7.1 + j; ex6 [3] = 8.8 + j; ex6[4] = 9.3+j;
                double sum6 = ex6[0] + ex6[1] + ex6[2] + ex6[3] + ex6[4];
                double ans6 = sum6/5;
                Random rnd6 = new Random();
                double[] nums6 = new double[4];
                nums6[0] = ans6-1;
                nums6[1] = ans6-2;
                nums6[2] = ans6+1;
                nums6[3] = ans6;
                int t6 = rnd6.Next(4);
                double copy6 = nums6[t6];
                nums6[t6] = ans6;
                nums6[3] = copy6;
                r.Text += "6. Проведено пять измерений (без систематических ошибок) некоторой случайной величины (в мм):  " + ex6[0] + "; " + ex6[1] + "; " + ex6[2] + "; " + ex6[3] + "; " + ex6[4] + ". Тогда несмещенная оценка математического ожидания равна:";
                r.Text += "1) " + nums6[0] + "\t2) " + nums6[1] + "\t3) " + nums6[2] + "\t4) " + nums6[3] + "\n";
                t6 = t6 + 1;
                r2.Text += "6 = " + t6;

                //7

                Random rdigit7 = new Random();
                double rnum7 = rdigit7.Next(1, 15);
                double r7 = (rnum7* rnum7)/10;
                double ans7 = rnum7/3 ;
                Random rnd7 = new Random();
                double[] nums7 = new double[4];
                nums7[0] = Math.Round(ans7*ans7,1);
                nums7[1] = r7 *10;
                nums7[2] = Math.Round(ans7 * ans7 / 10, 1);
                nums7[3] = Math.Round(ans7, 1);
                int t7 = rnd7.Next(4);
                double copy7 = nums7[t7];
                nums7[t7] = Math.Round(ans7, 1);
                nums7[3] = copy7;
                r.Text += "7. По выборке объема n = 10 найдена выборочная дисперсия DB = " + r7  + ". Тогда исправленное среднее квадратическое отклонение равно:";
                r.Text += "1) " + nums7[0] + "\t2) " + nums7[1] + "\t3) " + nums7[2] + "\t4) " + nums7[3] + "\n";
                t7 = t7 + 1;
                r2.Text += "7 = " + t7;
                
                
                //8
                
                double n8 = 8 + j;
                double ans8 = n8/4;
                Random rnd8 = new Random();
                double[] nums8 = new double[4];//места для ответов
                nums8[0] = n8/5;
                nums8[1] = n8 / 4 + 0.2;
                nums8[2] = Math.Round( 4/n8,2);
                nums8[3] = ans8;
                int t8 = rnd8.Next(4);
                double copy8 = nums8[t8];
                nums8[t8] = ans8;
                nums8[3] = copy8;
                r.Text += "8. Дано распределение выборки объема n = 100. Тогда плотность частоты а равна:";

                r.Text += "|  № интервала   |   Частичный интервал  |  Сумма частот  |  Плотность частоты  |";
                r.Text += "----------------------------------------------------------------------------------------------------------------";
                r.Text += "|              1              |                   1-5                   |            10             |                 2.5                | ";
                r.Text += "|              2              |                   5-9                   |            20             |                  5                  | ";
                r.Text += "|              3              |                   9-13                 |            50             |                12.5              | ";
                r.Text += "|              4              |                  13-17                |            12             |                  3                | ";
                r.Text += "|              5              |                  17-21                |            " + n8+ "              |                 a                   | ";
                r.Text += "";

                r.Text += "1) " + nums8[0] + "\t2) " + nums8[1] + "\t3) " + nums8[2] + "\t4) " + nums8[3] + "\n";
                t8 = t8 + 1;
                r2.Text += "8 = " + t8;
                
                
            //9
            
            double[] ex9 = new double[4];
            double result9 = 2.48 + j;
            ex9[0] = 2.1 + j; ex9[1] = 2.4 + j; ex9[2] = 2.7 + j; ex9[3] = 2.9 + j; 
            double sum9 = ex9[0] + ex9[1] + ex9[2] + ex9[3];
            double ans9 = result9*5 - sum9;
            Random rnd9 = new Random();
            double[] nums9 = new double[4];//места для ответов
            nums9[0] = ans9 + 0.2;
            nums9[1] = ans9+0.1;
            nums9[2] = result9;
            nums9[3] = ans9;
            int t9 = rnd9.Next(4);
            double copy9 = nums9[t9];
            nums9[t9] = ans9;
            nums9[3] = copy9;
            r.Text += "9. Проведено пять измерений (без систематических ошибок) некоторой случайной величины (в мм):  " + ex9[0] + "; " + "x2" + "; " + ex9[1] + "; " + ex9[2] + "; " + ex9[3] + ". Если несмещенная оценка математического ожидания равна "+ result9+", то x2 равно:";
            r.Text += "1) " + nums9[0] + "\t2) " + nums9[1] + "\t3) " + nums9[2] + "\t4) " + nums9[3] + "\n";
            t9 = t9 + 1;
            r2.Text += "9 = " + t9;
            
            //10
            
            int n_10 = j + 1;
            Random r10 = new Random();
            string[] nums10 = new string[4];
            int ans10 = n_10 * n_10;
            nums10[0] = "не изменится ";
            nums10[1] = "увеличится в " + n_10 + " раз (раза) ";
            nums10[2] = "увеличится на " + ans10 + " единиц ";
            nums10[3] = "увеличится в " + ans10 +" раз (раза) ";
            r.Text += "10. Если все варианты xi исходного вариационного ряда увеличить в " + n_10 + " раз (раза), то выборочная дисперсия DB:";
            int t10 = r10.Next(4);
            string copy10 = nums10[t10];
            nums10[t10] = "увеличится в " + ans10 + " раз (раза) ";
            nums10[3] = copy10;
            r.Text += "1) " + nums10[0] + ";\t2) " + nums10[1] + ";\n3) " + nums10[2] + ";\t4) " + nums10[3] + ".\n";
            t10++;
            r2.Text += "10 = " + t10;
            
            //11
            
            int n_11 = j + 1;
            Random r11 = new Random();
            string[] nums11 = new string[4];
            nums11[0] = "не изменится ";
            nums11[1] = "увеличится в " + n_11 * n_11 + " раз (раза) ";
            nums11[2] = "увеличится на " + n_11*n_11 + " единиц ";
            nums11[3] = "увеличится в " + n_11 + " раз(раза) ";
            r.Text += "11. Если все варианты xi исходного вариационного ряда увеличить в "+ n_11 +" раз (раза), то выборочное среднее:";
            int t11 = r11.Next(4);
            string copy11 = nums11[t11];
            nums11[t11] = "увеличится в " + n_11 + " раз(раза)";
            nums11[3] = copy11;
            r.Text += "1) " + nums11[0] + ";\t2) " + nums11[1] + ";\n3) " + nums11[2] + ";\t4) " + nums11[3] + ".\n";
            t11++;
            r2.Text += "11 = " + t11;
            
            //12
            
            Random r12 = new Random();
            int n_12 = (j+1)*(j+1);
            int n12_1 = j + 1;
            string[] nums12 = new string[4];//места для ответов
            nums12[0] = "уменьшится в " + n12_1 + " раз (раза) ";
            nums12[1] = "уменьшится в " + n_12 * 2 + " раз (раза) ";
            nums12[2] = "увеличится в " + n_12 * 2 + " раз (раза) ";
            nums12[3] = "увеличится в " + n12_1 + " раз (раза) ";
            r.Text += "12. Построен доверительный интервал для оценки математического ожидания нормально распределенного количественного признака при известном среднем квадратическом отклонении генеральной совокупности. Тогда при уменьшении объема выборки в " + n_12 + " раза значение точности этой оценки:";
            int t12 = r12.Next(4);
            string copy12 = nums12[t12];
            nums12[t12] = "увеличится в " + n12_1 + " раз (раза) ";
            nums12[3] = copy12;
            r.Text += "1) " + nums12[0] + ";\t2) " + nums12[1] + ";\n3) " + nums12[2] + ";\t4) " + nums12[3] + ".\n";
            t12++;
            r2.Text += "12 = " + t12;
                
            //13
            
            Random rnd13 = new Random();
            string[] nums13 = new string[4];
            double dopdigit1 = j + 5.26;
            double dopdigit2 = j + 10.49;
            double ans13_1 = dopdigit1 -0.1;
            double ans13_2 = dopdigit2 +0.1;
            double ans13_1_false = dopdigit1 - 0.1;
            double ans13_2_false = dopdigit2 - 0.1;
            nums13[0] = "("+ dopdigit1 +"; "+ans13_2 +");  ";
            nums13[1] = "(" + ans13_1 + "; " + dopdigit2 + ");  ";
            nums13[2] = "(" + ans13_1_false + "; " + ans13_2_false + ");  ";
            nums13[3] = "(" + ans13_1 + "; " + ans13_2 + ");  ";
            r.Text += "13. Дан доверительный интервал ( "+dopdigit1 + "; " + dopdigit2+ " ) для оценки среднего квадратического отклонения нормально распределенного количественного признака. Тогда при увеличении надежности (доверительной вероятности) оценки доверительный интервал может принять вид:";
            int t13 = rnd13.Next(4);
            string copy13 = nums13[t13];
            nums13[t13] = "(" + ans13_1 + "; " + ans13_2 + ");  ";
            nums13[3] = copy13;
            r.Text += "1) " + nums13[0] + "\t2) " + nums13[1] + "\t3) " + nums13[2] + "\t4) " + nums13[3] + "\n";
            t13++;
            r2.Text += "13 = " + t13;

            //14
            
            Random rnd14 = new Random();
            string[] nums14 = new string[4];
            double n_14 = j*0.01 + 0.24;
            double ans14_1 = n_14-0.1;
            double ans14_2 = n_14+0.1;
            double ans14_1_false = (n_14 - 0.1)*(-1);
            double ans14_2_false = n_14 + 0.2;
            nums14[0] = "(" + ans14_1_false + "; " + ans14_2 + ");  ";
            nums14[1] = "(" + ans14_1 + "; " + ans14_2_false + ");  ";
            nums14[2] = "(" + ans14_2 + "; " + ans14_1 + ");  ";
            nums14[3] = "(" + ans14_1 + "; " + ans14_2 + ");  ";
            r.Text += "14. Точечная оценка вероятности биномиально распределенного количественного признака равна "+ n_14 +". Тогда его интервальная оценка может иметь вид:";
            int t14 = rnd14.Next(4);
            string copy14 = nums14[t14];
            nums14[t14] = "(" + ans14_1 + "; " + ans14_2 + ");  ";
            nums14[3] = copy14;
            r.Text += "1) " + nums14[0] + "\t2) " + nums14[1] + "\t3) " + nums14[2] + "\t4) " + nums14[3] + "\n";
            t14++;
            r2.Text += "14 = " + t14;
            
            //15
            
            Random rnd15 = new Random();
            string[] nums15 = new string[4];
            double n_15_1 = j * 0.01 + 2.49;
            double n_15_2 = j * 0.001 + 0.05;
            nums15[0] = "левостороннюю критическую область;";
            nums15[1] = "область принятия гипотезы.";
            nums15[2] = "двустороннюю критическую область;";
            nums15[3] = "правостороннюю критическую область;";
            r.Text += "15. Соотношением вида P(K > "+ n_15_1 +" ) = "+ n_15_2 +" можно определить:";
            int t15 = rnd15.Next(4);
            string copy15 = nums15[t15];
            nums15[t15] = "правостороннюю критическую область;";
            nums15[3] = copy15;
            r.Text += "1) " + nums15[0] + "\t2) " + nums15[1] + "\n3) " + nums15[2] + "\t4) " + nums15[3] + "\n";
            t15++;
            r2.Text += "15 = " + t15;
                
            //16
            
            Random rnd16 = new Random();
            string[] nums16 = new string[4];
            double n_16_1 = j * 0.01 + 2.8;
            double n_16_2 = j * 0.001 + 0.06;
            nums16[0] = "Р(К > " + n_16_1 + ") = " + n_16_2 + " ;";//
            nums16[1] =  "Р(К < - " + n_16_1 + " ) + Р(К > " + n_16_1 + " ) = " + n_16_2 + " ;";
            nums16[2] = "Р(- " + n_16_1 + " < К < " + n_16_1 + " ) = " + n_16_2 + " ;";
            nums16[3] = "Р(К < - " + n_16_1 + " ) = " + n_16_2 + " ;";
            r.Text += "16. Левосторонняя критическая область может определяться из соотношения:";
            int t16 = rnd16.Next(4);
            string copy16 = nums16[t16];
            nums16[t16] = "Р(К < - " + n_16_1 + " ) = " + n_16_2 + " ;";
            nums16[3] = copy16;
            r.Text += "1) " + nums16[0] + "\t2) " + nums16[1] + "\n3) " + nums16[2] + " \t4) " + nums16[3] + "\n";
            t16++;
            r2.Text += "16 = " + t16;
            
            //17
            
            double n_17 = 4.2 + 0.01 * j;
            double n_17_dop = n_17 - 0.03;
            r.Text += "17. Основная гипотеза имеет вид: σ^2 = " + n_17+ ". Тогда конкурирующей может являться гипотеза";
            Random rnd17 = new Random();
            string[] nums17 = new string[4];
            nums17[0] = "σ^2 ≤ "+ n_17+" ;";
            nums17[1] = "σ^2 ≥ " + n_17 + " ;";
            nums17[2] = "σ^2 > " + n_17_dop + " ;";
            nums17[3] = "σ^2 < " + n_17 + " ;";
            int t17 = rnd17.Next(4);
            string copy17 = nums17[t17];
            nums17[t17] = "σ^2 < " + n_17 + " ;";
            nums17[3] = copy17;
            r.Text += "1) " + nums17[0] + " \t 2) " + nums17[1] + " \t 3) " + nums17[2] + " \t 4) " + nums17[3] + "\n";
            t17++;
            r2.Text += "17 = " + t17;
            
            //18
            
            Random rnd18 = new Random();
            double[] nums18 = new double[4];
            double n_18_1 = j * 0.01 + 3.25;
            double n_18_2 = j * 0.001 + 1.245;
            double n_18_3 = j * 0.001 + 2.14;
            double ans18 = n_18_3*(-1);
            double ans18_false1 = ans18 - 0.3;
            double ans18_false2 = ans18*(-1) + 0.3;
            nums18[0] = n_18_3;
            nums18[1] = ans18_false1;
            nums18[2] = ans18_false2;
            nums18[3] = ans18;
            r.Text += "18. Выборочное уравнение прямой линии регрессии Y на X имеет вид: ȳ - "+n_18_1+" = "+n_18_2+"(x + "+n_18_3+ "). Тогда выборочное среднее признака X равно:";
            int t18 = rnd18.Next(4);
            double copy18 = nums18[t18];
            nums18[t18] = ans18;
            nums18[3] = copy18;
            r.Text += "1) " + nums18[0] + ";\t2) " + nums18[1] + ";\t3) " + nums18[2] + "; \t4) " + nums18[3] + ".\n";
            t18++;
            r2.Text += "18 = " + t18;
            
            //19
            
            Random rnd19 = new Random();
            double[] nums19 = new double[4];
            double n_19_1 = j * 0.1+ 3.6;
            double n_19_2 = j * 0.1 + 4.2;
            double ans19 = j*0.01+0.25;
            double ans19_false1 = ans19*(-1);
            double ans19_false2 = j*0.1 + 2.4;
            nums19[0] = ans19_false2*(-1);
            nums19[1] = ans19_false1;
            nums19[2] = ans19_false2;
            nums19[3] = ans19;
            r.Text += "19. Выборочное уравнение прямой линии регрессии Y на X имеет вид : y = -" + n_19_1 + " + " + n_19_2 + "x. Тогда выборочный коэффициент корреляции может быть равен:";
            int t19 = rnd19.Next(4);
            double copy19 = nums19[t19];
            nums19[t19] = ans19;
            nums19[3] = copy19;
            r.Text += "1) " + nums19[0] + ";      2) " + nums19[1] + ";      3) " + nums19[2] + ";      4) " + nums19[3] + ".\n";
            t19++;
            r2.Text += "19 = " + t19;
            
            //20  	При построении выборочного уравнения прямой линии регрессии X на Y вычислены выборочный коэффициент регрессии xy = 3,8 и выборочные средние   и  . Тогда уравнение регрессии примет вид:
            
            double n_20_1 = 3.8 + 0.1 * j;
            double n_20_2 = 13.2 + 0.1 * j;
            double n_20_3 = 22.7 + 0.1 * j;
            double ans20 =n_20_1*n_20_3 - n_20_2;
            double ans20_false = ans20+7.29;
            r.Text += "20. При построении выборочного уравнения прямой линии регрессии X на Y вычислены выборочный коэффициент регрессии Pxy = " + n_20_1 + " и выборочные средние x и y равные соответственно "+n_20_2+" и "+n_20_3+". Тогда конкурирующей может являться гипотеза";
            Random rnd20 = new Random();
            string[] nums20 = new string[4];
            nums20[0] = "Xy = " + n_20_1 + "y + " + ans20 + ";";
            nums20[1] = "Xy = " + n_20_1 + "y - " + ans20_false + ";";
            nums20[2] = "Yx = " + n_20_1 + "y + " + ans20 + ";";
            nums20[3] = "Xy = " + n_20_1 + "y - "+ans20 + ";";
            int t20 = rnd20.Next(4);
            string copy20 = nums20[t20];
            nums20[t20] = "Xy = " + n_20_1 + "y -" + ans20 + ";";
            nums20[3] = copy20;
            r.Text += "1) " + nums20[0] + " \t 2) " + nums20[1] + " \n 3) " + nums20[2] + " \t 4) " + nums20[3] + "\n";
            t20++;
            r2.Text += "20 = " + t20;
            
            //21
            Random rnd = new Random();
            double[] nums = new double[4];
            double y = 1.3, x = 2.6, rb = -0.56 + i * 0.01, rxy;
            rxy = rb * (x / y);
            nums[0] = 1.3;
            nums[1] = 0.33;
            nums[2] = -1.12;
            nums[3] = rxy;
            int t = rnd.Next(4);
            double copy21 = nums[t];
            nums[t] = rxy;
            nums[3] = copy21;
            r.Text += "21.\tПри построении выборочного уравнения парной регрессии вычислены выборочный коэффициент корреляции равен " + rb + ", выборочные средние квадратические отклонения x и y соответственно равны " + x + " и " + y + ". Тогда выборочный коэффициент регрессии X на Y равен:";
            r.Text += "1) " + nums[0] + "\t2)" + nums[1] + "\t3)" + nums[2] + "\t4)" + nums[3] + ".";
            t++;
            r2.Text += "21 = "+t;
            
            r.Text += "\f";
            
            }
            //прописать здесь try catch

            doc.Save();
            doc2.Save();
            try
            {
                doc.Close();
                doc2.Close();
                app.Quit();

            }catch(Exception ee)
            { 
                MessageBox.Show(ee.Message);
            }

            }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }

