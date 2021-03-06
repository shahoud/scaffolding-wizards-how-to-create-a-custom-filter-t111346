﻿Imports System
Imports System.Linq
Imports DevExpress.Mvvm.POCO
Imports DevExpress.Mvvm.DataModel
Imports DevExpress.Mvvm.ViewModel
Imports Scaffolding.CustomFilter.IssueContextDataModel
Imports Scaffolding.CustomFilter.Common
Imports Scaffolding.CustomFilter.Model

Namespace Scaffolding.CustomFilter.ViewModels

	''' <summary>
	''' Represents the Issues collection view model.
	''' </summary>
	Partial Public Class IssueCollectionViewModel
		Inherits CollectionViewModel(Of Issue, Integer, IIssueContextUnitOfWork)

		''' <summary>
		''' Creates a new instance of IssueCollectionViewModel as a POCO view model.
		''' </summary>
		''' <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
		Public Shared Function Create(Optional ByVal unitOfWorkFactory As IUnitOfWorkFactory(Of IIssueContextUnitOfWork) = Nothing) As IssueCollectionViewModel
			Return ViewModelSource.Create(Function() New IssueCollectionViewModel(unitOfWorkFactory))
		End Function

		''' <summary>
		''' Initializes a new instance of the IssueCollectionViewModel class.
		''' This constructor is declared protected to avoid undesired instantiation of the IssueCollectionViewModel type without the POCO proxy factory.
		''' </summary>
		''' <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
		Protected Sub New(Optional ByVal unitOfWorkFactory As IUnitOfWorkFactory(Of IIssueContextUnitOfWork) = Nothing)
			MyBase.New(If(unitOfWorkFactory, UnitOfWorkSource.GetUnitOfWorkFactory()), Function(x) x.Issues)
		End Sub
	End Class
End Namespace