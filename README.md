# ConApp 
# First glance of EntityFramework using CodeFirst

> All examples are from http://peterkellner.net

References:
1. http://peterkellner.net/2012/02/17/entityframework-4-3-codefirst-trivial-one-file-example-part-1/
2. http://peterkellner.net/2012/02/17/entityframework-codefirst-4-3-adding-data-migration-to-simple-example-part-2 
3. http://peterkellner.net/2012/02/17/entityframework-code-first-4-3-adding-a-single-default-column-to-a-migration-enabled-project-part-3

You will learn
## System.Data.Entity Namespace
###### DropCreateDatabaseIfModelChanges<TContext>
An implementation of IDatabaseInitializer<TContext>that will delete, recreate, and optionally re-seed the database with data only if the model has changed since the database was created. This is achieved by writing a hash of the store model to the database when it is created and then comparing that hash with one generated from the current model. To seed the database, create a derived class and override the Seed method.
###### DropCreateDatabaseAlways<TContext>
An implementation of IDatabaseInitializer<TContext> that will always recreate and optionally re-seed the database with data the first time that a context is used in the application domain. To seed the database, create a derived class and override the Seed method.
###### CreateDatabaseIfNotExists<TContext>
An implementation of IDatabaseInitializer<TContext> that will recreate and optionally re-seed the database with data only if the database does not exist. To seed the database, create a derived class and override the Seed method.
