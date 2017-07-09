using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public partial class Form1
    {

        public string ReplaceString(string str)
        {
            if (str == null) return "";
            str = str.Replace("<td>", " ");
            str = str.Replace("</td>", " ");
            str = str.Replace("&lt;br />", " ");
            str = str.Replace("<br/>", " ");
            str = str.Replace("<br />", " ");
            str = str.Replace("<br>", " ");
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

        public string ReadFileLine(System.IO.StreamReader source)
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

        public string[] SpiltLine(string str)
        {
            string[] array = new string[3];
            array[0] = "";
            array[1] = "";
            array[2] = "";
            string[] temp = str.Split('\"', '?', '”');
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

        public string EraseComment(string str)
        {
            if (str.Contains("<a href="))
            {
                int index1 = str.LastIndexOf("<a href=");
                string temp1 = str.Substring(0, index1);
                int index2 = str.IndexOf("<a href=");
                string temp2 = str.Substring(index2);
                int index3 = temp2.IndexOf(">");
                temp2 = temp2.Substring(index3 + 1);
                str = temp1 + temp2;
            }
            if (str.Contains("<sup"))
            {
                int index1 = str.LastIndexOf("<sup");
                string temp1 = str.Substring(0, index1);
                int index2 = str.IndexOf("<sup");
                string temp2 = str.Substring(index2);
                int index3 = temp2.IndexOf("</sup>");
                temp2 = temp2.Substring(index3 + 6);
                str = temp1 + temp2;
            }

            str = str.Replace("?", " ");
            str = str.Replace("?", " ");
            return str;
        }

    }
}
