#this popose of a sample for how to use powershell connections and operate the db.

function Connect-Database
{
    [cmdletbinding()]
    param(
        [string]$SQLServer,
        [string]$SQLDatabase,
        [string]$User='',
        [string]$Pwd=''
    )
    try
    {
        $SQLConnection = New-Object System.Data.SQLClient.SQLConnection
        if($User -eq $null -or $User -eq "")
        {
            $SQLConnection.ConnectionString ="server=$SQLServer;database=$SQLDatabase;Integrated Security=True;"
            #Write-Output $SQLConnection.ConnectionString;
        }else
        {
            $SQLConnection.ConnectionString ="server=$SQLServer;database=$SQLDatabase;User Id=$User;Pwd=$Pwd;"
            #Write-Output $SQLConnection.ConnectionString;
        }
        return $SQLConnection
    }
    catch
    {

        Write-Output "Failed to connect SQL Server:$($SqlConection.ConnectionString)"  
    }
}

function Execute-SelectSql
{
    param(
        [parameter(mandatory=$true)]
        [string]$CommandText,
        [System.Data.SqlClient.SqlConnection]$SqlConnection
    )
    try{
        if($SqlConnection -ne $null -or $SqlConnection -ne "")
        {
           $SqlConnection.Open()
        }

        $SQLCommand = New-Object System.Data.SqlClient.SqlCommand
        $SQLCommand.CommandText = $CommandText
        $SQLCommand.Connection = $SQLConnection

        $SQLAdapter = New-Object System.Data.SqlClient.SqlDataAdapter
        $SqlAdapter.SelectCommand = $SQLCommand                 
        $SQLDataset = New-Object System.Data.DataSet
        $SqlAdapter.fill($SQLDataset) | out-null

        $tablevalue = @()
        foreach ($data in $SQLDataset.tables[0])
        {
            $tablevalue +=$data[0]
        }
        return $tableValue
    }
    catch{
        Write-Output $_
        
    }finally{
        $SQLAdapter.Dispose()
        $SQLCommand.Dispose()
        $SqlConnection.Close()
    }
}
<#
$sqlconnection=Connect-Database -SQLServer 'cppatdb' -SQLDatabase 'pattest'
$tablevalue=Execute-SQL -CommandText "select top 10 Name from patchingserver" -SqlConnection $sqlconnection
$tablevalue
#>
function Execute-InsertSql
{
    [cmdletBinding()]
    param(
        [string]$CommandText,
        [System.Data.SqlClient.SqlConnection]$SqlConnection
    )

       try{
        if($SqlConnection -ne $null -or $SqlConnection -ne "")
        {
           $SqlConnection.Open()
        }

        $SQLCommand = New-Object System.Data.SqlClient.SqlCommand
        $SQLCommand.CommandText = $CommandText
        $SQLCommand.Connection = $SQLConnection 
        $SQLCommand.Parameters.Add((New-Object System.Data.SqlClient.SqlParameter("@Name",[System.Data.SqlDbType]::NVarChar)))
        $SQLCommand.Parameters[0].Value="jeffrey"
        $SqlConnection.Parameters          
        $SQLCommand.ExecuteScalar()
    }
    catch{
        Write-Output $_
        
    }finally{
        $SQLCommand.Dispose()
        $SqlConnection.Close()
    }
    
}
$sqlconnection=Connect-Database -SQLServer 'cppatdb' -SQLDatabase 'pattest'
Execute-InsertSQL -CommandText "insert into Test(Name) values(@Name)" -SqlConnection $sqlconnection

