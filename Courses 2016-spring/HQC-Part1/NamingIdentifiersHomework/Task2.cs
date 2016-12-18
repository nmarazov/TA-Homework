namespace NamingIdentifiersHomework
{
    class Hauptklasse
    {
        enum Gender { Male, Female }

        class Person
        {
            public Gender Gender { get; set; }
            public string Name { get; set; }
            public int Age { get; set; }
        }

        public void CreatePerson(int personAge)
        {
            Person newPerson = new Person();
            newPerson.Age = personAge;

            if (personAge % 2 == 0)
            {
                newPerson.Name = "Ivan";
                newPerson.Gender = Gender.Male;
            }
            else
            {
                newPerson.Name = "Penka";
                newPerson.Gender = Gender.Female;
            }
        }
    }
}
