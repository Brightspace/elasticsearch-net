// ███╗   ██╗ ██████╗ ████████╗██╗ ██████╗███████╗
// ████╗  ██║██╔═══██╗╚══██╔══╝██║██╔════╝██╔════╝
// ██╔██╗ ██║██║   ██║   ██║   ██║██║     █████╗  
// ██║╚██╗██║██║   ██║   ██║   ██║██║     ██╔══╝  
// ██║ ╚████║╚██████╔╝   ██║   ██║╚██████╗███████╗
// ╚═╝  ╚═══╝ ╚═════╝    ╚═╝   ╚═╝ ╚═════╝╚══════╝
// -----------------------------------------------
//  
// This file is automatically generated 
// Please do not edit these files manually
// Run the following in the root of the repos:
//
// 		*NIX 		:	./build.sh codegen
// 		Windows 	:	build.bat codegen
//
// -----------------------------------------------
// ReSharper disable RedundantUsingDirective
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Expressions;
using Elasticsearch.Net;
using Elasticsearch.Net.Utf8Json;
using Elasticsearch.Net.Specification.SnapshotLifecycleManagementApi;

// ReSharper disable RedundantBaseConstructorCall
// ReSharper disable UnusedTypeParameter
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable RedundantNameQualifier
namespace Nest
{
	///<summary>Descriptor for DeleteSnapshotLifecycle <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/slm-api-delete.html</para></summary>
	public partial class DeleteSnapshotLifecycleDescriptor : RequestDescriptorBase<DeleteSnapshotLifecycleDescriptor, DeleteSnapshotLifecycleRequestParameters, IDeleteSnapshotLifecycleRequest>, IDeleteSnapshotLifecycleRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.SnapshotLifecycleManagementDeleteSnapshotLifecycle;
		///<summary>/_slm/policy/{policy_id}</summary>
		///<param name = "policyId">this parameter is required</param>
		public DeleteSnapshotLifecycleDescriptor(Id policyId): base(r => r.Required("policy_id", policyId))
		{
		}

		///<summary>Used for serialization purposes, making sure we have a parameterless constructor</summary>
		[SerializationConstructor]
		protected DeleteSnapshotLifecycleDescriptor(): base()
		{
		}

		// values part of the url path
		Id IDeleteSnapshotLifecycleRequest.PolicyId => Self.RouteValues.Get<Id>("policy_id");
	// Request parameters
	}

	///<summary>Descriptor for ExecuteSnapshotLifecycle <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/slm-api-execute.html</para></summary>
	public partial class ExecuteSnapshotLifecycleDescriptor : RequestDescriptorBase<ExecuteSnapshotLifecycleDescriptor, ExecuteSnapshotLifecycleRequestParameters, IExecuteSnapshotLifecycleRequest>, IExecuteSnapshotLifecycleRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.SnapshotLifecycleManagementExecuteSnapshotLifecycle;
		///<summary>/_slm/policy/{policy_id}/_execute</summary>
		///<param name = "policyId">this parameter is required</param>
		public ExecuteSnapshotLifecycleDescriptor(Id policyId): base(r => r.Required("policy_id", policyId))
		{
		}

		///<summary>Used for serialization purposes, making sure we have a parameterless constructor</summary>
		[SerializationConstructor]
		protected ExecuteSnapshotLifecycleDescriptor(): base()
		{
		}

		// values part of the url path
		Id IExecuteSnapshotLifecycleRequest.PolicyId => Self.RouteValues.Get<Id>("policy_id");
	// Request parameters
	}

	///<summary>Descriptor for GetSnapshotLifecycle <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/slm-api-get.html</para></summary>
	public partial class GetSnapshotLifecycleDescriptor : RequestDescriptorBase<GetSnapshotLifecycleDescriptor, GetSnapshotLifecycleRequestParameters, IGetSnapshotLifecycleRequest>, IGetSnapshotLifecycleRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.SnapshotLifecycleManagementGetSnapshotLifecycle;
		///<summary>/_slm/policy/{policy_id}</summary>
		///<param name = "policyId">Optional, accepts null</param>
		public GetSnapshotLifecycleDescriptor(Ids policyId): base(r => r.Optional("policy_id", policyId))
		{
		}

		///<summary>/_slm/policy</summary>
		public GetSnapshotLifecycleDescriptor(): base()
		{
		}

		// values part of the url path
		Ids IGetSnapshotLifecycleRequest.PolicyId => Self.RouteValues.Get<Ids>("policy_id");
		///<summary>Comma-separated list of snapshot lifecycle policies to retrieve</summary>
		public GetSnapshotLifecycleDescriptor PolicyId(Ids policyId) => Assign(policyId, (a, v) => a.RouteValues.Optional("policy_id", v));
	// Request parameters
	}

	///<summary>Descriptor for GetStatus <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/slm-get-status.html</para></summary>
	public partial class GetSlmStatusDescriptor : RequestDescriptorBase<GetSlmStatusDescriptor, GetSlmStatusRequestParameters, IGetSlmStatusRequest>, IGetSlmStatusRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.SnapshotLifecycleManagementGetStatus;
	// values part of the url path
	// Request parameters
	}

	///<summary>Descriptor for PutSnapshotLifecycle <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/slm-api-put.html</para></summary>
	public partial class PutSnapshotLifecycleDescriptor : RequestDescriptorBase<PutSnapshotLifecycleDescriptor, PutSnapshotLifecycleRequestParameters, IPutSnapshotLifecycleRequest>, IPutSnapshotLifecycleRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.SnapshotLifecycleManagementPutSnapshotLifecycle;
		///<summary>/_slm/policy/{policy_id}</summary>
		///<param name = "policyId">this parameter is required</param>
		public PutSnapshotLifecycleDescriptor(Id policyId): base(r => r.Required("policy_id", policyId))
		{
		}

		///<summary>Used for serialization purposes, making sure we have a parameterless constructor</summary>
		[SerializationConstructor]
		protected PutSnapshotLifecycleDescriptor(): base()
		{
		}

		// values part of the url path
		Id IPutSnapshotLifecycleRequest.PolicyId => Self.RouteValues.Get<Id>("policy_id");
	// Request parameters
	}

	///<summary>Descriptor for Start <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/slm-start.html</para></summary>
	public partial class StartSlmDescriptor : RequestDescriptorBase<StartSlmDescriptor, StartSlmRequestParameters, IStartSlmRequest>, IStartSlmRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.SnapshotLifecycleManagementStart;
	// values part of the url path
	// Request parameters
	}

	///<summary>Descriptor for Stop <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/slm-stop.html</para></summary>
	public partial class StopSlmDescriptor : RequestDescriptorBase<StopSlmDescriptor, StopSlmRequestParameters, IStopSlmRequest>, IStopSlmRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.SnapshotLifecycleManagementStop;
	// values part of the url path
	// Request parameters
	}
}