public partial class Person
{
    static private int GLOBAL_ID = 0;

    int Id;
    string IdentificationCode;
    string PassportNumber;
    string Name;
    string Surname;
    string PhoneNumber;
    string Gmail;
    string Sex;
    string BirthDate;

    public Person()
    {
        this.Id = ++GLOBAL_ID;
        this.IdentificationCode = string.Empty;
        this.PassportNumber = string.Empty;
        this.Name = string.Empty;
        this.Surname = string.Empty;
        this.PhoneNumber = string.Empty;
        this.Gmail = string.Empty;
        this.Sex = string.Empty;
        this.BirthDate = string.Empty;
    }

    public Person(string identificationCode, string passportNumber, string name, string surname, string phoneNumber, string gmail, string sex, string birthDate)
    {
        this.Id = ++GLOBAL_ID;
        this.IdentificationCode = identificationCode;
        this.PassportNumber = passportNumber;
        this.Name = name;
        this.Surname = surname;
        this.PhoneNumber = phoneNumber;
        this.Gmail = gmail;
        this.Sex = sex;
        this.BirthDate = birthDate;
    }

    public int GetId()
    { return Id; }
    public string GetIdentificationCode()
    { return IdentificationCode; }
    public string GetPassportNumber()
    { return PassportNumber; }
    public string GetName()
    { return Name; }
    public string GetSurname()
    { return Surname; }
    public string GetPhoneNumber()
    { return PhoneNumber; }
    public string GetGmail()
    { return Gmail; }
    public string GetSex()
    { return Sex; }
    public string GetBirthDate()
    { return BirthDate; }

    public void SetIdentificationCode(string identificationCode)
    { this.IdentificationCode = identificationCode; }
    public void SetPassportNumber(string passportNumber)
    { this.PassportNumber = passportNumber; }
    public void SetName(string name)
    { this.Name = name; }
    public void SetSurname(string surname)
    { this.Surname = surname; }
    public void SetPhoneNumber(string phoneNumber)
    { this.PhoneNumber = phoneNumber; }
    public void SetGmail(string gmail)
    { this.Gmail = gmail; }
    public void SetSex(string sex)
    { this.Sex = sex; }
    public void SetBirthDate(string birthDate)
    { this.BirthDate = birthDate; }
}