using System;

namespace String.StringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            //    Console.WriteLine(Indexof("el"));
            //    string a = "Hello";
            //    Console.WriteLine(a.IndexOf("el"));
            Console.WriteLine(Reverse("How are you ?"));
       }
        #region FirstTask
        static int Indexof(string word)
        {
            string temp = "Hello";
            int i = 0;
            bool check = false;
            for (; i < temp.Length; i++)
            {
                if (temp[i] == word[0])
                {
                    check = true;
                    break;
                }
            }
            if (!check)
            {
                return -1;
            }
            return i;

        }

        static int Indexof(string word, int index)
        {
            string temp = "Hello";
            bool check = false;
            int i = index;
            for (; i < temp.Length; i++)
            {
                if (temp[i] == word[0])
                {
                    check = true;
                    break;
                }
            }
            if (!check)
            {
                return -1;
            }
            return i;
        }

        static int Indexof(string word, int index, int count)
        {
            string temp = "Hello";
            bool check = false;
            int i = index;
            for (; i <= index + count; i++)
            {
                if (temp[i] == word[0])
                {
                    check = true;
                    break;
                }
            }
            if (!check)
            {
                return -1;
            }
            return i;

        }
        #endregion
        #region SecondTask
        static string Reverse(string str)
        {

            string reverse = string.Empty;
            foreach (var word in str.Split(' '))
            {
                string strword = "";
                foreach (var charr in word)
                {
                    strword = charr + strword;
                }
                reverse = reverse + strword + " ";
            }
            return reverse;
        }
        #endregion

    }
}
