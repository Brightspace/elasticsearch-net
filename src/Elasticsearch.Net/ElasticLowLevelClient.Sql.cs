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
namespace Elasticsearch.Net.Specification.SqlApi
{
	///<summary>
	/// Sql APIs.
	/// <para>Not intended to be instantiated directly. Use the <see cref = "IElasticLowLevelClient.Sql"/> property
	/// on <see cref = "IElasticLowLevelClient"/>.
	///</para>
	///</summary>
	public partial class LowLevelSqlNamespace : NamespacedClientProxy
	{
		internal LowLevelSqlNamespace(ElasticLowLevelClient client): base(client)
		{
		}

		///<summary>POST on /_sql/close <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/sql-pagination.html</para></summary>
		///<param name = "body">Specify the cursor value in the `cursor` element to clean the cursor.</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse ClearCursor<TResponse>(PostData body, ClearSqlCursorRequestParameters requestParameters = null)
			where TResponse : class, IElasticsearchResponse, new() => DoRequest<TResponse>(POST, "_sql/close", body, RequestParams(requestParameters));
		///<summary>POST on /_sql/close <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/sql-pagination.html</para></summary>
		///<param name = "body">Specify the cursor value in the `cursor` element to clean the cursor.</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		[MapsApi("sql.clear_cursor", "body")]
		public Task<TResponse> ClearCursorAsync<TResponse>(PostData body, ClearSqlCursorRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IElasticsearchResponse, new() => DoRequestAsync<TResponse>(POST, "_sql/close", ctx, body, RequestParams(requestParameters));
		///<summary>POST on /_sql <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/sql-rest-overview.html</para></summary>
		///<param name = "body">Use the `query` element to start a query. Use the `cursor` element to continue a query.</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse Query<TResponse>(PostData body, QuerySqlRequestParameters requestParameters = null)
			where TResponse : class, IElasticsearchResponse, new() => DoRequest<TResponse>(POST, "_sql", body, RequestParams(requestParameters));
		///<summary>POST on /_sql <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/sql-rest-overview.html</para></summary>
		///<param name = "body">Use the `query` element to start a query. Use the `cursor` element to continue a query.</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		[MapsApi("sql.query", "body")]
		public Task<TResponse> QueryAsync<TResponse>(PostData body, QuerySqlRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IElasticsearchResponse, new() => DoRequestAsync<TResponse>(POST, "_sql", ctx, body, RequestParams(requestParameters));
		///<summary>POST on /_sql/translate <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/sql-translate.html</para></summary>
		///<param name = "body">Specify the query in the `query` element.</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse Translate<TResponse>(PostData body, TranslateSqlRequestParameters requestParameters = null)
			where TResponse : class, IElasticsearchResponse, new() => DoRequest<TResponse>(POST, "_sql/translate", body, RequestParams(requestParameters));
		///<summary>POST on /_sql/translate <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/sql-translate.html</para></summary>
		///<param name = "body">Specify the query in the `query` element.</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		[MapsApi("sql.translate", "body")]
		public Task<TResponse> TranslateAsync<TResponse>(PostData body, TranslateSqlRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IElasticsearchResponse, new() => DoRequestAsync<TResponse>(POST, "_sql/translate", ctx, body, RequestParams(requestParameters));
	}
}