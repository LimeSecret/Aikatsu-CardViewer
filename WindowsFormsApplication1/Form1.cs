using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using MaterialSkin;
using MaterialSkin.Controls;

namespace WindowsFormsApplication1
{

    public partial class Form1 : MaterialForm
    {
        int current_index = 0;
        int amount = 0;
        int deckamount = 0;
        Card[] list = new Card[10000];
        Card[] deck = new Card[10000];
        public Form1()
        {
            InitializeComponent();
            LoadInformation();
            materialProgressBar1.Value = 0;
            Box1.BackColor = Color.Brown;
        }

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
            str = str.Replace("<br />", " ");
            str = str.Replace("<br />", " ");
            str = str.Replace("<p>", " ");
            str = str.Replace("</p>", " ");
            str = str.Replace("<tr>", " ");
            str = str.Replace("</tr>", " ");
            str = str.Replace("</a>", " ");
            str = str.Replace("・", " ");
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
            if(str.Contains("<a href"))
            {
                int index1 = str.LastIndexOf("<a href");
                string temp1 = str.Substring(0, index1);
                int index2 = str.IndexOf("<a href");
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
                int index3 = temp2.IndexOf("sup>");
                temp2 = temp2.Substring(index3 + 4);
                str = temp1 + temp2;
            }
            str = str.Replace("?", " ");
            str = str.Replace("?", " ");
            return str;
        }

        public void InitDeck()
        {
            picturebox1.Image = null;
            label2.Text = "";
            label4.Text = "";
            label6.Text = "";
            label8.Text = "";
            label10.Text = "";
            for (int i = 1; i <= deckamount; i++)
            {
                deck[i] = new Card();
            }
            current_index = 0;
            deckamount = 0;
            materialProgressBar1.Value = 0;
        }

        public void InitList()
        {
            InitDeck();
            for (int i = 1; i <= amount; i++)
            {
                list[i] = new Card();
            }
            amount = 0;
        }

        private void RenewCard()
        {
            InitList();
            string Localname = "code";
            string Store = "source";
            var te = System.IO.File.Create(Store);
            te.Close();
            WebClient client = new WebClient();
            string downloadString = client.DownloadString("http://aikatsu.wikia.com/wiki/Aikatsu!_Photo_on_Stage!!/Cardlist");
            System.IO.File.WriteAllText(Localname, downloadString, Encoding.Default);
            System.IO.StreamReader sourcefile = new System.IO.StreamReader(Localname, true);
            string pp;
            int t = 0;
            while (t < 14)
            {
                for (int i = 1; i < 2000; i++)
                {
                    pp = sourcefile.ReadLine();
                    if (pp == "</th></tr>")
                        break;
                    if (pp == "< noscript >< link rel = \"stylesheet\"" || pp.Contains("Upgrade Cards</span>"))
                        goto BREAKTHELOOP;
                }
                pp = sourcefile.ReadLine();
                pp = ReadFileLine(sourcefile);
                int count = 0;
                string[] temp = new string[13];
                for (int i = amount + 1; i <= amount + 120; i++)
                {
                    if (pp == "<tr style=\"text-align: center;\">" || pp == "<tr style=\"text-align: Center;\">")
                        pp = ReadFileLine(sourcefile);
                    temp[0] = pp;
                    pp = ReadFileLine(sourcefile);
                    temp[1] = pp;
                    pp = ReadFileLine(sourcefile);
                    pp = EraseComment(pp);
                    temp[2] = SpiltLine(pp)[1];
                    temp[3] = SpiltLine(pp)[2];
                    pp = ReadFileLine(sourcefile);
                    temp[4] = getBetween(pp, "<a href=\"", "\"");
                    pp = ReadFileLine(sourcefile);
                    temp[5] = pp;
                    pp = ReadFileLine(sourcefile);
                    if (pp.Contains("</table>"))
                        break;
                    if (pp == "PR+" || pp == "SR+" || pp == "R+" || pp == "N+")
                    {
                        list[i] = new Card(temp[0], temp[1], temp[2], temp[3], temp[4], temp[5]);
                        count++;
                        continue;
                    }
                    temp[6] = pp;
                    list[i] = new Card(temp[0], temp[1], temp[2], temp[3], temp[4], temp[5], temp[6]);
                    count++;
                    pp = ReadFileLine(sourcefile);
                    if (pp.Contains("Dress Up") && pp.Contains("Card") && pp.Contains("Pre"))
                        pp = ReadFileLine(sourcefile);
                    if (pp.Contains("</table>"))
                        break;
                }

                for (int i = amount + 1; i <= amount + count; i++)
                {
                    System.IO.File.AppendAllText(Store, "1. " + list[i].rank + Environment.NewLine);
                    System.IO.File.AppendAllText(Store, "2. " + list[i].cardno + Environment.NewLine);
                    System.IO.File.AppendAllText(Store, "3. " + list[i].cardname + Environment.NewLine);
                    System.IO.File.AppendAllText(Store, "4. " + list[i].charname + Environment.NewLine);
                    System.IO.File.AppendAllText(Store, "5. " + list[i].url + Environment.NewLine);
                    System.IO.File.AppendAllText(Store, "6. " + list[i].appeal + Environment.NewLine);
                    System.IO.File.AppendAllText(Store, "7. " + list[i].skill + Environment.NewLine);
                }
                amount = count + amount;
                t++;
            }

        BREAKTHELOOP:;
            for (int i = 1; i <= amount; i++)
                deck[i] = list[i];
            deckamount = amount;

        }

