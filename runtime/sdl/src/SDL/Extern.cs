// CivOne
//
// To the extent possible under law, the person who associated CC0 with
// CivOne has waived all copyright and related or neighboring rights
// to CivOne.
//
// You should have received a copy of the CC0 legalcode along with this
// work. If not, see <http://creativecommons.org/publicdomain/zero/1.0/>.

using System;
using System.Runtime.InteropServices;
using System.Text;

namespace CivOne
{
	internal static partial class SDL
	{
		private const string DLL_SDL = "SDL2";

		[DllImportAttribute(DLL_SDL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr SDL_CreateRenderer(IntPtr window, int index, SDL_RENDERER_FLAGS flags);

		[DllImportAttribute(DLL_SDL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr SDL_CreateWindow(byte[] title, int x, int y, int w, int h, SDL_WINDOW flags);

		private static IntPtr SDL_CreateWindow(string title, int x, int y, int w, int h, SDL_WINDOW flags) => SDL_CreateWindow(Encoding.UTF8.GetBytes($"{title}{'\0'}"), x, y, w, h, flags);

		[DllImportAttribute(DLL_SDL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void SDL_GetWindowSize(IntPtr window, out int width, out int height);

		[DllImportAttribute(DLL_SDL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void SDL_SetWindowFullscreen(IntPtr window, SDL_WINDOW flags);

		[DllImportAttribute(DLL_SDL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void SDL_Delay(uint ms);

		[DllImportAttribute(DLL_SDL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void SDL_DestroyRenderer(IntPtr renderer);

		[DllImportAttribute(DLL_SDL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void SDL_DestroyWindow(IntPtr handle);

		[DllImportAttribute(DLL_SDL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void SDL_ShowCursor(int toggle);

		[DllImportAttribute(DLL_SDL, CallingConvention = CallingConvention.Cdecl)]
		private static extern uint SDL_GetMouseState(out int x, out int y);

		[DllImportAttribute(DLL_SDL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr SDL_Init(SDL_INIT flags);

		[DllImportAttribute(DLL_SDL, CallingConvention = CallingConvention.Cdecl)]
		private static extern int SDL_PollEvent(out SDL_Event sdlEvent);

		[DllImportAttribute(DLL_SDL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void SDL_Quit();

		[DllImportAttribute(DLL_SDL, CallingConvention = CallingConvention.Cdecl)]
		private static extern int SDL_RenderClear(IntPtr renderer);

		[DllImportAttribute(DLL_SDL, CallingConvention = CallingConvention.Cdecl)]
		private static extern int SDL_RenderCopy(IntPtr renderer, IntPtr texture, ref SDL_Rect srcrect, ref SDL_Rect dstrect);

		[DllImportAttribute(DLL_SDL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void SDL_RenderPresent(IntPtr renderer);

		[DllImportAttribute(DLL_SDL, CallingConvention = CallingConvention.Cdecl)]
		private static extern int SDL_SetRenderDrawColor(IntPtr renderer, byte r, byte g, byte b, byte a);

		[DllImportAttribute(DLL_SDL, CallingConvention = CallingConvention.Cdecl)]
		private static extern int SDL_SetHint(byte[] name, byte[] value);

		private static bool SDL_SetHint(string name, string value) => SDL_SetHint(Encoding.UTF8.GetBytes($"{name}{'\0'}"), Encoding.UTF8.GetBytes($"{value}{'\0'}")) == 1;
		
		[DllImportAttribute(DLL_SDL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr SDL_CreateTexture(IntPtr renderer, uint format, SDL_TextureAccess access, int width, int height);

		[DllImportAttribute(DLL_SDL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void SDL_DestroyTexture(IntPtr texture);

		[DllImportAttribute(DLL_SDL, CallingConvention = CallingConvention.Cdecl)]
		private static extern int SDL_SetTextureBlendMode(IntPtr texture, SDL_BlendMode blendMode);

		[DllImportAttribute(DLL_SDL, CallingConvention = CallingConvention.Cdecl)]
		private static extern int SDL_LockTexture(IntPtr texture, ref SDL_Rect rect, out IntPtr pixels, out int pitch);

		[DllImportAttribute(DLL_SDL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void SDL_UnlockTexture(IntPtr texture);

		[DllImportAttribute(DLL_SDL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr SDL_Window();
	}
}