app.controller('UserController', ['$scope', 'UserFactory', '$location', function ($scope, UserFactory, $location) {
    $scope.user = {};

    $scope.login = function (user) {
        UserFactory.login(user).then(function () {
            $location.path('/');
        }, function (data) {
            $scope.message = data;
        });
    };
    $scope.logout = function () {
        UserFactory.logout();
    };
}]);