namespace BlogSharp.Model
{
	using System;
	using System.Collections.Generic;
	using Interfaces;

	/// <summary>
	/// Represents a Post into the Blog.
	/// </summary>
	[Serializable]
	public class Post : Entity
	{
		private IList<PostComment> comments;
		private IList<Tag> tags;
		/// <summary>
		/// Initializes a new instance of the <see cref="Post" /> class. 
		/// </summary>
		public Post()
		{
			this.tags = new List<Tag>();
			this.comments = new List<PostComment>();
		}

		/// <summary>
		/// Gets or sets Title.
		/// </summary>
		public virtual string Title { get; set; }

		/// <summary>
		/// Gets or sets FriendlyTitle.
		/// </summary>
		public virtual string FriendlyTitle { get; set; }

		/// <summary>
		/// Gets or sets Tags.
		/// </summary>
		public virtual IEnumerable<Tag> Tags
		{
			get
			{
				return tags;
			}
		}


		#region Implementation of IPostable

		/// <summary>
		/// Gets or sets a value indicating whether Published.
		/// </summary>
		public virtual bool Published { get; set; }

		/// <summary>
		/// Gets or sets Blog.
		/// </summary>
		public virtual Blog Blog { get; set; }

		/// <summary>
		/// Gets or sets User.
		/// </summary>
		public virtual User Publisher { get; set; }

		/// <summary>
		/// Gets or sets DateCreated.
		/// </summary>
		public virtual DateTime DateCreated { get; set; }

		/// <summary>
		/// Gets or sets DatePublished.
		/// </summary>
		public virtual DateTime DatePublished { get; set; }

		/// <summary>
		/// Gets or sets Content.
		/// </summary>
		public virtual string Content { get; set; }

		#endregion
		
		public virtual IEnumerable<PostComment> Comments
		{
			get { return comments; }
		}

		public virtual void AddComment(PostComment comment)
		{
			if (!this.comments.Contains(comment))
			{
				this.comments.Add(comment);
				comment.Parent = this;
			}
		}
		public virtual void AddTag(Tag tag)
		{
			if (!this.tags.Contains(tag))
			{
				this.tags.Add(tag);
				tag.AddPost(this);
			}
		}
	}
}