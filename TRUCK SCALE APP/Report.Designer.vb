﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Report
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.CrViewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'CrViewer
        '
        Me.CrViewer.ActiveViewIndex = -1
        Me.CrViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrViewer.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrViewer.DisplayBackgroundEdge = False
        Me.CrViewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrViewer.Location = New System.Drawing.Point(0, 0)
        Me.CrViewer.Name = "CrViewer"
        Me.CrViewer.ShowGotoPageButton = False
        Me.CrViewer.ShowGroupTreeButton = False
        Me.CrViewer.ShowParameterPanelButton = False
        Me.CrViewer.ShowRefreshButton = False
        Me.CrViewer.Size = New System.Drawing.Size(1184, 761)
        Me.CrViewer.TabIndex = 0
        Me.CrViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'Report
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 761)
        Me.Controls.Add(Me.CrViewer)
        Me.Name = "Report"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Report"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CrViewer As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
