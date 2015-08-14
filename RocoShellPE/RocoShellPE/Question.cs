using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RocoShellPE
{
    public class Question
    {
        private string _A;
        private string _B;
        private string _C;
        private string _D;
        private string _Answer;
        private string _Question;

        public string A { get { return _A; } }
        public string B{ get { return _B; } }
        public string C { get { return _C; } }
        public string D { get { return _D; } }
        public string answer { get { return _Answer; } }
        public string question { get { return _Question; } }

        private Question(string Question,string A,string B,string C,string D,string Answer)
        {
            _Question = Question;
            _A = A;
            _B = B;
            _C = C;
            _D = D;
            _Answer = Answer;
        }

        public static Question Init()
        {
            List<Question> qs = new List<Question>();
            qs.AddRange(
                new Question[] { 
                    new Question("以下哪个不是Love Live官方手游的名称","Love Live! School Idol Festival","Love Live! 学园偶像祭","ラブライブ！スクール アイドル フェスティバル","Love Live! School Idol Paradise","D"),//1
                    new Question("TV动画第一季第一集，以下哪个不是μ's的成员","高坂穂乃果","園田海未","絢瀬繪里","南ことり","C"),//2
                    new Question("以下哪个只有UR卡","妮可の母亲","矢澤にこ","矢澤ココア","矢澤こころ","A"),//3
                    new Question("以下哪个组合没有μ's成员","Printemps","BiBi","Lily White","Arashi","D"),//4
                    new Question("以下哪个不是A-RISE的成员","绮罗 ツバサ","絢瀬 绘里","统堂 英玲奈","优木 あんじゅ","B"),//5
                    new Question("以下那首歌是μ's的","Shocking Party","Private War","友情ノーチェンジ","初音ミク","C"),//6
                    new Question("Love Live!手游卡没有哪个级别","R","HSR","SR","UR","B"),//7
                    new Question("TV动画第二季第4集果果的梦排名第4的队伍","A-RISE","Mutant Girls","East Heart","Midnight Cats","B"),//8
                    new Question("妮可的护腕上的数字是","15","25","35","45","B"),//9
                    new Question("谁偷了妮可的护腕","松鼠","矢澤ココア","矢澤こころ","高坂穂乃果","A"),//10
                    }                
                );
            int i = 0;
            Random rnd = new Random();
            i = rnd.Next(0, qs.Count);
            return qs[i];
        }
    }
}
