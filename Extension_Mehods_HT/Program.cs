
//N26 - HT2 - extension methods

//SkillLevel enum dan foydalaning
//- Beginner
//- Experienced
//- Master
//- Expert

//- Skill modelidan foydalaning(id, name, level )

//CollectionExtensions static modelidan ( class ) foydalaning

//unda quyidagi extension methodlar bo'lsin 

//- Update ( this ICollection<Skill> first, ICollection<Skill> second )

//bunda first kolleksiyadan second kolleksiyadagi ichidan quyidagi turkumdagi itemlarni topib, amallar bajarish kerak
//- added - qo'shilganlar ( second da bor, first da yo'q ) -bularni first ga qo'shish kerak
//- removed - o'chirilganlar ( second da yo'q, first da bor ) -bularni first dan o'chirish kerak
//- updated - o'zgartirilgan ( first da va second da bor va o'zgartirilgan ) -bularni first da update qilish kerak ( id dan tashqari ) 



var skill1 = new List<Skill>
{
    new Skill("Asadbek", SkillLevel.Beginner),
    new Skill("Jamshid", SkillLevel.Master),
    new Skill("Teshavoy", SkillLevel.Expert),
};
var skill2 = new List<Skill>
{
     new Skill("Isomiddin", SkillLevel.Beginner),
    new Skill("Shavkat", SkillLevel.Expert),
    new Skill("Salima", SkillLevel.Expert),
    new Skill("Qulpinissa", SkillLevel.Master),
};

skill1.Update(skill2);

foreach (var item in skill1)
{
    Console.WriteLine($"{item.Name} {item.level}");
}




public enum SkillLevel
{
    Beginner,
    Experienced,
    Master,
    Expert
}

public class Skill
{
    public Skill(string name, SkillLevel level)
    {
        Name = name;
        this.level = level;
    }

    public Guid id { get; set; }
    public string Name { get; set; }
    public SkillLevel level { get; set; }


}

static class CollectionExtensions
{
    //- Update ( this ICollection<Skill> first, ICollection<Skill> second )

    //bunda first kolleksiyadan second kolleksiyadagi ichidan quyidagi turkumdagi itemlarni topib, amallar bajarish kerak
    //- added - qo'shilganlar ( second da bor, first da yo'q ) -bularni first ga qo'shish kerak
    //- removed - o'chirilganlar ( second da yo'q, first da bor ) -bularni first dan o'chirish kerak
    //- updated - o'zgartirilgan ( first da va second da bor va o'zgartirilgan ) -bularni first da update qilish kerak ( id dan tashqari ) 

    public static void Update(this ICollection<Skill> first, ICollection<Skill> second)
    {
        var added = second.Except(first).ToList();
        var removed = first.Except(second).ToList();
        var updated = first.Intersect(second).ToList();

        foreach ( var item in added )
        {
            first.Add(item);
        }

        foreach ( var item in removed )
        {
            first.Remove(item);
        }

        foreach( var item in updated )
        {
            var updateSkill = second.First(n => n.id == item.id);
            item.Name = updateSkill.Name;
            item.level = updateSkill.level;
        }
    }
}
