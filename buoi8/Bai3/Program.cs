using System;

namespace Bai3
{
    class Program
    {
        static void Main(string[] args)
        {
            Smartphone ss = new Samsung("dsd");
            ss.Call();
            Smartphone apple = new IPhone();
            apple.Camera();
        }
    }
}
