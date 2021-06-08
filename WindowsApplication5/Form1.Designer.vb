<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtfname = New System.Windows.Forms.TextBox()
        Me.insert = New System.Windows.Forms.Button()
        Me.txtlname = New System.Windows.Forms.TextBox()
        Me.dtgList = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.id = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.dtgList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(529, 9)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(133, 29)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "test con"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtfname
        '
        Me.txtfname.Location = New System.Drawing.Point(12, 44)
        Me.txtfname.Multiline = True
        Me.txtfname.Name = "txtfname"
        Me.txtfname.Size = New System.Drawing.Size(205, 29)
        Me.txtfname.TabIndex = 1
        '
        'insert
        '
        Me.insert.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.insert.Location = New System.Drawing.Point(223, 82)
        Me.insert.Name = "insert"
        Me.insert.Size = New System.Drawing.Size(80, 29)
        Me.insert.TabIndex = 2
        Me.insert.Text = "Insert"
        Me.insert.UseVisualStyleBackColor = True
        '
        'txtlname
        '
        Me.txtlname.Location = New System.Drawing.Point(12, 82)
        Me.txtlname.Multiline = True
        Me.txtlname.Name = "txtlname"
        Me.txtlname.Size = New System.Drawing.Size(205, 29)
        Me.txtlname.TabIndex = 3
        '
        'dtgList
        '
        Me.dtgList.AllowUserToOrderColumns = True
        Me.dtgList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtgList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgList.Location = New System.Drawing.Point(15, 128)
        Me.dtgList.Name = "dtgList"
        Me.dtgList.Size = New System.Drawing.Size(640, 195)
        Me.dtgList.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(305, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(218, 78)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "CREATE TABLE tblperson(" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(9) & "[PersonID] [INT] IDENTITY(1,1) NOT NULL," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(9) & "[Fname] [n" &
    "varchar](50) NULL," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(9) & "[Lname] [nvarchar](50) NULL" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & ")"
        '
        'id
        '
        Me.id.Location = New System.Drawing.Point(36, 9)
        Me.id.Multiline = True
        Me.id.Name = "id"
        Me.id.Size = New System.Drawing.Size(50, 29)
        Me.id.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(18, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "ID"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(674, 335)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.id)
        Me.Controls.Add(Me.dtgList)
        Me.Controls.Add(Me.txtlname)
        Me.Controls.Add(Me.insert)
        Me.Controls.Add(Me.txtfname)
        Me.Controls.Add(Me.Button1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.dtgList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents txtfname As TextBox
    Friend WithEvents insert As Button
    Friend WithEvents txtlname As TextBox
    Friend WithEvents dtgList As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents id As TextBox
    Friend WithEvents Label2 As Label
End Class
