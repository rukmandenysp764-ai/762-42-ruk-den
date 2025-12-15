namespace SingletonMethodClass
{
    public sealed class DBManager
    {
        private static readonly Lazy<DBManager> _instance = new Lazy<DBManager>(() => new DBManager());

        private DBManager()
        {
            Console.WriteLine("DBManager створено (підключення до БД ініціалізовано).");
        }

        public static DBManager Instance => _instance.Value;

        public void Connect()
        {
            Console.WriteLine("Підключено до бази даних (симуляція).");
        }

        public void ExecuteQuery(string sql)
        {
            Console.WriteLine($"Виконано запит: {sql}");
        }

        public void Disconnect()
        {
            Console.WriteLine("Відключено від бази даних.");
        }
    }
}

namespace SingletonMethodClass
{

    public sealed class DocumentSaver
    {
        private static readonly Lazy<DocumentSaver> _instance = new Lazy<DocumentSaver>(() => new DocumentSaver());

        private DocumentSaver()
        {
            Console.WriteLine("DocumentSaver створено (репозиторій ініціалізовано).");
        }

        public static DocumentSaver Instance => _instance.Value;

        public void SaveDocument(string name, string content)
        {
            Console.WriteLine($"Документ '{name}' збережено на диск.");
            Console.WriteLine($"Вміст: {content.Substring(0, Math.Min(50, content.Length))}...");
        }

        public string LoadDocument(string name)
        {
            Console.WriteLine($"Документ '{name}' завантажено з диска.");
            return $"[Вміст документа {name}: приклад даних...]";
        }
    }
}

namespace SingletonMethodClass
{

    public sealed class Logger
    {
        private static readonly Lazy<Logger> _instance = new Lazy<Logger>(() => new Logger());

        private Logger()
        {
            Console.WriteLine("Logger створено (файл логів відкрито).");
        }

        public static Logger Instance => _instance.Value;

        public void Log(string message)
        {
            string logEntry = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss} | {message}";
            Console.WriteLine($"[ЛОГ] {logEntry}");
        }
    }
}