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
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Elasticsearch.Net;
using static Elasticsearch.Net.HttpMethod;

// ReSharper disable InterpolatedStringExpressionIsNotIFormattable
// ReSharper disable once CheckNamespace
// ReSharper disable InterpolatedStringExpressionIsNotIFormattable
// ReSharper disable RedundantExtendsListEntry
namespace Elasticsearch.Net.Specification.SnapshotApi
{
	///<summary>
	/// Snapshot APIs.
	/// <para>Not intended to be instantiated directly. Use the <see cref = "IElasticLowLevelClient.Snapshot"/> property
	/// on <see cref = "IElasticLowLevelClient"/>.
	///</para>
	///</summary>
	public partial class LowLevelSnapshotNamespace : NamespacedClientProxy
	{
		internal LowLevelSnapshotNamespace(ElasticLowLevelClient client): base(client)
		{
		}

		///<summary>POST on /_snapshot/{repository}/_cleanup <para>https://www.elastic.co/guide/en/elasticsearch/reference/master/clean-up-snapshot-repo-api.html</para></summary>
		///<param name = "repository">A repository name</param>
		///<param name = "body"></param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse CleanupRepository<TResponse>(string repository, PostData body, CleanupRepositoryRequestParameters requestParameters = null)
			where TResponse : class, IElasticsearchResponse, new() => DoRequest<TResponse>(POST, Url($"_snapshot/{repository:repository}/_cleanup"), body, RequestParams(requestParameters));
		///<summary>POST on /_snapshot/{repository}/_cleanup <para>https://www.elastic.co/guide/en/elasticsearch/reference/master/clean-up-snapshot-repo-api.html</para></summary>
		///<param name = "repository">A repository name</param>
		///<param name = "body"></param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		[MapsApi("snapshot.cleanup_repository", "repository, body")]
		public Task<TResponse> CleanupRepositoryAsync<TResponse>(string repository, PostData body, CleanupRepositoryRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IElasticsearchResponse, new() => DoRequestAsync<TResponse>(POST, Url($"_snapshot/{repository:repository}/_cleanup"), ctx, body, RequestParams(requestParameters));
		///<summary>PUT on /_snapshot/{repository}/{snapshot} <para>https://www.elastic.co/guide/en/elasticsearch/reference/master/modules-snapshots.html</para></summary>
		///<param name = "repository">A repository name</param>
		///<param name = "snapshot">A snapshot name</param>
		///<param name = "body">The snapshot definition</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse Snapshot<TResponse>(string repository, string snapshot, PostData body, SnapshotRequestParameters requestParameters = null)
			where TResponse : class, IElasticsearchResponse, new() => DoRequest<TResponse>(PUT, Url($"_snapshot/{repository:repository}/{snapshot:snapshot}"), body, RequestParams(requestParameters));
		///<summary>PUT on /_snapshot/{repository}/{snapshot} <para>https://www.elastic.co/guide/en/elasticsearch/reference/master/modules-snapshots.html</para></summary>
		///<param name = "repository">A repository name</param>
		///<param name = "snapshot">A snapshot name</param>
		///<param name = "body">The snapshot definition</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		[MapsApi("snapshot.create", "repository, snapshot, body")]
		public Task<TResponse> SnapshotAsync<TResponse>(string repository, string snapshot, PostData body, SnapshotRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IElasticsearchResponse, new() => DoRequestAsync<TResponse>(PUT, Url($"_snapshot/{repository:repository}/{snapshot:snapshot}"), ctx, body, RequestParams(requestParameters));
		///<summary>PUT on /_snapshot/{repository} <para>https://www.elastic.co/guide/en/elasticsearch/reference/master/modules-snapshots.html</para></summary>
		///<param name = "repository">A repository name</param>
		///<param name = "body">The repository definition</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse CreateRepository<TResponse>(string repository, PostData body, CreateRepositoryRequestParameters requestParameters = null)
			where TResponse : class, IElasticsearchResponse, new() => DoRequest<TResponse>(PUT, Url($"_snapshot/{repository:repository}"), body, RequestParams(requestParameters));
		///<summary>PUT on /_snapshot/{repository} <para>https://www.elastic.co/guide/en/elasticsearch/reference/master/modules-snapshots.html</para></summary>
		///<param name = "repository">A repository name</param>
		///<param name = "body">The repository definition</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		[MapsApi("snapshot.create_repository", "repository, body")]
		public Task<TResponse> CreateRepositoryAsync<TResponse>(string repository, PostData body, CreateRepositoryRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IElasticsearchResponse, new() => DoRequestAsync<TResponse>(PUT, Url($"_snapshot/{repository:repository}"), ctx, body, RequestParams(requestParameters));
		///<summary>DELETE on /_snapshot/{repository}/{snapshot} <para>https://www.elastic.co/guide/en/elasticsearch/reference/master/modules-snapshots.html</para></summary>
		///<param name = "repository">A repository name</param>
		///<param name = "snapshot">A snapshot name</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse Delete<TResponse>(string repository, string snapshot, DeleteSnapshotRequestParameters requestParameters = null)
			where TResponse : class, IElasticsearchResponse, new() => DoRequest<TResponse>(DELETE, Url($"_snapshot/{repository:repository}/{snapshot:snapshot}"), null, RequestParams(requestParameters));
		///<summary>DELETE on /_snapshot/{repository}/{snapshot} <para>https://www.elastic.co/guide/en/elasticsearch/reference/master/modules-snapshots.html</para></summary>
		///<param name = "repository">A repository name</param>
		///<param name = "snapshot">A snapshot name</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		[MapsApi("snapshot.delete", "repository, snapshot")]
		public Task<TResponse> DeleteAsync<TResponse>(string repository, string snapshot, DeleteSnapshotRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IElasticsearchResponse, new() => DoRequestAsync<TResponse>(DELETE, Url($"_snapshot/{repository:repository}/{snapshot:snapshot}"), ctx, null, RequestParams(requestParameters));
		///<summary>DELETE on /_snapshot/{repository} <para>https://www.elastic.co/guide/en/elasticsearch/reference/master/modules-snapshots.html</para></summary>
		///<param name = "repository">Name of the snapshot repository to unregister. Wildcard (`*`) patterns are supported.</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse DeleteRepository<TResponse>(string repository, DeleteRepositoryRequestParameters requestParameters = null)
			where TResponse : class, IElasticsearchResponse, new() => DoRequest<TResponse>(DELETE, Url($"_snapshot/{repository:repository}"), null, RequestParams(requestParameters));
		///<summary>DELETE on /_snapshot/{repository} <para>https://www.elastic.co/guide/en/elasticsearch/reference/master/modules-snapshots.html</para></summary>
		///<param name = "repository">Name of the snapshot repository to unregister. Wildcard (`*`) patterns are supported.</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		[MapsApi("snapshot.delete_repository", "repository")]
		public Task<TResponse> DeleteRepositoryAsync<TResponse>(string repository, DeleteRepositoryRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IElasticsearchResponse, new() => DoRequestAsync<TResponse>(DELETE, Url($"_snapshot/{repository:repository}"), ctx, null, RequestParams(requestParameters));
		///<summary>GET on /_snapshot/{repository}/{snapshot} <para>https://www.elastic.co/guide/en/elasticsearch/reference/master/modules-snapshots.html</para></summary>
		///<param name = "repository">A repository name</param>
		///<param name = "snapshot">A comma-separated list of snapshot names</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse Get<TResponse>(string repository, string snapshot, GetSnapshotRequestParameters requestParameters = null)
			where TResponse : class, IElasticsearchResponse, new() => DoRequest<TResponse>(GET, Url($"_snapshot/{repository:repository}/{snapshot:snapshot}"), null, RequestParams(requestParameters));
		///<summary>GET on /_snapshot/{repository}/{snapshot} <para>https://www.elastic.co/guide/en/elasticsearch/reference/master/modules-snapshots.html</para></summary>
		///<param name = "repository">A repository name</param>
		///<param name = "snapshot">A comma-separated list of snapshot names</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		[MapsApi("snapshot.get", "repository, snapshot")]
		public Task<TResponse> GetAsync<TResponse>(string repository, string snapshot, GetSnapshotRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IElasticsearchResponse, new() => DoRequestAsync<TResponse>(GET, Url($"_snapshot/{repository:repository}/{snapshot:snapshot}"), ctx, null, RequestParams(requestParameters));
		///<summary>GET on /_snapshot <para>https://www.elastic.co/guide/en/elasticsearch/reference/master/modules-snapshots.html</para></summary>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse GetRepository<TResponse>(GetRepositoryRequestParameters requestParameters = null)
			where TResponse : class, IElasticsearchResponse, new() => DoRequest<TResponse>(GET, "_snapshot", null, RequestParams(requestParameters));
		///<summary>GET on /_snapshot <para>https://www.elastic.co/guide/en/elasticsearch/reference/master/modules-snapshots.html</para></summary>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		[MapsApi("snapshot.get_repository", "")]
		public Task<TResponse> GetRepositoryAsync<TResponse>(GetRepositoryRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IElasticsearchResponse, new() => DoRequestAsync<TResponse>(GET, "_snapshot", ctx, null, RequestParams(requestParameters));
		///<summary>GET on /_snapshot/{repository} <para>https://www.elastic.co/guide/en/elasticsearch/reference/master/modules-snapshots.html</para></summary>
		///<param name = "repository">A comma-separated list of repository names</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse GetRepository<TResponse>(string repository, GetRepositoryRequestParameters requestParameters = null)
			where TResponse : class, IElasticsearchResponse, new() => DoRequest<TResponse>(GET, Url($"_snapshot/{repository:repository}"), null, RequestParams(requestParameters));
		///<summary>GET on /_snapshot/{repository} <para>https://www.elastic.co/guide/en/elasticsearch/reference/master/modules-snapshots.html</para></summary>
		///<param name = "repository">A comma-separated list of repository names</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		[MapsApi("snapshot.get_repository", "repository")]
		public Task<TResponse> GetRepositoryAsync<TResponse>(string repository, GetRepositoryRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IElasticsearchResponse, new() => DoRequestAsync<TResponse>(GET, Url($"_snapshot/{repository:repository}"), ctx, null, RequestParams(requestParameters));
		///<summary>POST on /_snapshot/{repository}/{snapshot}/_restore <para>https://www.elastic.co/guide/en/elasticsearch/reference/master/modules-snapshots.html</para></summary>
		///<param name = "repository">A repository name</param>
		///<param name = "snapshot">A snapshot name</param>
		///<param name = "body">Details of what to restore</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse Restore<TResponse>(string repository, string snapshot, PostData body, RestoreRequestParameters requestParameters = null)
			where TResponse : class, IElasticsearchResponse, new() => DoRequest<TResponse>(POST, Url($"_snapshot/{repository:repository}/{snapshot:snapshot}/_restore"), body, RequestParams(requestParameters));
		///<summary>POST on /_snapshot/{repository}/{snapshot}/_restore <para>https://www.elastic.co/guide/en/elasticsearch/reference/master/modules-snapshots.html</para></summary>
		///<param name = "repository">A repository name</param>
		///<param name = "snapshot">A snapshot name</param>
		///<param name = "body">Details of what to restore</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		[MapsApi("snapshot.restore", "repository, snapshot, body")]
		public Task<TResponse> RestoreAsync<TResponse>(string repository, string snapshot, PostData body, RestoreRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IElasticsearchResponse, new() => DoRequestAsync<TResponse>(POST, Url($"_snapshot/{repository:repository}/{snapshot:snapshot}/_restore"), ctx, body, RequestParams(requestParameters));
		///<summary>GET on /_snapshot/_status <para>https://www.elastic.co/guide/en/elasticsearch/reference/master/modules-snapshots.html</para></summary>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse Status<TResponse>(SnapshotStatusRequestParameters requestParameters = null)
			where TResponse : class, IElasticsearchResponse, new() => DoRequest<TResponse>(GET, "_snapshot/_status", null, RequestParams(requestParameters));
		///<summary>GET on /_snapshot/_status <para>https://www.elastic.co/guide/en/elasticsearch/reference/master/modules-snapshots.html</para></summary>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		[MapsApi("snapshot.status", "")]
		public Task<TResponse> StatusAsync<TResponse>(SnapshotStatusRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IElasticsearchResponse, new() => DoRequestAsync<TResponse>(GET, "_snapshot/_status", ctx, null, RequestParams(requestParameters));
		///<summary>GET on /_snapshot/{repository}/_status <para>https://www.elastic.co/guide/en/elasticsearch/reference/master/modules-snapshots.html</para></summary>
		///<param name = "repository">A repository name</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse Status<TResponse>(string repository, SnapshotStatusRequestParameters requestParameters = null)
			where TResponse : class, IElasticsearchResponse, new() => DoRequest<TResponse>(GET, Url($"_snapshot/{repository:repository}/_status"), null, RequestParams(requestParameters));
		///<summary>GET on /_snapshot/{repository}/_status <para>https://www.elastic.co/guide/en/elasticsearch/reference/master/modules-snapshots.html</para></summary>
		///<param name = "repository">A repository name</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		[MapsApi("snapshot.status", "repository")]
		public Task<TResponse> StatusAsync<TResponse>(string repository, SnapshotStatusRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IElasticsearchResponse, new() => DoRequestAsync<TResponse>(GET, Url($"_snapshot/{repository:repository}/_status"), ctx, null, RequestParams(requestParameters));
		///<summary>GET on /_snapshot/{repository}/{snapshot}/_status <para>https://www.elastic.co/guide/en/elasticsearch/reference/master/modules-snapshots.html</para></summary>
		///<param name = "repository">A repository name</param>
		///<param name = "snapshot">A comma-separated list of snapshot names</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse Status<TResponse>(string repository, string snapshot, SnapshotStatusRequestParameters requestParameters = null)
			where TResponse : class, IElasticsearchResponse, new() => DoRequest<TResponse>(GET, Url($"_snapshot/{repository:repository}/{snapshot:snapshot}/_status"), null, RequestParams(requestParameters));
		///<summary>GET on /_snapshot/{repository}/{snapshot}/_status <para>https://www.elastic.co/guide/en/elasticsearch/reference/master/modules-snapshots.html</para></summary>
		///<param name = "repository">A repository name</param>
		///<param name = "snapshot">A comma-separated list of snapshot names</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		[MapsApi("snapshot.status", "repository, snapshot")]
		public Task<TResponse> StatusAsync<TResponse>(string repository, string snapshot, SnapshotStatusRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IElasticsearchResponse, new() => DoRequestAsync<TResponse>(GET, Url($"_snapshot/{repository:repository}/{snapshot:snapshot}/_status"), ctx, null, RequestParams(requestParameters));
		///<summary>POST on /_snapshot/{repository}/_verify <para>https://www.elastic.co/guide/en/elasticsearch/reference/master/modules-snapshots.html</para></summary>
		///<param name = "repository">A repository name</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse VerifyRepository<TResponse>(string repository, VerifyRepositoryRequestParameters requestParameters = null)
			where TResponse : class, IElasticsearchResponse, new() => DoRequest<TResponse>(POST, Url($"_snapshot/{repository:repository}/_verify"), null, RequestParams(requestParameters));
		///<summary>POST on /_snapshot/{repository}/_verify <para>https://www.elastic.co/guide/en/elasticsearch/reference/master/modules-snapshots.html</para></summary>
		///<param name = "repository">A repository name</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		[MapsApi("snapshot.verify_repository", "repository")]
		public Task<TResponse> VerifyRepositoryAsync<TResponse>(string repository, VerifyRepositoryRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IElasticsearchResponse, new() => DoRequestAsync<TResponse>(POST, Url($"_snapshot/{repository:repository}/_verify"), ctx, null, RequestParams(requestParameters));
	}
}