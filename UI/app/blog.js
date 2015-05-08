var blogApp = angular.module('blogApp', ['ngRoute', 'blogApp.controllers', 'blogApp.services', 'blogApp.directives', 'LocalStorageModule', 'ui.bootstrap']);
var blogControllers = angular.module('blogApp.controllers', []);
var blogServices = angular.module('blogApp.services', []);
var blogDirectives = angular.module('blogApp.directives', []);
blogApp.config(['$routeProvider', function ($routeProvider) {
    $routeProvider.
        when('/login', {
            templateUrl: 'views/login.html',
            controller: 'AccountController'
        }).
        when('/dashboard', {
            templateUrl: 'views/dashboard.html',
            controller: 'DashboardController'
        }).
        otherwise({
            redirectTo: '/login'
    });
}]);