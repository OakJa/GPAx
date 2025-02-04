using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gpax
{
    // The Gpax namespace contains all the classes related to GPA calculation and the main form.
    
    // Class to calculate GPA
    public class GPAcalculator
    {
        +----------------------+
         |     GPAcalculator    |

         | - gpa_sum: double   |
         | - n: double         |
         | - gpa_min: double   |
         | - gpa_max: double   |
         | - gpas: List<double>|
         +----------------------+
         | + setGpa(double)    |
         | + getGpa(): double  |
         | + GetMaxGPA(): double |
         | + GetMinGPA(): double |
        +----------------------+

                 ⬇ (Uses)

         +----------------------+
         |        Form1        |
         +----------------------+
         | - gpa: GPAcalculator |
         +----------------------+
         | + Form1()           |
         | + btnAdd_Click(...) |
         +----------------------+
         GPAcalculator: คลาสที่ใช้จัดเก็บและคำนวณค่า GPA (ค่าเฉลี่ย, ค่าสูงสุด, ค่าต่ำสุด)
         Form1: คลาส UI ที่ใช้งาน GPAcalculator เพื่อรับค่าจากผู้ใช้และแสดงผล

    }
}
