namespace _001_猜数字游戏;

class Program
{
    static void Main(string[] args)
    {
        //生成一个随机数
        Random randomGenerator = new Random();
        int secretNumber = randomGenerator.Next(1, 101); // 生成1到100之间的随机数

        int attempts = 0;  //记录尝试次数
        int guessedNumber;  //存储用户猜测的数字
        bool hasGuessedCorrectly = false;  //标记是否猜对了数字

        Console.WriteLine("欢迎来到猜数字游戏！");
        Console.WriteLine("我已经想好了一个1到100的随机数，你来猜猜看");

        //循环直到猜中
        while (!hasGuessedCorrectly)  //当hasGuessedCorrectly为false时继续循环
        {
            Console.Write("请输入你猜的数字");
            String userInput = Console.ReadLine();  //读取用户输入
            attempts++;  //尝试次数+1

            //尝试将用户输入转化成整数
            if (int.TryParse(userInput, out guessedNumber))  //尝试转换，如果成功，结果在guessedNumber中，并返回true
            {
                if (guessedNumber < secretNumber)
                {
                    Console.WriteLine("太小了！再试试");
                }
                else if (guessedNumber > secretNumber)
                {
                    Console.WriteLine("太大了！再试试");
                }
                else
                {
                    hasGuessedCorrectly = true;  //标记已猜中，循环将结束
                    Console.WriteLine($"恭喜你猜对了！秘密数字是{secretNumber}。");
                    Console.WriteLine($"你一共尝试了{attempts}次");
                }
            }
            else
            {
                Console.WriteLine("无效输入，请输入一个数字");
            }
        }

        Console.WriteLine("游戏结束，按任意键退出");
        Console.ReadKey();
    }
}
