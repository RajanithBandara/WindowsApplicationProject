using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsAppProject.Apps.students_chart
{
    public class student_progess
    {
        public string Location { get; set; }
        public decimal sem1 { get; set; }
        public decimal sem2 { get; set; }
        public decimal sem3 { get; set; }
        public decimal sem4 { get; set; }
        public decimal sem5 { get; set; }
        public decimal sem6 { get; set; }
        public decimal sem7 { get; set; }
        public decimal sem8 { get; set; }
        public object this[string propertyName] 
        {
            get {return this.GetType().GetProperty(propertyName).GetValue(this, null); }
            set { this.GetType().GetProperty(propertyName).SetValue(this, value, null); }
        }

    }
}
