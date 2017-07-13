namespace ConApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNewColumnParty : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Presidents", "Party", c => c.String());
            Sql("UPDATE Presidents SET Party = 'Republican' WHERE LastName='ReaganX'");
            Sql("UPDATE Presidents SET Party = 'Republican' WHERE LastName='BushX'");
            Sql("UPDATE Presidents SET Party = 'Democrat' WHERE LastName='ObamaX'");
        }

        public override void Down()
        {
            DropColumn("dbo.Presidents", "Party");
        }
    }
}
