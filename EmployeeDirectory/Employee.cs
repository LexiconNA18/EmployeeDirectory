namespace EmployeeDirectory
{
    class Employee
    {

        public int Salary { get; set; }

        // privat underliggande fält ("backing field")
        private string name = "";

        // public egenskap
        public string Name {
            
            // getter
            get {
                return name;
            }

            // setter, value är invärdet
            set
            {
                if (value != null)
                {
                    name = value;
                }
            }
        }
        
        
        public Employee(string name, int salary)
        {
            Name = name;
            Salary = salary;
        }

        public string GetName() {
            return this.Name;
        }

        public void SetName(string name) {
            if (name != null)
            {
                this.Name = name;
            }
        }
    }
}
