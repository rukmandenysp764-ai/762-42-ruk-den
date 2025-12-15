using SingletonMethodClass;

namespace SingletonMethodApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Демонстрація патерну Singleton ===\n");

            UserService userService = new UserService();
            ReportService reportService = new ReportService();
            userService.RegisterUser("Іван");
            reportService.GenerateReport();

            Console.WriteLine("\n" + new string('-', 50));

            Editor editor = new Editor();
            AutoBackupService backupService = new AutoBackupService();
            editor.CreateDocument("Звіт.docx", "Важливий фінансовий звіт за 2025 рік...");
            backupService.PerformAutoBackup();

            Console.WriteLine("\n" + new string('-', 50));

            SecurityService securityService = new SecurityService();
            UserActionController actionController = new UserActionController();
            securityService.CheckAccess("admin");
            actionController.TrackAction("Користувач увійшов в систему");

            Console.WriteLine("\n" + new string('-', 50));
            Console.WriteLine("Усі сервіси використовували ОДИНАКОВІ екземпляри:");
            Console.WriteLine($"DBManager однаковий у всіх: {userService.GetDB() == reportService.GetDB()}");
            Console.WriteLine($"DocumentSaver однаковий: {editor.GetSaver() == backupService.GetSaver()}");
            Console.WriteLine($"Logger однаковий: {securityService.GetLogger() == actionController.GetLogger()}");

            Console.WriteLine("\nНатисніть будь-яку клавішу для виходу...");
            Console.ReadKey();
        }
    }


    class UserService
    {
        private readonly DBManager _db = DBManager.Instance;
        private readonly Logger _logger = Logger.Instance;

        public void RegisterUser(string name)
        {
            _logger.Log($"Реєстрація користувача: {name}");
            _db.Connect();
            _db.ExecuteQuery($"INSERT INTO Users (Name) VALUES ('{name}')");
        }

        public DBManager GetDB() => _db;
    }

    class ReportService
    {
        private readonly DBManager _db = DBManager.Instance;
        private readonly Logger _logger = Logger.Instance;

        public void GenerateReport()
        {
            _logger.Log("Генерація звіту");
            _db.Connect();
            _db.ExecuteQuery("SELECT * FROM Sales WHERE Year = 2025");
        }

        public DBManager GetDB() => _db;
    }

    class Editor
    {
        private readonly DocumentSaver _saver = DocumentSaver.Instance;
        private readonly Logger _logger = Logger.Instance;

        public void CreateDocument(string name, string content)
        {
            _logger.Log($"Створення документа: {name}");
            _saver.SaveDocument(name, content);
        }

        public DocumentSaver GetSaver() => _saver;
    }

    class AutoBackupService
    {
        private readonly DocumentSaver _saver = DocumentSaver.Instance;
        private readonly Logger _logger = Logger.Instance;

        public void PerformAutoBackup()
        {
            _logger.Log("Автоматичне резервне копіювання");
            string content = _saver.LoadDocument("Важливий документ.docx");
            Logger.Instance.Log($"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] Повідомлення");
        }

        public DocumentSaver GetSaver() => _saver;
    }

    class SecurityService
    {
        private readonly Logger _logger = Logger.Instance;

        public void CheckAccess(string role)
        {
            _logger.Log($"Перевірка доступу для ролі: {role}");
            Console.WriteLine(role == "admin" ? "Доступ дозволено." : "Доступ заборонено.");
        }

        public Logger GetLogger() => _logger;
    }

    class UserActionController
    {
        private readonly Logger _logger = Logger.Instance;

        public void TrackAction(string action)
        {
            _logger.Log($"Дія користувача: {action}");
        }

        public Logger GetLogger() => _logger;
    }
}