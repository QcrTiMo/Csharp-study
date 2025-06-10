namespace _002_简单计算器
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("欢迎使用简单计算器！");
            Console.WriteLine("------------");

            double num1, num2;  //用于存储操作数
            char operation;  //用于存储操作符
            double result = 0;  //用于存储结果

            //获取第一个数字
            while (true)
            {
                Console.Write("请输入第一个数字：");
                String input1 = Console.ReadLine();
                if (double.TryParse(input1, out num1))
                {
                    break;  //转换成功跳出循环
                }
                else
                {
                    Console.WriteLine("输入无效，请重新输入：");
                }
            }

            //获取运算符
            while (true)
            {
                Console.WriteLine("请输入运算符（+、-、*、/）：");
                String opInput = Console.ReadLine();
                if (opInput.Length == 1 && "+*-/".Contains(opInput[0]))
                {
                    operation = opInput[0];  //获取第一个字符作为运算符
                    break;
                }
                else
                {
                    Console.WriteLine("输入无效，请重新输入运算符：");
                }
            }

            //获取第二个数字
            while (true)
            {
                Console.Write("请输入第二个数字:");
                String input2 = Console.ReadLine();
                if (double.TryParse(input2, out num2))
                {
                    break;  //转换成功跳出循环
                }
                else
                {
                    Console.WriteLine("输入无效，请重新输入：");
                }
            }

            bool calculate = true;  //用于控制是否继续计算
            switch (operation)
            {
                case '+':
                    result = num1 + num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;
                case '*':
                    result = num1 * num2;
                    break;
                case '/':
                    if (num2 == 0)
                    {
                        Console.WriteLine("除数不能为零，请重新输入第二个数字：");
                        calculate = false;  //设置为false，重新获取第二个数字
                    }
                    else
                    {
                        result = num1 / num2;
                    }
                    break;
                default:
                    Console.WriteLine("无效运算符");
                    calculate = false;
                    break;
            }

            //如果计算成功，输出结果
            if (calculate)
            {
                Console.WriteLine($"结果：{num1} {operation} {num2}  = {result}");
            }

            Console.WriteLine("---------------------");
            Console.WriteLine("按任意键退出...");
            Console.ReadKey();
        }
    }
}
