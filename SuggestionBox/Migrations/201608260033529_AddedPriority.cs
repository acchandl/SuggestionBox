namespace SuggestionBox.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedPriority : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SuggestionModels", "Priority", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.SuggestionModels", "Priority");
        }
    }
}
