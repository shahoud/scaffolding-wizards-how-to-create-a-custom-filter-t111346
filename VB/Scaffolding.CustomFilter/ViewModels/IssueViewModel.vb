Imports Microsoft.VisualBasic
Imports System
Imports System.Linq
Imports System.Linq.Expressions
Imports System.Collections.Generic
Imports System.Collections.ObjectModel
Imports DevExpress.Mvvm
Imports DevExpress.Mvvm.POCO
Imports Scaffolding.CustomFilter.Common.Utils
Imports Scaffolding.CustomFilter.IssueContextDataModel
Imports Scaffolding.CustomFilter.Common.DataModel
Imports Scaffolding.CustomFilter.Model
Imports Scaffolding.CustomFilter.Common.ViewModel

Namespace Scaffolding.CustomFilter.ViewModels
	Partial Public Class IssueViewModel
		Inherits SingleObjectViewModel(Of Issue, Integer, IIssueContextUnitOfWork)
		Public Sub New()
			Me.New(UnitOfWorkSource.GetUnitOfWorkFactory())
		End Sub
		Public Sub New(ByVal unitOfWorkFactory As IUnitOfWorkFactory(Of IIssueContextUnitOfWork))
			MyBase.New(unitOfWorkFactory, Function(x) x.Issues)
		End Sub
	End Class
End Namespace
