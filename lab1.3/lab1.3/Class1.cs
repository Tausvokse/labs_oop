using System;

namespace lab1._1_1
{
    class String
    {
        string str;  
        int length; 
        bool audit; 

        public String()
        {
            str = "hello";

        }
        public String(string str)
        {
            this.str = str;
            this.length = str.Length;

        }

        ~String() {}

        public bool Auditstr()
        {
            audit = true;
            for (int i = 0; i < length; i++)
            {

                if (!(this.str[i] >= 'a' && this.str[i] <= 'z' || this.str[i] == ' '))
                {
                    this.audit = false;
                }
            }
            return audit;

        }

        public string getstr
        {
            get { return str; }
            set { str = value; }
        }
        public int getlength
        {
            get { return length; }
        }
        public bool getaudit
        {
            get { return audit; }
        }

        public string Sort()
        {
            char[] stri = str.ToCharArray();
            char tmp;
            for (int j = 0; j < length - 1; j++)
            {
                for (int i = 0; i < length - j - 1; i++)
                {
                    if (stri[i] < stri[i + 1])
                    {
                        tmp = stri[i];
                        stri[i] = stri[i + 1];
                        stri[i + 1] = tmp;
                    }
                }
            }
            str = new string(stri);
            return str;

        }

        public static String operator +(String STR, char a)
        {

            return new String(STR.str + a);
        }

        public static String operator +(char a, String STR)
        {

            return new String(a + STR.str);
        }

        public static String operator +(String STR1, String STR)
        {

            return new String(STR1.str + STR.str);
        }

        public static bool operator >=(String STR1, String STR)
        {
            if (STR1.length >= STR.length)
            {
                return true;
            }
            else { return false; }

        }
        public static bool operator <=(String STR1, String STR)
        {
            if (STR1.length <= STR.length)
            {
                return true;
            }
            else { return false; }

        }

        public static String operator ++(String STR)
        {

            return new String(STR.str + 'a');
        }

        public static bool operator false(String STR)
        {
            bool allZeros = true;
            for (int i = 0; i < STR.str.Length; i++)
            {
                if (STR.str[i] != '0')
                {
                    allZeros = false;
                    break;
                }
            }
            return allZeros;
        }
        public static bool operator true(String STR)
        {
            bool allZeros = true;
            for (int i = 0; i < STR.str.Length; i++)
            {
                if (STR.str[i] != '0')
                {
                    allZeros = false;
                    break;
                }
            }
            return allZeros;
        }
    }
}