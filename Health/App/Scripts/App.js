var app = app || angular.module('HealthApp', ['ngRoute']);

app.config(['$routeProvider', '$httpProvider', function ($routeProvider, $httpProvider) {
    $routeProvider.when('/', {
        templateUrl: 'App/Scripts/Views/Home.html'
    }).when('/register', {
        templateUrl: 'App/Scripts/Views/register.html'
    }).when('/login', {
        templateUrl: 'App/Scripts/Views/Login.html'
    }).when('/UserPage', {
        templateUrl: 'App/Scripts/Views/UserPage.html'
    }).otherwise({ redirectTo: '/' });

 $httpProvider.interceptors.push('AuthFactory');
    
}]);