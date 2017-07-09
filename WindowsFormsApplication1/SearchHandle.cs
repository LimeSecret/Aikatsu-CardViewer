using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public partial class Form1
    {
        private void AllListToDeck()
        {
            deck = list.GetRange(0, list.Count);
        }

        private void RankSearch()
        {
            List<Card> tempdeck = new List<Card>();

            for (int i = 0; i < (deck.Count); i++)
            {
                if (Box1.Checked && deck[i].rank == "PR+")
                { tempdeck.Add(deck[i]); continue; }
                if (Box2.Checked && deck[i].rank == "PR")
                { tempdeck.Add(deck[i]); continue; }
                if (Box3.Checked && deck[i].rank == "SR+")
                { tempdeck.Add(deck[i]); continue; }
                if (Box4.Checked && deck[i].rank == "SR")
                { tempdeck.Add(deck[i]); continue; }
                if (Box5.Checked && deck[i].rank == "R+")
                { tempdeck.Add(deck[i]); continue; }
                if (Box6.Checked && deck[i].rank == "R")
                { tempdeck.Add(deck[i]); continue; }
                if (Box7.Checked && deck[i].rank == "N+")
                { tempdeck.Add(deck[i]); continue; }
                if (Box8.Checked && deck[i].rank == "N")
                { tempdeck.Add(deck[i]); }
            }
            deck = tempdeck.GetRange(0, tempdeck.Count);
        }

        private void NumberSearch(string start, string end)
        {
            List<Card> tempdeck = new List<Card>();

            int a; int b;
            try
            {
                if (start == "")
                    a = 0;
                else
                    a = Convert.ToInt32(start);
                if (end == "")
                    b = list.Count-1;
                else
                    b = Convert.ToInt32(end);

                for (int i = 0; i < (deck.Count); i++)
                {
                    if (Convert.ToInt32(deck[i].cardno) >= a && Convert.ToInt32(deck[i].cardno) <= b)
                        tempdeck.Add(deck[i]);
                }
                deck = tempdeck.GetRange(0, tempdeck.Count);
            }
            catch
            {
                MessageBox.Show("잘못된 카드 숫자를 입력하였습니다.");
            }
        }
        private void CharacterSearch(string str)
        {

            if (str.Contains("("))
            {
                int index1 = str.LastIndexOf("(");
                string temp1 = str.Substring(0, index1);
                int index2 = str.IndexOf("(");
                string temp2 = str.Substring(index2);
                int index3 = temp2.IndexOf(")");
                temp2 = temp2.Substring(index3 + 1);
                str = temp1 + temp2;
            }
            if (str.Contains("ALL") || str == " ")
            {
                return;
            }
            string input = str.Trim();

            List<Card> tempdeck = new List<Card>();
            string tempchar;

            for (int i = 0; i < (deck.Count); i++)
            {
                tempchar = deck[i].charname.ToLower();
                tempchar = tempchar.Replace("+", "");
                if (tempchar.Contains(input) && tempchar[0] == input[0])
                {
                    tempdeck.Add(deck[i]);
                }
            }
            deck = tempdeck.GetRange(0, tempdeck.Count);
        }


        private void SubstringSearch(string input)
        {
            input = input.ToLower();
            List<Card> tempdeck = new List<Card>();

            for (int i = 0; i < (deck.Count); i++)
            {
                if(deck[i].charname.ToLower().Contains(input))
                {
                    tempdeck.Add(deck[i]);
                    continue;
                }
                if (deck[i].cardname.ToLower().Contains(input))
                {
                    tempdeck.Add(deck[i]);
                    continue;
                }
                if (deck[i].appeal.ToLower().Contains(input))
                {
                    tempdeck.Add(deck[i]);
                }
            }
            deck = tempdeck.GetRange(0, tempdeck.Count);
        }

    }
}
