﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:2.0.50727.1318
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On

Imports System.Runtime.Serialization

Namespace BenchService
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0"),  _
     System.Runtime.Serialization.DataContractAttribute([Namespace]:="http://schemas.datacontract.org/2004/07/")>  _
    Partial Public Class ConsultantData
        Inherits Object
        Implements System.Runtime.Serialization.IExtensibleDataObject
        
        Private extensionDataField As System.Runtime.Serialization.ExtensionDataObject
        
        Private IdField As Integer
        
        Private NameField As String
        
        Private OnBenchField As Boolean
        
        <Global.System.ComponentModel.BrowsableAttribute(false)>  _
        Public Property ExtensionData() As System.Runtime.Serialization.ExtensionDataObject Implements System.Runtime.Serialization.IExtensibleDataObject.ExtensionData
            Get
                Return Me.extensionDataField
            End Get
            Set
                Me.extensionDataField = value
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property Id() As Integer
            Get
                Return Me.IdField
            End Get
            Set
                Me.IdField = value
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property Name() As String
            Get
                Return Me.NameField
            End Get
            Set
                Me.NameField = value
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property OnBench() As Boolean
            Get
                Return Me.OnBenchField
            End Get
            Set
                Me.OnBenchField = value
            End Set
        End Property
    End Class
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0"),  _
     System.Runtime.Serialization.DataContractAttribute([Namespace]:="http://schemas.datacontract.org/2004/07/")>  _
    Partial Public Class ConsultantUpdateData
        Inherits Object
        Implements System.Runtime.Serialization.IExtensibleDataObject
        
        Private extensionDataField As System.Runtime.Serialization.ExtensionDataObject
        
        Private DeleteField As Boolean
        
        Private IdField As Integer
        
        Private IsNewField As Boolean
        
        Private NameField As String
        
        Private OnBenchField As Boolean
        
        <Global.System.ComponentModel.BrowsableAttribute(false)>  _
        Public Property ExtensionData() As System.Runtime.Serialization.ExtensionDataObject Implements System.Runtime.Serialization.IExtensibleDataObject.ExtensionData
            Get
                Return Me.extensionDataField
            End Get
            Set
                Me.extensionDataField = value
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property Delete() As Boolean
            Get
                Return Me.DeleteField
            End Get
            Set
                Me.DeleteField = value
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property Id() As Integer
            Get
                Return Me.IdField
            End Get
            Set
                Me.IdField = value
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property IsNew() As Boolean
            Get
                Return Me.IsNewField
            End Get
            Set
                Me.IsNewField = value
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property Name() As String
            Get
                Return Me.NameField
            End Get
            Set
                Me.NameField = value
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property OnBench() As Boolean
            Get
                Return Me.OnBenchField
            End Get
            Set
                Me.OnBenchField = value
            End Set
        End Property
    End Class
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0"),  _
     System.Runtime.Serialization.DataContractAttribute([Namespace]:="http://schemas.datacontract.org/2004/07/")>  _
    Partial Public Class ProjectData
        Inherits Object
        Implements System.Runtime.Serialization.IExtensibleDataObject
        
        Private extensionDataField As System.Runtime.Serialization.ExtensionDataObject
        
        Private ProjectIdField As Integer
        
        <Global.System.ComponentModel.BrowsableAttribute(false)>  _
        Public Property ExtensionData() As System.Runtime.Serialization.ExtensionDataObject Implements System.Runtime.Serialization.IExtensibleDataObject.ExtensionData
            Get
                Return Me.extensionDataField
            End Get
            Set
                Me.extensionDataField = value
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property ProjectId() As Integer
            Get
                Return Me.ProjectIdField
            End Get
            Set
                Me.ProjectIdField = value
            End Set
        End Property
    End Class
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0"),  _
     System.Runtime.Serialization.DataContractAttribute([Namespace]:="http://schemas.datacontract.org/2004/07/")>  _
    Partial Public Class ProjectUpdateData
        Inherits Object
        Implements System.Runtime.Serialization.IExtensibleDataObject
        
        Private extensionDataField As System.Runtime.Serialization.ExtensionDataObject
        
        Private DeleteField As Boolean
        
        Private IsNewField As Boolean
        
        Private ProjectIdField As Integer
        
        <Global.System.ComponentModel.BrowsableAttribute(false)>  _
        Public Property ExtensionData() As System.Runtime.Serialization.ExtensionDataObject Implements System.Runtime.Serialization.IExtensibleDataObject.ExtensionData
            Get
                Return Me.extensionDataField
            End Get
            Set
                Me.extensionDataField = value
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property Delete() As Boolean
            Get
                Return Me.DeleteField
            End Get
            Set
                Me.DeleteField = value
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property IsNew() As Boolean
            Get
                Return Me.IsNewField
            End Get
            Set
                Me.IsNewField = value
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property ProjectId() As Integer
            Get
                Return Me.ProjectIdField
            End Get
            Set
                Me.ProjectIdField = value
            End Set
        End Property
    End Class
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0"),  _
     System.ServiceModel.ServiceContractAttribute(ConfigurationName:="BenchService.IBenchService")>  _
    Public Interface IBenchService
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IBenchService/GetConsultantList", ReplyAction:="http://tempuri.org/IBenchService/GetConsultantListResponse")>  _
        Function GetConsultantList(ByVal benchOnly As Boolean) As BenchService.ConsultantData()
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IBenchService/GetConsultant", ReplyAction:="http://tempuri.org/IBenchService/GetConsultantResponse")>  _
        Function GetConsultant(ByVal id As Integer) As BenchService.ConsultantData
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IBenchService/UpdateConsultant", ReplyAction:="http://tempuri.org/IBenchService/UpdateConsultantResponse")>  _
        Function UpdateConsultant(ByVal consultant As BenchService.ConsultantUpdateData) As BenchService.ConsultantData
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IBenchService/GetProjectList", ReplyAction:="http://tempuri.org/IBenchService/GetProjectListResponse")>  _
        Function GetProjectList(ByVal consultantId As Integer) As BenchService.ProjectData()
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IBenchService/UpdateProjects", ReplyAction:="http://tempuri.org/IBenchService/UpdateProjectsResponse")>  _
        Sub UpdateProjects(ByVal consultantId As Integer, ByVal projects() As BenchService.ProjectUpdateData)
    End Interface
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")>  _
    Public Interface IBenchServiceChannel
        Inherits BenchService.IBenchService, System.ServiceModel.IClientChannel
    End Interface
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")>  _
    Partial Public Class BenchServiceClient
        Inherits System.ServiceModel.ClientBase(Of BenchService.IBenchService)
        Implements BenchService.IBenchService
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String)
            MyBase.New(endpointConfigurationName)
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As String)
            MyBase.New(endpointConfigurationName, remoteAddress)
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
            MyBase.New(endpointConfigurationName, remoteAddress)
        End Sub
        
        Public Sub New(ByVal binding As System.ServiceModel.Channels.Binding, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
            MyBase.New(binding, remoteAddress)
        End Sub
        
        Public Function GetConsultantList(ByVal benchOnly As Boolean) As BenchService.ConsultantData() Implements BenchService.IBenchService.GetConsultantList
            Return MyBase.Channel.GetConsultantList(benchOnly)
        End Function
        
        Public Function GetConsultant(ByVal id As Integer) As BenchService.ConsultantData Implements BenchService.IBenchService.GetConsultant
            Return MyBase.Channel.GetConsultant(id)
        End Function
        
        Public Function UpdateConsultant(ByVal consultant As BenchService.ConsultantUpdateData) As BenchService.ConsultantData Implements BenchService.IBenchService.UpdateConsultant
            Return MyBase.Channel.UpdateConsultant(consultant)
        End Function
        
        Public Function GetProjectList(ByVal consultantId As Integer) As BenchService.ProjectData() Implements BenchService.IBenchService.GetProjectList
            Return MyBase.Channel.GetProjectList(consultantId)
        End Function
        
        Public Sub UpdateProjects(ByVal consultantId As Integer, ByVal projects() As BenchService.ProjectUpdateData) Implements BenchService.IBenchService.UpdateProjects
            MyBase.Channel.UpdateProjects(consultantId, projects)
        End Sub
    End Class
End Namespace