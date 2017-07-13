# ConApp 
First glance of EntityFramework using CodeFirst
All examples are from http://peterkellner.net
You will learn
### [System.Data.Entity Namespace]
###### DropCreateDatabaseIfModelChanges<TContext>
An implementation of IDatabaseInitializer<TContext>that will delete, recreate, and optionally  re-seed the database with data only if the model has changed since the database was created. This is achieved by writing a hash of the store model to the database when it is created and then comparing that hash with one generated from the current model. To seed the database, create a derived class and override the Seed method.
###### DropCreateDatabaseAlways<TContext>
An implementation of IDatabaseInitializer<TContext> that will always recreate and optionally re-seed the database with data the first time that a context is used in the application domain. To seed the database, create a derived class and override the Seed method.
###### CreateDatabaseIfNotExists<TContext>
An implementation of IDatabaseInitializer<TContext> that will recreate and optionally re-seed the database with data only if the database does not exist. To seed the database, create a derived class and override the Seed method.


  Add ConnectionString to app.config:
```sh
<add name="DefaultConnection"
       connectionString="Data Source=(LocalDb)\MSSQLLocalDB;Initial Catalog= ConApp-2-1-alpha1;Integrated Security=SSPI" providerName="System.Data.SqlClient" />
  </connectionStrings>
```

   Initialize the database
```sh
public class SiteDb : DbContext
{
   public SiteDb() : base("DefaultConnection"){ }
   public DbSet<President> Presidents { get; set; }
}
```
###### References
 -  http://peterkellner.net/2012/02/17/entityframework-4-3-codefirst-trivial-one-file-example-part-1/
 - http://peterkellner.net/2012/02/17/entityframework-codefirst-4-3-adding-data-migration-to-simple-example-part-2 
 - http://peterkellner.net/2012/02/17/entityframework-code-first-4-3-adding-a-single-default-column-to-a-migration-enabled-project-part-3

[System.Data.Entity Namespace]: <https://msdn.microsoft.com/en-us/library/gg696142(v=vs.103).aspx>
