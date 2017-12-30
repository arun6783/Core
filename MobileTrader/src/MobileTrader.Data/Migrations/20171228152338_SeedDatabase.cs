using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace MobileTrader.Data.Migrations
{
    public partial class SeedDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Insert INTO MAKES(NAME) VALUES ('MAKE1')");
            migrationBuilder.Sql("Insert INTO MAKES(NAME) VALUES ('MAKE2')");
            migrationBuilder.Sql("Insert INTO MAKES(NAME) VALUES ('MAKE3')");



            var sql = "";


            sql += " declare @makeid  int";
            sql += Environment.NewLine;

            sql += "select @makeid = Id from[Makes] where name = 'MAKE1'";
            sql += Environment.NewLine;

            sql += "insert into models(name, makeid) VALUES ('MAKE1-ModelA', @makeid)";
            sql += Environment.NewLine;

            sql += "insert into models(name, makeid) VALUES  ('MAKE1-ModelB', @makeid)";
            sql += Environment.NewLine;

            sql += "insert into models(name, makeid) VALUES ('MAKE1-ModelC', @makeid)";
            sql += Environment.NewLine;

            sql += "insert into models(name, makeid) VALUES  ('MAKE1-ModelD', @makeid)";
            sql += Environment.NewLine;


            sql += "select @makeid = Id from[Makes] where name = 'MAKE2'";
            sql += Environment.NewLine;

            sql += "insert into models(name, makeid) VALUES ('MAKE2-ModelA', @makeid)";
            sql += Environment.NewLine;

            sql += "insert into models(name, makeid) VALUES  ('MAKE2-ModelB', @makeid)";
            sql += Environment.NewLine;

            sql += "insert into models(name, makeid) VALUES ('MAKE2-ModelC', @makeid)";
            sql += Environment.NewLine;

            sql += "insert into models(name, makeid) VALUES ('MAKE2-ModelD', @makeid)";
            sql += Environment.NewLine;


            sql += "select @makeid = Id from[Makes] where name = 'MAKE3'";
            sql += Environment.NewLine;

            sql += "insert into models(name, makeid) VALUES ('MAKE3-ModelA', @makeid)";
            sql += Environment.NewLine;

            sql += "insert into models(name, makeid) VALUES ('MAKE3-ModelB', @makeid)";
            sql += Environment.NewLine;

            sql += "insert into models(name, makeid) VALUES ('MAKE3-ModelC', @makeid)";
            sql += Environment.NewLine;

            sql += "insert into models(name, makeid) VALUES ('MAKE3-ModelD', @makeid)";
            sql += Environment.NewLine;

            Debug.WriteLine(sql);
            migrationBuilder.Sql(sql);

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Delete from Makes");
        }
    }
}
