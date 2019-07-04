using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBlackJack
{
    class Util
    { 

        internal static Card DrawCommon(PlayerBase player, List<Card> decks)
        {

            // カードを引く
            Random random = new Random();

            var drawcard = decks[random.Next(decks.Count)];

            // 手札に追加
            player.Hand.Add(drawcard);

            // デッキから引いた手札を削除
            decks.Remove(drawcard);

            // スコアに追加
            player.Score += drawcard.Point;

            // バースト判定
            if (player.Score > 21)
            {
                player.Burst = true;
            }

            return drawcard;
        }
    }
}
