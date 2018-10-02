using System.Collections.Generic;
using System.Linq;
using System.Text;

class Department
{
    private string departmentName;
    private List<Room> rooms;

    public string DepartmentName
    {
        get { return departmentName; }
        set { departmentName = value; }
    }

    public List<Room> Rooms
    {
        get { return rooms; }
        set { rooms = value; }
    }

    public Department()
    {
        Rooms = new List<Room>();
    }

    public Department(string department, string patient)
        : this()
    {
        DepartmentName = department;
        GetRoomForPatient(patient);
    }

    public void GetRoomForPatient(string patientName)
    {
        var lastRoom = this.Rooms.LastOrDefault();
        if (lastRoom?.Number == 20 && lastRoom?.Patients.Count == 3)
        {
            return;
        }

        AddNewRoomIfNeeded(lastRoom);
        lastRoom = this.Rooms.Last();
        lastRoom.Patients.Add(new Patient(patientName));
    }

    private void AddNewRoomIfNeeded(Room lastRoom)
    {
        int roomNumber = this.Rooms.Count + 1;

        if (lastRoom == null || lastRoom.Patients.Count >= 3)
        {
            this.Rooms.Add(new Room(roomNumber));
        }
    }

    public string PrintPatientsByRoom(int roomNumber)
    {
        string patients = string.Empty;
        var room = Rooms[roomNumber - 1];

        return string.Join("\n", room
             .Patients
             .OrderBy(p => p.Name)
             .Select(p => p.Name)
             .ToArray());
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        foreach (var room in Rooms)
        {
            foreach (var patient in room.Patients)
            {
                sb.AppendLine(patient.Name);
            }
        }
        return sb.ToString();
    }
}