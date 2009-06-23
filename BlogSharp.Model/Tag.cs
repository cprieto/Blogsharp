// <copyright file="Tag.cs" company="BlogSharp">
// Apache Licence 2.0 
// </copyright>
// <author>Gonzalo Brusella</author>
// <email>gonzalo@brusella.com.ar</email>
// <date>2009-02-21</date>

namespace BlogSharp.Model
{
	using System;
	using System.Collections.Generic;
	using Interfaces;

    /// <summary>
	/// A Tag into the Blog.
	/// </summary>
	[Serializable]
	public class Tag : Entity
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="Tag" /> class. 
		/// </summary>
		public Tag()
		{
			this.Posts = new List<ITaggable>();
		}

		/// <summary>
		/// Gets or sets Name.
		/// </summary>
		public virtual string Name { get; set; }

		/// <summary>
		/// Gets or sets FriendlyName.
		/// </summary>
		public virtual string FriendlyName { get; set; }

		/// <summary>
		/// Gets or sets Posts.
		/// </summary>
        public virtual IList<ITaggable> Posts { get; set; }
	}
}