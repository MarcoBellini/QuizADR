<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla mediante l'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TimeLabel = New System.Windows.Forms.Label()
        Me.TimeTextLabel = New System.Windows.Forms.Label()
        Me.ThreeErrorLabel = New System.Windows.Forms.Label()
        Me.TwoErrorLabel = New System.Windows.Forms.Label()
        Me.OneErrorLabel = New System.Windows.Forms.Label()
        Me.NextTabButton = New System.Windows.Forms.Button()
        Me.PrevTabButton = New System.Windows.Forms.Button()
        Me.IndexLabel = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.QuestionThreeFalse = New System.Windows.Forms.RadioButton()
        Me.QuestionThreeTrue = New System.Windows.Forms.RadioButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.QuestionTwoFalse = New System.Windows.Forms.RadioButton()
        Me.QuestionTwoTrue = New System.Windows.Forms.RadioButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.QuestionOneTrue = New System.Windows.Forms.RadioButton()
        Me.QuestionOneFalse = New System.Windows.Forms.RadioButton()
        Me.QuestionThreeLabel = New System.Windows.Forms.Label()
        Me.QuestionTwoLabel = New System.Windows.Forms.Label()
        Me.QuestionOneLabel = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MainQuestionLabel = New System.Windows.Forms.Label()
        Me.CategoryLabel = New System.Windows.Forms.Label()
        Me.ResultLabel = New System.Windows.Forms.Label()
        Me.ResultTextLabel = New System.Windows.Forms.Label()
        Me.NewExamButton = New System.Windows.Forms.Button()
        Me.AnswerCheckButton = New System.Windows.Forms.Button()
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.ExamTimer = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.TimeLabel)
        Me.GroupBox1.Controls.Add(Me.TimeTextLabel)
        Me.GroupBox1.Controls.Add(Me.ThreeErrorLabel)
        Me.GroupBox1.Controls.Add(Me.TwoErrorLabel)
        Me.GroupBox1.Controls.Add(Me.OneErrorLabel)
        Me.GroupBox1.Controls.Add(Me.NextTabButton)
        Me.GroupBox1.Controls.Add(Me.PrevTabButton)
        Me.GroupBox1.Controls.Add(Me.IndexLabel)
        Me.GroupBox1.Controls.Add(Me.Panel3)
        Me.GroupBox1.Controls.Add(Me.Panel2)
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Controls.Add(Me.QuestionThreeLabel)
        Me.GroupBox1.Controls.Add(Me.QuestionTwoLabel)
        Me.GroupBox1.Controls.Add(Me.QuestionOneLabel)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.MainQuestionLabel)
        Me.GroupBox1.Controls.Add(Me.CategoryLabel)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(821, 357)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Schede esame"
        '
        'TimeLabel
        '
        Me.TimeLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.TimeLabel.AutoSize = True
        Me.TimeLabel.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TimeLabel.Location = New System.Drawing.Point(114, 326)
        Me.TimeLabel.Name = "TimeLabel"
        Me.TimeLabel.Size = New System.Drawing.Size(47, 20)
        Me.TimeLabel.TabIndex = 16
        Me.TimeLabel.Text = "0:0:00"
        Me.TimeLabel.Visible = False
        '
        'TimeTextLabel
        '
        Me.TimeTextLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.TimeTextLabel.AutoSize = True
        Me.TimeTextLabel.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TimeTextLabel.Location = New System.Drawing.Point(40, 326)
        Me.TimeTextLabel.Name = "TimeTextLabel"
        Me.TimeTextLabel.Size = New System.Drawing.Size(58, 20)
        Me.TimeTextLabel.TabIndex = 15
        Me.TimeTextLabel.Text = "Tempo:"
        Me.TimeTextLabel.Visible = False
        '
        'ThreeErrorLabel
        '
        Me.ThreeErrorLabel.AutoSize = True
        Me.ThreeErrorLabel.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ThreeErrorLabel.ForeColor = System.Drawing.Color.Red
        Me.ThreeErrorLabel.Location = New System.Drawing.Point(0, 207)
        Me.ThreeErrorLabel.Name = "ThreeErrorLabel"
        Me.ThreeErrorLabel.Size = New System.Drawing.Size(52, 13)
        Me.ThreeErrorLabel.TabIndex = 14
        Me.ThreeErrorLabel.Text = "Errata ->"
        Me.ThreeErrorLabel.Visible = False
        '
        'TwoErrorLabel
        '
        Me.TwoErrorLabel.AutoSize = True
        Me.TwoErrorLabel.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TwoErrorLabel.ForeColor = System.Drawing.Color.Red
        Me.TwoErrorLabel.Location = New System.Drawing.Point(0, 148)
        Me.TwoErrorLabel.Name = "TwoErrorLabel"
        Me.TwoErrorLabel.Size = New System.Drawing.Size(52, 13)
        Me.TwoErrorLabel.TabIndex = 13
        Me.TwoErrorLabel.Text = "Errata ->"
        Me.TwoErrorLabel.Visible = False
        '
        'OneErrorLabel
        '
        Me.OneErrorLabel.AutoSize = True
        Me.OneErrorLabel.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OneErrorLabel.ForeColor = System.Drawing.Color.Red
        Me.OneErrorLabel.Location = New System.Drawing.Point(0, 89)
        Me.OneErrorLabel.Name = "OneErrorLabel"
        Me.OneErrorLabel.Size = New System.Drawing.Size(52, 13)
        Me.OneErrorLabel.TabIndex = 12
        Me.OneErrorLabel.Text = "Errata ->"
        Me.OneErrorLabel.Visible = False
        '
        'NextTabButton
        '
        Me.NextTabButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NextTabButton.Location = New System.Drawing.Point(705, 322)
        Me.NextTabButton.Name = "NextTabButton"
        Me.NextTabButton.Size = New System.Drawing.Size(110, 29)
        Me.NextTabButton.TabIndex = 1
        Me.NextTabButton.Text = "Scheda successiva"
        Me.NextTabButton.UseVisualStyleBackColor = True
        '
        'PrevTabButton
        '
        Me.PrevTabButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PrevTabButton.Location = New System.Drawing.Point(578, 322)
        Me.PrevTabButton.Name = "PrevTabButton"
        Me.PrevTabButton.Size = New System.Drawing.Size(115, 29)
        Me.PrevTabButton.TabIndex = 2
        Me.PrevTabButton.Text = "Scheda precedente"
        Me.PrevTabButton.UseVisualStyleBackColor = True
        '
        'IndexLabel
        '
        Me.IndexLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.IndexLabel.AutoSize = True
        Me.IndexLabel.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IndexLabel.Location = New System.Drawing.Point(479, 326)
        Me.IndexLabel.Name = "IndexLabel"
        Me.IndexLabel.Size = New System.Drawing.Size(30, 20)
        Me.IndexLabel.TabIndex = 9
        Me.IndexLabel.Text = "***"
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.Controls.Add(Me.QuestionThreeFalse)
        Me.Panel3.Controls.Add(Me.QuestionThreeTrue)
        Me.Panel3.Location = New System.Drawing.Point(705, 203)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(104, 28)
        Me.Panel3.TabIndex = 1
        '
        'QuestionThreeFalse
        '
        Me.QuestionThreeFalse.AutoSize = True
        Me.QuestionThreeFalse.Location = New System.Drawing.Point(62, 6)
        Me.QuestionThreeFalse.Name = "QuestionThreeFalse"
        Me.QuestionThreeFalse.Size = New System.Drawing.Size(31, 17)
        Me.QuestionThreeFalse.TabIndex = 18
        Me.QuestionThreeFalse.Text = "F"
        Me.QuestionThreeFalse.UseVisualStyleBackColor = True
        '
        'QuestionThreeTrue
        '
        Me.QuestionThreeTrue.AutoSize = True
        Me.QuestionThreeTrue.Location = New System.Drawing.Point(11, 6)
        Me.QuestionThreeTrue.Name = "QuestionThreeTrue"
        Me.QuestionThreeTrue.Size = New System.Drawing.Size(32, 17)
        Me.QuestionThreeTrue.TabIndex = 17
        Me.QuestionThreeTrue.Text = "V"
        Me.QuestionThreeTrue.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.Controls.Add(Me.QuestionTwoFalse)
        Me.Panel2.Controls.Add(Me.QuestionTwoTrue)
        Me.Panel2.Location = New System.Drawing.Point(705, 144)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(104, 28)
        Me.Panel2.TabIndex = 1
        '
        'QuestionTwoFalse
        '
        Me.QuestionTwoFalse.AutoSize = True
        Me.QuestionTwoFalse.Location = New System.Drawing.Point(62, 6)
        Me.QuestionTwoFalse.Name = "QuestionTwoFalse"
        Me.QuestionTwoFalse.Size = New System.Drawing.Size(31, 17)
        Me.QuestionTwoFalse.TabIndex = 16
        Me.QuestionTwoFalse.Text = "F"
        Me.QuestionTwoFalse.UseVisualStyleBackColor = True
        '
        'QuestionTwoTrue
        '
        Me.QuestionTwoTrue.AutoSize = True
        Me.QuestionTwoTrue.Location = New System.Drawing.Point(11, 6)
        Me.QuestionTwoTrue.Name = "QuestionTwoTrue"
        Me.QuestionTwoTrue.Size = New System.Drawing.Size(32, 17)
        Me.QuestionTwoTrue.TabIndex = 15
        Me.QuestionTwoTrue.Text = "V"
        Me.QuestionTwoTrue.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.QuestionOneTrue)
        Me.Panel1.Controls.Add(Me.QuestionOneFalse)
        Me.Panel1.Location = New System.Drawing.Point(705, 85)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(104, 28)
        Me.Panel1.TabIndex = 1
        '
        'QuestionOneTrue
        '
        Me.QuestionOneTrue.AutoSize = True
        Me.QuestionOneTrue.Location = New System.Drawing.Point(11, 5)
        Me.QuestionOneTrue.Name = "QuestionOneTrue"
        Me.QuestionOneTrue.Size = New System.Drawing.Size(32, 17)
        Me.QuestionOneTrue.TabIndex = 11
        Me.QuestionOneTrue.Text = "V"
        Me.QuestionOneTrue.UseVisualStyleBackColor = True
        '
        'QuestionOneFalse
        '
        Me.QuestionOneFalse.AutoSize = True
        Me.QuestionOneFalse.Location = New System.Drawing.Point(62, 5)
        Me.QuestionOneFalse.Name = "QuestionOneFalse"
        Me.QuestionOneFalse.Size = New System.Drawing.Size(31, 17)
        Me.QuestionOneFalse.TabIndex = 12
        Me.QuestionOneFalse.Text = "F"
        Me.QuestionOneFalse.UseVisualStyleBackColor = True
        '
        'QuestionThreeLabel
        '
        Me.QuestionThreeLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.QuestionThreeLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QuestionThreeLabel.Location = New System.Drawing.Point(87, 204)
        Me.QuestionThreeLabel.Name = "QuestionThreeLabel"
        Me.QuestionThreeLabel.Size = New System.Drawing.Size(612, 66)
        Me.QuestionThreeLabel.TabIndex = 8
        Me.QuestionThreeLabel.Text = "************************* "
        '
        'QuestionTwoLabel
        '
        Me.QuestionTwoLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.QuestionTwoLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QuestionTwoLabel.Location = New System.Drawing.Point(87, 145)
        Me.QuestionTwoLabel.Name = "QuestionTwoLabel"
        Me.QuestionTwoLabel.Size = New System.Drawing.Size(612, 59)
        Me.QuestionTwoLabel.TabIndex = 7
        Me.QuestionTwoLabel.Text = "************************* "
        '
        'QuestionOneLabel
        '
        Me.QuestionOneLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.QuestionOneLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QuestionOneLabel.Location = New System.Drawing.Point(87, 86)
        Me.QuestionOneLabel.Name = "QuestionOneLabel"
        Me.QuestionOneLabel.Size = New System.Drawing.Size(612, 59)
        Me.QuestionOneLabel.TabIndex = 6
        Me.QuestionOneLabel.Text = "************************* "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(56, 203)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(19, 17)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "3)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(56, 144)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(19, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "2)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(56, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(19, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "1)"
        '
        'MainQuestionLabel
        '
        Me.MainQuestionLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MainQuestionLabel.BackColor = System.Drawing.SystemColors.ControlLight
        Me.MainQuestionLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainQuestionLabel.Location = New System.Drawing.Point(6, 20)
        Me.MainQuestionLabel.Name = "MainQuestionLabel"
        Me.MainQuestionLabel.Size = New System.Drawing.Size(809, 57)
        Me.MainQuestionLabel.TabIndex = 2
        Me.MainQuestionLabel.Text = "************************* "
        '
        'CategoryLabel
        '
        Me.CategoryLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.CategoryLabel.AutoSize = True
        Me.CategoryLabel.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CategoryLabel.ForeColor = System.Drawing.Color.Sienna
        Me.CategoryLabel.Location = New System.Drawing.Point(303, 326)
        Me.CategoryLabel.Name = "CategoryLabel"
        Me.CategoryLabel.Size = New System.Drawing.Size(47, 20)
        Me.CategoryLabel.TabIndex = 1
        Me.CategoryLabel.Text = " -****"
        '
        'ResultLabel
        '
        Me.ResultLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ResultLabel.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ResultLabel.Location = New System.Drawing.Point(299, 395)
        Me.ResultLabel.Name = "ResultLabel"
        Me.ResultLabel.Size = New System.Drawing.Size(321, 19)
        Me.ResultLabel.TabIndex = 11
        Me.ResultLabel.Text = "+++++"
        Me.ResultLabel.Visible = False
        '
        'ResultTextLabel
        '
        Me.ResultTextLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ResultTextLabel.AutoSize = True
        Me.ResultTextLabel.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ResultTextLabel.Location = New System.Drawing.Point(257, 395)
        Me.ResultTextLabel.Name = "ResultTextLabel"
        Me.ResultTextLabel.Size = New System.Drawing.Size(35, 13)
        Me.ResultTextLabel.TabIndex = 10
        Me.ResultTextLabel.Text = "Esito:"
        Me.ResultTextLabel.Visible = False
        '
        'NewExamButton
        '
        Me.NewExamButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.NewExamButton.Location = New System.Drawing.Point(10, 389)
        Me.NewExamButton.Name = "NewExamButton"
        Me.NewExamButton.Size = New System.Drawing.Size(107, 25)
        Me.NewExamButton.TabIndex = 1
        Me.NewExamButton.Text = "Nuovo Esame"
        Me.NewExamButton.UseVisualStyleBackColor = True
        '
        'AnswerCheckButton
        '
        Me.AnswerCheckButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.AnswerCheckButton.Location = New System.Drawing.Point(135, 389)
        Me.AnswerCheckButton.Name = "AnswerCheckButton"
        Me.AnswerCheckButton.Size = New System.Drawing.Size(107, 25)
        Me.AnswerCheckButton.TabIndex = 1
        Me.AnswerCheckButton.Text = "Verifica Risposte"
        Me.AnswerCheckButton.UseVisualStyleBackColor = True
        '
        'CloseButton
        '
        Me.CloseButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CloseButton.Location = New System.Drawing.Point(727, 391)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(107, 25)
        Me.CloseButton.TabIndex = 2
        Me.CloseButton.Text = "Esci"
        Me.CloseButton.UseVisualStyleBackColor = True
        '
        'ExamTimer
        '
        Me.ExamTimer.Interval = 1000
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(846, 428)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.AnswerCheckButton)
        Me.Controls.Add(Me.NewExamButton)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ResultLabel)
        Me.Controls.Add(Me.ResultTextLabel)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.Text = "Simulazione Esame ADR"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents QuestionOneFalse As RadioButton
    Friend WithEvents QuestionOneTrue As RadioButton
    Friend WithEvents QuestionThreeLabel As Label
    Friend WithEvents QuestionTwoLabel As Label
    Friend WithEvents QuestionOneLabel As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents MainQuestionLabel As Label
    Friend WithEvents CategoryLabel As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents QuestionThreeFalse As RadioButton
    Friend WithEvents QuestionThreeTrue As RadioButton
    Friend WithEvents Panel2 As Panel
    Friend WithEvents QuestionTwoFalse As RadioButton
    Friend WithEvents QuestionTwoTrue As RadioButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents IndexLabel As Label
    Friend WithEvents NextTabButton As Button
    Friend WithEvents PrevTabButton As Button
    Friend WithEvents NewExamButton As Button
    Friend WithEvents AnswerCheckButton As Button
    Friend WithEvents CloseButton As Button
    Friend WithEvents ResultLabel As Label
    Friend WithEvents ResultTextLabel As Label
    Friend WithEvents ThreeErrorLabel As Label
    Friend WithEvents TwoErrorLabel As Label
    Friend WithEvents OneErrorLabel As Label
    Friend WithEvents ExamTimer As Timer
    Friend WithEvents TimeLabel As Label
    Friend WithEvents TimeTextLabel As Label
End Class
