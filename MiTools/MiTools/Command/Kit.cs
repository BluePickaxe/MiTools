using MiNET;
using MiNET.Plugins.Attributes;
using MiNET.Items;

namespace MiTools.Command
{
    public class Kit : MiTools
    {
        [Command(Name = "kit")]
        public void Execute1(Player sender)
        {
            sender.SendMessage("§cMiTools..");
            sender.SendMessage("§6Version: 0.1 beta");
            sender.SendMessage("§6Author: BluePickaxe");
            sender.SendMessage("§6명령어 사용법 : /kit h");
        }

        [Command(Name = "kit")]
        public void Execute2(Player sender, string s)
        {
            switch (s)
            {
                case "t":
                    sender.Inventory.SetInventorySlot(0, new ItemStoneSword());
                    sender.Inventory.SetInventorySlot(1, new ItemStoneShovel());
                    sender.Inventory.SetInventorySlot(2, new ItemStonePickaxe());
                    sender.Inventory.SetInventorySlot(3, new ItemStoneAxe());
                    sender.SendMessage("§c[MiTools] §6툴 키트가 지급되었습니다!");
                    break;
                case "h":
                    sender.SendMessage("§c/kit t : §6툴 키트를 받습니다.");
                    break;
                default:
                    sender.SendMessage("§c[MiTools] §6/kit h 로 명령어 사용법을 확인하십시오!");
                    break;
            }
        }
    }
}
