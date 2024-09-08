namespace AspNetMvcPdfISharp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initseed : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.tblEmployee", newName: "tblMyEmps");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.tblMyEmps", newName: "tblEmployee");
        }
    }
}
