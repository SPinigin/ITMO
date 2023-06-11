using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinCS.WinForm.Lab2.Ex9
{
    interface IPubs
    {
        void Subs();
        bool IfSubs { get; set; }
    }
}
