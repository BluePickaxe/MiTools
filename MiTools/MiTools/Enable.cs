using System;

namespace MiTools
{
    public class Enable : MiTools
    {
        protected override void OnEnable()
        {
            Console.WriteLine("[MiTools] by BluePickaxe");
            Console.WriteLine("[MiTools] Enabling...");
        }
    }
}
