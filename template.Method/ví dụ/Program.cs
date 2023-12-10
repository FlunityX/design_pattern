using System;
// Đây là một lớp trừu tượng định nghĩa giao diện cơ bản cho một trò chơi.
// Nó chứa một phương thức không thể triển khai được gọi là Play(),
// cũng như các phương thức trừu tượng khác Initialize(), StartGame(), và EndGame().
public abstract class Game
{
    //public void Play(): Phương thức này triển khai logic chung cho việc chơi một trò chơi
    // Nó gọi các phương thức trừu tượng để thực hiện các bước khởi tạo, bắt đầu trò chơi và kết thúc trò chơi.
    // bóng đá hay bóng rổ có 3 phương thức con
    public void Play()// phương thức mẫu - định nghĩa các phương thức // cấu trúc chung đối tg
    {
        Initialize();
        StartGame();
        EndGame();
    }
    // phương thức trừu tg để lớp con tiến hành mở rộng
    protected abstract void Initialize();

    protected abstract void StartGame();

    protected abstract void EndGame();
}
// triển khai lớp con ghi đè lên các phương thức đó
public class FootballGame : Game
{
    protected override void Initialize()
    {
        Console.WriteLine("Football game initialized");
    }

    protected override void StartGame()
    {
        Console.WriteLine("Football game started");
    }

    protected override void EndGame()
    {
        Console.WriteLine("Football game ended");
    }
}

public class BasketballGame : Game
{
    protected override void Initialize()
    {
        Console.WriteLine("Basketball game initialized");
    }

    protected override void StartGame()
    {
        Console.WriteLine("Basketball game started");
    }

    protected override void EndGame()
    {
        Console.WriteLine("Basketball game ended");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Game footballGame = new FootballGame();
        footballGame.Play();

        Console.WriteLine();

        Game basketballGame = new BasketballGame();
        basketballGame.Play();
        Console.ReadLine();
    } }
