using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matem
{
    public class Pair<T, K>
    {
        public T First { get; set; }
        public K Second { get; set; }


    }
    public class Task
    {
        public string question { get; set; }
        public string Theme { get; set; }
        public List<Pair<string, bool>> answers = new List<Pair<string, bool>>();

        public Task() { }
        public Task(string S, string TH, List<Pair<string, bool>> a)
        {
            question = S;
            Theme = TH;
            answers = a;
        }
        public void AddInList()
        {
            question = Console.ReadLine();
            Pair<string, bool> mur = new Pair<string, bool>();
            mur.First = Console.ReadLine();
            mur.Second = false; // пометка неправильных ответов, ДОБАВИТЬ!
        }

    }
    //List<Task> a = new List<Task>();
    //Pair<string, bool> c = new Pair<string, bool>();
    //c.First = "LLL";
    //        c.Second = false;
    //        List<Pair<string, bool>> an = new List<Pair<string, bool>>();
    //string mm = " llll";
    //Task t1 = new Task();
    //t1.question = mm;
    //        an.Add(c);
    //        t1.answers = an;
    //        a.Add(t1);
    //        int mur = 0;
}
