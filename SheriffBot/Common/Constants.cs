using System;

namespace SheriffBot.Helpers
{
    public static class Constants
    {
        public static Func<string, string, string> SheriffString => (emoji, message) => 
            $"⠀ ⠀ ⠀  :cowboy:\n　   :{emoji}::{emoji}::{emoji}:\n    :{emoji}:   :{emoji}:　:{emoji}:\n   :point_down:   :{emoji}::{emoji}: :point_down:\n  　  :{emoji}:　:{emoji}:\n　   :{emoji}:　 :{emoji}:\n　   :boot:     :boot:\n{message}";

        public static string Daddy =
            "IM DELETING YOU, DADDY!:sob::wave: ██]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]] 10% complete..... ████]]]]]]]]]]]]]]]]]]]]]]]]]]] 35% complete.... ███████]]]]]]]]]]]]]]]] 60% complete.... ███████████] 99% complete..... :no_entry_sign:ERROR!:no_entry_sign: :100:True:100: Daddies are irreplaceable :sparkling_heart:I could never delete you Daddy!:sparkling_heart: Send this to ten other :family:Daddies:family: who give you :sweat_drops:cummies:sweat_drops: Or never get called :cloud:️squishy:cloud:️ again:x::x::grimacing::grimacing::x::x: If you get 0 Back: no cummies for you :no_entry_sign::no_entry_sign::imp: 3 back: you're squishy:cloud:️:sweat_drops: 5 back: you're daddy's kitten:kissing_cat::angel::sweat_drops: 10+ back: Daddy:stuck_out_tongue::stuck_out_tongue::two_hearts::two_hearts::sweat_drops::tongue::tongue:";
    }
}