namespace Books_MVC5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAttributeToBookModel2 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Book", "BookImage");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Book", "BookImage", c => c.String());
        }
    }
}
