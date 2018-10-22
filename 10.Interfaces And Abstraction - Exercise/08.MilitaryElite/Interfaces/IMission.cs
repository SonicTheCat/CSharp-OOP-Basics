namespace MilitaryElite.Interfaces
{
   public interface IMission
    {
        string MissionName { get; }
        string State { get; }

        void CompleteMission();
    }
}
