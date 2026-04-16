using dpiotrowski_lab2.Model.Rooms.Departments;
using System;
using System.Collections.Generic;
using System.Text;

namespace dpiotrowski_lab2.Model.Rooms
{
    public class DepartmentList : IObjectList<Department>
    {
        private Dictionary<Guid, Department> departments;
        public List<Department> Elements { get => departments.Values.ToList(); }

        public event EventHandler<Department>? ElementAdded;
        public event EventHandler<Department>? ElementRemoved;
        public event EventHandler<Department>? ElementUpdated;

        public DepartmentList()
        {
            this.departments = new Dictionary<Guid, Department>();
        }

        public Department Get(Guid elementId)
        {
            return this.departments[elementId];
        }

        public void Add(Department department)
        {
            this.departments.Add(department.Id, department);

            this.ElementAdded?.Invoke(this, department);
        }

        public void Remove(Guid departmentId)
        {
            var removed = this.departments[departmentId];

            this.departments.Remove(departmentId);

            this.ElementRemoved?.Invoke(this, removed);
        }

        public void Update(Department department)
        {
            if (!this.departments.ContainsKey(department.Id))
            {
                throw new ArgumentException($"Department with id {department.Id} does not exist.");
            }

            this.departments[department.Id] = department;

            this.ElementUpdated?.Invoke(this, department);
        }
    }
}
