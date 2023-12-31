﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemplateRESTful.Persistence.Data.Actions;

namespace TemplateRESTful.Persistence.Data.Containers
{
    public class UserActionsContainer<T> : IUserActions<T> where T : class
    {
        private IList<T> UserAction { get; }

        public UserActionsContainer()
        {
            UserAction = new List<T>();
        }

        public IList<T> Get()
        {
            return UserAction;
        }

        public IList<T> Read()
        {
            var userActions = new List<T>(UserAction);
            UserAction.Clear();
            return userActions;
        }

        public void Add(T action)
        {
            UserAction.Add(action);
        }

        public void Clear()
        {
            UserAction.Clear();
        }
    }
}
