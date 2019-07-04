using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBlackJack
{
    class Dealer : PlayerBase
    {
        public Dealer(List<Card> hand, int score, bool burst) : base (hand, score, burst) { }

        public override void Draw(List<Card> decks)
        {
            var drawcard = Util.DrawCommon(this, decks);

            // 表示
            if (Hand.Count == 2)
            {
                Console.WriteLine("ディーラーの2枚目のカードは分かりません。");  
            }
            else
            {
                Console.WriteLine("ディーラーの引いたカードは" + drawcard.Mark + "の" + drawcard.NoString + "です。");
            }
            
        }
    }
}
