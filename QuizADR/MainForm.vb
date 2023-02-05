Public Class MainForm

    Private MainExam As ExamManager
    Private nCurrentIndex As Integer = 0
    Private bCorrectionMode As Boolean = False
    Private ElapsedTime As Long = 0

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Try to load Quiz.Dat and Regex
        Try
            MainExam = New ExamManager()

            NewExam()
            UpdateTab()

        Catch ex As Exception
            MsgBox("Impossibile avviare l'applicazione. Errore: " & ex.Message)
            Close()
        End Try



    End Sub

    Private Sub UpdateTab()
        Dim Tab As ADRTab

        ' Get specific tab
        Tab = MainExam.ExamTab(nCurrentIndex)

        ' Fill UI values with readed values
        With Tab
            CategoryLabel.Text = .Category
            MainQuestionLabel.Text = .MainQuestion
            QuestionOneLabel.Text = .QuestionOne
            QuestionTwoLabel.Text = .QuestionTwo
            QuestionThreeLabel.Text = .QuestionThree

            QuestionOneTrue.Checked = .UserAnswerOne
            QuestionTwoTrue.Checked = .UserAnswerTwo
            QuestionThreeTrue.Checked = .UserAnswerThree

            QuestionOneFalse.Checked = Not .UserAnswerOne
            QuestionTwoFalse.Checked = Not .UserAnswerTwo
            QuestionThreeFalse.Checked = Not .UserAnswerThree
        End With

        ' If in correction mode show errors labels
        If bCorrectionMode = True Then
            If Tab.AnswerAreCorrects = False Then
                OneErrorLabel.Visible = Not (Tab.AnswerOne = Tab.UserAnswerOne)
                TwoErrorLabel.Visible = Not (Tab.AnswerTwo = Tab.UserAnswerTwo)
                ThreeErrorLabel.Visible = Not (Tab.AnswerThree = Tab.UserAnswerThree)
            Else
                OneErrorLabel.Visible = False
                TwoErrorLabel.Visible = False
                ThreeErrorLabel.Visible = False
            End If
        End If

        ' Show user the current umber of tab
        IndexLabel.Text = (nCurrentIndex + 1).ToString & " / " & MainExam.ExamTabs.ToString
    End Sub

    Private Sub CorrectTabs()
        Dim nNumberOfErrors As Integer = 0

        bCorrectionMode = True

        ' Disable combobox
        Panel1.Enabled = False
        Panel2.Enabled = False
        Panel3.Enabled = False

        ' Sum number of errors
        For i As Integer = 0 To MainExam.ExamTabs - 1
            If MainExam.ExamTab(i).AnswerAreCorrects = False Then
                If MainExam.ExamTab(i).AnswerOne <> MainExam.ExamTab(i).UserAnswerOne Then
                    nNumberOfErrors += 1
                End If

                If MainExam.ExamTab(i).AnswerTwo <> MainExam.ExamTab(i).UserAnswerTwo Then
                    nNumberOfErrors += 1
                End If

                If MainExam.ExamTab(i).AnswerThree <> MainExam.ExamTab(i).UserAnswerThree Then
                    nNumberOfErrors += 1
                End If
            End If
        Next

        ' Show results to user
        ResultLabel.Text = String.Format("hai fatto {0} errori su {1} domande", nNumberOfErrors, MainExam.ExamTabs * 3)
        ResultLabel.Visible = True
        ResultTextLabel.Visible = True

        ' Update graphics
        nCurrentIndex = 0
        UpdateTab()

        ' Disable exam timer
        ElapsedTime = 0
        TimeTextLabel.Visible = False
        TimeLabel.Visible = False
        ExamTimer.Enabled = False

    End Sub

    Private Sub NewExam()
        bCorrectionMode = False

        ' Hide errors label
        OneErrorLabel.Visible = False
        TwoErrorLabel.Visible = False
        ThreeErrorLabel.Visible = False

        ' Hide result label
        ResultLabel.Visible = False
        ResultTextLabel.Visible = False

        ' Enable combobox
        Panel1.Enabled = True
        Panel2.Enabled = True
        Panel3.Enabled = True

        ' Reset Index
        nCurrentIndex = 0

        ' Create new exam
        MainExam.ClearExam()
        MainExam.NewExam()

        ' Update graphics
        UpdateTab()

        ' Enable exam timer
        ElapsedTime = 0
        TimeTextLabel.Visible = True
        TimeLabel.Visible = True
        ExamTimer.Enabled = True
    End Sub

    Private Sub NextTabButton_Click(sender As Object, e As EventArgs) Handles NextTabButton.Click
        ' Next tab
        nCurrentIndex += 1

        If nCurrentIndex > MainExam.ExamTabs - 1 Then
            nCurrentIndex = MainExam.ExamTabs - 1
        End If

        UpdateTab()
    End Sub

    Private Sub PrevTabButton_Click(sender As Object, e As EventArgs) Handles PrevTabButton.Click
        ' Previous tab
        nCurrentIndex -= 1

        If nCurrentIndex < 0 Then
            nCurrentIndex = 0
        End If

        UpdateTab()
    End Sub

    Private Sub QuestionOneTrue_CheckedChanged(sender As Object, e As EventArgs) Handles QuestionOneTrue.CheckedChanged
        MainExam.ExamTab(nCurrentIndex).UserAnswerOne = QuestionOneTrue.Checked
    End Sub

    Private Sub QuestionOneFalse_CheckedChanged(sender As Object, e As EventArgs) Handles QuestionOneFalse.CheckedChanged
        MainExam.ExamTab(nCurrentIndex).UserAnswerOne = QuestionOneTrue.Checked
    End Sub

    Private Sub QuestionTwoTrue_CheckedChanged(sender As Object, e As EventArgs) Handles QuestionTwoTrue.CheckedChanged
        MainExam.ExamTab(nCurrentIndex).UserAnswerTwo = QuestionTwoTrue.Checked
    End Sub

    Private Sub QuestionTwoFalse_CheckedChanged(sender As Object, e As EventArgs) Handles QuestionTwoFalse.CheckedChanged
        MainExam.ExamTab(nCurrentIndex).UserAnswerTwo = QuestionTwoTrue.Checked
    End Sub

    Private Sub QuestionThreeTrue_CheckedChanged(sender As Object, e As EventArgs) Handles QuestionThreeTrue.CheckedChanged
        MainExam.ExamTab(nCurrentIndex).UserAnswerThree = QuestionThreeTrue.Checked
    End Sub
    Private Sub QuestionThreeFalse_CheckedChanged(sender As Object, e As EventArgs) Handles QuestionThreeFalse.CheckedChanged
        MainExam.ExamTab(nCurrentIndex).UserAnswerThree = QuestionThreeTrue.Checked
    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        ' Ask user if exit program
        If MessageBox.Show("Uscire dal programma?", "Quiz ADR", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub NewExamButton_Click(sender As Object, e As EventArgs) Handles NewExamButton.Click

        ' Ask user if start new session
        If MessageBox.Show("Iniziare un nuovo esame?", "Quiz ADR", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            NewExam()
        End If

    End Sub

    Private Sub AnswerCheckButton_Click(sender As Object, e As EventArgs) Handles AnswerCheckButton.Click
        ' Ask user if start new session
        If MessageBox.Show("Correggere tutte le schede?", "Quiz ADR", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            CorrectTabs()
        End If
    End Sub

    Private Sub ExamTimer_Tick(sender As Object, e As EventArgs) Handles ExamTimer.Tick
        ' Show elapsed time to user
        With TimeSpan.FromSeconds(ElapsedTime)
            TimeLabel.Text = Format(.Hours, "0") &
                                  ":" & Fix(.Minutes).ToString &
                                  ":" & Format(.Seconds, "00")
        End With

        ' Increment 1 second
        ElapsedTime += 1
    End Sub
End Class
