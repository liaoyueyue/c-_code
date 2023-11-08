using Experiment6.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Experiment6.dao
{
    interface StudentDao
    {
        int add(Student student);
        int delete(Student student);
        int update(Student student);
        List<Student> queryAll();
    }
}
