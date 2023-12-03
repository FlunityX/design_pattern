namespace singleton
{
    public class Logger
    {
        // Hàm tạo đơn riêng tư và không tham số
        private static Logger instance;
      
        private Logger()
        {
            // Khởi tạo logger
        }
        //Biến tĩnh để giữ tham chiếu đến phiên bản được tạo duy nhất
        public static Logger Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Logger();
                }
                return instance;
            }
        }

        public void LogMessage(string message)
        {
            // Ghi log thông báo
            Console.WriteLine($"Log Message: {message}");
        }

        public void LogError(string error)
        {
            // Ghi log lỗi
            Console.WriteLine($"Log Error: {error}");
        }

        public void LogWarning(string warning)
        {
            // Ghi log cảnh báo
            Console.WriteLine($"Log Warning: {warning}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Logger logger = Logger.Instance;
            logger.LogMessage("This is a log message.");
            logger.LogError("This is an error.");
            logger.LogWarning("This is a warning.");
            Console.ReadLine();
        }
    }

}