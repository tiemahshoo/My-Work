app.controller('RegistrationController', ['$scope', 'UserFactory', '$routeParams', '$q', '$location', function ($scope, UserDetailsFactory, $routeParams, $q, $location) {
    $scope.register = function () {
        UserDetailsFactory.register($scope.user).then(function (data) {
            $location.path("/");
        });
    };
}])