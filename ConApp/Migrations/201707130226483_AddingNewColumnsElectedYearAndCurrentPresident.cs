namespace ConApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingNewColumnsElectedYearAndCurrentPresident : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Presidents", "YearElected", c => c.Int(nullable: false));
            AddColumn("dbo.Presidents", "CurrentPresident", c => c.Boolean(nullable: false));

            Sql("UPDATE Presidents SET CurrentPresident = 0,YearElected = 1980 WHERE LastName='ReaganX'");
            Sql("UPDATE Presidents SET CurrentPresident = 1,YearElected = 1992 WHERE LastName='BushX'");
            Sql("UPDATE Presidents SET CurrentPresident = 1,YearElected = 2008 WHERE LastName='ObamaX'");
        }
        
        public override void Down()
        {
            DropColumn("dbo.Presidents", "CurrentPresident");
            DropColumn("dbo.Presidents", "YearElected");
        }
    }
}
