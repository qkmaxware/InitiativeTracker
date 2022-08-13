using System.Collections.Generic;

namespace InitiativeTracker.Data {

public static partial class MonsterCatalogue {
    private static void AddBasicRules() {
        // https://www.dndbeyond.com/sources/basic-rules/monsters#MonsterStatBlocks
        #region A
        All.Add(new Character() {
            Name = "Aboleth",
            Ac =17,
            Hp =135,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-a",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 21 },
                new Attribute { Name = "DEX", Value = 9 },
                new Attribute { Name = "CON", Value = 15 },
                new Attribute { Name = "INT", Value = 18 },
                new Attribute { Name = "WIS", Value = 15 },
                new Attribute { Name = "CHA", Value = 18 },
            }
        });
        All.Add(new Character() {
            Name = "Adult Black Dragon",
            Ac =19,
            Hp =195,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-a",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 23 },
                new Attribute { Name = "DEX", Value = 14 },
                new Attribute { Name = "CON", Value = 21 },
                new Attribute { Name = "INT", Value = 14 },
                new Attribute { Name = "WIS", Value = 13 },
                new Attribute { Name = "CHA", Value = 17 },
            }
        });
        All.Add(new Character() {
            Name = "Adult Blue Dragon",
            Ac =19,
            Hp =225,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-a",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 25 },
                new Attribute { Name = "DEX", Value = 10 },
                new Attribute { Name = "CON", Value = 23 },
                new Attribute { Name = "INT", Value = 16 },
                new Attribute { Name = "WIS", Value = 15 },
                new Attribute { Name = "CHA", Value = 19 },
            }
        });
        All.Add(new Character() {
            Name = "Adult Brass Dragon",
            Ac =18,
            Hp =172,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-a",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 23 },
                new Attribute { Name = "DEX", Value = 10 },
                new Attribute { Name = "CON", Value = 21 },
                new Attribute { Name = "INT", Value = 14 },
                new Attribute { Name = "WIS", Value = 13 },
                new Attribute { Name = "CHA", Value = 17 },
            }
        });
        All.Add(new Character() {
            Name = "Adult Bronze Dragon",
            Ac =19,
            Hp =212,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-a",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 25 },
                new Attribute { Name = "DEX", Value = 10 },
                new Attribute { Name = "CON", Value = 23 },
                new Attribute { Name = "INT", Value = 16 },
                new Attribute { Name = "WIS", Value = 15 },
                new Attribute { Name = "CHA", Value = 19 },
            }
        });
        All.Add(new Character() {
            Name = "Adult Copper Dragon",
            Ac =18,
            Hp =184,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-a",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 23 },
                new Attribute { Name = "DEX", Value = 12 },
                new Attribute { Name = "CON", Value = 21 },
                new Attribute { Name = "INT", Value = 18 },
                new Attribute { Name = "WIS", Value = 15 },
                new Attribute { Name = "CHA", Value = 17 },
            }
        });
        All.Add(new Character() {
            Name = "Adult Gold Dragon",
            Ac =19,
            Hp =256,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-a",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 27 },
                new Attribute { Name = "DEX", Value = 14 },
                new Attribute { Name = "CON", Value = 25 },
                new Attribute { Name = "INT", Value = 16 },
                new Attribute { Name = "WIS", Value = 15 },
                new Attribute { Name = "CHA", Value = 24 },
            }
        });
        All.Add(new Character() {
            Name = "Adult Green Dragon",
            Ac =19,
            Hp =207,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-a",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 23 },
                new Attribute { Name = "DEX", Value = 12 },
                new Attribute { Name = "CON", Value = 21 },
                new Attribute { Name = "INT", Value = 18 },
                new Attribute { Name = "WIS", Value = 15 },
                new Attribute { Name = "CHA", Value = 17 },
            }
        });
        All.Add(new Character() {
            Name = "Adult Red Dragon",
            Ac =19,
            Hp =256,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-a",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 27 },
                new Attribute { Name = "DEX", Value = 10 },
                new Attribute { Name = "CON", Value = 25 },
                new Attribute { Name = "INT", Value = 16 },
                new Attribute { Name = "WIS", Value = 13 },
                new Attribute { Name = "CHA", Value = 21 },
            }
        });
        All.Add(new Character() {
            Name = "Adult Silver Dragon",
            Ac =19,
            Hp =243,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-a",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 27 },
                new Attribute { Name = "DEX", Value = 10 },
                new Attribute { Name = "CON", Value = 25 },
                new Attribute { Name = "INT", Value = 16 },
                new Attribute { Name = "WIS", Value = 13 },
                new Attribute { Name = "CHA", Value = 21 },
            }
        });
        All.Add(new Character() {
            Name = "Adult White Dragon",
            Ac =18,
            Hp =200,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-a",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 22 },
                new Attribute { Name = "DEX", Value = 10 },
                new Attribute { Name = "CON", Value = 22 },
                new Attribute { Name = "INT", Value = 8 },
                new Attribute { Name = "WIS", Value = 12 },
                new Attribute { Name = "CHA", Value = 12 },
            }
        });
        All.Add(new Character() {
            Name = "Air Elemental",
            Ac =15,
            Hp =90,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-a",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 14 },
                new Attribute { Name = "DEX", Value = 20 },
                new Attribute { Name = "CON", Value = 14 },
                new Attribute { Name = "INT", Value = 6 },
                new Attribute { Name = "WIS", Value = 10 },
                new Attribute { Name = "CHA", Value = 6 },
            }
        });
        All.Add(new Character() {
            Name = "Allosaurus",
            Ac =13,
            Hp =51,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-a",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 19 },
                new Attribute { Name = "DEX", Value = 13 },
                new Attribute { Name = "CON", Value = 17 },
                new Attribute { Name = "INT", Value = 2 },
                new Attribute { Name = "WIS", Value = 12 },
                new Attribute { Name = "CHA", Value = 5 },
            }
        });
        All.Add(new Character() {
            Name = "Ancient Black Dragon",
            Ac =22,
            Hp =367,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-a",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 27 },
                new Attribute { Name = "DEX", Value = 14 },
                new Attribute { Name = "CON", Value = 25 },
                new Attribute { Name = "INT", Value = 16 },
                new Attribute { Name = "WIS", Value = 15 },
                new Attribute { Name = "CHA", Value = 19 },
            }
        });
        All.Add(new Character() {
            Name = "Ancient Blue Dragon",
            Ac =22,
            Hp =481,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-a",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 20 },
                new Attribute { Name = "DEX", Value = 10 },
                new Attribute { Name = "CON", Value = 27 },
                new Attribute { Name = "INT", Value = 18 },
                new Attribute { Name = "WIS", Value = 17 },
                new Attribute { Name = "CHA", Value = 21 },
            }
        });
        All.Add(new Character() {
            Name = "Ancient Brass Dragon",
            Ac =20,
            Hp =297,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-a",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 27 },
                new Attribute { Name = "DEX", Value = 10 },
                new Attribute { Name = "CON", Value = 25 },
                new Attribute { Name = "INT", Value = 16 },
                new Attribute { Name = "WIS", Value = 15 },
                new Attribute { Name = "CHA", Value = 19 },
            }
        });
        All.Add(new Character() {
            Name = "Ancient Bronze Dragon",
            Ac =22,
            Hp =444,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-a",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 29 },
                new Attribute { Name = "DEX", Value = 10 },
                new Attribute { Name = "CON", Value = 27 },
                new Attribute { Name = "INT", Value = 18 },
                new Attribute { Name = "WIS", Value = 17 },
                new Attribute { Name = "CHA", Value = 21 },
            }
        });
        All.Add(new Character() {
            Name = "Ancient Copper Dragon",
            Ac =21,
            Hp =350,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-a",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 27 },
                new Attribute { Name = "DEX", Value = 12 },
                new Attribute { Name = "CON", Value = 25 },
                new Attribute { Name = "INT", Value = 20 },
                new Attribute { Name = "WIS", Value = 17 },
                new Attribute { Name = "CHA", Value = 19 },
            }
        });
        All.Add(new Character() {
            Name = "Ancient Gold Dragon",
            Ac =22,
            Hp =546,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-a",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 30 },
                new Attribute { Name = "DEX", Value = 14 },
                new Attribute { Name = "CON", Value = 29 },
                new Attribute { Name = "INT", Value = 18 },
                new Attribute { Name = "WIS", Value = 17 },
                new Attribute { Name = "CHA", Value = 28 },
            }
        });
        All.Add(new Character() {
            Name = "Ancient Green Dragon",
            Ac =21,
            Hp =385,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-a",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 27 },
                new Attribute { Name = "DEX", Value = 12 },
                new Attribute { Name = "CON", Value = 25 },
                new Attribute { Name = "INT", Value = 20 },
                new Attribute { Name = "WIS", Value = 17 },
                new Attribute { Name = "CHA", Value = 19 },
            }
        });
        All.Add(new Character() {
            Name = "Ancient Red Dragon",
            Ac =22,
            Hp =546,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-a",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 30 },
                new Attribute { Name = "DEX", Value = 10 },
                new Attribute { Name = "CON", Value = 29 },
                new Attribute { Name = "INT", Value = 18 },
                new Attribute { Name = "WIS", Value = 15 },
                new Attribute { Name = "CHA", Value = 23 },
            }
        });
        All.Add(new Character() {
            Name = "Ancient Silver Dragon",
            Ac =22,
            Hp =487,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-a",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 30 },
                new Attribute { Name = "DEX", Value = 10 },
                new Attribute { Name = "CON", Value = 29 },
                new Attribute { Name = "INT", Value = 18 },
                new Attribute { Name = "WIS", Value = 15 },
                new Attribute { Name = "CHA", Value = 23 },
            }
        });
        All.Add(new Character() {
            Name = "Ancient White Dragon",
            Ac =20,
            Hp =333,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-a",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 26 },
                new Attribute { Name = "DEX", Value = 10 },
                new Attribute { Name = "CON", Value = 26 },
                new Attribute { Name = "INT", Value = 10 },
                new Attribute { Name = "WIS", Value = 13 },
                new Attribute { Name = "CHA", Value = 14 },
            }
        });
        All.Add(new Character() {
            Name = "Androsphinx",
            Ac =17,
            Hp =199,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-a",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 22 },
                new Attribute { Name = "DEX", Value = 10 },
                new Attribute { Name = "CON", Value = 20 },
                new Attribute { Name = "INT", Value = 16 },
                new Attribute { Name = "WIS", Value = 18 },
                new Attribute { Name = "CHA", Value = 23 },
            }
        });
        All.Add(new Character() {
            Name = "Animated Armour",
            Ac =18,
            Hp =33,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-a",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 14 },
                new Attribute { Name = "DEX", Value = 11 },
                new Attribute { Name = "CON", Value = 13 },
                new Attribute { Name = "INT", Value = 1 },
                new Attribute { Name = "WIS", Value = 3 },
                new Attribute { Name = "CHA", Value = 1 },
            }
        });
        All.Add(new Character() {
            Name = "Ankheg",
            Ac =14,
            Hp =39,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-a",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 17 },
                new Attribute { Name = "DEX", Value = 11 },
                new Attribute { Name = "CON", Value = 13 },
                new Attribute { Name = "INT", Value = 1 },
                new Attribute { Name = "WIS", Value = 13 },
                new Attribute { Name = "CHA", Value = 6 },
            }
        });
        All.Add(new Character() {
            Name = "Ankylosaurus",
            Ac =15,
            Hp =68,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-a",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 19 },
                new Attribute { Name = "DEX", Value = 11 },
                new Attribute { Name = "CON", Value = 15 },
                new Attribute { Name = "INT", Value = 2 },
                new Attribute { Name = "WIS", Value = 12 },
                new Attribute { Name = "CHA", Value = 5 },
            }
        });
        All.Add(new Character() {
            Name = "Ape",
            Ac =12,
            Hp =19,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-a",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 16 },
                new Attribute { Name = "DEX", Value = 14 },
                new Attribute { Name = "CON", Value = 14 },
                new Attribute { Name = "INT", Value = 6 },
                new Attribute { Name = "WIS", Value = 12 },
                new Attribute { Name = "CHA", Value = 7 },
            }
        });
        All.Add(new Character() {
            Name = "Awakened Shrub",
            Ac =9,
            Hp =10,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-a",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 3 },
                new Attribute { Name = "DEX", Value = 8 },
                new Attribute { Name = "CON", Value = 11 },
                new Attribute { Name = "INT", Value = 10 },
                new Attribute { Name = "WIS", Value = 10 },
                new Attribute { Name = "CHA", Value = 6 },
            }
        });
        All.Add(new Character() {
            Name = "Awakened Tree",
            Ac =13,
            Hp =59,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-a",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 19 },
                new Attribute { Name = "DEX", Value = 6 },
                new Attribute { Name = "CON", Value = 15 },
                new Attribute { Name = "INT", Value = 10 },
                new Attribute { Name = "WIS", Value = 10 },
                new Attribute { Name = "CHA", Value = 7 },
            }
        });
        All.Add(new Character() {
            Name = "Axe Beak",
            Ac =11,
            Hp =19,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-a",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 14 },
                new Attribute { Name = "DEX", Value = 12 },
                new Attribute { Name = "CON", Value = 12 },
                new Attribute { Name = "INT", Value = 2 },
                new Attribute { Name = "WIS", Value = 10 },
                new Attribute { Name = "CHA", Value = 5 },
            }
        });
        All.Add(new Character() {
            Name = "Azer",
            Ac =17,
            Hp =39,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-a",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 17 },
                new Attribute { Name = "DEX", Value = 12 },
                new Attribute { Name = "CON", Value = 15 },
                new Attribute { Name = "INT", Value = 12 },
                new Attribute { Name = "WIS", Value = 13 },
                new Attribute { Name = "CHA", Value = 10 },
            }
        });
        #endregion
        #region B
        // https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-b
        All.Add(new Character() {
            Name = "Baboon",
            Ac =12,
            Hp =3,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-b",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 8 },
                new Attribute { Name = "DEX", Value = 14 },
                new Attribute { Name = "CON", Value = 11 },
                new Attribute { Name = "INT", Value = 4 },
                new Attribute { Name = "WIS", Value = 12 },
                new Attribute { Name = "CHA", Value = 6 },
            }
        });
        All.Add(new Character() {
            Name = "Badger",
            Ac = 10,
            Hp = 3,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-b",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 4 },
                new Attribute { Name = "DEX", Value = 11 },
                new Attribute { Name = "CON", Value = 12 },
                new Attribute { Name = "INT", Value = 2 },
                new Attribute { Name = "WIS", Value = 12 },
                new Attribute { Name = "CHA", Value = 5 },
            }
        });
        All.Add(new Character() {
            Name = "Balor",
            Ac = 19,
            Hp = 262,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-b",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 26 },
                new Attribute { Name = "DEX", Value = 15 },
                new Attribute { Name = "CON", Value = 22 },
                new Attribute { Name = "INT", Value = 20 },
                new Attribute { Name = "WIS", Value = 16 },
                new Attribute { Name = "CHA", Value = 22 },
            }
        });
        All.Add(new Character() {
            Name = "Barbed Devil",
            Ac = 15,
            Hp = 110,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-b",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 16 },
                new Attribute { Name = "DEX", Value = 17 },
                new Attribute { Name = "CON", Value = 18 },
                new Attribute { Name = "INT", Value = 12 },
                new Attribute { Name = "WIS", Value = 14 },
                new Attribute { Name = "CHA", Value = 14 },
            }
        });
        All.Add(new Character() {
            Name = "Banshee",
            Ac = 12,
            Hp = 58,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-b",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 1 },
                new Attribute { Name = "DEX", Value = 14 },
                new Attribute { Name = "CON", Value = 10 },
                new Attribute { Name = "INT", Value = 12 },
                new Attribute { Name = "WIS", Value = 11 },
                new Attribute { Name = "CHA", Value = 17 },
            }
        });
        All.Add(new Character() {
            Name = "Basilisk",
            Ac = 15,
            Hp = 52,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-b",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 16 },
                new Attribute { Name = "DEX", Value = 8 },
                new Attribute { Name = "CON", Value = 15 },
                new Attribute { Name = "INT", Value = 2 },
                new Attribute { Name = "WIS", Value = 8 },
                new Attribute { Name = "CHA", Value = 7 },
            }
        });
        All.Add(new Character() {
            Name = "Bat",
            Ac = 12,
            Hp = 1,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-b",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 2 },
                new Attribute { Name = "DEX", Value = 15 },
                new Attribute { Name = "CON", Value = 8 },
                new Attribute { Name = "INT", Value = 2 },
                new Attribute { Name = "WIS", Value = 12 },
                new Attribute { Name = "CHA", Value = 4 },
            }
        });
        All.Add(new Character() {
            Name = "Bearded Devil",
            Ac = 13,
            Hp = 52,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-b",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 16 },
                new Attribute { Name = "DEX", Value = 15 },
                new Attribute { Name = "CON", Value = 15 },
                new Attribute { Name = "INT", Value = 9 },
                new Attribute { Name = "WIS", Value = 11 },
                new Attribute { Name = "CHA", Value = 11 },
            }
        });
        All.Add(new Character() {
            Name = "Behir",
            Ac = 17,
            Hp = 168,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-b",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 23 },
                new Attribute { Name = "DEX", Value = 16 },
                new Attribute { Name = "CON", Value = 18 },
                new Attribute { Name = "INT", Value = 7 },
                new Attribute { Name = "WIS", Value = 14 },
                new Attribute { Name = "CHA", Value = 12 },
            }
        });
        All.Add(new Character() {
            Name = "Black Bear",
            Ac = 11,
            Hp = 19,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-b",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 15 },
                new Attribute { Name = "DEX", Value = 10 },
                new Attribute { Name = "CON", Value = 14 },
                new Attribute { Name = "INT", Value = 2 },
                new Attribute { Name = "WIS", Value = 12 },
                new Attribute { Name = "CHA", Value = 7 },
            }
        });
        All.Add(new Character() {
            Name = "Black Dragon Wyrmling",
            Ac = 17,
            Hp = 33,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-b",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 15 },
                new Attribute { Name = "DEX", Value = 14 },
                new Attribute { Name = "CON", Value = 13 },
                new Attribute { Name = "INT", Value = 10 },
                new Attribute { Name = "WIS", Value = 11 },
                new Attribute { Name = "CHA", Value = 13 },
            }
        });
        All.Add(new Character() {
            Name = "Black Pudding",
            Ac = 7,
            Hp = 85,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-b",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 16 },
                new Attribute { Name = "DEX", Value = 5 },
                new Attribute { Name = "CON", Value = 16 },
                new Attribute { Name = "INT", Value = 1 },
                new Attribute { Name = "WIS", Value = 6 },
                new Attribute { Name = "CHA", Value = 1 },
            }
        });
        All.Add(new Character() {
            Name = "Blink Dog",
            Ac = 13,
            Hp = 22,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-b",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 12 },
                new Attribute { Name = "DEX", Value = 17 },
                new Attribute { Name = "CON", Value = 12 },
                new Attribute { Name = "INT", Value = 10 },
                new Attribute { Name = "WIS", Value = 13 },
                new Attribute { Name = "CHA", Value = 11 },
            }
        });
        All.Add(new Character() {
            Name = "Blood Hawk",
            Ac = 12,
            Hp = 7,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-b",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 6 },
                new Attribute { Name = "DEX", Value = 14 },
                new Attribute { Name = "CON", Value = 10 },
                new Attribute { Name = "INT", Value = 3 },
                new Attribute { Name = "WIS", Value = 14 },
                new Attribute { Name = "CHA", Value = 5 },
            }
        });
        All.Add(new Character() {
            Name = "Blue Dragon Wyrmling",
            Ac = 17,
            Hp = 52,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-b",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 17 },
                new Attribute { Name = "DEX", Value = 10 },
                new Attribute { Name = "CON", Value = 15 },
                new Attribute { Name = "INT", Value = 12 },
                new Attribute { Name = "WIS", Value = 11 },
                new Attribute { Name = "CHA", Value = 15 },
            }
        });
        All.Add(new Character() {
            Name = "Boar",
            Ac = 11,
            Hp = 11,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-b",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 13 },
                new Attribute { Name = "DEX", Value = 11 },
                new Attribute { Name = "CON", Value = 12 },
                new Attribute { Name = "INT", Value = 2 },
                new Attribute { Name = "WIS", Value = 9 },
                new Attribute { Name = "CHA", Value = 5 },
            }
        });
        All.Add(new Character() {
            Name = "Bone Devil",
            Ac = 19,
            Hp = 142,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-b",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 18 },
                new Attribute { Name = "DEX", Value = 16 },
                new Attribute { Name = "CON", Value = 18 },
                new Attribute { Name = "INT", Value = 13 },
                new Attribute { Name = "WIS", Value = 14 },
                new Attribute { Name = "CHA", Value = 16 },
            }
        });
        All.Add(new Character() {
            Name = "Brass Dragon Wyrmling",
            Ac = 16,
            Hp = 16,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-b",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 15 },
                new Attribute { Name = "DEX", Value = 10 },
                new Attribute { Name = "CON", Value = 13 },
                new Attribute { Name = "INT", Value = 10 },
                new Attribute { Name = "WIS", Value = 11 },
                new Attribute { Name = "CHA", Value = 13 },
            }
        });
        All.Add(new Character() {
            Name = "Bronze Dragon Wyrmling",
            Ac = 17,
            Hp = 32,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-b",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 17 },
                new Attribute { Name = "DEX", Value = 10 },
                new Attribute { Name = "CON", Value = 15 },
                new Attribute { Name = "INT", Value = 12 },
                new Attribute { Name = "WIS", Value = 11 },
                new Attribute { Name = "CHA", Value = 15 },
            }
        });
        All.Add(new Character() {
            Name = "Brown Bear",
            Ac = 11,
            Hp = 34,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-b",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 19 },
                new Attribute { Name = "DEX", Value = 10 },
                new Attribute { Name = "CON", Value = 16 },
                new Attribute { Name = "INT", Value = 2 },
                new Attribute { Name = "WIS", Value = 13 },
                new Attribute { Name = "CHA", Value = 7 },
            }
        });
        All.Add(new Character() {
            Name = "Bugbear",
            Ac = 16,
            Hp = 27,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-b",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 15 },
                new Attribute { Name = "DEX", Value = 14 },
                new Attribute { Name = "CON", Value = 13 },
                new Attribute { Name = "INT", Value = 8 },
                new Attribute { Name = "WIS", Value = 11 },
                new Attribute { Name = "CHA", Value = 9 },
            }
        });
        All.Add(new Character() {
            Name = "Bulette",
            Ac = 17,
            Hp = 94,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-b",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 19 },
                new Attribute { Name = "DEX", Value = 11 },
                new Attribute { Name = "CON", Value = 21 },
                new Attribute { Name = "INT", Value = 2 },
                new Attribute { Name = "WIS", Value = 10 },
                new Attribute { Name = "CHA", Value = 5 },
            }
        });
        #endregion 
        #region C
        All.Add(new Character() {
            Name = "Camel",
            Ac = 9,
            Hp = 15,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-c",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 16 },
                new Attribute { Name = "DEX", Value = 8 },
                new Attribute { Name = "CON", Value = 14 },
                new Attribute { Name = "INT", Value = 2 },
                new Attribute { Name = "WIS", Value = 8 },
                new Attribute { Name = "CHA", Value = 5 },
            }
        });
        All.Add(new Character() {
            Name = "Cat",
            Ac = 12,
            Hp = 2,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-c",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 3 },
                new Attribute { Name = "DEX", Value = 15 },
                new Attribute { Name = "CON", Value = 10 },
                new Attribute { Name = "INT", Value = 3 },
                new Attribute { Name = "WIS", Value = 12 },
                new Attribute { Name = "CHA", Value = 7 },
            }
        });
        All.Add(new Character() {
            Name = "Centaur",
            Ac = 12,
            Hp = 45,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-c",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 18 },
                new Attribute { Name = "DEX", Value = 14 },
                new Attribute { Name = "CON", Value = 14 },
                new Attribute { Name = "INT", Value = 9 },
                new Attribute { Name = "WIS", Value = 13 },
                new Attribute { Name = "CHA", Value = 11 },
            }
        });
        All.Add(new Character() {
            Name = "Chain Devil",
            Ac = 16,
            Hp = 85,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-c",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 18 },
                new Attribute { Name = "DEX", Value = 15 },
                new Attribute { Name = "CON", Value = 18 },
                new Attribute { Name = "INT", Value = 11 },
                new Attribute { Name = "WIS", Value = 12 },
                new Attribute { Name = "CHA", Value = 14 },
            }
        });
        All.Add(new Character() {
            Name = "Chimera",
            Ac = 14,
            Hp = 114,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-c",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 19 },
                new Attribute { Name = "DEX", Value = 11 },
                new Attribute { Name = "CON", Value = 19 },
                new Attribute { Name = "INT", Value = 3 },
                new Attribute { Name = "WIS", Value = 14 },
                new Attribute { Name = "CHA", Value = 10 },
            }
        });
        All.Add(new Character() {
            Name = "Chuul",
            Ac = 16,
            Hp = 93,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-c",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 19 },
                new Attribute { Name = "DEX", Value = 10 },
                new Attribute { Name = "CON", Value = 16 },
                new Attribute { Name = "INT", Value = 5 },
                new Attribute { Name = "WIS", Value = 11 },
                new Attribute { Name = "CHA", Value = 5 },
            }
        });
        All.Add(new Character() {
            Name = "Clay Golem",
            Ac = 14,
            Hp = 133,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-c",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 20 },
                new Attribute { Name = "DEX", Value = 9 },
                new Attribute { Name = "CON", Value = 18 },
                new Attribute { Name = "INT", Value = 3 },
                new Attribute { Name = "WIS", Value = 8 },
                new Attribute { Name = "CHA", Value = 1 },
            }
        });
        All.Add(new Character() {
            Name = "Cloaker",
            Ac = 14,
            Hp = 78,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-c",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 17 },
                new Attribute { Name = "DEX", Value = 15 },
                new Attribute { Name = "CON", Value = 12 },
                new Attribute { Name = "INT", Value = 13 },
                new Attribute { Name = "WIS", Value = 12 },
                new Attribute { Name = "CHA", Value = 14 },
            }
        });
        All.Add(new Character() {
            Name = "Cloud Giant",
            Ac = 14,
            Hp = 200,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-c",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 27 },
                new Attribute { Name = "DEX", Value = 10 },
                new Attribute { Name = "CON", Value = 22 },
                new Attribute { Name = "INT", Value = 12 },
                new Attribute { Name = "WIS", Value = 16 },
                new Attribute { Name = "CHA", Value = 16 },
            }
        });
        All.Add(new Character() {
            Name = "Cockatrice",
            Ac = 11,
            Hp = 27,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-c",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 6 },
                new Attribute { Name = "DEX", Value = 12 },
                new Attribute { Name = "CON", Value = 12 },
                new Attribute { Name = "INT", Value = 2 },
                new Attribute { Name = "WIS", Value = 12 },
                new Attribute { Name = "CHA", Value = 5 },
            }
        });
        All.Add(new Character() {
            Name = "Constrictor Snake",
            Ac = 12,
            Hp = 13,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-c",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 15 },
                new Attribute { Name = "DEX", Value = 14 },
                new Attribute { Name = "CON", Value = 12 },
                new Attribute { Name = "INT", Value = 1 },
                new Attribute { Name = "WIS", Value = 10 },
                new Attribute { Name = "CHA", Value = 3 },
            }
        });
        All.Add(new Character() {
            Name = "Copper Dragon Wyrmling",
            Ac = 16,
            Hp = 22,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-c",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 15 },
                new Attribute { Name = "DEX", Value = 12 },
                new Attribute { Name = "CON", Value = 13 },
                new Attribute { Name = "INT", Value = 14 },
                new Attribute { Name = "WIS", Value = 11 },
                new Attribute { Name = "CHA", Value = 13 },
            }
        });
        All.Add(new Character() {
            Name = "Couatl",
            Ac = 19,
            Hp = 97,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-c",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 16 },
                new Attribute { Name = "DEX", Value = 20 },
                new Attribute { Name = "CON", Value = 17 },
                new Attribute { Name = "INT", Value = 18 },
                new Attribute { Name = "WIS", Value = 20 },
                new Attribute { Name = "CHA", Value = 18 },
            }
        });
        All.Add(new Character() {
            Name = "Crab",
            Ac = 11,
            Hp = 2,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-c",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 2 },
                new Attribute { Name = "DEX", Value = 11 },
                new Attribute { Name = "CON", Value = 10 },
                new Attribute { Name = "INT", Value = 1 },
                new Attribute { Name = "WIS", Value = 8 },
                new Attribute { Name = "CHA", Value = 2 },
            }
        });
        All.Add(new Character() {
            Name = "Crocodile",
            Ac = 12,
            Hp = 19,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-c",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 15 },
                new Attribute { Name = "DEX", Value = 10 },
                new Attribute { Name = "CON", Value = 13 },
                new Attribute { Name = "INT", Value = 2 },
                new Attribute { Name = "WIS", Value = 10 },
                new Attribute { Name = "CHA", Value = 5 },
            }
        });
        All.Add(new Character() {
            Name = "Cyclops",
            Ac = 14,
            Hp = 138,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-c",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 2 },
                new Attribute { Name = "DEX", Value = 11 },
                new Attribute { Name = "CON", Value = 20 },
                new Attribute { Name = "INT", Value = 8 },
                new Attribute { Name = "WIS", Value = 6 },
                new Attribute { Name = "CHA", Value = 10 },
            }
        });
        #endregion 
        #region D
        All.Add(new Character() {
            Name = "Darkmantle",
            Ac = 11,
            Hp = 22,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-d",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 16 },
                new Attribute { Name = "DEX", Value = 12 },
                new Attribute { Name = "CON", Value = 13 },
                new Attribute { Name = "INT", Value = 2 },
                new Attribute { Name = "WIS", Value = 10 },
                new Attribute { Name = "CHA", Value = 5 },
            }
        });
        All.Add(new Character() {
            Name = "Death Dog",
            Ac = 12,
            Hp = 39,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-d",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 15 },
                new Attribute { Name = "DEX", Value = 14 },
                new Attribute { Name = "CON", Value = 14 },
                new Attribute { Name = "INT", Value = 3 },
                new Attribute { Name = "WIS", Value = 13 },
                new Attribute { Name = "CHA", Value = 6 },
            }
        });
        All.Add(new Character() {
            Name = "Deer",
            Ac = 13,
            Hp = 4,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-d",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 15 },
                new Attribute { Name = "DEX", Value = 14 },
                new Attribute { Name = "CON", Value = 14 },
                new Attribute { Name = "INT", Value = 12 },
                new Attribute { Name = "WIS", Value = 10 },
                new Attribute { Name = "CHA", Value = 9 },
            }
        });
        All.Add(new Character() {
            Name = "Deep Gnome",
            Ac = 15,
            Hp = 16,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-d",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 15 },
                new Attribute { Name = "DEX", Value = 14 },
                new Attribute { Name = "CON", Value = 14 },
                new Attribute { Name = "INT", Value = 12 },
                new Attribute { Name = "WIS", Value = 10 },
                new Attribute { Name = "CHA", Value = 9 },
            }
        });
        All.Add(new Character() {
            Name = "Deva",
            Ac = 17,
            Hp = 136,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-d",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 18 },
                new Attribute { Name = "DEX", Value = 18 },
                new Attribute { Name = "CON", Value = 18 },
                new Attribute { Name = "INT", Value = 17 },
                new Attribute { Name = "WIS", Value = 20 },
                new Attribute { Name = "CHA", Value = 20 },
            }
        });
        All.Add(new Character() {
            Name = "Djinni",
            Ac = 17,
            Hp = 161,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-d",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 21 },
                new Attribute { Name = "DEX", Value = 15 },
                new Attribute { Name = "CON", Value = 22 },
                new Attribute { Name = "INT", Value = 15 },
                new Attribute { Name = "WIS", Value = 16 },
                new Attribute { Name = "CHA", Value = 20 },
            }
        });
        All.Add(new Character() {
            Name = "Dire Wolf",
            Ac = 14,
            Hp = 37,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-d",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 17 },
                new Attribute { Name = "DEX", Value = 15 },
                new Attribute { Name = "CON", Value = 15 },
                new Attribute { Name = "INT", Value = 3 },
                new Attribute { Name = "WIS", Value = 12 },
                new Attribute { Name = "CHA", Value = 7 },
            }
        });
        All.Add(new Character() {
            Name = "Doppelganger",
            Ac = 14,
            Hp = 52,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-d",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 11 },
                new Attribute { Name = "DEX", Value = 18 },
                new Attribute { Name = "CON", Value = 14 },
                new Attribute { Name = "INT", Value = 11 },
                new Attribute { Name = "WIS", Value = 12 },
                new Attribute { Name = "CHA", Value = 14 },
            }
        });
        All.Add(new Character() {
            Name = "Draft Horse",
            Ac = 10,
            Hp = 19,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-d",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 18 },
                new Attribute { Name = "DEX", Value = 10 },
                new Attribute { Name = "CON", Value = 12 },
                new Attribute { Name = "INT", Value = 2 },
                new Attribute { Name = "WIS", Value = 11 },
                new Attribute { Name = "CHA", Value = 7 },
            }
        });
        All.Add(new Character() {
            Name = "Dragon Turtle",
            Ac = 20,
            Hp = 341,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-d",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 25 },
                new Attribute { Name = "DEX", Value = 10 },
                new Attribute { Name = "CON", Value = 20 },
                new Attribute { Name = "INT", Value = 10 },
                new Attribute { Name = "WIS", Value = 12 },
                new Attribute { Name = "CHA", Value = 12 },
            }
        });
        All.Add(new Character() {
            Name = "Dretch",
            Ac = 11,
            Hp = 18,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-d",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 11 },
                new Attribute { Name = "DEX", Value = 11 },
                new Attribute { Name = "CON", Value = 12 },
                new Attribute { Name = "INT", Value = 5 },
                new Attribute { Name = "WIS", Value = 8 },
                new Attribute { Name = "CHA", Value = 3 },
            }
        });
        All.Add(new Character() {
            Name = "Drider",
            Ac = 19,
            Hp = 123,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-d",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 16 },
                new Attribute { Name = "DEX", Value = 16 },
                new Attribute { Name = "CON", Value = 18 },
                new Attribute { Name = "INT", Value = 13 },
                new Attribute { Name = "WIS", Value = 14 },
                new Attribute { Name = "CHA", Value = 12 },
            }
        });
        All.Add(new Character() {
            Name = "Drow",
            Ac = 15,
            Hp = 13,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-d",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 10 },
                new Attribute { Name = "DEX", Value = 14 },
                new Attribute { Name = "CON", Value = 10 },
                new Attribute { Name = "INT", Value = 11 },
                new Attribute { Name = "WIS", Value = 11 },
                new Attribute { Name = "CHA", Value = 12 },
            }
        });
        All.Add(new Character() {
            Name = "Dryad",
            Ac = 11,
            Hp = 22,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-d",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 10 },
                new Attribute { Name = "DEX", Value = 12 },
                new Attribute { Name = "CON", Value = 11 },
                new Attribute { Name = "INT", Value = 14 },
                new Attribute { Name = "WIS", Value = 15 },
                new Attribute { Name = "CHA", Value = 18 },
            }
        });
        All.Add(new Character() {
            Name = "Duergar",
            Ac = 16,
            Hp = 26,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-d",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 14 },
                new Attribute { Name = "DEX", Value = 11 },
                new Attribute { Name = "CON", Value = 14 },
                new Attribute { Name = "INT", Value = 11 },
                new Attribute { Name = "WIS", Value = 10 },
                new Attribute { Name = "CHA", Value = 9 },
            }
        });
        All.Add(new Character() {
            Name = "Dust Mephit",
            Ac = 12,
            Hp = 17,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-d",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 5 },
                new Attribute { Name = "DEX", Value = 14 },
                new Attribute { Name = "CON", Value = 10 },
                new Attribute { Name = "INT", Value = 9 },
                new Attribute { Name = "WIS", Value = 11 },
                new Attribute { Name = "CHA", Value = 10 },
            }
        });
        #endregion
        #region E
        All.Add(new Character() {
            Name = "Eagle",
            Ac = 12,
            Hp = 3,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-e",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 6 },
                new Attribute { Name = "DEX", Value = 15 },
                new Attribute { Name = "CON", Value = 10 },
                new Attribute { Name = "INT", Value = 2 },
                new Attribute { Name = "WIS", Value = 14 },
                new Attribute { Name = "CHA", Value = 7 },
            }
        });
        All.Add(new Character() {
            Name = "Earth Elemental",
            Ac = 17,
            Hp = 126,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-e",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 20 },
                new Attribute { Name = "DEX", Value = 8 },
                new Attribute { Name = "CON", Value = 20 },
                new Attribute { Name = "INT", Value = 5 },
                new Attribute { Name = "WIS", Value = 10 },
                new Attribute { Name = "CHA", Value = 5 },
            }
        });
        All.Add(new Character() {
            Name = "Efreeti",
            Ac = 17,
            Hp = 200,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-e",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 22 },
                new Attribute { Name = "DEX", Value = 12 },
                new Attribute { Name = "CON", Value = 24 },
                new Attribute { Name = "INT", Value = 16 },
                new Attribute { Name = "WIS", Value = 15 },
                new Attribute { Name = "CHA", Value = 16 },
            }
        });
        All.Add(new Character() {
            Name = "Elephant",
            Ac = 12,
            Hp = 76,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-e",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 22 },
                new Attribute { Name = "DEX", Value = 9 },
                new Attribute { Name = "CON", Value = 17 },
                new Attribute { Name = "INT", Value = 3 },
                new Attribute { Name = "WIS", Value = 11 },
                new Attribute { Name = "CHA", Value = 6 },
            }
        });
        All.Add(new Character() {
            Name = "Elk",
            Ac = 10,
            Hp = 13,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-e",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 16 },
                new Attribute { Name = "DEX", Value = 10 },
                new Attribute { Name = "CON", Value = 12 },
                new Attribute { Name = "INT", Value = 2 },
                new Attribute { Name = "WIS", Value = 10 },
                new Attribute { Name = "CHA", Value = 6 },
            }
        });
        All.Add(new Character() {
            Name = "Erinyes",
            Ac = 18,
            Hp = 153,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-e",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 18 },
                new Attribute { Name = "DEX", Value = 16 },
                new Attribute { Name = "CON", Value = 18 },
                new Attribute { Name = "INT", Value = 14 },
                new Attribute { Name = "WIS", Value = 14 },
                new Attribute { Name = "CHA", Value = 18 },
            }
        });
        All.Add(new Character() {
            Name = "Ettercap",
            Ac = 13,
            Hp = 44,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-e",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 14 },
                new Attribute { Name = "DEX", Value = 15 },
                new Attribute { Name = "CON", Value = 13 },
                new Attribute { Name = "INT", Value = 7 },
                new Attribute { Name = "WIS", Value = 12 },
                new Attribute { Name = "CHA", Value = 8 },
            }
        });
        All.Add(new Character() {
            Name = "Ettin",
            Ac = 12,
            Hp = 85,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-e",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 21 },
                new Attribute { Name = "DEX", Value = 8 },
                new Attribute { Name = "CON", Value = 17 },
                new Attribute { Name = "INT", Value = 6 },
                new Attribute { Name = "WIS", Value = 10 },
                new Attribute { Name = "CHA", Value = 8 },
            }
        });
        #endregion
        #region F
        All.Add(new Character() {
            Name = "Fire Elemental",
            Ac = 13,
            Hp = 102,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-f",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 10 },
                new Attribute { Name = "DEX", Value = 17 },
                new Attribute { Name = "CON", Value = 16 },
                new Attribute { Name = "INT", Value = 6 },
                new Attribute { Name = "WIS", Value = 10 },
                new Attribute { Name = "CHA", Value = 7 },
            }
        });
        All.Add(new Character() {
            Name = "Fire Giant",
            Ac = 18,
            Hp = 162,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-f",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 25 },
                new Attribute { Name = "DEX", Value = 9 },
                new Attribute { Name = "CON", Value = 23 },
                new Attribute { Name = "INT", Value = 10 },
                new Attribute { Name = "WIS", Value = 14 },
                new Attribute { Name = "CHA", Value = 13 },
            }
        });
        All.Add(new Character() {
            Name = "Flameskull",
            Ac = 13,
            Hp = 40,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-f",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 1 },
                new Attribute { Name = "DEX", Value = 17 },
                new Attribute { Name = "CON", Value = 14 },
                new Attribute { Name = "INT", Value = 16 },
                new Attribute { Name = "WIS", Value = 10 },
                new Attribute { Name = "CHA", Value = 11 },
            }
        });
        All.Add(new Character() {
            Name = "Flesh Golem",
            Ac = 9,
            Hp = 93,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-f",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 19 },
                new Attribute { Name = "DEX", Value = 9 },
                new Attribute { Name = "CON", Value = 18 },
                new Attribute { Name = "INT", Value = 6 },
                new Attribute { Name = "WIS", Value = 10 },
                new Attribute { Name = "CHA", Value = 5 },
            }
        });
        All.Add(new Character() {
            Name = "Flying Snake",
            Ac = 14,
            Hp = 5,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-f",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 4 },
                new Attribute { Name = "DEX", Value = 18 },
                new Attribute { Name = "CON", Value = 11 },
                new Attribute { Name = "INT", Value = 2 },
                new Attribute { Name = "WIS", Value = 12 },
                new Attribute { Name = "CHA", Value = 5 },
            }
        });
        All.Add(new Character() {
            Name = "Flying Sword",
            Ac = 17,
            Hp = 17,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-f",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 12 },
                new Attribute { Name = "DEX", Value = 15 },
                new Attribute { Name = "CON", Value = 11 },
                new Attribute { Name = "INT", Value = 1 },
                new Attribute { Name = "WIS", Value = 5 },
                new Attribute { Name = "CHA", Value = 1 },
            }
        });
        All.Add(new Character() {
            Name = "Frog",
            Ac = 11,
            Hp = 1,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-f",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 1 },
                new Attribute { Name = "DEX", Value = 13 },
                new Attribute { Name = "CON", Value = 8 },
                new Attribute { Name = "INT", Value = 1 },
                new Attribute { Name = "WIS", Value = 8 },
                new Attribute { Name = "CHA", Value = 3 },
            }
        });
        All.Add(new Character() {
            Name = "Frost Giant",
            Ac = 15,
            Hp = 138,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-f",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 23 },
                new Attribute { Name = "DEX", Value = 9 },
                new Attribute { Name = "CON", Value = 21 },
                new Attribute { Name = "INT", Value = 9 },
                new Attribute { Name = "WIS", Value = 10 },
                new Attribute { Name = "CHA", Value = 12 },
            }
        });
        #endregion
        #region G
        All.Add(new Character() {
            Name = "Gargoyle",
            Ac = 15,
            Hp = 52,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-g",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 15 },
                new Attribute { Name = "DEX", Value = 11 },
                new Attribute { Name = "CON", Value = 16 },
                new Attribute { Name = "INT", Value = 6 },
                new Attribute { Name = "WIS", Value = 11 },
                new Attribute { Name = "CHA", Value = 7 },
            }
        });
        All.Add(new Character() {
            Name = "Gelatinous Cube",
            Ac = 6,
            Hp = 84,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-g",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 14 },
                new Attribute { Name = "DEX", Value = 3 },
                new Attribute { Name = "CON", Value = 20 },
                new Attribute { Name = "INT", Value = 1 },
                new Attribute { Name = "WIS", Value = 6 },
                new Attribute { Name = "CHA", Value = 1 },
            }
        });
        All.Add(new Character() {
            Name = "Ghast",
            Ac = 13,
            Hp = 36,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-g",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 16 },
                new Attribute { Name = "DEX", Value = 17 },
                new Attribute { Name = "CON", Value = 10 },
                new Attribute { Name = "INT", Value = 11 },
                new Attribute { Name = "WIS", Value = 10 },
                new Attribute { Name = "CHA", Value = 8 },
            }
        });
        All.Add(new Character() {
            Name = "Ghost",
            Ac = 11,
            Hp = 45,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-g",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 7 },
                new Attribute { Name = "DEX", Value = 13 },
                new Attribute { Name = "CON", Value = 10 },
                new Attribute { Name = "INT", Value = 10 },
                new Attribute { Name = "WIS", Value = 12 },
                new Attribute { Name = "CHA", Value = 17 },
            }
        });
        All.Add(new Character() {
            Name = "Ghoul",
            Ac = 12,
            Hp = 22,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-g",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 13 },
                new Attribute { Name = "DEX", Value = 15 },
                new Attribute { Name = "CON", Value = 10 },
                new Attribute { Name = "INT", Value = 7 },
                new Attribute { Name = "WIS", Value = 10 },
                new Attribute { Name = "CHA", Value = 6 },
            }
        });
        All.Add(new Character() {
            Name = "Giant Ape",
            Ac = 12,
            Hp = 157,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-g",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 23 },
                new Attribute { Name = "DEX", Value = 14 },
                new Attribute { Name = "CON", Value = 18 },
                new Attribute { Name = "INT", Value = 7 },
                new Attribute { Name = "WIS", Value = 12 },
                new Attribute { Name = "CHA", Value = 7 },
            }
        });
        All.Add(new Character() {
            Name = "Giant Badger",
            Ac = 10,
            Hp = 13,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-g",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 13 },
                new Attribute { Name = "DEX", Value = 10 },
                new Attribute { Name = "CON", Value = 15 },
                new Attribute { Name = "INT", Value = 2 },
                new Attribute { Name = "WIS", Value = 12 },
                new Attribute { Name = "CHA", Value = 5 },
            }
        });
        All.Add(new Character() {
            Name = "Giant Bat",
            Ac = 13,
            Hp = 22,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-g",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 15 },
                new Attribute { Name = "DEX", Value = 16 },
                new Attribute { Name = "CON", Value = 11 },
                new Attribute { Name = "INT", Value = 2 },
                new Attribute { Name = "WIS", Value = 12 },
                new Attribute { Name = "CHA", Value = 6 },
            }
        });
        All.Add(new Character() {
            Name = "Giant Boar",
            Ac = 12,
            Hp = 42,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-g",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 17 },
                new Attribute { Name = "DEX", Value = 10 },
                new Attribute { Name = "CON", Value = 16 },
                new Attribute { Name = "INT", Value = 2 },
                new Attribute { Name = "WIS", Value = 7 },
                new Attribute { Name = "CHA", Value = 5 },
            }
        });
        All.Add(new Character() {
            Name = "Giant Centipede",
            Ac = 13,
            Hp = 4,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-g",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 5 },
                new Attribute { Name = "DEX", Value = 14 },
                new Attribute { Name = "CON", Value = 12 },
                new Attribute { Name = "INT", Value = 1 },
                new Attribute { Name = "WIS", Value = 7 },
                new Attribute { Name = "CHA", Value = 3 },
            }
        });
        All.Add(new Character() {
            Name = "Giant Constrictor Snake",
            Ac = 12,
            Hp = 60,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-g",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 19 },
                new Attribute { Name = "DEX", Value = 14 },
                new Attribute { Name = "CON", Value = 12 },
                new Attribute { Name = "INT", Value = 1 },
                new Attribute { Name = "WIS", Value = 10 },
                new Attribute { Name = "CHA", Value = 3 },
            }
        });
        All.Add(new Character() {
            Name = "Giant Crab",
            Ac = 15,
            Hp = 13,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-g",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 13 },
                new Attribute { Name = "DEX", Value = 15 },
                new Attribute { Name = "CON", Value = 11 },
                new Attribute { Name = "INT", Value = 1 },
                new Attribute { Name = "WIS", Value = 9 },
                new Attribute { Name = "CHA", Value = 3 },
            }
        });
        All.Add(new Character() {
            Name = "Giant Crocodile",
            Ac = 14,
            Hp = 85,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-g",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 21 },
                new Attribute { Name = "DEX", Value = 9 },
                new Attribute { Name = "CON", Value = 17 },
                new Attribute { Name = "INT", Value = 2 },
                new Attribute { Name = "WIS", Value = 10 },
                new Attribute { Name = "CHA", Value = 7 },
            }
        });
        All.Add(new Character() {
            Name = "Giant Eagle",
            Ac = 13,
            Hp = 26,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-g",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 16 },
                new Attribute { Name = "DEX", Value = 17 },
                new Attribute { Name = "CON", Value = 13 },
                new Attribute { Name = "INT", Value = 8 },
                new Attribute { Name = "WIS", Value = 14 },
                new Attribute { Name = "CHA", Value = 10 },
            }
        });
        All.Add(new Character() {
            Name = "Giant Elk",
            Ac = 14,
            Hp = 42,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-g",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 19 },
                new Attribute { Name = "DEX", Value = 16 },
                new Attribute { Name = "CON", Value = 14 },
                new Attribute { Name = "INT", Value = 7 },
                new Attribute { Name = "WIS", Value = 14 },
                new Attribute { Name = "CHA", Value = 10 },
            }
        });
        All.Add(new Character() {
            Name = "Giant Fire Beetle",
            Ac = 13,
            Hp = 4,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-g",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 8 },
                new Attribute { Name = "DEX", Value = 10 },
                new Attribute { Name = "CON", Value = 12 },
                new Attribute { Name = "INT", Value = 1 },
                new Attribute { Name = "WIS", Value = 7 },
                new Attribute { Name = "CHA", Value = 3 },
            }
        });
        All.Add(new Character() {
            Name = "Giant Frog",
            Ac = 11,
            Hp = 18,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-g",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 12 },
                new Attribute { Name = "DEX", Value = 13 },
                new Attribute { Name = "CON", Value = 11 },
                new Attribute { Name = "INT", Value = 2 },
                new Attribute { Name = "WIS", Value = 10 },
                new Attribute { Name = "CHA", Value = 3 },
            }
        });
        All.Add(new Character() {
            Name = "Giant Goat",
            Ac = 11,
            Hp = 19,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-g",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 17 },
                new Attribute { Name = "DEX", Value = 11 },
                new Attribute { Name = "CON", Value = 12 },
                new Attribute { Name = "INT", Value = 3 },
                new Attribute { Name = "WIS", Value = 12 },
                new Attribute { Name = "CHA", Value = 6 },
            }
        });
        All.Add(new Character() {
            Name = "Giant Hyena",
            Ac = 12,
            Hp = 45,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-g",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 16 },
                new Attribute { Name = "DEX", Value = 14 },
                new Attribute { Name = "CON", Value = 14 },
                new Attribute { Name = "INT", Value = 2 },
                new Attribute { Name = "WIS", Value = 12 },
                new Attribute { Name = "CHA", Value = 7 },
            }
        });
        All.Add(new Character() {
            Name = "Giant Lizard",
            Ac = 12,
            Hp = 19,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-g",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 15 },
                new Attribute { Name = "DEX", Value = 12 },
                new Attribute { Name = "CON", Value = 13 },
                new Attribute { Name = "INT", Value = 2 },
                new Attribute { Name = "WIS", Value = 10 },
                new Attribute { Name = "CHA", Value = 5 },
            }
        });
        All.Add(new Character() {
            Name = "Giant Octopus",
            Ac = 11,
            Hp = 52,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-g",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 17 },
                new Attribute { Name = "DEX", Value = 13 },
                new Attribute { Name = "CON", Value = 13 },
                new Attribute { Name = "INT", Value = 4 },
                new Attribute { Name = "WIS", Value = 10 },
                new Attribute { Name = "CHA", Value = 4 },
            }
        });
        All.Add(new Character() {
            Name = "Giant Owl",
            Ac = 12,
            Hp = 19,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-g",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 13 },
                new Attribute { Name = "DEX", Value = 15 },
                new Attribute { Name = "CON", Value = 12 },
                new Attribute { Name = "INT", Value = 8 },
                new Attribute { Name = "WIS", Value = 13 },
                new Attribute { Name = "CHA", Value = 10 },
            }
        });
        All.Add(new Character() {
            Name = "Giant Poisonous Snake",
            Ac = 14,
            Hp = 11,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-g",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 10 },
                new Attribute { Name = "DEX", Value = 18 },
                new Attribute { Name = "CON", Value = 13 },
                new Attribute { Name = "INT", Value = 2 },
                new Attribute { Name = "WIS", Value = 10 },
                new Attribute { Name = "CHA", Value = 3 },
            }
        });
        All.Add(new Character() {
            Name = "Giant Rat",
            Ac = 12,
            Hp = 7,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-g",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 7 },
                new Attribute { Name = "DEX", Value = 15 },
                new Attribute { Name = "CON", Value = 11 },
                new Attribute { Name = "INT", Value = 2 },
                new Attribute { Name = "WIS", Value = 10 },
                new Attribute { Name = "CHA", Value = 4 },
            }
        });
        All.Add(new Character() {
            Name = "Giant Scorpion",
            Ac = 15,
            Hp = 52,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-g",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 15 },
                new Attribute { Name = "DEX", Value = 13 },
                new Attribute { Name = "CON", Value = 15 },
                new Attribute { Name = "INT", Value = 1 },
                new Attribute { Name = "WIS", Value = 9 },
                new Attribute { Name = "CHA", Value = 3 },
            }
        });
        All.Add(new Character() {
            Name = "Giant Sea Horse",
            Ac = 13,
            Hp = 16,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-g",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 12 },
                new Attribute { Name = "DEX", Value = 15 },
                new Attribute { Name = "CON", Value = 11 },
                new Attribute { Name = "INT", Value = 2 },
                new Attribute { Name = "WIS", Value = 12 },
                new Attribute { Name = "CHA", Value = 5 },
            }
        });
        All.Add(new Character() {
            Name = "Giant Shark",
            Ac = 13 ,
            Hp = 126 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-g",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 23 },
                new Attribute { Name = "DEX", Value = 11 },
                new Attribute { Name = "CON", Value = 21 },
                new Attribute { Name = "INT", Value = 1 },
                new Attribute { Name = "WIS", Value = 10 },
                new Attribute { Name = "CHA", Value = 5 },
            }
        });
        All.Add(new Character() {
            Name = "Giant Spider",
            Ac = 14 ,
            Hp = 26 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-g",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 14 },
                new Attribute { Name = "DEX", Value = 16 },
                new Attribute { Name = "CON", Value = 12 },
                new Attribute { Name = "INT", Value = 3 },
                new Attribute { Name = "WIS", Value = 11 },
                new Attribute { Name = "CHA", Value = 4 },
            }
        });
        All.Add(new Character() {
            Name = "Giant Toad",
            Ac = 11 ,
            Hp = 39 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-g",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 15 },
                new Attribute { Name = "DEX", Value = 13 },
                new Attribute { Name = "CON", Value = 13 },
                new Attribute { Name = "INT", Value = 2 },
                new Attribute { Name = "WIS", Value = 10 },
                new Attribute { Name = "CHA", Value = 3 },
            }
        });
        All.Add(new Character() {
            Name = "Giant Vulture",
            Ac = 10 ,
            Hp = 22 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-g",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 15 },
                new Attribute { Name = "DEX", Value = 10 },
                new Attribute { Name = "CON", Value = 15 },
                new Attribute { Name = "INT", Value = 6 },
                new Attribute { Name = "WIS", Value = 12 },
                new Attribute { Name = "CHA", Value = 7 },
            }
        });
        All.Add(new Character() {
            Name = "Giant Wasp",
            Ac = 12 ,
            Hp = 13 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-g",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 10 },
                new Attribute { Name = "DEX", Value = 14 },
                new Attribute { Name = "CON", Value = 10 },
                new Attribute { Name = "INT", Value = 1 },
                new Attribute { Name = "WIS", Value = 10 },
                new Attribute { Name = "CHA", Value = 3 },
            }
        });
        All.Add(new Character() {
            Name = "Giant Weasel",
            Ac = 13 ,
            Hp = 9 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-g",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 11 },
                new Attribute { Name = "DEX", Value = 16 },
                new Attribute { Name = "CON", Value = 10 },
                new Attribute { Name = "INT", Value = 4 },
                new Attribute { Name = "WIS", Value = 12 },
                new Attribute { Name = "CHA", Value = 5 },
            }
        });
        All.Add(new Character() {
            Name = "Giant Wolf Spider",
            Ac = 13 ,
            Hp = 11 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-g",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 12 },
                new Attribute { Name = "DEX", Value = 16 },
                new Attribute { Name = "CON", Value = 13 },
                new Attribute { Name = "INT", Value = 3 },
                new Attribute { Name = "WIS", Value = 12 },
                new Attribute { Name = "CHA", Value = 4 },
            }
        });
        All.Add(new Character() {
            Name = "Glabrezu",
            Ac = 17 ,
            Hp = 157 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-g",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 20 },
                new Attribute { Name = "DEX", Value = 15 },
                new Attribute { Name = "CON", Value = 21 },
                new Attribute { Name = "INT", Value = 19 },
                new Attribute { Name = "WIS", Value = 17 },
                new Attribute { Name = "CHA", Value = 16 },
            }
        });
        All.Add(new Character() {
            Name = "Gibbering Mouther",
            Ac = 9 ,
            Hp = 67 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-g",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 10 },
                new Attribute { Name = "DEX", Value = 8 },
                new Attribute { Name = "CON", Value = 16 },
                new Attribute { Name = "INT", Value = 3 },
                new Attribute { Name = "WIS", Value = 10 },
                new Attribute { Name = "CHA", Value = 6 },
            }
        });
        All.Add(new Character() {
            Name = "Gnoll",
            Ac = 15 ,
            Hp = 22 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-g",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 14 },
                new Attribute { Name = "DEX", Value = 12 },
                new Attribute { Name = "CON", Value = 11 },
                new Attribute { Name = "INT", Value = 6 },
                new Attribute { Name = "WIS", Value = 10 },
                new Attribute { Name = "CHA", Value = 7 },
            }
        });
        All.Add(new Character() {
            Name = "Goat",
            Ac = 10 ,
            Hp = 4 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-g",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 12 },
                new Attribute { Name = "DEX", Value = 10 },
                new Attribute { Name = "CON", Value = 11 },
                new Attribute { Name = "INT", Value = 2 },
                new Attribute { Name = "WIS", Value = 10 },
                new Attribute { Name = "CHA", Value = 5 },
            }
        });
        All.Add(new Character() {
            Name = "Goblin",
            Ac = 15 ,
            Hp = 7 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-g",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 8 },
                new Attribute { Name = "DEX", Value = 14 },
                new Attribute { Name = "CON", Value = 10 },
                new Attribute { Name = "INT", Value = 10 },
                new Attribute { Name = "WIS", Value = 8 },
                new Attribute { Name = "CHA", Value = 8 },
            }
        });
        All.Add(new Character() {
            Name = "Gold Dragon Wyrmling",
            Ac = 17 ,
            Hp = 60 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-g",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 19 },
                new Attribute { Name = "DEX", Value = 14 },
                new Attribute { Name = "CON", Value = 17 },
                new Attribute { Name = "INT", Value = 14 },
                new Attribute { Name = "WIS", Value = 11 },
                new Attribute { Name = "CHA", Value = 16 },
            }
        });
        All.Add(new Character() {
            Name = "Gorgon",
            Ac = 19 ,
            Hp = 114 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-g",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 20 },
                new Attribute { Name = "DEX", Value = 11 },
                new Attribute { Name = "CON", Value = 18 },
                new Attribute { Name = "INT", Value = 2 },
                new Attribute { Name = "WIS", Value = 12 },
                new Attribute { Name = "CHA", Value = 7 },
            }
        });
        All.Add(new Character() {
            Name = "Grey Ooze",
            Ac = 8 ,
            Hp = 22 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-g",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 12 },
                new Attribute { Name = "DEX", Value = 6 },
                new Attribute { Name = "CON", Value = 16 },
                new Attribute { Name = "INT", Value = 1 },
                new Attribute { Name = "WIS", Value = 6 },
                new Attribute { Name = "CHA", Value = 2 },
            }
        });
        All.Add(new Character() {
            Name = "Green Dragon Wyrmling",
            Ac = 17 ,
            Hp = 38 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-g",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 15 },
                new Attribute { Name = "DEX", Value = 12 },
                new Attribute { Name = "CON", Value = 13 },
                new Attribute { Name = "INT", Value = 14 },
                new Attribute { Name = "WIS", Value = 11 },
                new Attribute { Name = "CHA", Value = 13 },
            }
        });
        All.Add(new Character() {
            Name = "Green Hag",
            Ac = 17 ,
            Hp = 82 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-g",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 18 },
                new Attribute { Name = "DEX", Value = 12 },
                new Attribute { Name = "CON", Value = 16 },
                new Attribute { Name = "INT", Value = 13 },
                new Attribute { Name = "WIS", Value = 14 },
                new Attribute { Name = "CHA", Value = 14 },
            }
        });
        All.Add(new Character() {
            Name = "Grick",
            Ac = 14 ,
            Hp = 27 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-g",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 14 },
                new Attribute { Name = "DEX", Value = 14 },
                new Attribute { Name = "CON", Value = 11 },
                new Attribute { Name = "INT", Value = 3 },
                new Attribute { Name = "WIS", Value = 14 },
                new Attribute { Name = "CHA", Value = 5 },
            }
        });
        All.Add(new Character() {
            Name = "Griffon",
            Ac = 12 ,
            Hp = 59 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-g",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 18 },
                new Attribute { Name = "DEX", Value = 15 },
                new Attribute { Name = "CON", Value = 16 },
                new Attribute { Name = "INT", Value = 2 },
                new Attribute { Name = "WIS", Value = 13 },
                new Attribute { Name = "CHA", Value = 8 },
            }
        });
        All.Add(new Character() {
            Name = "Grimlock",
            Ac = 11 ,
            Hp = 11 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-g",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 16 },
                new Attribute { Name = "DEX", Value = 12 },
                new Attribute { Name = "CON", Value = 12 },
                new Attribute { Name = "INT", Value = 9 },
                new Attribute { Name = "WIS", Value = 8 },
                new Attribute { Name = "CHA", Value = 6 },
            }
        });
        All.Add(new Character() {
            Name = "Guardian Naga",
            Ac = 18 ,
            Hp = 127 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-g",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 19 },
                new Attribute { Name = "DEX", Value = 18 },
                new Attribute { Name = "CON", Value = 16 },
                new Attribute { Name = "INT", Value = 16 },
                new Attribute { Name = "WIS", Value = 19 },
                new Attribute { Name = "CHA", Value = 18 },
            }
        });
        All.Add(new Character() {
            Name = "Gynosphinx",
            Ac = 17 ,
            Hp = 136 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-g",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 18 },
                new Attribute { Name = "DEX", Value = 15 },
                new Attribute { Name = "CON", Value = 16 },
                new Attribute { Name = "INT", Value = 18 },
                new Attribute { Name = "WIS", Value = 18 },
                new Attribute { Name = "CHA", Value = 18 },
            }
        });
        #endregion
        #region H
        All.Add(new Character() {
            Name = "Harpy",
            Ac = 11,
            Hp = 38,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-h",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 16 },
                new Attribute { Name = "DEX", Value = 13 },
                new Attribute { Name = "CON", Value = 14 },
                new Attribute { Name = "INT", Value = 10 },
                new Attribute { Name = "WIS", Value = 11 },
                new Attribute { Name = "CHA", Value = 10 },
            }
        });
        All.Add(new Character() {
            Name = "Hell Hound",
            Ac = 15,
            Hp = 45,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-h",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 17 },
                new Attribute { Name = "DEX", Value = 12 },
                new Attribute { Name = "CON", Value = 14 },
                new Attribute { Name = "INT", Value = 6 },
                new Attribute { Name = "WIS", Value = 13 },
                new Attribute { Name = "CHA", Value = 6 },
            }
        });
        All.Add(new Character() {
            Name = "Hezrou",
            Ac = 16,
            Hp = 136,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-h",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 19 },
                new Attribute { Name = "DEX", Value = 17 },
                new Attribute { Name = "CON", Value = 20 },
                new Attribute { Name = "INT", Value = 5 },
                new Attribute { Name = "WIS", Value = 12 },
                new Attribute { Name = "CHA", Value = 13 },
            }
        });
        All.Add(new Character() {
            Name = "Hill Giant",
            Ac = 13,
            Hp = 105,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-h",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 21 },
                new Attribute { Name = "DEX", Value = 8 },
                new Attribute { Name = "CON", Value = 19 },
                new Attribute { Name = "INT", Value = 5 },
                new Attribute { Name = "WIS", Value = 9 },
                new Attribute { Name = "CHA", Value = 6 },
            }
        });
        All.Add(new Character() {
            Name = "Hippogriff",
            Ac = 11,
            Hp = 19,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-h",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 17 },
                new Attribute { Name = "DEX", Value = 13 },
                new Attribute { Name = "CON", Value = 13 },
                new Attribute { Name = "INT", Value = 2 },
                new Attribute { Name = "WIS", Value = 12 },
                new Attribute { Name = "CHA", Value = 8 },
            }
        });
        All.Add(new Character() {
            Name = "Hobgoblin",
            Ac = 18,
            Hp = 11,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-h",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 13 },
                new Attribute { Name = "DEX", Value = 12 },
                new Attribute { Name = "CON", Value = 12 },
                new Attribute { Name = "INT", Value = 10 },
                new Attribute { Name = "WIS", Value = 10 },
                new Attribute { Name = "CHA", Value = 9 },
            }
        });
        All.Add(new Character() {
            Name = "Homunculus",
            Ac = 13,
            Hp = 5,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-h",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 4 },
                new Attribute { Name = "DEX", Value = 15 },
                new Attribute { Name = "CON", Value = 11 },
                new Attribute { Name = "INT", Value = 10 },
                new Attribute { Name = "WIS", Value = 10 },
                new Attribute { Name = "CHA", Value = 7 },
            }
        });
        All.Add(new Character() {
            Name = "Horned Devil",
            Ac = 18,
            Hp = 178,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-h",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 22 },
                new Attribute { Name = "DEX", Value = 17 },
                new Attribute { Name = "CON", Value = 21 },
                new Attribute { Name = "INT", Value = 12 },
                new Attribute { Name = "WIS", Value = 16 },
                new Attribute { Name = "CHA", Value = 17 },
            }
        });
        All.Add(new Character() {
            Name = "Hunter Shark",
            Ac = 12,
            Hp = 45,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-h",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 18 },
                new Attribute { Name = "DEX", Value = 13 },
                new Attribute { Name = "CON", Value = 15 },
                new Attribute { Name = "INT", Value = 1 },
                new Attribute { Name = "WIS", Value = 10 },
                new Attribute { Name = "CHA", Value = 4 },
            }
        });
        All.Add(new Character() {
            Name = "Hydra",
            Ac = 15,
            Hp = 172,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-h",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 20 },
                new Attribute { Name = "DEX", Value = 12 },
                new Attribute { Name = "CON", Value = 20 },
                new Attribute { Name = "INT", Value = 2 },
                new Attribute { Name = "WIS", Value = 10 },
                new Attribute { Name = "CHA", Value = 7 },
            }
        });
        All.Add(new Character() {
            Name = "Hyena",
            Ac = 11,
            Hp = 5,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-h",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 11 },
                new Attribute { Name = "DEX", Value = 13 },
                new Attribute { Name = "CON", Value = 12 },
                new Attribute { Name = "INT", Value = 2 },
                new Attribute { Name = "WIS", Value = 12 },
                new Attribute { Name = "CHA", Value = 5 },
            }
        });
        #endregion
        #region I
        All.Add(new Character() {
            Name = "Ice Devil",
            Ac = 18,
            Hp = 180,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-i",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 21 },
                new Attribute { Name = "DEX", Value = 14 },
                new Attribute { Name = "CON", Value = 18 },
                new Attribute { Name = "INT", Value = 18 },
                new Attribute { Name = "WIS", Value = 15 },
                new Attribute { Name = "CHA", Value = 18 },
            }
        });
        All.Add(new Character() {
            Name = "Ice Mephit",
            Ac = 11,
            Hp = 21,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-i",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 7 },
                new Attribute { Name = "DEX", Value = 13 },
                new Attribute { Name = "CON", Value = 10 },
                new Attribute { Name = "INT", Value = 9 },
                new Attribute { Name = "WIS", Value = 11 },
                new Attribute { Name = "CHA", Value = 12 },
            }
        });
        All.Add(new Character() {
            Name = "Imp",
            Ac = 13,
            Hp = 10,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-i",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 6 },
                new Attribute { Name = "DEX", Value = 17 },
                new Attribute { Name = "CON", Value = 13 },
                new Attribute { Name = "INT", Value = 11 },
                new Attribute { Name = "WIS", Value = 12 },
                new Attribute { Name = "CHA", Value = 14 },
            }
        });
        All.Add(new Character() {
            Name = "Invisible Stalker",
            Ac = 14,
            Hp = 104,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-i",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 16 },
                new Attribute { Name = "DEX", Value = 19 },
                new Attribute { Name = "CON", Value = 14 },
                new Attribute { Name = "INT", Value = 10 },
                new Attribute { Name = "WIS", Value = 15 },
                new Attribute { Name = "CHA", Value = 11 },
            }
        });
        All.Add(new Character() {
            Name = "Iron Golem",
            Ac = 20,
            Hp = 210,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-i",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 24 },
                new Attribute { Name = "DEX", Value = 9 },
                new Attribute { Name = "CON", Value = 20 },
                new Attribute { Name = "INT", Value = 3 },
                new Attribute { Name = "WIS", Value = 11 },
                new Attribute { Name = "CHA", Value = 1 },
            }
        });
        #endregion
        #region J
        All.Add(new Character() {
            Name = "Jackal",
            Ac = 12,
            Hp = 3,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-j",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 8 },
                new Attribute { Name = "DEX", Value = 15 },
                new Attribute { Name = "CON", Value = 11 },
                new Attribute { Name = "INT", Value = 3 },
                new Attribute { Name = "WIS", Value = 12 },
                new Attribute { Name = "CHA", Value = 6 },
            }
        });
        #endregion
        #region K
        All.Add(new Character() {
            Name = "Killer Whale",
            Ac = 12,
            Hp = 90,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-k",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 19 },
                new Attribute { Name = "DEX", Value = 10 },
                new Attribute { Name = "CON", Value = 13 },
                new Attribute { Name = "INT", Value = 3 },
                new Attribute { Name = "WIS", Value = 12 },
                new Attribute { Name = "CHA", Value = 7 },
            }
        });
        All.Add(new Character() {
            Name = "Kobold",
            Ac = 12,
            Hp = 5,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-k",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 7 },
                new Attribute { Name = "DEX", Value = 15 },
                new Attribute { Name = "CON", Value = 9 },
                new Attribute { Name = "INT", Value = 8 },
                new Attribute { Name = "WIS", Value = 7 },
                new Attribute { Name = "CHA", Value = 8 },
            }
        });
        All.Add(new Character() {
            Name = "Kraken",
            Ac = 18,
            Hp = 472,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-k",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 30 },
                new Attribute { Name = "DEX", Value = 11 },
                new Attribute { Name = "CON", Value = 25 },
                new Attribute { Name = "INT", Value = 22 },
                new Attribute { Name = "WIS", Value = 18 },
                new Attribute { Name = "CHA", Value = 20 },
            }
        });
        #endregion
        #region L
        All.Add(new Character() {
            Name = "Lamia",
            Ac = 13,
            Hp = 97,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-l",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 16 },
                new Attribute { Name = "DEX", Value = 13 },
                new Attribute { Name = "CON", Value = 15 },
                new Attribute { Name = "INT", Value = 14 },
                new Attribute { Name = "WIS", Value = 15 },
                new Attribute { Name = "CHA", Value = 16 },
            }
        });
        All.Add(new Character() {
            Name = "Lemure",
            Ac = 7,
            Hp = 13,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-l",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 10 },
                new Attribute { Name = "DEX", Value = 5 },
                new Attribute { Name = "CON", Value = 11 },
                new Attribute { Name = "INT", Value = 1 },
                new Attribute { Name = "WIS", Value = 11 },
                new Attribute { Name = "CHA", Value = 3 },
            }
        });
        All.Add(new Character() {
            Name = "Lich",
            Ac = 17,
            Hp = 135,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-l",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 11 },
                new Attribute { Name = "DEX", Value = 16 },
                new Attribute { Name = "CON", Value = 16 },
                new Attribute { Name = "INT", Value = 20 },
                new Attribute { Name = "WIS", Value = 14 },
                new Attribute { Name = "CHA", Value = 16 },
            }
        });
        All.Add(new Character() {
            Name = "Lion",
            Ac = 12,
            Hp = 26,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-l",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 17 },
                new Attribute { Name = "DEX", Value = 15 },
                new Attribute { Name = "CON", Value = 13 },
                new Attribute { Name = "INT", Value = 3 },
                new Attribute { Name = "WIS", Value = 12 },
                new Attribute { Name = "CHA", Value = 8 },
            }
        });
        All.Add(new Character() {
            Name = "Lizard",
            Ac = 10,
            Hp = 2,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-l",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 2 },
                new Attribute { Name = "DEX", Value = 11 },
                new Attribute { Name = "CON", Value = 10 },
                new Attribute { Name = "INT", Value = 1 },
                new Attribute { Name = "WIS", Value = 8 },
                new Attribute { Name = "CHA", Value = 3 },
            }
        });
        All.Add(new Character() {
            Name = "Lizardfolk",
            Ac = 15,
            Hp = 22,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-l",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 15 },
                new Attribute { Name = "DEX", Value = 10 },
                new Attribute { Name = "CON", Value = 13 },
                new Attribute { Name = "INT", Value = 7 },
                new Attribute { Name = "WIS", Value = 12 },
                new Attribute { Name = "CHA", Value = 7 },
            }
        });
        #endregion
        #region M
        All.Add(new Character() {
            Name = "Magma Mephit",
            Ac = 11,
            Hp = 22,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-m",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 8 },
                new Attribute { Name = "DEX", Value = 12 },
                new Attribute { Name = "CON", Value = 12 },
                new Attribute { Name = "INT", Value = 7 },
                new Attribute { Name = "WIS", Value = 10 },
                new Attribute { Name = "CHA", Value = 10 },
            }
        });
        All.Add(new Character() {
            Name = "Magmin",
            Ac = 14,
            Hp = 9,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-m",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 7 },
                new Attribute { Name = "DEX", Value = 15 },
                new Attribute { Name = "CON", Value = 12 },
                new Attribute { Name = "INT", Value = 8 },
                new Attribute { Name = "WIS", Value = 11 },
                new Attribute { Name = "CHA", Value = 10 },
            }
        });
        All.Add(new Character() {
            Name = "Mammoth",
            Ac = 13,
            Hp = 126,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-m",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 24 },
                new Attribute { Name = "DEX", Value = 9 },
                new Attribute { Name = "CON", Value = 21 },
                new Attribute { Name = "INT", Value = 3 },
                new Attribute { Name = "WIS", Value = 11 },
                new Attribute { Name = "CHA", Value = 6 },
            }
        });
        All.Add(new Character() {
            Name = "Manticore",
            Ac = 14,
            Hp = 68,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-m",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 17 },
                new Attribute { Name = "DEX", Value = 16 },
                new Attribute { Name = "CON", Value = 17 },
                new Attribute { Name = "INT", Value = 7 },
                new Attribute { Name = "WIS", Value = 12 },
                new Attribute { Name = "CHA", Value = 8 },
            }
        });
        All.Add(new Character() {
            Name = "Marilith",
            Ac = 18,
            Hp = 189,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-m",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 18 },
                new Attribute { Name = "DEX", Value = 20 },
                new Attribute { Name = "CON", Value = 20 },
                new Attribute { Name = "INT", Value = 18 },
                new Attribute { Name = "WIS", Value = 16 },
                new Attribute { Name = "CHA", Value = 20 },
            }
        });
        All.Add(new Character() {
            Name = "Mastiff",
            Ac = 12,
            Hp = 5,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-m",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 13 },
                new Attribute { Name = "DEX", Value = 14 },
                new Attribute { Name = "CON", Value = 12 },
                new Attribute { Name = "INT", Value = 3 },
                new Attribute { Name = "WIS", Value = 12 },
                new Attribute { Name = "CHA", Value = 7 },
            }
        });
        All.Add(new Character() {
            Name = "Medusa",
            Ac = 15,
            Hp = 127,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-m",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 10 },
                new Attribute { Name = "DEX", Value = 15 },
                new Attribute { Name = "CON", Value = 16 },
                new Attribute { Name = "INT", Value = 12 },
                new Attribute { Name = "WIS", Value = 13 },
                new Attribute { Name = "CHA", Value = 15 },
            }
        });
        All.Add(new Character() {
            Name = "Merfolk",
            Ac = 11,
            Hp = 11,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-m",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 10 },
                new Attribute { Name = "DEX", Value = 13 },
                new Attribute { Name = "CON", Value = 12 },
                new Attribute { Name = "INT", Value = 11 },
                new Attribute { Name = "WIS", Value = 11 },
                new Attribute { Name = "CHA", Value = 12 },
            }
        });
        All.Add(new Character() {
            Name = "Merrow",
            Ac = 13,
            Hp = 45,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-m",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 18 },
                new Attribute { Name = "DEX", Value = 10 },
                new Attribute { Name = "CON", Value = 15 },
                new Attribute { Name = "INT", Value = 8 },
                new Attribute { Name = "WIS", Value = 10 },
                new Attribute { Name = "CHA", Value = 9 },
            }
        });
        All.Add(new Character() {
            Name = "Mimic",
            Ac = 12,
            Hp = 58,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-m",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 17 },
                new Attribute { Name = "DEX", Value = 12 },
                new Attribute { Name = "CON", Value = 15 },
                new Attribute { Name = "INT", Value = 5 },
                new Attribute { Name = "WIS", Value = 13 },
                new Attribute { Name = "CHA", Value = 8 },
            }
        });
        All.Add(new Character() {
            Name = "Minotaur",
            Ac = 14,
            Hp = 76,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-m",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 18 },
                new Attribute { Name = "DEX", Value = 11 },
                new Attribute { Name = "CON", Value = 16 },
                new Attribute { Name = "INT", Value = 6 },
                new Attribute { Name = "WIS", Value = 16 },
                new Attribute { Name = "CHA", Value = 9 },
            }
        });
        All.Add(new Character() {
            Name = "Minotaur Skeleton",
            Ac = 12,
            Hp = 67,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-m",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 18 },
                new Attribute { Name = "DEX", Value = 11 },
                new Attribute { Name = "CON", Value = 15 },
                new Attribute { Name = "INT", Value = 6 },
                new Attribute { Name = "WIS", Value = 8 },
                new Attribute { Name = "CHA", Value = 5 },
            }
        });
        All.Add(new Character() {
            Name = "Mule",
            Ac = 10,
            Hp = 11,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-m",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 14 },
                new Attribute { Name = "DEX", Value = 10 },
                new Attribute { Name = "CON", Value = 13 },
                new Attribute { Name = "INT", Value = 2 },
                new Attribute { Name = "WIS", Value = 10 },
                new Attribute { Name = "CHA", Value = 5 },
            }
        });
        All.Add(new Character() {
            Name = "Mummy",
            Ac = 11,
            Hp = 58,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-m",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 16 },
                new Attribute { Name = "DEX", Value = 8 },
                new Attribute { Name = "CON", Value = 15 },
                new Attribute { Name = "INT", Value = 6 },
                new Attribute { Name = "WIS", Value = 10 },
                new Attribute { Name = "CHA", Value = 12 },
            }
        });
        All.Add(new Character() {
            Name = "Mummy Lord",
            Ac = 17,
            Hp = 97,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-m",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 18 },
                new Attribute { Name = "DEX", Value = 10 },
                new Attribute { Name = "CON", Value = 17 },
                new Attribute { Name = "INT", Value = 11 },
                new Attribute { Name = "WIS", Value = 18 },
                new Attribute { Name = "CHA", Value = 16 },
            }
        });
        #endregion
        #region N
        All.Add(new Character() {
            Name = "Nalfeshnee",
            Ac = 18,
            Hp = 184,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-n",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 21 },
                new Attribute { Name = "DEX", Value = 10 },
                new Attribute { Name = "CON", Value = 22 },
                new Attribute { Name = "INT", Value = 19 },
                new Attribute { Name = "WIS", Value = 12 },
                new Attribute { Name = "CHA", Value = 15 },
            }
        });
        All.Add(new Character() {
            Name = "Night Hag",
            Ac = 17,
            Hp = 112,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-n",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 18 },
                new Attribute { Name = "DEX", Value = 15 },
                new Attribute { Name = "CON", Value = 16 },
                new Attribute { Name = "INT", Value = 16 },
                new Attribute { Name = "WIS", Value = 14 },
                new Attribute { Name = "CHA", Value = 16 },
            }
        });
        All.Add(new Character() {
            Name = "Nothic",
            Ac = 15,
            Hp = 45,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-n",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 14 },
                new Attribute { Name = "DEX", Value = 16 },
                new Attribute { Name = "CON", Value = 16 },
                new Attribute { Name = "INT", Value = 13 },
                new Attribute { Name = "WIS", Value = 10 },
                new Attribute { Name = "CHA", Value = 8 },
            }
        });
        #endregion
        #region O
        All.Add(new Character() {
            Name = "Ochre Jelly",
            Ac = 8,
            Hp = 45,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-o",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 15 },
                new Attribute { Name = "DEX", Value = 6 },
                new Attribute { Name = "CON", Value = 14 },
                new Attribute { Name = "INT", Value = 2 },
                new Attribute { Name = "WIS", Value = 6 },
                new Attribute { Name = "CHA", Value = 1 },
            }
        });
        All.Add(new Character() {
            Name = "Octopus",
            Ac = 12,
            Hp = 3,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-o",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 4 },
                new Attribute { Name = "DEX", Value = 15 },
                new Attribute { Name = "CON", Value = 11 },
                new Attribute { Name = "INT", Value = 3 },
                new Attribute { Name = "WIS", Value = 10 },
                new Attribute { Name = "CHA", Value = 4 },
            }
        });
        All.Add(new Character() {
            Name = "Ogre",
            Ac = 11,
            Hp = 59,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-o",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 19 },
                new Attribute { Name = "DEX", Value = 8 },
                new Attribute { Name = "CON", Value = 16 },
                new Attribute { Name = "INT", Value = 5 },
                new Attribute { Name = "WIS", Value = 7 },
                new Attribute { Name = "CHA", Value = 7 },
            }
        });
        All.Add(new Character() {
            Name = "Ogre Zombie",
            Ac = 8,
            Hp = 85,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-o",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 19 },
                new Attribute { Name = "DEX", Value = 6 },
                new Attribute { Name = "CON", Value = 18 },
                new Attribute { Name = "INT", Value = 3 },
                new Attribute { Name = "WIS", Value = 6 },
                new Attribute { Name = "CHA", Value = 5 },
            }
        });
        All.Add(new Character() {
            Name = "Oni",
            Ac = 16,
            Hp = 110,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-o",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 19 },
                new Attribute { Name = "DEX", Value = 11 },
                new Attribute { Name = "CON", Value = 16 },
                new Attribute { Name = "INT", Value = 14 },
                new Attribute { Name = "WIS", Value = 12 },
                new Attribute { Name = "CHA", Value = 15 },
            }
        });
        All.Add(new Character() {
            Name = "Orc",
            Ac = 13,
            Hp = 15,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-o",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 16 },
                new Attribute { Name = "DEX", Value = 12 },
                new Attribute { Name = "CON", Value = 16 },
                new Attribute { Name = "INT", Value = 7 },
                new Attribute { Name = "WIS", Value = 11 },
                new Attribute { Name = "CHA", Value = 10 },
            }
        });
        All.Add(new Character() {
            Name = "Otyugh",
            Ac = 14,
            Hp = 114,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-o",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 16 },
                new Attribute { Name = "DEX", Value = 11 },
                new Attribute { Name = "CON", Value = 19 },
                new Attribute { Name = "INT", Value = 6 },
                new Attribute { Name = "WIS", Value = 13 },
                new Attribute { Name = "CHA", Value = 6 },
            }
        });
        All.Add(new Character() {
            Name = "Owl",
            Ac = 11,
            Hp = 1,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-o",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 3 },
                new Attribute { Name = "DEX", Value = 13 },
                new Attribute { Name = "CON", Value = 8 },
                new Attribute { Name = "INT", Value = 2 },
                new Attribute { Name = "WIS", Value = 12 },
                new Attribute { Name = "CHA", Value = 7 },
            }
        });
        All.Add(new Character() {
            Name = "Owlbear",
            Ac = 13,
            Hp = 59,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-o",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 20 },
                new Attribute { Name = "DEX", Value = 12 },
                new Attribute { Name = "CON", Value = 17 },
                new Attribute { Name = "INT", Value = 3 },
                new Attribute { Name = "WIS", Value = 12 },
                new Attribute { Name = "CHA", Value = 7 },
            }
        });
        #endregion
        #region P
        All.Add(new Character() {
            Name = "Panther",
            Ac = 12,
            Hp = 13,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-p",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 14 },
                new Attribute { Name = "DEX", Value = 15 },
                new Attribute { Name = "CON", Value = 10 },
                new Attribute { Name = "INT", Value = 3 },
                new Attribute { Name = "WIS", Value = 14 },
                new Attribute { Name = "CHA", Value = 7 },
            }
        });
        All.Add(new Character() {
            Name = "Pegasus",
            Ac = 12,
            Hp = 59,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-p",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 18 },
                new Attribute { Name = "DEX", Value = 15 },
                new Attribute { Name = "CON", Value = 16 },
                new Attribute { Name = "INT", Value = 10 },
                new Attribute { Name = "WIS", Value = 15 },
                new Attribute { Name = "CHA", Value = 13 },
            }
        });
        All.Add(new Character() {
            Name = "Phase Spider",
            Ac = 13,
            Hp = 32,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-p",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 15 },
                new Attribute { Name = "DEX", Value = 15 },
                new Attribute { Name = "CON", Value = 12 },
                new Attribute { Name = "INT", Value = 6 },
                new Attribute { Name = "WIS", Value = 10 },
                new Attribute { Name = "CHA", Value = 6 },
            }
        });
        All.Add(new Character() {
            Name = "Pit Fiend",
            Ac = 19,
            Hp = 300,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-p",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 26 },
                new Attribute { Name = "DEX", Value = 14 },
                new Attribute { Name = "CON", Value = 24 },
                new Attribute { Name = "INT", Value = 22 },
                new Attribute { Name = "WIS", Value = 18 },
                new Attribute { Name = "CHA", Value = 24 },
            }
        });
        All.Add(new Character() {
            Name = "Planetar",
            Ac = 19,
            Hp = 200,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-p",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 24 },
                new Attribute { Name = "DEX", Value = 20 },
                new Attribute { Name = "CON", Value = 24 },
                new Attribute { Name = "INT", Value = 19 },
                new Attribute { Name = "WIS", Value = 22 },
                new Attribute { Name = "CHA", Value = 25 },
            }
        });
        All.Add(new Character() {
            Name = "Plesiosaurus",
            Ac = 13,
            Hp = 68,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-p",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 18 },
                new Attribute { Name = "DEX", Value = 15 },
                new Attribute { Name = "CON", Value = 16 },
                new Attribute { Name = "INT", Value = 2 },
                new Attribute { Name = "WIS", Value = 12 },
                new Attribute { Name = "CHA", Value = 5 },
            }
        });
        All.Add(new Character() {
            Name = "Poisonous Snake",
            Ac = 12,
            Hp = 2,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-p",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 2 },
                new Attribute { Name = "DEX", Value = 16 },
                new Attribute { Name = "CON", Value = 11 },
                new Attribute { Name = "INT", Value = 1 },
                new Attribute { Name = "WIS", Value = 10 },
                new Attribute { Name = "CHA", Value = 3 },
            }
        });
        All.Add(new Character() {
            Name = "Polar Bear",
            Ac = 12,
            Hp = 42,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-p",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 20 },
                new Attribute { Name = "DEX", Value = 10 },
                new Attribute { Name = "CON", Value = 16 },
                new Attribute { Name = "INT", Value = 2 },
                new Attribute { Name = "WIS", Value = 13 },
                new Attribute { Name = "CHA", Value = 7 },
            }
        });
        All.Add(new Character() {
            Name = "Pony",
            Ac = 10,
            Hp = 11,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-p",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 15 },
                new Attribute { Name = "DEX", Value = 10 },
                new Attribute { Name = "CON", Value = 13 },
                new Attribute { Name = "INT", Value = 2 },
                new Attribute { Name = "WIS", Value = 11 },
                new Attribute { Name = "CHA", Value = 7 },
            }
        });
        All.Add(new Character() {
            Name = "Pseudodragon",
            Ac = 13,
            Hp = 7,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-p",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 6 },
                new Attribute { Name = "DEX", Value = 15 },
                new Attribute { Name = "CON", Value = 13 },
                new Attribute { Name = "INT", Value = 10 },
                new Attribute { Name = "WIS", Value = 12 },
                new Attribute { Name = "CHA", Value = 10 },
            }
        });
        All.Add(new Character() {
            Name = "Pteranodon",
            Ac = 13,
            Hp = 13,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-p",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 12 },
                new Attribute { Name = "DEX", Value = 15 },
                new Attribute { Name = "CON", Value = 10 },
                new Attribute { Name = "INT", Value = 2 },
                new Attribute { Name = "WIS", Value = 9 },
                new Attribute { Name = "CHA", Value = 5 },
            }
        });
        All.Add(new Character() {
            Name = "Purple Worm",
            Ac = 18,
            Hp = 247,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-p",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 28 },
                new Attribute { Name = "DEX", Value = 7 },
                new Attribute { Name = "CON", Value = 22 },
                new Attribute { Name = "INT", Value = 1 },
                new Attribute { Name = "WIS", Value = 8 },
                new Attribute { Name = "CHA", Value = 4 },
            }
        });
        #endregion
        #region Q
        All.Add(new Character() {
            Name = "Quasit",
            Ac = 13,
            Hp = 7,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-q",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 5 },
                new Attribute { Name = "DEX", Value = 17 },
                new Attribute { Name = "CON", Value = 10 },
                new Attribute { Name = "INT", Value = 7 },
                new Attribute { Name = "WIS", Value = 10 },
                new Attribute { Name = "CHA", Value = 10 },
            }
        });
        All.Add(new Character() {
            Name = "Quipper",
            Ac = 13,
            Hp = 1,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-q",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 2 },
                new Attribute { Name = "DEX", Value = 16 },
                new Attribute { Name = "CON", Value = 9 },
                new Attribute { Name = "INT", Value = 1 },
                new Attribute { Name = "WIS", Value = 7 },
                new Attribute { Name = "CHA", Value = 2 },
            }
        });
        #endregion
        #region R
        All.Add(new Character() {
            Name = "Rakshasa",
            Ac = 16,
            Hp = 110,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-r",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 14 },
                new Attribute { Name = "DEX", Value = 17 },
                new Attribute { Name = "CON", Value = 18 },
                new Attribute { Name = "INT", Value = 13 },
                new Attribute { Name = "WIS", Value = 16 },
                new Attribute { Name = "CHA", Value = 20 },
            }
        });
        All.Add(new Character() {
            Name = "Rat",
            Ac = 10,
            Hp = 1,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-r",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 2 },
                new Attribute { Name = "DEX", Value = 11 },
                new Attribute { Name = "CON", Value = 9 },
                new Attribute { Name = "INT", Value = 2 },
                new Attribute { Name = "WIS", Value = 10 },
                new Attribute { Name = "CHA", Value = 4 },
            }
        });
        All.Add(new Character() {
            Name = "Raven",
            Ac = 12,
            Hp = 1,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-r",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 2 },
                new Attribute { Name = "DEX", Value = 14 },
                new Attribute { Name = "CON", Value = 8 },
                new Attribute { Name = "INT", Value = 2 },
                new Attribute { Name = "WIS", Value = 12 },
                new Attribute { Name = "CHA", Value = 6 },
            }
        });
        All.Add(new Character() {
            Name = "Red Dragon Wyrmling",
            Ac = 17,
            Hp = 75,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-r",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 19 },
                new Attribute { Name = "DEX", Value = 10 },
                new Attribute { Name = "CON", Value = 17 },
                new Attribute { Name = "INT", Value = 12 },
                new Attribute { Name = "WIS", Value = 11 },
                new Attribute { Name = "CHA", Value = 15 },
            }
        });
        All.Add(new Character() {
            Name = "Reef Shark",
            Ac = 12,
            Hp = 22,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-r",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 14 },
                new Attribute { Name = "DEX", Value = 13 },
                new Attribute { Name = "CON", Value = 13 },
                new Attribute { Name = "INT", Value = 1 },
                new Attribute { Name = "WIS", Value = 10 },
                new Attribute { Name = "CHA", Value = 4 },
            }
        });
        All.Add(new Character() {
            Name = "Remorhaz",
            Ac = 17,
            Hp = 195,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-r",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 24 },
                new Attribute { Name = "DEX", Value = 13 },
                new Attribute { Name = "CON", Value = 21 },
                new Attribute { Name = "INT", Value = 4 },
                new Attribute { Name = "WIS", Value = 10 },
                new Attribute { Name = "CHA", Value = 5 },
            }
        });
        All.Add(new Character() {
            Name = "Rinoceros",
            Ac = 11,
            Hp = 45,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-r",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 21 },
                new Attribute { Name = "DEX", Value = 8 },
                new Attribute { Name = "CON", Value = 15 },
                new Attribute { Name = "INT", Value = 2 },
                new Attribute { Name = "WIS", Value = 12 },
                new Attribute { Name = "CHA", Value = 6 },
            }
        });
        All.Add(new Character() {
            Name = "Riding Horse",
            Ac = 10,
            Hp = 13,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-r",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 16 },
                new Attribute { Name = "DEX", Value = 10 },
                new Attribute { Name = "CON", Value = 12 },
                new Attribute { Name = "INT", Value = 2 },
                new Attribute { Name = "WIS", Value = 11 },
                new Attribute { Name = "CHA", Value = 7 },
            }
        });
        All.Add(new Character() {
            Name = "Roc",
            Ac = 15,
            Hp = 248,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-r",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 28 },
                new Attribute { Name = "DEX", Value = 10 },
                new Attribute { Name = "CON", Value = 20 },
                new Attribute { Name = "INT", Value = 3 },
                new Attribute { Name = "WIS", Value = 10 },
                new Attribute { Name = "CHA", Value = 9 },
            }
        });
        All.Add(new Character() {
            Name = "Roper",
            Ac = 20,
            Hp = 93,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-r",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 18 },
                new Attribute { Name = "DEX", Value = 8 },
                new Attribute { Name = "CON", Value = 17 },
                new Attribute { Name = "INT", Value = 7 },
                new Attribute { Name = "WIS", Value = 16 },
                new Attribute { Name = "CHA", Value = 6 },
            }
        });
        All.Add(new Character() {
            Name = "Rug of Smothering",
            Ac = 12,
            Hp = 33,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-r",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 17 },
                new Attribute { Name = "DEX", Value = 14 },
                new Attribute { Name = "CON", Value = 10 },
                new Attribute { Name = "INT", Value = 1 },
                new Attribute { Name = "WIS", Value = 3 },
                new Attribute { Name = "CHA", Value = 1 },
            }
        });
        All.Add(new Character() {
            Name = "Rust Monster",
            Ac = 14,
            Hp = 27,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-r",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 13 },
                new Attribute { Name = "DEX", Value = 12 },
                new Attribute { Name = "CON", Value = 13 },
                new Attribute { Name = "INT", Value = 2 },
                new Attribute { Name = "WIS", Value = 13 },
                new Attribute { Name = "CHA", Value = 6 },
            }
        });
        #endregion
        #region S
        All.Add(new Character() {
            Name = "Saber-toothed Tiger",
            Ac = 12,
            Hp = 52,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-s",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 18 },
                new Attribute { Name = "DEX", Value = 14 },
                new Attribute { Name = "CON", Value = 15 },
                new Attribute { Name = "INT", Value = 3 },
                new Attribute { Name = "WIS", Value = 12 },
                new Attribute { Name = "CHA", Value = 8 },
            }
        });
        All.Add(new Character() {
            Name = "Sahuagin",
            Ac = 12,
            Hp = 22,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-s",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 13 },
                new Attribute { Name = "DEX", Value = 11 },
                new Attribute { Name = "CON", Value = 12 },
                new Attribute { Name = "INT", Value = 12 },
                new Attribute { Name = "WIS", Value = 13 },
                new Attribute { Name = "CHA", Value = 9 },
            }
        });
        All.Add(new Character() {
            Name = "Salamander",
            Ac = 15,
            Hp = 90,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-s",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 18 },
                new Attribute { Name = "DEX", Value = 14 },
                new Attribute { Name = "CON", Value = 15 },
                new Attribute { Name = "INT", Value = 11 },
                new Attribute { Name = "WIS", Value = 10 },
                new Attribute { Name = "CHA", Value = 12 },
            }
        });
        All.Add(new Character() {
            Name = "Satyr",
            Ac = 14,
            Hp = 31,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-s",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 12 },
                new Attribute { Name = "DEX", Value = 16 },
                new Attribute { Name = "CON", Value = 11 },
                new Attribute { Name = "INT", Value = 12 },
                new Attribute { Name = "WIS", Value = 10 },
                new Attribute { Name = "CHA", Value = 14 },
            }
        });
        All.Add(new Character() {
            Name = "Scorpion",
            Ac = 11,
            Hp = 1,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-s",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 2 },
                new Attribute { Name = "DEX", Value = 11 },
                new Attribute { Name = "CON", Value = 8 },
                new Attribute { Name = "INT", Value = 1 },
                new Attribute { Name = "WIS", Value = 8 },
                new Attribute { Name = "CHA", Value = 2 },
            }
        });
        All.Add(new Character() {
            Name = "Sea Hag",
            Ac = 14,
            Hp = 52,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-s",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 16 },
                new Attribute { Name = "DEX", Value = 13 },
                new Attribute { Name = "CON", Value = 16 },
                new Attribute { Name = "INT", Value = 12 },
                new Attribute { Name = "WIS", Value = 12 },
                new Attribute { Name = "CHA", Value = 13 },
            }
        });
        All.Add(new Character() {
            Name = "Sea Horse",
            Ac = 11,
            Hp = 1,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-s",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 1 },
                new Attribute { Name = "DEX", Value = 12 },
                new Attribute { Name = "CON", Value = 8 },
                new Attribute { Name = "INT", Value = 1 },
                new Attribute { Name = "WIS", Value = 10 },
                new Attribute { Name = "CHA", Value = 2 },
            }
        });
        All.Add(new Character() {
            Name = "Shadow",
            Ac = 12,
            Hp = 16,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-s",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 6 },
                new Attribute { Name = "DEX", Value = 14 },
                new Attribute { Name = "CON", Value = 13 },
                new Attribute { Name = "INT", Value = 6 },
                new Attribute { Name = "WIS", Value = 10 },
                new Attribute { Name = "CHA", Value = 8 },
            }
        });
        All.Add(new Character() {
            Name = "Shambling Mound",
            Ac = 15,
            Hp = 136,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-s",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 18 },
                new Attribute { Name = "DEX", Value = 8 },
                new Attribute { Name = "CON", Value = 16 },
                new Attribute { Name = "INT", Value = 5 },
                new Attribute { Name = "WIS", Value = 10 },
                new Attribute { Name = "CHA", Value = 5 },
            }
        });
        All.Add(new Character() {
            Name = "Shield Guardian",
            Ac = 17,
            Hp = 142,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-s",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 18 },
                new Attribute { Name = "DEX", Value = 8 },
                new Attribute { Name = "CON", Value = 18 },
                new Attribute { Name = "INT", Value = 7 },
                new Attribute { Name = "WIS", Value = 10 },
                new Attribute { Name = "CHA", Value = 3 },
            }
        });
        All.Add(new Character() {
            Name = "Shrieker",
            Ac = 5,
            Hp = 13,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-s",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 1 },
                new Attribute { Name = "DEX", Value = 1 },
                new Attribute { Name = "CON", Value = 10 },
                new Attribute { Name = "INT", Value = 1 },
                new Attribute { Name = "WIS", Value = 3 },
                new Attribute { Name = "CHA", Value = 1 },
            }
        });
        All.Add(new Character() {
            Name = "Silver Dragon Wyrmling",
            Ac = 17,
            Hp = 45,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-s",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 19 },
                new Attribute { Name = "DEX", Value = 10 },
                new Attribute { Name = "CON", Value = 17 },
                new Attribute { Name = "INT", Value = 12 },
                new Attribute { Name = "WIS", Value = 11 },
                new Attribute { Name = "CHA", Value = 15 },
            }
        });
        All.Add(new Character() {
            Name = "Skeleton",
            Ac = 13,
            Hp = 13,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-s",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 10 },
                new Attribute { Name = "DEX", Value = 14 },
                new Attribute { Name = "CON", Value = 15 },
                new Attribute { Name = "INT", Value = 6 },
                new Attribute { Name = "WIS", Value = 8 },
                new Attribute { Name = "CHA", Value = 5 },
            }
        });
        All.Add(new Character() {
            Name = "Solar",
            Ac = 21,
            Hp = 243,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-s",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 26 },
                new Attribute { Name = "DEX", Value = 22 },
                new Attribute { Name = "CON", Value = 26 },
                new Attribute { Name = "INT", Value = 25 },
                new Attribute { Name = "WIS", Value = 26 },
                new Attribute { Name = "CHA", Value = 30 },
            }
        });
        All.Add(new Character() {
            Name = "Spectator",
            Ac = 14,
            Hp = 39,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-s",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 8 },
                new Attribute { Name = "DEX", Value = 14 },
                new Attribute { Name = "CON", Value = 14 },
                new Attribute { Name = "INT", Value = 13 },
                new Attribute { Name = "WIS", Value = 14 },
                new Attribute { Name = "CHA", Value = 11 },
            }
        });
        All.Add(new Character() {
            Name = "Specter",
            Ac = 12,
            Hp = 22,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-s",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 1 },
                new Attribute { Name = "DEX", Value = 14 },
                new Attribute { Name = "CON", Value = 11 },
                new Attribute { Name = "INT", Value = 10 },
                new Attribute { Name = "WIS", Value = 10 },
                new Attribute { Name = "CHA", Value = 11 },
            }
        });
        All.Add(new Character() {
            Name = "Spider",
            Ac = 12,
            Hp = 1,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-s",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 2 },
                new Attribute { Name = "DEX", Value = 14 },
                new Attribute { Name = "CON", Value = 8 },
                new Attribute { Name = "INT", Value = 1 },
                new Attribute { Name = "WIS", Value = 10 },
                new Attribute { Name = "CHA", Value = 2 },
            }
        });
        All.Add(new Character() {
            Name = "Spirit Naga",
            Ac = 15,
            Hp = 75,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-s",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 18 },
                new Attribute { Name = "DEX", Value = 17 },
                new Attribute { Name = "CON", Value = 14 },
                new Attribute { Name = "INT", Value = 16 },
                new Attribute { Name = "WIS", Value = 15 },
                new Attribute { Name = "CHA", Value = 16 },
            }
        });
        All.Add(new Character() {
            Name = "Sprite",
            Ac = 15,
            Hp = 2,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-s",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 3 },
                new Attribute { Name = "DEX", Value = 18 },
                new Attribute { Name = "CON", Value = 10 },
                new Attribute { Name = "INT", Value = 14 },
                new Attribute { Name = "WIS", Value = 13 },
                new Attribute { Name = "CHA", Value = 11 },
            }
        });
        All.Add(new Character() {
            Name = "Steam Mephit",
            Ac = 10,
            Hp = 21,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-s",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 5 },
                new Attribute { Name = "DEX", Value = 11 },
                new Attribute { Name = "CON", Value = 10 },
                new Attribute { Name = "INT", Value = 11 },
                new Attribute { Name = "WIS", Value = 10 },
                new Attribute { Name = "CHA", Value = 12 },
            }
        });
        All.Add(new Character() {
            Name = "Stirge",
            Ac = 14,
            Hp = 2,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-s",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 4 },
                new Attribute { Name = "DEX", Value = 16 },
                new Attribute { Name = "CON", Value = 11 },
                new Attribute { Name = "INT", Value = 2 },
                new Attribute { Name = "WIS", Value = 8 },
                new Attribute { Name = "CHA", Value = 6 },
            }
        });
        All.Add(new Character() {
            Name = "Stone Giant",
            Ac = 17,
            Hp = 126,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-s",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 23 },
                new Attribute { Name = "DEX", Value = 15 },
                new Attribute { Name = "CON", Value = 20 },
                new Attribute { Name = "INT", Value = 10 },
                new Attribute { Name = "WIS", Value = 12 },
                new Attribute { Name = "CHA", Value = 9 },
            }
        });
        All.Add(new Character() {
            Name = "Stone Golem",
            Ac = 17,
            Hp = 178,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-s",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 22 },
                new Attribute { Name = "DEX", Value = 9 },
                new Attribute { Name = "CON", Value = 20 },
                new Attribute { Name = "INT", Value = 3 },
                new Attribute { Name = "WIS", Value = 11 },
                new Attribute { Name = "CHA", Value = 1 },
            }
        });
        All.Add(new Character() {
            Name = "Storm Giant",
            Ac = 16,
            Hp = 230,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-s",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 29 },
                new Attribute { Name = "DEX", Value = 14 },
                new Attribute { Name = "CON", Value = 20 },
                new Attribute { Name = "INT", Value = 16 },
                new Attribute { Name = "WIS", Value = 18 },
                new Attribute { Name = "CHA", Value = 18 },
            }
        });
        All.Add(new Character() {
            Name = "Succubus",
            Ac = 15,
            Hp = 66,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-s",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 8 },
                new Attribute { Name = "DEX", Value = 17 },
                new Attribute { Name = "CON", Value = 13 },
                new Attribute { Name = "INT", Value = 15 },
                new Attribute { Name = "WIS", Value = 12 },
                new Attribute { Name = "CHA", Value = 20 },
            }
        });
        All.Add(new Character() {
            Name = "Incubus",
            Ac = 15,
            Hp = 66,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-s",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 8 },
                new Attribute { Name = "DEX", Value = 17 },
                new Attribute { Name = "CON", Value = 13 },
                new Attribute { Name = "INT", Value = 15 },
                new Attribute { Name = "WIS", Value = 12 },
                new Attribute { Name = "CHA", Value = 20 },
            }
        });
        All.Add(new Character() {
            Name = "Bats (Swarm)",
            Ac = 12,
            Hp = 22,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-s",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 5 },
                new Attribute { Name = "DEX", Value = 15 },
                new Attribute { Name = "CON", Value = 10 },
                new Attribute { Name = "INT", Value = 2 },
                new Attribute { Name = "WIS", Value = 12 },
                new Attribute { Name = "CHA", Value = 4 },
            }
        });
        All.Add(new Character() {
            Name = "Insects (Swarm)",
            Ac = 12,
            Hp = 22,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-s",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 3 },
                new Attribute { Name = "DEX", Value = 13 },
                new Attribute { Name = "CON", Value = 10 },
                new Attribute { Name = "INT", Value = 1 },
                new Attribute { Name = "WIS", Value = 7 },
                new Attribute { Name = "CHA", Value = 1 },
            }
        });
        All.Add(new Character() {
            Name = "Poisonous Snakes (Swarm)",
            Ac = 14,
            Hp = 36,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-s",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 8 },
                new Attribute { Name = "DEX", Value = 18 },
                new Attribute { Name = "CON", Value = 11 },
                new Attribute { Name = "INT", Value = 1 },
                new Attribute { Name = "WIS", Value = 10 },
                new Attribute { Name = "CHA", Value = 3 },
            }
        });
        All.Add(new Character() {
            Name = "Quippers (Swarm)",
            Ac = 13,
            Hp = 28,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-s",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 13 },
                new Attribute { Name = "DEX", Value = 16 },
                new Attribute { Name = "CON", Value = 9 },
                new Attribute { Name = "INT", Value = 1 },
                new Attribute { Name = "WIS", Value = 7 },
                new Attribute { Name = "CHA", Value = 2 },
            }
        });
        All.Add(new Character() {
            Name = "Rats (Swarm)",
            Ac = 10,
            Hp = 24,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-s",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 9 },
                new Attribute { Name = "DEX", Value = 11 },
                new Attribute { Name = "CON", Value = 9 },
                new Attribute { Name = "INT", Value = 2 },
                new Attribute { Name = "WIS", Value = 10 },
                new Attribute { Name = "CHA", Value = 3 },
            }
        });
        All.Add(new Character() {
            Name = "Ravens (Swarm)",
            Ac = 12,
            Hp = 24,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-s",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 6 },
                new Attribute { Name = "DEX", Value = 14 },
                new Attribute { Name = "CON", Value = 8 },
                new Attribute { Name = "INT", Value = 3 },
                new Attribute { Name = "WIS", Value = 12 },
                new Attribute { Name = "CHA", Value = 6 },
            }
        });
        #endregion
        #region T
        All.Add(new Character() {
            Name = "Tarrasque",
            Ac = 25,
            Hp = 676,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-t",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 30 },
                new Attribute { Name = "DEX", Value = 11 },
                new Attribute { Name = "CON", Value = 30 },
                new Attribute { Name = "INT", Value = 3 },
                new Attribute { Name = "WIS", Value = 11 },
                new Attribute { Name = "CHA", Value = 11 },
            }
        });
        All.Add(new Character() {
            Name = "Tiger",
            Ac = 12,
            Hp = 37,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-t",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 17 },
                new Attribute { Name = "DEX", Value = 15 },
                new Attribute { Name = "CON", Value = 14 },
                new Attribute { Name = "INT", Value = 3 },
                new Attribute { Name = "WIS", Value = 12 },
                new Attribute { Name = "CHA", Value = 18 },
            }
        });
        All.Add(new Character() {
            Name = "Treant",
            Ac = 16,
            Hp = 138,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-t",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 23 },
                new Attribute { Name = "DEX", Value = 8 },
                new Attribute { Name = "CON", Value = 21 },
                new Attribute { Name = "INT", Value = 12 },
                new Attribute { Name = "WIS", Value = 16 },
                new Attribute { Name = "CHA", Value = 12 },
            }
        });
        All.Add(new Character() {
            Name = "Triceratops",
            Ac = 13,
            Hp = 95,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-t",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 22 },
                new Attribute { Name = "DEX", Value = 9 },
                new Attribute { Name = "CON", Value = 17 },
                new Attribute { Name = "INT", Value = 2 },
                new Attribute { Name = "WIS", Value = 11 },
                new Attribute { Name = "CHA", Value = 5 },
            }
        });
        All.Add(new Character() {
            Name = "Troll",
            Ac = 15,
            Hp = 84,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-t",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 18 },
                new Attribute { Name = "DEX", Value = 13 },
                new Attribute { Name = "CON", Value = 20 },
                new Attribute { Name = "INT", Value = 7 },
                new Attribute { Name = "WIS", Value = 9 },
                new Attribute { Name = "CHA", Value = 7 },
            }
        });
        All.Add(new Character() {
            Name = "Twig Blight",
            Ac = 13,
            Hp = 4,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-t",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 6 },
                new Attribute { Name = "DEX", Value = 13 },
                new Attribute { Name = "CON", Value = 12 },
                new Attribute { Name = "INT", Value = 4 },
                new Attribute { Name = "WIS", Value = 8 },
                new Attribute { Name = "CHA", Value = 3 },
            }
        });
        All.Add(new Character() {
            Name = "Tyrannosaurus Rex",
            Ac = 13,
            Hp = 136,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-t",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 25 },
                new Attribute { Name = "DEX", Value = 10 },
                new Attribute { Name = "CON", Value = 19 },
                new Attribute { Name = "INT", Value = 2 },
                new Attribute { Name = "WIS", Value = 12 },
                new Attribute { Name = "CHA", Value = 9 },
            }
        });
        #endregion
        #region U
        All.Add(new Character() {
            Name = "Unicorn",
            Ac = 12,
            Hp = 67,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-u",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 18 },
                new Attribute { Name = "DEX", Value = 14 },
                new Attribute { Name = "CON", Value = 15 },
                new Attribute { Name = "INT", Value = 11 },
                new Attribute { Name = "WIS", Value = 17 },
                new Attribute { Name = "CHA", Value = 16 },
            }
        });
        #endregion
        #region V
        All.Add(new Character() {
            Name = "Vampire",
            Ac = 16,
            Hp = 144,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-v",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 18 },
                new Attribute { Name = "DEX", Value = 18 },
                new Attribute { Name = "CON", Value = 18 },
                new Attribute { Name = "INT", Value = 17 },
                new Attribute { Name = "WIS", Value = 15 },
                new Attribute { Name = "CHA", Value = 18 },
            }
        });
        All.Add(new Character() {
            Name = "Vampire Spawn",
            Ac = 15,
            Hp = 82,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-v",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 16 },
                new Attribute { Name = "DEX", Value = 16 },
                new Attribute { Name = "CON", Value = 16 },
                new Attribute { Name = "INT", Value = 11 },
                new Attribute { Name = "WIS", Value = 10 },
                new Attribute { Name = "CHA", Value = 12 },
            }
        });
        All.Add(new Character() {
            Name = "Violet Fungus",
            Ac = 5,
            Hp = 18,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-v",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 3 },
                new Attribute { Name = "DEX", Value = 1 },
                new Attribute { Name = "CON", Value = 10 },
                new Attribute { Name = "INT", Value = 1 },
                new Attribute { Name = "WIS", Value = 3 },
                new Attribute { Name = "CHA", Value = 1 },
            }
        });
        All.Add(new Character() {
            Name = "Vrock",
            Ac = 15,
            Hp = 104,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-v",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 17 },
                new Attribute { Name = "DEX", Value = 15 },
                new Attribute { Name = "CON", Value = 18 },
                new Attribute { Name = "INT", Value = 8 },
                new Attribute { Name = "WIS", Value = 13 },
                new Attribute { Name = "CHA", Value = 8 },
            }
        });
        All.Add(new Character() {
            Name = "Vulture",
            Ac = 10,
            Hp = 5,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-v",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 7 },
                new Attribute { Name = "DEX", Value = 10 },
                new Attribute { Name = "CON", Value = 13 },
                new Attribute { Name = "INT", Value = 2 },
                new Attribute { Name = "WIS", Value = 12 },
                new Attribute { Name = "CHA", Value = 4 },
            }
        });
        #endregion
        #region W
        All.Add(new Character() {
            Name = "Warhorse",
            Ac = 11,
            Hp = 19,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-w",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 18 },
                new Attribute { Name = "DEX", Value = 12 },
                new Attribute { Name = "CON", Value = 13 },
                new Attribute { Name = "INT", Value = 2 },
                new Attribute { Name = "WIS", Value = 12 },
                new Attribute { Name = "CHA", Value = 7 },
            }
        });
        All.Add(new Character() {
            Name = "Warhorse Skeleton",
            Ac = 13,
            Hp = 22,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-w",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 18 },
                new Attribute { Name = "DEX", Value = 12 },
                new Attribute { Name = "CON", Value = 15 },
                new Attribute { Name = "INT", Value = 2 },
                new Attribute { Name = "WIS", Value = 8 },
                new Attribute { Name = "CHA", Value = 5 },
            }
        });
        All.Add(new Character() {
            Name = "Water Elemental",
            Ac = 14,
            Hp = 114,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-w",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 18 },
                new Attribute { Name = "DEX", Value = 14 },
                new Attribute { Name = "CON", Value = 18 },
                new Attribute { Name = "INT", Value = 5 },
                new Attribute { Name = "WIS", Value = 10 },
                new Attribute { Name = "CHA", Value = 8 },
            }
        });
        All.Add(new Character() {
            Name = "Weasel",
            Ac = 13,
            Hp = 1,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-w",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 3 },
                new Attribute { Name = "DEX", Value = 16 },
                new Attribute { Name = "CON", Value = 8 },
                new Attribute { Name = "INT", Value = 2 },
                new Attribute { Name = "WIS", Value = 12 },
                new Attribute { Name = "CHA", Value = 3 },
            }
        });
        All.Add(new Character() {
            Name = "Werebear",
            Ac = 10,
            Hp = 135,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-w",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 19 },
                new Attribute { Name = "DEX", Value = 10 },
                new Attribute { Name = "CON", Value = 17 },
                new Attribute { Name = "INT", Value = 11 },
                new Attribute { Name = "WIS", Value = 12 },
                new Attribute { Name = "CHA", Value = 12 },
            }
        });
        All.Add(new Character() {
            Name = "Wereboar",
            Ac = 10,
            Hp = 78,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-w",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 17 },
                new Attribute { Name = "DEX", Value = 10 },
                new Attribute { Name = "CON", Value = 15 },
                new Attribute { Name = "INT", Value = 10 },
                new Attribute { Name = "WIS", Value = 11 },
                new Attribute { Name = "CHA", Value = 8 },
            }
        });
        All.Add(new Character() {
            Name = "Wererat",
            Ac = 12,
            Hp = 33,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-w",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 10 },
                new Attribute { Name = "DEX", Value = 15 },
                new Attribute { Name = "CON", Value = 12 },
                new Attribute { Name = "INT", Value = 11 },
                new Attribute { Name = "WIS", Value = 10 },
                new Attribute { Name = "CHA", Value = 8 },
            }
        });
        All.Add(new Character() {
            Name = "Weretiger",
            Ac = 12,
            Hp = 120,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-w",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 17 },
                new Attribute { Name = "DEX", Value = 15 },
                new Attribute { Name = "CON", Value = 16 },
                new Attribute { Name = "INT", Value = 10 },
                new Attribute { Name = "WIS", Value = 13 },
                new Attribute { Name = "CHA", Value = 11 },
            }
        });
        All.Add(new Character() {
            Name = "Werewolf",
            Ac = 11,
            Hp = 58,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-w",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 15 },
                new Attribute { Name = "DEX", Value = 13 },
                new Attribute { Name = "CON", Value = 14 },
                new Attribute { Name = "INT", Value = 10 },
                new Attribute { Name = "WIS", Value = 11 },
                new Attribute { Name = "CHA", Value = 10 },
            }
        });
        All.Add(new Character() {
            Name = "White Dragon Wyrmling",
            Ac = 16,
            Hp = 32,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-w",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 14 },
                new Attribute { Name = "DEX", Value = 10 },
                new Attribute { Name = "CON", Value = 14 },
                new Attribute { Name = "INT", Value = 5 },
                new Attribute { Name = "WIS", Value = 10 },
                new Attribute { Name = "CHA", Value = 11 },
            }
        });
        All.Add(new Character() {
            Name = "Wight",
            Ac = 14,
            Hp = 45,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-w",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 15 },
                new Attribute { Name = "DEX", Value = 14 },
                new Attribute { Name = "CON", Value = 16 },
                new Attribute { Name = "INT", Value = 10 },
                new Attribute { Name = "WIS", Value = 13 },
                new Attribute { Name = "CHA", Value = 15 },
            }
        });
        All.Add(new Character() {
            Name = "Will-o'-wisp",
            Ac = 19,
            Hp = 22,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-w",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 1 },
                new Attribute { Name = "DEX", Value = 28 },
                new Attribute { Name = "CON", Value = 10 },
                new Attribute { Name = "INT", Value = 13 },
                new Attribute { Name = "WIS", Value = 14 },
                new Attribute { Name = "CHA", Value = 11 },
            }
        });
        All.Add(new Character() {
            Name = "Winter Wolf",
            Ac = 13,
            Hp = 75,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-w",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 18 },
                new Attribute { Name = "DEX", Value = 13 },
                new Attribute { Name = "CON", Value = 14 },
                new Attribute { Name = "INT", Value = 7 },
                new Attribute { Name = "WIS", Value = 12 },
                new Attribute { Name = "CHA", Value = 8 },
            }
        });
        All.Add(new Character() {
            Name = "Wolf",
            Ac = 13,
            Hp = 11,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-w",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 12 },
                new Attribute { Name = "DEX", Value = 15 },
                new Attribute { Name = "CON", Value = 12 },
                new Attribute { Name = "INT", Value = 3 },
                new Attribute { Name = "WIS", Value = 12 },
                new Attribute { Name = "CHA", Value = 6 },
            }
        });
        All.Add(new Character() {
            Name = "Worg",
            Ac = 13,
            Hp = 26,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-w",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 16 },
                new Attribute { Name = "DEX", Value = 13 },
                new Attribute { Name = "CON", Value = 13 },
                new Attribute { Name = "INT", Value = 7 },
                new Attribute { Name = "WIS", Value = 11 },
                new Attribute { Name = "CHA", Value = 8 },
            }
        });
        All.Add(new Character() {
            Name = "Wraith",
            Ac = 13,
            Hp = 67,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-w",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 6 },
                new Attribute { Name = "DEX", Value = 16 },
                new Attribute { Name = "CON", Value = 16 },
                new Attribute { Name = "INT", Value = 12 },
                new Attribute { Name = "WIS", Value = 14 },
                new Attribute { Name = "CHA", Value = 15 },
            }
        });
        All.Add(new Character() {
            Name = "Wyvern",
            Ac = 13,
            Hp = 110,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-w",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 19 },
                new Attribute { Name = "DEX", Value = 10 },
                new Attribute { Name = "CON", Value = 16 },
                new Attribute { Name = "INT", Value = 5 },
                new Attribute { Name = "WIS", Value = 12 },
                new Attribute { Name = "CHA", Value = 6 },
            }
        });
        #endregion
        #region X
        All.Add(new Character() {
            Name = "Xorn",
            Ac = 19,
            Hp = 73,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-x",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 17 },
                new Attribute { Name = "DEX", Value = 10 },
                new Attribute { Name = "CON", Value = 22 },
                new Attribute { Name = "INT", Value = 11 },
                new Attribute { Name = "WIS", Value = 10 },
                new Attribute { Name = "CHA", Value = 11 },
            }
        });
        #endregion
        #region Y
        All.Add(new Character() {
            Name = "Young Black Dragon",
            Ac = 18,
            Hp = 127,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-y",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 19 },
                new Attribute { Name = "DEX", Value = 14 },
                new Attribute { Name = "CON", Value = 17 },
                new Attribute { Name = "INT", Value = 12 },
                new Attribute { Name = "WIS", Value = 11 },
                new Attribute { Name = "CHA", Value = 15 },
            }
        });
        All.Add(new Character() {
            Name = "Young Blue Dragon",
            Ac = 18,
            Hp = 152,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-y",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 21 },
                new Attribute { Name = "DEX", Value = 10 },
                new Attribute { Name = "CON", Value = 19 },
                new Attribute { Name = "INT", Value = 14 },
                new Attribute { Name = "WIS", Value = 13 },
                new Attribute { Name = "CHA", Value = 17 },
            }
        });
        All.Add(new Character() {
            Name = "Young Brass Dragon",
            Ac = 17,
            Hp = 110,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-y",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 19 },
                new Attribute { Name = "DEX", Value = 10 },
                new Attribute { Name = "CON", Value = 17 },
                new Attribute { Name = "INT", Value = 12 },
                new Attribute { Name = "WIS", Value = 11 },
                new Attribute { Name = "CHA", Value = 15 },
            }
        });
        All.Add(new Character() {
            Name = "Young Bronze Dragon",
            Ac = 18,
            Hp = 142,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-y",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 21 },
                new Attribute { Name = "DEX", Value = 10 },
                new Attribute { Name = "CON", Value = 19 },
                new Attribute { Name = "INT", Value = 14 },
                new Attribute { Name = "WIS", Value = 13 },
                new Attribute { Name = "CHA", Value = 17 },
            }
        });
        All.Add(new Character() {
            Name = "Young Copper Dragon",
            Ac = 18,
            Hp = 119,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-y",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 19 },
                new Attribute { Name = "DEX", Value = 12 },
                new Attribute { Name = "CON", Value = 17 },
                new Attribute { Name = "INT", Value = 16 },
                new Attribute { Name = "WIS", Value = 13 },
                new Attribute { Name = "CHA", Value = 15 },
            }
        });
        All.Add(new Character() {
            Name = "Young Gold Dragon",
            Ac = 18,
            Hp = 178,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-y",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 23 },
                new Attribute { Name = "DEX", Value = 14 },
                new Attribute { Name = "CON", Value = 21 },
                new Attribute { Name = "INT", Value = 16 },
                new Attribute { Name = "WIS", Value = 13 },
                new Attribute { Name = "CHA", Value = 20 },
            }
        });
        All.Add(new Character() {
            Name = "Young Green Dragon",
            Ac = 18,
            Hp = 136,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-y",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 19 },
                new Attribute { Name = "DEX", Value = 12 },
                new Attribute { Name = "CON", Value = 17 },
                new Attribute { Name = "INT", Value = 16 },
                new Attribute { Name = "WIS", Value = 13 },
                new Attribute { Name = "CHA", Value = 15 },
            }
        });
        All.Add(new Character() {
            Name = "Young Red Dragon",
            Ac = 18,
            Hp = 178,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-y",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 23 },
                new Attribute { Name = "DEX", Value = 10 },
                new Attribute { Name = "CON", Value = 21 },
                new Attribute { Name = "INT", Value = 14 },
                new Attribute { Name = "WIS", Value = 11 },
                new Attribute { Name = "CHA", Value = 19 },
            }
        });
        All.Add(new Character() {
            Name = "Young Silver Dragon",
            Ac = 18,
            Hp = 168,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-y",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 23 },
                new Attribute { Name = "DEX", Value = 10 },
                new Attribute { Name = "CON", Value = 21 },
                new Attribute { Name = "INT", Value = 14 },
                new Attribute { Name = "WIS", Value = 11 },
                new Attribute { Name = "CHA", Value = 19 },
            }
        });
        All.Add(new Character() {
            Name = "Young White Dragon",
            Ac = 17,
            Hp = 133,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-y",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 18 },
                new Attribute { Name = "DEX", Value = 10 },
                new Attribute { Name = "CON", Value = 18 },
                new Attribute { Name = "INT", Value = 6 },
                new Attribute { Name = "WIS", Value = 11 },
                new Attribute { Name = "CHA", Value = 12 },
            }
        });
        #endregion
        #region Z
        All.Add(new Character() {
            Name = "Zombie",
            Ac = 8,
            Hp = 22,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/basic-rules/monster-stat-blocks-z",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 13 },
                new Attribute { Name = "DEX", Value = 6 },
                new Attribute { Name = "CON", Value = 16 },
                new Attribute { Name = "INT", Value = 3 },
                new Attribute { Name = "WIS", Value = 6 },
                new Attribute { Name = "CHA", Value = 5 },
            }
        });
        #endregion
    }

}

}