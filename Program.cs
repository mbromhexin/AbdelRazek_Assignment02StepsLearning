using System.Runtime.CompilerServices;

namespace AbddelRazek_Assignment02_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // By AbdelRazek Mohamed
            #region Assignment01
            //bool flag = false;
            //do
            //{

            //    Console.Write("Do You Want Know Your Degree?\n1)Yes\t2)No: ");
            //    int changeFlag = int.Parse(Console.ReadLine());
            //    if(changeFlag == 1)
            //    {
            //        flag = true;
            //        Console.Clear();
            //    }
            //    else
            //    {
            //        flag = false;
            //        break;
            //    }

            //    Console.Write("Enter Your Degree: ");
            //    int degree = int.Parse(Console.ReadLine());
            //    if (degree > 0 && degree <= 50)
            //    {
            //        Console.WriteLine("You Fail");
            //    }
            //    else if (degree > 50 && degree <= 65)
            //    {
            //        Console.WriteLine("You Fair");
            //    }
            //    else if (degree > 65 && degree <= 75)
            //    {
            //        Console.WriteLine("You Good");
            //    }
            //    else if (degree > 75 && degree <= 85)
            //    {
            //        Console.WriteLine("You Very Good");
            //    }
            //    else if (degree > 85 && degree <= 100)
            //    {
            //        Console.WriteLine("You Excelent");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Enter Valid Degree");
            //    }

            //} while (flag);

            #endregion

            #region Assignmet02

            bool flag = false;
            do
            {
                Console.WriteLine("1)Good Morning");
                Console.WriteLine("2)Good Evening");
                Console.WriteLine("3)Good After noon");
                Console.WriteLine("4)Good Night");
                Console.Write("Enter Your Choies: ");
                int choies = int.Parse(Console.ReadLine());

                switch (choies) 
                {
                    case 1: Console.WriteLine("Good Morning");
                        break;

                    case 2:
                        Console.WriteLine("Good Evening");
                        break;

                    case 3:
                        Console.WriteLine("Good After noon");
                        break;

                    case 4:
                        Console.WriteLine("Good Night");
                        break;

                    default: Console.WriteLine("Enter Valide Choise");
                        break;
                }

                Console.Write("Do You Want To Contenue Y or N: ");
                string yesOrNo = Console.ReadLine();
                if (yesOrNo == "y" || yesOrNo == "Y")
                {
                    flag = true;
                    Console.Clear();
                }
                else
                {
                    flag = false;
                   
                }


            }while (flag);
            #endregion









        }
    }
}
