﻿Imports System
Imports System.Linq
Imports System.Data
Imports System.Data.Entity
Imports System.Linq.Expressions
Imports System.Collections.Generic
Imports Scaffolding.CustomFilter.Common.Utils
Imports Scaffolding.CustomFilter.Common.DataModel
Imports Scaffolding.CustomFilter.Common.DataModel.EntityFramework
Imports Scaffolding.CustomFilter.Model

Namespace Scaffolding.CustomFilter.IssueContextDataModel
    ''' <summary>
    ''' A IssueContextDesignTimeUnitOfWork instance that represents the design-time implementation of the IIssueContextUnitOfWork interface.
    ''' </summary>
    Public Class IssueContextDesignTimeUnitOfWork
        Inherits DesignTimeUnitOfWork
        Implements IIssueContextUnitOfWork

        ''' <summary>
        ''' Initializes a new instance of the IssueContextDesignTimeUnitOfWork class.
        ''' </summary>
        Public Sub New()
        End Sub

        Private ReadOnly Property IIssueContextUnitOfWork_Issues() As IRepository(Of Issue, Integer) Implements IIssueContextUnitOfWork.Issues
            Get
                Return GetRepository(Function(x As Issue) x.ID)
            End Get
        End Property
    End Class
End Namespace
