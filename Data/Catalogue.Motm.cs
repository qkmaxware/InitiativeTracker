using System.Collections.Generic;

namespace InitiativeTracker.Data {

public static partial class MonsterCatalogue {
    private static void AddMonstersOfTheMultiverse() {
        #region A
        All.Add(new Character() {
            Name = "Black Abishais",
            Hp = 58,
            Ac = 15,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary#BlackAbishai",
                // IconUrl = "https://www.dndbeyond.com/avatars/thumbnails/25746/179/400/416/637880557202300665.png"
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 14 },
                new Attribute { Name = "DEX", Value = 17 },
                new Attribute { Name = "CON", Value = 14 },
                new Attribute { Name = "INT", Value = 13 },
                new Attribute { Name = "WIS", Value = 16 },
                new Attribute { Name = "CHA", Value = 11 },
            }
        });
        All.Add(new Character() {
            Name = "Blue Abishais",
            Hp = 202,
            Ac = 19,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary#BlueAbishai",
                // IconUrl = "https://www.dndbeyond.com/avatars/thumbnails/25746/185/400/529/637880557211961588.png"
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 15 },
                new Attribute { Name = "DEX", Value = 14 },
                new Attribute { Name = "CON", Value = 17 },
                new Attribute { Name = "INT", Value = 22 },
                new Attribute { Name = "WIS", Value = 23 },
                new Attribute { Name = "CHA", Value = 18 },
            }
        });
        All.Add(new Character() {
            Name = "Green Abishais",
            Hp = 195,
            Ac = 18,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary#GreenAbishai",
                // IconUrl = "https://www.dndbeyond.com/avatars/thumbnails/25746/439/350/427/637880557669463607.png"
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 12 },
                new Attribute { Name = "DEX", Value = 17 },
                new Attribute { Name = "CON", Value = 16 },
                new Attribute { Name = "INT", Value = 17 },
                new Attribute { Name = "WIS", Value = 12 },
                new Attribute { Name = "CHA", Value = 19 },
            }
        });
        All.Add(new Character() {
            Name = "Red Abishais",
            Hp = 289 ,
            Ac = 22 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary#RedAbishai",
                // IconUrl = "https://www.dndbeyond.com/avatars/thumbnails/25746/604/400/557/637880557931667788.png"
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 23 },
                new Attribute { Name = "DEX", Value = 16 },
                new Attribute { Name = "CON", Value = 19 },
                new Attribute { Name = "INT", Value = 14 },
                new Attribute { Name = "WIS", Value = 15 },
                new Attribute { Name = "CHA", Value = 19 },
            }
        });
        All.Add(new Character() {
            Name = "White Abishais",
            Hp = 68 ,
            Ac = 15 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary#WhiteAbishai",
                // IconUrl = "https://www.dndbeyond.com/avatars/thumbnails/25746/753/400/365/637880558154186325.png"
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 16 },
                new Attribute { Name = "DEX", Value = 11 },
                new Attribute { Name = "CON", Value = 18 },
                new Attribute { Name = "INT", Value = 11 },
                new Attribute { Name = "WIS", Value = 12 },
                new Attribute { Name = "CHA", Value = 13 },
            }
        });
        All.Add(new Character() {
            Name = "Alhoon",
            Hp = 150 ,
            Ac = 15 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary#Alhoon",
                // IconUrl = "https://www.dndbeyond.com/avatars/thumbnails/25746/112/400/656/637880557092470626.png"
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 11 },
                new Attribute { Name = "DEX", Value = 12 },
                new Attribute { Name = "CON", Value = 16 },
                new Attribute { Name = "INT", Value = 19 },
                new Attribute { Name = "WIS", Value = 17 },
                new Attribute { Name = "CHA", Value = 17 },
            }
        });
        All.Add(new Character() {
            Name = "Alkilith",
            Hp = 168 ,
            Ac = 17 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary#Alkilith",
                // IconUrl = "https://www.dndbeyond.com/avatars/thumbnails/25746/115/355/502/637880557097470961.png"
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 12 },
                new Attribute { Name = "DEX", Value = 19 },
                new Attribute { Name = "CON", Value = 22 },
                new Attribute { Name = "INT", Value = 6 },
                new Attribute { Name = "WIS", Value = 11 },
                new Attribute { Name = "CHA", Value = 7 },
            }
        });
        All.Add(new Character() {
            Name = "Allip",
            Hp = 40 ,
            Ac = 13 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary#Allip",
                // IconUrl = "https://www.dndbeyond.com/avatars/thumbnails/25746/118/345/512/637880557103481432.png"
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 6 },
                new Attribute { Name = "DEX", Value = 17 },
                new Attribute { Name = "CON", Value = 10 },
                new Attribute { Name = "INT", Value = 17 },
                new Attribute { Name = "WIS", Value = 15 },
                new Attribute { Name = "CHA", Value = 16 },
            }
        });
        All.Add(new Character() {
            Name = "Amnizu",
            Ac = 21 ,
            Hp = 202 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary#Amnizu",
                // IconUrl = "https://www.dndbeyond.com/avatars/thumbnails/25746/124/350/409/637880557113382534.png"
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 11 },
                new Attribute { Name = "DEX", Value = 13 },
                new Attribute { Name = "CON", Value = 16 },
                new Attribute { Name = "INT", Value = 20 },
                new Attribute { Name = "WIS", Value = 12 },
                new Attribute { Name = "CHA", Value = 18 },
            }
        });
        All.Add(new Character() {
            Name = "Annis Hag",
            Ac = 17 ,
            Hp = 90 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary#AnnisHag",
                // IconUrl = "https://www.dndbeyond.com/avatars/thumbnails/25746/131/330/500/637880557123273417.png"
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 21 },
                new Attribute { Name = "DEX", Value = 12 },
                new Attribute { Name = "CON", Value = 14 },
                new Attribute { Name = "INT", Value = 13 },
                new Attribute { Name = "WIS", Value = 14 },
                new Attribute { Name = "CHA", Value = 15 },
            }
        });
        All.Add(new Character() {
            Name = "Archdruid",
            Ac = 14 ,
            Hp = 154 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary#Archdruid",
                // IconUrl = "https://www.dndbeyond.com/avatars/thumbnails/25746/137/400/362/637880557132144402.png"
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 14 },
                new Attribute { Name = "DEX", Value = 14 },
                new Attribute { Name = "CON", Value = 12 },
                new Attribute { Name = "INT", Value = 12 },
                new Attribute { Name = "WIS", Value = 20 },
                new Attribute { Name = "CHA", Value = 11 },
            }
        });
        All.Add(new Character() {
            Name = "Archer",
            Ac = 16 ,
            Hp = 75 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary#Archer",
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 11 },
                new Attribute { Name = "DEX", Value = 18 },
                new Attribute { Name = "CON", Value = 16 },
                new Attribute { Name = "INT", Value = 11 },
                new Attribute { Name = "WIS", Value = 13 },
                new Attribute { Name = "CHA", Value = 10 },
            }
        });
        All.Add(new Character() {
            Name = "Armanite",
            Ac = 16 ,
            Hp = 94 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary#Armanite",
                // IconUrl = "https://www.dndbeyond.com/avatars/thumbnails/25746/143/350/404/637880557141535078.png"
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 21 },
                new Attribute { Name = "DEX", Value = 18 },
                new Attribute { Name = "CON", Value = 21 },
                new Attribute { Name = "INT", Value = 8 },
                new Attribute { Name = "WIS", Value = 12 },
                new Attribute { Name = "CHA", Value = 13 },
            }
        });
        All.Add(new Character() {
            Name = "Astral Dreadnought",
            Ac = 20 ,
            Hp = 297 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary#AstralDreadnought",
                // IconUrl = "https://www.dndbeyond.com/avatars/thumbnails/25746/146/350/432/637880557148035617.png"
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 28 },
                new Attribute { Name = "DEX", Value = 7 },
                new Attribute { Name = "CON", Value = 25 },
                new Attribute { Name = "INT", Value = 5 },
                new Attribute { Name = "WIS", Value = 14 },
                new Attribute { Name = "CHA", Value = 18 },
            }
        });
        #endregion
        #region B
        All.Add(new Character() {
            Name = "Babau",
            Ac = 16 ,
            Hp = 82 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary#Babau",
                // IconUrl = "https://www.dndbeyond.com/avatars/thumbnails/25746/152/400/583/637880557157126444.png"
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 19 },
                new Attribute { Name = "DEX", Value = 16 },
                new Attribute { Name = "CON", Value = 16 },
                new Attribute { Name = "INT", Value = 11 },
                new Attribute { Name = "WIS", Value = 12 },
                new Attribute { Name = "CHA", Value = 13 },
            }
        });
        All.Add(new Character() {
            Name = "Bael",
            Ac = 18 ,
            Hp = 189 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary#Bael",
                // IconUrl = "https://media.dndbeyond.com/compendium-images/motm/krLB7gHQhdpHbQ1u/02-003.bael.png"
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 24 },
                new Attribute { Name = "DEX", Value = 17 },
                new Attribute { Name = "CON", Value = 20 },
                new Attribute { Name = "INT", Value = 21 },
                new Attribute { Name = "WIS", Value = 24 },
                new Attribute { Name = "CHA", Value = 14 },
            }
        });
        All.Add(new Character() {
            Name = "Balhannoth",
            Ac = 17 ,
            Hp = 114 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary#Balhannoth",
                // IconUrl = "https://www.dndbeyond.com/avatars/thumbnails/25746/158/320/467/637880557167287374.png"
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 17 },
                new Attribute { Name = "DEX", Value = 8 },
                new Attribute { Name = "CON", Value = 18 },
                new Attribute { Name = "INT", Value = 6 },
                new Attribute { Name = "WIS", Value = 15 },
                new Attribute { Name = "CHA", Value = 8 },
            }
        });
        All.Add(new Character() {
            Name = "Banderhobb",
            Ac = 15 ,
            Hp = 84 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary#Banderhobb",
                // IconUrl = "https://www.dndbeyond.com/avatars/thumbnails/25746/161/330/486/637880557171917880.png"
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 20 },
                new Attribute { Name = "DEX", Value = 12 },
                new Attribute { Name = "CON", Value = 20 },
                new Attribute { Name = "INT", Value = 11 },
                new Attribute { Name = "WIS", Value = 14 },
                new Attribute { Name = "CHA", Value = 8 },
            }
        });
        All.Add(new Character() {
            Name = "Baphomet",
            Ac = 22 ,
            Hp = 319 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary#Baphomet",
                // IconUrl = "https://www.dndbeyond.com/avatars/thumbnails/25746/164/370/516/637880557177608469.png"
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 30 },
                new Attribute { Name = "DEX", Value = 14 },
                new Attribute { Name = "CON", Value = 26 },
                new Attribute { Name = "INT", Value = 18 },
                new Attribute { Name = "WIS", Value = 24 },
                new Attribute { Name = "CHA", Value = 16},
            }
        });
        All.Add(new Character() {
            Name = "Bard",
            Ac = 15 ,
            Hp = 44 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary#Bard",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 11 },
                new Attribute { Name = "DEX", Value = 14 },
                new Attribute { Name = "CON", Value = 12 },
                new Attribute { Name = "INT", Value = 10 },
                new Attribute { Name = "WIS", Value = 13 },
                new Attribute { Name = "CHA", Value = 14},
            }
        });
        All.Add(new Character() {
            Name = "Barghest",
            Ac = 17 ,
            Hp = 60 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary#Barghest",
                // IconUrl = "https://media.dndbeyond.com/compendium-images/motm/krLB7gHQhdpHbQ1u/02-005.barghest.png"
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 19 },
                new Attribute { Name = "DEX", Value = 15 },
                new Attribute { Name = "CON", Value = 14 },
                new Attribute { Name = "INT", Value = 13 },
                new Attribute { Name = "WIS", Value = 12 },
                new Attribute { Name = "CHA", Value = 14},
            }
        });
        All.Add(new Character() {
            Name = "Berbalang",
            Ac = 14 ,
            Hp = 49 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary#Berbalang",
                // IconUrl = "https://www.dndbeyond.com/avatars/thumbnails/25746/173/350/431/637880557193799735.png"
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 9 },
                new Attribute { Name = "DEX", Value = 16 },
                new Attribute { Name = "CON", Value = 9 },
                new Attribute { Name = "INT", Value = 17 },
                new Attribute { Name = "WIS", Value = 11 },
                new Attribute { Name = "CHA", Value = 10},
            }
        });
        All.Add(new Character() {
            Name = "Bheur Hag",
            Ac = 17 ,
            Hp = 91 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary#BheurHag",
                // IconUrl = "https://www.dndbeyond.com/avatars/thumbnails/25746/176/350/488/637880557197940226.png"
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 13 },
                new Attribute { Name = "DEX", Value = 16 },
                new Attribute { Name = "CON", Value = 14 },
                new Attribute { Name = "INT", Value = 12 },
                new Attribute { Name = "WIS", Value = 13 },
                new Attribute { Name = "CHA", Value = 16},
            }
        });
        All.Add(new Character() {
            Name = "Blackguard",
            Ac = 18 ,
            Hp = 119 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary#Blackguard",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 18 },
                new Attribute { Name = "DEX", Value = 11 },
                new Attribute { Name = "CON", Value = 18 },
                new Attribute { Name = "INT", Value = 11 },
                new Attribute { Name = "WIS", Value = 14 },
                new Attribute { Name = "CHA", Value = 15},
            }
        });
        All.Add(new Character() {
            Name = "Boggle",
            Ac = 14 ,
            Hp = 18 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary#Boggle",
                // IconUrl = "https://www.dndbeyond.com/avatars/thumbnails/69/54/380/291/636461831203734580.png"
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 18 },
                new Attribute { Name = "DEX", Value = 11 },
                new Attribute { Name = "CON", Value = 18 },
                new Attribute { Name = "INT", Value = 11 },
                new Attribute { Name = "WIS", Value = 14 },
                new Attribute { Name = "CHA", Value = 15},
            }
        });
        All.Add(new Character() {
            Name = "Boneclaw",
            Ac = 16 ,
            Hp = 150 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary#Boneclaw",
                // IconUrl = "https://www.dndbeyond.com/avatars/thumbnails/25746/191/375/518/637880557223212626.png"
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 19 },
                new Attribute { Name = "DEX", Value = 16 },
                new Attribute { Name = "CON", Value = 15 },
                new Attribute { Name = "INT", Value = 13 },
                new Attribute { Name = "WIS", Value = 15 },
                new Attribute { Name = "CHA", Value = 9},
            }
        });
        All.Add(new Character() {
            Name = "Bulezau",
            Ac = 14 ,
            Hp = 52 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary#Bulezau",
                // IconUrl = "https://www.dndbeyond.com/avatars/thumbnails/25746/194/285/585/637880557228163135.png"
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 15 },
                new Attribute { Name = "DEX", Value = 14 },
                new Attribute { Name = "CON", Value = 17 },
                new Attribute { Name = "INT", Value = 8 },
                new Attribute { Name = "WIS", Value = 9 },
                new Attribute { Name = "CHA", Value = 6},
            }
        });
        #endregion
        #region C
        All.Add(new Character() {
            Name = "Cadaver Collector",
            Ac = 17 ,
            Hp = 189 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary#CadaverCollector",
                // IconUrl = "https://www.dndbeyond.com/avatars/thumbnails/25746/198/340/398/637880557234533641.png"
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 21 },
                new Attribute { Name = "DEX", Value = 14 },
                new Attribute { Name = "CON", Value = 20 },
                new Attribute { Name = "INT", Value = 5 },
                new Attribute { Name = "WIS", Value = 11 },
                new Attribute { Name = "CHA", Value = 8},
            }
        });
        All.Add(new Character() {
            Name = "Canoloth",
            Ac = 16 ,
            Hp = 120 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary#Canoloth",
                // IconUrl = "https://www.dndbeyond.com/avatars/thumbnails/25746/201/360/341/637880557239744112.png"
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 18 },
                new Attribute { Name = "DEX", Value = 10 },
                new Attribute { Name = "CON", Value = 17 },
                new Attribute { Name = "INT", Value = 5 },
                new Attribute { Name = "WIS", Value = 17 },
                new Attribute { Name = "CHA", Value = 12 },
            }
        });
        All.Add(new Character() {
            Name = "Catoblepas",
            Ac = 14 ,
            Hp = 84 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary#Catoblepas",
                // IconUrl = "https://www.dndbeyond.com/avatars/thumbnails/25746/204/360/201/637880557248534900.png"
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 19 },
                new Attribute { Name = "DEX", Value = 12 },
                new Attribute { Name = "CON", Value = 21 },
                new Attribute { Name = "INT", Value = 3 },
                new Attribute { Name = "WIS", Value = 14 },
                new Attribute { Name = "CHA", Value = 8 },
            }
        });
        All.Add(new Character() {
            Name = "Aurochs Cattle",
            Ac = 11 ,
            Hp = 38 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary#Aurochs",
                // IconUrl = "https://www.dndbeyond.com/avatars/thumbnails/25746/149/400/284/637880557152376173.png"
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 20 },
                new Attribute { Name = "DEX", Value = 10 },
                new Attribute { Name = "CON", Value = 19 },
                new Attribute { Name = "INT", Value = 2 },
                new Attribute { Name = "WIS", Value = 12 },
                new Attribute { Name = "CHA", Value = 5 },
            }
        });
        All.Add(new Character() {
            Name = "Deep Rothé Cattle",
            Ac = 10 ,
            Hp = 13 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary#DeepRothe",
                // IconUrl = "https://www.dndbeyond.com/avatars/thumbnails/25746/257/400/335/637880557334172410.png"
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 18 },
                new Attribute { Name = "DEX", Value = 10 },
                new Attribute { Name = "CON", Value = 14 },
                new Attribute { Name = "INT", Value = 2 },
                new Attribute { Name = "WIS", Value = 10 },
                new Attribute { Name = "CHA", Value = 4 },
            }
        });
        All.Add(new Character() {
            Name = "Ox",
            Ac = 10 ,
            Hp = 15 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary#Ox",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 18 },
                new Attribute { Name = "DEX", Value = 10 },
                new Attribute { Name = "CON", Value = 14 },
                new Attribute { Name = "INT", Value = 2 },
                new Attribute { Name = "WIS", Value = 10 },
                new Attribute { Name = "CHA", Value = 4 },
            }
        });
        All.Add(new Character() {
            Name = "Stench Kow",
            Ac = 10 ,
            Hp = 15 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary#StenchKow",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 18 },
                new Attribute { Name = "DEX", Value = 10 },
                new Attribute { Name = "CON", Value = 14 },
                new Attribute { Name = "INT", Value = 2 },
                new Attribute { Name = "WIS", Value = 10 },
                new Attribute { Name = "CHA", Value = 4 },
            }
        });
        All.Add(new Character() {
            Name = "Cave Fisher",
            Ac = 16 ,
            Hp = 58 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary#CaveFisher",
                // IconUrl = "https://www.dndbeyond.com/avatars/thumbnails/25746/207/400/443/637880557253855284.png"
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 16 },
                new Attribute { Name = "DEX", Value = 13 },
                new Attribute { Name = "CON", Value = 14 },
                new Attribute { Name = "INT", Value = 3 },
                new Attribute { Name = "WIS", Value = 10 },
                new Attribute { Name = "CHA", Value = 3 },
            }
        });
        All.Add(new Character() {
            Name = "Champion",
            Ac = 18 ,
            Hp = 143 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary#Champion",
                // IconUrl = "https://www.dndbeyond.com/avatars/thumbnails/25746/210/200/434/637880557258835814.png"
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 20 },
                new Attribute { Name = "DEX", Value = 15 },
                new Attribute { Name = "CON", Value = 14 },
                new Attribute { Name = "INT", Value = 10 },
                new Attribute { Name = "WIS", Value = 14 },
                new Attribute { Name = "CHA", Value = 12 },
            }
        });
        All.Add(new Character() {
            Name = "Choker",
            Ac = 16 ,
            Hp = 13 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary#Choker",
                // IconUrl = "https://www.dndbeyond.com/avatars/thumbnails/25746/216/310/325/637880557268936771.png"
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 16 },
                new Attribute { Name = "DEX", Value = 14 },
                new Attribute { Name = "CON", Value = 13 },
                new Attribute { Name = "INT", Value = 4 },
                new Attribute { Name = "WIS", Value = 12 },
                new Attribute { Name = "CHA", Value = 7 },
            }
        });
        All.Add(new Character() {
            Name = "Choldrith",
            Ac = 15 ,
            Hp = 66 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary#Choldrith",
                // IconUrl = "https://www.dndbeyond.com/avatars/thumbnails/25746/216/310/325/637880557268936771.png"
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 12 },
                new Attribute { Name = "DEX", Value = 16 },
                new Attribute { Name = "CON", Value = 12 },
                new Attribute { Name = "INT", Value = 11 },
                new Attribute { Name = "WIS", Value = 14 },
                new Attribute { Name = "CHA", Value = 10 },
            }
        });
        All.Add(new Character() {
            Name = "Clockwork Bronze Scout",
            Ac = 13 ,
            Hp = 36 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary#BronzeScout",
                // IconUrl = "https://www.dndbeyond.com/avatars/thumbnails/25746/222/400/214/637880557279107715.png"
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 10 },
                new Attribute { Name = "DEX", Value = 16 },
                new Attribute { Name = "CON", Value = 11 },
                new Attribute { Name = "INT", Value = 3 },
                new Attribute { Name = "WIS", Value = 14 },
                new Attribute { Name = "CHA", Value = 1 },
            }
        });
        All.Add(new Character() {
            Name = "Clockwork Iron Cobra",
            Ac = 13 ,
            Hp = 91 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary#IronCobra",
                // IconUrl = "https://www.dndbeyond.com/avatars/thumbnails/25746/225/400/392/637880557284349579.png"
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 12 },
                new Attribute { Name = "DEX", Value = 16 },
                new Attribute { Name = "CON", Value = 14 },
                new Attribute { Name = "INT", Value = 3 },
                new Attribute { Name = "WIS", Value = 10 },
                new Attribute { Name = "CHA", Value = 1 },
            }
        });
        All.Add(new Character() {
            Name = "Clockwork Oaken Bolter",
            Ac = 16 ,
            Hp = 117 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary#OakenBolter",
                // IconUrl = "https://www.dndbeyond.com/avatars/thumbnails/25746/228/400/317/637880557289778657.png"
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 12 },
                new Attribute { Name = "DEX", Value = 18 },
                new Attribute { Name = "CON", Value = 15 },
                new Attribute { Name = "INT", Value = 3 },
                new Attribute { Name = "WIS", Value = 10 },
                new Attribute { Name = "CHA", Value = 1 },
            }
        });
        All.Add(new Character() {
            Name = "Clockwork Stone Defender",
            Ac = 16 ,
            Hp = 105 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary#StoneDefender",
                // IconUrl = "https://www.dndbeyond.com/avatars/thumbnails/25746/231/310/289/637880557293249114.png"
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 19 },
                new Attribute { Name = "DEX", Value = 10 },
                new Attribute { Name = "CON", Value = 17 },
                new Attribute { Name = "INT", Value = 3 },
                new Attribute { Name = "WIS", Value = 10 },
                new Attribute { Name = "CHA", Value = 1 },
            }
        });
        All.Add(new Character() {
            Name = "Cloud Giant Smiling One",
            Ac = 15 ,
            Hp = 250 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary#CloudGiantSmilingOne",
                // IconUrl = "https://www.dndbeyond.com/avatars/thumbnails/25746/234/310/531/637880557298069392.png"
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 26 },
                new Attribute { Name = "DEX", Value = 12 },
                new Attribute { Name = "CON", Value = 22 },
                new Attribute { Name = "INT", Value = 15 },
                new Attribute { Name = "WIS", Value = 16 },
                new Attribute { Name = "CHA", Value = 17 },
            }
        });
        All.Add(new Character() {
            Name = "Corpse Flower",
            Ac = 12 ,
            Hp = 127 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary#CorpseFlower",
                // IconUrl = "https://www.dndbeyond.com/avatars/thumbnails/25746/239/360/424/637880557306930233.png"
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 14 },
                new Attribute { Name = "DEX", Value = 14 },
                new Attribute { Name = "CON", Value = 16 },
                new Attribute { Name = "INT", Value = 7 },
                new Attribute { Name = "WIS", Value = 15 },
                new Attribute { Name = "CHA", Value = 3 },
            }
        });
        All.Add(new Character() {
            Name = "Cranium Rat",
            Ac = 12 ,
            Hp = 2 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary#CraniumRat",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 2 },
                new Attribute { Name = "DEX", Value = 14 },
                new Attribute { Name = "CON", Value = 10 },
                new Attribute { Name = "INT", Value = 4 },
                new Attribute { Name = "WIS", Value = 11 },
                new Attribute { Name = "CHA", Value = 8 },
            }
        });
        All.Add(new Character() {
            Name = "Cranium Rat (Swarm)",
            Ac = 12 ,
            Hp = 76 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary#SwarmofCraniumRats",
                // IconUrl = "https://www.dndbeyond.com/avatars/thumbnails/25746/697/380/341/637880558073379029.png"
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 9 },
                new Attribute { Name = "DEX", Value = 14 },
                new Attribute { Name = "CON", Value = 10 },
                new Attribute { Name = "INT", Value = 15 },
                new Attribute { Name = "WIS", Value = 11 },
                new Attribute { Name = "CHA", Value = 14 },
            }
        });
        #endregion
        #region D
        All.Add(new Character() {
            Name = "Darkling",
            Ac = 14 ,
            Hp = 13 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary#Darkling",
                // IconUrl = "https://media.dndbeyond.com/compendium-images/motm/krLB7gHQhdpHbQ1u/02-050.darkling-darkling-elder.png"
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 9 },
                new Attribute { Name = "DEX", Value = 16 },
                new Attribute { Name = "CON", Value = 12 },
                new Attribute { Name = "INT", Value = 10 },
                new Attribute { Name = "WIS", Value = 12 },
                new Attribute { Name = "CHA", Value = 10 },
            }
        });
        All.Add(new Character() {
            Name = "Darkling Elder",
            Ac = 15 ,
            Hp = 27 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary#DarklingElder",
                // IconUrl = "https://media.dndbeyond.com/compendium-images/motm/krLB7gHQhdpHbQ1u/02-050.darkling-darkling-elder.png"
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 13},
                new Attribute { Name = "DEX", Value = 17 },
                new Attribute { Name = "CON", Value = 12 },
                new Attribute { Name = "INT", Value = 10 },
                new Attribute { Name = "WIS", Value = 14 },
                new Attribute { Name = "CHA", Value = 13 },
            }
        });
        All.Add(new Character() {
            Name = "Death Kiss",
            Ac = 15 ,
            Hp = 142 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary#DeathKiss",
                // IconUrl = "https://media.dndbeyond.com/compendium-images/motm/krLB7gHQhdpHbQ1u/02-006.death-kiss.png"
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 18 },
                new Attribute { Name = "DEX", Value = 14 },
                new Attribute { Name = "CON", Value = 18 },
                new Attribute { Name = "INT", Value = 10 },
                new Attribute { Name = "WIS", Value = 12 },
                new Attribute { Name = "CHA", Value = 10 },
            }
        });
        All.Add(new Character() {
            Name = "Deathlock",
            Ac = 12 ,
            Hp = 36 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary#Deathlock",
                // IconUrl = "https://www.dndbeyond.com/avatars/thumbnails/25746/254/350/568/637880557329212325.png"
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 11 },
                new Attribute { Name = "DEX", Value = 15 },
                new Attribute { Name = "CON", Value = 10 },
                new Attribute { Name = "INT", Value = 14 },
                new Attribute { Name = "WIS", Value = 12 },
                new Attribute { Name = "CHA", Value = 16 },
            }
        });
        All.Add(new Character() {
            Name = "Deathlock Mastermind",
            Ac = 13 ,
            Hp = 110 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary#DeathlockMastermind",
                // IconUrl = "https://www.dndbeyond.com/avatars/thumbnails/25746/254/350/568/637880557329212325.png"
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 11 },
                new Attribute { Name = "DEX", Value = 16 },
                new Attribute { Name = "CON", Value = 12 },
                new Attribute { Name = "INT", Value = 15 },
                new Attribute { Name = "WIS", Value = 12 },
                new Attribute { Name = "CHA", Value = 17 },
            }
        });All.Add(new Character() {
            Name = "Deathlock Mastermind",
            Ac = 13 ,
            Hp = 110 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary#DeathlockMastermind",
                // IconUrl = "https://www.dndbeyond.com/avatars/thumbnails/25746/254/350/568/637880557329212325.png"
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 11 },
                new Attribute { Name = "DEX", Value = 16 },
                new Attribute { Name = "CON", Value = 12 },
                new Attribute { Name = "INT", Value = 15 },
                new Attribute { Name = "WIS", Value = 12 },
                new Attribute { Name = "CHA", Value = 17 },
            }
        });
        All.Add(new Character() {
            Name = "Deathlock Wight",
            Ac = 12 ,
            Hp = 37 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary#DeathlockWight",
                // IconUrl = "https://www.dndbeyond.com/avatars/thumbnails/25746/254/350/568/637880557329212325.png"
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 11 },
                new Attribute { Name = "DEX", Value = 14 },
                new Attribute { Name = "CON", Value = 16 },
                new Attribute { Name = "INT", Value = 12 },
                new Attribute { Name = "WIS", Value = 14 },
                new Attribute { Name = "CHA", Value = 16 },
            }
        });
        All.Add(new Character() {
            Name = "Demogorgon",
            Ac = 22 ,
            Hp = 464 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary#Demogorgon",
                // IconUrl = "https://www.dndbeyond.com/avatars/thumbnails/25746/263/400/342/637880557346153822.png"
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 29 },
                new Attribute { Name = "DEX", Value = 14 },
                new Attribute { Name = "CON", Value = 26 },
                new Attribute { Name = "INT", Value = 20 },
                new Attribute { Name = "WIS", Value = 17 },
                new Attribute { Name = "CHA", Value = 25 },
            }
        });
        All.Add(new Character() {
            Name = "Derro Savant",
            Ac = 13 ,
            Hp = 36 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary#DerroSavant",
                // IconUrl = "https://www.dndbeyond.com/avatars/thumbnails/25746/266/305/489/637880557351604440.png"
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 9 },
                new Attribute { Name = "DEX", Value = 14 },
                new Attribute { Name = "CON", Value = 12 },
                new Attribute { Name = "INT", Value = 11 },
                new Attribute { Name = "WIS", Value = 5 },
                new Attribute { Name = "CHA", Value = 14 },
            }
        });
        All.Add(new Character() {
            Name = "Devourer",
            Ac = 16 ,
            Hp = 189 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary#Devourer",
                // IconUrl = "https://www.dndbeyond.com/avatars/thumbnails/25746/272/350/480/637880557360565244.png"
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 20 },
                new Attribute { Name = "DEX", Value = 12 },
                new Attribute { Name = "CON", Value = 20 },
                new Attribute { Name = "INT", Value = 13 },
                new Attribute { Name = "WIS", Value = 10 },
                new Attribute { Name = "CHA", Value = 16 },
            }
        });
        All.Add(new Character() {
            Name = "Dhergoloth",
            Ac = 15 ,
            Hp = 119 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary#Dhergoloth",
                // IconUrl = "https://www.dndbeyond.com/avatars/thumbnails/25746/275/400/558/637880557365705561.png"
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 17 },
                new Attribute { Name = "DEX", Value = 10 },
                new Attribute { Name = "CON", Value = 19 },
                new Attribute { Name = "INT", Value = 7 },
                new Attribute { Name = "WIS", Value = 10 },
                new Attribute { Name = "CHA", Value = 9 },
            }
        });
        All.Add(new Character() {
            Name = "Brontosaurus",
            Ac = 15 ,
            Hp = 121 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary#Brontosaurus",
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
            Name = "Deinonychus",
            Ac = 13 ,
            Hp = 26 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary#Deinonychus",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 15 },
                new Attribute { Name = "DEX", Value = 15 },
                new Attribute { Name = "CON", Value = 14 },
                new Attribute { Name = "INT", Value = 4 },
                new Attribute { Name = "WIS", Value = 12 },
                new Attribute { Name = "CHA", Value = 6 },
            }
        });
        All.Add(new Character() {
            Name = "Dimetrodon",
            Ac = 12 ,
            Hp = 19 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary#Dimetrodon",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 14 },
                new Attribute { Name = "DEX", Value = 10 },
                new Attribute { Name = "CON", Value = 15 },
                new Attribute { Name = "INT", Value = 2 },
                new Attribute { Name = "WIS", Value = 10 },
                new Attribute { Name = "CHA", Value = 5 },
            }
        });
        All.Add(new Character() {
            Name = "Hadrosaurus",
            Ac = 11 ,
            Hp = 19 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary#Hadrosaurus",
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
            Name = "Quetzalcoatlus",
            Ac = 13 ,
            Hp = 30 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary#Quetzalcoatlus",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 15 },
                new Attribute { Name = "DEX", Value = 13 },
                new Attribute { Name = "CON", Value = 13 },
                new Attribute { Name = "INT", Value = 2 },
                new Attribute { Name = "WIS", Value = 10 },
                new Attribute { Name = "CHA", Value = 5 },
            }
        });
        All.Add(new Character() {
            Name = "Stegosaurus",
            Ac = 13 ,
            Hp = 76 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary#Stegosaurus",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 20 },
                new Attribute { Name = "DEX", Value = 9 },
                new Attribute { Name = "CON", Value = 17 },
                new Attribute { Name = "INT", Value = 2 },
                new Attribute { Name = "WIS", Value = 11 },
                new Attribute { Name = "CHA", Value = 5 },
            }
        });
        All.Add(new Character() {
            Name = "Velociraptor",
            Ac = 13 ,
            Hp = 10 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary#Velociraptor",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 6 },
                new Attribute { Name = "DEX", Value = 14 },
                new Attribute { Name = "CON", Value = 13 },
                new Attribute { Name = "INT", Value = 4 },
                new Attribute { Name = "WIS", Value = 12 },
                new Attribute { Name = "CHA", Value = 6 },
            }
        });
        All.Add(new Character() {
            Name = "Dolphin",
            Ac = 12 ,
            Hp = 11 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary#Dolphin",
                // IconUrl = "https://media.dndbeyond.com/compendium-images/motm/krLB7gHQhdpHbQ1u/02-008.dolphins.png"
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 14 },
                new Attribute { Name = "DEX", Value = 13 },
                new Attribute { Name = "CON", Value = 13 },
                new Attribute { Name = "INT", Value = 6 },
                new Attribute { Name = "WIS", Value = 12 },
                new Attribute { Name = "CHA", Value = 7 },
            }
        });
        All.Add(new Character() {
            Name = "Dolphin Delighter",
            Ac = 14 ,
            Hp = 27 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary#DolphinDelighter",
                // IconUrl = "https://media.dndbeyond.com/compendium-images/motm/krLB7gHQhdpHbQ1u/02-008.dolphins.png"
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 14 },
                new Attribute { Name = "DEX", Value = 13 },
                new Attribute { Name = "CON", Value = 13 },
                new Attribute { Name = "INT", Value = 11 },
                new Attribute { Name = "WIS", Value = 12 },
                new Attribute { Name = "CHA", Value = 16 },
            }
        });
        All.Add(new Character() {
            Name = "Draegloth",
            Ac = 15 ,
            Hp = 123 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary#Draegloth",
                // IconUrl = "https://www.dndbeyond.com/avatars/thumbnails/25746/289/400/476/637880557388817803.png"
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 20 },
                new Attribute { Name = "DEX", Value = 15 },
                new Attribute { Name = "CON", Value = 18 },
                new Attribute { Name = "INT", Value = 13 },
                new Attribute { Name = "WIS", Value = 11 },
                new Attribute { Name = "CHA", Value = 11 },
            }
        });
        All.Add(new Character() {
            Name = "Drow Arachnomancer",
            Ac = 15 ,
            Hp = 162 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary#DrowArachnomancer",
                // IconUrl = "https://www.dndbeyond.com/avatars/thumbnails/25746/292/380/492/637880557395858581.png"
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 11 },
                new Attribute { Name = "DEX", Value = 17 },
                new Attribute { Name = "CON", Value = 14 },
                new Attribute { Name = "INT", Value = 19 },
                new Attribute { Name = "WIS", Value = 14 },
                new Attribute { Name = "CHA", Value = 16 },
            }
        });
        All.Add(new Character() {
            Name = "Drow Favored Consort",
            Ac = 15 ,
            Hp = 240 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary#DrowFavoredConsort",
                // IconUrl = "https://www.dndbeyond.com/avatars/thumbnails/25746/295/285/486/637880557401089114.png"
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 15 },
                new Attribute { Name = "DEX", Value = 20 },
                new Attribute { Name = "CON", Value = 16 },
                new Attribute { Name = "INT", Value = 18 },
                new Attribute { Name = "WIS", Value = 15 },
                new Attribute { Name = "CHA", Value = 18 },
            }
        });
        All.Add(new Character() {
            Name = "Drow House Captain",
            Ac = 16 ,
            Hp = 162 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary#DrowHouseCaptain",
                // IconUrl = "https://www.dndbeyond.com/avatars/thumbnails/25746/298/200/571/637880557405799243.png"
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 14 },
                new Attribute { Name = "DEX", Value = 19 },
                new Attribute { Name = "CON", Value = 15 },
                new Attribute { Name = "INT", Value = 12 },
                new Attribute { Name = "WIS", Value = 14 },
                new Attribute { Name = "CHA", Value = 13 },
            }
        });
        All.Add(new Character() {
            Name = "Drow Inquisitor",
            Ac = 16 ,
            Hp = 149 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary#DrowInquisitor",
                // IconUrl = "https://www.dndbeyond.com/avatars/thumbnails/25746/304/360/714/637880557414400051.png"
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 12 },
                new Attribute { Name = "DEX", Value = 15 },
                new Attribute { Name = "CON", Value = 14 },
                new Attribute { Name = "INT", Value = 16 },
                new Attribute { Name = "WIS", Value = 21 },
                new Attribute { Name = "CHA", Value = 20 },
            }
        });
        All.Add(new Character() {
            Name = "Drow Matron Mother",
            Ac = 17 ,
            Hp = 247 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary#DrowMatronMother",
                // IconUrl = "https://www.dndbeyond.com/avatars/thumbnails/25746/307/275/694/637880557418580550.png"
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 12 },
                new Attribute { Name = "DEX", Value = 18 },
                new Attribute { Name = "CON", Value = 16 },
                new Attribute { Name = "INT", Value = 12 },
                new Attribute { Name = "WIS", Value = 21 },
                new Attribute { Name = "CHA", Value = 22 },
            }
        });
        All.Add(new Character() {
            Name = "Drow Shadowblade",
            Ac = 17 ,
            Hp = 150 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary#DrowShadowblade",
                // IconUrl = "https://www.dndbeyond.com/avatars/thumbnails/25746/316/350/612/637880557434521888.png"
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 14 },
                new Attribute { Name = "DEX", Value = 21 },
                new Attribute { Name = "CON", Value = 16 },
                new Attribute { Name = "INT", Value = 12 },
                new Attribute { Name = "WIS", Value = 14 },
                new Attribute { Name = "CHA", Value = 13 },
            }
        });
        All.Add(new Character() {
            Name = "Duergar Despot",
            Ac = 21 ,
            Hp = 119 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary#DuergarDespot",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 20 },
                new Attribute { Name = "DEX", Value = 5 },
                new Attribute { Name = "CON", Value = 19 },
                new Attribute { Name = "INT", Value = 15 },
                new Attribute { Name = "WIS", Value = 14 },
                new Attribute { Name = "CHA", Value = 13 },
            }
        });
        All.Add(new Character() {
            Name = "Duergar Kavalrachni",
            Ac = 16 ,
            Hp = 26 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary#DuergarKavalrachni",
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
            Name = "Duergar Mind Master",
            Ac = 14 ,
            Hp = 39 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary#DuergarMindMaster",
                // IconUrl = "https://www.dndbeyond.com/avatars/thumbnails/25746/322/350/495/637880557445782972.png"
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 11 },
                new Attribute { Name = "DEX", Value = 17 },
                new Attribute { Name = "CON", Value = 14 },
                new Attribute { Name = "INT", Value = 15 },
                new Attribute { Name = "WIS", Value = 10 },
                new Attribute { Name = "CHA", Value = 12 },
            }
        });
        All.Add(new Character() {
            Name = "Duergar Soulblade",
            Ac = 14 ,
            Hp = 27 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary#DuergarSoulblade",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 16 },
                new Attribute { Name = "DEX", Value = 16 },
                new Attribute { Name = "CON", Value = 10 },
                new Attribute { Name = "INT", Value = 11 },
                new Attribute { Name = "WIS", Value = 10 },
                new Attribute { Name = "CHA", Value = 12 },
            }
        });
        All.Add(new Character() {
            Name = "Duergar Stone Guard",
            Ac = 18 ,
            Hp = 39 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary#DuergarStoneGuard",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 18 },
                new Attribute { Name = "DEX", Value = 11 },
                new Attribute { Name = "CON", Value = 14 },
                new Attribute { Name = "INT", Value = 11 },
                new Attribute { Name = "WIS", Value = 10 },
                new Attribute { Name = "CHA", Value = 9 },
            }
        });
        All.Add(new Character() {
            Name = "Duergar Warlord",
            Ac = 20 ,
            Hp = 75 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary#DuergarWarlord",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 18 },
                new Attribute { Name = "DEX", Value = 11 },
                new Attribute { Name = "CON", Value = 17 },
                new Attribute { Name = "INT", Value = 12 },
                new Attribute { Name = "WIS", Value = 12 },
                new Attribute { Name = "CHA", Value = 14 },
            }
        });
        All.Add(new Character() {
            Name = "Duergar Xarrorn",
            Ac = 18 ,
            Hp = 26 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary#DuergarXarrorn",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 16 },
                new Attribute { Name = "DEX", Value = 11 },
                new Attribute { Name = "CON", Value = 14 },
                new Attribute { Name = "INT", Value = 11 },
                new Attribute { Name = "WIS", Value = 10 },
                new Attribute { Name = "CHA", Value = 9 },
            }
        });
        All.Add(new Character() {
            Name = "Duergar Hammerer",
            Ac = 17 ,
            Hp = 33 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary#DuergarHammerer",
                // IconUrl = "https://www.dndbeyond.com/avatars/thumbnails/25746/319/400/348/637880557441052656.png"
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 17 },
                new Attribute { Name = "DEX", Value = 7 },
                new Attribute { Name = "CON", Value = 12 },
                new Attribute { Name = "INT", Value = 5 },
                new Attribute { Name = "WIS", Value = 5 },
                new Attribute { Name = "CHA", Value = 5 },
            }
        });
        All.Add(new Character() {
            Name = "Duergar Hammerer",
            Ac = 15 ,
            Hp = 38 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary#DuergarScreamer",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 18 },
                new Attribute { Name = "DEX", Value = 7 },
                new Attribute { Name = "CON", Value = 12 },
                new Attribute { Name = "INT", Value = 5 },
                new Attribute { Name = "WIS", Value = 5 },
                new Attribute { Name = "CHA", Value = 5 },
            }
        });
        All.Add(new Character() {
            Name = "Dybbuk",
            Ac = 14 ,
            Hp = 37 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary#Dybbuk",
                // IconUrl = "https://www.dndbeyond.com/avatars/thumbnails/25746/338/320/600/637880557473675495.png"
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 6 },
                new Attribute { Name = "DEX", Value = 19 },
                new Attribute { Name = "CON", Value = 16 },
                new Attribute { Name = "INT", Value = 16 },
                new Attribute { Name = "WIS", Value = 15 },
                new Attribute { Name = "CHA", Value = 14 },
            }
        });
        #endregion
        #region E
        All.Add(new Character() {
            Name = "Eidolon",
            Ac = 9 ,
            Hp = 63 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary-ek#Eidolon",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 7 },
                new Attribute { Name = "DEX", Value = 8 },
                new Attribute { Name = "CON", Value = 9 },
                new Attribute { Name = "INT", Value = 14 },
                new Attribute { Name = "WIS", Value = 19 },
                new Attribute { Name = "CHA", Value = 16 },
            }
        });
        All.Add(new Character() {
            Name = "Autumn Eladrin",
            Ac = 19 ,
            Hp = 165 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary-ek#AutumnEladrin",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 12 },
                new Attribute { Name = "DEX", Value = 16 },
                new Attribute { Name = "CON", Value = 16 },
                new Attribute { Name = "INT", Value = 14 },
                new Attribute { Name = "WIS", Value = 17 },
                new Attribute { Name = "CHA", Value = 18 },
            }
        });
        All.Add(new Character() {
            Name = "Spring Eladrin",
            Ac = 19 ,
            Hp = 165 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary-ek#SpringEladrin",
                // IconUrl = "https://www.dndbeyond.com/avatars/thumbnails/25746/659/370/608/637880558018008469.png"
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 14 },
                new Attribute { Name = "DEX", Value = 16 },
                new Attribute { Name = "CON", Value = 16 },
                new Attribute { Name = "INT", Value = 18 },
                new Attribute { Name = "WIS", Value = 11 },
                new Attribute { Name = "CHA", Value = 18 },
            }
        });
        All.Add(new Character() {
            Name = "Summer Eladrin",
            Ac = 19 ,
            Hp = 165 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary-ek#SummerEladrin",
                // IconUrl = "https://www.dndbeyond.com/avatars/thumbnails/25746/694/400/603/637880558069088509.png"
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 19 },
                new Attribute { Name = "DEX", Value = 21 },
                new Attribute { Name = "CON", Value = 16 },
                new Attribute { Name = "INT", Value = 14 },
                new Attribute { Name = "WIS", Value = 12 },
                new Attribute { Name = "CHA", Value = 18 },
            }
        });
        All.Add(new Character() {
            Name = "Winter Eladrin",
            Ac = 19 ,
            Hp = 165 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary-ek#WinterEladrin",
                // IconUrl = "https://www.dndbeyond.com/avatars/thumbnails/25746/756/380/505/637880558159476968.png"
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 11 },
                new Attribute { Name = "DEX", Value = 16 },
                new Attribute { Name = "CON", Value = 16 },
                new Attribute { Name = "INT", Value = 18 },
                new Attribute { Name = "WIS", Value = 17 },
                new Attribute { Name = "CHA", Value = 13 },
            }
        });
        All.Add(new Character() {
            Name = "Elder Brain",
            Ac = 10 ,
            Hp = 210 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary-ek#ElderBrain",
                // IconUrl = "https://www.dndbeyond.com/avatars/thumbnails/25746/344/420/547/637880557484876534.png"
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 15 },
                new Attribute { Name = "DEX", Value = 10 },
                new Attribute { Name = "CON", Value = 20 },
                new Attribute { Name = "INT", Value = 21 },
                new Attribute { Name = "WIS", Value = 19 },
                new Attribute { Name = "CHA", Value = 24 },
            }
        });
        All.Add(new Character() {
            Name = "Elder Tempest",
            Ac = 19 ,
            Hp = 264 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary-ek#ElderTempest",
                // IconUrl = "https://www.dndbeyond.com/avatars/thumbnails/25746/350/400/438/637880557494577389.png"
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 23 },
                new Attribute { Name = "DEX", Value = 28 },
                new Attribute { Name = "CON", Value = 23 },
                new Attribute { Name = "INT", Value = 2 },
                new Attribute { Name = "WIS", Value = 21 },
                new Attribute { Name = "CHA", Value = 18 },
            }
        });
        All.Add(new Character() {
            Name = "Air Elemental Myrmidon",
            Ac = 18 ,
            Hp = 117 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary-ek#AirElementalMyrmidon",
                // IconUrl = "https://www.dndbeyond.com/avatars/thumbnails/25746/109/380/441/637880557088470123.png"
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 18 },
                new Attribute { Name = "DEX", Value = 14 },
                new Attribute { Name = "CON", Value = 14 },
                new Attribute { Name = "INT", Value = 9 },
                new Attribute { Name = "WIS", Value = 10 },
                new Attribute { Name = "CHA", Value = 10 },
            }
        });
        All.Add(new Character() {
            Name = "Earth Elemental Myrmidon",
            Ac = 18 ,
            Hp = 127 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary-ek#EarthElementalMyrmidon",
                // IconUrl = "https://www.dndbeyond.com/avatars/thumbnails/25746/341/380/405/637880557478796041.png"
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 18 },
                new Attribute { Name = "DEX", Value = 10 },
                new Attribute { Name = "CON", Value = 17 },
                new Attribute { Name = "INT", Value = 8 },
                new Attribute { Name = "WIS", Value = 10 },
                new Attribute { Name = "CHA", Value = 10 },
            }
        });
        All.Add(new Character() {
            Name = "Fire Elemental Myrmidon",
            Ac = 18 ,
            Hp = 123 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary-ek#FireElementalMyrmidon",
                // IconUrl = "https://www.dndbeyond.com/avatars/thumbnails/25746/359/295/392/637880557508868802.png"
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 13 },
                new Attribute { Name = "DEX", Value = 18 },
                new Attribute { Name = "CON", Value = 15 },
                new Attribute { Name = "INT", Value = 9 },
                new Attribute { Name = "WIS", Value = 10 },
                new Attribute { Name = "CHA", Value = 10 },
            }
        });
        All.Add(new Character() {
            Name = "Water Elemental Myrmidon",
            Ac = 18 ,
            Hp = 127 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary-ek#WaterElementalMyrmidon",
                // IconUrl = "https://www.dndbeyond.com/avatars/thumbnails/25746/750/360/502/637880558149325772.png"
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 18 },
                new Attribute { Name = "DEX", Value = 14 },
                new Attribute { Name = "CON", Value = 16 },
                new Attribute { Name = "INT", Value = 8 },
                new Attribute { Name = "WIS", Value = 10 },
                new Attribute { Name = "CHA", Value = 10 },
            }
        });
        #endregion
        #region F
        All.Add(new Character() {
            Name = "Fire Giant Dreadnought",
            Ac = 21 ,
            Hp = 187 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary-ek#FireGiantDreadnought",
                // IconUrl = "https://www.dndbeyond.com/avatars/thumbnails/25746/362/400/414/637880557513639132.png"
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 27 },
                new Attribute { Name = "DEX", Value = 9 },
                new Attribute { Name = "CON", Value = 23 },
                new Attribute { Name = "INT", Value = 8 },
                new Attribute { Name = "WIS", Value = 10 },
                new Attribute { Name = "CHA", Value = 11 },
            }
        });
        All.Add(new Character() {
            Name = "Firenewt Warlock of Imix",
            Ac = 10 ,
            Hp = 33 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary-ek#FirenewtWarlockofImix",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 13 },
                new Attribute { Name = "DEX", Value = 11 },
                new Attribute { Name = "CON", Value = 12 },
                new Attribute { Name = "INT", Value = 9 },
                new Attribute { Name = "WIS", Value = 11 },
                new Attribute { Name = "CHA", Value = 14 },
            }
        });
        All.Add(new Character() {
            Name = "Firenewt Warrior",
            Ac = 13 ,
            Hp = 27 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary-ek#FirenewtWarrior",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 10 },
                new Attribute { Name = "DEX", Value = 13 },
                new Attribute { Name = "CON", Value = 12 },
                new Attribute { Name = "INT", Value = 7 },
                new Attribute { Name = "WIS", Value = 11 },
                new Attribute { Name = "CHA", Value = 8 },
            }
        });
        All.Add(new Character() {
            Name = "Flail Snail",
            Ac = 16 ,
            Hp = 52 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary-ek#FlailSnail",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 17 },
                new Attribute { Name = "DEX", Value = 5 },
                new Attribute { Name = "CON", Value = 20 },
                new Attribute { Name = "INT", Value = 3 },
                new Attribute { Name = "WIS", Value = 10 },
                new Attribute { Name = "CHA", Value = 5 },
            }
        });
        All.Add(new Character() {
            Name = "Flind",
            Ac = 16 ,
            Hp = 127 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary-ek#Flind",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 20 },
                new Attribute { Name = "DEX", Value = 14 },
                new Attribute { Name = "CON", Value = 19 },
                new Attribute { Name = "INT", Value = 11 },
                new Attribute { Name = "WIS", Value = 13 },
                new Attribute { Name = "CHA", Value = 12 },
            }
        });
        All.Add(new Character() {
            Name = "Fraz Urbluu",
            Ac = 18 ,
            Hp = 337 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary-ek#FrazUrbluu",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 29 },
                new Attribute { Name = "DEX", Value = 12 },
                new Attribute { Name = "CON", Value = 25 },
                new Attribute { Name = "INT", Value = 26 },
                new Attribute { Name = "WIS", Value = 24 },
                new Attribute { Name = "CHA", Value = 26 },
            }
        });
        All.Add(new Character() {
            Name = "Froghemoth",
            Ac = 14 ,
            Hp = 161 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary-ek#Froghemoth",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 23 },
                new Attribute { Name = "DEX", Value = 13 },
                new Attribute { Name = "CON", Value = 20 },
                new Attribute { Name = "INT", Value = 2 },
                new Attribute { Name = "WIS", Value = 12 },
                new Attribute { Name = "CHA", Value = 5 },
            }
        });
        All.Add(new Character() {
            Name = "Frost Giant Everlasting One",
            Ac = 15 ,
            Hp = 189 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary-ek#FrostGiantEverlastingOne",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 25 },
                new Attribute { Name = "DEX", Value = 9 },
                new Attribute { Name = "CON", Value = 24 },
                new Attribute { Name = "INT", Value = 9 },
                new Attribute { Name = "WIS", Value = 10 },
                new Attribute { Name = "CHA", Value = 12 },
            }
        });
        All.Add(new Character() {
            Name = "Frost Salamander",
            Ac = 17 ,
            Hp = 168 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary-ek#FrostSalamander",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 20 },
                new Attribute { Name = "DEX", Value = 12 },
                new Attribute { Name = "CON", Value = 18 },
                new Attribute { Name = "INT", Value = 7 },
                new Attribute { Name = "WIS", Value = 11 },
                new Attribute { Name = "CHA", Value = 7 },
            }
        });
        #endregion
        #region G
        All.Add(new Character() {
            Name = "Gauth",
            Ac = 15 ,
            Hp = 52 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary-ek#Gauth",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 10 },
                new Attribute { Name = "DEX", Value = 14 },
                new Attribute { Name = "CON", Value = 16 },
                new Attribute { Name = "INT", Value = 15 },
                new Attribute { Name = "WIS", Value = 15 },
                new Attribute { Name = "CHA", Value = 13 },
            }
        });
        All.Add(new Character() {
            Name = "Gazer",
            Ac = 13 ,
            Hp = 13 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary-ek#Gazer",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 3 },
                new Attribute { Name = "DEX", Value = 17 },
                new Attribute { Name = "CON", Value = 14 },
                new Attribute { Name = "INT", Value = 3 },
                new Attribute { Name = "WIS", Value = 10 },
                new Attribute { Name = "CHA", Value = 7 },
            }
        });
        All.Add(new Character() {
            Name = "Geryon",
            Ac = 19 ,
            Hp = 300 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary-ek#Geryon",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 29 },
                new Attribute { Name = "DEX", Value = 17 },
                new Attribute { Name = "CON", Value = 22 },
                new Attribute { Name = "INT", Value = 19 },
                new Attribute { Name = "WIS", Value = 16 },
                new Attribute { Name = "CHA", Value = 23 },
            }
        });
        All.Add(new Character() {
            Name = "Giant Strider",
            Ac = 14 ,
            Hp = 22 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary-ek#GiantStrider",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 18 },
                new Attribute { Name = "DEX", Value = 13 },
                new Attribute { Name = "CON", Value = 14 },
                new Attribute { Name = "INT", Value = 4 },
                new Attribute { Name = "WIS", Value = 12 },
                new Attribute { Name = "CHA", Value = 6 },
            }
        });
        All.Add(new Character() {
            Name = "Giff",
            Ac = 16 ,
            Hp = 60 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary-ek#Giff",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 18 },
                new Attribute { Name = "DEX", Value = 14 },
                new Attribute { Name = "CON", Value = 17 },
                new Attribute { Name = "INT", Value = 11 },
                new Attribute { Name = "WIS", Value = 12 },
                new Attribute { Name = "CHA", Value = 12 },
            }
        });
        All.Add(new Character() {
            Name = "Girallon",
            Ac = 13 ,
            Hp = 59 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary-ek#Girallon",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 18 },
                new Attribute { Name = "DEX", Value = 16 },
                new Attribute { Name = "CON", Value = 16 },
                new Attribute { Name = "INT", Value = 5 },
                new Attribute { Name = "WIS", Value = 12 },
                new Attribute { Name = "CHA", Value = 7 },
            }
        });
        All.Add(new Character() {
            Name = "Githyanki Gish",
            Ac = 17 ,
            Hp = 130 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary-ek#GithyankiGish",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 17 },
                new Attribute { Name = "DEX", Value = 15 },
                new Attribute { Name = "CON", Value = 14 },
                new Attribute { Name = "INT", Value = 16 },
                new Attribute { Name = "WIS", Value = 15 },
                new Attribute { Name = "CHA", Value = 16 },
            }
        });
        All.Add(new Character() {
            Name = "Githyanki Kithrak",
            Ac = 18 ,
            Hp = 180 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary-ek#GithyankiKithrak",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 18 },
                new Attribute { Name = "DEX", Value = 16 },
                new Attribute { Name = "CON", Value = 17 },
                new Attribute { Name = "INT", Value = 16 },
                new Attribute { Name = "WIS", Value = 15 },
                new Attribute { Name = "CHA", Value = 17 },
            }
        });
        All.Add(new Character() {
            Name = "Githyanki Supreme Commander",
            Ac = 18 ,
            Hp = 187 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary-ek#GithyankiSupremeCommander",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 19 },
                new Attribute { Name = "DEX", Value = 17 },
                new Attribute { Name = "CON", Value = 18 },
                new Attribute { Name = "INT", Value = 16 },
                new Attribute { Name = "WIS", Value = 16 },
                new Attribute { Name = "CHA", Value = 18 },
            }
        });
        All.Add(new Character() {
            Name = "Githzerai Anarch",
            Ac = 20 ,
            Hp = 144 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary-ek#GithzeraiAnarch",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 16 },
                new Attribute { Name = "DEX", Value = 21 },
                new Attribute { Name = "CON", Value = 18 },
                new Attribute { Name = "INT", Value = 18 },
                new Attribute { Name = "WIS", Value = 20 },
                new Attribute { Name = "CHA", Value = 14 },
            }
        });
        All.Add(new Character() {
            Name = "Githzerai Enlightened",
            Ac = 18 ,
            Hp = 112 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary-ek#GithzeraiEnlightened",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 14 },
                new Attribute { Name = "DEX", Value = 19 },
                new Attribute { Name = "CON", Value = 16 },
                new Attribute { Name = "INT", Value = 17 },
                new Attribute { Name = "WIS", Value = 19 },
                new Attribute { Name = "CHA", Value = 13 },
            }
        });
        All.Add(new Character() {
            Name = "Gnoll Flesh Gnawer",
            Ac = 14 ,
            Hp = 22 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary-ek#GnollFleshGnawer",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 12 },
                new Attribute { Name = "DEX", Value = 14 },
                new Attribute { Name = "CON", Value = 12 },
                new Attribute { Name = "INT", Value = 8 },
                new Attribute { Name = "WIS", Value = 10 },
                new Attribute { Name = "CHA", Value = 8 },
            }
        });
        All.Add(new Character() {
            Name = "Gnoll Hunter",
            Ac = 13 ,
            Hp = 22 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary-ek#GnollHunter",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 14 },
                new Attribute { Name = "DEX", Value = 14 },
                new Attribute { Name = "CON", Value = 12 },
                new Attribute { Name = "INT", Value = 8 },
                new Attribute { Name = "WIS", Value = 12 },
                new Attribute { Name = "CHA", Value = 8 },
            }
        });
        All.Add(new Character() {
            Name = "Gnoll Witherling",
            Ac = 12 ,
            Hp = 11 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary-ek#GnollWitherling",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 14 },
                new Attribute { Name = "DEX", Value = 8 },
                new Attribute { Name = "CON", Value = 12 },
                new Attribute { Name = "INT", Value = 5 },
                new Attribute { Name = "WIS", Value = 5 },
                new Attribute { Name = "CHA", Value = 5 },
            }
        });
        All.Add(new Character() {
            Name = "Gray Render",
            Ac = 19 ,
            Hp = 189 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary-ek#GrayRender",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 19 },
                new Attribute { Name = "DEX", Value = 13 },
                new Attribute { Name = "CON", Value = 20 },
                new Attribute { Name = "INT", Value = 3 },
                new Attribute { Name = "WIS", Value = 6 },
                new Attribute { Name = "CHA", Value = 8 },
            }
        });
        All.Add(new Character() {
            Name = "Grung",
            Ac = 12 ,
            Hp = 11 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary-ek#Grung",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 7 },
                new Attribute { Name = "DEX", Value = 14 },
                new Attribute { Name = "CON", Value = 15 },
                new Attribute { Name = "INT", Value = 10 },
                new Attribute { Name = "WIS", Value = 11 },
                new Attribute { Name = "CHA", Value = 10 },
            }
        });
        All.Add(new Character() {
            Name = "Grung Elite Warrior",
            Ac = 13 ,
            Hp = 49 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary-ek#GrungEliteWarrior",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 7 },
                new Attribute { Name = "DEX", Value = 16 },
                new Attribute { Name = "CON", Value = 15 },
                new Attribute { Name = "INT", Value = 10 },
                new Attribute { Name = "WIS", Value = 11 },
                new Attribute { Name = "CHA", Value = 12 },
            }
        });
        All.Add(new Character() {
            Name = "Grung Wildling",
            Ac = 16 ,
            Hp = 27 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary-ek#GrungWildling",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 7 },
                new Attribute { Name = "DEX", Value = 16 },
                new Attribute { Name = "CON", Value = 15 },
                new Attribute { Name = "INT", Value = 10 },
                new Attribute { Name = "WIS", Value = 15 },
                new Attribute { Name = "CHA", Value = 11 },
            }
        });
        All.Add(new Character() {
            Name = "Guard Drake",
            Ac = 14 ,
            Hp = 52 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary-ek#GuardDrake",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 16 },
                new Attribute { Name = "DEX", Value = 11 },
                new Attribute { Name = "CON", Value = 16 },
                new Attribute { Name = "INT", Value = 4 },
                new Attribute { Name = "WIS", Value = 10 },
                new Attribute { Name = "CHA", Value = 7 },
            }
        });
        #endregion
        #region H
        All.Add(new Character() {
            Name = "Hellfire Engine",
            Ac = 18 ,
            Hp = 216 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary-ek#HellfireEngine",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 20 },
                new Attribute { Name = "DEX", Value = 16 },
                new Attribute { Name = "CON", Value = 24 },
                new Attribute { Name = "INT", Value = 2 },
                new Attribute { Name = "WIS", Value = 10 },
                new Attribute { Name = "CHA", Value = 1 },
            }
        });
        All.Add(new Character() {
            Name = "Hobgoblin Devastator",
            Ac = 13 ,
            Hp = 45 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary-ek#HobgoblinDevastator",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 13 },
                new Attribute { Name = "DEX", Value = 12 },
                new Attribute { Name = "CON", Value = 14 },
                new Attribute { Name = "INT", Value = 16 },
                new Attribute { Name = "WIS", Value = 13 },
                new Attribute { Name = "CHA", Value = 11 },
            }
        });
        All.Add(new Character() {
            Name = "Hobgoblin Iron Shadow",
            Ac = 15 ,
            Hp = 32 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary-ek#HobgoblinIronShadow",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 14 },
                new Attribute { Name = "DEX", Value = 16 },
                new Attribute { Name = "CON", Value = 15 },
                new Attribute { Name = "INT", Value = 14 },
                new Attribute { Name = "WIS", Value = 15 },
                new Attribute { Name = "CHA", Value = 11 },
            }
        });
        All.Add(new Character() {
            Name = "Howler",
            Ac = 16 ,
            Hp = 90 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary-ek#Howler",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 17 },
                new Attribute { Name = "DEX", Value = 16 },
                new Attribute { Name = "CON", Value = 15 },
                new Attribute { Name = "INT", Value = 5 },
                new Attribute { Name = "WIS", Value = 14 },
                new Attribute { Name = "CHA", Value = 6 },
            }
        });
        All.Add(new Character() {
            Name = "Hutijin",
            Ac = 19 ,
            Hp = 200 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary-ek#Hutijin",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 27 },
                new Attribute { Name = "DEX", Value = 15 },
                new Attribute { Name = "CON", Value = 25 },
                new Attribute { Name = "INT", Value = 23},
                new Attribute { Name = "WIS", Value = 19 },
                new Attribute { Name = "CHA", Value = 25 },
            }
        });
        All.Add(new Character() {
            Name = "Hydroloth",
            Ac = 15 ,
            Hp = 135 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary-ek#Hydroloth",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 12 },
                new Attribute { Name = "DEX", Value = 21 },
                new Attribute { Name = "CON", Value = 16 },
                new Attribute { Name = "INT", Value = 19 },
                new Attribute { Name = "WIS", Value = 10 },
                new Attribute { Name = "CHA", Value = 14 },
            }
        });
        #endregion
        #region I
        #endregion
        #region J
        All.Add(new Character() {
            Name = "Juiblex",
            Ac = 18 ,
            Hp = 350 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary-ek#Juiblex",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 24 },
                new Attribute { Name = "DEX", Value = 10 },
                new Attribute { Name = "CON", Value = 23 },
                new Attribute { Name = "INT", Value = 20 },
                new Attribute { Name = "WIS", Value = 20 },
                new Attribute { Name = "CHA", Value = 16 },
            }
        });
        #endregion
        #region K
        All.Add(new Character() {
            Name = "Ki-rin",
            Ac = 20 ,
            Hp = 153 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary-ek#Kirin",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 21 },
                new Attribute { Name = "DEX", Value = 16 },
                new Attribute { Name = "CON", Value = 16 },
                new Attribute { Name = "INT", Value = 19 },
                new Attribute { Name = "WIS", Value = 20 },
                new Attribute { Name = "CHA", Value = 20 },
            }
        });
        All.Add(new Character() {
            Name = "Kobold Dragonshield",
            Ac = 15 ,
            Hp = 44 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary-ek#KoboldDragonshield",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 12 },
                new Attribute { Name = "DEX", Value = 15 },
                new Attribute { Name = "CON", Value = 14 },
                new Attribute { Name = "INT", Value = 8 },
                new Attribute { Name = "WIS", Value = 9 },
                new Attribute { Name = "CHA", Value = 10 },
            }
        });
        All.Add(new Character() {
            Name = "Kobold Inventor",
            Ac = 12 ,
            Hp = 13 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary-ek#KoboldInventor",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 7 },
                new Attribute { Name = "DEX", Value = 15 },
                new Attribute { Name = "CON", Value = 12 },
                new Attribute { Name = "INT", Value = 14 },
                new Attribute { Name = "WIS", Value = 10 },
                new Attribute { Name = "CHA", Value = 8 },
            }
        });
        All.Add(new Character() {
            Name = "Kobold Scale Sorcerer",
            Ac = 15 ,
            Hp = 27 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary-ek#KoboldScaleSorcerer",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 7 },
                new Attribute { Name = "DEX", Value = 15 },
                new Attribute { Name = "CON", Value = 14 },
                new Attribute { Name = "INT", Value = 10 },
                new Attribute { Name = "WIS", Value = 9 },
                new Attribute { Name = "CHA", Value = 14 },
            }
        });
        All.Add(new Character() {
            Name = "Korred",
            Ac = 17 ,
            Hp = 93 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary-ek#Korred",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 23 },
                new Attribute { Name = "DEX", Value = 14 },
                new Attribute { Name = "CON", Value = 20 },
                new Attribute { Name = "INT", Value = 10 },
                new Attribute { Name = "WIS", Value = 15 },
                new Attribute { Name = "CHA", Value = 9 },
            }
        });
        All.Add(new Character() {
            Name = "Kraken Priest",
            Ac = 15 ,
            Hp = 75 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary-ek#KrakenPriest",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 12 },
                new Attribute { Name = "DEX", Value = 10 },
                new Attribute { Name = "CON", Value = 16 },
                new Attribute { Name = "INT", Value = 10 },
                new Attribute { Name = "WIS", Value = 15 },
                new Attribute { Name = "CHA", Value = 14 },
            }
        });
        All.Add(new Character() {
            Name = "Young Kruthik",
            Ac = 16 ,
            Hp = 9 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary-ek#YoungKruthik",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 13 },
                new Attribute { Name = "DEX", Value = 16 },
                new Attribute { Name = "CON", Value = 13 },
                new Attribute { Name = "INT", Value = 4 },
                new Attribute { Name = "WIS", Value = 10 },
                new Attribute { Name = "CHA", Value = 6 },
            }
        });
        All.Add(new Character() {
            Name = "Adult Kruthik",
            Ac = 18 ,
            Hp = 39 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary-ek#AdultKruthik",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 15 },
                new Attribute { Name = "DEX", Value = 16 },
                new Attribute { Name = "CON", Value = 15 },
                new Attribute { Name = "INT", Value = 7 },
                new Attribute { Name = "WIS", Value = 12 },
                new Attribute { Name = "CHA", Value = 8 },
            }
        });
        All.Add(new Character() {
            Name = "Kruthik Hive Lord",
            Ac = 20 ,
            Hp = 102 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary-ek#KruthikHiveLord",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 19 },
                new Attribute { Name = "DEX", Value = 16 },
                new Attribute { Name = "CON", Value = 17 },
                new Attribute { Name = "INT", Value = 10 },
                new Attribute { Name = "WIS", Value = 14 },
                new Attribute { Name = "CHA", Value = 10 },
            }
        });
        #endregion
        #region L
        All.Add(new Character() {
            Name = "Leucrotta",
            Ac = 14 ,
            Hp = 67 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary-lr#Leucrotta",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 18 },
                new Attribute { Name = "DEX", Value = 14 },
                new Attribute { Name = "CON", Value = 15 },
                new Attribute { Name = "INT", Value = 9 },
                new Attribute { Name = "WIS", Value = 12 },
                new Attribute { Name = "CHA", Value = 6 },
            }
        });
        All.Add(new Character() {
            Name = "Leviathan",
            Ac = 17 ,
            Hp = 328 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary-lr#Leviathan",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 27 },
                new Attribute { Name = "DEX", Value = 24 },
                new Attribute { Name = "CON", Value = 30 },
                new Attribute { Name = "INT", Value = 2 },
                new Attribute { Name = "WIS", Value = 18 },
                new Attribute { Name = "CHA", Value = 17 },
            }
        });
        #endregion
        #region M
        All.Add(new Character() {
            Name = "Martial Arts Adept",
            Ac = 16 ,
            Hp = 60 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary-lr#MartialArtsAdept",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 11 },
                new Attribute { Name = "DEX", Value = 17 },
                new Attribute { Name = "CON", Value = 13 },
                new Attribute { Name = "INT", Value = 11 },
                new Attribute { Name = "WIS", Value = 16 },
                new Attribute { Name = "CHA", Value = 10 },
            }
        });
        All.Add(new Character() {
            Name = "Marut",
            Ac = 22 ,
            Hp = 432 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary-lr#Marut",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 28 },
                new Attribute { Name = "DEX", Value = 12 },
                new Attribute { Name = "CON", Value = 26 },
                new Attribute { Name = "INT", Value = 19 },
                new Attribute { Name = "WIS", Value = 15 },
                new Attribute { Name = "CHA", Value = 18 },
            }
        });
        All.Add(new Character() {
            Name = "Master Thief",
            Ac = 16 ,
            Hp = 84 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary-lr#MasterThief",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 11 },
                new Attribute { Name = "DEX", Value = 18 },
                new Attribute { Name = "CON", Value = 14 },
                new Attribute { Name = "INT", Value = 11 },
                new Attribute { Name = "WIS", Value = 11 },
                new Attribute { Name = "CHA", Value = 12 },
            }
        });
        All.Add(new Character() {
            Name = "Maw Demon",
            Ac = 13 ,
            Hp = 33 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary-lr#MawDemon",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 14 },
                new Attribute { Name = "DEX", Value = 8 },
                new Attribute { Name = "CON", Value = 13 },
                new Attribute { Name = "INT", Value = 5 },
                new Attribute { Name = "WIS", Value = 8 },
                new Attribute { Name = "CHA", Value = 5 },
            }
        });
        All.Add(new Character() {
            Name = "Meenlock",
            Ac = 15 ,
            Hp = 31 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary-lr#Meenlock",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 17},
                new Attribute { Name = "DEX", Value = 15 },
                new Attribute { Name = "CON", Value = 12 },
                new Attribute { Name = "INT", Value = 11 },
                new Attribute { Name = "WIS", Value = 10 },
                new Attribute { Name = "CHA", Value = 8 },
            }
        });
        All.Add(new Character() {
            Name = "Merregon",
            Ac = 16 ,
            Hp = 45 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary-lr#Merregon",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 18 },
                new Attribute { Name = "DEX", Value = 14 },
                new Attribute { Name = "CON", Value = 17 },
                new Attribute { Name = "INT", Value = 6 },
                new Attribute { Name = "WIS", Value = 12 },
                new Attribute { Name = "CHA", Value = 8 },
            }
        });
        All.Add(new Character() {
            Name = "Merrenoloth",
            Ac = 13 ,
            Hp = 40 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary-lr#Merrenoloth",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 8 },
                new Attribute { Name = "DEX", Value = 17 },
                new Attribute { Name = "CON", Value = 10 },
                new Attribute { Name = "INT", Value = 17 },
                new Attribute { Name = "WIS", Value = 14 },
                new Attribute { Name = "CHA", Value = 11 },
            }
        });
        All.Add(new Character() {
            Name = "Mindwitness",
            Ac = 15 ,
            Hp = 75 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary-lr#Mindwitness",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 10 },
                new Attribute { Name = "DEX", Value = 14 },
                new Attribute { Name = "CON", Value = 14 },
                new Attribute { Name = "INT", Value = 15 },
                new Attribute { Name = "WIS", Value = 15 },
                new Attribute { Name = "CHA", Value = 10 },
            }
        });
        All.Add(new Character() {
            Name = "Moloch",
            Ac = 19 ,
            Hp = 253 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary-lr#Moloch",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 26 },
                new Attribute { Name = "DEX", Value = 19 },
                new Attribute { Name = "CON", Value = 22 },
                new Attribute { Name = "INT", Value = 21 },
                new Attribute { Name = "WIS", Value = 18 },
                new Attribute { Name = "CHA", Value = 23 },
            }
        });
        All.Add(new Character() {
            Name = "Molydeus",
            Ac = 19 ,
            Hp = 216 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary-lr#Molydeus",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 28 },
                new Attribute { Name = "DEX", Value = 22 },
                new Attribute { Name = "CON", Value = 25 },
                new Attribute { Name = "INT", Value = 21 },
                new Attribute { Name = "WIS", Value = 24 },
                new Attribute { Name = "CHA", Value = 24 },
            }
        });
        All.Add(new Character() {
            Name = "Morkoth",
            Ac = 17 ,
            Hp = 165 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary-lr#Morkoth",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 14 },
                new Attribute { Name = "DEX", Value = 14 },
                new Attribute { Name = "CON", Value = 14 },
                new Attribute { Name = "INT", Value = 20 },
                new Attribute { Name = "WIS", Value = 15 },
                new Attribute { Name = "CHA", Value = 13 },
            }
        });
        All.Add(new Character() {
            Name = "Mouth of Grolantor",
            Ac = 14 ,
            Hp = 105 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary-lr#MouthofGrolantor",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 21 },
                new Attribute { Name = "DEX", Value = 10 },
                new Attribute { Name = "CON", Value = 18 },
                new Attribute { Name = "INT", Value = 5 },
                new Attribute { Name = "WIS", Value = 7 },
                new Attribute { Name = "CHA", Value = 5 },
            }
        });
        #endregion
        #region N
        All.Add(new Character() {
            Name = "Nabassu",
            Ac = 18 ,
            Hp = 190 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary-lr#Nabassu",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 22 },
                new Attribute { Name = "DEX", Value = 14 },
                new Attribute { Name = "CON", Value = 21 },
                new Attribute { Name = "INT", Value = 14 },
                new Attribute { Name = "WIS", Value = 15 },
                new Attribute { Name = "CHA", Value = 17 },
            }
        });
        All.Add(new Character() {
            Name = "Nagpa",
            Ac = 19 ,
            Hp = 203 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary-lr#Nagpa",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 9 },
                new Attribute { Name = "DEX", Value = 15 },
                new Attribute { Name = "CON", Value = 12 },
                new Attribute { Name = "INT", Value = 23 },
                new Attribute { Name = "WIS", Value = 18 },
                new Attribute { Name = "CHA", Value = 21 },
            }
        });
        All.Add(new Character() {
            Name = "Narzugon",
            Ac = 20 ,
            Hp = 112 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary-lr#Narzugon",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 20 },
                new Attribute { Name = "DEX", Value = 10 },
                new Attribute { Name = "CON", Value = 17 },
                new Attribute { Name = "INT", Value = 16 },
                new Attribute { Name = "WIS", Value = 14 },
                new Attribute { Name = "CHA", Value = 19 },
            }
        });
        All.Add(new Character() {
            Name = "Neogi Hatchling",
            Ac = 11 ,
            Hp = 7 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary-lr#NeogiHatchling",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 3 },
                new Attribute { Name = "DEX", Value = 13 },
                new Attribute { Name = "CON", Value = 10 },
                new Attribute { Name = "INT", Value = 6 },
                new Attribute { Name = "WIS", Value = 10 },
                new Attribute { Name = "CHA", Value = 9 },
            }
        });
        All.Add(new Character() {
            Name = "Neogi Adult",
            Ac = 15 ,
            Hp = 33 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary-lr#NeogiAdult",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 6 },
                new Attribute { Name = "DEX", Value = 16 },
                new Attribute { Name = "CON", Value = 14 },
                new Attribute { Name = "INT", Value = 13 },
                new Attribute { Name = "WIS", Value = 12 },
                new Attribute { Name = "CHA", Value = 15 },
            }
        });
        All.Add(new Character() {
            Name = "Neogi Master",
            Ac = 15 ,
            Hp = 71 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary-lr#NeogiMaster",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 6 },
                new Attribute { Name = "DEX", Value = 16 },
                new Attribute { Name = "CON", Value = 14 },
                new Attribute { Name = "INT", Value = 16 },
                new Attribute { Name = "WIS", Value = 12 },
                new Attribute { Name = "CHA", Value = 18 },
            }
        });
        All.Add(new Character() {
            Name = "Neothelid",
            Ac = 16 ,
            Hp = 232 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary-lr#Neothelid",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 27 },
                new Attribute { Name = "DEX", Value = 7 },
                new Attribute { Name = "CON", Value = 21 },
                new Attribute { Name = "INT", Value = 3 },
                new Attribute { Name = "WIS", Value = 16 },
                new Attribute { Name = "CHA", Value = 12 },
            }
        });
        All.Add(new Character() {
            Name = "Nightwalker",
            Ac = 14 ,
            Hp = 337 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary-lr#Nightwalker",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 22 },
                new Attribute { Name = "DEX", Value = 19 },
                new Attribute { Name = "CON", Value = 24 },
                new Attribute { Name = "INT", Value = 6 },
                new Attribute { Name = "WIS", Value = 9 },
                new Attribute { Name = "CHA", Value = 8 },
            }
        });
        All.Add(new Character() {
            Name = "Nilbog",
            Ac = 13 ,
            Hp = 7 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary-lr#Nilbog",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 8 },
                new Attribute { Name = "DEX", Value = 14 },
                new Attribute { Name = "CON", Value = 10 },
                new Attribute { Name = "INT", Value = 10 },
                new Attribute { Name = "WIS", Value = 8 },
                new Attribute { Name = "CHA", Value = 15 },
            }
        });
        All.Add(new Character() {
            Name = "Nupperibo",
            Ac = 13 ,
            Hp = 11 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary-lr#Nupperibo",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 16 },
                new Attribute { Name = "DEX", Value = 11 },
                new Attribute { Name = "CON", Value = 13 },
                new Attribute { Name = "INT", Value = 3 },
                new Attribute { Name = "WIS", Value = 8 },
                new Attribute { Name = "CHA", Value = 1 },
            }
        });
        #endregion
        #region O
        All.Add(new Character() {
            Name = "Oblex Spawn",
            Ac = 13 ,
            Hp = 18 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary-lr#OblexSpawn",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 8 },
                new Attribute { Name = "DEX", Value = 16 },
                new Attribute { Name = "CON", Value = 15 },
                new Attribute { Name = "INT", Value = 14 },
                new Attribute { Name = "WIS", Value = 11 },
                new Attribute { Name = "CHA", Value = 10 },
            }
        });
        All.Add(new Character() {
            Name = "Adult Oblex",
            Ac = 14 ,
            Hp = 75 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary-lr#AdultOblex",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 8 },
                new Attribute { Name = "DEX", Value = 19 },
                new Attribute { Name = "CON", Value = 16 },
                new Attribute { Name = "INT", Value = 19 },
                new Attribute { Name = "WIS", Value = 12 },
                new Attribute { Name = "CHA", Value = 15 },
            }
        });
        All.Add(new Character() {
            Name = "Elder Oblex",
            Ac = 16 ,
            Hp = 115 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary-lr#ElderOblex",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 15 },
                new Attribute { Name = "DEX", Value = 16 },
                new Attribute { Name = "CON", Value = 21 },
                new Attribute { Name = "INT", Value = 22 },
                new Attribute { Name = "WIS", Value = 13 },
                new Attribute { Name = "CHA", Value = 18 },
            }
        });
        All.Add(new Character() {
            Name = "Ogre Battering Ram",
            Ac = 11 ,
            Hp = 76 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary-lr#OgreBatteringRam",
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
            Name = "Ogre Bolt Launcher",
            Ac = 13 ,
            Hp = 59 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary-lr#OgreBoltLauncher",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 19 },
                new Attribute { Name = "DEX", Value = 12 },
                new Attribute { Name = "CON", Value = 16 },
                new Attribute { Name = "INT", Value = 5 },
                new Attribute { Name = "WIS", Value = 7 },
                new Attribute { Name = "CHA", Value = 7 },
            }
        });
        All.Add(new Character() {
            Name = "Ogre Chain Brute",
            Ac = 11 ,
            Hp = 59 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary-lr#OgreChainBrute",
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
            Name = "Ogre Howdah",
            Ac = 15 ,
            Hp = 59 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary-lr#OgreHowdah",
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
            Name = "Oinoloth",
            Ac = 17 ,
            Hp = 119 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary-lr#Oinoloth",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 19 },
                new Attribute { Name = "DEX", Value = 17 },
                new Attribute { Name = "CON", Value = 18 },
                new Attribute { Name = "INT", Value = 17 },
                new Attribute { Name = "WIS", Value = 16 },
                new Attribute { Name = "CHA", Value = 19 },
            }
        });
        All.Add(new Character() {
            Name = "Orcus",
            Ac = 17 ,
            Hp = 405 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary-lr#Orcus",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 27 },
                new Attribute { Name = "DEX", Value = 14 },
                new Attribute { Name = "CON", Value = 25 },
                new Attribute { Name = "INT", Value = 20 },
                new Attribute { Name = "WIS", Value = 20 },
                new Attribute { Name = "CHA", Value = 25 },
            }
        });
        All.Add(new Character() {
            Name = "Orthon",
            Ac = 17 ,
            Hp = 105 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary-lr#Orthon",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 22 },
                new Attribute { Name = "DEX", Value = 16 },
                new Attribute { Name = "CON", Value = 21 },
                new Attribute { Name = "INT", Value = 15 },
                new Attribute { Name = "WIS", Value = 15 },
                new Attribute { Name = "CHA", Value = 16 },
            }
        });
        #endregion
        #region P
        All.Add(new Character() {
            Name = "Phoenix",
            Ac = 18 ,
            Hp = 175 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary-lr#Phoenix",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 19 },
                new Attribute { Name = "DEX", Value = 26 },
                new Attribute { Name = "CON", Value = 25 },
                new Attribute { Name = "INT", Value = 2 },
                new Attribute { Name = "WIS", Value = 21 },
                new Attribute { Name = "CHA", Value = 18 },
            }
        });
        #endregion
        #region Q
        All.Add(new Character() {
            Name = "Quickling",
            Ac = 16 ,
            Hp = 10 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary-lr#Quickling",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 4 },
                new Attribute { Name = "DEX", Value = 23 },
                new Attribute { Name = "CON", Value = 13 },
                new Attribute { Name = "INT", Value = 10 },
                new Attribute { Name = "WIS", Value = 12 },
                new Attribute { Name = "CHA", Value = 7 },
            }
        });
        #endregion
        #region R
        All.Add(new Character() {
            Name = "Redcap",
            Ac = 14 ,
            Hp = 45 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary-lr#Redcap",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 18 },
                new Attribute { Name = "DEX", Value = 13 },
                new Attribute { Name = "CON", Value = 18 },
                new Attribute { Name = "INT", Value = 10 },
                new Attribute { Name = "WIS", Value = 12 },
                new Attribute { Name = "CHA", Value = 9 },
            }
        });
        All.Add(new Character() {
            Name = "Retriever",
            Ac = 19 ,
            Hp = 210 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary-lr#Retriever",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 22 },
                new Attribute { Name = "DEX", Value = 16 },
                new Attribute { Name = "CON", Value = 20 },
                new Attribute { Name = "INT", Value = 3 },
                new Attribute { Name = "WIS", Value = 11 },
                new Attribute { Name = "CHA", Value = 4 },
            }
        });
        All.Add(new Character() {
            Name = "Rutterkin",
            Ac = 12 ,
            Hp = 37 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary-lr#Rutterkin",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 14 },
                new Attribute { Name = "DEX", Value = 15 },
                new Attribute { Name = "CON", Value = 17 },
                new Attribute { Name = "INT", Value = 5 },
                new Attribute { Name = "WIS", Value = 12 },
                new Attribute { Name = "CHA", Value = 6 },
            }
        });
        #endregion
        #region S
        All.Add(new Character() {
            Name = "Sea Spawn",
            Ac = 11 ,
            Hp = 32 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary-su#SeaSpawn",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 15 },
                new Attribute { Name = "DEX", Value = 8 },
                new Attribute { Name = "CON", Value = 15 },
                new Attribute { Name = "INT", Value = 6 },
                new Attribute { Name = "WIS", Value = 10 },
                new Attribute { Name = "CHA", Value = 8 },
            }
        });
        All.Add(new Character() {
            Name = "Gloom Weaver",
            Ac = 14 ,
            Hp = 104 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary-su#GloomWeaver",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 11 },
                new Attribute { Name = "DEX", Value = 18 },
                new Attribute { Name = "CON", Value = 14 },
                new Attribute { Name = "INT", Value = 15 },
                new Attribute { Name = "WIS", Value = 12 },
                new Attribute { Name = "CHA", Value = 18 },
            }
        });
        All.Add(new Character() {
            Name = "Shadow Dancer",
            Ac = 15 ,
            Hp = 71 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary-su#ShadowDancer",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 12 },
                new Attribute { Name = "DEX", Value = 16 },
                new Attribute { Name = "CON", Value = 13 },
                new Attribute { Name = "INT", Value = 11 },
                new Attribute { Name = "WIS", Value = 12 },
                new Attribute { Name = "CHA", Value = 12 },
            }
        });
        All.Add(new Character() {
            Name = "Soul Monger",
            Ac = 15 ,
            Hp = 136 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary-su#SoulMonger",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 8 },
                new Attribute { Name = "DEX", Value = 17 },
                new Attribute { Name = "CON", Value = 14 },
                new Attribute { Name = "INT", Value = 19 },
                new Attribute { Name = "WIS", Value = 16 },
                new Attribute { Name = "CHA", Value = 13 },
            }
        });
        All.Add(new Character() {
            Name = "Shadow Mastiff",
            Ac = 12 ,
            Hp = 33 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary-su#ShadowMastiff",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 16 },
                new Attribute { Name = "DEX", Value = 14 },
                new Attribute { Name = "CON", Value = 13 },
                new Attribute { Name = "INT", Value = 5 },
                new Attribute { Name = "WIS", Value = 12 },
                new Attribute { Name = "CHA", Value = 5 },
            }
        });
        All.Add(new Character() {
            Name = "Shadow Mastiff Alpha",
            Ac = 12 ,
            Hp = 44 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary-su#ShadowMastiffAlpha",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 16 },
                new Attribute { Name = "DEX", Value = 14 },
                new Attribute { Name = "CON", Value = 13 },
                new Attribute { Name = "INT", Value = 6 },
                new Attribute { Name = "WIS", Value = 12 },
                new Attribute { Name = "CHA", Value = 5 },
            }
        });
        All.Add(new Character() {
            Name = "Shoosuva",
            Ac = 14 ,
            Hp = 136 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary-su#Shoosuva",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 18 },
                new Attribute { Name = "DEX", Value = 13 },
                new Attribute { Name = "CON", Value = 17 },
                new Attribute { Name = "INT", Value = 7 },
                new Attribute { Name = "WIS", Value = 14 },
                new Attribute { Name = "CHA", Value = 9 },
            }
        });
        All.Add(new Character() {
            Name = "Sibriex",
            Ac = 19 ,
            Hp = 150 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary-su#Sibriex",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 10 },
                new Attribute { Name = "DEX", Value = 3 },
                new Attribute { Name = "CON", Value = 23 },
                new Attribute { Name = "INT", Value = 25 },
                new Attribute { Name = "WIS", Value = 24 },
                new Attribute { Name = "CHA", Value = 25 },
            }
        });
        All.Add(new Character() {
            Name = "Skulk",
            Ac = 14 ,
            Hp = 18 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary-su#Skulk",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 6 },
                new Attribute { Name = "DEX", Value = 19 },
                new Attribute { Name = "CON", Value = 10 },
                new Attribute { Name = "INT", Value = 10 },
                new Attribute { Name = "WIS", Value = 7 },
                new Attribute { Name = "CHA", Value = 1 },
            }
        });
        All.Add(new Character() {
            Name = "Skull Lord",
            Ac = 18 ,
            Hp = 112 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary-su#SkullLord",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 14 },
                new Attribute { Name = "DEX", Value = 16 },
                new Attribute { Name = "CON", Value = 17 },
                new Attribute { Name = "INT", Value = 16 },
                new Attribute { Name = "WIS", Value = 15 },
                new Attribute { Name = "CHA", Value = 21 },
            }
        });
        All.Add(new Character() {
            Name = "Slithering Tracker",
            Ac = 14 ,
            Hp = 39 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary-su#SlitheringTracker",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 16 },
                new Attribute { Name = "DEX", Value = 19 },
                new Attribute { Name = "CON", Value = 15 },
                new Attribute { Name = "INT", Value = 10 },
                new Attribute { Name = "WIS", Value = 14 },
                new Attribute { Name = "CHA", Value = 11 },
            }
        });
        All.Add(new Character() {
            Name = "Angry Sorrowsworn",
            Ac = 18 ,
            Hp = 255 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary-su#AngrySorrowsworn",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 17 },
                new Attribute { Name = "DEX", Value = 10 },
                new Attribute { Name = "CON", Value = 19 },
                new Attribute { Name = "INT", Value = 8 },
                new Attribute { Name = "WIS", Value = 13 },
                new Attribute { Name = "CHA", Value = 6 },
            }
        });
        All.Add(new Character() {
            Name = "Hungry Sorrowsworn",
            Ac = 17 ,
            Hp = 225 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary-su#HungrySorrowsworn",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 19 },
                new Attribute { Name = "DEX", Value = 10 },
                new Attribute { Name = "CON", Value = 17 },
                new Attribute { Name = "INT", Value = 6 },
                new Attribute { Name = "WIS", Value = 11 },
                new Attribute { Name = "CHA", Value = 6 },
            }
        });
        All.Add(new Character() {
            Name = "Lonely Sorrowsworn",
            Ac = 16 ,
            Hp = 112 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary-su#LonelySorrowsworn",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 16 },
                new Attribute { Name = "DEX", Value = 12 },
                new Attribute { Name = "CON", Value = 17 },
                new Attribute { Name = "INT", Value = 6 },
                new Attribute { Name = "WIS", Value = 11 },
                new Attribute { Name = "CHA", Value = 6 },
            }
        });
        All.Add(new Character() {
            Name = "Lost Sorrowsworn",
            Ac = 15 ,
            Hp = 78 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary-su#LostSorrowsworn",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 17 },
                new Attribute { Name = "DEX", Value = 12 },
                new Attribute { Name = "CON", Value = 15 },
                new Attribute { Name = "INT", Value = 6 },
                new Attribute { Name = "WIS", Value = 7 },
                new Attribute { Name = "CHA", Value = 5 },
            }
        });
        All.Add(new Character() {
            Name = "Wretched Sorrowsworn",
            Ac = 15 ,
            Hp = 10 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary-su#WretchedSorrowsworn",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 7 },
                new Attribute { Name = "DEX", Value = 12 },
                new Attribute { Name = "CON", Value = 9 },
                new Attribute { Name = "INT", Value = 5 },
                new Attribute { Name = "WIS", Value = 6 },
                new Attribute { Name = "CHA", Value = 5 },
            }
        });
        All.Add(new Character() {
            Name = "Spawn of Kyuss",
            Ac = 10 ,
            Hp = 76 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary-su#SpawnofKyuss",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 16 },
                new Attribute { Name = "DEX", Value = 11 },
                new Attribute { Name = "CON", Value = 18 },
                new Attribute { Name = "INT", Value = 5 },
                new Attribute { Name = "WIS", Value = 7 },
                new Attribute { Name = "CHA", Value = 3 },
            }
        });
        All.Add(new Character() {
            Name = "Star Spawn Grue",
            Ac = 11 ,
            Hp = 17 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary-su#StarSpawnGrue",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 6 },
                new Attribute { Name = "DEX", Value = 13 },
                new Attribute { Name = "CON", Value = 10 },
                new Attribute { Name = "INT", Value = 9 },
                new Attribute { Name = "WIS", Value = 11 },
                new Attribute { Name = "CHA", Value = 6 },
            }
        });
        All.Add(new Character() {
            Name = "Star Spawn Hulk",
            Ac = 16 ,
            Hp = 136 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary-su#StarSpawnHulk",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 20 },
                new Attribute { Name = "DEX", Value = 8 },
                new Attribute { Name = "CON", Value = 21 },
                new Attribute { Name = "INT", Value = 7 },
                new Attribute { Name = "WIS", Value = 12 },
                new Attribute { Name = "CHA", Value = 9 },
            }
        });
        All.Add(new Character() {
            Name = "Star Spawn Larva Mage",
            Ac = 16 ,
            Hp = 168 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary-su#StarSpawnLarvaMage",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 17 },
                new Attribute { Name = "DEX", Value = 12 },
                new Attribute { Name = "CON", Value = 23 },
                new Attribute { Name = "INT", Value = 18 },
                new Attribute { Name = "WIS", Value = 12 },
                new Attribute { Name = "CHA", Value = 16 },
            }
        });
        All.Add(new Character() {
            Name = "Star Spawn Mangler",
            Ac = 14 ,
            Hp = 71 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary-su#StarSpawnMangler",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 8 },
                new Attribute { Name = "DEX", Value = 18 },
                new Attribute { Name = "CON", Value = 12 },
                new Attribute { Name = "INT", Value = 11 },
                new Attribute { Name = "WIS", Value = 12 },
                new Attribute { Name = "CHA", Value = 7 },
            }
        });
        All.Add(new Character() {
            Name = "Star Spawn Seer",
            Ac = 17 ,
            Hp = 153 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary-su#StarSpawnSeer",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 14 },
                new Attribute { Name = "DEX", Value = 12 },
                new Attribute { Name = "CON", Value = 18 },
                new Attribute { Name = "INT", Value = 22 },
                new Attribute { Name = "WIS", Value = 19 },
                new Attribute { Name = "CHA", Value = 16 },
            }
        });
        All.Add(new Character() {
            Name = "Female Steeder",
            Ac = 14 ,
            Hp = 30 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary-su#FemaleSteeder",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 15 },
                new Attribute { Name = "DEX", Value = 16 },
                new Attribute { Name = "CON", Value = 14 },
                new Attribute { Name = "INT", Value = 2 },
                new Attribute { Name = "WIS", Value = 10 },
                new Attribute { Name = "CHA", Value = 3 },
            }
        });
        All.Add(new Character() {
            Name = "Male Steeder",
            Ac = 12 ,
            Hp = 13 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary-su#MaleSteeder",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 15 },
                new Attribute { Name = "DEX", Value = 12 },
                new Attribute { Name = "CON", Value = 14 },
                new Attribute { Name = "INT", Value = 2 },
                new Attribute { Name = "WIS", Value = 10 },
                new Attribute { Name = "CHA", Value = 3 },
            }
        });
        All.Add(new Character() {
            Name = "Steel Predator",
            Ac = 20 ,
            Hp = 207 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary-su#SteelPredator",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 24 },
                new Attribute { Name = "DEX", Value = 17 },
                new Attribute { Name = "CON", Value = 22 },
                new Attribute { Name = "INT", Value = 4 },
                new Attribute { Name = "WIS", Value = 14 },
                new Attribute { Name = "CHA", Value = 6 },
            }
        });
        All.Add(new Character() {
            Name = "Stone Cursed",
            Ac = 17 ,
            Hp = 19 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary-su#StoneCursed",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 16 },
                new Attribute { Name = "DEX", Value = 5 },
                new Attribute { Name = "CON", Value = 14 },
                new Attribute { Name = "INT", Value = 5 },
                new Attribute { Name = "WIS", Value = 8 },
                new Attribute { Name = "CHA", Value = 7 },
            }
        });
        All.Add(new Character() {
            Name = "Stone Giant Dreamwalker",
            Ac = 18 ,
            Hp = 161 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary-su#StoneGiantDreamwalker",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 23 },
                new Attribute { Name = "DEX", Value = 14 },
                new Attribute { Name = "CON", Value = 21 },
                new Attribute { Name = "INT", Value = 10 },
                new Attribute { Name = "WIS", Value = 8 },
                new Attribute { Name = "CHA", Value = 12 },
            }
        });
        All.Add(new Character() {
            Name = "Storm Giant Quintessent",
            Ac = 12 ,
            Hp = 230 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary-su#StormGiantQuintessent",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 29 },
                new Attribute { Name = "DEX", Value = 14 },
                new Attribute { Name = "CON", Value = 20 },
                new Attribute { Name = "INT", Value = 17 },
                new Attribute { Name = "WIS", Value = 20 },
                new Attribute { Name = "CHA", Value = 19 },
            }
        });
        All.Add(new Character() {
            Name = "Swarm of Rot Grubs",
            Ac = 8 ,
            Hp = 22 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary-su#SwarmofRotGrubs",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 2 },
                new Attribute { Name = "DEX", Value = 7 },
                new Attribute { Name = "CON", Value = 10 },
                new Attribute { Name = "INT", Value = 1 },
                new Attribute { Name = "WIS", Value = 2 },
                new Attribute { Name = "CHA", Value = 1 },
            }
        });
        All.Add(new Character() {
            Name = "Swashbuckler",
            Ac = 17 ,
            Hp = 66 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary-su#Swashbuckler",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 12 },
                new Attribute { Name = "DEX", Value = 18 },
                new Attribute { Name = "CON", Value = 12 },
                new Attribute { Name = "INT", Value = 14 },
                new Attribute { Name = "WIS", Value = 21 },
                new Attribute { Name = "CHA", Value = 15 },
            }
        });
        All.Add(new Character() {
            Name = "Sword Wraiths Commander",
            Ac = 18 ,
            Hp = 127 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary-su#SwordWraithCommander",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 18 },
                new Attribute { Name = "DEX", Value = 14 },
                new Attribute { Name = "CON", Value = 18 },
                new Attribute { Name = "INT", Value = 11 },
                new Attribute { Name = "WIS", Value = 12 },
                new Attribute { Name = "CHA", Value = 14 },
            }
        });
        All.Add(new Character() {
            Name = "Sword Wraiths Warrior",
            Ac = 16 ,
            Hp = 45 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary-su#SwordWraithWarrior",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 18 },
                new Attribute { Name = "DEX", Value = 12 },
                new Attribute { Name = "CON", Value = 17 },
                new Attribute { Name = "INT", Value = 6 },
                new Attribute { Name = "WIS", Value = 9 },
                new Attribute { Name = "CHA", Value = 10 },
            }
        });
        #endregion
        #region T
        All.Add(new Character() {
            Name = "Tanarukk",
            Ac = 14 ,
            Hp = 95 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary-su#Tanarukk",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 18 },
                new Attribute { Name = "DEX", Value = 13 },
                new Attribute { Name = "CON", Value = 20 },
                new Attribute { Name = "INT", Value = 9 },
                new Attribute { Name = "WIS", Value = 9 },
                new Attribute { Name = "CHA", Value = 9 },
            }
        });
        All.Add(new Character() {
            Name = "Titivilus",
            Ac = 20 ,
            Hp = 150 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary-su#Titivilus",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 19 },
                new Attribute { Name = "DEX", Value = 22 },
                new Attribute { Name = "CON", Value = 17 },
                new Attribute { Name = "INT", Value = 24 },
                new Attribute { Name = "WIS", Value = 22 },
                new Attribute { Name = "CHA", Value = 26 },
            }
        });
        All.Add(new Character() {
            Name = "Tlincalli",
            Ac = 15 ,
            Hp = 85 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary-su#Tlincalli",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 16 },
                new Attribute { Name = "DEX", Value = 23 },
                new Attribute { Name = "CON", Value = 16 },
                new Attribute { Name = "INT", Value = 8 },
                new Attribute { Name = "WIS", Value = 12 },
                new Attribute { Name = "CHA", Value = 8 },
            }
        });
        All.Add(new Character() {
            Name = "Tortle",
            Ac = 17 ,
            Hp = 22 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary-su#Tortle",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 15 },
                new Attribute { Name = "DEX", Value = 10 },
                new Attribute { Name = "CON", Value = 12 },
                new Attribute { Name = "INT", Value = 11 },
                new Attribute { Name = "WIS", Value = 13 },
                new Attribute { Name = "CHA", Value = 12 },
            }
        });
        All.Add(new Character() {
            Name = "Tortle Druid",
            Ac = 17 ,
            Hp = 33 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary-su#TortleDruid",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 14 },
                new Attribute { Name = "DEX", Value = 10 },
                new Attribute { Name = "CON", Value = 12 },
                new Attribute { Name = "INT", Value = 11 },
                new Attribute { Name = "WIS", Value = 15 },
                new Attribute { Name = "CHA", Value = 12 },
            }
        });
        All.Add(new Character() {
            Name = "Trapper",
            Ac = 13 ,
            Hp = 68 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary-su#Trapper",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 17 },
                new Attribute { Name = "DEX", Value = 10 },
                new Attribute { Name = "CON", Value = 17 },
                new Attribute { Name = "INT", Value = 2 },
                new Attribute { Name = "WIS", Value = 13 },
                new Attribute { Name = "CHA", Value = 4 },
            }
        });
        All.Add(new Character() {
            Name = "Dire Troll",
            Ac = 15 ,
            Hp = 172 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary-su#DireTroll",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 22 },
                new Attribute { Name = "DEX", Value = 15 },
                new Attribute { Name = "CON", Value = 21 },
                new Attribute { Name = "INT", Value = 9 },
                new Attribute { Name = "WIS", Value = 11 },
                new Attribute { Name = "CHA", Value = 5 },
            }
        });
        All.Add(new Character() {
            Name = "Rot Troll",
            Ac = 16 ,
            Hp = 138 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary-su#RotTroll",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 18 },
                new Attribute { Name = "DEX", Value = 13 },
                new Attribute { Name = "CON", Value = 22 },
                new Attribute { Name = "INT", Value = 5 },
                new Attribute { Name = "WIS", Value = 8 },
                new Attribute { Name = "CHA", Value = 5 },
            }
        });
        All.Add(new Character() {
            Name = "Spirit Troll",
            Ac = 17 ,
            Hp = 130 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary-su#SpiritTroll",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 1 },
                new Attribute { Name = "DEX", Value = 17 },
                new Attribute { Name = "CON", Value = 13 },
                new Attribute { Name = "INT", Value = 8 },
                new Attribute { Name = "WIS", Value = 9 },
                new Attribute { Name = "CHA", Value = 16 },
            }
        });
        All.Add(new Character() {
            Name = "Venom Troll",
            Ac = 15 ,
            Hp = 94 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary-su#VenomTroll",
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
        #endregion
        #region U
        All.Add(new Character() {
            Name = "Ulitharid",
            Ac = 15 ,
            Hp = 127 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary-su#Ulitharid",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 15 },
                new Attribute { Name = "DEX", Value = 12 },
                new Attribute { Name = "CON", Value = 15 },
                new Attribute { Name = "INT", Value = 21 },
                new Attribute { Name = "WIS", Value = 19 },
                new Attribute { Name = "CHA", Value = 21 },
            }
        });
        #endregion
        #region V
        All.Add(new Character() {
            Name = "Vampiric Mist",
            Ac = 13 ,
            Hp = 30 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary-vz#VampiricMist",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 6 },
                new Attribute { Name = "DEX", Value = 16 },
                new Attribute { Name = "CON", Value = 16 },
                new Attribute { Name = "INT", Value = 6 },
                new Attribute { Name = "WIS", Value = 12 },
                new Attribute { Name = "CHA", Value = 7 },
            }
        });
        All.Add(new Character() {
            Name = "Vargouille",
            Ac = 12 ,
            Hp = 18 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary-vz#Vargouille",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 6 },
                new Attribute { Name = "DEX", Value = 14 },
                new Attribute { Name = "CON", Value = 14 },
                new Attribute { Name = "INT", Value = 4 },
                new Attribute { Name = "WIS", Value = 7 },
                new Attribute { Name = "CHA", Value = 2 },
            }
        });
        All.Add(new Character() {
            Name = "Vegepygmy",
            Ac = 13 ,
            Hp = 13 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary-vz#Vegepygmy",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 7 },
                new Attribute { Name = "DEX", Value = 14 },
                new Attribute { Name = "CON", Value = 13 },
                new Attribute { Name = "INT", Value = 6 },
                new Attribute { Name = "WIS", Value = 11 },
                new Attribute { Name = "CHA", Value = 7 },
            }
        });
        All.Add(new Character() {
            Name = "Vegepygmy Chief",
            Ac = 14 ,
            Hp = 33 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary-vz#VegepygmyChief",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 14 },
                new Attribute { Name = "DEX", Value = 14 },
                new Attribute { Name = "CON", Value = 14 },
                new Attribute { Name = "INT", Value = 7 },
                new Attribute { Name = "WIS", Value = 12 },
                new Attribute { Name = "CHA", Value = 9 },
            }
        });
        All.Add(new Character() {
            Name = "Thorny Vegepygmy",
            Ac = 14 ,
            Hp = 27 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary-vz#ThornyVegepygmy",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 13 },
                new Attribute { Name = "DEX", Value = 12 },
                new Attribute { Name = "CON", Value = 13 },
                new Attribute { Name = "INT", Value = 2 },
                new Attribute { Name = "WIS", Value = 10 },
                new Attribute { Name = "CHA", Value = 6 },
            }
        });
        #endregion
        #region W
        All.Add(new Character() {
            Name = "War Priest",
            Ac = 18 ,
            Hp = 117 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary-vz#WarPriest",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 16 },
                new Attribute { Name = "DEX", Value = 10 },
                new Attribute { Name = "CON", Value = 14 },
                new Attribute { Name = "INT", Value = 11 },
                new Attribute { Name = "WIS", Value = 17 },
                new Attribute { Name = "CHA", Value = 13 },
            }
        });
        All.Add(new Character() {
            Name = "Warlock of the Archfey",
            Ac = 13 ,
            Hp = 67 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary-vz#WarlockoftheArchfey",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 9 },
                new Attribute { Name = "DEX", Value = 16 },
                new Attribute { Name = "CON", Value = 11 },
                new Attribute { Name = "INT", Value = 11 },
                new Attribute { Name = "WIS", Value = 12 },
                new Attribute { Name = "CHA", Value = 18 },
            }
        });
        All.Add(new Character() {
            Name = "Warlock of the Fiend",
            Ac = 13 ,
            Hp = 78 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary-vz#WarlockoftheFiend",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 10 },
                new Attribute { Name = "DEX", Value = 16 },
                new Attribute { Name = "CON", Value = 15 },
                new Attribute { Name = "INT", Value = 12 },
                new Attribute { Name = "WIS", Value = 12 },
                new Attribute { Name = "CHA", Value = 18 },
            }
        });
        All.Add(new Character() {
            Name = "Warlock of the Great Old One",
            Ac = 13 ,
            Hp = 91 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary-vz#WarlockoftheGreatOldOne",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 9 },
                new Attribute { Name = "DEX", Value = 16 },
                new Attribute { Name = "CON", Value = 15 },
                new Attribute { Name = "INT", Value = 12 },
                new Attribute { Name = "WIS", Value = 12 },
                new Attribute { Name = "CHA", Value = 18 },
            }
        });
        All.Add(new Character() {
            Name = "Warlord",
            Ac = 18 ,
            Hp = 229 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary-vz#Warlord",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 20 },
                new Attribute { Name = "DEX", Value = 16 },
                new Attribute { Name = "CON", Value = 18 },
                new Attribute { Name = "INT", Value = 12 },
                new Attribute { Name = "WIS", Value = 12 },
                new Attribute { Name = "CHA", Value = 18 },
            }
        });
        All.Add(new Character() {
            Name = "Wastrilith",
            Ac = 18 ,
            Hp = 157 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary-vz#Wastrilith",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 19 },
                new Attribute { Name = "DEX", Value = 18 },
                new Attribute { Name = "CON", Value = 21 },
                new Attribute { Name = "INT", Value = 19 },
                new Attribute { Name = "WIS", Value = 12 },
                new Attribute { Name = "CHA", Value = 14 },
            }
        });
        All.Add(new Character() {
            Name = "Apprentice Wizard",
            Ac = 10 ,
            Hp = 13 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary-vz#ApprenticeWizard",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 10 },
                new Attribute { Name = "DEX", Value = 10 },
                new Attribute { Name = "CON", Value = 10 },
                new Attribute { Name = "INT", Value = 14 },
                new Attribute { Name = "WIS", Value = 10 },
                new Attribute { Name = "CHA", Value = 1 },
            }
        });
        All.Add(new Character() {
            Name = "Abjurer Wizard",
            Ac = 12 ,
            Hp = 104 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary-vz#AbjurerWizard",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 9 },
                new Attribute { Name = "DEX", Value = 14 },
                new Attribute { Name = "CON", Value = 14 },
                new Attribute { Name = "INT", Value = 18 },
                new Attribute { Name = "WIS", Value = 12 },
                new Attribute { Name = "CHA", Value = 11 },
            }
        });
        All.Add(new Character() {
            Name = "Conjurer Wizard",
            Ac = 12 ,
            Hp = 58 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary-vz#ConjurerWizard",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 9 },
                new Attribute { Name = "DEX", Value = 14 },
                new Attribute { Name = "CON", Value = 11 },
                new Attribute { Name = "INT", Value = 17 },
                new Attribute { Name = "WIS", Value = 12 },
                new Attribute { Name = "CHA", Value = 11 },
            }
        });
        All.Add(new Character() {
            Name = "Diviner Wizard",
            Ac = 12 ,
            Hp = 90 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary-vz#DivinerWizard",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 9 },
                new Attribute { Name = "DEX", Value = 14 },
                new Attribute { Name = "CON", Value = 11 },
                new Attribute { Name = "INT", Value = 18 },
                new Attribute { Name = "WIS", Value = 12 },
                new Attribute { Name = "CHA", Value = 11 },
            }
        });
        All.Add(new Character() {
            Name = "Enchanter Wizard",
            Ac = 12 ,
            Hp = 49 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary-vz#EnchanterWizard",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 9 },
                new Attribute { Name = "DEX", Value = 14 },
                new Attribute { Name = "CON", Value = 11 },
                new Attribute { Name = "INT", Value = 17 },
                new Attribute { Name = "WIS", Value = 12 },
                new Attribute { Name = "CHA", Value = 11 },
            }
        });
        All.Add(new Character() {
            Name = "Evoker Wizard",
            Ac = 12 ,
            Hp = 121 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary-vz#EvokerWizard",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 9 },
                new Attribute { Name = "DEX", Value = 14 },
                new Attribute { Name = "CON", Value = 12 },
                new Attribute { Name = "INT", Value = 17 },
                new Attribute { Name = "WIS", Value = 12 },
                new Attribute { Name = "CHA", Value = 11 },
            }
        });
        All.Add(new Character() {
            Name = "Illusionist Wizard",
            Ac = 12 ,
            Hp = 44 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary-vz#IllusionistWizard",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 9 },
                new Attribute { Name = "DEX", Value = 14 },
                new Attribute { Name = "CON", Value = 13 },
                new Attribute { Name = "INT", Value = 16 },
                new Attribute { Name = "WIS", Value = 11 },
                new Attribute { Name = "CHA", Value = 12 },
            }
        });
        All.Add(new Character() {
            Name = "Necromancer Wizard",
            Ac = 12 ,
            Hp = 110 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary-vz#NecromancerWizard",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 9 },
                new Attribute { Name = "DEX", Value = 14 },
                new Attribute { Name = "CON", Value = 12 },
                new Attribute { Name = "INT", Value = 17 },
                new Attribute { Name = "WIS", Value = 12 },
                new Attribute { Name = "CHA", Value = 11 },
            }
        });
        All.Add(new Character() {
            Name = "Transmuter Wizard",
            Ac = 12 ,
            Hp = 49 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary-vz#TransmuterWizard",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 9 },
                new Attribute { Name = "DEX", Value = 14 },
                new Attribute { Name = "CON", Value = 11 },
                new Attribute { Name = "INT", Value = 17 },
                new Attribute { Name = "WIS", Value = 12 },
                new Attribute { Name = "CHA", Value = 11 },
            }
        });
        All.Add(new Character() {
            Name = "Wood Woad",
            Ac = 10 ,
            Hp = 75 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary-vz#WoodWoad",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 18 },
                new Attribute { Name = "DEX", Value = 12 },
                new Attribute { Name = "CON", Value = 16 },
                new Attribute { Name = "INT", Value = 10 },
                new Attribute { Name = "WIS", Value = 13 },
                new Attribute { Name = "CHA", Value = 8 },
            }
        });
        #endregion
        #region X
        All.Add(new Character() {
            Name = "Xvarts",
            Ac = 13 ,
            Hp = 7 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary-vz#Xvart",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 8 },
                new Attribute { Name = "DEX", Value = 14 },
                new Attribute { Name = "CON", Value = 10 },
                new Attribute { Name = "INT", Value = 8 },
                new Attribute { Name = "WIS", Value = 7 },
                new Attribute { Name = "CHA", Value = 7 },
            }
        });
        All.Add(new Character() {
            Name = "Xvart Warlock of Raxivort",
            Ac = 12 ,
            Hp = 22 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary-vz#XvartWarlockofRaxivort",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 8 },
                new Attribute { Name = "DEX", Value = 14 },
                new Attribute { Name = "CON", Value = 12 },
                new Attribute { Name = "INT", Value = 8 },
                new Attribute { Name = "WIS", Value = 11 },
                new Attribute { Name = "CHA", Value = 12 },
            }
        });
        #endregion
        #region Y
        All.Add(new Character() {
            Name = "Yagnoloth",
            Ac = 17 ,
            Hp = 147 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary-vz#Yagnoloth",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 19 },
                new Attribute { Name = "DEX", Value = 14 },
                new Attribute { Name = "CON", Value = 21 },
                new Attribute { Name = "INT", Value = 16 },
                new Attribute { Name = "WIS", Value = 15 },
                new Attribute { Name = "CHA", Value = 18 },
            }
        });
        All.Add(new Character() {
            Name = "Yeenoghu",
            Ac = 20 ,
            Hp = 333 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary-vz#Yeenoghu",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 29 },
                new Attribute { Name = "DEX", Value = 16 },
                new Attribute { Name = "CON", Value = 26 },
                new Attribute { Name = "INT", Value = 16 },
                new Attribute { Name = "WIS", Value = 24 },
                new Attribute { Name = "CHA", Value = 15 },
            }
        });
        All.Add(new Character() {
            Name = "Yeth Hound",
            Ac = 14 ,
            Hp = 51 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary-vz#YethHound",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 18 },
                new Attribute { Name = "DEX", Value = 17 },
                new Attribute { Name = "CON", Value = 16 },
                new Attribute { Name = "INT", Value = 5 },
                new Attribute { Name = "WIS", Value = 12 },
                new Attribute { Name = "CHA", Value = 7 },
            }
        });
        All.Add(new Character() {
            Name = "Yuan-ti Anathema",
            Ac = 16 ,
            Hp = 189 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary-vz#YuantiAnathema",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 23 },
                new Attribute { Name = "DEX", Value = 13 },
                new Attribute { Name = "CON", Value = 19 },
                new Attribute { Name = "INT", Value = 19 },
                new Attribute { Name = "WIS", Value = 17 },
                new Attribute { Name = "CHA", Value = 20 },
            }
        });
        All.Add(new Character() {
            Name = "Yuan-ti Broodguard",
            Ac = 14 ,
            Hp = 45 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary-vz#YuantiBroodguard",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 15 },
                new Attribute { Name = "DEX", Value = 14 },
                new Attribute { Name = "CON", Value = 14 },
                new Attribute { Name = "INT", Value = 6 },
                new Attribute { Name = "WIS", Value = 11 },
                new Attribute { Name = "CHA", Value = 4 },
            }
        });
        All.Add(new Character() {
            Name = "Yuan-ti Mind Whisperer",
            Ac = 14 ,
            Hp = 71 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary-vz#YuantiMindWhisperer",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 16 },
                new Attribute { Name = "DEX", Value = 14 },
                new Attribute { Name = "CON", Value = 13 },
                new Attribute { Name = "INT", Value = 14 },
                new Attribute { Name = "WIS", Value = 14 },
                new Attribute { Name = "CHA", Value = 16 },
            }
        });
        All.Add(new Character() {
            Name = "Yuan-ti Nightmare Speaker",
            Ac = 14 ,
            Hp = 71 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary-vz#YuantiNightmareSpeaker",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 16 },
                new Attribute { Name = "DEX", Value = 14 },
                new Attribute { Name = "CON", Value = 13 },
                new Attribute { Name = "INT", Value = 14 },
                new Attribute { Name = "WIS", Value = 12 },
                new Attribute { Name = "CHA", Value = 16 },
            }
        });
        All.Add(new Character() {
            Name = "Yuan-ti Pit Master",
            Ac = 14 ,
            Hp = 88 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary-vz#YuantiPitMaster",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 16 },
                new Attribute { Name = "DEX", Value = 14 },
                new Attribute { Name = "CON", Value = 13 },
                new Attribute { Name = "INT", Value = 14 },
                new Attribute { Name = "WIS", Value = 12 },
                new Attribute { Name = "CHA", Value = 16 },
            }
        });
        #endregion
        #region Z
        All.Add(new Character() {
            Name = "Zaratan",
            Ac = 21 ,
            Hp = 307 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary-vz#Zaratan",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 30 },
                new Attribute { Name = "DEX", Value = 10 },
                new Attribute { Name = "CON", Value = 30 },
                new Attribute { Name = "INT", Value = 2 },
                new Attribute { Name = "WIS", Value = 21 },
                new Attribute { Name = "CHA", Value = 18 },
            }
        });
        All.Add(new Character() {
            Name = "Zariel",
            Ac = 21 ,
            Hp = 420 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary-vz#Zariel",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 27 },
                new Attribute { Name = "DEX", Value = 24 },
                new Attribute { Name = "CON", Value = 28 },
                new Attribute { Name = "INT", Value = 26 },
                new Attribute { Name = "WIS", Value = 27 },
                new Attribute { Name = "CHA", Value = 30 },
            }
        });
        All.Add(new Character() {
            Name = "Zuggtmoy",
            Ac = 18 ,
            Hp = 304 ,
            Links = new ExternalLinks {
                DataSheetUrl = "https://www.dndbeyond.com/sources/motm/bestiary-vz#Zuggtmoy",
                // IconUrl = ""
            },
            Attributes = new List<Attribute>{
                new Attribute { Name = "STR", Value = 22 },
                new Attribute { Name = "DEX", Value = 15 },
                new Attribute { Name = "CON", Value = 18 },
                new Attribute { Name = "INT", Value = 20 },
                new Attribute { Name = "WIS", Value = 19 },
                new Attribute { Name = "CHA", Value = 24 },
            }
        });
        #endregion
    }
}

}