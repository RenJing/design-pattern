namespace temp
{
    public class Employee
    {
        public EmployeeType Type { get; set; }

        public Employee(EmployeeType type)
        {
            Type = type;
        }

        public int GetSomething()
        {
            switch (Type)
            {
                case EmployeeType.normal:
                    return 1;
                case EmployeeType.manager:
                    return 2;
                default:
                    return 3;
            }
        }
    }

    public enum EmployeeType
    {
        normal, manager
    }
}
