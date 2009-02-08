﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BlogSharp.Model.Validation;
using NUnit.Framework;

namespace BlogSharp.Model.Tests.Validators
{
	[TestFixture]
	public class UserValidatorTests:ValidationTestBase<UserValidator,User>
	{
		[Test]
		public void Should_raise_error_when_Username_is_null_or_empty()
		{
			ShouldHaveErrors(x => x.Username, null);
			ShouldHaveErrors(x => x.Username, "");
		}

		[Test]
		public void Should_raise_error_when_Email_is_null_or_empty()
		{
			ShouldHaveErrors(x => x.Email, null);
			ShouldHaveErrors(x => x.Email, "");
		}

		[Test]
		public void Should_raise_error_when_Email_is_in_invalid_format()
		{
			ShouldHaveErrors(x => x.Email, "aaa");
			ShouldHaveErrors(x => x.Email, "aaa@aaa");
			ShouldHaveErrors(x => x.Email, "aaa@aaa.");
			ShouldNotHaveErrors(x => x.Email, "aaa@aaa.com");
		}

		[Test]
		public void Should_raise_error_when_Password_is_null_or_empty()
		{
			ShouldHaveErrors(x => x.Password, null);
			ShouldHaveErrors(x => x.Password, "");
		}


	}
}