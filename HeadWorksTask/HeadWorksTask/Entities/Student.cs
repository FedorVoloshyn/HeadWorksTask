namespace HeadWorksTask.Entities
{
    public struct Student
    {
        string Name { get; set; }
        string SecondName { get; set; }
        string Group { get; set; }

        public Student(string _name, string _secondName, string _group)
        {
            this.Name = _name;
            this.SecondName = _secondName;
            this.Group = _group;
        }
    }
}
