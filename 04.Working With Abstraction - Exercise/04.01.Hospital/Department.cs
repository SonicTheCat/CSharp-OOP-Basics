using System.Linq;
using System.Text;

class Department
{
    private string departmentName;
    private string[][] rooms;

    public string DepartmentName
    {
        get { return departmentName; }
        set { departmentName = value; }
    }

    public string[][] Rooms
    {
        get { return rooms; }
        set { rooms = value; }
    }

    public Department()
    {
        Rooms = new string[20][];
        for (int i = 0; i < 20; i++)
        {
            Rooms[i] = new string[3]; 
        }
    }

    public Department(string department, string patient)
        : this()
    {
        DepartmentName = department;      
        FindRoomForPatient(patient); 
    }

    public void FindRoomForPatient(string patientName)
    {
        for (int i = 0; i < Rooms.Length; i++)
        {
            for (int j = 0; j < Rooms[i].Length; j++)
            {
                if (Rooms[i][j] == null)
                {
                    Rooms[i][j] = patientName;
                    return;
                }
            }
        }
    }
    public string GetPatientsInRoom(int roomNumber)
    {
        return string
              .Join("\n", Rooms[roomNumber - 1]
              .Where(x => x != null)
              .OrderBy(x => x));
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        foreach (var room in Rooms)
        {
            if (room.Any(x => x != null))
            {
                sb.AppendLine(string.Join("\n", room.Where(x => x != null)));
            }
        }
        return sb.ToString();
    }
}