﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Db4objects.Db4o;

namespace BlogSharp.Db4o
{
	public class ObjectContainerComparer
	{
		public static bool AreEqual(IObjectContainer left,IObjectContainer right)
		{
			IObjectContainer leftReal;
			IObjectContainer rightReal;
			if (left is IObjectContainerProxy)
				leftReal = ((IObjectContainerProxy)left).InnerContainer;
			else
				leftReal = left;

			if (right is IObjectContainerProxy)
				rightReal = ((IObjectContainerProxy)right).InnerContainer;
			else
				rightReal = right;
			return object.ReferenceEquals(left, right);
		}
	}
}