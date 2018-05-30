using Data.Dto;
using Data.Extensions;

namespace Data.Migrations.Seed
{
    internal static class Groups
    {
        internal static void Execute(WcpContext context)
        {
            context.Groups.AddIfNotExists(
                new Group()
                {
                    Id = Group.GroupAId,
                    Name = Group.GroupA
                },
                new Group()
                {
                    Id = Group.GroupBId,
                    Name = Group.GroupB
                },
                new Group()
                {
                    Id = Group.GroupCId, 
                    Name = Group.GroupC
                },
                new Group()
                {
                    Id = Group.GroupDId,
                    Name = Group.GroupD
                },
                new Group()
                {
                    Id = Group.GroupEId,
                    Name = Group.GroupE
                },
                new Group()
                {
                    Id = Group.GroupFId,
                    Name = Group.GroupF
                },
                new Group()
                {
                    Id = Group.GroupGId,
                    Name = Group.GroupG
                },
                new Group()
                {
                    Id = Group.GroupHId,
                    Name = Group.GroupH
                }
            );
        }
    }
}
