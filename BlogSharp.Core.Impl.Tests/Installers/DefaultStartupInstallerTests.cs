﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BlogSharp.Core.Impl.Installers;
using BlogSharp.Core.Persistence.Repositories;
using BlogSharp.Model;
using Rhino.Mocks;
using Xunit;

namespace BlogSharp.Core.Impl.Tests.Installers
{
	
	public class DefaultStartupInstallerTests:BaseTest
	{
		[Fact]
		public void Executes_installer_if_there_is_no_blog()
		{
			var blogRP = MockRepository.GenerateMock<IBlogRepository>();
			var postRP = MockRepository.GenerateMock<IPostRepository>();
			var userRP = MockRepository.GenerateMock<IUserRepository>();
			blogRP.Expect(x => x.GetBlog()).Return(null);
			var installer = new DefaultStartupInstaller(blogRP,postRP,userRP);
			installer.Execute();
			blogRP.AssertWasCalled(x => x.SaveBlog(Arg<Blog>.Is.NotNull));
			userRP.AssertWasCalled(x => x.SaveUser(Arg<User>.Is.NotNull));
			postRP.AssertWasCalled(x => x.SavePost(Arg<Post>.Is.NotNull));
		}
	}
}