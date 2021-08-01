//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder.Embedded v8.14.1
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Web;
using Umbraco.Core.Models;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;
using Umbraco.ModelsBuilder.Embedded;

namespace Umbraco.Web.PublishedModels
{
	/// <summary>News List</summary>
	[PublishedModel("newsList")]
	public partial class NewsList : PublishedContentModel, IHeaderControls, IMainImageControls, ISEocontrols
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.14.1")]
		public new const string ModelTypeAlias = "newsList";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.14.1")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.14.1")]
		public new static IPublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.14.1")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<NewsList, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public NewsList(IPublishedContent content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// Page Size: Enter the page size for the page list
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.14.1")]
		[ImplementPropertyType("pageSize")]
		public virtual decimal PageSize => this.Value<decimal>("pageSize");

		///<summary>
		/// Title: Enter the title for the page. If this is empty the name of the page will be used.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.14.1")]
		[ImplementPropertyType("title")]
		public virtual string Title => global::Umbraco.Web.PublishedModels.HeaderControls.GetTitle(this);

		///<summary>
		/// Main Image: Choose the main image for this page
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.14.1")]
		[ImplementPropertyType("mainImage")]
		public virtual global::Umbraco.Core.Models.MediaWithCrops MainImage => global::Umbraco.Web.PublishedModels.MainImageControls.GetMainImage(this);

		///<summary>
		/// Meta Description: Enter the meta description for this page
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.14.1")]
		[ImplementPropertyType("metaDescription")]
		public virtual string MetaDescription => global::Umbraco.Web.PublishedModels.SEocontrols.GetMetaDescription(this);

		///<summary>
		/// Meta Keywords: Enter the keywords for this page
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.14.1")]
		[ImplementPropertyType("metaKeywords")]
		public virtual global::System.Collections.Generic.IEnumerable<string> MetaKeywords => global::Umbraco.Web.PublishedModels.SEocontrols.GetMetaKeywords(this);

		///<summary>
		/// Meta Name: Enter the meta name for this page
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.14.1")]
		[ImplementPropertyType("metaName")]
		public virtual string MetaName => global::Umbraco.Web.PublishedModels.SEocontrols.GetMetaName(this);
	}
}