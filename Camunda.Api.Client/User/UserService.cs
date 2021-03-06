﻿namespace Camunda.Api.Client.User
{
    public class UserService
    {
        private IUserRestService _api;

        internal UserService(IUserRestService api) { _api = api; }

        public QueryResource<UserQuery, UserInfo> Query(UserQuery query = null) =>
            new QueryResource<UserQuery, UserInfo>(_api, query);

        /// <param name="userId">The id of the user to be retrieved.</param>
        public UserResource this[string userId] => new UserResource(_api, userId);
    }
}
