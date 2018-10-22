using MilitaryElite.Interfaces;
using System;

namespace MilitaryElite.Models
{
    public class Mission : IMission
    {
        private string missionName;
        private string state;

        public string MissionName => this.missionName;

        public string State
        {
            get => this.state;
            private set
            {
                if (value != "inProgress" && value != "Finished")
                {
                    throw new ArgumentException();
                }
                this.state = value;
            }
        }

        public Mission(string missionName, string state)
        {
            this.missionName = missionName;
            State = state;
        }

        public void CompleteMission()
        {
            State = "Finished";
        }

        public override string ToString()
        {
            return $"Code Name: {MissionName} State: {State}";
        }
    }
}
