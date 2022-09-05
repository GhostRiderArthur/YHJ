using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 银行家
{
    internal class YHJ
    {
        public int ResourceNum { get; set; }
        public int ProcessNum { get; set; }
        public int[] Available { get; set; }
        public int[,] Max { get; set; }
        public int[,] Allocation { get; set; }
        public int[,] Need { get; set; }
        public bool[] Finish { get; set; }
        public int[,] Work { get; set; }
        public bool IsSafe()
        {
            int AllFinish = 0;
            Work = (int[,])Allocation.Clone();
            while (AllFinish != ProcessNum)
            {
                for()
            }
            return true;
        }
        public bool IsAssignment()
        {

            return false;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            YHJ yhj = new YHJ();
            yhj.ResourceNum = 3;
            yhj.ProcessNum = 5;
            //可分配资源数
            yhj.Available = new int[3] { 3,3,2 };
            //最大需求
            yhj.Max = new int[5,3] { { 7, 5, 3 }, { 3, 2, 2 }, { 9, 0, 2 }, { 2, 2, 2 }, { 4, 3, 3 } };
            //已分配资源
            yhj.Allocation= new int[5,3] { { 0,1,0},{ 2,0,0},{ 3,0,2},{ 2,1,1},{ 0,0,2} };
            //还需要的资源
            yhj.Need = new int[5,3] { { 7,4,3},{ 1,2,2},{ 6,0,0},{ 0,1,1},{ 4,3,1} };
            //是否安全
            yhj.Finish = new bool[5];
            
            
            Console.ReadLine();

        }
    }
}
