using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text.Json.Serialization;

namespace InitiativeTracker.Data {

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum CharacterKind {
    NPC, 
    Player,
}


public class TeamConverter : TypeConverter {
    public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) {
        if (sourceType == typeof(string))
            return true;

        return base.CanConvertFrom(context, sourceType);
    }
    public override object ConvertFrom(ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value) {
        if (value.GetType() == typeof(string)) {
            var existing = Team.Teams.Where(t => t.Name == (string)value).FirstOrDefault();
            return existing ?? new Team { Name = (string)value, ColourCode = (string)value};
        }

        return base.ConvertFrom(context, culture, value);
    }

    public override bool CanConvertTo(ITypeDescriptorContext context, Type targetType) {
        return (targetType == typeof(string));
    }
    public override object ConvertTo(ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, Type targetType) {
        return ((Team)value).Name;
    }
}

[TypeConverterAttribute(typeof(TeamConverter))]
public class Team {
    public string Name {get; set;}
    public string ColourCode {get; set;}

    public static Team[] Teams = new Team[] {
        new Team { Name= "blue",   ColourCode= "#95E0E8"}, 
        new Team { Name= "green",  ColourCode= "lime"}, 
        new Team { Name= "red",    ColourCode= "red"}, 
        new Team { Name= "yellow", ColourCode= "#FFD12A"}, 
        new Team { Name= "purple", ColourCode= "#DB91EF"},
    };
}

public class Attribute {
    public string IconUrl {get; set;}
    public string Name {get; set;}
    public int Value {get; set;}
}

public class ExternalLinks {
    public string IconUrl {get; set;}
    public string DataSheetUrl {get; set;}
}

public class Class {
    public int Level {get; set;}
    public string Name {get; set;}

    public override string ToString() => $"Lvl.{Level} {Name}";
}

public class Character {
    public CharacterKind Kind {get; set;}
    public Team Team {get; set;} = Team.Teams[0];
    private List<Class> _classes;
    public List<Class> Classes {
        get {
            if (_classes == null)
                _classes = new List<Class>();
            return _classes;
        } 
        set {
            if (value == null)
                value = new List<Class>();
            _classes = value;
        }
    }
    private ExternalLinks _links;
    public ExternalLinks Links {
        get {
            if (_links == null)
                _links = new ExternalLinks();
            return _links;
        } 
        set {
            if (value == null)
                value = new ExternalLinks();
            _links = value;
        }
    }
    public string Name {get; set;}
    public int Hp {get; set;}
    public int Ac {get; set;}
    public int Initiative {get; set;}
    public bool IsTurn {get; set;}

    public List<Attribute> Attributes {get; set;} = new List<Attribute> {
        new Attribute { Name = "STR", Value = 0 },
        new Attribute { Name = "DEX", Value = 0 },
        new Attribute { Name = "CON", Value = 0 },
        new Attribute { Name = "INT", Value = 0 },
        new Attribute { Name = "WIS", Value = 0 },
        new Attribute { Name = "CHA", Value = 0 },
    };

    public Character Clone() {
        return new Character {
            Kind = this.Kind,
            Team = this.Team,
            Classes = this.Classes.Select(cls => new Class { Name = cls.Name, Level = cls.Level }).ToList(),
            Links = new ExternalLinks {
                IconUrl = this.Links.IconUrl,
                DataSheetUrl = this.Links.DataSheetUrl,
            },
            Name = this.Name,
            Hp = this.Hp,
            Ac = this.Ac,
            Initiative = this.Initiative,
            IsTurn = this.IsTurn,

            Attributes = this.Attributes.Select(attr => new Attribute{ Name = attr.Name, Value = attr.Value }).ToList()
        };
    }
    public Character CloneAs(CharacterKind kind, Team team) {
        var clone = this.Clone();
        clone.Kind = kind;
        clone.Team = team;
        return clone;
    }
}

}