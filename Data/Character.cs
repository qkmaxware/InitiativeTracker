namespace InitiativeTracker.Data {

public enum CharacterKind {
    NPC, 
    Player,
}

public class Character {
    public CharacterKind Kind;
    public string Team = "red";
    public string Name;
    public int Hp;
    public int Ac;
    public int Initative;
    public bool IsTurn;
}

}