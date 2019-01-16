using System;

namespace SheriffBot.Helpers
{
    public static class Constants
    {
        public static Func<string, string, string> SheriffString => (emoji, message) => 
            $"⠀ ⠀ ⠀  :cowboy:\n　   {emoji}{emoji}{emoji}\n    {emoji}   {emoji}　{emoji}\n   :point_down:   {emoji}{emoji} :point_down:\n  　  {emoji}　{emoji}\n　   {emoji}　 {emoji}\n　   :boot:     :boot:\n{message}";
    }
}