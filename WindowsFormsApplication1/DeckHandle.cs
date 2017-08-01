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
using System.IO;
using System.Threading;
using MaterialSkin;
using MaterialSkin.Controls;


namespace WindowsFormsApplication1
{
    public partial class Form1
    {
        int current_index = -1;
        List<Card> list = new List<Card>();
        List<Card> deck = new List<Card>();
        Dictionary<string, int> charlist = new Dictionary<string, int>();
        Dictionary<string, int> appeallist = new Dictionary<string, int>();

        public void InitDeck()
        {
            picturebox1.Image = null;
            label2.Text = "";
            label4.Text = "";
            label6.Text = "";
            label8.Text = "";
            label10.Text = "";

            deck.Clear();
            current_index = -1;
            materialProgressBar1.Value = 0;
            materialLabel5.Text = "( " + " / "  + " )";
        }

        public void InitList()
        {
            InitDeck();
            list.Clear();

            string Infocode = AppDomain.CurrentDomain.BaseDirectory + @"\resources\infocode";
            File.WriteAllText(Infocode, "", Encoding.Default);

        }

        private void RenewCard()
        {
            InitList();
            FullWebLoad();
            LoadInformation();
        }

        private void LoadInformation()
        {
            string Path = AppDomain.CurrentDomain.BaseDirectory + @"\images\";
            System.IO.DirectoryInfo di = new System.IO.DirectoryInfo(Path);
            if (di.Exists == false)
            {
                di.Create();
            }

            string Store = AppDomain.CurrentDomain.BaseDirectory + @"\resources\infocode";
            System.IO.FileInfo fi = new System.IO.FileInfo(Store);
            if (!fi.Exists)
                return;

            System.IO.StreamReader sourcefile = new System.IO.StreamReader(Store, true);
            string pp;
            pp = sourcefile.ReadLine();
            string[] temp = new string[7];
            Card temcard;
            while (pp != null)
            {
                temp[0] = pp;
                pp = sourcefile.ReadLine();
                temp[1] = pp;
                pp = sourcefile.ReadLine();
                temp[2] = pp;
                pp = sourcefile.ReadLine();
                temp[3] = pp;
                pp = sourcefile.ReadLine();
                temp[4] = pp;
                pp = sourcefile.ReadLine();
                temp[5] = pp;
                pp = sourcefile.ReadLine();
                temp[6] = pp;
                pp = sourcefile.ReadLine();

                if (Convert.ToInt32(temp[1]) < 9800)
                {
                    temcard = new Card(temp[0], temp[1], temp[2], temp[3], temp[4], temp[5], temp[6]);
                    list.Add(temcard);
                }
            }

            AllListToDeck();
            sourcefile.Close();
            MakeCharList();
            MakeAppealList();
        }

        public void ShowCardInfo(int index)
        {
            string Store = AppDomain.CurrentDomain.BaseDirectory + @"\images\";
            string Loading= AppDomain.CurrentDomain.BaseDirectory + @"\resources\loading.png";
            try
            {
                System.IO.FileInfo fi = new System.IO.FileInfo(Store + "Photokatsu_" + deck[index].cardno + ".jpg");
                if (!fi.Exists)
                {
                    picturebox1.Load(Loading);
                    ThreadPool.QueueUserWorkItem(ImageDownload, index);
                }
                else
                {
                    picturebox1.Load(Store + "Photokatsu_" + deck[index].cardno + ".jpg");
                }

            }
            catch
            {
                picturebox1.Load(Loading);
            }
            finally
            {
                label2.Text = deck[index].cardno;
                label4.Text = deck[index].rank;
                label6.Text = deck[index].cardname;
                label8.Text = deck[index].charname;
                label10.Text = deck[index].appeal;
                materialLabel5.Text = "( " + (index+1) + " / " + (deck.Count) + " )";
                materialProgressBar1.Value = Convert.ToInt32((Convert.ToDouble(current_index+1) / Convert.ToDouble(deck.Count)) * 10000);
            }
        }

        public void ImageDownload(object index_ori)
        {
            int index = (int)index_ori;
            string Store = AppDomain.CurrentDomain.BaseDirectory + @"\images\";
            using (WebClient client = new WebClient())
            {
                try { client.DownloadFile(deck[index].url, Store + "Photokatsu_" + deck[index].cardno + ".jpg"); }
                catch {;}
            }
            if (current_index == index)
            {
                try
                {
                    picturebox1.Load(Store + "Photokatsu_" + deck[index].cardno + ".jpg");
                }
                catch {; }
            }
        }

        public void DownloadAll()
        {
            Thread downthread = new Thread(DownloadAllThread);
            downthread.IsBackground = true;
            downthread.Start();
        }

        public void DownloadAllThread()
        {
            string Store = AppDomain.CurrentDomain.BaseDirectory + @"\images\";
            try
            {
                for (int i = 0; i <= (list.Count); i++)
                {
                    System.IO.FileInfo fi = new System.IO.FileInfo(Store + "Photokatsu_" + list[i].cardno + ".jpg");
                    if ((!fi.Exists) || (fi.Length == 0))
                    {
                        Thread imgthread = new Thread(ImageDownload);
                        imgthread.Start(i);
                        imgthread.Join();
                    }
                }
                MessageBox.Show("일괄 다운로드가 완료되었습니다.");
            }
            catch
            { ;}
        }

        public void NewDeckFirstPage()
        {
            string Noresult = AppDomain.CurrentDomain.BaseDirectory + @"\resources\noresult.jpg";
            if ((deck.Count) != 0)
            {
                current_index = 0;
                ShowCardInfo(current_index);
            }
            else
            {
                picturebox1.Load(Noresult);
            }
        }

        public void DeckSort()
        {
            deck.Sort(new Sorter());
        }

        public void MakeCharList()
        {
            charlist.Clear();
            charlist.Add("ALL", list.Count);
            foreach(Card x in list)
            {
                string temp = x.charname.Replace("+", "");
                temp = temp.Trim();
                temp = temp.ToLower();
                if (charlist.Keys.Contains(temp))
                {
                    charlist[temp]++;
                }
                else
                {
                    charlist.Add(temp, 1);
                }
            }

            var rank = charlist.OrderByDescending(num => num.Value);

            foreach(KeyValuePair<string,int> x in rank)
            {
                CharBox.Items.Add(x.Key + " (" + x.Value + ")");
            }
        }

        public void MakeAppealList()
        {
            appeallist.Clear();
            appeallist.Add("ALL", list.Count);
            foreach (Card x in list)
            {
                string temp = x.appeal.Replace("+", "");
                temp = temp.Trim();
                temp = temp.ToLower();
                if (appeallist.Keys.Contains(temp))
                {
                    appeallist[temp]++;
                }
                else
                {
                    appeallist.Add(temp, 1);
                }
            }

            var rank = appeallist.OrderByDescending(num => num.Value);

            foreach (KeyValuePair<string, int> x in rank)
            {
                AppealBox.Items.Add(x.Key + " (" + x.Value + ")");
            }
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

    class Sorter : IComparer<Card>
    {
        public int Compare(Card x, Card y)
        {
            int i, j;
            Int32.TryParse(x.cardno, out i);
            Int32.TryParse(y.cardno, out j);
            if(i <= j)
            {
                return -1;
            }
            return 0;
        }
    }

}
