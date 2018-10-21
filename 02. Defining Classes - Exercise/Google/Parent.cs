namespace Google
{
    public class Parent
    {
        // Fields.
        private string parentName;
        private string parentBirthday;

        // Properties.
        public string ParentName { get => parentName; set => parentName = value; }
        public string ParentBirthday { get => parentBirthday; set => parentBirthday = value; }

        // Constructor.
        public Parent(string parentName, string parentBirthday)
        {
            this.ParentName = parentName;
            this.ParentBirthday = parentBirthday;
        }
    }
}
