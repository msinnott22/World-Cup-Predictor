using System;
using System.Collections.Generic;
using Data.Interfaces;

namespace Data.Dto
{
    public class Group : IEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public virtual HashSet<Team> Teams { get; set; }

        public static Guid GroupAId = new Guid("6DF192D8-2DAC-4CFA-A547-12A5B490B13F");
        public static string GroupA = "Group A";

        public static Guid GroupBId = new Guid("A1AA60D4-D266-4CE2-A595-0C23C8389535");
        public static string GroupB = "Group B";

        public static Guid GroupCId = new Guid("6A6D1BD4-A9E0-4BF5-B839-3021CFA5450C");
        public static string GroupC = "Group C";

        public static Guid GroupDId = new Guid("C4CC45AB-3A72-482C-AA08-C602A15579D6");
        public static string GroupD = "Group D";
        
        public static Guid GroupEId = new Guid("4D458FCF-EC26-4B8E-A2A7-1AE13F4EA6C6");
        public static string GroupE = "Group E";

        public static Guid GroupFId = new Guid("308D23B9-C017-4E8C-8D0C-C8FFA8714406");
        public static string GroupF = "Group F";

        public static Guid GroupGId = new Guid("532648E4-0634-43F4-AF6A-01000FEF49CE");
        public static string GroupG = "Group G";

        public static Guid GroupHId = new Guid("9158318F-5819-48F7-80CB-41DEE344345D");
        public static string GroupH = "Group H";
    }
}
