namespace N12___HT1;

class User
{

    private string firstName;
    private string lastName;
    private string patronymic;

    public User(string firstName, string lastName, string patronymic)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.patronymic = patronymic;
    }


    public string FullName
    {
        get => $"{firstName} {patronymic} {lastName}";
        set
        {
            string[] names = value.Split(' ');
            if (names.Length == 3)
            {
                firstName = names[0];
                patronymic = names[1];
                lastName = names[2];
            }
            else
            {
                throw new ArgumentException("To'liq ism, sharif va familiya bo'lishi kerak.");
            }
        }
    }


    public override bool Equals(object obj)
    {
        if (obj == null)
        {
            return false;
        }

        User otherUser = (User)obj;
        return this.GetHashCode() == otherUser.GetHashCode();
    }

    public override int GetHashCode()
    {
        return (firstName + patronymic + lastName).GetHashCode();
    }
}
