namespace Books_MVC5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAttributeToBookModel1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Book", "BookImage", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Book", "BookImage");
        }
    }
}
