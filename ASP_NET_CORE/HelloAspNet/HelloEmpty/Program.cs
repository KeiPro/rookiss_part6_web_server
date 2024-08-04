namespace HelloEmpty
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

			// RazorPage�� ����ϰڴٴ� �ڵ�.
			builder.Services.AddRazorPages();

			var app = builder.Build();

            app.UseRouting();

			app.MapRazorPages();

			app.Run();
        }
    }
}
