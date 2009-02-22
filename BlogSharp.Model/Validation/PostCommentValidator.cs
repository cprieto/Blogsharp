// <copyright file="PostCommentValidator.cs" company="BlogSharp">
// Apache Licence 2.0 
// </copyright>
// <author>Gonzalo Brusella</author>
// <email>gonzalo@brusella.com.ar</email>
// <date>2009-02-21</date>


namespace BlogSharp.Model.Validation
{
	using FluentValidation;
	using Rules;

	/// <summary>
	/// A validaror for the PostComment Class.
	/// </summary>
	public class PostCommentValidator : ValidatorBase<PostComment>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="PostCommentValidator" /> class. 
		/// </summary>
		public PostCommentValidator()
		{
			this.RuleFor(x => x.Comment).NotEmpty();
			this.RuleFor(x => x.Email).NotEmpty().And().EmailAddress();
			this.RuleFor(x => x.Web).Url().When(x => !string.IsNullOrEmpty(x.Web));
		}
	}
}