﻿Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.Http
Imports System.Web.Routing

Namespace DxSample.Service
	Public Class WebApiApplication
		Inherits System.Web.HttpApplication

		Protected Sub Application_Start()
			GlobalConfiguration.Configure(AddressOf WebApiConfig.Register)
		End Sub
	End Class
End Namespace
