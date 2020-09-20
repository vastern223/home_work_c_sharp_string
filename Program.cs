using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home_work_c_sharp_string
{
    class Program
    {
        static void Main(string[] args)
        {
            ////завданяня 1

            //string letter;
            //string[] starray = new string[]{"most","lost","free","down","look","string"};

            //for (int i = 0; i < starray.Length; i++)
            //{
            //    Console.WriteLine(starray[i]);
            //}

            //for (int i = 0; i < starray.Length - 1; i++)
            //{
            //    for (int j = i; j >= 0; j--)
            //    {
            //        if (String.Compare(starray[j], starray[j + 1]) > 0) 
            //        {

            //            letter = starray[j];
            //            starray[j] = starray[j + 1];
            //            starray[j + 1] = letter;
            //        }
            //    }
            //}

            //Console.WriteLine();
            //for (int i = 0; i < starray.Length; i++)
            //{
            //    Console.WriteLine(starray[i]);
            //}




            ////завданяня 2

            //string str = "prosto chtoto poshlo netack";
            //string newstr = null;

            //Console.WriteLine(str);
            //string[] str2 = str.Split(new char[] { ' ', '\n' }, StringSplitOptions.RemoveEmptyEntries);

            //for (int i = str2.Length - 1; i >= 0; i--)
            //{
            //    newstr += str2[i] + " ";
            //}

            //Console.WriteLine();
            //Console.WriteLine(newstr);



            ////завданяня 3

            //string str = ".prosto  chtoto  poshlo netack .  prosto chtoto .poshlo netack.";
            //Console.WriteLine(str);
            //string[] str2 = str.Split(new char[] { '.', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            //string[] str3;
            //if (str[0] != '.')
            //{
            //    str3 = str2[1].Split(new char[] { ' ', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            //}
            //else
            //{
            //    str3 = str2[0].Split(new char[] { ' ', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            //}

            //Console.WriteLine();

            //String letter = String.Join("", str3);
            //if (str[0] != '.')
            //{
            //    str2[1] = letter;
            //}
            //else
            //{
            //    str2[0] = letter;
            //}
            //String letter1 = String.Join(".", str2);

            //if (str[0] == '.')
            //{
            //    string str_new = ".";
            //    str_new += letter1;
            //    letter1 = str_new;
            //}

            //if (str[str.Length - 1] == '.')
            //{
            //    str = letter1 + '.';
            //}
            //else
            //    str = letter1;

            //Console.WriteLine(str);



            ////завданяня 4

            //string word;
            //Console.Write(" enter string :");
            //word = Console.ReadLine();
            //char[] newword = word.ToCharArray();
            //Array.Reverse(newword);
            //string finaltext = new string(newword);

            //if (word == finaltext)
            //{
            //    Console.WriteLine(" polyndrome");
            //}
            //else
            //{
            //    Console.WriteLine(" not polyndrome");
            //}



            ////завданяня 5

            //Console.Write(" enter number word: ");
            //int number = int.Parse(Console.ReadLine());
            //string str = "prosto chtoto poshlo netack";

            //Console.WriteLine(str);
            //string[] str2 = str.Split(new char[] { ' ', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            //for (int i = 0; i < str2.Length; i++)
            //{
            //    if (number-1 == i)
            //    {
            //        Console.WriteLine(str2[i][0]);
            //    }
            //}


            ////завданяня 6

            //string str = "prosto  chtoto  poshl netack moshet vse oke";
            //Console.WriteLine(str);
            //string[] str2 = str.Split(new char[] { ' ', '\n' }, StringSplitOptions.RemoveEmptyEntries);

            //Console.Write("enter Length word: ");
            //int index = int.Parse(Console.ReadLine());

            //for (int i = 0; i < str2.Length; i++)
            //{
            //    if (str2[i].Length == index)
            //    {
            //        str2[i] = str2[i].Remove(str2[i].Length - 3);
            //        str2[i] += "$";
            //    }
            //}

            //String letter1 = String.Join(" ", str2);
            //Console.WriteLine(letter1);



            ////завданяня 7

            //string word;
            //Console.Write(" enter words: ");
            //word = Console.ReadLine().ToString();
            //int count1 = 0;
            //int count2 = 0;

            //for (int i = 0; i < word.Length; i++)
            //{
            //    if (word[i] >= 65 && word[i] <= 90)
            //    {
            //        count1++;
            //    }
            //    if (word[i] >= 97 && word[i] <= 122)
            //    {
            //        count2++;
            //    }
            //}
            //double count3 = 100 / word.Length;
            //double count4 = count1 * count3;
            //double count5 = count2 * count3;

            //Console.WriteLine(" capital letters:" + count4);
            //Console.WriteLine(" lowercase letters:" + count5);





            ////завданяня 8

            //string str = "prosto chtoto poshlo netack";
            //string str2 = " strano";
            //Console.WriteLine(str);
            //string newstr = str.Insert(27, str2);
            //Console.WriteLine(newstr);


            ////завданяня 9


            //string str = "prosto prosto prosto prosto prosto";
            //Console.WriteLine(str);
            //str = str.Replace("sto", "totup");
            //Console.WriteLine(str);



            ////завданяня 10

            //char[,] arr = new char[8, 8]{
            //        {'i','b','b','p','b','i','d','g' },
            //        { 'b','l','i','v','j','p','v','i' },
            //        { 'k','l','w','a','i','v','z','n' },
            //        { 'm','o','j','i','l','o','l','e' },
            //        { 'o','j','k','o','o','p','i','i' },
            //        { 'f','i','m','l','l','d','y','a' },
            //        { 'o','y','o','d','e','e','h','z' },
            //        { 'a','s','f','q','y','k','l','p' } };



            //bool find = false;
            //int index_i = 0;
            //int index_j = 0;
            //bool isWertical = false;

            //for (int i = 0; i < 8; i++)
            //{
            //    for (int j = 0; j < 8; j++)
            //    {
                   
            //        if (i <= 4 && arr[i, j] == 'l' && arr[i + 1, j] == 'o' && arr[i + 2, j] == 'l' && arr[i + 3, j] == 'e')
            //        {
            //            index_i = i;
            //            index_j = j;
            //            find = true;
            //            isWertical = true;
            //        }

            //        if (i >= 3 && arr[i, j] == 'l' && arr[i - 1, j] == 'o' && arr[i - 2, j] == 'l' && arr[i - 3, j] == 'e')
            //        {
            //            index_i = i;
            //            index_j = j;
            //            find = true;
            //            isWertical = true;
            //        }
            //        if (j <= 4 && arr[i, j] == 'l' && arr[i, j + 1] == 'o' && arr[i, j + 2] == 'l' && arr[i, j + 3] == 'e')
            //        {
            //            index_i = i;
            //            index_j = j;
            //            find = true;
            //            isWertical = false;
            //        }
            //        if (j >= 3 && arr[i, j] == 'l' && arr[i, j - 1] == 'o' && arr[i, j - 2] == 'l' && arr[i, j - 3] == 'e')
            //        {
            //            index_i = i;
            //            index_j = j;
            //            find = true;
            //            isWertical = false;
            //        }
            //    }
            //}

            //if (find != true)
            //{
            //    Console.WriteLine("There aro no word in arr!");
            //}
            //else
            //{
            //    Console.WriteLine("You find word!");
            //    Console.WriteLine("Number of row = " + index_i);
            //    Console.WriteLine("Number of col = " + index_j);
            //    if (isWertical == true)
            //        Console.WriteLine("Word is wertical");
            //    else
            //        Console.WriteLine("Word is horizontal");
            //}


            ////завданяня 11


            //char[] charsToTrim = { ' ' };
            //string str = "   prosto    chtoto    poshlo    netack    ";
            //Console.WriteLine(str);
            //string result = str.Trim(charsToTrim);
            //string[] str2 = result.Split(new char[] { ' ', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            //String word = String.Join("*", str2);
            //Console.WriteLine(word);



            ////завданяня 12

            //string str = "prosto chtoto  poshlo netack  flacksavnacka ";

            //Console.WriteLine(str);

            //string[] str2 = str.Split(new char[] { ' ', '\n' }, StringSplitOptions.RemoveEmptyEntries);

            //int a = str2[0].Length;

            //int index = 0;
            //for (int i = 0; i < str2.Length; i++)
            //{
            //    if (a < str2[i].Length)
            //    {
            //        a = str2[i].Length;
            //        index = i;
            //    }
            //}

            //char[] arr = str2[index].ToCharArray();
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] == 'a')
            //    {
            //        arr[i] = 'B';
            //    }
            //}
            //str2[index] = new string(arr);

            //Console.WriteLine();

            //for (int i = 0; i < str2.Length; i++)
            //{
            //    Console.WriteLine(str2[i]);

            //}


            ////завданяня 13

            //string str = "prosto 123 sto 12.3 pro 2 je 22.2 245 qtr";
            //Console.WriteLine(str);
            //string[] str2 = str.Split(new char[] { ' ', '\n' }, StringSplitOptions.RemoveEmptyEntries);

            //string str_int_number = null;
            //string str_double_number = null;
            //string str_new = null;
            //bool str_new_correct = false;
            //bool str_int_correct = false;
            //bool str_double_correct = false;

            //for (int i = 0; i < str2.Length; i++)
            //{
            //    for (int j = 0; j < str2[i].Length; j++)
            //    {
            //        if (str2[i][j] >= 97 && str2[i][j] <= 122 || str2[i][j] >= 65 && str2[i][j] <= 90)
            //        {
            //            str_new_correct = true;
            //            continue;
            //        }
            //        else
            //        {
            //            str_new_correct = false;
            //            break;
            //        }
            //    }
            //    if (str_new_correct == true)
            //    {
            //        str_new += str2[i] + " ";
            //    }

            //    for (int j = 0; j < str2[i].Length; j++)
            //    {
            //        if (str2[i][j] >= 48 && str2[i][j] <= 57)
            //        {
            //            str_int_correct = true;
            //            continue;
            //        }
            //        else
            //        {
            //            str_int_correct = false;
            //            break;
            //        }
            //    }
            //    if (str_int_correct == true)
            //    {
            //        str_int_number += str2[i] + " ";
            //    }

            //    for (int j = 0; j < str2[i].Length; j++)
            //    {
            //        if (str2[i][j] >= 48 && str2[i][j] <= 57)
            //        {
            //            str_double_correct = true;
            //            continue;
            //        }
            //        else if (str2[i][j] == '.')
            //        {
            //            str_double_correct = true;
            //            continue;
            //        }
            //        else
            //        {
            //            str_double_correct = false;
            //            break;
            //        }
            //    }
            //    if (str_double_correct == true)
            //    {
            //        str_double_number += str2[i] + " ";
            //    }
            //}

            //Console.WriteLine(str_new);
            //Console.WriteLine(str_int_number);
            //Console.WriteLine(str_double_number);


            ////завданяня 14

            //string str = "prosto chtoto  hlo netk  flacksavnacka";
            //Console.WriteLine(str);

            //string[] str2 = str.Split(new char[] { ' ', '\n' }, StringSplitOptions.RemoveEmptyEntries);

            //for (int i = 0; i < str2.Length; i++)
            //{
            //    if (str2[i].Length < 5)
            //    {
            //        str2[i] = str2[i].Remove(0);
            //    }
            //}
            //String word = String.Join(" ", str2);
            //string[] str3 = word.Split(new char[] { ' ', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            //String word1 = String.Join(" ", str3);

            //Console.WriteLine(word1);



        }
    }
}
