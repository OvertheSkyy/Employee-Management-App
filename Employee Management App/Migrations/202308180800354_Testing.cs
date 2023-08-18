namespace Employee_Management_App.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Testing : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Employee_Table",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EmpNo = c.String(nullable: false, maxLength: 6),
                        FirstName = c.String(nullable: false, maxLength: 15),
                        LastName = c.String(nullable: false, maxLength: 15),
                        Birthdate = c.DateTime(nullable: false),
                        ContactNo = c.Long(nullable: false),
                        EmailAddress = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Employee_Table");
        }
    }
}
