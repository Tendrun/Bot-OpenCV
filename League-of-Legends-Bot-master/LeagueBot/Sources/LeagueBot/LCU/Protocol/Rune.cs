using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeagueBot.LCU.Protocol
{

    public class Rune
    {
        /// <summary>
        /// primaryStyleId and subStyleId can use this enum
        /// </summary>
        public enum primaryStyleIdEnum
        {       
            //Key, id
            Precision = 8000,
            Domination = 8100,
            Sorcery = 8200,
            Resolve = 8400,
            Inspiration = 8300,
        }

        public enum selectedPerkIdsPrecisionEnum
        {
            //Key, id

            //Main Rune
            PressTheAttack = 8005,
            LethalTempo = 8008,
            FleetFootwork = 8021,
            Conqueror = 8010,

            //Sub Runes

            //First Line
            Overheal = 9101,
            Triumph = 9111,
            PresenceOfMind = 8009,

            //Second Line
            LegendTenacity = 9105,
            LegendAlacrity = 9104,
            LegendBloodline = 9103,

            //Third Line
            CutDown = 8017,
            LastStand = 8299,
            CoupDeGrace = 8014,
        }

        public enum selectedPerkIdsDominationEnum
        {
            //Key, id

            //Main Rune
            Electrocute = 8112,
            Predator = 8124,
            DarkHarvest = 8128,
            HailOfBlades = 9923,

            //Sub Runes

            //First Line
            CheapShot = 8126,
            TasteOfBlood = 8139,
            SuddenImpact = 8143,

            //Second Line
            ZombieWard = 8136,
            GhostPoro = 8120,
            EyeballCollection = 8138,

            //Third Line
            TreasureHunter = 8135,
            IngeniousHunter = 8134,
            RelentlessHunter = 8105,
            UltimateHunter = 8106,
        }

        public enum selectedPerkIdsSorceryEnum
        {
            //Key, id

            //Main Rune
            SummonAery = 8214,
            ArcaneComet = 8229,
            PhaseRush = 8230,

            //Sub Runes

            //First Line
            NullifyingOrb = 8224,
            ManaflowBand = 8226,
            NimbusCloak = 8275,

            //Second Line
            Transcendence = 8210,
            Celerity = 8234,
            AbsoluteFocus = 8233,

            //Third Line
            Scorch = 8237,
            Waterwalking = 8232,
            GatheringStorm = 8236,
        }

        public enum selectedPerkIdsResolveEnum
        {
            //Key, id

            //Main Rune
            GraspOfTheUndying = 8437,
            Aftershock = 8439,
            Guardian = 8465,

            //Sub Runes

            //First Line
            Demolish = 8446,
            FontOfLife = 8463,
            ShieldBash = 8401,

            //Second Line
            Conditioning = 8429,
            SecondWind = 8444,
            BonePlating = 8473,

            //Third Line
            Overgrowth = 8451,
            Revitalize = 8453,
            Unflinching = 8242,
        }

        public enum selectedPerkIdsInspirationEnum
        {
            //Key, id

            //Main Rune
            GlacialAugment = 8351,
            UnsealedSpellbook = 8360,
            FirstStrike = 8369,

            //Sub Runes

            //First Line
            HextechFlashtraption = 8306,
            MagicalFootwear = 8304,
            PerfectTiming = 8313,

            //Second Line
            FuturesMarket = 8321,
            MinionDematerializer = 8316,
            BiscuitDelivery = 8345,

            //Third Line
            CosmicInsight = 8347,
            ApproachVelocity = 8410,
            TimeWarpTonic = 8352,
        }

        /// <summary>
        /// Fix this 
        /// </summary>
        public enum SubPerks
        {
            AdaptivDamage = 5008,
            AttackSpeed = 5005,
            Armor = 5002,
            CDR = 5007,
            MR = 5003,
            Health = 5001
        }

        public bool current;
        public int id;
        public bool isActive;
        public bool isDeletable;
        public bool isEditable;
        public bool isRecommendationOverride;
        public bool isTemporary;
        public bool isValid;
        public long lastModified;
        public string name;
        public int order;
        public int primaryStyleId;
        public int recommendationChampionId;
        public int recommendationIndex;
        public string runeRecommendationId;
        public int[] selectedPerkIds;
        public int subStyleId;
    }
}
