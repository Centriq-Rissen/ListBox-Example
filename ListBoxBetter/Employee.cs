using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1
{

    public class Employee
    {
        private int _ID;
        private string _FirstName;
        private string _LastName;
        private string _Position;
        private decimal _Salary;
        private DateTime? _TerminationDate;

        public int ID
        {
            get { return _ID; }
            set { _ID = value; }
        }

        public string FirstName
        {
            get { return _FirstName; }
            set { _FirstName = value; }
        }

        public string LastName
        {
            get { return _LastName; }
            set { _LastName = value; }
        }

        public string Position
        {
            get { return _Position; }
            set { _Position = value; }
        }

        public decimal Salary
        {
            get { return _Salary; }
            set { _Salary = value; }
        }

        public string ImageFile { get; set; }
        public byte[] Image
        {
            get
            {
                if (ImageFile != null)
                {
                    return File.ReadAllBytes(ImageFile);
                }
                else
                    return null;
            }
        }

        public DateTime? TerminationDate
        {
            get { return _TerminationDate; }
            set { _TerminationDate = value; }
        }
        public override string ToString()
        {
            return FirstName + " " + LastName;
        }
    }
}
