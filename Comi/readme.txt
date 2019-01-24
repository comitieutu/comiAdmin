
//insert data in migration
var sqlFile = Path.Combine("D:\\admin\\Comi", @"Countries.sql");
migrationBuilder.Sql(File.ReadAllText(sqlFile));

//sqlFile = Path.Combine("D:\\admin\\Comi", @"StaticData-US.sql");
//migrationBuilder.Sql(File.ReadAllText(sqlFile));

sqlFile = Path.Combine("D:\\admin\\Comi", @"StaticData-VN.sql");
migrationBuilder.Sql(File.ReadAllText(sqlFile));

//fix table country, stateorprovince, district in migration 
UniqueId = table.Column<Guid>(nullable: false, defaultValueSql: "newid()"),
Deleted = table.Column<bool>(nullable: false, defaultValueSql: "0"),
CreatedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "getdate()"),
ModifiedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "getdate()"),

//paypal
comiecommerce@gmail.com
Pass@word1
comiecommerce-facilitator@gmail.com
Pass@word1
comiecommerce-buyer@gmail.com
Pass@word1

//microsoft
comiecommerce@outlook.com
Pass@word123456