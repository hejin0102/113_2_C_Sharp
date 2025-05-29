using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coin_Toss
{
    // 這個類別用來表示擲硬幣的相關邏輯與功能
    public class Coin
    {
        private string sideUp; //硬幣正面朝上的一面
        private static Random rand = new Random(); //隨機樹生成器

        // 建構子，初始化硬幣正反面
        public Coin()
        {
            sideUp = "正面"; // 預設為正面
        }

        // 擲硬幣方法，隨機決定正反面
        public void Toss()
        {
            //模擬擲硬幣,隨機選擇正面或反面
            if (rand.Next(2) == 0)
            {
                sideUp = "正面";
            }
            else
            {
                sideUp = "反面";
            }
        }


        // 取得目前正反面
        public string GetsideUp()
        {
            return sideUp;
        }
    }
}