        private void LoadInformation()
        {
            string Path = AppDomain.CurrentDomain.BaseDirectory + @"\images\";
            System.IO.DirectoryInfo di = new System.IO.DirectoryInfo(Path);
            if (di.Exists == false)
            {
                di.Create();
            }

            string Store = "source";
            System.IO.FileInfo fi = new System.IO.FileInfo(Store);
            if (!fi.Exists)
                return;

            System.IO.StreamReader sourcefile = new System.IO.StreamReader(Store, true);
            string pp;
            pp = sourcefile.ReadLine();
            string[] temp = new string[10];
            while (pp != null)
            {
                temp[0] = pp.Substring(3);
                pp = sourcefile.ReadLine();
                temp[1] = pp.Substring(3);
                pp = sourcefile.ReadLine();
                temp[2] = pp.Substring(3);
                pp = sourcefile.ReadLine();
                temp[3] = pp.Substring(3);
                pp = sourcefile.ReadLine();
                temp[4] = pp.Substring(3);
                pp = sourcefile.ReadLine();
                temp[5] = pp.Substring(3);
                pp = sourcefile.ReadLine();
                amount++;
                if (pp.Contains("7."))
                {
                    temp[6] = pp.Substring(3);
                    list[amount] = new Card(temp[0], temp[1], temp[2], temp[3], temp[4], temp[5], temp[6]);
                    pp = sourcefile.ReadLine();
                }
                else
                    list[amount] = new Card(temp[0], temp[1], temp[2], temp[3], temp[4], temp[5]);
            }

            for (int i = 1; i <= amount; i++)
                deck[i] = list[i];
            deckamount = amount;
            sourcefile.Close();
        }

        public void ShowCardInfo(int index)
        {
            string Store = AppDomain.CurrentDomain.BaseDirectory + @"\images\";
            System.IO.FileInfo fi = new System.IO.FileInfo(Store + "Photokatsu_" + deck[index].cardno + ".jpg");
            if (!fi.Exists)
            {
                using (WebClient client = new WebClient())
                {
                   client.DownloadFile(deck[index].url, Store + "Photokatsu_" + deck[index].cardno + ".jpg");
                }
            }

            picturebox1.Load(Store + "Photokatsu_" + deck[index].cardno + ".jpg");
            label2.Text = deck[index].cardno;
            label4.Text = deck[index].rank;
            label6.Text = deck[index].cardname;
            label8.Text = deck[index].charname;
            label10.Text = deck[index].appeal;
            materialLabel5.Text = "( " + index + " / " + deckamount + " )";
        }

        private void materialRaisedButton3_Click(object sender, EventArgs e)
        {
            RenewCard();
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            if (amount == 0)
                return;
            if (current_index - 1 <= 0)
                current_index = 1;
            else
                current_index--;

            ShowCardInfo(current_index);
            materialProgressBar1.Value = Math.Max(materialProgressBar1.Value - (10000 / deckamount), 0);
        }

        private void materialFlatButton2_Click(object sender, EventArgs e)
        {
            if (amount == 0)
                return;
            if (current_index + 1 > deckamount)
                current_index = deckamount;
            else
                current_index++;

            ShowCardInfo(current_index);
            materialProgressBar1.Value = Math.Min(materialProgressBar1.Value + (10000 / deckamount), 10000);
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            InitDeck();
            RankSearch();
        }

        private void RankSearch()
        {
            for (int i = 1; i <= amount; i++)
            {
                if (Box1.Checked && list[i].rank == "PR+")
                { deck[++deckamount] = list[i]; continue; }
                if (Box2.Checked && list[i].rank == "PR")
                { deck[++deckamount] = list[i]; continue; }
                if (Box3.Checked && list[i].rank == "SR+")
                { deck[++deckamount] = list[i]; continue; }
                if (Box4.Checked && list[i].rank == "SR")
                { deck[++deckamount] = list[i]; continue; }
                if (Box5.Checked && list[i].rank == "R+")
                { deck[++deckamount] = list[i]; continue; }
                if (Box6.Checked && list[i].rank == "R")
                { deck[++deckamount] = list[i]; continue; }
                if (Box7.Checked && list[i].rank == "N+")
                { deck[++deckamount] = list[i]; continue; }
                if (Box8.Checked && list[i].rank == "N")
                { deck[++deckamount] = list[i]; }
            }
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            InitList();
            string initname = "inital";
            string Store = "source";
            string temp = System.IO.File.ReadAllText(initname);
            System.IO.File.WriteAllText(Store, temp, Encoding.Default);
            MessageBox.Show("초기화되었습니다. 프로그램을 다시 실행해주세요.");
            Close();
        }
    }

    public class Card
    {
        public string rank;
        public string cardno;
        public string cardname;
        public string charname;
        public string url;
        public string appeal;
        public string skill;
        public string memo;
        public Card() {; }
        public Card(string a, string b, string c, string d, string e, string f)
        {
            rank = a;
            cardno = b;
            cardname = c;
            charname = d;
            url = e;
            appeal = f;
            skill = null;
            memo = "";
        }
        public Card(string a, string b, string c, string d, string e, string f, string g)
        {
            rank = a;
            cardno = b;
            cardname = c;
            charname = d;
            url = e;
            appeal = f;
            skill = g;
            memo = "";
        }
    }

}
