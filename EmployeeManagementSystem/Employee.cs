using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem
{
    class Employee
    {
        private int EmpNo;
        private string EmpName;
        private double Salary;
        private double HRA;
        private double TA;
        private double DA;
        private double PF;
        private double TDS;
        private double NetSalary;
        private double GrossSalary;

        public int _EmpNo
        {
            get
            {
                return EmpNo;
            }
            set
            {
                EmpNo = value;
            }
        }
        public string _EmpName
        {
            get
            {
                return EmpName;
            }
            set
            {
                EmpName = value;
            }
        }
        public double _Salary
        {
            get
            {
                return Salary;
            }
            set
            {
                Salary = value;
            }
        }
        public double _HRA
        {
            get
            {
                return HRA;
            }
            set
            {
                HRA = value;
            }
        }
        public double _TA
        {
            get
            {
                return TA;
            }
            set
            {
                TA = value;
            }
        }
        public double _DA
        {
            get
            {
                return DA;
            }
            set
            {
                DA = value;
            }
        }
        public double _PF
        {
            get
            {
                return PF;
            }
            set
            {
                PF = value;
            }
        }
        public double _TDS
        {
            get
            {
                return TDS;
            }
            set
            {
                TDS = value;
            }
        }
        public double _NetSalary
        {
            get
            {
                return NetSalary;
            }
            set
            {
                NetSalary = value;
            }
        }
        public double _GrossSalary
        {
            get
            {
                return GrossSalary;
            }
            set
            {
                GrossSalary = value;
            }
        }
    }
}
