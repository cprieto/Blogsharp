// <copyright file="PostComment.cs" company="BlogSharp">
// Coypyleft 2009 Apache Licence 2.0 
// </copyright>
// <author>Gonzalo Brusella</author>
// <email>gonzalo@brusella.com.ar</email>
// <date>2009-02-21</date>

namespace BlogSharp.Model
{
	using System;
	using Interfaces;

	/// <summary>
	/// Represents a Comment to an entry.
	/// </summary>
	[Serializable]
	public class PostComment : Entity
	{
		/// <summary>
		/// Gets or sets Post.
		/// </summary>
		public ICommentable Post { get; set; }

		/// <summary>
		/// Gets or sets Comment.
		/// </summary>
		public string Comment { get; set; }

		/// <summary>
		/// Gets or sets Email.
		/// </summary>
		public string Email { get; set; }

		/// <summary>
		/// Gets or sets Name.
		/// </summary>
		public string Name { get; set; }

        /// <summary>
        /// Gets or sets the commentor. 
        /// This is a registered user comment (such as the blog owner).
        /// </summary>
        public User Commentor { get; set; }

		/// <summary>
		/// Gets or sets Web.
		/// </summary>
		public string Web { get; set; }

		/// <summary>
		/// Gets or sets Date.
		/// </summary>
		public DateTime Date { get; set; }
	}
}