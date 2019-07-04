using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBlackJack
{
    /// <summary>
    /// ①トランプの「数値」
    /// </summary>
    class Card
    {
        /// <summary>
        /// ①トランプの「数値」
        /// </summary>
        public string Mark { get; set; }

        /// <summary>
        /// ①トランプの「数値」
        /// </summary>
        public int No { get; set; }

        /// <summary>
        /// ②トランプの「表示」
        /// </summary>
        public string NoString
        {
            get
            {
                //①トランプの「数値」を使用して判定する
                switch (No)
                {
                    // ......ここで条件分岐。1と11と12と13の場合、AとJとQとKを返却する
                    case 1:
                        return "A";
                    case 11:
                        return "J";
                    case 12:
                        return "Q";
                    case 13:
                        return "K";
                    default:
                        break;
                }

                return No.ToString();
            }
        }


        /// <summary>
        /// ③ブラックジャックの「点」
        /// </summary>
        public int Point
        {
            get
            {
                //①トランプの「数値」を使用して判定する
                switch (No)
                {
                    // ......ここで条件分岐。11と12と13の場合、ともに10を返却する
                    case 11:
                    case 12:
                    case 13:
                        return 10;
                    default:
                        break;
                }

                return No;
            }
        }


    }
}
