(function() {
    'use strict';

    blogDirectives
        .directive('registerUser', registerUser);

    registerUser.$inject = ['$window'];
    
    function registerUser ($window) {
        // Usage:
        //     <registerUser></registerUser>
        // Creates:
        // 
        var directive = {
            link: link,
            restrict: 'E',
            templateUrl: 'views/signup.html'
        };
        return directive;

        function link(scope, element, attrs) {
           
        }
    }

})();