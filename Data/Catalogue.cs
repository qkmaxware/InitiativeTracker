using System.Collections.Generic;

namespace InitiativeTracker.Data {

public static partial class MonsterCatalogue {
    public static List<Character> All {get; private set;} = new List<Character>();

    static MonsterCatalogue () {
        AddBasicRules();
        AddMonstersOfTheMultiverse(); 
    }
}

}