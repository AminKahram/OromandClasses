namespace ArraySample.ArrayClass
{
    public partial class Person 
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    public partial class Person : IComparable<Person>
    {
        public int CompareTo(Person? other)
        {
            if (this.Id == other.Id)
                return 0;
            else if (this.Id > other.Id)
                return 1;
            else return -1;
        }
    }
    public partial class Person : IComparer<Person>
    {

        public int Compare(Person? x, Person? y)
        {
           throw new NotImplementedException();
        }

        
    }
}
