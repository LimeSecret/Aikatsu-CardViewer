using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public partial class Form1
    {
        public static string getBetween(string strSource, string strStart, string strEnd)
        {
            int Start, End;
            if (strSource.Contains(strStart) && strSource.Contains(strEnd))
            {
                Start = strSource.IndexOf(strStart, 0) + strStart.Length;
                End = strSource.IndexOf(strEnd, Start);
                return strSource.Substring(Start, End - Start);
            }
            else
            {
                return "";
            }
        }

        public static string getBetween(string strSource, string strStart)
        {
            int Start;
            if (strSource.Contains(strStart))
            {
                Start = strSource.IndexOf(strStart, 0) + strStart.Length;

                return strSource.Substring(Start);
            }
            else
            {
                return "";
            }
        }


        public static string ChangeString(string str)
        {
            int start = 0;
            int end = 0;
            bool find = false;
            while (true)
            {
                for (int i = 0; i < str.Length; i++)
                {
                    if (str[i] == '<')
                    {
                        start = i;
                        find = true;
                    }
                    if (str[i] == '>' && find == true)
                    {
                        end = i;
                        str = str.Remove(start, end - start + 1);
                        break;
                    }
                }
                if (find == false)
                    break;
                find = false;
            }
            return str;
        }

        public static string ReplaceString(string str)
        {
            if (str == null) return "";
            str = str.Replace("<td>", " ");
            str = str.Replace("</td>", " ");
            str = str.Replace("&lt;br />", " ");
            str = str.Replace("<br/>", " ");
            str = str.Replace("<br />", " ");
            str = str.Replace("<p>", " ");
            str = str.Replace("</p>", " ");
            str = str.Replace("<tr>", " ");
            str = str.Replace("</tr>", " ");
            str = str.Replace("</a>", " ");
            str = str.Replace("・", " ");
            str = str.Replace("|", " ");
            str = str.Replace("�", "");
            str = str.Replace("ō", "o");
            str = str.Replace("Ō", "O");
            str = str.Replace("ī", "i");
            str = str.Replace("ū", "u");
            str = str.Trim();
            return str;
        }

        public static string ReadFileLine(System.IO.StreamReader source)
        {
            string str = null;
            while (str == "" || str == null)
            {
                str = source.ReadLine();
                str = ReplaceString(str);
                str = str.Trim();
            }
            return str;
        }

        public static string[] SpiltLine(string str)
        {
            string[] array = new string[3];
            array[0] = "";
            array[1] = "";
            array[2] = "";
            string[] temp = str.Split('\"', '?');
            int count = 0;
            foreach (string s in temp)
            {
                array[count] = s.Trim();
                count++;
                if (count == 3)
                    break;
            }
            if (array[2] == "")
            {
                array[2] = array[0].Trim();
                array[1] = "";
            }
            return array;
        }

        public static string EraseComment(string str)
        {
            if (str.Contains("&lt;ref>"))
            {
                int index1 = str.LastIndexOf("&lt;ref>");
                string temp1 = str.Substring(0, index1);
                int index2 = str.IndexOf("&lt;ref>");
                string temp2 = str.Substring(index2);
                int index3 = temp2.IndexOf("&lt;/ref>");
                temp2 = temp2.Substring(index3 + 9);
                str = temp1 + temp2;
            }
            if (str.Contains("[["))
            {
                int index1 = str.LastIndexOf("[[");
                string temp1 = str.Substring(0, index1);
                int index2 = str.IndexOf("[[");
                string temp2 = str.Substring(index2);
                int index3 = temp2.IndexOf("]]");
                temp2 = temp2.Substring(index3 + 2);
                str = temp1 + temp2;
            }

            str = str.Replace("?", " ");
            str = str.Replace("?", " ");
            return str;
        }

    }
}
