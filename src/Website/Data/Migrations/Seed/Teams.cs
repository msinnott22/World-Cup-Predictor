using Data.Dto;
using Data.Extensions;

namespace Data.Migrations.Seed
{
    internal static class Teams
    {
        internal static void Execute(WcpContext context)
        {
            context.Teams.AddIfNotExists(
                new Team()
                {
                    Id = Team.RussiaId,
                    GroupId = Group.GroupAId,
                    Name = "Russia",
                    Abbreviation = "RUS"
                },
                new Team()
                {
                    Id = Team.SaudiArabiaId,
                    GroupId = Group.GroupAId,
                    Name = "Saudi Arabia",
                    Abbreviation = "KSA"
                },
                new Team()
                {
                    Id = Team.EgyptId,
                    GroupId = Group.GroupAId,
                    Name = "Egypt",
                    Abbreviation = "EGY"
                },
                new Team()
                {
                    Id = Team.UruguayId,
                    GroupId = Group.GroupAId,
                    Name = "Uruguay",
                    Abbreviation = "URU"
                },
                new Team()
                {
                    Id = Team.PortugalId,
                    GroupId = Group.GroupBId,
                    Name = "Portugal",
                    Abbreviation = "POR"
                },
                new Team()
                {
                    Id = Team.SpainId,
                    GroupId = Group.GroupBId,
                    Name = "Spain",
                    Abbreviation = "ESP"
                },
                new Team()
                {
                    Id = Team.MoroccoId,
                    GroupId = Group.GroupBId,
                    Name = "Morocco",
                    Abbreviation = "MOR"
                },
                new Team()
                {
                    Id = Team.IranId,
                    GroupId = Group.GroupBId,
                    Name = "Iran",
                    Abbreviation = "IRN"
                },
                new Team()
                {
                    Id = Team.FranceId,
                    GroupId = Group.GroupCId,
                    Name = "France",
                    Abbreviation = "FRA"
                },
                new Team()
                {
                    Id = Team.AustraliaId,
                    GroupId = Group.GroupCId,
                    Name = "Australia",
                    Abbreviation = "AUS"
                },
                new Team()
                {
                    Id = Team.PeruId,
                    GroupId = Group.GroupCId,
                    Name = "Peru",
                    Abbreviation = "PER"
                },
                new Team()
                {
                    Id = Team.DenmarkId,
                    GroupId = Group.GroupCId,
                    Name = "Denmark",
                    Abbreviation = "DEN"
                },
                new Team()
                {
                    Id = Team.ArgentinaId,
                    GroupId = Group.GroupDId,
                    Name = "Argentina",
                    Abbreviation = "ARG"
                },
                new Team()
                {
                    Id = Team.IcelandId,
                    GroupId = Group.GroupDId,
                    Name = "Iceland",
                    Abbreviation = "ICE"
                },
                new Team()
                {
                    Id = Team.CroatiaId,
                    GroupId = Group.GroupDId,
                    Name = "Croatia",
                    Abbreviation = "CRO"
                },
                new Team()
                {
                    Id = Team.NigeriaId,
                    GroupId = Group.GroupDId,
                    Name = "Nigeria",
                    Abbreviation = "NGA"
                },
                new Team()
                {
                    Id = Team.BrazilId,
                    GroupId = Group.GroupEId,
                    Name = "Brazil",
                    Abbreviation = "BRZ"
                },
                new Team()
                {
                    Id = Team.SwitzerlandId,
                    GroupId = Group.GroupEId,
                    Name = "Switzerland",
                    Abbreviation = "SWI"
                },
                new Team()
                {
                    Id = Team.CostaRicaId,
                    GroupId = Group.GroupEId,
                    Name = "Costa Rica",
                    Abbreviation = "CRC"
                },
                new Team()
                {
                    Id = Team.SerbiaId,
                    GroupId = Group.GroupEId,
                    Name = "Serbia",
                    Abbreviation = "SER"
                },
                new Team()
                {
                    Id = Team.GermanyId,
                    GroupId = Group.GroupFId,
                    Name = "Germany",
                    Abbreviation = "GER"
                },
                new Team()
                {
                    Id = Team.MexicoId,
                    GroupId = Group.GroupFId,
                    Name = "Mexico",
                    Abbreviation = "MEX"
                },
                new Team()
                {
                    Id = Team.SwedenId,
                    GroupId = Group.GroupFId,
                    Name = "Sweden",
                    Abbreviation = "SWE"
                },
                new Team()
                {
                    Id = Team.SouthKoreaId,
                    GroupId = Group.GroupFId,
                    Name = "South Korea",
                    Abbreviation = "KOR"
                },
                new Team()
                {
                    Id = Team.BelgiumId,
                    GroupId = Group.GroupGId,
                    Name = "Belgium",
                    Abbreviation = "BEL"
                },
                new Team()
                {
                    Id = Team.PanamaId,
                    GroupId = Group.GroupGId,
                    Name = "Panama",
                    Abbreviation = "PAN"
                },
                new Team()
                {
                    Id = Team.TunisiaId,
                    GroupId = Group.GroupGId,
                    Name = "Tunisia",
                    Abbreviation = "TUN"
                },
                new Team()
                {
                    Id = Team.EnglandId,
                    GroupId = Group.GroupGId,
                    Name = "England",
                    Abbreviation = "ENG"
                },
                new Team()
                {
                    Id = Team.PolandId,
                    GroupId = Group.GroupHId,
                    Name = "Poland",
                    Abbreviation = "POL"
                },
                new Team()
                {
                    Id = Team.SenegalId,
                    GroupId = Group.GroupHId,
                    Name = "Senegal",
                    Abbreviation = "SEN"
                },
                new Team()
                {
                    Id = Team.ColombiaId,
                    GroupId = Group.GroupHId,
                    Name = "Colombia",
                    Abbreviation = "COL"
                },
                new Team()
                {
                    Id = Team.JapanId,
                    GroupId = Group.GroupHId,
                    Name = "Japan",
                    Abbreviation = "JPN"
                }
            );
        }
    }
}
