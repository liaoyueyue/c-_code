using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Experiment6.entity
{
    class Student
    {
        int id;
        int studentid;
        string? name;
        string? gender;
        string? age;
        string? major;
        string? phone;

        public int Id { get { return id; } set { id = value; } }
        public int Studentid { get {  return studentid; } set {  studentid = value; } }
        public string? Name { get { return name; } set { name = value; } }
        public string? Gender { get {  return gender; } set {  gender = value; } }
        public string? Age { get {  return age; } set { age = value; } }
        public string? Major { get {  return major; } set { major = value; } }
        public string? Phone { get { return phone;} set { phone = value; } }
    }
}
