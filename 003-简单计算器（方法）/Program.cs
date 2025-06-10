namespace _003_简单计算器_方法_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //前面基本一致
            Console.WriteLine("欢迎使用简单计算器！");
            Console.WriteLine("------------");

            double num1, num2;  //用于存储操作数
            char operation;  //用于存储操作符
            double result = 0;  //用于存储结果
            bool calculate = false;  //用于控制是否继续计算

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
                    if (operation == '/' && num2 == 0)
                    {
                        Console.WriteLine("除数不能为0，无法进行除法运算！请重新输入第二个数字：");
                        continue;  //如果是除法且除数为0，则重新输入
                    }
                    break;  //转换成功跳出循环
                }
                else
                {
                    Console.WriteLine("输入无效，请重新输入：");
                }
            }

            calculate = true;  
            switch (operation)
            {
                case '+':
                    result = Add(num1, num2);
                    break;
                case '-':
                    result = Subtract(num1, num2);
                    break;
                case '*':
                    result = Multiply(num1, num2);
                    break;
                case '/':
                    result = Divide(num1, num2);
                    break;
                default:
                    Console.WriteLine("未知的运算符！");
                    calculate = false;  //如果运算符不合法，则不进行计算
                    break;
            }
            if (calculate)
            {
                Console.WriteLine($"结果：{num1} {operation} {num2}  = {result}");
            }

            Console.WriteLine("---------------------");
            Console.WriteLine("按任意键退出...");
            Console.ReadKey();
        }

        //加法方法
        static double Add(double a, double b)
        {
            return a + b;
        }

        //减法
        static double Subtract(double a, double b)
        {
            return a - b;
        }

        //乘法
        static double Multiply(double a, double b)
        {
            return a * b;
        }

        //除法
        static double Divide(double a, double b)
        {
                return a / b;
        }
    }
}
