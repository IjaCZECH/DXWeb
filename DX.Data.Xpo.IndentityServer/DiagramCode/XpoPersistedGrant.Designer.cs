﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace DX.Data.Xpo.IndentityServer.XPModels
{

	[Persistent(@"DXPersistedGrants")]
	public partial class XpoPersistedGrant : XPLiteObject
	{
		[Key]
		[Size(50)]
		[Persistent(@"Id")]
		string _Id;
		[PersistentAlias("_Id")]
		public string Id
		{
			get { return _Id; }
		}
		string _Type;
		[Indexed(@"SubjectId;ClientId", Name = @"IDXGrant_Subject_Client_Type")]
		[Size(50)]
		public string Type
		{
			get { return _Type; }
			set { SetPropertyValue<string>(nameof(Type), ref _Type, value); }
		}
		string _SubjectId;
		[Size(200)]
		public string SubjectId
		{
			get { return _SubjectId; }
			set { SetPropertyValue<string>(nameof(SubjectId), ref _SubjectId, value); }
		}
		string _ClientId;
		[Size(200)]
		public string ClientId
		{
			get { return _ClientId; }
			set { SetPropertyValue<string>(nameof(ClientId), ref _ClientId, value); }
		}
		string _Description;
		[Size(200)]
		public string Description
		{
			get { return _Description; }
			set { SetPropertyValue<string>(nameof(Description), ref _Description, value); }
		}
		DateTime _CreationTime;
		public DateTime CreationTime
		{
			get { return _CreationTime; }
			set { SetPropertyValue<DateTime>(nameof(CreationTime), ref _CreationTime, value); }
		}
		DateTime? _Expiration;
		[Indexed(Name = @"IDXGrant_Expiration")]
		public DateTime? Expiration
		{
			get { return _Expiration; }
			set { SetPropertyValue<DateTime?>(nameof(Expiration), ref _Expiration, value); }
		}
		string _Data;
		[Size(SizeAttribute.Unlimited)]
		public string Data
		{
			get { return _Data; }
			set { SetPropertyValue<string>(nameof(Data), ref _Data, value); }
		}
	}

}
