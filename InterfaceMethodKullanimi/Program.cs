using InterfaceMethodKullanimi;

IDatabase db = new SqlDatabase()
{
    Company = "Microsoft",
    DatabaseName = "Microsoft SQL Server"
};
db.Read();
db.Create();
db.Update();
db.Delete();