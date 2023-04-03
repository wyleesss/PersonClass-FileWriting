using System;
using System.Text;

public partial class Person
{
    public void ConsoleOutput()
    {
        Console.WriteLine($"PERSON*           \t|ID::[{this.Id}]" +
            $"\nname:               \t {(this.Name == String.Empty ? "none" : this.Name)}" +
            $"\nsurname:            \t {(this.Surname == String.Empty ? "none" : this.Surname)}" +
            $"\nsex:                \t {(this.Sex == String.Empty ? "none" : this.Sex)}" +
            $"\nidentification code:\t {(this.IdentificationCode == String.Empty ? "none" : this.IdentificationCode)}" +
            $"\npassport number:    \t {(this.PassportNumber == String.Empty ? "none" : this.PassportNumber)}" +
            $"\nphone number:       \t {(this.PhoneNumber == String.Empty ? "none" : this.PhoneNumber)}" +
            $"\ngmail:              \t {(this.Gmail == String.Empty ? "none" : this.Gmail)}" +
            $"\nbirth date:         \t {(this.BirthDate == String.Empty ? "none" : this.BirthDate)}\n");
    }

    public void FileOutput(string fileDirection)
    {
        using (FileStream file = new FileStream(fileDirection, FileMode.OpenOrCreate, FileAccess.Write, FileShare.None))
        {
            string PersonInfo = ($"PERSON*           \t|ID::[{this.Id}]" +
            $"\nname:               \t {(this.Name == String.Empty ? "none" : this.Name)}" +
            $"\nsurname:            \t {(this.Surname == String.Empty ? "none" : this.Surname)}" +
            $"\nsex:                \t {(this.Sex == String.Empty ? "none" : this.Sex)}" +
            $"\nidentification code:\t {(this.IdentificationCode == String.Empty ? "none" : this.IdentificationCode)}" +
            $"\npassport number:    \t {(this.PassportNumber == String.Empty ? "none" : this.PassportNumber)}" +
            $"\nphone number:       \t {(this.PhoneNumber == String.Empty ? "none" : this.PhoneNumber)}" +
            $"\ngmail:              \t {(this.Gmail == String.Empty ? "none" : this.Gmail)}" +
            $"\nbirth date:         \t {(this.BirthDate == String.Empty ? "none" : this.BirthDate)}\n\n");

            byte[] writeBytes = Encoding.Default.GetBytes(PersonInfo);
            file.Write(writeBytes, 0, writeBytes.Length);
            file.Close();
        }
        Console.WriteLine("writed into a file successfully!\n");
    }
}