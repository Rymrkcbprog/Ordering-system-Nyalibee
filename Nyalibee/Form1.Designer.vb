<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Btnlogin = New Button()
        Label1 = New Label()
        txtuser = New TextBox()
        PictureBox1 = New PictureBox()
        txtpass = New TextBox()
        xbutton = New FontAwesome.Sharp.IconButton()
        Label2 = New Label()
        CheckBox1 = New CheckBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Btnlogin
        ' 
        Btnlogin.BackColor = Color.Red
        Btnlogin.FlatStyle = FlatStyle.Flat
        Btnlogin.ForeColor = Color.White
        Btnlogin.Location = New Point(210, 474)
        Btnlogin.Name = "Btnlogin"
        Btnlogin.Size = New Size(192, 63)
        Btnlogin.TabIndex = 0
        Btnlogin.Text = "Log in"
        Btnlogin.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Mongolian Baiti", 22.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Red
        Label1.Location = New Point(106, 197)
        Label1.Name = "Label1"
        Label1.Size = New Size(370, 40)
        Label1.TabIndex = 1
        Label1.Text = "Welcome to Nyalibee!"
        ' 
        ' txtuser
        ' 
        txtuser.Location = New Point(172, 324)
        txtuser.Multiline = True
        txtuser.Name = "txtuser"
        txtuser.PlaceholderText = "Username"
        txtuser.Size = New Size(265, 47)
        txtuser.TabIndex = 0
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(172, 36)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(258, 201)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 3
        PictureBox1.TabStop = False
        ' 
        ' txtpass
        ' 
        txtpass.Location = New Point(172, 391)
        txtpass.Multiline = True
        txtpass.Name = "txtpass"
        txtpass.PasswordChar = "●"c
        txtpass.PlaceholderText = "Password"
        txtpass.Size = New Size(265, 47)
        txtpass.TabIndex = 0
        ' 
        ' xbutton
        ' 
        xbutton.FlatAppearance.BorderSize = 0
        xbutton.FlatStyle = FlatStyle.Flat
        xbutton.IconChar = FontAwesome.Sharp.IconChar.Close
        xbutton.IconColor = Color.Black
        xbutton.IconFont = FontAwesome.Sharp.IconFont.Auto
        xbutton.IconSize = 25
        xbutton.Location = New Point(561, 13)
        xbutton.Name = "xbutton"
        xbutton.Size = New Size(23, 25)
        xbutton.TabIndex = 13
        xbutton.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Tai Le", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.ControlDark
        Label2.Location = New Point(115, 255)
        Label2.Name = "Label2"
        Label2.Size = New Size(392, 46)
        Label2.TabIndex = 14
        Label2.Text = "Welcome to Nyalibee! Log in an account for the " & vbCrLf & "               Nyaliest ordering experience!"
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(241, 444)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(132, 24)
        CheckBox1.TabIndex = 15
        CheckBox1.Text = "Show Password"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlLightLight
        ClientSize = New Size(598, 576)
        Controls.Add(CheckBox1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Controls.Add(xbutton)
        Controls.Add(txtuser)
        Controls.Add(txtpass)
        Controls.Add(Btnlogin)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Btnlogin As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtuser As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtpass As TextBox
    Friend WithEvents xbutton As FontAwesome.Sharp.IconButton
    Friend WithEvents Label2 As Label
    Friend WithEvents CheckBox1 As CheckBox

End Class
