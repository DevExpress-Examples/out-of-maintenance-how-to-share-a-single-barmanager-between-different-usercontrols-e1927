Imports Microsoft.VisualBasic
Imports System
Namespace B143239
	Partial Public Class PropertiesUserControl
		''' <summary> 
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary> 
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Component Designer generated code"

		''' <summary> 
		''' Required method for Designer support - do not modify 
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.dockControl = New DevExpress.XtraBars.StandaloneBarDockControl()
			Me.propertyView = New DevExpress.XtraVerticalGrid.PropertyGridControl()
			Me.propertyDescriptionView = New DevExpress.XtraVerticalGrid.PropertyDescriptionControl()
			CType(Me.propertyView, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' dockControl
			' 
			Me.dockControl.Dock = System.Windows.Forms.DockStyle.Top
			Me.dockControl.Location = New System.Drawing.Point(0, 0)
			Me.dockControl.Name = "dockControl"
			Me.dockControl.Size = New System.Drawing.Size(423, 23)
			Me.dockControl.Text = "standaloneBarDockControl1"
			' 
			' propertyView
			' 
			Me.propertyView.AutoGenerateRows = True
			Me.propertyView.Dock = System.Windows.Forms.DockStyle.Fill
			Me.propertyView.Location = New System.Drawing.Point(0, 23)
			Me.propertyView.Name = "propertyView"
			Me.propertyView.OptionsBehavior.Editable = False
			Me.propertyView.Size = New System.Drawing.Size(423, 222)
			Me.propertyView.TabIndex = 1
			' 
			' propertyDescriptionView
			' 
			Me.propertyDescriptionView.Dock = System.Windows.Forms.DockStyle.Bottom
			Me.propertyDescriptionView.Location = New System.Drawing.Point(0, 245)
			Me.propertyDescriptionView.Name = "propertyDescriptionView"
			Me.propertyDescriptionView.Size = New System.Drawing.Size(423, 100)
			Me.propertyDescriptionView.TabIndex = 2
			Me.propertyDescriptionView.TabStop = False
			' 
			' PropertiesUserControl
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.propertyView)
			Me.Controls.Add(Me.propertyDescriptionView)
			Me.Controls.Add(Me.dockControl)
			Me.Name = "PropertiesUserControl"
			Me.Size = New System.Drawing.Size(423, 345)
			CType(Me.propertyView, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private dockControl As DevExpress.XtraBars.StandaloneBarDockControl
		Private propertyView As DevExpress.XtraVerticalGrid.PropertyGridControl
		Private propertyDescriptionView As DevExpress.XtraVerticalGrid.PropertyDescriptionControl
	End Class
End Namespace
