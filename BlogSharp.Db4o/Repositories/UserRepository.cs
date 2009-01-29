﻿using System.Linq;
using BlogSharp.Core.Persistence.Repositories;
using BlogSharp.Model;
using Db4objects.Db4o;

namespace BlogSharp.Db4o.Repositories
{
    public class UserRepository : Db4oRepository, IUserRepository
    {
        public UserRepository(IObjectContainerManager container)
            : base(container)
        {

        }

        #region Implementation of IUserRepository

		public Model.User GetAuthorByUsername(string username)
        {
			return container.GetContainer().Query<Model.User>(x => x.Username == username).SingleOrDefault();
        }

		public Model.User GetAuthorByEmail(string email)
        {
			return container.GetContainer().Query<Model.User>(x => x.Email == email).SingleOrDefault();
        }

		public void SaveUser(Model.User user)
        {
            SaveObject(user);
        }

		public void RemoveUser(Model.User user)
        {
            RemoveObject(user);
        }

		public Model.User GetById(int id)
    	{
			return container.GetContainer().Query<Model.User>(x => x.Id == id).SingleOrDefault();
    	}

    	#endregion
    }
}