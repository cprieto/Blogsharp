// <copyright file="Blog.cs" company="BlogSharp">
// Apache Licence 2.0 
// </copyright>
// <author>Gonzalo Brusella</author>
// <email>gonzalo@brusella.com.ar</email>
// <date>2009-02-21</date>


namespace BlogSharp.Model
{
	using System;
	using System.Collections.Generic;

	/// <summary>
	/// The Blog Main Class.
	/// </summary>
	[Serializable]
	public class Blog : Entity
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="Blog" /> class. 
		/// </summary>
		public Blog()
		{
			this.Writers = new List<User>();
			this.Posts = new List<Post>();
		}

		/// <summary>
		/// Gets or sets Configuration.
		/// </summary>
		public virtual BlogConfiguration Configuration { get; set; }

		/// <summary>
		/// Gets or sets Name.
		/// </summary>
		public virtual string Name { get; set; }

		/// <summary>
		/// Gets or sets Founder.
		/// </summary>
		public virtual User Founder { get; set; }

		/// <summary>
		/// Gets or sets Authors.
		/// </summary>
		public virtual IList<User> Writers { get; set; }

		/// <summary>
		/// Gets or sets Posts.
		/// </summary>
		public virtual IList<Post> Posts { get; set; }

		/// <summary>
		/// Gets or sets Title.
		/// </summary>
		public virtual string Title { get; set; }

		/// <summary>
		/// Gets or sets Host.
		/// </summary>
		public virtual string Host { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether IsInitialized.
		/// </summary>
		public virtual bool IsInitialized { get; set; }
	}
}