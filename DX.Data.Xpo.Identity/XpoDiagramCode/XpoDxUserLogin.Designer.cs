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
namespace DX.Data.Xpo.Identity.Persistent
{

	[Persistent(@"DXUserLogins")]
	public partial class XpoDxUserLogin : XpoDxBase
	{
		string _LoginProvider;
		[Indexed(@"User", Name = @"IdxUserLogin", Unique = true)]
		[Size(150)]
		public string LoginProvider
		{
			get { return _LoginProvider; }
			set { SetPropertyValue<string>("LoginProvider", ref _LoginProvider, value); }
		}
		string _ProviderKey;
		[Size(150)]
		public string ProviderKey
		{
			get { return _ProviderKey; }
			set { SetPropertyValue<string>("ProviderKey", ref _ProviderKey, value); }
		}
		XpoDxUser _User;
		[Association(@"XpoDxUserLogins")]
		public XpoDxUser User
		{
			get { return _User; }
			set { SetPropertyValue<XpoDxUser>("User", ref _User, value); }
		}
		[PersistentAlias("[User!Key]")]
		public string UserId
		{
			get { return (string)(EvaluateAlias("UserId")); }
		}
	}

}
