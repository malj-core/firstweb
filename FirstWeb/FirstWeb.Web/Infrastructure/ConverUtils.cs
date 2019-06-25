using System;

namespace FirstWeb.Web.Infrastructure
{
    public class ConverUtils
    {
        //生产随机数
        public static string CreateRandomNum(int numCount)
        {
            const string allChar = "0,1,2,3,4,5,6,7,8,9,A,B,C,D,E,F,G,H,I,J,K,O,P,Q,R,S,T,U,W,X,Y,Z,a,b,c,d,e,f,g,h,i,j,k,m,n,o,p,q,s,t,u,w,x,y,z";
            var allCharArray = allChar.Split(',');//拆分成数组
            var randomNum = "";
            var temp = -1;                             //记录上次随机数的数值，尽量避免产生几个相同的随机数
            var rand = new Random();
            for (var i = 0; i < numCount; i++)
            {
                if (temp != -1)
                {
                    rand = new Random(i * temp * ((int)DateTime.Now.Ticks));
                }
                var t = rand.Next(35);
                if (temp == t)
                {
                    return CreateRandomNum(numCount);
                }
                temp = t;
                randomNum += allCharArray[t];
            }
            return randomNum;
        }
    }
}