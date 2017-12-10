using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//定义student结构体
struct Student
{
    public string sID;  //学号
    public string sName;//姓名
    public float sScore;//分数
}
//定义class结构体
struct Clas
{
    public string cID;   //班级编号
    public float cScore;//班级总成绩
}
namespace StudentScoreManage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==学生学号不少于3位===班级编号不少于2位==");
            int n;      //定义参赛学生个数
            int m;      //定义参赛班级个数
            Console.WriteLine("\t请问有几个参赛班级:");
            m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("=========================================");
            Clas[] cl = new Clas[m];
            for (int i = 0; i < cl.Length; i++)
            {
                Console.WriteLine("\t请输入第{0}个班级的编号:", i + 1);
                cl[i].cID = Console.ReadLine();
                Console.WriteLine("=========================================");
            }
            Console.WriteLine("\t请问有几个学生:");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("=========================================");
            Student[] stu = new Student[n];
            for (int i = 0; i < stu.Length; i++)
            {
                Console.WriteLine("\t请输入第{0}位学生的信息", i + 1);
                Console.Write("学号:");
                stu[i].sID = Console.ReadLine();
                Console.Write("姓名:");
                stu[i].sName = Console.ReadLine();
                Console.Write("分数:");
                stu[i].sScore = float.Parse(Console.ReadLine());
                Console.WriteLine("=========================================");
            }
            for (int i = 0; i < stu.Length; i++)
            {
                Console.Write("第{0}位学生信息:", i + 1);
                Console.WriteLine("\t学号:" + stu[i].sID);
                Console.WriteLine("\t\t姓名:" + stu[i].sName);
                Console.WriteLine("\t\t分数:" + stu[i].sScore);
                Console.WriteLine("=========================================");
            }
            //求班级总成绩
            for (int i = 0; i < stu.Length; i++)
            {
                for (int j = 0; j < cl.Length; j++)
                {
                    if ((stu[i].sID.Substring(0, 2) == cl[j].cID))
                        cl[j].cScore += stu[i].sScore;
                }
            }
            Console.WriteLine("\t{0}个班的总成绩分别是:\n", cl.Length);
            for (int i = 0; i < cl.Length; i++)
            {
                Console.WriteLine("\t班级编号:{0},班级总成绩:{1}", cl[i].cID, cl[i].cScore);
                Console.WriteLine("=========================================");
            }
            //班级总成绩排序====反冒泡排序====
            for (int i = 1; i < cl.Length; i++)
            {
                for (int j = 1; j <= cl.Length - i; j++)
                {
                    if (cl[j].cScore > cl[j - 1].cScore)
                    {
                        float cScoretemp;
                        string cIDtemp;

                        cScoretemp = cl[j - 1].cScore;
                        cIDtemp = cl[j - 1].cID;
                        cl[j - 1].cScore = cl[j].cScore;
                        cl[j - 1].cID = cl[j].cID;
                        cl[j].cScore = cScoretemp;
                        cl[j].cID = cIDtemp;
                    }
                }
            }
            Console.WriteLine("\t{0}个班的总成绩排名是:\n", cl.Length);
            for (int i = 0; i < cl.Length; i++)
            {
                Console.WriteLine("\t班级编号:{0},班级总成绩:{1}", cl[i].cID, cl[i].cScore);
                Console.WriteLine("=========================================");
            }
            //学生个人成绩排序====反冒泡排序====
            for (int i = 1; i < stu.Length; i++)
            {
                for (int j = 1; j <= stu.Length - i; j++)
                {
                    if (stu[j].sScore > stu[j - 1].sScore)
                    {
                        float sScoretemp;
                        string sIDtemp;
                        string sNametemp;
                        sScoretemp = stu[j - 1].sScore;
                        sIDtemp = stu[j - 1].sID;
                        sNametemp = stu[j - 1].sName;
                        stu[j - 1].sScore = stu[j].sScore;
                        stu[j - 1].sID = stu[j].sID;
                        stu[j - 1].sName = stu[j].sName;
                        stu[j].sScore = sScoretemp;
                        stu[j].sID = sIDtemp;
                        stu[j].sName = sNametemp;
                    }
                }
            }
            Console.WriteLine("\t{0}个学生成绩排名是:\n", stu.Length);
            for (int i = 0; i < stu.Length; i++)
            {
                Console.WriteLine("\t学生学号:{0},学生姓名:{1},学生分数:{2}", stu[i].sID, stu[i].sName, stu[i].sScore);
                Console.WriteLine("=========================================");
            }
            Console.ReadKey();
        }
    }
}