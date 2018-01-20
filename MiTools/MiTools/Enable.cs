using System;

namespace MiTools
{
    public class Enable : MiTools
    {
        protected override void OnEnable()
        {
            Console.WriteLine("[MiTools] by 푸른곡괭이(BluePickaxe)");
            Console.WriteLine("[MiTools] Enabling...");
        }
    }
}