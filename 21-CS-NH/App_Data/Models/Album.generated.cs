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
	/// <summary>Album</summary>
	[PublishedModel("album")]
	public partial class Album : PublishedContentModel, IHeaderControls, IMainImageControls
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.14.1")]
		public new const string ModelTypeAlias = "album";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.14.1")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.14.1")]
		public new static IPublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.14.1")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Album, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public Album(IPublishedContent content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// List Image
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.14.1")]
		[ImplementPropertyType("listImage")]
		public virtual global::System.Collections.Generic.IEnumerable<global::Umbraco.Core.Models.MediaWithCrops> ListImage => this.Value<global::System.Collections.Generic.IEnumerable<global::Umbraco.Core.Models.MediaWithCrops>>("listImage");

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
	}
}
