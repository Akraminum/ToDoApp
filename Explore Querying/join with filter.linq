<Query Kind="Statements">
  <Connection>
    <ID>53667ca3-7885-4b3f-856e-ce8dc2f7e04b</ID>
    <NamingServiceVersion>2</NamingServiceVersion>
    <Persist>true</Persist>
    <Driver Assembly="EF7Driver" PublicKeyToken="469b5aa5a4331a8c">EF7Driver.StaticDriver</Driver>
    <CustomAssemblyPath>E:\02-Play Ground\ToDoApp\API\ToDoAppAPI\bin\Debug\net6.0\ToDoAppAPI.dll</CustomAssemblyPath>
    <CustomTypeName>ToDoAppAPI.DataBase.AppDbContext</CustomTypeName>
    <CustomCxString>server=.;database=ToDoApp;trusted_connection=true;TrustServerCertificate=True;</CustomCxString>
    <DisplayName>ToDoApp</DisplayName>
    <DriverData>
      <UseDbContextOptions>true</UseDbContextOptions>
      <EFProvider>Microsoft.EntityFrameworkCore.SqlServer</EFProvider>
    </DriverData>
  </Connection>
</Query>

Lists.Include(l =>
	l.Tasks.Where(t => 
    	t.Title.Contains("p")));


Lists.Where(l => true)
.Include(l =>
	l.Tasks.Where(t => 
    	t.Title.Contains("m")));
		
		

		


