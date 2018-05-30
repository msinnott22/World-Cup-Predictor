using System;
using System.ComponentModel.DataAnnotations;
using Data.Interfaces;

namespace Data.Dto
{
    public class Team : IEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        [MaxLength(3)]
        public string Abbreviation { get; set; }
        public Guid GroupId { get; set; }
        public virtual Group Group { get; set; }
        public int GamesPlayed { get; set; }
        public int GamesWon { get; set; }
        public int GamesDrawn { get; set; }
        public int GamesLost { get; set; }
        public int Points { get; set; }
        public int GoalsFor { get; set; }
        public int GoalsAgainst { get; set; }
        public int GoalDifference { get; set; }

        public static Guid RussiaId = new Guid("AB264F55-5310-4ADF-9F96-4ADCD96362C7");
        public static Guid SaudiArabiaId = new Guid("89B30BED-DFEE-4465-9368-5193ED5C64A9");
        public static Guid EgyptId = new Guid("7D9BD248-2B6F-4F84-822F-953160DB304E");
        public static Guid UruguayId = new Guid("C2C2BD76-0F72-4D82-805E-84B4C63A35CD");
        public static Guid PortugalId = new Guid("F2A72662-6617-48BB-8B18-1BEDF367B333");
        public static Guid SpainId = new Guid("47BEA7A6-4B39-4936-AED3-B8E6477B801B");
        public static Guid MoroccoId = new Guid("75CB8F8F-09CB-4D42-8A1D-D72733214AFD");
        public static Guid IranId = new Guid("B590A25F-7E03-4D86-8D8A-9002E9649B78");
        public static Guid FranceId = new Guid("FAAFECFF-9DDE-4AB6-BFF1-45701DAC9703");
        public static Guid AustraliaId = new Guid("D992EFFC-9717-4748-B553-3021385BEFDB");
        public static Guid PeruId = new Guid("FF62423C-8EFE-4621-B6AE-459057708744");
        public static Guid DenmarkId = new Guid("F2DE18D4-D687-4A9C-AEFD-57711E46879B");
        public static Guid ArgentinaId = new Guid("86911EE3-105B-40A4-9E6C-12A08A42E5F3");
        public static Guid IcelandId = new Guid("5FB315E4-AC09-43E7-A25A-1AAA14AD49D2");
        public static Guid CroatiaId = new Guid("D8BA096D-6642-4065-B6AE-EFDD69C9D838");
        public static Guid NigeriaId = new Guid("AFA69EC2-B079-4A34-91E5-FCB4F0A81305");
        public static Guid BrazilId = new Guid("4BF6D1FC-945D-4D87-B92E-C8D8241EFB38");
        public static Guid SwitzerlandId = new Guid("22538FD5-835F-4A25-89A2-E2361BCC79CB");
        public static Guid CostaRicaId = new Guid("59D528AA-D88C-4A42-8842-F3D63873E7E0");
        public static Guid SerbiaId = new Guid("A96A8A9D-8CD8-4ECB-B4A4-4EC7A7C8036C");
        public static Guid GermanyId = new Guid("4206B050-1053-4E2F-A9EE-ECBCD4C2E05F");
        public static Guid MexicoId = new Guid("ED25FD68-19C8-4946-8DE5-771CEBFAB18F");
        public static Guid SwedenId = new Guid("4AFB5C43-D22D-4EA3-9A13-4382C7F871B9");
        public static Guid SouthKoreaId = new Guid("E1180E09-B390-4091-82B6-3D8083B0B3D5");
        public static Guid BelgiumId = new Guid("655758A5-4E48-4278-B3EC-2B35E02968A0");
        public static Guid PanamaId = new Guid("D71B5AE4-6FFD-49EF-8D65-FEBF6C7C2B5D");
        public static Guid TunisiaId = new Guid("0203000F-7D44-4C35-8BA3-E770489568B0");
        public static Guid EnglandId = new Guid("0507C4E7-28C3-4FDF-9CB2-B0A63B6829DC");
        public static Guid PolandId = new Guid("2ED79000-5E29-462C-90CC-05E6DE9760D3");
        public static Guid SenegalId = new Guid("A0C39188-A660-4858-97FD-E87FEC330518");
        public static Guid ColombiaId = new Guid("40091D62-C1DE-4C1A-863F-97E31B82D216");
        public static Guid JapanId = new Guid("79CDD0E8-8C23-4199-9773-3DFAD546805F");
    }
}
