using DigitalMusicLibrary_BE.Middleware;

namespace DigitalMusicLibraryAPI.Middleware
{
	public static class ExceptionMiddlewareExtension
	{
		public static void ConfigureExceptionMiddleware(this IApplicationBuilder app)
		{
			app.UseMiddleware<ExceptionMiddleware>();
		}
	}
}
