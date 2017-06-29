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

        int current_index = 0;
        int amount = 0;
        int deckamount = 0;
        Card[] list = new Card[10000];
        Card[] deck = new Card[10000];

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
            materialLabel5.Text = "( " + " / "  + " )";
        }

        public void InitList()
        {
            InitDeck();
            for (int i = 1; i <= amount; i++)
            {
                list[i] = new Card();
            }
            amount = 0;

            string Localname = AppDomain.CurrentDomain.BaseDirectory + @"\resources\code";
            string Store = AppDomain.CurrentDomain.BaseDirectory + @"\resources\source";
            string Infocode = AppDomain.CurrentDomain.BaseDirectory + @"\resources\infocode";
            File.WriteAllText(Localname, "", Encoding.Default);
            File.WriteAllText(Store, "", Encoding.Default);
            File.WriteAllText(Infocode, "", Encoding.Default);

        }

        private void RenewCard()
        {
            InitList();
            string page_image = "http://aikatsu.wikia.com/wiki/Aikatsu!_Photo_on_Stage!!/Cardlist";
            string page_data = "http://aikatsu.wikia.com/wiki/Aikatsu!_Photo_on_Stage!!/Cardlist?action=edit";
            ReadPage(page_image, page_data);
            page_image = "http://aikatsu.wikia.com/wiki/Aikatsu!_Photo_on_Stage!!/Cardlist/Page_2";
            page_data = "http://aikatsu.wikia.com/wiki/Aikatsu!_Photo_on_Stage!!/Cardlist/Page_2?action=edit";
            ReadPage(page_image, page_data);
        }


        private void ReadPage(string info1, string info2)
        {
            string Localname = AppDomain.CurrentDomain.BaseDirectory + @"\resources\code";
            string Store = AppDomain.CurrentDomain.BaseDirectory + @"\resources\source";
            string Infocode = AppDomain.CurrentDomain.BaseDirectory + @"\resources\infocode";

            WebClient client = new WebClient();
            string downloadString = client.DownloadString(info1);
            File.WriteAllText(Localname, downloadString, Encoding.Default);
            downloadString = client.DownloadString(info2);
            File.WriteAllText(Infocode, downloadString, Encoding.Default);
            StreamReader sourcefile = new StreamReader(Localname, true);
            StreamReader sourcefile2 = new StreamReader(Infocode, true);
            string pp;
            string qq;
            int t = 0;
            while (t < 14)
            {
                for (int i = 1; i < 2000; i++)
                {
                    pp = sourcefile.ReadLine();
                    
                    if (pp == "</th></tr>")
                        break;
                    if (pp == "< noscript >< link rel = \"stylesheet\"" || pp == null || pp.Contains("Upgrade Cards</span>"))
                        goto BREAKTHELOOP;
                }

                for (int i = 1; i < 2000; i++)
                {
                    pp = sourcefile2.ReadLine();
                    if (pp == "|-align=\"center\"" || pp == "|- align=\"center\"")
                        break;
                    if (pp == "==Upgrade Cards==")
                        goto BREAKTHELOOP;
                }
                pp = sourcefile.ReadLine();
                pp = ReadFileLine(sourcefile);
                qq = ReadFileLine(sourcefile2);
                int count = 0;
                string[] temp = new string[13];
                for (int i = amount + 1; i <= amount + 1200; i++)
                {
                    if (pp == "<tr style=\"text-align: center;\">" || pp == "<tr style=\"text-align: Center;\">")
                        pp = ReadFileLine(sourcefile);
                    temp[0] = qq;
                    pp = ReadFileLine(sourcefile);
                    qq = ReadFileLine(sourcefile2);
                    temp[1] = qq;
                    pp = ReadFileLine(sourcefile);
                    qq = ReadFileLine(sourcefile2);
                    qq = EraseComment(qq);
                    temp[2] = SpiltLine(qq)[1];
                    temp[3] = SpiltLine(qq)[2];
                    pp = ReadFileLine(sourcefile);
                    qq = ReadFileLine(sourcefile2);
                    temp[4] = getBetween(pp, "<a href=\"", "\"");
                    pp = ReadFileLine(sourcefile);
                    qq = ReadFileLine(sourcefile2);
                    temp[5] = qq;
                    pp = ReadFileLine(sourcefile);
                    qq = ReadFileLine(sourcefile2);

                    if (pp.Contains("</table>"))
                        break;
                    if (qq.Contains("align=\"center\""))
                    {
                        qq = ReadFileLine(sourcefile2);
                        list[i] = new Card(temp[0], temp[1], temp[2], temp[3], temp[4], temp[5]);
                        count++;
                        continue;
                    }
                    if (qq == "PR+" || qq == "SR+" || qq == "R+" || qq == "N+" || qq == "N" || qq == "R" || qq == "SR" || qq == "PR")
                    {
                        list[i] = new Card(temp[0], temp[1], temp[2], temp[3], temp[4], temp[5]);
                        count++;
                        continue;
                    }
                    temp[6] = qq;
                    list[i] = new Card(temp[0], temp[1], temp[2], temp[3], temp[4], temp[5], temp[6]);
                    count++;
                    pp = ReadFileLine(sourcefile);
                    qq = ReadFileLine(sourcefile2);
                    if (qq.Contains("Dress Up") && qq.Contains("Card") && qq.Contains("Pre"))
                    {
                        pp = ReadFileLine(sourcefile);
                        qq = ReadFileLine(sourcefile2);
                    }
                    if (pp.Contains("</table>"))
                        break;
                    qq = ReadFileLine(sourcefile2);
                }

                for (int i = amount + 1; i <= amount + count; i++)
                {
                    File.AppendAllText(Store, "1. " + list[i].rank + Environment.NewLine);
                    File.AppendAllText(Store, "2. " + list[i].cardno + Environment.NewLine);
                    File.AppendAllText(Store, "3. " + list[i].cardname + Environment.NewLine);
                    File.AppendAllText(Store, "4. " + list[i].charname + Environment.NewLine);
                    File.AppendAllText(Store, "5. " + list[i].url + Environment.NewLine);
                    File.AppendAllText(Store, "6. " + list[i].appeal + Environment.NewLine);
                    File.AppendAllText(Store, "7. " + list[i].skill + Environment.NewLine);
                }
                amount = count + amount;
                t++;
            }


        BREAKTHELOOP:;
            for (int i = 1; i <= amount; i++)
                deck[i] = list[i];
            deckamount = amount;
            sourcefile.Close();
            sourcefile2.Close();
            File.Delete(Localname);
            File.Delete(Infocode);
        }


        private void LoadInformation()
        {
            string Path = AppDomain.CurrentDomain.BaseDirectory + @"\images\";
            System.IO.DirectoryInfo di = new System.IO.DirectoryInfo(Path);
            if (di.Exists == false)
            {
                di.Create();
            }

            string Store = AppDomain.CurrentDomain.BaseDirectory + @"\resources\source";
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
            string Loading= AppDomain.CurrentDomain.BaseDirectory + @"\resources\loading.png";
            try
            {
                System.IO.FileInfo fi = new System.IO.FileInfo(Store + "Photokatsu_" + deck[index].cardno + ".jpg");
                if (!fi.Exists)
                {
                    picturebox1.Load(Loading);
                    Thread imgthread = new Thread(ImageDownload);
                    imgthread.Start(index);
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
                materialLabel5.Text = "( " + index + " / " + deckamount + " )";
                materialProgressBar1.Value = Convert.ToInt32((Convert.ToDouble(current_index) / Convert.ToDouble(deckamount)) * 10000);
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
                picturebox1.Load(Store + "Photokatsu_" + deck[index].cardno + ".jpg");
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
                for (int i = 1; i <= amount; i++)
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
            if (deckamount != 0)
            {
                current_index = 1;
                ShowCardInfo(current_index);
            }
            else
            {
                picturebox1.Load(Noresult);
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

}
