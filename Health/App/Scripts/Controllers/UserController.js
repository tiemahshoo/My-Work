app.controller('UserController', ['$scope', 'UserFactory', '$location', function ($scope, UserFactory, $location) {
    $scope.user = {};

    $scope.login = function (user) {
        UserFactory.login(user).then(function () {
            //success then
            $location.path('/');
        }, function (data) {
            //fail then
            $scope.message = data;
        });
    };
}]);