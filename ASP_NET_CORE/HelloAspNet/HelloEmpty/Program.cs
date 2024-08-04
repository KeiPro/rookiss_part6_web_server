namespace HelloEmpty
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

			// RazorPage를 사용하겠다는 코드.
			builder.Services.AddRazorPages();

			var app = builder.Build();

            app.UseRouting();

			app.MapRazorPages();

			app.Run();
        }
    }
}
