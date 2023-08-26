using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LeagueBot.Patterns.MadePatterns
{
    class Rune : PatternScript
    {
        public override void Execute()
        {
            client.initialize(); // read current league process informations

            client.ChangeRunes();
        }
    }
}
