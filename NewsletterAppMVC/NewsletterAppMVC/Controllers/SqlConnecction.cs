namespace NewsletterAppMVC.Controllers
{
    internal class SqlConnecction
    {
        private string connectionString;

        public SqlConnecction(string connectionString)
        {
            this.connectionString = connectionString;
        }
    }
}