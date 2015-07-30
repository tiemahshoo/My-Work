app.factory('UserFactory', ['$http', '$q', function ($http, $q) {
    var o = {};

    o.register = function (user) {
        var defer = $q.defer();
        var config = { contentType: 'application/json' };
        $http.post('/api/Account/Register/', user, config).success(function (data) {
            defer.resolve(data)
        });
        return defer.promise;
    };

    o.setToken = function (token) {
        localStorage.setItem('token', token);
    };

    o.getToken = function () {
        return localStorage.getItem('token');
    };

    o.removeToken = function () {
        localStorage.removeItem('token');
    };

    o.login = function (user) {
        var q = $q.defer();
        $http.post('/Token', 'username=' + user.username + '&password=' + user.password + '&grant_type=password', { contentType: 'application/x-www-form-urlencoded' }).success(function (data) {
            o.setToken(data.access_token);
        }).error(function (data) {
            q.reject(data.error_description);
        });
        return q.promise;
    };

    o.logout = function () {
        o.removeToken();
        o.status.roles.length = 0;
    };

    o.status = {};
    o.status.roles = [];
    o.status.isLoggedIn = (o.getToken()) ? true : false;
    if (o.status.isLoggedIn) o.getRoles();

    return o;
}]);