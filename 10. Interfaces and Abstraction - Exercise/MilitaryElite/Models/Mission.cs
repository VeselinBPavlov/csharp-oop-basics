namespace MilitaryElite.Models
{
    using MilitaryElite.Contracts;
    using MilitaryElite.Enums;

    public class Mission : IMission
    {
        private string codeName;
        private State state;       

        public string CodeName { get => codeName; private set => codeName = value; }
        public State State { get => state; private set => state = value; }

        public Mission(string codeName, State state)
        {
            this.CodeName = codeName;
            this.State = state;
        }

        public void CompleteMission()
        {
            this.State = State.Finished;
        }

        public override string ToString()
        {
            return $"Code Name: {this.CodeName} State: {this.State}";
        }
    }
}