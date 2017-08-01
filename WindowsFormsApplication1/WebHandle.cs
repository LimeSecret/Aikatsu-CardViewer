using System;
using System.IO;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml.XPath;
using System.Linq;
using HtmlAgilityPack;

namespace WindowsFormsApplication1
{
    public partial class Form1
    {

        public int start = 1;

        public void FullWebLoad()
        {
            string url = "http://aikatsu.wikia.com/wiki/Aikatsu!_Photo_on_Stage!!/Cardlist";
            WebLoader(url);
            WebLoader(url + "/Page_2");
        }

        public void WebLoader(string url)
        {
            string Infocode = AppDomain.CurrentDomain.BaseDirectory + @"\resources\infocode";
            HtmlWeb web = new HtmlWeb();
            var htmlDoc = web.Load(url);

            string crawling_category = "//table/tr/td | //table/tr/td/a[@href]";
            var node = htmlDoc.DocumentNode.SelectNodes(crawling_category);

            foreach (var Node in node)
            {
                if (Node.InnerText == "")
                {
                    string hrefValue = Node.GetAttributeValue("href", string.Empty);
                    WriteText(hrefValue, Infocode);
                }
                else if (Node.InnerText == "\n")
                {
                    continue;
                }
                else
                {
                    string temp = EraseComment(Node.InnerHtml);
                    temp = (ReplaceString(temp));
                    temp = temp.Trim();
                    WriteText(temp, Infocode);
                }
            }
        }


        public void WriteText(string str, string target)
        {
            int n;
            bool isnum = int.TryParse(str, out n);

            if (start == 6)
            {
                if (str == "PR+" || str == "SR+" || str == "R+" || str == "N+" || str == "N" || str == "R" || str == "SR" || str == "PR")
                {
                    File.AppendAllText(target, Environment.NewLine, Encoding.Default);
                    File.AppendAllText(target, str, Encoding.Default);
                    File.AppendAllText(target, Environment.NewLine, Encoding.Default);
                    start = 2;
                }
                else
                {
                    File.AppendAllText(target, str, Encoding.Default);
                    File.AppendAllText(target, Environment.NewLine, Encoding.Default);
                    start = 1;
                }            
            }
            else if (start == 1)
            {
                if (str == "PR+" || str == "SR+" || str == "R+" || str == "N+" || str == "N" || str == "R" || str == "SR" || str == "PR")
                {
                    File.AppendAllText(target, str, Encoding.Default);
                    File.AppendAllText(target, Environment.NewLine, Encoding.Default);
                    start = 2;
                }
                else
                {

                }
            }
            else if (start == 2)
            {
                if (isnum == true)
                {
                    File.AppendAllText(target, str, Encoding.Default);
                    File.AppendAllText(target, Environment.NewLine, Encoding.Default);
                    start = 3;
                }
                else
                {

                }
            }
            else if (start == 3)
            {
                try
                {
                    File.AppendAllText(target, SpiltLine(str)[1], Encoding.Default);
                    File.AppendAllText(target, Environment.NewLine, Encoding.Default);
                }
                catch
                {
                    File.AppendAllText(target, Environment.NewLine, Encoding.Default);
                }
                try
                {
                    File.AppendAllText(target, SpiltLine(str)[2], Encoding.Default);
                    File.AppendAllText(target, Environment.NewLine, Encoding.Default);
                }
                catch
                {
                    File.AppendAllText(target, Environment.NewLine, Encoding.Default);
                }
                start = 4;
            }
            else if (start == 4)
            {
                if (str.Contains("https://vignet") == true)
                {
                    File.AppendAllText(target, str, Encoding.Default);
                    File.AppendAllText(target, Environment.NewLine, Encoding.Default);
                    start = 5;
                }
                else
                {
                    
                }      
            }
            else if (start == 5)
            {
                File.AppendAllText(target, str, Encoding.Default);
                File.AppendAllText(target, Environment.NewLine, Encoding.Default);
                start = 6;
            }
        
        }

        /*
        public void WriteText(string str, string target)
        {
            int n;
            bool isnum = int.TryParse(str, out n);
            if(str == "894" && start == 7)     // 통한의 예외처리 ㅠㅠㅠㅠ
            {
                File.AppendAllText(target, "SR", Encoding.Default);
                File.AppendAllText(target, Environment.NewLine, Encoding.Default);
                File.AppendAllText(target, str, Encoding.Default);
                File.AppendAllText(target, Environment.NewLine, Encoding.Default);
                start = 2;
            }
            if (str == "PR+" || str == "SR+" || str == "R+" || str == "N+" || str == "N" || str == "R" || str == "SR" || str == "PR")
            {
                if (start == 2)     // 통한의 예외처리 2 ㅠㅠㅠㅠㅠㅠ
                {
                    start = 3;
                    return;
                }

                for(int i = start; i <= 6; i++)
                {
                    File.AppendAllText(target, Environment.NewLine, Encoding.Default);
                }
                start = 1;
                File.AppendAllText(target, str, Encoding.Default);
                File.AppendAllText(target, Environment.NewLine, Encoding.Default);
            }

            else if (isnum == true)
            {
                if(start != 1)
                {
                    for (int i = start; i <= 6; i++)
                    {
                        File.AppendAllText(target, Environment.NewLine, Encoding.Default);
                    }
                    File.AppendAllText(target, Environment.NewLine, Encoding.Default);
                }
                File.AppendAllText(target, str, Encoding.Default);
                File.AppendAllText(target, Environment.NewLine, Encoding.Default);
                start = 2;
            }

            else if (start == 5 || start == 6)
            {
                File.AppendAllText(target, str, Encoding.Default);
                File.AppendAllText(target, Environment.NewLine, Encoding.Default);
            }

            else if (start == 3)
            {
                File.AppendAllText(target, SpiltLine(str)[1], Encoding.Default);
                File.AppendAllText(target, Environment.NewLine, Encoding.Default);
                File.AppendAllText(target, SpiltLine(str)[2], Encoding.Default);
                File.AppendAllText(target, Environment.NewLine, Encoding.Default);
            }
            else if (start == 4 && str.Contains("https://vignet"))
            {
                File.AppendAllText(target, str, Encoding.Default);
                File.AppendAllText(target, Environment.NewLine, Encoding.Default);
            }
            else
            {
                return;
            }

            start++;
            return;
        }
        */

    }
}
