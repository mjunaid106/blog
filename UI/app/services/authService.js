(function () {
    'use strict';

    blogServices
        .service('authService', authService);

    authService.$inject = ['$http', 'localStorageService'];

    function authService($http, localStorageService) {
        var serviceBase = '/';
        this._saveRegistration = saveRegistration;


        function saveRegistration(registration) {
            $http.post(serviceBase + 'api/account/PostUser', registration)
                .then(function (reponse) {
                    return reponse;
                });
        }
    }
})();