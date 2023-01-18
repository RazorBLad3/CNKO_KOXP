using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KOXP.Common
{
    public class Party
    {
        public int MemberId { get; set; }
        public string? MemberName { get; set; }
        public int MemberClass { get; set; }
        public int MemberHp { get; set; }
        public int MemberMaxHp { get; set; }
        public int MemberBuffHp { get; set; }
        public int MemberBuffTime { get; set; }
    }
}
