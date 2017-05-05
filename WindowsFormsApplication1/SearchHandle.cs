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
            Array.Copy(list, deck, 10000);
            deckamount = amount;
        }

        private void RankSearch()
        {
            Card[] tempdeck = new Card[10000];
            int index = 0;
            for (int i = 1; i <= deckamount; i++)
            {
                if (Box1.Checked && deck[i].rank == "PR+")
                { tempdeck[++index] = deck[i]; continue; }
                if (Box2.Checked && deck[i].rank == "PR")
                { tempdeck[++index] = deck[i]; continue; }
                if (Box3.Checked && deck[i].rank == "SR+")
                { tempdeck[++index] = deck[i]; continue; }
                if (Box4.Checked && deck[i].rank == "SR")
                { tempdeck[++index] = deck[i]; continue; }
                if (Box5.Checked && deck[i].rank == "R+")
                { tempdeck[++index] = list[i]; continue; }
                if (Box6.Checked && deck[i].rank == "R")
                { tempdeck[++index] = deck[i]; continue; }
                if (Box7.Checked && deck[i].rank == "N+")
                { tempdeck[++index] = deck[i]; continue; }
                if (Box8.Checked && deck[i].rank == "N")
                { tempdeck[++index] = deck[i]; }
            }
            deckamount = index;
            Array.Copy(tempdeck, deck, 10000);
        }

        private void NumberSearch(string start, string end)
        {
            Card[] tempdeck = new Card[10000];
            int index = 0;

            int a; int b;
            try
            {
                if (start == "")
                    a = 1;
                else
                    a = Convert.ToInt32(start);
                if (end == "")
                    b = 10000;
                else
                    b = Convert.ToInt32(end);

                for (int i = 1; i <= deckamount; i++)
                {
                    if (Convert.ToInt32(deck[i].cardno) >= a && Convert.ToInt32(deck[i].cardno) <= b)
                        tempdeck[++index] = deck[i];
                }
                deckamount = index;
                Array.Copy(tempdeck, deck, 10000);
            }
            catch
            {
                MessageBox.Show("잘못된 카드 숫자를 입력하였습니다.");
            }
        }

        private void CharacterSearch(string input)
        {
            input = input.ToLower();
            Card[] tempdeck = new Card[10000];
            int index = 0;

            for (int i = 1; i <= deckamount; i++)
            {
                if(deck[i].charname.ToLower().Contains(input))
                {
                    tempdeck[++index] = deck[i];
                }
            }
            deckamount = index;
            Array.Copy(tempdeck, deck, 10000);
        }

    }
}
