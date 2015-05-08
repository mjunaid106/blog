(function () {
    'use strict';

    blogControllers
        .controller('AccountController', AccountController);

    AccountController.$inject = ['$scope', '$location', '$modal', 'AccountService', 'authService'];

    function AccountController($scope, $location, $modal, AccountService, authService) {
        /* jshint validthis:true */
        //var vm = this;
        //vm.title = 'AccountController';

        $scope.Login = Login;
        //$scope.Register = Register;
        $scope.OpenRegisterDialog = OpenRegisterDialog;
        //$scope.PostRegistrationRequest = PostRegistrationRequest;

        function Login() {
            AccountService.Login($scope.Username, $scope.Password).then(
                function onSuccess(response) {
                    if (response.data === 'null') {
                        $scope.Message = "Invalid Username or Password";
                    }
                    else {
                        $location.path("/dashboard");
                    }
                }
            );
        }

        function OpenRegisterDialog() {
            var modalInstance = $modal.open({
                templateUrl: 'views/signup.html',
                controller: 'RegisterModalController',
                backdrop: 'static',
                animate: true
            });
           
            //On close, continue.
            //modalInstance.result.then(function (status) {

            //    //On Close of Modal.
            //    if (status === "success") {
            //        console.log("Thank you for your registration request. We will be in touch shortly.");

            //    } else if (status === "error") {
            //        console.log("This service is currently unavailable. Please try again later.");
            //    }
            //});
        }

        //function Register() {
        //    AccountService.Register($scope.Username, $scope.Password).then(
        //        function onSuccess(response) {
        //            if (response.data === 'null') {
        //                $scope.Message = "Invalid Username or Password";
        //            }
        //            else {
        //                $location.path("/dashboard");
        //            }
        //        }
        //    );
        //}

        //function PostRegistrationRequest() {
        //    AccountService.Register($scope.Username, $scope.Password).then(
        //        function onSuccess(response) {
        //            if (response.data === 'null') {
        //                $scope.modalInstance.close("success");
        //            }
        //            else {
        //                $scope.modalInstance.close("error");
        //            }
        //        }
        //    );
        //}
    }
})();