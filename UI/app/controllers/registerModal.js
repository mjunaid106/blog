(function () {
    'use strict';

    blogControllers
        .controller('RegisterModalController', RegisterModalController);

    RegisterModalController.$inject = ['$scope', '$location', '$modal', '$modalInstance', 'AccountService'];

    function RegisterModalController($scope, $location, $modal, $modalInstance, AccountService) {
        /* jshint validthis:true */
        var vm = this;
        vm.title = 'RegisterModalController';

        $scope.PostRegistrationRequest = PostRegistrationRequest;

        function PostRegistrationRequest() {
            AccountService.Register($scope.Username, $scope.Password).then(
                function onSuccess(response) {
                    if (response.data === 'null') {
                        $modalInstance.close("success");
                    }
                    else {
                        $modalInstance.close("error");
                    }
                }
            );
        }
    }
})();
