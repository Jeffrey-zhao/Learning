Now, I will write down the true scenario of using EF with Model First/Database First
1.problem:
a MVC solution with serverl projects,for example,web mvc projct without models which references another project,a libary class for models.
but when i create an empty "AppDB.edmx" file,then there are two connection string in config files that are web.config and app.config
something like this blew:
------------------------------
  <connectionStrings>
    <add name="AppDBContainer1" connectionString="metadata=res://*/AppDB.csdl|res://*/AppDB.ssdl|res://*/AppDB.msl;provider=System.Data.SqlClient;provider connection string=&quot;data source=(localdb)\ProjectsV13;initial catalog=AppDB;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework&quot;" providerName="System.Data.EntityClient" />
  </connectionStrings>
 -----------------------------
 
 you know,i like add connection node like this not for ef but just for sql connection.
 
 ------------------------------
  <connectionStrings>
    <add name="AppDBContainer2" connectionString="data source=(localdb)\ProjectsV13;initial catalog=AppDB;integrated security=True;" providerName="System.Data.SqlClient" />
  </connectionStrings>
 -----------------------------
 
 look out for the last key word "providerName" of these two conncetion or the differences of these two.
 AppDBContainer1: providerName=System.Data.SqlClient
 AppDBContainer2:providerName=System.Data.EntityClient
 and the same with "connectionString".
 I test these two connectionString
 when i use AppDBContainer2 ,it works ,another not.
 and connectionStrings Node in app.config don't work for this solution, and it use web.config info.
 
 2.solution:
 step 1:create a mvc project
 step 2:create a model project
 step 3:--most important step,copy connection of app.config in the model project to web.config in the mvc project
 step 4:--focus key,you may leave other connectiongString,but if you use ef connectionString.just keep it same when you copy
 ------------------------------------
public AppDBContainer() : base("name=AppDBContainer2"){}
 ------------------------------------
 
