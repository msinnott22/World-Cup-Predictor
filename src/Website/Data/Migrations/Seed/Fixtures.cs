using System;
using Data.Dto;
using Data.Extensions;

namespace Data.Migrations.Seed
{
    internal static class Fixtures
    {
        internal static void Execute(WcpContext context)
        {
            context.Fixtures.AddIfNotExists(
                new Fixture()
                {
                    Id = Guid.NewGuid(),
                    HomeTeamId = Team.RussiaId,
                    AwayTeamId = Team.SaudiArabiaId,
                    Date = new DateTime(2018, 06, 14),
                    KickOff = new DateTime(2018, 06, 14, 16, 00, 00),
                    ExtraTimeAvailable = false,
                    PenaltiesAvailable = false,
                    Venue = "Luzhniki, Moscow"
                },
                new Fixture()
                {
                    Id = Guid.NewGuid(),
                    HomeTeamId = Team.EgyptId,
                    AwayTeamId = Team.UruguayId,
                    Date = new DateTime(2018, 06, 15),
                    KickOff = new DateTime(2018, 06, 15, 13, 00, 00),
                    ExtraTimeAvailable = false,
                    PenaltiesAvailable = false,
                    Venue = "Ekaterinburg"
                },
                new Fixture()
                {
                    Id = Guid.NewGuid(),
                    HomeTeamId = Team.PortugalId,
                    AwayTeamId = Team.SpainId,
                    Date = new DateTime(2018, 06, 15),
                    KickOff = new DateTime(2018, 06, 15, 19, 00, 00),
                    ExtraTimeAvailable = false,
                    PenaltiesAvailable = false,
                    Venue = "Sochi"
                },
                new Fixture()
                {
                    Id = Guid.NewGuid(),
                    HomeTeamId = Team.MoroccoId,
                    AwayTeamId = Team.IranId,
                    Date = new DateTime(2018, 06, 15),
                    KickOff = new DateTime(2018, 06, 15, 16, 00, 00),
                    ExtraTimeAvailable = false,
                    PenaltiesAvailable = false,
                    Venue = "St Petersburg"
                },
                new Fixture()
                {
                    Id = Guid.NewGuid(),
                    HomeTeamId = Team.FranceId,
                    AwayTeamId = Team.AustraliaId,
                    Date = new DateTime(2018, 06, 16),
                    KickOff = new DateTime(2018, 06, 16, 11, 00, 00),
                    ExtraTimeAvailable = false,
                    PenaltiesAvailable = false,
                    Venue = "Kazan"
                },
                new Fixture()
                {
                    Id = Guid.NewGuid(),
                    HomeTeamId = Team.ArgentinaId,
                    AwayTeamId = Team.IcelandId,
                    Date = new DateTime(2018, 06, 16),
                    KickOff = new DateTime(2018, 06, 16, 14, 00, 00),
                    ExtraTimeAvailable = false,
                    PenaltiesAvailable = false,
                    Venue = "Spartak, Moscow"
                },
                new Fixture()
                {
                    Id = Guid.NewGuid(),
                    HomeTeamId = Team.PeruId,
                    AwayTeamId = Team.DenmarkId,
                    Date = new DateTime(2018, 06, 16),
                    KickOff = new DateTime(2018, 06, 16, 17, 00, 00),
                    ExtraTimeAvailable = false,
                    PenaltiesAvailable = false,
                    Venue = "Saransk"
                },
                new Fixture()
                {
                    Id = Guid.NewGuid(),
                    HomeTeamId = Team.CroatiaId,
                    AwayTeamId = Team.NigeriaId,
                    Date = new DateTime(2018, 06, 16),
                    KickOff = new DateTime(2018, 06, 16, 20, 00, 00),
                    ExtraTimeAvailable = false,
                    PenaltiesAvailable = false,
                    Venue = "Kaliningrad"
                },
                new Fixture()
                {
                    Id = Guid.NewGuid(),
                    HomeTeamId = Team.CostaRicaId,
                    AwayTeamId = Team.SerbiaId,
                    Date = new DateTime(2018, 06, 17),
                    KickOff = new DateTime(2018, 06, 17, 13, 00, 00),
                    ExtraTimeAvailable = false,
                    PenaltiesAvailable = false,
                    Venue = "Samara"
                },
                new Fixture()
                {
                    Id = Guid.NewGuid(),
                    HomeTeamId = Team.GermanyId,
                    AwayTeamId = Team.MexicoId,
                    Date = new DateTime(2018, 06, 17),
                    KickOff = new DateTime(2018, 06, 17, 16, 00, 00),
                    ExtraTimeAvailable = false,
                    PenaltiesAvailable = false,
                    Venue = "Luzhniki, Moscow"
                },
                new Fixture()
                {
                    Id = Guid.NewGuid(),
                    HomeTeamId = Team.BrazilId,
                    AwayTeamId = Team.SwitzerlandId,
                    Date = new DateTime(2018, 06, 17),
                    KickOff = new DateTime(2018, 06, 17, 19, 00, 00),
                    ExtraTimeAvailable = false,
                    PenaltiesAvailable = false,
                    Venue = "Rostov-on-Don"
                },
                new Fixture()
                {
                    Id = Guid.NewGuid(),
                    HomeTeamId = Team.SwedenId,
                    AwayTeamId = Team.SouthKoreaId,
                    Date = new DateTime(2018, 06, 18),
                    KickOff = new DateTime(2018, 06, 18, 13, 00, 00),
                    ExtraTimeAvailable = false,
                    PenaltiesAvailable = false,
                    Venue = "Nizhny Novgorod"
                },
                new Fixture()
                {
                    Id = Guid.NewGuid(),
                    HomeTeamId = Team.BelgiumId,
                    AwayTeamId = Team.PanamaId,
                    Date = new DateTime(2018, 06, 18),
                    KickOff = new DateTime(2018, 06, 18, 16, 00, 00),
                    ExtraTimeAvailable = false,
                    PenaltiesAvailable = false,
                    Venue = "Luzhniki, Moscow"
                },
                new Fixture()
                {
                    Id = Guid.NewGuid(),
                    HomeTeamId = Team.TunisiaId,
                    AwayTeamId = Team.EnglandId,
                    Date = new DateTime(2018, 06, 18),
                    KickOff = new DateTime(2018, 06, 18, 19, 00, 00),
                    ExtraTimeAvailable = false,
                    PenaltiesAvailable = false,
                    Venue = "Volgograd"
                },
                new Fixture()
                {
                    Id = Guid.NewGuid(),
                    HomeTeamId = Team.ColombiaId,
                    AwayTeamId = Team.JapanId,
                    Date = new DateTime(2018, 06, 19),
                    KickOff = new DateTime(2018, 06, 19, 13, 00, 00),
                    ExtraTimeAvailable = false,
                    PenaltiesAvailable = false,
                    Venue = "Saransk"
                },
                new Fixture()
                {
                    Id = Guid.NewGuid(),
                    HomeTeamId = Team.PolandId,
                    AwayTeamId = Team.SenegalId,
                    Date = new DateTime(2018, 06, 19),
                    KickOff = new DateTime(2018, 06, 19, 16, 00, 00),
                    ExtraTimeAvailable = false,
                    PenaltiesAvailable = false,
                    Venue = "Spartak, Moscow"
                },
                new Fixture()
                {
                    Id = Guid.NewGuid(),
                    HomeTeamId = Team.RussiaId,
                    AwayTeamId = Team.EgyptId,
                    Date = new DateTime(2018, 06, 19),
                    KickOff = new DateTime(2018, 06, 19, 19, 00, 00),
                    ExtraTimeAvailable = false,
                    PenaltiesAvailable = false,
                    Venue = "St Petersburg"
                },
                new Fixture()
                {
                    Id = Guid.NewGuid(),
                    HomeTeamId = Team.PortugalId,
                    AwayTeamId = Team.MoroccoId,
                    Date = new DateTime(2018, 06, 20),
                    KickOff = new DateTime(2018, 06, 20, 13, 00, 00),
                    ExtraTimeAvailable = false,
                    PenaltiesAvailable = false,
                    Venue = "Luzhniki, Moscow"
                },
                new Fixture()
                {
                    Id = Guid.NewGuid(),
                    HomeTeamId = Team.UruguayId,
                    AwayTeamId = Team.SaudiArabiaId,
                    Date = new DateTime(2018, 06, 20),
                    KickOff = new DateTime(2018, 06, 20, 16, 00, 00),
                    ExtraTimeAvailable = false,
                    PenaltiesAvailable = false,
                    Venue = "Rostov-on-Don"
                },
                new Fixture()
                {
                    Id = Guid.NewGuid(),
                    HomeTeamId = Team.IranId,
                    AwayTeamId = Team.SpainId,
                    Date = new DateTime(2018, 06, 20),
                    KickOff = new DateTime(2018, 06, 20, 19, 00, 00),
                    ExtraTimeAvailable = false,
                    PenaltiesAvailable = false,
                    Venue = "Kazan"
                },
                new Fixture()
                {
                    Id = Guid.NewGuid(),
                    HomeTeamId = Team.DenmarkId,
                    AwayTeamId = Team.AustraliaId,
                    Date = new DateTime(2018, 06, 21),
                    KickOff = new DateTime(2018, 06, 21, 13, 00, 00),
                    ExtraTimeAvailable = false,
                    PenaltiesAvailable = false,
                    Venue = "Samara"
                },
                new Fixture()
                {
                    Id = Guid.NewGuid(),
                    HomeTeamId = Team.FranceId,
                    AwayTeamId = Team.PeruId,
                    Date = new DateTime(2018, 06, 21),
                    KickOff = new DateTime(2018, 06, 21, 16, 00, 00),
                    ExtraTimeAvailable = false,
                    PenaltiesAvailable = false,
                    Venue = "Ekaterinburg"
                },
                new Fixture()
                {
                    Id = Guid.NewGuid(),
                    HomeTeamId = Team.ArgentinaId,
                    AwayTeamId = Team.CroatiaId,
                    Date = new DateTime(2018, 06, 21),
                    KickOff = new DateTime(2018, 06, 21, 19, 00, 00),
                    ExtraTimeAvailable = false,
                    PenaltiesAvailable = false,
                    Venue = "Nizhny Novgorod"
                },
                new Fixture()
                {
                    Id = Guid.NewGuid(),
                    HomeTeamId = Team.BrazilId,
                    AwayTeamId = Team.CroatiaId,
                    Date = new DateTime(2018, 06, 22),
                    KickOff = new DateTime(2018, 06, 22, 13, 00, 00),
                    ExtraTimeAvailable = false,
                    PenaltiesAvailable = false,
                    Venue = "St Petersburg"
                },
                new Fixture()
                {
                    Id = Guid.NewGuid(),
                    HomeTeamId = Team.NigeriaId,
                    AwayTeamId = Team.IcelandId,
                    Date = new DateTime(2018, 06, 22),
                    KickOff = new DateTime(2018, 06, 22, 16, 00, 00),
                    ExtraTimeAvailable = false,
                    PenaltiesAvailable = false,
                    Venue = "Volgograd"
                },
                new Fixture()
                {
                    Id = Guid.NewGuid(),
                    HomeTeamId = Team.SerbiaId,
                    AwayTeamId = Team.SwitzerlandId,
                    Date = new DateTime(2018, 06, 22),
                    KickOff = new DateTime(2018, 06, 22, 19, 00, 00),
                    ExtraTimeAvailable = false,
                    PenaltiesAvailable = false,
                    Venue = "Kaliningrad"
                },
                new Fixture()
                {
                    Id = Guid.NewGuid(),
                    HomeTeamId = Team.BelgiumId,
                    AwayTeamId = Team.TunisiaId,
                    Date = new DateTime(2018, 06, 23),
                    KickOff = new DateTime(2018, 06, 23, 13, 00, 00),
                    ExtraTimeAvailable = false,
                    PenaltiesAvailable = false,
                    Venue = "Spartak, Moscow"
                },
                new Fixture()
                {
                    Id = Guid.NewGuid(),
                    HomeTeamId = Team.SouthKoreaId,
                    AwayTeamId = Team.MexicoId,
                    Date = new DateTime(2018, 06, 23),
                    KickOff = new DateTime(2018, 06, 23, 16, 00, 00),
                    ExtraTimeAvailable = false,
                    PenaltiesAvailable = false,
                    Venue = "Rostov-on-Don"
                },
                new Fixture()
                {
                    Id = Guid.NewGuid(),
                    HomeTeamId = Team.GermanyId,
                    AwayTeamId = Team.SwedenId,
                    Date = new DateTime(2018, 06, 23),
                    KickOff = new DateTime(2018, 06, 23, 19, 00, 00),
                    ExtraTimeAvailable = false,
                    PenaltiesAvailable = false,
                    Venue = "Sochi"
                },
                new Fixture()
                {
                    Id = Guid.NewGuid(),
                    HomeTeamId = Team.EnglandId,
                    AwayTeamId = Team.PanamaId,
                    Date = new DateTime(2018, 06, 24),
                    KickOff = new DateTime(2018, 06, 24, 13, 00, 00),
                    ExtraTimeAvailable = false,
                    PenaltiesAvailable = false,
                    Venue = "Nizhny Novgorod"
                },
                new Fixture()
                {
                    Id = Guid.NewGuid(),
                    HomeTeamId = Team.JapanId,
                    AwayTeamId = Team.SenegalId,
                    Date = new DateTime(2018, 06, 24),
                    KickOff = new DateTime(2018, 06, 24, 16, 00, 00),
                    ExtraTimeAvailable = false,
                    PenaltiesAvailable = false,
                    Venue = "Ekaterinburg"
                },
                new Fixture()
                {
                    Id = Guid.NewGuid(),
                    HomeTeamId = Team.PolandId,
                    AwayTeamId = Team.ColombiaId,
                    Date = new DateTime(2018, 06, 24),
                    KickOff = new DateTime(2018, 06, 24, 19, 00, 00),
                    ExtraTimeAvailable = false,
                    PenaltiesAvailable = false,
                    Venue = "Kazan"
                },
                new Fixture()
                {
                    Id = Guid.NewGuid(),
                    HomeTeamId = Team.UruguayId,
                    AwayTeamId = Team.RussiaId,
                    Date = new DateTime(2018, 06, 25),
                    KickOff = new DateTime(2018, 06, 25, 15, 00, 00),
                    ExtraTimeAvailable = false,
                    PenaltiesAvailable = false,
                    Venue = "Samara"
                },
                new Fixture()
                {
                    Id = Guid.NewGuid(),
                    HomeTeamId = Team.SaudiArabiaId,
                    AwayTeamId = Team.EgyptId,
                    Date = new DateTime(2018, 06, 25),
                    KickOff = new DateTime(2018, 06, 25, 15, 00, 00),
                    ExtraTimeAvailable = false,
                    PenaltiesAvailable = false,
                    Venue = "Volgograd"
                },
                new Fixture()
                {
                    Id = Guid.NewGuid(),
                    HomeTeamId = Team.SpainId,
                    AwayTeamId = Team.MoroccoId,
                    Date = new DateTime(2018, 06, 25),
                    KickOff = new DateTime(2018, 06, 25, 19, 00, 00),
                    ExtraTimeAvailable = false,
                    PenaltiesAvailable = false,
                    Venue = "Kaliningrad"
                },
                new Fixture()
                {
                    Id = Guid.NewGuid(),
                    HomeTeamId = Team.IranId,
                    AwayTeamId = Team.PortugalId,
                    Date = new DateTime(2018, 06, 25),
                    KickOff = new DateTime(2018, 06, 25, 19, 00, 00),
                    ExtraTimeAvailable = false,
                    PenaltiesAvailable = false,
                    Venue = "Saransk"
                },
                new Fixture()
                {
                    Id = Guid.NewGuid(),
                    HomeTeamId = Team.DenmarkId,
                    AwayTeamId = Team.FranceId,
                    Date = new DateTime(2018, 06, 26),
                    KickOff = new DateTime(2018, 06, 26, 15, 00, 00),
                    ExtraTimeAvailable = false,
                    PenaltiesAvailable = false,
                    Venue = "Luzhniki, Moscow"
                },
                new Fixture()
                {
                    Id = Guid.NewGuid(),
                    HomeTeamId = Team.AustraliaId,
                    AwayTeamId = Team.PeruId,
                    Date = new DateTime(2018, 06, 26),
                    KickOff = new DateTime(2018, 06, 26, 15, 00, 00),
                    ExtraTimeAvailable = false,
                    PenaltiesAvailable = false,
                    Venue = "Sochi"
                },
                new Fixture()
                {
                    Id = Guid.NewGuid(),
                    HomeTeamId = Team.NigeriaId,
                    AwayTeamId = Team.ArgentinaId,
                    Date = new DateTime(2018, 06, 26),
                    KickOff = new DateTime(2018, 06, 26, 19, 00, 00),
                    ExtraTimeAvailable = false,
                    PenaltiesAvailable = false,
                    Venue = "St Petersburg"
                },
                new Fixture()
                {
                    Id = Guid.NewGuid(),
                    HomeTeamId = Team.IcelandId,
                    AwayTeamId = Team.CroatiaId,
                    Date = new DateTime(2018, 06, 26),
                    KickOff = new DateTime(2018, 06, 26, 19, 00, 00),
                    ExtraTimeAvailable = false,
                    PenaltiesAvailable = false,
                    Venue = "Rostov-on-Don"
                },
                new Fixture()
                {
                    Id = Guid.NewGuid(),
                    HomeTeamId = Team.SouthKoreaId,
                    AwayTeamId = Team.GermanyId,
                    Date = new DateTime(2018, 06, 27),
                    KickOff = new DateTime(2018, 06, 27, 15, 00, 00),
                    ExtraTimeAvailable = false,
                    PenaltiesAvailable = false,
                    Venue = "Kazan"
                },
                new Fixture()
                {
                    Id = Guid.NewGuid(),
                    HomeTeamId = Team.MexicoId,
                    AwayTeamId = Team.SwedenId,
                    Date = new DateTime(2018, 06, 27),
                    KickOff = new DateTime(2018, 06, 27, 15, 00, 00),
                    ExtraTimeAvailable = false,
                    PenaltiesAvailable = false,
                    Venue = "Ekaterinburg"
                },
                new Fixture()
                {
                    Id = Guid.NewGuid(),
                    HomeTeamId = Team.SerbiaId,
                    AwayTeamId = Team.BrazilId,
                    Date = new DateTime(2018, 06, 27),
                    KickOff = new DateTime(2018, 06, 27, 19, 00, 00),
                    ExtraTimeAvailable = false,
                    PenaltiesAvailable = false,
                    Venue = "Spartak, Moscow"
                },
                new Fixture()
                {
                    Id = Guid.NewGuid(),
                    HomeTeamId = Team.SwitzerlandId,
                    AwayTeamId = Team.CostaRicaId,
                    Date = new DateTime(2018, 06, 27),
                    KickOff = new DateTime(2018, 06, 27, 19, 00, 00),
                    ExtraTimeAvailable = false,
                    PenaltiesAvailable = false,
                    Venue = "Nizhny Novgorod"
                },
                new Fixture()
                {
                    Id = Guid.NewGuid(),
                    HomeTeamId = Team.JapanId,
                    AwayTeamId = Team.PolandId,
                    Date = new DateTime(2018, 06, 28),
                    KickOff = new DateTime(2018, 06, 28, 15, 00, 00),
                    ExtraTimeAvailable = false,
                    PenaltiesAvailable = false,
                    Venue = "Volgograd"
                },
                new Fixture()
                {
                    Id = Guid.NewGuid(),
                    HomeTeamId = Team.SenegalId,
                    AwayTeamId = Team.ColombiaId,
                    Date = new DateTime(2018, 06, 28),
                    KickOff = new DateTime(2018, 06, 28, 15, 00, 00),
                    ExtraTimeAvailable = false,
                    PenaltiesAvailable = false,
                    Venue = "Samara"
                },
                new Fixture()
                {
                    Id = Guid.NewGuid(),
                    HomeTeamId = Team.EnglandId,
                    AwayTeamId = Team.BelgiumId,
                    Date = new DateTime(2018, 06, 28),
                    KickOff = new DateTime(2018, 06, 28, 19, 00, 00),
                    ExtraTimeAvailable = false,
                    PenaltiesAvailable = false,
                    Venue = "Kaliningrad"
                },
                new Fixture()
                {
                    Id = Guid.NewGuid(),
                    HomeTeamId = Team.PanamaId,
                    AwayTeamId = Team.TunisiaId,
                    Date = new DateTime(2018, 06, 28),
                    KickOff = new DateTime(2018, 06, 28, 19, 00, 00),
                    ExtraTimeAvailable = false,
                    PenaltiesAvailable = false,
                    Venue = "Saransk"
                });
        }
    }
}
