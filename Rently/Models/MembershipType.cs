using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Rently.Models
{
    public class MembershipType
    {
        public byte Id { get; set; }
        public short SignupFee { get; set; }
        public byte DurationInMonths { get; set; }
        public byte DiscountRate { get; set; }
        public string MembershipTypeName { get; set; }

        public static readonly byte Unknown = 0;
        public static readonly byte PayAsYouGo = 1;


    }
}