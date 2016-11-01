namespace HeadWorksTask.Entities
{
    public struct Student
    {
        public string Name { get; set; }
        public string SecondName { get; set; }
        public string Group { get; set; }

        public Student(string _name, string _secondName, string _group)
        {
            this.Name = _name;
            this.SecondName = _secondName;
            this.Group = _group;
        }

        public string FullStudentName
        {
            get { return this.Name + ' ' + this.SecondName + ". Group #" + this.Group; }
        }
    }
}
