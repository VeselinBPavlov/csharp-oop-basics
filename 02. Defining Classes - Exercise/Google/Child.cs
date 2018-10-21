namespace Google
{
    public class Child
    {
        // Fields.
        private string childName;
        private string childBirthday;

        // Properties.
        public string ChildName { get => childName; set => childName = value; }
        public string ChildBirthday { get => childBirthday; set => childBirthday = value; }

        // Constructor.
        public Child(string childName, string childBirthday)
        {
            this.ChildName = childName;
            this.ChildBirthday = childBirthday;
        }
    }
}
