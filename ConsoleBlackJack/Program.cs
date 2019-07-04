using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBlackJack
{
    class Program
    {
        static void Main(string[] args)
        {

            // マーク
            string[] marks = new string[] { "ハート", "スペード", "クラブ", "ダイヤ" };
            // 数字
            int[] nos = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };

            // 山札
            List<Card> decks = new List<Card>();

            // 山札作成
            foreach (var mark in marks)
            {
                foreach (var no in nos)
                {

                    Card card = new Card
                    {
                        Mark = mark,

                        No = no
                    };

                    //「ハートの5」、「スペードのJ」などの文字列が順番にdecksに代入される
                    decks.Add(card);
                }
            }

            User user = new User(new List<Card>(), 0, false);

            Dealer dealer = new Dealer(new List<Card>(), 0, false);

            // プレイヤーとディーラーはそれぞれ、カードを2枚引く
            user.Draw(decks);
            user.Draw(decks);
            dealer.Draw(decks);
            dealer.Draw(decks);

            


            while (true)
            {

                //現在の得点を表示
                Console.WriteLine("あなたの現在の得点は" + user.Score.ToString() + "です");
                // カードを引くか
                Console.Out.WriteLine("カードを引きますか？引く場合はYを、引かない場合はNを入力してください。");

                var drawflag = Console.ReadLine();

                if (drawflag.Equals("y") || drawflag.Equals("Y"))
                {
                    user.Draw(decks);


                    if (user.Burst)
                    {
                        break;
                    }
                }
                else if (drawflag.Equals("n") || drawflag.Equals("N"))
                {
                    break;
                }

            }

            //現在の得点を表示
            Console.WriteLine("ディーラーの2枚目のカードは" + dealer.Hand[1].Mark + "の" + dealer.Hand[1].NoString + "です。");

            while (true)
            {
                dealer.Draw(decks);

                if (dealer.Score >= 17)
                {
                    break;
                }

                Console.WriteLine("ディーラーの現在の得点は" + dealer.Score.ToString() + "です");

            }

            Console.WriteLine("あなたの得点は" + user.Score.ToString() + "です");

            Console.WriteLine("ディーラーの得点は" + dealer.Score.ToString() + "です");

            // 判定
            if ((user.Score > dealer.Score && !user.Burst) || (!user.Burst && dealer.Burst))
            {
                Console.WriteLine("YOU WIN!!");
            }
            else if (user.Score !=  dealer.Score && !dealer.Burst)
            {
                Console.WriteLine("YOU LOSE");
            }
            else
            {
                Console.WriteLine("引き分け");
            }


            Console.WriteLine("また遊んでね");

        }
    }
}
