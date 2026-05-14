using Silk.NET.Windowing;
using Silk.NET.OpenGL;
using Silk.NET.Maths;
using System.Net;

class Program
{
    static IWindow window;
    static GL gl;

    static void Main(string[] args)
    {
        var options = WindowOptions.Default;

        options.Size = new Vector2D<int>(800, 600);
        options.Title = "physics experiment";

        window = Window.Create(options);

        window.Load += OnLoad;
        window.Update += OnUpdate;
        window.Render += OnRender;
    }

    static void OnLoad()
    {
        gl = GL.GetApi(window);

        gl.ClearColor(0.1f, 0.1f, 0.15f, 1f);
    }

    static void OnUpdate(double dt)
    {
        // empty for now
    } 

    static void OnRender(double dt)
    {
        gl.Clear(ClearBufferMask.ColorBufferBit);
    }
}