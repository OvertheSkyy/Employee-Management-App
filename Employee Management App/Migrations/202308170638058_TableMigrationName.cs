namespace Employee_Management_App.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TableMigrationName : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Employee_Table", "EmpNo", c => c.String(nullable: false, maxLength: 6));
            AlterColumn("dbo.Employee_Table", "FirstName", c => c.String(nullable: false, maxLength: 15));
            AlterColumn("dbo.Employee_Table", "LastName", c => c.String(nullable: false, maxLength: 15));
            AlterColumn("dbo.Employee_Table", "ContactNo", c => c.String(nullable: false, maxLength: 11));
            AlterColumn("dbo.Employee_Table", "EmailAddress", c => c.String(nullable: false, maxLength: 100));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Employee_Table", "EmailAddress", c => c.String());
            AlterColumn("dbo.Employee_Table", "ContactNo", c => c.String());
            AlterColumn("dbo.Employee_Table", "LastName", c => c.String());
            AlterColumn("dbo.Employee_Table", "FirstName", c => c.String());
            AlterColumn("dbo.Employee_Table", "EmpNo", c => c.String());
        }
    }
}
