using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBlackJack
{
    class User : PlayerBase
    {
        public User(List<Card> hand, int score, bool burst) : base(hand, score, burst) { }

        public override void Draw(List<Card> decks)
        {
            var drawcard = Util.DrawCommon(this,decks);


            // 表示
            Console.WriteLine("あなたの引いたカードは" + drawcard.Mark + "の" + drawcard.NoString + "です。");
        }
    }
}
