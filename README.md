# AssignmentVB

Foobar is a vb.net library for learning with word pluralization.

## Installation

Use the package manager to install AssignmentVB.

```bash
git clone https://github.com/empovdev/AssignmentVB.git
```

## Usage
create new table sample
```sql

CREATE TABLE tblperson(
	[PersonID] [INT] IDENTITY(1,1) NOT NULL,
	[Fname] [nvarchar](50) NULL,
	[Lname] [nvarchar](50) NULL
)

```
code for loadData to DataGridView
```vb.net
Private Sub loadData(sql As String, dtg As DataGridView)
        Try
            connection.Open()
            cmd = New SqlCommand()
            da = New SqlDataAdapter
            dt = New DataTable

            With cmd
                .Connection = connection
                .CommandText = sql
            End With
            With da
                .SelectCommand = cmd
                .Fill(dt)
            End With
            dtg.DataSource = dt

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connection.Close()
            da.Dispose()
        End Try
    End Sub
    
````

## Contributing
Pull requests are welcome. For major changes, please open an issue first to discuss what you would like to change.

Please make sure to update tests as appropriate.

## License
[MIT](https://choosealicense.com/licenses/mit/)
