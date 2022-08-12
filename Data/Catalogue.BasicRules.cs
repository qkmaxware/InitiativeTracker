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
    }

}

}